using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace app.WebServices.service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IServiceInformationServices”。
    [ServiceContract]
    public interface IServiceInformationServices
    {
        [OperationContract]
        string InsertServiceInformation(string serInfDate);
         [OperationContract]
        string GetServiceInformation();
         [OperationContract]
         string GetServiceInformation(string serInfDate);
         [OperationContract]
         string UpdateServiceInformationBuIndID(string serInfDate);
         [OperationContract]
         string DeleteServiceInformationByIndID(string serInfDate);
    }
}
