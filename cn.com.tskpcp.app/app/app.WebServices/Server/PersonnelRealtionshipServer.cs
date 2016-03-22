using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
   /// <summary>
   /// 人员关系
   /// </summary>
    public class PersonnelRealtionshipServer
    {
        public int InsertPersonnelRealtionship(PersonnelRelationship perRe)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.PersonnelRelationship.InsertOnSubmit(perRe);
                db.SubmitChanges();
                return int.Parse(perRe.UserID.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public IList<PersonnelRelationship> GetPersonnelRelationship()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<PersonnelRelationship> attInd = from c in db.PersonnelRelationship select c;
            if (attInd != null)
            {
                return attInd.ToList<PersonnelRelationship>();
            }
            else
            {
                return new List<PersonnelRelationship>();
            }
        }

        public PersonnelRelationship GetPersonnelRelationship(string UserId)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.AttentionIndustry.Count() > 0)
            {
                var user = db.PersonnelRelationship.Single(c => c.UserID == UserId);
                return user;
            }
            else
            {
                return null;
            }
        }

        public int UpdatePersonnelRelationshipfoByUserID(PersonnelRelationship attInd)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                var result = (from item in db.PersonnelRelationship where item.UserID == attInd.UserID select item).Single();
                result.GUserID = attInd.GUserID;
                result.IndID = attInd.IndID;
                result.objType = attInd.objType;
                db.SubmitChanges();
                return int.Parse(result.UserID.ToString());

            }
            catch
            {
                return 0;
            }
        }

        public int DeletePersonnelRelationshipByUserID(string userID)
        {
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
            var user = from c in db.PersonnelRelationship where c.UserID == userID select c;
            if (user.Count() > 0)
            {
                db.PersonnelRelationship.DeleteAllOnSubmit(user);
                count = db.PersonnelRelationship.Where(c => c.UserID == userID).Count();

            }
            return count;
        }
    }
}