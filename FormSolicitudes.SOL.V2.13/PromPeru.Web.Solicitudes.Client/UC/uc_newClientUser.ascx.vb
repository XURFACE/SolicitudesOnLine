
Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL.clsUTL_EnvioCorreo

Imports MP.DW.BL
Imports PromPeru.Configuration.Enumerators
Public Class uc_newClientUser
    Inherits System.Web.UI.UserControl

    Public Property TipoControl As tipoControlUSR
        Set(ByVal value As tipoControlUSR)
            ViewState("_TipoControl_") = value
            btnUpdate.Visible = value = tipoControlUSR.Actualiza_Datos

            imgCmp.Visible = value = tipoControlUSR.Ingresa
            rfvCaptcha.Enabled = value = tipoControlUSR.Ingresa
            txtCodCatpcha.Visible = value = tipoControlUSR.Ingresa
            txtPwd.Enabled = value = tipoControlUSR.Ingresa
            txtpwdConf.Enabled = value = tipoControlUSR.Ingresa
            btnGuardar.Visible = value = tipoControlUSR.Ingresa
            lblrotcapcha.Visible = value = tipoControlUSR.Ingresa
        End Set
        Get
            Return ViewState("_TipoControl_")
        End Get
    End Property

    ''' <summary>
    ''' Id de usuario solo poner en caso se tenga que actualizar
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public WriteOnly Property IDusr As Long
        Set(ByVal value As Long)
            If TipoControl <> tipoControlUSR.Ingresa Then
                hdfId.Value = value
            End If
        End Set
    End Property
    Public Property Redireccionar_Conf As String
        Set(ByVal value As String)

            ViewState("_Redireccionar_") = value
        End Set
        Get
            Return ViewState("_Redireccionar_")
        End Get
    End Property


    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If (txtCodCatpcha.Text <> Session("CaptchaImageText").ToString()) Then
                Throw New Exception("El código de la imagen no corresponde")
            End If
            Dim objbc As New BC.clsBC_CLIENT_USERTX

            Dim objUTLEnvioEmail As New MP.DW.UTL.clsUTL_EnvioCorreo
            Dim random As New Random()
            objbc.oBECLIENT_USER.strNOMUSR = txtNom.Text
            objbc.oBECLIENT_USER.strAPUSR = txtAP.Text
            objbc.oBECLIENT_USER.strAMUSR = txtAM.Text
            objbc.oBECLIENT_USER.strMAILUSR = txtMail.Text
            objbc.oBECLIENT_USER.strPWDUSR = Encripta(Encripta(AlgoritmoDeEncriptacion.MD5, txtPwd.Text))
            DatosAuditoria(objbc.oBECLIENT_USER, Me.ToString.Substring(4), "")
            objbc.oBECLIENT_USER.strCODVERIFICACION = MP.DW.UTL.clsUTL_Helpers.GenerateRandomCode(random)
            objbc.oBECLIENT_USER.strLOGINUSR = txtLogin.Text

            Dim objbcRead As New BC.clsBC_CLIENT_USERRO
            objbcRead.oBECLIENT_USER = objbc.oBECLIENT_USER
            objbcRead.LeerUSUARIOLogIn()
            If objbcRead.oBECLIENT_USER.lngID = 0 Then

                objbc.LstCLIENT_USER.Add(objbc.oBECLIENT_USER)
                objbc.InsertarCLIENT_USER()
                Dim strmsg As String = "Su Código de Verificación es: " & objbc.oBECLIENT_USER.strCODVERIFICACION & " . " & _
                                        vbNewLine & "También puede verificar su cuenta ingresando a " & _
                                        ConfigurationManager.AppSettings("rutaImagenCorto") & "/Public/wfrm_Confirmacion.aspx?CodVer=" & _
                                        Encripta(objbc.oBECLIENT_USER.strCODVERIFICACION) & "&Login=" & Encripta(objbc.oBECLIENT_USER.strLOGINUSR.ToString)

                objUTLEnvioEmail.EnvioEmail(objbc.oBECLIENT_USER.strMAILUSR, objbc.oBECLIENT_USER.strCODVERIFICACION, strmsg)
                Dim stra As String = "{0}?Login={2}&Mail={3}"
                Response.Redirect(String.Format(stra, Redireccionar_Conf, objbc.oBECLIENT_USER.strCODVERIFICACION, Encripta(objbc.oBECLIENT_USER.strLOGINUSR.ToString), Encripta(objbc.oBECLIENT_USER.strMAILUSR)))
            Else
                Throw New Exception("Ya existe un usuario " + objbcRead.oBECLIENT_USER.strLOGINUSR)
            End If
        Catch ex As Exception
            lblMsg.Text = Formatomsgerr(ex.Message.Split(New Char() {"/"}, StringSplitOptions.RemoveEmptyEntries))
            lblMsg.Visible = True
        Finally
            Session("CaptchaImageText") = GenerateRandomCode(New Random)
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Session("CaptchaImageText") = GenerateRandomCode(New Random)
            If TipoControl <> tipoControlUSR.Ingresa Then
                Dim objBC As New BC.clsBC_CLIENT_USERRO
                objBC.oBECLIENT_USER.lngID = hdfId.Value
                objBC.LeerCLIENT_USER()
                If objBC.oBECLIENT_USER.lngID <> 0 Then
                    txtAM.Text = objBC.oBECLIENT_USER.strAMUSR
                    txtAP.Text = objBC.oBECLIENT_USER.strAPUSR
                    txtLogin.Text = objBC.oBECLIENT_USER.strLOGINUSR
                    txtMail.Text = objBC.oBECLIENT_USER.strMAILUSR
                    txtNom.Text = objBC.oBECLIENT_USER.strNOMUSR
                End If
            End If
            txtCodCatpcha.Attributes.Add("onKeyPress", "doClick('" + btnGuardar.ClientID + "',event)")
        End If
    End Sub

    Protected Sub btnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            Dim objBEuser As New BE.clsBE_CLIENT_USER
            objBEuser.lngID = hdfId.Value
            objBEuser.strNOMUSR = txtNom.Text
            objBEuser.strAPUSR = txtAP.Text
            objBEuser.strAMUSR = txtAM.Text
            objBEuser.strMAILUSR = txtMail.Text
            DatosAuditoria(objBEuser, Me.ToString.Substring(4), "")
            objBEuser.strCODVERIFICACION = "VR"
            objBEuser.strLOGINUSR = txtLogin.Text
            Dim objbc As New BC.clsBC_CLIENT_USERTX
            objbc.LstCLIENT_USER.Add(objBEuser)
            objbc.ModificarCLIENT_USER()

        Catch ex As Exception
            lblMsg.Text = ex.Message
        End Try
    End Sub

End Class