using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
   /// <summary>
   /// 关注行业
   /// </summary>
    public interface AttentionIndustryInterface
    {
         int IInsertAttentionIndustry(AttentionIndustry attInd);

         IList<AttentionIndustry> IGetAttentionIndustry();

         AttentionIndustry IGetAttentionIndustry(string UserId);

         int IUpdateAttentionIndustryfoByUserID(AttentionIndustry attInd);

         int IDeleteAttentionIndustryByUserID(string userID);
    }
}
