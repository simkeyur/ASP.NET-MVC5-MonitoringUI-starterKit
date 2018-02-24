using System.Web;
using System.Web.Optimization;

namespace MonitoringSuite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Content/js/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/js/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/js/bootstrap.min.js",
                      "~/Content/js/respond.js"));
            
            //MorrisChartsJS
            bundles.Add(new ScriptBundle("~/bundles/js/morrisCharts").Include(
                      "~/Scripts/plugins/morris/morris.min.js",
                      "~/Scripts/plugins/morris/raphael.min.js"));

            //AngularJS
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Content/js/angular.js"));

            //Angular Controller
            bundles.Add(new ScriptBundle("~/angular/drilldown-controller").Include(
                      "~/Scripts/controller/drilldown.js"));

            //Bootstrap CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/monitoring.css",
                      "~/Content/css/site.css"));

            //MorrisCharts CSS
            bundles.Add(new StyleBundle("~/Content/css/morrisCharts").Include(
                      "~/Content/css/plugins/morris.css"));

            //FontAwesome CSS
            bundles.Add(new StyleBundle("~/Content/css/fontAwesome").Include(
                      "~/Content/font-awesome.min.css",
                      "~/Content/css/plugins/flag-icon.min.css"));
        }
    }
}
