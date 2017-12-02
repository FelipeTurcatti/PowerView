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
                        "~/bower_components/jquery/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/bower_components/jquery-validation/dist/jquery.validate*"));

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
                      "~/Content/sb-admin-2.css"));
        }
    }
}
