<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_RestorePwd.aspx.vb"
    Inherits="PromPeru.Web.Solicitudes.Client.wfrm_RestorePwd" %>

<%@ Register Src="~/UC/uc_RestorePwd.ascx" TagName="uc_RestorePwd" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
</head>

<style type="text/css">
    body{
        background:#fff;
    }
</style>

<body>
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
             Solicitar Clave</p>
    </div>
    <div>
        <uc1:uc_RestorePwd ID="uc_RestorePwd1" runat="server" />
    </div>
    </form>
</body>
</html>
