using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
    /// <summary>
    /// 招聘职位表
    /// </summary>
    public class positionInfoServer
    {
        public int InsertPositionInfo(positionInfo post)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.positionInfo.InsertOnSubmit(post);
                db.SubmitChanges();
                return int.Parse(post.posID.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public IList<positionInfo> GetPositionInfo()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<positionInfo> attInd = from c in db.positionInfo select c;
            if (attInd != null)
            {
                return attInd.ToList<positionInfo>();
            }
            else
            {
                return null;
            }
        }
        public IList<positionInfo> GetListPositionInfo(int posID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<positionInfo> attInd = from c in db.positionInfo where c.posID == posID select c;
            if (attInd != null)
            {
                return attInd.ToList<positionInfo>();
            }
            else
            {
                return null;
            }
        }
        public positionInfo GetPositionInfo(int posID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.positionInfo.Count() > 0)
            {
                var user = db.positionInfo.Single(c => c.posID == posID);
                return user;
            }
            else
            {
                return null;
            }
        }

        public int UpdatePositionInfoByJobID(positionInfo post)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                var result = (from item in db.positionInfo where item.posID == post.posID select item).Single();
                result.posID = post.posID;
                result.userID = post.userID;
                result.companyID = post.companyID;
                result.posName = post.posName;
                result.createTime = post.createTime;
                result.region = post.region;
                result.city = post.city;
                result.province = post.province;
                result.record = post.record;
                result.recruitment = post.recruitment;
                result.range = post.range;
                result.posstate = post.posstate;
                result.posType = post.posType;
                result.requirements = post.requirements;
                db.SubmitChanges();
                return int.Parse(result.posID.ToString());

            }
            catch
            {
                return 0;
            }
        }

        public int DeletePositionInfoByJobID(int posID)
        {
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
            var user = from c in db.positionInfo where c.posID == posID select c;
            if (user.Count() > 0)
            {
                db.positionInfo.DeleteAllOnSubmit(user);
                count = db.positionInfo.Where(c => c.posID == posID).Count();

            }
            return count;
        }
    }
}