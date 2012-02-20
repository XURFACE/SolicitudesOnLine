<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/MainMasterPage.Master"
    CodeBehind="wfrm_lstLicenciatario.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_lstLicenciatario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-body">
        <h4>
            Usuarios de la marca</h4>
    </div>
    <table class="tabla-form bordernone">
        <tr>
            <td style="padding-top: 1px; padding-bottom: 1px;">
                <asp:Label ID="Label1" runat="server" Text="Usuario o correo:" CssClass="label"></asp:Label>
            </td>
            <td style="padding-top: 1px; padding-bottom: 1px;">
                <asp:TextBox ID="txtLoginMail" runat="server" Width="250px" MaxLength="150"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-top: 1px;">
                <asp:Label ID="lblInst" runat="server" Text="Nombres y/o Apellidos:" CssClass="label"></asp:Label>
            </td>
            <td style="padding-top: 1px;">
                <asp:TextBox ID="txtName" runat="server" Width="250px" MaxLength="150"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <div class="buttom-conten">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                    <%--<asp:Button ID="btnMostrar" runat="server" Text="Mostrar Todos" />--%>
                </div>
            </td>
        </tr>
    </table>
    <div style="width: 800px; margin: 0 auto; padding-bottom: 10px; padding-top: 10px;">
        <asp:GridView ID="gViewDU" runat="server" AutoGenerateColumns="False" GridLines="None"
            CssClass="mGrid" PagerStyle-CssClass="pgr" AllowPaging="True" ShowHeader="true"
            PageSize="50" EmptyDataText="No data in the data source." ShowHeaderWhenEmpty="True" DataKeyNames="ID">
            <EmptyDataRowStyle ForeColor="Red" HorizontalAlign="Center" Height="50px" VerticalAlign="Middle" />
            <EmptyDataTemplate>
                <div style="padding-top: 15px">
                    No se encontraron registros</div>
            </EmptyDataTemplate>
            <Columns>
                <asp:BoundField HeaderText="Usuario" DataField="LOGINUSR" />
                <asp:BoundField HeaderText="Nombre" DataField="NOMBRECOMPLETO" />
                <asp:BoundField HeaderText="Correo" DataField="MAILUSR" />
                <asp:BoundField HeaderText="# de empresas" DataField="TOTALEMPS">
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <%--<asp:HyperLinkField DataNavigateUrlFields="ID" HeaderText="# de empresas" DataNavigateUrlFormatString="wfrm_Empresas.aspx?id={0}"
                    DataTextField="TOTALEMPS">
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:HyperLinkField>--%>
                <asp:TemplateField HeaderText="Opciones">
                    <ItemTemplate>
                        <a onclick="$(this).modal({width:310, height:380}).open(); return false;" href="wfrm_Usuario.aspx?id=<%# EVAL("ID") %>"
                            class="btnupdate" title="Ver detalles">
                            <img src="../images/pixel.gif" alt="editar" style="width: 14px; height: 14px;" /></a>&nbsp;
                        <asp:ImageButton ID="imgbtnDel" ImageUrl="~/images/delet-on.gif" CommandName="Delete"
                            CssClass="delete" OnClientClick="return confirm('¿Está seguro de eliminar al usuario?');"
                            ToolTip="Eliminar" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <PagerSettings Position="TopAndBottom" />
            <PagerStyle CssClass="pgr"></PagerStyle>
        </asp:GridView>
    </div>
</asp:Content>
