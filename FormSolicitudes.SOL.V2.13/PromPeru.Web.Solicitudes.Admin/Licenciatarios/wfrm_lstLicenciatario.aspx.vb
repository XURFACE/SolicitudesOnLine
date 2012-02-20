Imports MP.DW.BL

Public Class wfrm_lstLicenciatario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtLoginMail.Attributes.Add("onKeyPress", "doClick('" + btnBuscar.ClientID + "',event)")
        txtName.Attributes.Add("onKeyPress", "doClick('" + btnBuscar.ClientID + "',event)")
    End Sub
    Private Sub cargaGrid(Optional ByVal dt As DataTable = Nothing)
        If IsNothing(dt) Then
            Dim bc As New BC.clsBC_CLIENT_USERRO
            bc.LeerListaToDTCLIENT_USER(txtName.Text, txtLoginMail.Text)
            Session("data") = bc.oDTCLIENT_USER
            dt = bc.oDTCLIENT_USER
        End If
        gViewDU.DataSource = dt
        gViewDU.DataBind()
    End Sub

    Protected Sub gViewDU_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gViewDU.PageIndexChanging
        gViewDU.PageIndex = e.NewPageIndex
        cargaGrid(Session("data"))
    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        cargaGrid()
    End Sub

    Private Sub gViewDU_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gViewDU.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim imgbtn As ImageButton = e.Row.FindControl("imgbtnDel")
            If Not IsNothing(imgbtn) Then
                imgbtn.OnClientClick = "return confirm('¿Está seguro de eliminar al usuario " & e.Row.Cells(1).Text & "?');"
            End If

        End If
    End Sub

    Private Sub gViewDU_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gViewDU.RowDeleting
        Try
            Dim Obj As New BC.clsBC_CLIENT_USERTX
            Obj.oBECLIENT_USER.lngID = gViewDU.DataKeys(e.RowIndex).Value
            Obj.LstCLIENT_USER.Add(Obj.oBECLIENT_USER)
            Obj.EliminarCLIENT_USER()
            cargaGrid()
        Catch ex As Exception

        End Try
    End Sub
End Class