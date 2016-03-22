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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“PersonnelRealtionshipServices”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 PersonnelRealtionshipServices.svc 或 PersonnelRealtionshipServices.svc.cs，然后开始调试。
    /// <summary>
    /// 人员关系
    /// </summary>
    public class PersonnelRealtionshipServices : IPersonnelRealtionshipServices, PersonnelRealtionshipInterface
    {


        public string InsertAttentionIndustry(string perRe)
        {
            PersonnelRelationship com = JSONHelper.JsonDeserialize_JsonTo<PersonnelRelationship>(perRe);
            int returnValue = IInsertPersonnelRealtionship(com);
            if (returnValue == 0)
            {
                return JSONHelper.GetError(returnValue.ToString());
            }
            else
            {
                return JSONHelper.GetSuccess(returnValue.ToString());
            }
        }

        public string GetPersonnelRelationship(string UserId)
        {
            if (UserId == "" || UserId.Equals(string.Empty))
            {
                return JSONHelper.ObjectToJson<PersonnelRelationship>("personnel", IGetPersonnelRelationship());
            }
            else
            {
                return JSONHelper.JsonSerializer_to_Json<PersonnelRelationship>(IGetPersonnelRelationship(UserId));
            }
        }

        public string DeletePersonnelRelationshipByUserID(string userID)
        {
            int returnValue = IDeletePersonnelRelationshipByUserID(userID);
            if (returnValue == 0)
            {
                return JSONHelper.GetError(returnValue.ToString());
            }
            else
            {
                return JSONHelper.GetSuccess(returnValue.ToString());
            };
        }

        private static readonly PersonnelRealtionshipServer prs = new PersonnelRealtionshipServer();
        public int IInsertPersonnelRealtionship(PersonnelRelationship perRe)
        {
            try {
                return prs.InsertPersonnelRealtionship(perRe);
            }
            catch {
                return 0;
            }
        }

        public IList<PersonnelRelationship> IGetPersonnelRelationship()
        {
            try {
                return prs.GetPersonnelRelationship();
            }
            catch {
                return null;
            }
        }

        public PersonnelRelationship IGetPersonnelRelationship(string UserId)
        {
            try {
                return prs.GetPersonnelRelationship(UserId);
            }
            catch {
                return null;
            }
        }

        public int IDeletePersonnelRelationshipByUserID(string userID)
        {
            try {
                return prs.DeletePersonnelRelationshipByUserID(userID);
            }
            catch {
                return 0;
            }
        }
    }
}
