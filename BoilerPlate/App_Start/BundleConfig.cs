using System.Web;
using System.Web.Optimization;

namespace BoilerPlate
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            //add sb admin 2 js 
            bundles.Add(new ScriptBundle("~/bundles/sbadmin").Include(
                        "~/Scripts/sb-admin-2.js"));

            //add a bundle for the chart library
            bundles.Add(new ScriptBundle("~/bundles/chart").Include(
                        "~/Scripts/Chart.js"));


            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      "~/Content/bootstrap.css"));

            //add sb admin 2 css
            bundles.Add(new StyleBundle("~/Content/sbadmin2").Include(
                      "~/Content/all.css", 
                      "~/Content/sb-admin-2.css"));

        }
    }
}
