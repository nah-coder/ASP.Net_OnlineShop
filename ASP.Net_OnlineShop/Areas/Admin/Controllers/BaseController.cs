using ASP.Net_OnlineShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.Net_OnlineShop.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (UserLogin)Session[CommonConstant.USER_SESSION];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new { Controller = "Login", action = "Index", Area = "Admin" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}