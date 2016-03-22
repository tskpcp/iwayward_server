using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
   /// <summary>
   /// 用户信息
   /// </summary>
    public interface UserInfoInterface
    {
        string InserUserInfo(UserInfo user);
        IList<UserInfo> GetUser();
        UserInfo GetUser(string userID);
        string UpdateUserInfoByUserID(UserInfo user);
        int DeleteUserInfoByUserID(string userID);


    }
}
