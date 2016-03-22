using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
    
    /// <summary>
    /// 公司信息表
    /// </summary>
    public class companyTableServer
    {
        public int InsertCompanyTable(companyTable comp)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.companyTable.InsertOnSubmit(comp);
                db.SubmitChanges();
                return int.Parse(comp.companyID.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public IList<companyTable> GetCompanyTable()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<companyTable> attInd = from c in db.companyTable select c;
            if (attInd != null)
            {
                return attInd.ToList<companyTable>();
            }
            else
            {
                return null;
            }
        }
        public IList<companyTable> GetListCompanyTable(int companyID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<companyTable> attInd = from c in db.companyTable where c.companyID == companyID select c;
            if (attInd != null)
            {
                return attInd.ToList<companyTable>();
            }
            else
            {
                return null;
            }
        }
        public companyTable GetCompanyTable(int companyID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.companyTable.Count() > 0)
            {
                var user = db.companyTable.Single(c => c.companyID == companyID);
                return user;
            }
            else
            {
                return null;
            }
        }

        public int UpdateCompanyTableByComId(companyTable post)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                var result = (from item in db.companyTable where item.companyID == post.companyID select item).Single();
                result.companyID = post.companyID;
                result.userID = post.userID;
                result.companyName = post.companyName;
                result.companyType = post.companyType;
                result.companyCount = post.companyCount;
                result.describe = post.describe;
               
                db.SubmitChanges();
                return int.Parse(result.companyID.ToString());

            }
            catch
            {
                return 0;
            }
        }

        public int DeleteCompanyTableByComId(int companyID)
        {
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
            var user = from c in db.companyTable where c.companyID == companyID select c;
            if (user.Count() > 0)
            {
                db.companyTable.DeleteAllOnSubmit(user);
                count = db.companyTable.Where(c => c.companyID == companyID).Count();

            }
            return count;
        }
    }
}