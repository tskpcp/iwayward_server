using app.WebClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebClient.Interface
{
    public interface CodeInterface
    {
         string InsertCode(CODE code);
         IList<CODE> GetCode();
         CODE GetCode(string codeID);
         int DeleteCodeByCodeID(string CodeID);
    }
}
