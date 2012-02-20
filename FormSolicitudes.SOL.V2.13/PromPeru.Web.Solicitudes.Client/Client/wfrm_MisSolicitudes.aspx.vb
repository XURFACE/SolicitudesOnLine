
Imports MP.DW.BL
Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers

Imports PromPeru.Configuration.Konstantes
Public Class wfrm_MisSolicitudes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cargarListaSolicitud(gViewSol)
        End If
    End Sub

    Private Sub cargarListaSolicitud(ByRef xobjgwv As GridView)
         Dim objBC As New BC.clsBC_SOLICITUDRO

        If Not IsNothing(Session(kstrNombreSession)) Then
            Dim oblUser As New BE.clsBE_CLIENT_USER
            oblUser = CType(Session(kstrNombreSession), BE.clsBE_CLIENT_USER)
            Dim dt As Data.DataTable = objBC.LeerListaToDTSOLICITUDESBYCLIENT(oblUser.lngID)
            xobjgwv.DataSource = dt
            xobjgwv.DataBind()
        End If
    End Sub

    Protected Sub gViewSol_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gViewSol.PageIndexChanging
        gViewSol.PageIndex = e.NewPageIndex
        cargarListaSolicitud(gViewSol)
    End Sub


    Protected Sub gViewSol_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gViewSol.RowCommand
         Dim strCommand As String = e.CommandName
        Dim intIndex As Integer

        If strCommand = "verDet" Then
            intIndex = CInt(e.CommandSource.parent.parent.rowindex)
            Dim objBC As New BC.clsBC_SOLICITUDRO
            Dim oblUser As New BE.clsBE_CLIENT_USER
            oblUser = CType(Session(kstrNombreSession), BE.clsBE_CLIENT_USER)
            Dim dt As Data.DataTable = objBC.LeerListaToDTSOLICITUDESBYCLIENT(oblUser.lngID)
        End If
    End Sub

    Protected Sub gViewSol_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gViewSol.RowDataBound
        'If e.Row.RowType = DataControlRowType.DataRow Then
    End Sub
End Class