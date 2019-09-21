using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.Areas.Account.ViewModels
{
    public class SignInViewModel
    {
        [Required(ErrorMessageResourceName = "EmailRequired", ErrorMessageResourceType = typeof(Resources.Resource))]
        [RegularExpression(".+@.+\\..+", ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "EmailInvalid")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "PasswordRequired", ErrorMessageResourceType = typeof(Resources.Resource))]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resources.Resource))]
        [StringLength(64, ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "PasswordSizeError", MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "RememberMe", ResourceType = typeof(Resources.Resource))]
        public bool RememberMe { get; set; }
    }
}