using OnlineStore.Website.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.Areas.Account.ViewModels
{
    public class SignUpViewModel
    {
        [Required(ErrorMessageResourceName = "EmailRequired", ErrorMessageResourceType = typeof(Resources.Resource))]
        [RegularExpression(".+@.+\\..+", ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "EmailInvalid")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "PasswordRequired", ErrorMessageResourceType = typeof(Resources.Resource))]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resources.Resource))]
        [StringLength(64, ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "PasswordSizeError", MinimumLength = 8)]
        public string Password { get; set; }

        [Required(ErrorMessageResourceName = "ConfirmPasswordRequired", ErrorMessageResourceType = typeof(Resources.Resource))]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Resource))]
        [StringLength(64, ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "PasswordSizeError", MinimumLength = 8)]
        [Compare("Password" , ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "ConfirmPasswordInvalid")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "PhoneNumberRequired")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resources.Resource))]
        [RegularExpression(@"^(\+)(\d{12})$", ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "PhoneNumberInvalid")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "LanguageRequired")]
        [Display(Name = "Language", ResourceType = typeof(Resources.Resource))]
        public string LanguageId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "NameRequired")]
        [Display(ResourceType = typeof(Resources.Resource), Name = "Name")]
        [StringLength(100, ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "NameSizeError", MinimumLength = 1)]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "SurnameRequired")]
        [Display(ResourceType = typeof(Resources.Resource), Name = "Surname")]
        [StringLength(150, ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "SurnameSizeError", MinimumLength = 1)]
        public string Surname { get; set; }

        [Display(ResourceType = typeof(Resources.Resource), Name = "Patronymic")]
        [StringLength(150, ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "PatronymicSizeError", MinimumLength = 0)]
        public string Patronymic { get; set; }

        [Display(ResourceType = typeof(Resources.Resource), Name = "ImageFilename")]
        [StringLength(250, ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "ImageFilenameSizeError", MinimumLength = 0)]
        [DataType(DataType.Upload)]
        public string ImageFilename { get; set; }

        public List<LanguageViewModel> Languages { get; set; }
    }
}