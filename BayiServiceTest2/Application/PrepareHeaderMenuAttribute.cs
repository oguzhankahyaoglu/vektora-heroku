﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace BayiServiceTest2.Application
{
    /// <summary>
    /// Üst menüdeki kategori ağacını bağlar.
    /// Ayrıca, birden fazla fiyat listesi seçip seçemeyeceğini set eder.
    /// </summary>
    public class PrepareHeaderMenuAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //var selectedPriceList = Sessions.Ctx?.SelectedPriceList;
            //if (filterContext.HttpContext.Request.IsAjaxRequest() || selectedPriceList == null)
            //{
            //    base.OnActionExecuted(filterContext);
            //    return;
            //}

            //if (filterContext.Result is ViewResult viewResult)
            //{
            //    viewResult.ViewData["Categories"] = ServiceCaller.CallVenüsBayi(ws => ws.GetCategoriesAsync(ServiceCaller.AuthToken));
            //}
            base.OnActionExecuted(filterContext);
        }
    }
}