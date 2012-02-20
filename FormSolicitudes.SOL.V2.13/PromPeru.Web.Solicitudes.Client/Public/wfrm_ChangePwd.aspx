<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_ChangePwd.aspx.vb"
    Inherits="PromPeru.Web.Solicitudes.Client.wfrm_ChangePwd" %>

<%@ Register Src="../UC/uc_changePwd.ascx" TagName="uc_changePwd" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
</head>
<body class="body-popup">
    <form id="form1" runat="server">
    <div>
        
        <uc1:uc_changePwd ID="uc_changePwd1" runat="server" />
    </div>
    </form>
</body>
</html>
