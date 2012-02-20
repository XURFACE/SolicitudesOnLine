<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/MainMasterPage.Master"
    CodeBehind="wfrm_ListEjemplo.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_ListEjemplo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-body">
        <h4>
            Administrar ejemplos</h4>
    </div>
    <div style="width: 600px; margin: 0 auto; padding-bottom: 10px; padding-top: 10px;">
        <asp:LinkButton ID="LinkButton1" runat="server" href="wfrm_Ejemplo.aspx" OnClientClick="$(this).modal({width:440, height:380}).open(); return false;"
            CssClass="btncenter" Height="33px" Width="110px">Agregar</asp:LinkButton>
        <div class="clear">
        </div>
        <asp:GridView ID="grvEjemplo" runat="server" AutoGenerateColumns="False" DataKeyNames="intID,strRUTA_ARCHIVO"
            CssClass="mGrid">
            <Columns>
                <asp:BoundField DataField="strDESCRIPCION" HeaderText="DESCRIPCION" />
                <asp:BoundField DataField="strTIPOLIC" HeaderText="USO" />
                <asp:BoundField DataField="blnIND_ACTIVO" HeaderText="ESTADO" />
                <asp:TemplateField ShowHeader="False" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <a href="wfrm_Ejemplo.aspx?IdEjmp=<%#Eval("intID")%>" onclick="$(this).modal({width:370, height:320}).open(); return false;"
                            class="btnupdate">
                            <img src="../images/pixel.gif" alt="Editar" style="width: 14px; height: 14px;" /></a>
                        <a class="delete">
                            <asp:ImageButton ImageUrl="~/images/pixel.gif" ID="imgbtnDel" CommandName="Delete"
                                runat="server" Style="width: 14px; height: 14px;" />
                        </a>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="80px"></ItemStyle>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <div class="clear">
    </div>
    <asp:Button ID="btn_load" runat="server" Text="load" Style="display: none;" />
</asp:Content>
