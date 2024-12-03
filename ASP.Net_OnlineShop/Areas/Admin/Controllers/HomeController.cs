using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Net_OnlineShop.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}