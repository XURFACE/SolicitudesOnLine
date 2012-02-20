Public Class WFRM_FELIC
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btbMisSol_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btbMisSol.Click
        Response.Redirect("WFRM_MisSolicitudes.aspx")
    End Sub
End Class