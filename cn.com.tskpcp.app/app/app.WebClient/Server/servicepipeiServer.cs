using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using app.WebClient.Model;
namespace app.WebClient.Server
{
    public class servicepipeiServer
    {
        public int InsertServicepipei(servicepipei perRe)
        {
            servicepipeiDataContext db = new servicepipeiDataContext();
            try
            {
                db.servicepipei.InsertOnSubmit(perRe);
                db.SubmitChanges();
                return int.Parse(perRe.UserID.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public IList<servicepipei> GetServicepipei()
        {
            servicepipeiDataContext db = new servicepipeiDataContext();
            IEnumerable<servicepipei> attInd = from c in db.servicepipei select c;
            if (attInd != null)
            {
                return attInd.ToList<servicepipei>();
            }
            else
            {
                return new List<servicepipei>();
            }
        }

        public servicepipei GetServicepipei(string UserId)
        {
            servicepipeiDataContext db = new servicepipeiDataContext();
            if (db.servicepipei.Count() > 0)
            {
                var user = db.servicepipei.Single(c => c.UserID == UserId);
                return user;
            }
            else
            {
                return null;
            }
        }

        public int UpdateServicepipeifoByUserID(servicepipei attInd)
        {
            servicepipeiDataContext db = new servicepipeiDataContext();
            try
            {
                var result = (from item in db.servicepipei where item.UserID == attInd.UserID select item).Single();
                result.ServicID = attInd.ServicID;
                result.PUserID = attInd.PUserID;
                db.SubmitChanges();
                return int.Parse(result.UserID.ToString());

            }
            catch
            {
                return 0;
            }
        }

        public int DeleteServicepipeiByUserID(string userID)
        {
            int count = 0;
            servicepipeiDataContext db = new servicepipeiDataContext();
            var user = from c in db.servicepipei where c.UserID == userID select c;
            if (user.Count() > 0)
            {
                db.servicepipei.DeleteAllOnSubmit(user);
                count = db.servicepipei.Where(c => c.UserID == userID).Count();

            }
            return count;
        }
    }
}