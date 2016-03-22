using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace app.WebServices.service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IservicepipeiServices”。
    [ServiceContract]
    public interface IservicepipeiServices
    {
        [OperationContract]
        string InsertServicepipei(string perRe);

         [OperationContract]
        string GetServicepipei();

         [OperationContract]
        string GetServicepipei(string UserId);
         [OperationContract]
        string UpdateServicepipeifoByUserID(string attInd);
         [OperationContract]
        string DeleteServicepipeiByUserID(string userID);
    }
}
