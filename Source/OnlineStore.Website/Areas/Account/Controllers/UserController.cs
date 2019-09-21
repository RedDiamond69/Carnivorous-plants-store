using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using OnlineStore.Logic.Interfaces;
using OnlineStore.Model.DTO;
using OnlineStore.Website.Areas.Account.ViewModels;
using OnlineStore.Website.ViewModels;
using OnlineStore.Website.Extensions;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Website.Areas.Account.Controllers
{
    public class UserController : Controller
    {
        private readonly IAuthenticationManager _authenticationManager;
        private readonly IAccountService _accountService;
        private readonly ILanguageService _languageService;
        private readonly IMapper _mapper;

        public UserController(IAuthenticationManager authenticationManager, IAccountService accountService,
            IMapper mapper, ILanguageService languageService)
        {
            _authenticationManager = authenticationManager;
            _languageService = languageService;
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult SignIn(string returnUrl = "/home/")
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new SignInViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SignIn(SignInViewModel model, string returnUrl = "/home/")
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<ApplicationUserDTO>(model);
                ClaimsIdentity claim = await _accountService.AuthenticateAsync(user);
                if (claim == null)
                {
                    ModelState.AddModelError("", Resources.Resource.EmailOrPasswordInvalid);
                }
                else
                {
                    if(await _accountService.IsEmailConfirmedAsync(claim.GetUserId()))
                    {
                        _authenticationManager.SignOut();
                        _authenticationManager.SignIn(new AuthenticationProperties
                        {
                            IsPersistent = model.RememberMe
                        }, claim);
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        var emailConfirmationToken = await _accountService.GenerateEmailConfirmationTokenAsync(claim.GetUserId());
                        var confirmationUrl = Url.Action("confirmemail", "user",
                            new { userId = claim.GetUserId(), code = emailConfirmationToken },
                            protocol: Request.Url.Scheme);
                        var body = new HtmlString($"<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\">" +
                            $"<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\">" +
                            $"<meta http-equiv=\"X - UA - Compatible\" content=\"ie = edge\">" +
                            $"<style>.bg-light{{background: whitesmoke;}}body{{font-family: -apple-system, BlinkMacSystemFont, " +
                            $"'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', " +
                            $"sans-serif;}}.text-center{{text-align: center;}}div{{display: flex; flex-direction: column; " +
                            $"justify-content: center;}}p{{font-size: 1.5em;}}.btn{{background: rgb(70, 73, 255); " +
                            $"color: white; height: 30px; width: 250px; border-radius: 5px; padding-top: 0.5em; " +
                            $"margin: 0.5em auto 0.5em auto; text-decoration: none; font-size: 1.2em;}}</style>" +
                            $"</head><body><div class=\"div bg - light text - center\">" +
                            $"<div><p>{Resources.Resource.EmailConfirmationBody}</p></div>" +
                            $"<a href=\"{confirmationUrl}\" class=\"btn\">{Resources.Resource.ConfirmEmail}</a>" +
                            $"</div></body></html>").ToHtmlString();

                        await _accountService.SendEmailAsync(claim.GetUserId(), Resources.Resource.EmailConfirmationSubject, body);
                        return View("ConfirmEmail");
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult SignUp(string returnUrl = "/home/")
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new SignUpViewModel() { Languages = _languageService.GetAll().Select(l => _mapper.Map<LanguageViewModel>(l)).ToList() });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SignUp(SignUpViewModel model, HttpPostedFileBase file, string returnUrl = "/home/")
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<ApplicationUserDTO>(model);
                user.ApplicationUserProfile = _mapper.Map<ApplicationUserProfileDTO>(model);
                if (file is null)
                {
                    user.ApplicationUserProfile.ImageFilename = "default-profile.svg";
                    user.Role = "Customer";
                    var result = await _accountService.CreateAsync(user);
                    if (result.Succedeed)
                    {
                        var newUser = await _accountService.GetByEmailAsync(user.Email);
                        var emailConfirmationToken = await _accountService.GenerateEmailConfirmationTokenAsync(newUser.Id);
                        var confirmationUrl = Url.Action("confirmemail", "user",
                            new { userId = newUser.Id, code = emailConfirmationToken },
                            protocol: Request.Url.Scheme);
                        var body = new HtmlString($"<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\">" +
                            $"<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\">" +
                            $"<meta http-equiv=\"X - UA - Compatible\" content=\"ie = edge\">" +
                            $"<style>.bg-light{{background: whitesmoke !important;}}" +
                            $"body{{font-family: -apple-system, BlinkMacSystemFont, " +
                            $"'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', " +
                            $"sans-serif !important;}}.text-center{{text-align: center !important;}}" +
                            $"div{{display: flex !important; flex-direction: column !important; " +
                            $"justify-content: center !important;}}p{{font-size: 1.5em !important;}}" +
                            $".btn{{background: rgb(70, 73, 255) !important; " +
                            $"color: white !important; height: 30px !important; width: 250px !important; " +
                            $"border-radius: 5px !important; padding-top: 0.5em !important; " +
                            $"margin: 0.5em auto 0.5em auto !important; text-decoration: none !important; " +
                            $"font-size: 1.2em !important;}}</style>" +
                            $"</head><body><div class=\"div bg - light text - center\">" +
                            $"<div><p>{Resources.Resource.EmailConfirmationBody}</p></div>" +
                            $"<a href=\"{confirmationUrl}\" class=\"btn\">{Resources.Resource.ConfirmEmail}</a>" +
                            $"</div></body></html>").ToHtmlString();

                        await _accountService.SendEmailAsync(newUser.Id, Resources.Resource.EmailConfirmationSubject, body);
                        return View("ConfirmEmail");
                    }
                    else
                    {
                        ModelState.AddModelError("Email", Resources.Resource.UserExist);
                    }
                }
                else
                {
                    if (file.IsImage())
                    {
                        user.Role = "Customer";
                        string imageFilename = Guid.NewGuid().ToString() + "." + file.FileName.Split('.').Last();
                        user.ApplicationUserProfile.ImageFilename = imageFilename;
                        var result = await _accountService.CreateAsync(user);
                        if (result.Succedeed)
                        {
                            string path = Path.Combine(Server.MapPath("~/AppUsersData"), imageFilename);
                            file.SaveAs(path);
                            var newUser = await _accountService.GetByEmailAsync(user.Email);
                            var emailConfirmationToken = await _accountService.GenerateEmailConfirmationTokenAsync(newUser.Id);
                            var confirmationUrl = Url.Action("confirmemail", "user",
                                new { userId = newUser.Id, code = emailConfirmationToken },
                                protocol: Request.Url.Scheme);
                            var body = new HtmlString($"<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\">" +
                            $"<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\">" +
                            $"<meta http-equiv=\"X - UA - Compatible\" content=\"ie = edge\">" +
                            $"<style>.bg-light{{background: whitesmoke !important;}}" +
                            $"body{{font-family: -apple-system, BlinkMacSystemFont, " +
                            $"'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', " +
                            $"sans-serif !important;}}.text-center{{text-align: center !important;}}" +
                            $"div{{display: flex !important; flex-direction: column !important; " +
                            $"justify-content: center !important;}}p{{font-size: 1.5em !important;}}" +
                            $".btn{{background: rgb(70, 73, 255) !important; " +
                            $"color: white !important; height: 30px !important; width: 250px !important; " +
                            $"border-radius: 5px !important; padding-top: 0.5em !important; " +
                            $"margin: 0.5em auto 0.5em auto !important; text-decoration: none !important; " +
                            $"font-size: 1.2em !important;}}</style>" +
                            $"</head><body><div class=\"div bg - light text - center\">" +
                            $"<div><p>{Resources.Resource.EmailConfirmationBody}</p></div>" +
                            $"<a href=\"{confirmationUrl}\" class=\"btn\">{Resources.Resource.ConfirmEmail}</a>" +
                            $"</div></body></html>").ToHtmlString();

                            await _accountService.SendEmailAsync(newUser.Id, Resources.Resource.EmailConfirmationSubject, body);
                            return View("ConfirmEmail");
                        }
                        else
                        {
                            ModelState.AddModelError("Email", Resources.Resource.UserExist);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFilename", Resources.Resource.IsNotImage);
                    }
                }
            }
            model.Languages = _languageService.GetAll().Select(l => _mapper.Map<LanguageViewModel>(l)).ToList();
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var result = await _accountService.ConfirmEmailAsync(userId, code);
            if (result.Succedeed)
            {
                return View("ConfirmSucceded");
            }
            return View("Error");
        }

        [HttpGet]
        [Authorize]
        public ActionResult Logout()
        {
            _authenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}
