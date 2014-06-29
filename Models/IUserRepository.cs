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
    public interface IUserRepository
    {
         void save(user usr);
         bool CheckUserName(string user);
         List<user> Show_Data();
         user User_Data(int id);
         void Edit(user usr);
         void Remove(user usr);
         void Dispose();
         user First(string username, string password);
    }
}
