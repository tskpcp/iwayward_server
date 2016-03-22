using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.WebServices.Server
{
    /// <summary>
    /// 代码
    /// </summary>
    public class CodeServer
    {
       
        public string InsertCode(CODE code)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            try
            {
                db.CODE.InsertOnSubmit(code);
                db.SubmitChanges();
                return code.CodeID;
            }
            catch
            {
                return "";
            }
        }
        public IList<CODE> GetCode()
        {
            iwaywardDataContext db = new iwaywardDataContext();
            IEnumerable<CODE> codes = from c in db.CODE select c;
            if (codes != null)
            {
                return codes.ToList<CODE>();
            }
            else
            {
                return new List<CODE>();
            }
        }
        public IList<CODE> GetCodeForCodeFatherId(string codeFatherId) {
            iwaywardDataContext db = new iwaywardDataContext();
           
            try {
                IEnumerable<CODE> codes = from c in db.CODE where c.CodeFatherID.Equals(codeFatherId) select c;
                if (codes != null)
                {
                    return codes.ToList<CODE>();
                }
                else {
                    return new List<CODE>();
                }
            }
            catch {
                return new List<CODE>();
            }
        }
        public CODE GetCode(string codeID)
        {
            iwaywardDataContext db = new iwaywardDataContext();
            if (db.CODE.Count() > 0)
            {
                var code = db.CODE.Single(c => c.CodeID == codeID);
                return code;
            }
            else
            {
                return null;
            }
        }
      
        public int DeleteCodeByCodeID(string CodeID)
        {
            int count = 0;
            iwaywardDataContext db = new iwaywardDataContext();
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