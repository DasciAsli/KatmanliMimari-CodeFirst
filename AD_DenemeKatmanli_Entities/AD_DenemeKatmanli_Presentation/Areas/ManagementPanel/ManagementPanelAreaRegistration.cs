﻿using System.Web.Mvc;

namespace AD_DenemeKatmanli_Presentation.Areas.ManagementPanel
{
    public class ManagementPanelAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ManagementPanel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ManagementPanel_default",
                "ManagementPanel/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}