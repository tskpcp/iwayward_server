using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
  
    /// <summary>
    /// 信息服务
    /// </summary>
    public interface ServiceInformationInterface
    {
         int IInsertServiceInformation(ServiceInformation serInf);
         IList<ServiceInformation> IGetServiceInformation();
         IList<ServiceInformation> IGetServiceInformationforUserId(string UserID);
         ServiceInformation IGetServiceInformation(int ServiceID,string UserID);
         int IUpdateServiceInformationBuIndID(ServiceInformation serviceInformation);
         int IDeleteServiceInformationByIndID(int ServiceId);
    }
}
