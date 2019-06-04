using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Website.App_Start
{
    public partial class AutofacConfig
    {
        public void ConfigurationAuth(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/account/user/signin"),
                LogoutPath = new PathString("/account/user/logout"),
                ReturnUrlParameter = "returnUrl"
            });
        }
    }
}