using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
    /// <summary>
    /// 简历表
    /// </summary>
    public class resumeServer
    {
        /// <summary>
        /// 添加简历信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string InsertResume(resume r)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.resume.InsertOnSubmit(r);
                db.SubmitChanges();
                return r.resumeID.ToString();
            }
            catch
            {
                return string.Empty; 
            }
        }
        /// <summary>
        /// 获取简历信息
        /// </summary>
        /// <returns></returns>
        public IList<resume> GetResume()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<resume> r = from c in db.resume select c;
            if (r != null)
            {
                return r.ToList<resume>();
            }
            else
            {
                return new List<resume>();
            }
        }
        /// <summary>
        /// 根据resumeId获取简历信息
        /// </summary>
        /// <param name="resumeId"></param>
        /// <returns></returns>
        public resume GetResume(int resumeId)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.resume.Count() > 0)
            {
                var r = db.resume.Single(c => c.resumeID == resumeId);
                return r;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 根据resumeId修改简历信息
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public string UpdatResumeByResumeID(resume r)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                var result = (from item in db.resume where item.resumeID == r.resumeID select item).Single();
                result.resumeID = r.resumeID;
                result.userID = r.userID;
                result.jobState = r.jobState;
                result.resumeState = r.resumeState;
                result.myEdu = r.myEdu;
                result.jobYear = r.jobYear;
                result.toAddress = r.toAddress;
                result.industry = r.industry;
                result.position = r.position;
                result.salary = r.salary;
                result.research = r.research;
                result.jobID = r.jobID;
                result.projectID = r.projectID;
               
                db.SubmitChanges();
                return result.resumeID.ToString();

            }
            catch
            {
                return string.Empty;
            }
        }
        //根据resumeId删除简历信息
        public int DeleteResumeByResumeID(int resumeId) 
        {
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
            var user = from c in db.resume where c.resumeID == resumeId select c;
            if (user.Count() > 0)
            {
                db.resume.DeleteAllOnSubmit(user);
                count = db.resume.Where(c => c.resumeID == resumeId).Count();

            }
            return count;
        }
    }
}