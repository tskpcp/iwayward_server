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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“AttentionIndustryService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 AttentionIndustryService.svc 或 AttentionIndustryService.svc.cs，然后开始调试。
    //关注行业
    public class AttentionIndustryService : IAttentionIndustryService, AttentionIndustryInterface
    {

        public string InsertAttentionIndustry(string attentionData)
        {
            AttentionIndustry ai = JSONHelper.JsonDeserialize_JsonTo<AttentionIndustry>(attentionData);
            int returnValue=IInsertAttentionIndustry(ai);
            if (returnValue==0)
            {
                return JSONHelper.GetError(returnValue.ToString());
            }
            else
            {
                return JSONHelper.GetSuccess(returnValue.ToString());
            }
        }

        public string GetAttentionIndustry(string userID)
        {
            if (userID == "" || userID.Equals(string.Empty))
            {
                return JSONHelper.ObjectToJson<AttentionIndustry>("attention", IGetAttentionIndustry());
            }
            else {
                return JSONHelper.JsonSerializer_to_Json<AttentionIndustry>(IGetAttentionIndustry(userID));
            }
        }

        public  string UpdateAttentionIndustryfoByUserID(string attentionData)
        {
            AttentionIndustry attention = JSONHelper.JsonDeserialize_JsonTo<AttentionIndustry>(attentionData);
            int returnValue = IUpdateAttentionIndustryfoByUserID(attention);
            if (returnValue==0)
            {
                return JSONHelper.GetError(returnValue.ToString());
            }
            else
            {
                return JSONHelper.GetSuccess(returnValue.ToString());
            };
        }

        public string DeleteAttentionIndustryByUserID(string userID)
        {
            int returnValue = IDeleteAttentionIndustryByUserID(userID);
            if(returnValue==0){
                return JSONHelper.GetError(returnValue.ToString());
            }
            else
            {
                return JSONHelper.GetSuccess(returnValue.ToString());
            }
        }


        private static readonly AttentionIndustryServer ais = new AttentionIndustryServer();
        public int IInsertAttentionIndustry(AttentionIndustry attInd)
        {
            try {
                return ais.InsertAttentionIndustry(attInd);
            }
            catch {
                return 0;
            }
        }

        public IList<AttentionIndustry> IGetAttentionIndustry()
        {
            try {
                return ais.GetAttentionIndustry();
            }
            catch {
                return null;
             }
        }

        public AttentionIndustry IGetAttentionIndustry(string UserId)
        {
            try {
                return ais.GetAttentionIndustry(UserId);
            }
            catch {
                return null;
            }
        }

        public int IUpdateAttentionIndustryfoByUserID(AttentionIndustry attInd)
        {
            try {
                return ais.UpdateAttentionIndustryfoByUserID(attInd);
            }
            catch {
                return 0;
            }
        }

        public int IDeleteAttentionIndustryByUserID(string userID)
        {
            try {
                return ais.DeleteAttentionIndustryByUserID(userID);
            }
            catch {
                return 0;
            }
        }
    }
}
