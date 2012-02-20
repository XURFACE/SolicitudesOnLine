Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.BL
Imports PromPeru.Configuration.Konstantes

Public Class backloadingpage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not IsNothing(Request.QueryString("logintoken"))) Then

            Dim objBC_USUARIO As New BC.clsBC_CLIENT_USERRO
            objBC_USUARIO.oBECLIENT_USER.lngID = CType(Request.QueryString("logintoken"), Long)
            objBC_USUARIO.LeerCLIENT_USER()
            Session(kstrNombreSession) = objBC_USUARIO.oBECLIENT_USER

            Response.Redirect("/Solicitudes/Client/main.aspx")
        End If

    End Sub

End Class