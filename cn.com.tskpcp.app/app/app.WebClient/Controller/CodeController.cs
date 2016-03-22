using app.WebClient.Interface;
using app.WebClient.Model;
using app.WebClient.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebClient.Controller
{
    public class CodeController:CodeInterface
    {
        private static readonly CodeServer cs = new CodeServer();
        public string InsertCode(CODE code) {

            return cs.InsertCode(code);
        }
        public IList<CODE> GetCode() {
            return cs.GetCode();
        }
        public CODE GetCode(string codeID) {
            if (codeID.Equals(null))
            {
                return null;
            }
            else {
                return cs.GetCode(codeID);
            }
        }
        public int DeleteCodeByCodeID(string CodeID) {
            if (CodeID.Equals(null))
            {
                return 0;
            }
            else
            {
                return cs.DeleteCodeByCodeID(CodeID);
            }
        }
    }
}