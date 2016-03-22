using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
  /// <summary>
  /// 人员关系
  /// </summary>
    public interface PersonnelRealtionshipInterface
    {
        int IInsertPersonnelRealtionship(PersonnelRelationship perRe);

        IList<PersonnelRelationship> IGetPersonnelRelationship();

        PersonnelRelationship IGetPersonnelRelationship(string UserId);


        int IDeletePersonnelRelationshipByUserID(string userID);
    }
}
