using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Net_OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(long id)
        {
            var product = new ProductDao().ViewDetail(id);
            return View(product);
        }

        public ActionResult Category(long id)
        {
            var category = new CategoryDao().ViewDetail(id);
            ViewBag.Category = category;
            var model = new ProductDao().ListByCategoryId(id);
            return View(model);
        }
        [ChildActionOnly]
        public PartialViewResult ProductCategory()
        {
            var model = new ProductCategoryDao().GetAll();
            return PartialView(model);
        }

        
    }
}