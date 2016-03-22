using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
    
    /// <summary>
    /// 地区表
    /// </summary>
    public class regionTableServer
    {
        public int InsertRegionTable(regionTable comp)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.regionTable.InsertOnSubmit(comp);
                db.SubmitChanges();
                return int.Parse(comp.regionID.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public IList<regionTable> GetRegionTable()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<regionTable> attInd = from c in db.regionTable select c;
            if (attInd != null)
            {
                return attInd.ToList<regionTable>();
            }
            else
            {
                return null;
            }
        }
        public IList<regionTable> GetListRegionTable(int regionID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<regionTable> attInd = from c in db.regionTable where c.regionID == regionID select c;
            if (attInd != null)
            {
                return attInd.ToList<regionTable>();
            }
            else
            {
                return null;
            }
        }
        public regionTable GetRegionTable(int regionID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.regionTable.Count() > 0)
            {
                var user = db.regionTable.Single(c => c.regionID == regionID);
                return user;
            }
            else
            {
                return null;
            }
        }

        public int UpdateRegionTableByComId(regionTable post)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                var result = (from item in db.regionTable where item.regionID == post.regionID select item).Single();
                result.regionID = post.regionID;
                result.provinceID = post.provinceID;
                result.provinceName = post.provinceName;
                result.cityID = post.cityID;
                result.cityName = post.cityName;
                result.regionName = post.regionName;
                

                db.SubmitChanges();
                return int.Parse(result.regionID.ToString());

            }
            catch
            {
                return 0;
            }
        }

        public int DeleteRegionTableByComId(int regionID)
        {
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
            var user = from c in db.regionTable where c.regionID == regionID select c;
            if (user.Count() > 0)
            {
                db.regionTable.DeleteAllOnSubmit(user);
                count = db.regionTable.Where(c => c.regionID == regionID).Count();

            }
            return count;
        }
    }
}