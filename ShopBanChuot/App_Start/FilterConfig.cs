﻿using System.Web;
using System.Web.Mvc;

namespace ShopBanChuot
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new System.Web.Mvc.AuthorizeAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
