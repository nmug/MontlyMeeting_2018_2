﻿using System.Web;
using System.Web.Mvc;

namespace Ef6DatabaseFirstUsingEfPocoGenerator
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
