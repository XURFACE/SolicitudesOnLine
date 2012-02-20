Public Class wfrm_Usuario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsNothing(Request.QueryString("id")) AndAlso Not String.IsNullOrEmpty(Request.QueryString("id")) Then
            uc_newClientUser1.IDusr = Request.QueryString("id")
        End If
    End Sub

End Class