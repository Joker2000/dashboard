using System.Web;
using System.Web.Optimization;

namespace Dashboard.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(
                new ScriptBundle("~/bundles/gentelella").Include(
                    "~/Scripts/gentelella/nprogress.js",
                    "~/Scripts/gentelella/gauge.min.js",
                    "~/Scripts/gentelella/gauge_demo.js",
                    "~/Scripts/gentelella/chart.min.js",
                    "~/Scripts/gentelella/bootstrap-progressbar.min.js",
                    "~/Scripts/gentelella/jquery.nicescroll.min.js",
                    "~/Scripts/gentelella/icheck.min.js",
                    "~/Scripts/gentelella/moment.min.js",
                    "~/Scripts/gentelella/daterangepicker.js",
                    "~/Scripts/gentelella/custom.js",
                    "~/Scripts/gentelella/jquery.flot.js",
                    "~/Scripts/gentelella/jquery.flot.pie.js",
                    "~/Scripts/gentelella/jquery.flot.orderBars.js",
                    "~/Scripts/gentelella/jquery.flot.time.min.js",
                    "~/Scripts/gentelella/date.js",
                    "~/Scripts/gentelella/jquery.flot.spline.js",
                    "~/Scripts/gentelella/jquery.flot.stack.js",
                    "~/Scripts/gentelella/curvedLines.js",
                    "~/Scripts/gentelella/jquery.flot.resize.js",
                    "~/Scripts/gentelella/jquery-jvectormap-2.0.3.min.js",
                    "~/Scripts/gentelella/gdp-data.js",
                    "~/Scripts/gentelella/jquery-jvectormap-world-mill-en.js",
                    "~/Scripts/gentelella/jquery-jvectormap-us-aea-en.js",
                    "~/Scripts/gentelella/pace.min.js",
                    "~/Scripts/gentelella/skycons.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(
                new StyleBundle("~/Content/gentelella").Include(
                    "~/Content/lib/gentelella/animate.min.css",
                    "~/Content/lib/gentelella/font-awesome.css",
                    "~/Content/lib/gentelella/custom.css",
                    "~/Content/lib/gentelella/jquery-jvectormap-2.0.3.css",
                    "~/Content/lib/gentelella/green.css",
                    "~/Content/lib/gentelella/floatexamples.css"));
        }
    }
}
