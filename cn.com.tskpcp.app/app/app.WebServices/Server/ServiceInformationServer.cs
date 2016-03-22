using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
   /// <summary>
   /// 信息服务
   /// </summary>
    public class ServiceInformationServer
    {
        public int InsertServiceInformation(ServiceInformation serInf)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.ServiceInformation.InsertOnSubmit(serInf);
                db.SubmitChanges();
                return int.Parse(serInf.IndID.ToString());
            }
            catch
            {
                return 0;
            }
        }
        public IList<ServiceInformation> GetServiceInformationforUserId(string UserId)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<ServiceInformation> codes = from c in db.ServiceInformation where c.UserID==UserId select c;
            if (codes != null)
            {
                return codes.ToList<ServiceInformation>();
            }
            else
            {
                return null;
            }
        }
        public IList<ServiceInformation> GetServiceInformation() {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<ServiceInformation> codes = from c in db.ServiceInformation select c;
            if (codes != null)
            {
                return codes.ToList<ServiceInformation>();
            }
            else
            {
                return null;
            }
        }
        public ServiceInformation GetServiceInformation(int ServiceID,string UserId)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.ServiceInformation.Count() > 0)
            {
                var code = db.ServiceInformation.Single(c => c.ServicID == ServiceID && c.UserID == UserId);
                return code;
            }
            else
            {
                return null;
            }
        }
        public int UpdateServiceInformationBuIndID(ServiceInformation serviceInformation)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                var result=db.ServiceInformation.Single(c => c.ServicID == serviceInformation.ServicID && c.UserID == serviceInformation.UserID);
               
                result.title = serviceInformation.title;
                result.serviceTyoe = serviceInformation.serviceTyoe;
                result.sendTime = serviceInformation.sendTime;
                result.IndID = serviceInformation.IndID;
                result.region = serviceInformation.region;
                result.city = serviceInformation.city;
                result.province = serviceInformation.province;
                result.macrk = serviceInformation.macrk;
                result.longitude = serviceInformation.longitude;
                result.latitude = serviceInformation.latitude;
                
                db.SubmitChanges();
                return result.ServicID;

            }
            catch
            {
                return 0;
            }
        }
        public int DeleteServiceInformationByIndID(int ServiceID)
        {
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
            var code = from c in db.ServiceInformation where c.ServicID == ServiceID select c;
            if (code.Count() > 0)
            {
                db.ServiceInformation.DeleteAllOnSubmit(code);
                count = db.ServiceInformation.Where(c => c.ServicID == ServiceID).Count();

            }
            return count;
        }
    }
}