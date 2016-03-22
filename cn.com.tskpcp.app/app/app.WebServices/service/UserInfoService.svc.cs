using app.WebServices.Interface;
using app.WebServices.Model;
using app.WebServices.Server;
using app.WebServices.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace app.WebServices.service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“UserInfoService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 UserInfoService.svc 或 UserInfoService.svc.cs，然后开始调试。
    public class UserInfoService : IUserInfoService,UserInfoInterface
    {
       
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        public string InserUserInfoService(string userData)
        {

            int IntTemp = GetRandNumUserID();
            StringBuilder tempUser = new StringBuilder(userData);
            string strTemp ="{"+string.Format("\"userID\":\"{0}\"", IntTemp.ToString())+",";
            tempUser.Replace("{", strTemp);
            UserInfo user = JSONHelper.JsonDeserialize_JsonTo<UserInfo>(tempUser.ToString());
            tempUser.Clear();
            string returnValue=InserUserInfo(user);
            if (returnValue.Equals(string.Empty))
            {
                return JSONHelper.GetError(returnValue.ToString());
            }
            else {
                return JSONHelper.GetSuccess(returnValue.ToString());
            }

        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public string GetUserInfoService(string userData)
        {

            if (userData == null || userData.Equals("") || userData.Equals(string.Empty))
            {
                return JSONHelper.ObjectToJson<UserInfo>("user", GetUser());
            } else {
                return JSONHelper.JsonSerializer_to_Json<UserInfo>(GetUser(userData));
            }

        }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        public string UpdateUserInfoService(string userData)
        {
            UserInfo user = JSONHelper.JsonDeserialize_JsonTo<UserInfo>(userData);
            string returnValue=UpdateUserInfoByUserID(user);
            if (returnValue.Equals(string.Empty))
            {
                return JSONHelper.GetError(returnValue.ToString());
            }
            else
            {
                return JSONHelper.GetSuccess(returnValue.ToString());
            } 
        }




        private static readonly UserInfoServer us = new UserInfoServer(); 
        public string InserUserInfo(UserInfo user)
        {

            try
            {
                return us.InsertUserInfo(user);
            }
            catch (NotImplementedException e)
            {

                e.GetBaseException();
                return string.Empty;
            }

        }

        public IList<UserInfo> GetUser()
        {
            try
            {
                return us.GetUserInfo();
            }
            catch (NotImplementedException e)
            {

                e.GetBaseException();
                return null;
            }
        }

        public UserInfo GetUser(string userID)
        {
            try
            {

                return us.GetUserInfo(userID);
            }
            catch (NotImplementedException e)
            {

                e.GetBaseException();
                return null;
            }
        }

        public string UpdateUserInfoByUserID(UserInfo user)
        {
            try
            {

                return us.UpdateUserInfoByUserID(user);
            }
            catch (NotImplementedException e)
            {

                e.GetBaseException();
                return string.Empty;
            }
        }

        public int DeleteUserInfoByUserID(string userID)
        {
            try
            {
                return us.DeleteUserInfoByUserID(userID);
            }
            catch (NotImplementedException e)
            {

                e.GetBaseException();
                return 0;
            }
        }

        private int GetRandNumUserID() {
            int IntUserId = 0;
            int.TryParse(Utility.Common.GetRandNum(8), out IntUserId);
            return IntUserId;
        }

    }
}
