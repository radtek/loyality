﻿using System.Web.Mvc;

namespace Vtb24.Arms.Catalog
{
    public class CatalogAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Catalog";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Catalog_default",
                "Catalog/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
