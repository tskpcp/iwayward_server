<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CodeView.aspx.cs" Inherits="app.WebClient.codeView.CodeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="0" style="width: 300px; height: 500px;">
                <tr>
                    <td>CodeID</td>
                    <td><asp:TextBox runat="server" ID="txtCodeID" Width="100"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>CodeName</td>
                    <td><asp:TextBox ID="txtCodeName" runat="server" Width="100"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>CodeFatherID</td>
                    <td><asp:TextBox ID="txtCodeFatherID" runat="server" Width="100"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>CodeIndex</td>
                    <td><asp:TextBox ID="txtCodeIndex" runat="server" Width="100"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>CodeMark</td>
                    <td><asp:TextBox ID="txtCodeMark" runat="server" Width="100"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Button ID="btnInserCode" runat="server" Text="Button" OnClick="btnInserCode_Click" /></td>
                    <td><asp:TextBox ID="txtReturnvalue" runat="server" Width="100"></asp:TextBox></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
