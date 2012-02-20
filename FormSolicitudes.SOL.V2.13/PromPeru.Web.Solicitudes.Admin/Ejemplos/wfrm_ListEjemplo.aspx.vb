Imports MP.DW.BL
Imports MP.DW.UTL.clsUTL_Helpers
Imports PromPeru.Configuration.Konstantes
Public Class wfrm_ListEjemplo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            fillGridView()
        End If
    End Sub
    Private Sub fillGridView()
        Dim objBC As New BC.clsBC_EJEMPLORO
        objBC.LeerListaEJEMPLO()
        grvEjemplo.DataSource = objBC.LstEJEMPLO
        grvEjemplo.DataBind()
    End Sub

    Protected Sub btn_load_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_load.Click
        fillGridView()
    End Sub

    Private Sub grvEjemplo_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grvEjemplo.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim bln As Nullable(Of Boolean) = CBoolMP(e.Row.Cells(2).Text)
            e.Row.Cells(2).Text = IIf(bln.HasValue AndAlso bln, "Habilitado", "Deshabilitado")
        End If
    End Sub

    Private Sub grvEjemplo_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles grvEjemplo.RowDeleting
        Dim objbc As New BC.clsBC_EJEMPLOTX
        objbc.oBEEJEMPLO.intID = grvEjemplo.DataKeys(e.RowIndex).Values(0)
        objbc.LstEJEMPLO.Add(objbc.oBEEJEMPLO)
        objbc.EliminarEJEMPLO()
        fillGridView()
    End Sub
End Class