using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace app.WebServices.service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IindustryServices”。
   //行业操作
    [ServiceContract]
    public interface IindustryServices
    {
        [OperationContract]
        string GetIndustry(string indID);

         [OperationContract]
        string GetIndustryIlistChild(string indID);

         [OperationContract]
        string GetChildIndustry(string childId);

    }
}
