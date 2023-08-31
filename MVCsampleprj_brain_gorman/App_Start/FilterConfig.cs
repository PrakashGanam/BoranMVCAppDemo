using System.Web;
using System.Web.Mvc;

namespace MVCsampleprj_brain_gorman
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
