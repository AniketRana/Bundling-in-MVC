using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;


namespace BundlingAndMinificationInMVC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            //var bundle = new ScriptBundle("~/Content/js");

            //bundle.Include("~/content/JS/Javascript1.js",
            //    "~/content/JS/Javascript2.js",
            //    "~/content/JS/Javascript3.js",
            //    "~/content/JS/Javascript4.js",
            //    "~/content/JS/Javascript5.js");

            //bundles.Add(bundle);

            bundles.Add(new ScriptBundle("~/bundles/JS")
                .IncludeDirectory("~/Content/JS", "*.js"));

            bundles.Add(new ScriptBundle("~/bundles/CSS")
                .IncludeDirectory("~/Content/Style", "*.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}