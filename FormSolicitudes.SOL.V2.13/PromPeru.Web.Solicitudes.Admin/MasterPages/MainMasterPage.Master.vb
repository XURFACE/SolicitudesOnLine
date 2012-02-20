Imports PromPeru.Configuration.Konstantes
Public Class MainMasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsNothing(Session(kstrNombreSessionAdm)) Then
            lblNomUsr.Text = CType(Session(kstrNombreSessionAdm), MP.DW.BL.BE.clsBE_USUARIO).strNOMBRE
        Else
            Response.Redirect("../login.aspx")
        End If
    End Sub

    Protected Sub BLogOut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BLogOut.Click
        Session(kstrNombreSessionAdm) = Nothing
        Response.Redirect("../login.aspx")
    End Sub
End Class