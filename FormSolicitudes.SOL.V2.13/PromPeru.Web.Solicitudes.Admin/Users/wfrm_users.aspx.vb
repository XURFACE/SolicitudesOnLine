Imports MP.DW.BL
Imports MP.DW.UTL.clsUTL_Helpers
Imports PromPeru.Configuration.Konstantes
Public Class wfrm_users
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            fillGridView()
        End If

    End Sub
    Private Sub fillGridView()
        Dim objBC As New BC.clsBC_USUARIORO
        objBC.LeerListaUSUARIO()
        grvusuarios.DataSource = objBC.LstUSUARIO
        grvusuarios.DataBind()
    End Sub

    'Protected Sub grvusuarios_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grvusuarios.RowDataBound
    '    If e.Row.RowType = DataControlRowType.DataRow Then
    '        Dim btn As Button = e.Row.Cells(3).Controls(2)
    '        If Not IsNothing(btn) Then
    '            btn.OnClientClick = "return ConfirmOnDelete('" + e.Row.Cells(1).Text + "');"
    '            'btn.Attributes.Add("onclick", )
    '        End If
    '    End If
    'End Sub

    'Protected Sub btnadd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnadd.Click
    '    Response.Redirect("wfrm_DataUser.aspx")
    'End Sub

    'Protected Sub grvusuarios_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles grvusuarios.RowEditing
    '    Response.Redirect("wfrm_DataUser.aspx?IdUsr=" & grvusuarios.DataKeys(e.NewEditIndex).Value)
    'End Sub

    Protected Sub grvusuarios_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles grvusuarios.RowDeleting
        Dim objbc As New BC.clsBC_USUARIOTX
        objbc.oBEUSUARIO.intID = grvusuarios.DataKeys(e.RowIndex).Value
        objbc.LstUSUARIO.Add(objbc.oBEUSUARIO)
        objbc.EliminarUSUARIO()
        fillGridView()
    End Sub

    Protected Sub btn_load_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_load.Click
        fillGridView()
    End Sub
End Class