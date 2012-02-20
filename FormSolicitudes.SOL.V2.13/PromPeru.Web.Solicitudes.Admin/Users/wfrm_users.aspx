<%@ Page Title="" EnableEventValidation="false" Language="vb" AutoEventWireup="false"
    MasterPageFile="~/MasterPages/MainMasterPage.Master" CodeBehind="wfrm_users.aspx.vb"
    Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript" language="javascript">
        function ConfirmOnDelete(item) {
            if (confirm("¿Esta seguro de eliminar el usuario " + item + "?") == true)
                return true;
            else
                return false;
        }
    </script>
     <div class="content-body">
        <h4>
            Usuarios del sistema</h4>
    </div>
    <div style="width: 600px; margin: 0 auto; padding-bottom:10px; padding-top:10px;">
        
        <asp:LinkButton ID="LinkButton1" runat="server" href="wfrm_DataUser.aspx" OnClientClick="$(this).modal({width:370, height:400}).open(); return false;" CssClass="btncenter" Height="33px" Width="110px" >Agregar</asp:LinkButton>
        <div class="clear"></div>
        <asp:GridView ID="grvusuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="intID"
            CssClass="mGrid">
            <Columns>
                <asp:BoundField HeaderText="Login" DataField="strLOGIN" />
                <asp:BoundField HeaderText="Nombre" DataField="strNOMBRE" />
                <asp:BoundField HeaderText="Perfil" DataField="strPERFIL" />
                <asp:TemplateField HeaderText="Opciones" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <a href="wfrm_DataUser.aspx?IdUsr=<%#Eval("intID")%>" onclick="$(this).modal({width:370, height:300}).open(); return false;"
                            class="btnupdate">
                            <img src="../images/pixel.gif" alt="Editar" style="width: 14px; height: 14px;" /></a>
                        <a class="delete">
                            <asp:ImageButton ImageUrl="~/images/pixel.gif" ID="imgbtnDel" CommandName="Delete" runat="server" style="width: 14px; height: 14px;" />
                        </a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <asp:Button ID="btn_load" runat="server" Text="load" Style="display: none;" />
    <div class="clear"></div>
</asp:Content>
