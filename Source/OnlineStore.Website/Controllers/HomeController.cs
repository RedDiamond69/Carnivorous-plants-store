using AutoMapper;
using OnlineStore.Logic.Interfaces;
using OnlineStore.Website.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IArticleService _articleService;
        private readonly ILanguageService _languageService;
        private readonly IProviderService _providerService;
        private readonly IContactService _contactService;
        private readonly IStockService _stockService;
        private readonly IMapper _mapper;

        public HomeController(ICategoryService categoryService, IProductService productService, 
            IArticleService articleService, ILanguageService languageService, IProviderService providerService, 
            IMapper mapper, IContactService contactService, IStockService stockService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _articleService = articleService;
            _languageService = languageService;
            _providerService = providerService;
            _contactService = contactService;
            _stockService = stockService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var categories = _categoryService.GetAll().Select(c => {
                var cvm = _mapper.Map<CategoryViewModel>(c);
                cvm.Products = _productService.Find(p 
                    => p.CategoryId == c.CategoryId).Take(3).Select(p => {
                        var pvm = _mapper.Map<ProductViewModel>(p);
                        pvm.Provider = _mapper.Map<ProviderViewModel>(_providerService.Get(p.ProviderId));
                        return pvm;
                    }).ToList();
                cvm.Articles = _articleService.Find(a
                    => a.CategoryId == c.CategoryId).Take(3).Select(a => _mapper.Map<ArticleViewModel>(a)).ToList();
                return cvm;
            }).ToList();
            var contacts = _contactService.GetAll().Select(c => _mapper.Map<ShopContactViewModel>(c)).FirstOrDefault();
            var languages = _languageService.GetAll().Select(l => _mapper.Map<LanguageViewModel>(l)).ToList();
            var stocks = _stockService.Find(s => s.IsActive).Select(s => _mapper.Map<StockViewModel>(s)).Take(3).ToList();
            return View(new HomePageViewModel() { Languages = languages, Categories = categories, Contacts = contacts, Stocks = stocks });
        }

        [HttpGet]
        public ActionResult ChangeCulture(string lang)
        {
            string returnUrl = Request.UrlReferrer.AbsolutePath;
            var cultures = _languageService.GetAll().Select(l => l.LanguageCode).ToList();
            if (!cultures.Contains(lang))
            {
                lang = "ru";
            }
            HttpCookie cookie = Request.Cookies["lang"];
            if (cookie != null)
                cookie.Value = lang;
            else
            {
                cookie = new HttpCookie("lang");
                cookie.HttpOnly = false;
                cookie.Value = lang;
                cookie.Expires = DateTime.UtcNow.AddYears(1);
            }
            Response.Cookies.Add(cookie);
            return Redirect(returnUrl);
        }
    }
}
