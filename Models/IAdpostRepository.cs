using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_abd.Models
{
    public interface IAdpostRepository
    {
        void save(adpost ad);
        void Edit(adpost ad);
        List<adpost> Show_Data();
        adpost Adpost_Data(int id);
        void Delete_obj(adpost ad);
        void Dispose();
        List<adpost> Showmy_Ads(int id);
        List<adpost> index_data();
        adpost get_data(string type);
        
    }
}
