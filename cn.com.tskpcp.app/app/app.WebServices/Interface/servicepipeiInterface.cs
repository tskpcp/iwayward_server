using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
    /// <summary>
    /// 信息匹配
    /// </summary>
    public interface servicepipeiInterface
    {
        
        int InsertServicepipei(servicepipei perRe);

        
        IList<servicepipei> GetServicepipei();

        
        servicepipei GetServicepipei(string UserId);

         int UpdateServicepipeifoByUserID(servicepipei attInd);

         int DeleteServicepipeiByUserID(string userID);
    }
}
