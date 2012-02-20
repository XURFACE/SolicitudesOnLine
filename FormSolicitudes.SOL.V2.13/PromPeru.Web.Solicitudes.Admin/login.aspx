<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Admin.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
     <style type="text/css">
        table.table-content-form tr td label { margin-left:0px;}
     </style>
</head>
<body>
     <form id="form1" runat="server">

         <div style="margin: 120px;">
       
        <div class="form-login">
        <div class="login-top" ></div>
        <div class="login-logo"></div>   
        <div class="login-table">
            <table class="table-content-form" style="width: 350px; margin: 0  auto; ">
            <tr>
                <td colspan="2">
                  <h4 style=" text-align:center;color:red;">Iniciar Sesión</h4>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                   <label> Usuario:
                   </label>
                   </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtLogin" runat="server" Width="190px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLogin" runat="server" 
                        ControlToValidate="txtLogin" ErrorMessage="Ingrese el Login" 
                        ValidationGroup="ValLogin">•</asp:RequiredFieldValidator>
                </td>
               
            </tr>
            <tr>
                <td>
                    <label>
                    Password:
                    </label>
                    </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="190px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPdw" runat="server" 
                        ControlToValidate="txtPwd" ErrorMessage="Ingrese el Password" 
                        ValidationGroup="ValLogin">•</asp:RequiredFieldValidator>
                </td>
              
            </tr>
            <tr>
                <td colspan="2">               
                    <asp:Button ID="btnIngresar" runat="server" Text="" 
                        ValidationGroup="ValLogin" CssClass="login-button" />
                </td>
               
            </tr>
            <tr>
                <td colspan="2">
                  <div style="width:265px; margin:0 auto;">
                    <asp:ValidationSummary CssClass="messbox" ID="vldSmr" runat="server" ValidationGroup="ValLogin" />
                    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                </div>
                </td>
             
            </tr>
        </table>
        </div>
  
   </div>
   </div>
    </form>
</body>
</html>
