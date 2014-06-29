using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_abd.Models
{
    public interface IAdminRepository
    {
        bool CheckUserName(string user,string pwd);
        List<adpost> show_ads();
        adpost Adpost_Data(int id);
        void Delete_obj(adpost ad);
        admin First(string username, string password);
    }
}
