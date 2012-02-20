<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/PublicMasterPage.Master"
    CodeBehind="wfrm_searchLic.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.wfrm_searchLic" %>

<%@ Register Src="../UC/uc_GiroSector.ascx" TagName="uc_GiroSector" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-body">
        <h4>
            Solicitudes ingresadas
        </h4>
    </div>
    <div class="contenet-form">
        <h6>
            Inserte los criterios de búsqueda</h6>
        <div class="content-info">
            <table>
                <tr>
                    <td class="leftTable">
                        <label for="representante">
                            Razón Social:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_razonsocial" runat="server" CssClass="representante" MaxLength="150"
                            size="60"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="leftTable">
                        <label for="representante">
                            RUC:
                        </label>
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_RUC" runat="server" CssClass="representante" size="40px" MaxLength="11"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="leftTable">
                        <label for="representante">
                            Giro:
                        </label>
                    </td>
                    <td>
                        <uc1:uc_GiroSector ID="uc_GiroSector" runat="server" Tipo="Ambos" />
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <div class="buttom-conten">
                            <div class="buttom-right-search">
                                <asp:Button ID="Btn_buscar" runat="server" Text="Buscar" CssClass="button" />
                                <%--<asp:Button ID="btn_Todos" runat="server" Text="Mostrar  Todos" CssClass="button" />--%>
                            </div>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
        <div class="div-xlsExportar">
            <asp:LinkButton ID="lnkExportar" runat="server"></asp:LinkButton>
        </div>
        <asp:GridView ID="grvSolicitudes" runat="server" AutoGenerateColumns="False" DataKeyNames="IDEMP,IDSOL"
            CssClass="mGrid" AllowPaging="True" PagerStyle-CssClass="pgr" Width="800px">
            <Columns>
                <asp:BoundField HeaderText="Empresa" DataField="RAZONSOCIAL" />
                <asp:BoundField HeaderText="Giro" DataField="GIRO" />
                <asp:BoundField HeaderText="Programa de Responsabilidad Social" DataField="NOMBREPROGRAMASOCIAL" />
                <asp:BoundField DataField="OBJETIVO" HeaderText="Impulsa a:" />
                <asp:TemplateField ShowHeader="False" HeaderText="Opciones" Visible="False">
                    <ItemTemplate>
                        <div class="div-lickDetalle">
                            <a href='wfrm_DetalleSolicitud.aspx?idsol=<%#Eval("IDSOL")%>' title="Detalle">Detalle
                            </a>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <PagerStyle CssClass="pgr"></PagerStyle>
        </asp:GridView>
    </div>
</asp:Content>
