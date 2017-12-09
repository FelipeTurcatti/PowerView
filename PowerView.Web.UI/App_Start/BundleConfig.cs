using System.Web;
using System.Web.Optimization;

namespace PowerView.Web.UI
{
    /// <summary>
    /// Bundle configuration
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// Bundles registering
        /// </summary>
        ///<remarks>
        ///For more information see http://go.microsoft.com/fwlink/?LinkId=301862
        ///</remarks>        
        /// <param name="bundles">Bundle collection.-</param>        
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/bower_components/jquery/dist/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/bower_components/jquery-validation/dist/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            "~/bower_components/jquery-ui/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/bundles/d3").Include(
            "~/bower_components/rickshaw/vendor/d3.v3.js"));

            bundles.Add(new ScriptBundle("~/bundles/rickshaw").Include(
            "~/bower_components/rickshaw/rickshaw.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/bower_components/bootstrap/dist/js/bootstrap.min.js",
                      "~/bower_components/respond/dest/respond.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/bower_components/metisMenu/dist/metisMenu.min.css",
                      "~/Content/timeline.css",
                      "~/Content/Site.css",
                      "~/Content/sb-admin-2.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
               "~/bower_components/jquery-ui/themes/base/jquery-ui.css"
            ));

            bundles.Add(new ScriptBundle("~/Content/rickshaw/css")
                .IncludeDirectory("~/bower_components/rickshaw/src/css", "*.css", true));          
        }
    }
}
