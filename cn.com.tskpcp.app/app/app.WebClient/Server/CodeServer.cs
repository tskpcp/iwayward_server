using app.WebClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebClient.Server
{
    public class CodeServer
    {
        public string InsertCode(CODE code) {
            codeDataContext db = new codeDataContext();
            try {
                db.CODE.InsertOnSubmit(code);
                db.SubmitChanges();
                return code.CodeID;
            }
            catch{
                return "";
            }
        }
        public IList<CODE> GetCode() {
            codeDataContext db = new codeDataContext();
            IEnumerable<CODE> codes = from c in db.CODE select c;
            if (codes != null)
            {
                return codes.ToList<CODE>();    
            }
            else { 
                return new List<CODE>();
            }
        }
        public CODE GetCode(string codeID)
        {
            codeDataContext db = new codeDataContext();
            if(db.CODE.Count()>0){
                var code = db.CODE.Single(c=>c.CodeID==codeID);
                return code;
            }
            else{
                return null;
            }
        }
        public int DeleteCodeByCodeID(string CodeID) {
            int count = 0;
            codeDataContext db = new codeDataContext();
            var code = from c in db.CODE where c.CodeID == CodeID select c;
            if (code.Count() > 0)
            {
                db.CODE.DeleteAllOnSubmit(code);
                count = db.CODE.Where(c => c.CodeID == CodeID).Count();
               
            }
            return count;
        }
    }
}