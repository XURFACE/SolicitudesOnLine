Imports PromPeru.Configuration

Public Class WFRM_Termino
    Inherits System.Web.UI.Page

    Protected Sub btn_final_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_final.Click
        Response.Redirect("wfrm_MisSolicitudes.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Session(Konstantes.kstrSessionTotal) = Nothing
        Session(Konstantes.kstrPasos) = Nothing
        Session("SessionInst") = Nothing
        Session("SessionProd") = Nothing
        Session("SessionEvent") = Nothing
        Session("DetUso") = Nothing
        Session("cllObjProductosMarca") = Nothing
        Session("cllObjProductos") = Nothing
        Session("rutaApl") = Nothing

        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.AppendHeader("Pragma", "no-cache")
        Response.AppendHeader("Cache-Control", "no-store")
        Response.AppendHeader("Expires", "-1")

        Response.Expires = 0
        Response.Cache.SetNoStore()
        Response.AppendHeader("Pragma", "no-cache")

    End Sub
End Class