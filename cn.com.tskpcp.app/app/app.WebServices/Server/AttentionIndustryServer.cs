using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
    
    /// <summary>
    /// 关注行业
    /// </summary>
    public class AttentionIndustryServer
    {

        public int InsertAttentionIndustry(AttentionIndustry attInd)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.AttentionIndustry.InsertOnSubmit(attInd);
                db.SubmitChanges();
                return int.Parse(attInd.UserID.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public IList<AttentionIndustry> GetAttentionIndustry()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<AttentionIndustry> attInd = from c in db.AttentionIndustry select c;
            if (attInd != null)
            {
                return attInd.ToList<AttentionIndustry>();
            }
            else
            {
                return new List<AttentionIndustry>();
            }
        }

        public AttentionIndustry GetAttentionIndustry(string UserId)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.AttentionIndustry.Count() > 0)
            {
                var user = db.AttentionIndustry.Single(c => c.UserID == UserId);
                return user;
            }
            else
            {
                return null;
            }
        }

        public int UpdateAttentionIndustryfoByUserID(AttentionIndustry attInd)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                var result = (from item in db.AttentionIndustry where item.UserID == attInd.UserID select item).Single();
                result.IndMark1 = attInd.IndMark1;
                result.IndMark2 = attInd.IndMark2;
                result.IndMark3 = attInd.IndMark3;
                db.SubmitChanges();
                return int.Parse(result.UserID.ToString());

            }
            catch
            {
                return 0;
            }
        }

        public int DeleteAttentionIndustryByUserID(string userID)
        {
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
            var user = from c in db.AttentionIndustry where c.UserID == userID select c;
            if (user.Count() > 0)
            {
                db.AttentionIndustry.DeleteAllOnSubmit(user);
                count = db.AttentionIndustry.Where(c => c.UserID == userID).Count();

            }
            return count;
        }
    }
}