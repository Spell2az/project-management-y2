using System.Web;
using System.Web.Optimization;

namespace ManagementApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles
                .Add(new ScriptBundle("~/bundles/jquery")
                    .Include("~/Scripts/jquery-{version}.js", "~/Content/src/vendor/jquery-easing/jquery.easing.js"));

            bundles
                .Add(new ScriptBundle("~/bundles/jqueryval")
                .Include("~/Scripts/jquery.validate*"));

            bundles
                .Add(new ScriptBundle("~/bundles/datatables")
                .Include("~/Content/src/vendor/datatables/jquery.dataTables.js", "~/Content/src/vendor/datatables/dataTables.bootstrap4.js"));
            bundles
                .Add(new ScriptBundle("~/bundles/chart.js")
                    .Include("~/Content/src/vendor/chart.js/Chart.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles
                .Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-*"));

            bundles
                .Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Content/src/vendor/bootstrap/js/bootstrap.js"));

            bundles
                .Add(new StyleBundle("~/Content/css")
                .Include("~/Content/src/vendor/datatables/dataTables.bootstrap4.css", "~/Content/Site.css"));
        }
    }
}
