using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APS_abd.Models
{
    public class AdminRepository : IAdminRepository
    {
        public bool CheckUserName(string u, string pwd)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                var q = db.admins.First(x => x.UserName == u && x.Password == pwd);
                if (q != null)
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }
        }

        public List<adpost> show_ads()
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                try
                {
                    return db.adposts.ToList();
                }
                catch(Exception e)
                {
                    return null;
                }
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
        public adpost Adpost_Data(int id)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                try
                {
                    var ad = db.adposts.Find(id);

                    return ad;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public admin First(string username, string password)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                try
                {
                    return db.admins.First(x => x.UserName.Equals(username) && x.Password.Equals(password));
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}