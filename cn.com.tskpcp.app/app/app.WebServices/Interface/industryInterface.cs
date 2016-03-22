using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
   
    /// <summary>
    /// 行业表
    /// </summary>
    public interface industryInterface
    {

         IList<industry> GetIndustry();

         industry GetIndustry(int indID);

         IList<industry> GetIndustryIlistChild(int indID);

         industry GetChildIndustry(int childId);

        
    }
}
