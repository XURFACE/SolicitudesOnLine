Imports MP.DW.BL
Imports PromPeru.Configuration.Konstantes
Public Class main
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As BE.clsBE_CLIENT_USER = CType(Session(kstrNombreSession), BE.clsBE_CLIENT_USER)
        If Not IsNothing(obj) Then
            'hplnkActDts.NavigateUrl = "~/usuario/wfrm_Actualizardatos.aspx?Iduser=" & obj.lngID
            'Master.strNombreUsuario = obj.strNOMUSR
        End If
    End Sub

End Class