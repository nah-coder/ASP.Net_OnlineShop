using Model.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ProductDao
    {
        OnlineShopDBContext db = null;
        public ProductDao()
        {
            db = new OnlineShopDBContext();
        }

        public List<Product> ListByCategoryId(long id) { 
            return db.Products.Where(x=>x.CategoryID == id).ToList();
        }
        public List<Product> GetAll(int top)
        {
            return db.Products.Where(x => x.Status == true).OrderByDescending(x=>x.CreateDate).Take(top).ToList();
        }

        public List<Product> ListFeature(int top)
        {
            return db.Products.Where(x => x.TopHot != null && x.TopHot > DateTime.Now&& x.Status==true).OrderByDescending(x => x.CreateDate).Take(top).ToList();
        }

        public Product ViewDetail(long id)
        {
            return db.Products.Find(id);
        }
    }
}
