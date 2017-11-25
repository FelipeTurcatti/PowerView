using System.Web;
using System.Web.Mvc;

namespace PowerView.Web.UI
{
    /// <summary>
    /// Filter registration
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Filter registering.-
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
