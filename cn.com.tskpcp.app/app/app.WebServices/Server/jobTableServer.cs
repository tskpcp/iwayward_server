using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
    /// <summary>
    /// 工作经历表
    /// </summary>
    public class jobTableServer
    {
        public int InsertJobTable(jobTable job)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.jobTable.InsertOnSubmit(job);
                db.SubmitChanges();
                return int.Parse(job.jobID.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public IList<jobTable> GetJobTable()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<jobTable> attInd = from c in db.jobTable select c;
            if (attInd != null)
            {
                return attInd.ToList<jobTable>();
            }
            else
            {
                return null;
            }
        }
        public IList<jobTable> GetListJobTable(int jobID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<jobTable> attInd = from c in db.jobTable where c.jobID == jobID select c;
            if (attInd != null)
            {
                return attInd.ToList<jobTable>();
            }
            else
            {
                return null;
            }
        }
        public jobTable GetJobTable(int jobID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.jobTable.Count() > 0)
            {
                var user = db.jobTable.Single(c => c.jobID == jobID);
                return user;
            }
            else
            {
                return null;
            }
        }

        public int UpdateJobTableByJobID(jobTable job)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                var result = (from item in db.jobTable where item.jobID == job.jobID select item).Single();
                result.jobID = job.jobID;
                result.userID = job.userID;
                result.companyID = job.companyID;
                result.position = job.position;
                result.beginTime = job.beginTime;
                result.endTime = job.endTime;
                result.describe = job.describe;
                
                db.SubmitChanges();
                return int.Parse(result.jobID.ToString());

            }
            catch
            {
                return 0;
            }
        }

        public int DeleteJobTableByJobID(int jobID)
        {
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
            var user = from c in db.jobTable where c.jobID == jobID select c;
            if (user.Count() > 0)
            {
                db.jobTable.DeleteAllOnSubmit(user);
                count = db.jobTable.Where(c => c.jobID == jobID).Count();

            }
            return count;
        }
    }
}