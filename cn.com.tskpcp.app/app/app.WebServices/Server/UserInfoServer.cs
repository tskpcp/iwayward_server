using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace app.WebServices.Server
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserInfoServer
    {
        
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string InsertUserInfo(UserInfo user)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.UserInfo.InsertOnSubmit(user);
                db.SubmitChanges();
                return user.userID;
            }
            catch
            {
                return string.Empty; ;
            }
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        public IList<UserInfo> GetUserInfo()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<UserInfo> userInfo = from c in db.UserInfo select c;
            if (userInfo != null)
            {
                return userInfo.ToList<UserInfo>();
            }
            else
            {
                return new List<UserInfo>();
            }
        }
       /// <summary>
       /// 根据UserId获取用户信息
       /// </summary>
       /// <param name="userID"></param>
       /// <returns></returns>
        public UserInfo GetUserInfo(string userID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.UserInfo.Count() > 0)
            {
                var user = db.UserInfo.Single(c => c.userID == userID);
                return user;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 根据UserId修改用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string UpdateUserInfoByUserID(UserInfo user) {
            iwaywardDataContext db = new iwaywardDataContext();
            try { 
                var result=(from item in db.UserInfo where item.userID==user.userID select item).Single();
                result.userName = user.userName;
                result.age = user.age;
                result.sex = user.sex;
                result.headUrl = user.headUrl;
                result.nickName = user.nickName;
                result.region = user.region;
                result.city = user.city;
                result.province = user.province;
                result.mail = user.mail;
                result.qqNo = user.qqNo;
                result.sinaID = user.sinaID;
                result.tengID = user.tengID;
                result.weixinID = user.weixinID;
                result.weixinName = user.weixinName;
                result.weixinTwo = user.weixinTwo;
                result.professional = user.professional;
                result.industry = user.industry;
                result.position = user.position;
                result.erweima = user.erweima;
                result.zhuceTime = user.zhuceTime;
                result.qianming = user.qianming;
                db.SubmitChanges();
                return result.userID;

            }
            catch {
                return string.Empty;
            }
        }
        //根据UserID删除用户信息
        public int DeleteUserInfoByUserID(string userID)
        {
            int count =0;
            iwaywardDataContext db = new iwaywardDataContext();
            var user = from c in db.UserInfo where c.userID == userID select c;
            if (user.Count() > 0)
            {
                db.UserInfo.DeleteAllOnSubmit(user);
                count = db.UserInfo.Where(c => c.userID == userID).Count();

            }
            return count;
        }
    }
}