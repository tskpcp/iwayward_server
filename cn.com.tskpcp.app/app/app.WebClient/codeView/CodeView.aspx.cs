using app.WebClient.Controller;
using app.WebClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace app.WebClient.codeView
{
    public partial class CodeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserCode_Click(object sender, EventArgs e)
        {
            /*
            CodeController cc = new CodeController();
            CODE code = new CODE();
            code.CodeID = txtCodeID.Text;
            code.CodeName = txtCodeName.Text;
            int temp=0;
            int.TryParse(txtCodeIndex.Text,out temp);
            code.CodeIndex =temp;
            code.CodeMark = txtCodeMark.Text;
            code.CodeFatherID = txtCodeFatherID.Text;
            txtReturnvalue.Text= cc.InsertCode(code);
            */
            txtReturnvalue.Text = GetRandNum(8);
        }

        public static string GetRandNum(int randNumLength)
        {
            Random randNum = new Random(unchecked((int)DateTime.Now.Ticks));
            StringBuilder sb = new StringBuilder(randNumLength);
            for (int i = 0; i < randNumLength; i++)
            {
                sb.Append(randNum.Next(0, 9));
            }
            return sb.ToString();
        }
    }
}