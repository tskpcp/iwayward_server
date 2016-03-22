using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using app.WebClient.Model;
namespace app.WebClient.Server
{
    public class ServiceInformationServer
    {
        public int InsertServiceInformation(ServiceInformation serInf)
        {
            ServiceInformationDataContext db = new ServiceInformationDataContext();
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
        public IList<ServiceInformation> GetServiceInformation()
        {
            ServiceInformationDataContext db = new ServiceInformationDataContext();
            IEnumerable<ServiceInformation> codes = from c in db.ServiceInformation select c;
            if (codes != null)
            {
                return codes.ToList<ServiceInformation>();
            }
            else
            {
                return new List<ServiceInformation>();
            }
        }
        public ServiceInformation GetServiceInformation(int IndID)
        {
            ServiceInformationDataContext db = new ServiceInformationDataContext();
            if (db.ServiceInformation.Count() > 0)
            {
                var code = db.ServiceInformation.Single(c => c.IndID == IndID);
                return code;
            }
            else
            {
                return null;
            }
        }
        public int DeleteServiceInformationByIndID(int IndID)
        {
            int count = 0;
            ServiceInformationDataContext db = new ServiceInformationDataContext();
            var code = from c in db.ServiceInformation where c.IndID == IndID select c;
            if (code.Count() > 0)
            {
                db.ServiceInformation.DeleteAllOnSubmit(code);
                count = db.ServiceInformation.Where(c => c.IndID == IndID).Count();

            }
            return count;
        }
    }
}