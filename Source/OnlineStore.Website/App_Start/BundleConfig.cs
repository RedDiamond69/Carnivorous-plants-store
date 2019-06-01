using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace OnlineStore.Website
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.bundle.js",
                        "~/Scripts/scripts*"));

            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Style.css",
                      "~/Content/PagedList.css"));
        }
    }
}