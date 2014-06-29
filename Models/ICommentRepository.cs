using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_abd.Models
{
    public interface ICommentRepository
    {
        void save_comment(comment_mng c);
        List<comment_mng> show_data(int id);

    }
}
