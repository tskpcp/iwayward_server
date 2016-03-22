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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“industryServices”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 industryServices.svc 或 industryServices.svc.cs，然后开始调试。
    /// <summary>
    /// 行业表
    /// </summary>
    public class industryServices : IindustryServices, industryInterface
    {

        string IindustryServices.GetIndustry(string indID)
        {
            if (indID == "" || indID.Equals(string.Empty))
            {
                return JSONHelper.ObjectToJson<industry>("industry", GetIndustry());
            }
            else
            {
                return JSONHelper.JsonSerializer_to_Json<industry>(GetIndustry(int.Parse(indID)));
            }
        }


        public string GetIndustryIlistChild(string indID)
        {
            return JSONHelper.ObjectToJson<industry>("industryChild", GetIndustryIlistChild(int.Parse(indID)));
        }

        public string GetChildIndustry(string childId)
        {
            return JSONHelper.JsonSerializer_to_Json<industry>(GetChildIndustry(int.Parse(childId)));
        }


        private static readonly industryServer inds = new industryServer();
        public IList<industry> GetIndustry()
        {
            try {
                return inds.GetIndustry();
            }
            catch {
                return null;
            }
        }

        public industry GetIndustry(int indID)
        {
            try {
                return inds.GetIndustry(indID);
            }
            catch {
                return null;
            }
        }

        public IList<industry> GetIndustryIlistChild(int indID)
        {
            try {
                return inds.GetIndustryIlistChild(indID);
            }
            catch {
                return null;
            }
        }

        public industry GetChildIndustry(int childId)
        {
            try {
                return inds.GetChildIndustry(childId);
            }
            catch {
                return null;
            }
        }
    }
}
