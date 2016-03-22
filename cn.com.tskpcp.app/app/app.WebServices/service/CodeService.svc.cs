using app.WebServices.Interface;
using app.WebServices.Model;
using app.WebServices.Server;
using app.WebServices.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace app.WebServices.service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“CodeService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 CodeService.svc 或 CodeService.svc.cs，然后开始调试。
    public class CodeService : ICodeService,CodeInterface
    {
        private static readonly CodeServer cs = new CodeServer();
        public string InserCodeService(string codeData)
        {
            CODE code = JSONHelper.JsonDeserialize_JsonTo<CODE>(codeData);
            return InsertCode(code);
        }

        public string GetCodeForFatherIdService(string codeFatherId)
        {
            return JSONHelper.ObjectToJson<CODE>("code", GetCodeForCodeFatherId(codeFatherId));
        }
        public string GetCodeService(string codeID)
        {
            if ( codeID==null||codeID.Equals(""))
            {
                return JSONHelper.ObjectToJson<CODE>("code", GetCode());

            }
            else {
                return JSONHelper.JsonSerializer_to_Json<CODE>(GetCode(codeID));
                
            }
               
       }

       public string InsertCode(CODE code) {
          
            return cs.InsertCode(code);
       }
       public IList<CODE> GetCode() {
          return  cs.GetCode();

       }
       public CODE GetCode(string codeID) {
           return cs.GetCode(codeID);
       }
       public int DeleteCodeByCodeID(string CodeID) {
           return 0;
       }
       public IList<CODE> GetCodeForCodeFatherId(string codeFatherId)
       {
           return cs.GetCodeForCodeFatherId(codeFatherId);
       }
    }
}
