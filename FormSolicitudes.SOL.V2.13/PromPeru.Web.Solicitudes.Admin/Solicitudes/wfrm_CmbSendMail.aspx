<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_CmbSendMail.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_CmbSendMail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href="../css/modal-window.css" rel="stylesheet" type="text/css" media="all" />
    <script src="../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script text="text/javascript">
        $(document).ready(function () {


        });
    </script>
    <style type="text/css">
        #txtAreaDetalle
        {
            width: 499px;
            height: 187px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <%  Dim cadena As String = ""%>
    <div class="title-popup">
        <p> Marca país - Archivos adicionales-</p>
    </div>
    <div class="body-popup">
        <div class="inner">
            <p>
            El evaluador ha considerado que para su solicitud sea aprobada se agreguen siguientes archivos adicionales:
            </p>
                <asp:GridView ID="grvarcAdic" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                            Width="500px" BorderColor="Red" BorderStyle="Dashed" BorderWidth="1px">
                    <Columns>
                        <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripción" />
                        <asp:TemplateField HeaderText="Archivos">
                            <ItemTemplate>
                                <asp:HyperLink Target="_blank" ID="lnkRF" class="EFile" runat="server" Text='<%# Bind("RUTA_ARCHIVO") %>'
                                    NavigateUrl='<%# Bind("RUTA_ARCHIVO") %>' ForeColor="Red"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            <p >Mensaje para el evaluador:</p>
            <p >
                <asp:TextBox ID="txtAreaDetalle" runat="server" Height="269px" 
                    TextMode="MultiLine" Width="501px"></asp:TextBox>
            </p>
           &nbsp;
           <div>
                <div class="buttom-popup" style="text-align: center; width: 100%;">
                      <asp:Button ID="btnSolicitar" runat="server" Style="margin-left: 0px;" Text="Enviar Solicitud" />
                 </div>
                 &nbsp;
            
            </div>
            <p>
                <asp:Literal ID="ltrMsg" runat="server"></asp:Literal>
            </p>
        </div>
    </div>
    </form>
    </body>
</html>
