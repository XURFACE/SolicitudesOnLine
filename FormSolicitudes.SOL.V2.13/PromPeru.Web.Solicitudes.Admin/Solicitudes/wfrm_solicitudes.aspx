<%@ Page Title="" ValidateRequest="false" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/MainMasterPage.Master"
    CodeBehind="wfrm_solicitudes.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_solicitudes1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <link href="<%= Page.ResolveClientUrl("~/css/blitzer/jquery-ui-1.7.3.custom.css") %>" rel="stylesheet" type="text/css" />

    <script type="text/javascript" src="<%= Page.ResolveClientUrl("~/js/jquery-ui-1.7.3.custom.min.js") %>" ></script>
	<script type="text/javascript">

	    $(document).ready(function () {

	        // Datepicker

	        $(".calendarApro").datepicker();
	        $(".calendarReg").datepicker();
	        // Activar/desactivar los campos de calendario
	        $("#ctl00_ContentPlaceHolder1_chkFechRegistro").click(function (e) {
	            if ($("#ctl00_ContentPlaceHolder1_chkFechRegistro").attr("checked")) {
	                $(".calendarReg").removeAttr("disabled");
	            }
	            else {
	                $(".calendarReg").attr("disabled", "disabled");
	            }
	        })

	        $("#ctl00_ContentPlaceHolder1_chkFechAprovacion").click(function (e) {
	            if ($("#ctl00_ContentPlaceHolder1_chkFechAprovacion").attr("checked")) {
	                $(".calendarApro").removeAttr("disabled");
	            }
	            else {
	                $(".calendarApro").attr("disabled", "disabled");
	            }
	        })

	    });
	</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-body">
        <h4>
            Criterios de busqueda</h4>
    </div>
    <div style="width: 700px; margin: 0 auto;">
        <table class="tabla-form bordernone">
            <tr>
                <td rowspan="2">
                    <label class="lbltxt">
                        Tipo Institución:</label>
                </td>
                <td colspan="2">
                    <asp:RadioButton ID="rbPerJur" runat="server" Text="Persona Jurídica" Checked="False"
                        GroupName="rbBuscar" />
                </td>
                <td colspan="2">
                    <asp:RadioButton ID="rbPerOrEst" runat="server" Text="Organismo Estatal" GroupName="rbBuscar" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:RadioButton ID="rbPerNat" runat="server" Text="Persona Jurídica Extranjera" GroupName="rbBuscar" />
                </td>
                <td colspan="2">
                    <asp:RadioButton ID="rbPerNatNeg" runat="server" Text="Persona Natural con Negocio"
                        GroupName="rbBuscar" />
                </td>
            </tr>
            <tr>
                <td style="padding-top: 1px; padding-bottom: 1px;">
                    <asp:Label ID="Label1" runat="server" Text="Razón Social:" CssClass="label"></asp:Label>
                </td>
                <td colspan="4" style="padding-top: 1px; padding-bottom: 1px;">
                    <asp:TextBox ID="txtRznSocial" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="padding-top: 1px;">
                    <asp:Label ID="lblInst" runat="server" Text="RUC :" CssClass="label"></asp:Label>
                </td>
                <td colspan="4" style="padding-top: 1px;">
                    <asp:TextBox ID="txtRUC" runat="server" MaxLength="11" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <label class="lbltxt">
                        Tipo de Uso:</label>
                </td>
                <td>
                    <asp:CheckBox ID="chckInst" runat="server" Text="Institucional" ValidationGroup="chckBus" />
                </td>
                <td colspan="2">
                    <asp:CheckBox ID="chckProd" runat="server" Text="Producto" />
                </td>
                <td>
                    <asp:CheckBox ID="chckEvent" runat="server" Text="Evento" ValidationGroup="chckBus" />
                </td>
            </tr>
            <tr>
                <td>
                    <label class="lbltxt">
                        Estado:</label></td>
                <td colspan="4">
                    <asp:DropDownList ID="dllCamEst" runat="server">
                    <asp:ListItem Value="0">--TODOS--</asp:ListItem>
                    <asp:ListItem Value="1">EN EVALUACIÓN - DOCUMENTACIÓN</asp:ListItem>
                    <asp:ListItem Value="2">En evaluación - Referencias</asp:ListItem>
                    <asp:ListItem Value="3">EN EVALUACIÓN - COMITÉ</asp:ListItem>
                    <asp:ListItem Value="4">APROBADO</asp:ListItem>
                    <asp:ListItem Value="5">RECHAZADO</asp:ListItem>
                    <asp:ListItem Value="6">REVOCADO</asp:ListItem>
                    <asp:ListItem Value="7">SUSPENDIDO</asp:ListItem>
                    <asp:ListItem Value="8">SUSPENDIDO POR DEUDA</asp:ListItem>
                    <asp:ListItem Value="9">CADUCADO</asp:ListItem>
                </asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>
                        <br />
                </td>
                <td colspan="2">
                 <asp:CheckBox ID="chkFechRegistro" runat="server" Text="Feha de Registro" />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Desde"></asp:Label>
                <asp:TextBox ID="txtFechaRegistroDesde" runat="server" Enabled="False" 
                    CssClass="calendarReg"></asp:TextBox>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Hasta"></asp:Label>
                <asp:TextBox ID="txtFechaRegistroHasta" runat="server" Enabled="False" 
                    CssClass="calendarReg"></asp:TextBox>
                    
                </td>
         <td colspan="2">
               <asp:CheckBox ID="chkFechAprovacion" runat="server" 
                        Text="Fecha de aprovacion" />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Desde"></asp:Label>
                    <asp:TextBox ID="txtFechaAprovacionDesde" runat="server" Enabled="False" 
                        CssClass="calendarApro"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Hasta"></asp:Label>
                    <asp:TextBox ID="txtFechaAprovacionHasta" runat="server" Enabled="False" 
                        CssClass="calendarApro"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td colspan="2">
                    <div class="buttom-conten buttom-right">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                        <%--<asp:Button ID="btnMostrar" runat="server" Text="Mostrar Todos" />--%>
                    </div>
                </td>
                <td colspan="2">
                </td>
            </tr>
        </table>
    </div>
    <div class="clear">
    </div>
    <div style="width: 800px; margin: 0 30px;">
        <div class="div-xlsExportar">
            <asp:LinkButton ID="lnkExportar" runat="server"></asp:LinkButton>
        </div>
        <asp:GridView ID="gViewDU" runat="server" AutoGenerateColumns="False" GridLines="None"
            CssClass="mGrid" PagerStyle-CssClass="pgr" AllowPaging="True" 
            PageSize="25">
            <Columns>
                <asp:BoundField HeaderText="Empresa" DataField="RAZONSOCIAL" />
                <asp:BoundField HeaderText="Giro" DataField="GIRO" />
                <asp:BoundField HeaderText="Uso" DataField="TIPOLIC" />
                <asp:BoundField HeaderText="Estado" DataField="STSSOL" />
                <asp:BoundField HeaderText="Programa de Responsabilidad Social" DataField="NOMBREPROGRAMASOCIAL" />
                <asp:BoundField HeaderText="Impulsa a:" DataField="OBJETIVO" />
                <asp:TemplateField HeaderText="Opciones">
                    <ItemTemplate>
                        <a onclick="$(this).modal({width:620, height:600}).open(); return false;" href="wfrm_CmbEstado.aspx?id=<%# EVAL("IDEMP") %>&idsol=<%# EVAL("IDSOL") %>"
                            class="btnupdate" title="Cambiar Estado">
                            <img src="../images/pixel.gif" alt="editar" style="width: 14px; height: 14px;" /></a>
                        <a href="wfrm_DetalleSolicitud.aspx?id=<%# EVAL("IDEMP") %>&idSol=<%# EVAL("IDSOL") %>"
                            class="detalle" title="Detalles">
                            <img src="../images/pixel.gif" alt="editar" style="width: 14px; height: 14px;" /></a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <PagerStyle CssClass="pgr"></PagerStyle>
        </asp:GridView>
    </div>
    <div class="clear">
    </div>
</asp:Content>
