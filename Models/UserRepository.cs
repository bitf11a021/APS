using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;


namespace APS_abd.Models
{
    public class UserRepository : IUserRepository
    {
        public void save(user u)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                db.users.Add(u);
                db.SaveChanges();
                  
            }
        }
        public bool CheckUserName(string u)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                try
                {
                    var q = db.users.First(x => x.UserName == u);
                    if (q != null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;

                    }
                }
                catch(Exception e){
                    return true;
                }
                
            }
        }
        public List<user> Show_Data()
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                return db.users.ToList();
            }
        }
        public user User_Data(int id)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                try
                {
                    return db.users.Find(id);
                }
                catch(Exception e)
                {
                    return null;
                }
            }
        }
        public void Edit(user u)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                db.Entry(u).State = System.Data.EntityState.Modified;
               
                db.SaveChanges();
            }
        }
        public void Remove(user u)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                //var dd = from x in db.users
                //         where x == u
                //         select x;
                //user aa = (user)dd;
                db.users.Remove(u);
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
        public user First(string username, string password)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                try
                {
                    return db.users.First(x => x.UserName.Equals(username) && x.Password.Equals(password));
                }
                catch(Exception e){
                    return null;
                }
            }
        }
    }
}