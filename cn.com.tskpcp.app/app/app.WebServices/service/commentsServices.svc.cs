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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“commentsServices”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 commentsServices.svc 或 commentsServices.svc.cs，然后开始调试。
    /// <summary>
    /// 服务评论
    /// </summary>
    public class commentsServices : IcommentsServices,commentsInterface
    {

       public  string InsertComments(string comment)
        {
            comments com = JSONHelper.JsonDeserialize_JsonTo<comments>(comment);
            int returnValue= InsertComments(com);
            if (returnValue == 0)
            {
                return JSONHelper.GetError(returnValue.ToString());
            }
            else
            {
                return JSONHelper.GetSuccess(returnValue.ToString());
            }
        }

        public string GetComments(string commID)
        {
            if (commID == "" || commID.Equals(string.Empty))
            {
                return JSONHelper.ObjectToJson<comments>("comments", GetComment());
            }
            else
            {
                return JSONHelper.JsonSerializer_to_Json<comments>(GetComment(int.Parse(commID)));
            }
        }


        private static readonly commentsServer cs = new commentsServer();
        public int InsertComments(comments comm)
        {
            try {
                return cs.InsertComments(comm);
            }
            catch {
                return 0;
            }
        }

        public IList<comments> GetComment()
        {
            try {
                return cs.GetComment();
            }
            catch {
                return null;
            }
        }

        public comments GetComment(int commID)
        {
            try {
                return cs.GetComment(commID);
            }
            catch {
                return null;
            }
        }
    }
}
