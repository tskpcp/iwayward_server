using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
    /// <summary>
    /// 信息匹配
    /// </summary>
    public class servicepipeiServer
    {
        
        /// <summary>
        /// 计算匹配内容 带修改
        /// </summary>
        /// <param name="perRe"></param>
        /// <returns></returns>
        public int InsertServicepipei(servicepipei perRe)
        {
         /*1获取用户服务信息
          *2获取用户关注领域
          *3搜索服务信息
          *4存入此表
          */
            
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.servicepipei.InsertOnSubmit(perRe);
                db.SubmitChanges();
                return int.Parse(perRe.UserID.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public IList<servicepipei> GetServicepipei()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<servicepipei> attInd = from c in db.servicepipei select c;
            if (attInd != null)
            {
                return attInd.ToList<servicepipei>();
            }
            else
            {
                return new List<servicepipei>();
            }
        }

        public servicepipei GetServicepipei(string UserId)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.servicepipei.Count() > 0)
            {
                var user = db.servicepipei.Single(c => c.UserID == UserId);
                return user;
            }
            else
            {
                return null;
            }
        }
       
        /// <summary>
        /// 删除匹配信息 待修改
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public int DeleteServicepipeiByUserID(string userID)
        {
  
            /*1根据此表ID搜索服务表
             *如果没有删除
             *2根据此表服务获取行业ID，根据UserID获取关注ID，如果匹配 保留，如果不匹配删除
            */
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
            var user = from c in db.servicepipei where c.UserID == userID select c;
            if (user.Count() > 0)
            {
                db.servicepipei.DeleteAllOnSubmit(user);
                count = db.servicepipei.Where(c => c.UserID == userID).Count();

            }
            return count;
        }
    }
}