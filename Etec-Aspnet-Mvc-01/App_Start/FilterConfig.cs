using System.Web;
using System.Web.Mvc;

namespace Etec_Aspnet_Mvc_01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
