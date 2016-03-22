using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
   /// <summary>
   /// 公司信息
   /// </summary>
    public interface companyTableInterface
    {
        string InserCompanyTable(companyTable company);
        IList<companyTable> GetCompanyTable();
        UserInfo GetCompanyTable(string companyID);
        string UpdateCompanyTableByCompID(companyTable company);
        int DeleteCompanyTableByCompID(string companyID);

    }
}
