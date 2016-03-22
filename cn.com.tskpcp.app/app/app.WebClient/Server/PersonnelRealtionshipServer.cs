using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using app.WebClient.Model;
namespace app.WebClient.Server
{
    public class PersonnelRealtionshipServer
    {
        public int InsertAttentionIndustry(PersonnelRelationship perRe)
        {
            PersonnelRelationshipDataContext db = new PersonnelRelationshipDataContext();
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
            PersonnelRelationshipDataContext db = new PersonnelRelationshipDataContext();
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
            PersonnelRelationshipDataContext db = new PersonnelRelationshipDataContext();
            if (db.PersonnelRelationship.Count() > 0)
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
            PersonnelRelationshipDataContext db = new PersonnelRelationshipDataContext();
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
            PersonnelRelationshipDataContext db = new PersonnelRelationshipDataContext();
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