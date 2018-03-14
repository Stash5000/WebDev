using System.Web;
using System.Web.Mvc;

namespace Week_4_Lab_Joey_Dias
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
