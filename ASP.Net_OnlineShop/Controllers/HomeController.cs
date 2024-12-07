using Model.Dao;
using Model.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Net_OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Slides = new SlideDao().Slides();
            //var productdao = new ProductDao();
            //ViewBag.NewProduct = productdao.GetAll(10);
            //ViewBag.ListFeatureProduct = productdao.ListFeature(10);
            ViewBag.NewProduct = new ProductDao().GetAll(10);
            ViewBag.ListFeatureProduct = new ProductDao().ListFeature(10);
            return View();
        }
        [ChildActionOnly]
        public ActionResult MainMenu()
        {
            var model = new MenuDao().ListByGroupId(1);
            return PartialView(model);
        }
        
        [ChildActionOnly]
        public ActionResult TopMenu()
        {
            var model = new MenuDao().ListByGroupId(2);
            return PartialView(model);
        }

        [ChildActionOnly]
        public ActionResult Footer()
        {
            var model = new FooterDao().GetFooter();
            return PartialView(model);
        }
    }
}