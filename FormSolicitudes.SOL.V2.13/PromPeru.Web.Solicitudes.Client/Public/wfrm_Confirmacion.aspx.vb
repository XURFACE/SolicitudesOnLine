Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.BL
Imports PromPeru.Configuration.Enumerators
Imports PromPeru.Configuration
Public Class wfrm_Confirmacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsNothing(Request.QueryString("CodVer")) AndAlso Not IsNothing(Request.QueryString("Login")) Then
            Confirmar(DesEncripta(Request.QueryString("CodVer")))
        End If
        If Not IsNothing(Request.QueryString("Mail")) Then
            lblMail.Text = DesEncripta(Request.QueryString("Mail"))
        End If
    End Sub
    Private Sub Confirmar(ByVal xstrCodValidacion As String)
        Try
            If IsNothing(Request.QueryString("Login")) Then
                Throw New Exception("Codigo y/o Login no existen")
            End If
            Dim objbcRO As New BC.clsBC_CLIENT_USERRO
            objbcRO.oBECLIENT_USER.strLOGINUSR = DesEncripta(Request.QueryString("Login"))
            objbcRO.LeerUSUARIOLogIn()
            If objbcRO.oBECLIENT_USER.strCODVERIFICACION = xstrCodValidacion Then
                Dim objBEuser As New BE.clsBE_CLIENT_USER
                objBEuser = objbcRO.oBECLIENT_USER
                DatosAuditoria(objBEuser, Me.ToString.Substring(4), "")
                Dim objbcTX As New BC.clsBC_CLIENT_USERTX
                objBEuser.intESTADOUSR = 1
                objbcTX.LstCLIENT_USER.Add(objBEuser)
                objbcTX.ModificarCLIENT_USER()
                Session(Konstantes.kstrNombreSession) = objBEuser
            End If
            Response.Redirect("../Client/Main.aspx")
        Catch ex As Exception
            lblMessege.Text = ex.Message
            lblMessege.Visible = True
        End Try
    End Sub
    Protected Sub btnConfirmar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Confirmar(txtValidacion.Text)
    End Sub
End Class