using Model.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class SlideDao
    {
        OnlineShopDBContext db = null;
        public SlideDao() {
            db = new OnlineShopDBContext();
        }

        public List<Slide> Slides()
        {
            return db.Slides.Where(x => x.Status == true).OrderBy(x=>x.DisplayOrder).ToList();
        }
    }
}
