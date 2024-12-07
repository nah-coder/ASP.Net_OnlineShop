using Model.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ProductCategoryDao
    {
        OnlineShopDBContext db = null;
        public ProductCategoryDao() {
            db = new OnlineShopDBContext();
        }

        public List<ProductCategory> GetAll()
        {
            return db.ProductCategories.Where(x=>x.Status==true).OrderBy(x=>x.DisplayOrder).ToList();
        }
    }
}
