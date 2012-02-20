Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.BL
Imports PromPeru.Configuration.Konstantes

Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim objBC_USUARIO As BE.clsBE_CLIENT_USER

        If Not IsNothing(Session(kstrNombreSession)) Then
            objBC_USUARIO = Session(kstrNombreSession)
            Response.Redirect("Client/main.aspx")
        Else
            Response.Redirect("Public/wfrm_NewSolicitud.aspx")
        End If
        
    End Sub

End Class