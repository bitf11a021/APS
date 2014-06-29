using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APS_abd.Models
{
    public class CommentRepository : ICommentRepository
    {
        public void save_comment(comment_mng c)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                db.comment_mng.Add(c);
                db.SaveChanges();
            }
        }
        public List<comment_mng> show_data(int id)
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
               // List<comment_mng> dd=db.comment_mng.SqlQuery("select * from comment_mng where Id=id").ToList();
                var dd = from x in db.comment_mng
                         where x.Id == id
                         select x;
                return dd.ToList();
            }
        }
    }
}