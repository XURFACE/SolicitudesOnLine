
Public Class wfrm_ChangePwd
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsNothing(Request.QueryString("idUser")) Then
            uc_changePwd1.Login = Request.QueryString("idUser")
        End If
    End Sub

End Class