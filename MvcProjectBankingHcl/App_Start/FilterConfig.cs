using System.Web;
using System.Web.Mvc;

namespace MvcProjectBankingHcl
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
