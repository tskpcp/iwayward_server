using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using app.WebClient.Model;
namespace app.WebClient.Server
{
    public class commentsServer
    {
        public int InsertComments(comments comm)
        {
            commentsDataContext db = new commentsDataContext();
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
            commentsDataContext db = new commentsDataContext();
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
            commentsDataContext db = new commentsDataContext();
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
            commentsDataContext db = new commentsDataContext();
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