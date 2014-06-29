using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APS_abd.Models
{
    public class AdpostRepository : IAdpostRepository
    {
        public void save(adpost u)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                db.adposts.Add(u);
                db.SaveChanges();

            }
        }
        public List<adpost> Show_Data()
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                return db.adposts.ToList();
            }
        }
        public adpost Adpost_Data(int id)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {

                var ad = db.adposts.Find(id);
               
                return ad;
            }
        }
        public void Edit(adpost u)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                db.Entry(u).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void Delete_obj(adpost u)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                db.adposts.Remove(u);
               db.SaveChanges();
            }
        }
        public void Dispose()
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                db.Dispose();
            }
        }
        public List<adpost> Showmy_Ads(int id)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                var q = from x in db.adposts
                        where x.Uid == id
                        select x;
                return q.ToList();

            }
        }
        public List<adpost> index_data()
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                return db.adposts.ToList();
            }
        }
        public adpost get_data(string type)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                var list = from val in db.adposts
                           where val.subcategory == type
                           select val;
                return list.First();
            }
        }

    }
}