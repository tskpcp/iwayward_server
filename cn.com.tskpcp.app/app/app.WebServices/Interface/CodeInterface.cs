using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
    /// <summary>
    /// 代码表
    /// </summary>
    public interface CodeInterface
    {
        string InsertCode(CODE code);
        IList<CODE> GetCode();
        IList<CODE> GetCodeForCodeFatherId(string codeFatherId);
        CODE GetCode(string codeID);
        int DeleteCodeByCodeID(string CodeID);
    }
}
