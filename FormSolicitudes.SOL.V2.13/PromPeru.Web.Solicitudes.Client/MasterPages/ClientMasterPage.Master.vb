Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.BL
Imports PromPeru.Configuration.Konstantes

Public Class ClientMasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objBC_USUARIO As BE.clsBE_CLIENT_USER

        If Not IsNothing(Session(kstrNombreSession)) Then
            objBC_USUARIO = Session(kstrNombreSession)
            lblNomUsr.Text = objBC_USUARIO.strNOMUSR & Space(1) & objBC_USUARIO.strAPUSR & Space(1) & objBC_USUARIO.strAMUSR
            Dim strms As String = ""
            Dim arrExp As String() = objBC_USUARIO.strEXPEDIENTES.Split(New Char() {"/"}, StringSplitOptions.RemoveEmptyEntries)
            If arrExp.Length > 0 Then
                For i As Integer = 0 To arrExp.Length - 1
                    Dim Str As String = arrExp(i)
                    If i = 2 And i < arrExp.Length - 1 Then
                        lnkVertodos.Visible = True
                        Exit For
                    End If
                    strms += Str + "<br>"
                Next
            End If
            lblNumReg.Text = strms
            lnkChangPwd.NavigateUrl = "../Public/wfrm_ChangePwd.aspx?idUser=" & CstrMP(objBC_USUARIO.strLOGINUSR)
        Else
            CleanSessions()
            Response.Redirect("../index.aspx")
        End If
    End Sub

    Protected Sub BLogOut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BLogOut.Click
        Session(kstrNombreSession) = Nothing
        CleanSessions()

        Response.Redirect("../index.aspx")
    End Sub


    Private Sub CleanSessions()
        Session(kstrSessionTotal) = Nothing
        Session(kstrPasos) = Nothing
        Session("SessionInst") = Nothing
        Session("SessionProd") = Nothing
        Session("SessionEvent") = Nothing
        Session("DetUso") = Nothing
        Session("cllObjProductosMarca") = Nothing
        Session("cllObjProductos") = Nothing
        Session("rutaApl") = Nothing
    End Sub

    Protected Sub LBSolicitar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBSolicitar.Click
        CleanSessions()
        Response.Redirect("../Client/wfrm_Paso01.aspx")

    End Sub

    Protected Sub LBUso_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBUso.Click
        CleanSessions()
        Response.Redirect("/#use")
    End Sub

    Protected Sub LBMisSol_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBMisSol.Click
        CleanSessions()
        Response.Redirect("../Client/wfrm_MisSolicitudes.aspx")
    End Sub
End Class