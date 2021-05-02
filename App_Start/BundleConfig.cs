using System.Web;
using System.Web.Optimization;

namespace FootballLeague
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            //Register page
            bundles.Add(new ScriptBundle("~/bundles/football/register").Include(
                "~/Scripts/football/register.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            
            //Modernizr
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/footballScripts").Include("~/Scripts/football/jquery.min.js",
                "~/Scripts/football/jquery.scrollex.min.js", "~/Scripts/football/jquery.scrolly.min.js",
                "~/Scripts/football/main.js", "~/Scripts/football/skel.min.js", "~/Scripts/football/util.js"));

            bundles.Add( new StyleBundle("~/Content/footballCss").Include("~/Content/football/font-awesome.min.css","~/Content/football/main.css"));
        }
    }
}
