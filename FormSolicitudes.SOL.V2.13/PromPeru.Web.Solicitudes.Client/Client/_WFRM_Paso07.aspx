<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master" CodeBehind="WFRM_Paso07.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.WFRM_Paso07" %>
<%@ Register Assembly="FUA" Namespace="Subgurim.Controles" TagPrefix="cc1" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="content-body">
        <h4>
            Paso 7</h4>
    </div>
        <div class="contenet-form">
        <h6>
            Cuéntenos sobre el evento</h6>
    </div> 
    <table class="table-content-form paso5" style="width:807px; margin: 0 auto;">
       
        <tr>
            <td colspan="2">
            
            <p>
                Es importante que la marca Perú acompañe todos los eventos que de alguna manera
                pueden generar un impacto positivo en la imagen del Perú. Agradecemos su interés
                en invitarnos a ser parte de su evento.</p>
                <br />
            </td>_
        </tr>
        <tr>
            <td class="style7">
              
                    Nombre del evento:*</td>
            <td>
                <asp:TextBox ID="txtNomEvento" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" 
                    ControlToValidate="txtNomEvento" ErrorMessage="Campo Requerido" 
                    ValidationGroup="valPso7"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">
                    Organizador:*</td>
            <td>
                <asp:TextBox ID="txtOrg" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvOrg" runat="server" 
                    ControlToValidate="txtOrg" ErrorMessage="Campo Requerido" 
                    ValidationGroup="valPso7"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="style7">
              
                    Referencias del evento:</td>
            <td>
                <asp:TextBox ID="txtRefEvento" runat="server"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td class="style7">
               
                    Descripción del Evento:</td>
            <td>
                <asp:TextBox ID="txtDescEvento" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                
                    Agenda / Programa del evento (De ser el caso):</td>
            <td>
                <asp:TextBox ID="txtAgProg" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
             <cc1:FileUploaderAJAX ID="FUAjaxRef" runat="server" text_Add="Adjuntar Ref" 
                    text_Uploading="Subiendo.." CssClass="fileAjax" MaxFiles="1" /> <br />

                <%--<asp:FileUpload ID="AdjRef" runat="server" class="file" />--%>
                <%--<asp:RegularExpressionValidator ID="revFUAPE" runat="server" 
                    ControlToValidate="AdjRef" ErrorMessage="Formatos: jpg, gif" 
                    ValidationExpression="(.*).(.jpg|.JPG|.gif|.GIF|.jpeg|.JPEG|.bmp|.BMP|.png|.PNG)$" 
                    ValidationGroup="valPso7"></asp:RegularExpressionValidator>--%>
                    <div>
                    <asp:HyperLink target="_blank" ID="lnkAPE" runat="server" Visible="False" class="EFile">[lnkDNI]</asp:HyperLink>
                <%--<asp:Label ID="lblAPE" runat="server" Visible="False" class="lbl"></asp:Label>--%>
                <asp:Button ID="btnAPE" runat="server" Text="" Visible="False" class="quitar"/>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style7">
               
                    No. Edición del Evento:</td>
            <td>
                <asp:TextBox ID="txtEdicEvento" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                    Peridiocidad del Evento:</td>
            <td>
                <asp:TextBox ID="txtPeriEvento" runat="server" ></asp:TextBox>
                <asp:RegularExpressionValidator ID="revPE" runat="server" 
                    ControlToValidate="txtPeriEvento" ErrorMessage="*" 
                    ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">
                    Lugar de Realización:</td>
            <td>
                <asp:TextBox ID="txtRealiz" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                    Fecha de Realización:</td>
            <td>
                <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                    Descripción del Publico General del Evento:</td>
            <td>
                <asp:TextBox ID="txtDescPGEvento" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">Participantes/Asistentes:</td>
            <td>
                <asp:TextBox ID="txtPtesAtes" runat="server" ></asp:TextBox>
                <asp:RegularExpressionValidator ID="revParct" runat="server" 
                    ControlToValidate="txtPtesAtes" ErrorMessage="*" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">
              Costo promedio de la participación / asistencia al evento:</td>
            <td>
                <asp:TextBox ID="txtCPartAsistEvento" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revcost" runat="server" 
                    ControlToValidate="txtCPartAsistEvento" ErrorMessage="*" 
                    ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">Auspiciadores y/o patrocinadores:</td>
            <td>
                <asp:TextBox ID="txtAuspPatron" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
  
     
      <div class="buttom-conten">
            <div class=" buttom-left">
                <asp:Button ID="bt_atras" runat="server" Text="Atras" CssClass="btn-sumit" />
            </div>
            <div class=" buttom-right">
                <asp:Button ID="Btn_Seguir" runat="server" Text="Siguiente" 
                    CssClass="btn-sumit" ValidationGroup="valPso7" />
            </div>
        </div>
       
    <div class="clear">
    </div>
</asp:Content>

