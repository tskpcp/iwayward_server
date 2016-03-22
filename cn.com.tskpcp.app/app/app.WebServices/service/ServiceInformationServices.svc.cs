using app.WebServices.Interface;
using app.WebServices.Model;
using app.WebServices.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace app.WebServices.service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“ServiceInformationServices”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 ServiceInformationServices.svc 或 ServiceInformationServices.svc.cs，然后开始调试。
    /// <summary>
    /// 信息服务
    /// </summary>
    public class ServiceInformationServices : IServiceInformationServices, ServiceInformationInterface
    {

        string InsertServiceInformation(string serInfDate)
        {
            throw new NotImplementedException();
        }

        string GetServiceInformation()
        {
            throw new NotImplementedException();
        }

        string GetServiceInformation(string serInfDate)
        {
            throw new NotImplementedException();
        }

        string UpdateServiceInformationBuIndID(string serInfDate)
        {
            throw new NotImplementedException();
        }

        string DeleteServiceInformationByIndID(string serInfDate)
        {
            throw new NotImplementedException();
        }
        private static readonly ServiceInformationServer sis = new ServiceInformationServer();
        public int IInsertServiceInformation(ServiceInformation serInf)
        {
            try {
                return sis.InsertServiceInformation(serInf);
            }
            catch {
                return 0;
            }
        }

        public IList<ServiceInformation> IGetServiceInformation()
        {
            try {
                return sis.GetServiceInformation();
            }
            catch {
                return null;
            }
        }

        public ServiceInformation IGetServiceInformation(int ServiceID, string UserID)
        {
            try {
                return sis.GetServiceInformation(ServiceID, UserID);
            }
            catch {
                return null;
            }
        }

        public int IUpdateServiceInformationBuIndID(ServiceInformation serviceInformation)
        {
            try {
                return sis.UpdateServiceInformationBuIndID(serviceInformation);
            }
            catch {
                return 0;
            }
        }

        public int IDeleteServiceInformationByIndID(int ServiceId)
        {
            try {
                return sis.DeleteServiceInformationByIndID(ServiceId);
            }
            catch {
                return 0;
            }
        }


        public IList<ServiceInformation> IGetServiceInformationforUserId(string UserID)
        {
            try
            {
                return sis.GetServiceInformationforUserId(UserID);
            }
            catch
            {
                return null;
            }
        }

        string IServiceInformationServices.InsertServiceInformation(string serInfDate)
        {
            throw new NotImplementedException();
        }

        string IServiceInformationServices.GetServiceInformation()
        {
            throw new NotImplementedException();
        }

        string IServiceInformationServices.GetServiceInformation(string serInfDate)
        {
            throw new NotImplementedException();
        }

        string IServiceInformationServices.UpdateServiceInformationBuIndID(string serInfDate)
        {
            throw new NotImplementedException();
        }

        string IServiceInformationServices.DeleteServiceInformationByIndID(string serInfDate)
        {
            throw new NotImplementedException();
        }
    }
}
