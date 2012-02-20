Imports MP.DW.BL
Imports PromPeru.Configuration
Public Class Popwfrm_EmpresasUsuario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cargarLista(grvLstEmpresa)
        End If
    End Sub

    Private Sub cargarLista(ByRef grv As GridView)
        Dim idClient As Int64 = CType(Session(Konstantes.kstrNombreSession), BE.clsBE_CLIENT_USER).lngID
        Dim objEMPRESARO As New BC.clsBC_EMPRESARO
        objEMPRESARO.LeerListaToEMPRESABYCLIENTUSER(idClient)
        grvLstEmpresa.DataSource = objEMPRESARO.oDTEMPRESA
        grvLstEmpresa.DataBind()
    End Sub

    Protected Sub grvLstEmpresa_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles grvLstEmpresa.PageIndexChanging
        grvLstEmpresa.PageIndex = e.NewPageIndex
        cargarLista(grvLstEmpresa)
    End Sub

End Class