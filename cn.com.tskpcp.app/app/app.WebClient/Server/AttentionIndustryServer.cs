using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using app.WebClient.Model;
namespace app.WebClient.Server
{
    public class AttentionIndustryServer
    {
        public int InsertAttentionIndustry(AttentionIndustry attInd)
        {
            AttentionIndustryDataContext db = new AttentionIndustryDataContext();
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
            AttentionIndustryDataContext db = new AttentionIndustryDataContext();
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
            AttentionIndustryDataContext db = new AttentionIndustryDataContext();
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
            AttentionIndustryDataContext db = new AttentionIndustryDataContext();
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
            AttentionIndustryDataContext db = new AttentionIndustryDataContext();
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