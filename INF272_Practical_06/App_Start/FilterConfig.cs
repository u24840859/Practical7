﻿using System.Web;
using System.Web.Mvc;

namespace INF272_Practical_06
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
