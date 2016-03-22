using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
   /// <summary>
   /// 服务评论
   /// </summary>
    public class commentsServer
    {
        public int InsertComments(comments comm)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.comments.InsertOnSubmit(comm);
                db.SubmitChanges();
                return comm.commID;
            }
            catch
            {
                return 0;
            }
        }
        public int DeleteCommentByCommID(int CommId)
        {
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
            var comment = from c in db.comments where c.commID == CommId select c;
            if (comment.Count() > 0)
            {
                db.comments.DeleteAllOnSubmit(comment);
                count = db.comments.Where(c => c.commID == CommId).Count();

            }
            return count;
        }
        public IList<comments> GetComment()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<comments> comm = from c in db.comments select c;
            if (comm != null)
            {
                return comm.ToList<comments>();
            }
            else
            {
                return new List<comments>();
            }
        }
        public comments GetComment(int commID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.comments.Count() > 0)
            {
                var comm = db.comments.Single(c => c.commID == commID);
                return comm;
            }
            else
            {
                return null;
            }
        }
    }
}