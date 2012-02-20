
Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL.clsUTL_EnvioCorreo
Imports MP.DW.BL
Imports PromPeru.Configuration.Enumerators
Public Class uc_RestorePwd
    Inherits System.Web.UI.UserControl

    Protected Sub btnSolicitar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSolicitar.Click
        Try
            If (txtCodCatpcha.Text <> Session("CaptchaImageText").ToString()) Then
                Throw New Exception("El código de la imagen no corresponde")
            End If
            'Busca el usuario
            Dim objBC_USUARIO As New BC.clsBC_CLIENT_USERRO
            objBC_USUARIO.oBECLIENT_USER.strLOGINUSR = txtusrMail.Text
            objBC_USUARIO.LeerUSUARIOLogIn()
            If objBC_USUARIO.oBECLIENT_USER.lngID = 0 Then
                Throw New Exception("El usuario no existe")
            End If
            Dim objBC_USUARIOtx As New BC.clsBC_CLIENT_USERTX
            objBC_USUARIO.oBECLIENT_USER.strCODVERIFICACION = MP.DW.UTL.clsUTL_Helpers.GenerateRandomCode(New Random)
            objBC_USUARIOtx.LstCLIENT_USER.Add(objBC_USUARIO.oBECLIENT_USER)
            objBC_USUARIOtx.ModificarCLIENT_USER()
            ''Genera codigo de restauracion
            'Dim objBCrest As New BC.clsBC_RESTAURAPWDTX
            'Dim objRest As New BE.clsBE_RESTAURAPWD
            'objRest.strCODUSUARIO = txtusrMail.Text
            'objRest.uidCLAVECONFIRMACION = Guid.NewGuid
            'objBCrest.LstRESTAURAPWD.Add(objRest)
            'objBCrest.InsertarRESTAURAPWD()

            Dim strmsgBody = String.Format("Este es un correo para restauración de contraseña para hacerlo ingrese a esta ruta {0} y ponga la siguiente clave: {1} donde se solicita", _
                                           ConfigurationManager.AppSettings("rutaImagenCorto") & "/Public/wfrm_NewPassword.aspx?cod=" & Encripta(objBC_USUARIO.oBECLIENT_USER.strLOGINUSR), _
                                           CstrMP(objBC_USUARIO.oBECLIENT_USER.strCODVERIFICACION))
            Dim objUTLEnvioEmail As New MP.DW.UTL.clsUTL_EnvioCorreo
            objUTLEnvioEmail.EnvioEmail(objBC_USUARIO.oBECLIENT_USER.strMAILUSR, CstrMP(objBC_USUARIO.oBECLIENT_USER.strCODVERIFICACION), strmsgBody, "Restaurar Password")

            ScriptManager.RegisterStartupScript(Me, Me.GetType, "", "parent.$.modal().closePopup();", True)
        Catch ex As Exception
            ltrMsg.Text = Formatomsgerr(ex.Message.Split(New Char() {"/"}, StringSplitOptions.RemoveEmptyEntries))
        Finally
            Session("CaptchaImageText") = GenerateRandomCode(New Random)
        End Try

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Session("CaptchaImageText") = GenerateRandomCode(New Random)
        End If
    End Sub

End Class