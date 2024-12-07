using Model.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ContentDao
    {
        OnlineShopDBContext db = null;

        public ContentDao()
        {
            db = new OnlineShopDBContext();
        }

        public Content GetById(long id)
        {
            return db.Contents.Find(id);
        }
    }
}
