using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
   /// <summary>
   /// 行业表
   /// </summary>
    public class industryServer
    {
        public int InsertIndustry(industry ind)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.industry.InsertOnSubmit(ind);
                db.SubmitChanges();
                return int.Parse(ind.IndID.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public IList<industry> GetIndustry()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<industry> attInd = from c in db.industry select c;
            if (attInd != null)
            {
                return attInd.ToList<industry>();
            }
            else
            {
                return null;
            }
        }
        public IList<industry> GetIndustryIlistChild(int indID) {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<industry> attInd = from c in db.industry where c.IndID == indID select c;
            if (attInd != null)
            {
                return attInd.ToList<industry>();
            }
            else {
                return null;
            }
        }
        public industry GetIndustry(int indID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.industry.Count() > 0)
            {
                var user = db.industry.Single(c => c.IndID == indID);
                return user;
            }
            else
            {
                return null;
            }
        }
        public industry GetChildIndustry(int childId) {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.industry.Count() > 0)
            {
                var industry = db.industry.Single(c => c.IndChildID == childId);
                return industry;
            }
            else {
                return null;
            }
        }
        public int UpdateIndustryfoByIndID(industry ind)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                var result = (from item in db.industry where item.IndID == ind.IndID select item).Single();
                result.IndName = ind.IndName;
                result.IndChildID = ind.IndChildID;
                result.IndChildName = ind.IndChildName;
                db.SubmitChanges();
                return int.Parse(result.IndID.ToString());

            }
            catch
            {
                return 0;
            }
        }

        public int DeleteIndustryByIndID(int indID)
        {
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
            var user = from c in db.industry where c.IndID==indID select c;
            if (user.Count() > 0)
            {
                db.industry.DeleteAllOnSubmit(user);
                count = db.industry.Where(c => c.IndID==indID).Count();

            }
            return count;
        }
    }
}