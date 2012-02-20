Imports MP.DW.BL
Imports MP.DW.UTL.clsUTL_EnvioCorreo
Imports MP.DW.UTL.clsUTL_Helpers
Imports PromPeru.Configuration
Public Class wfrm_CmbEstado
    Inherits System.Web.UI.Page
    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        Try
            Dim idsol As Int32
            Dim objSOLICITUDTX As New BC.clsBC_SOLICITUDTX
            Dim objSOLICITUDRO As New BC.clsBC_SOLICITUDRO
            Dim objSol As New BE.clsBE_SOLICITUD

            Dim xMsgSubject As String = "Autorización de Uso - Marca Perú"
            If Not IsNothing(Request.QueryString("idsol")) Then
                idsol = CType(Request.QueryString("idsol"), Int32)
                objSOLICITUDRO.oBESOLICITUD.lngID = idsol
                objSOLICITUDRO.LeerSOLICITUD()
                objSol = objSOLICITUDRO.oBESOLICITUD

                objSol.strSTSSOL = dllCamEst.SelectedItem.ToString
                DatosAuditoria(objSol, "Administrador", "")
                objSOLICITUDTX.LstSOLICITUD.Add(objSol)
                objSOLICITUDTX.ModificarSOLICITUD()


                If Not IsNothing(Request.QueryString("id")) Then
                    Dim objEMPRESARO As New BC.clsBC_EMPRESARO
                    Dim objEMPRESATX As New BC.clsBC_EMPRESATX

                    objEMPRESARO.oBEEMPRESA.lngID = CType(Request.QueryString("id"), Int32)
                    objEMPRESARO.LeerEMPRESA()

                    objEMPRESARO.oBEEMPRESA.dblMONTODEUDA = CType(txtMontDeu.Text, Double)

                    Dim strmsg As New StringBuilder
                    For Each Str As String In txtMsg.Text
                        If Asc(Str) = 13 Then
                            Str = "<br>"
                        End If
                        strmsg.Append(Str)
                    Next
                    Dim mailTo As String

                    If dllCamEst.SelectedItem.Text.ToUpper.Equals("APROBADO") Then
                        mailTo = String.Format("{0},{1}", objEMPRESARO.oBEEMPRESA.strEMAIL, ConfigurationManager.AppSettings("MailtoEstado" & dllCamEst.SelectedValue))
                        SendSimpleMessage(xMsgSubject, mailTo, "", "Solicitud Aprobada", _
                                          "&nbsp;", _
                                          strmsg.ToString, _
                                          ConfigurationManager.AppSettings("ServerSMTP"), ConfigurationManager.AppSettings("PortSMTP"))
                    Else
                        mailTo = ConfigurationManager.AppSettings("MailtoEstado" & dllCamEst.SelectedValue)
                        xMsgSubject = "Cambio de estado - empresa " & objEMPRESARO.oBEEMPRESA.strRAZONSOCIAL
                        SendSimpleMessage(xMsgSubject, mailTo, "", "Solicitud de uso de la Marca País Perú - " & objSOLICITUDRO.oBESOLICITUD.strTIPOLIC, _
                                          "Empresa: " & objEMPRESARO.oBEEMPRESA.strRAZONSOCIAL & "<br>En estado " & dllCamEst.SelectedItem.Text, _
                                          strmsg.ToString, _
                                          ConfigurationManager.AppSettings("ServerSMTP"), ConfigurationManager.AppSettings("PortSMTP"))
                    End If
                    objEMPRESATX.LstEMPRESA.Add(objEMPRESARO.oBEEMPRESA)
                    objEMPRESATX.ModificarEMPRESA()
                End If
            End If
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "", "recargar()", True)
        Catch ex As Exception
            ltrMsg.Text = Formatomsgerr(ex.Message.Split(New Char() {"/"}, StringSplitOptions.RemoveEmptyEntries))
        End Try

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim objSOLICITUDRO As New BC.clsBC_SOLICITUDRO
        If Not IsPostBack Then
            Dim objSol As New BE.clsBE_SOLICITUD
            If Not IsNothing(Request.QueryString("idsol")) Then
                ID = CType(Request.QueryString("idsol"), Int32)
                objSOLICITUDRO.oBESOLICITUD.lngID = ID
                objSOLICITUDRO.LeerSOLICITUD()

                If Not IsNothing(Request.QueryString("id")) Then
                    Dim objEMPRESARO As New BC.clsBC_EMPRESARO
                    objEMPRESARO.oBEEMPRESA.lngID = CType(Request.QueryString("id"), Int32)
                    objEMPRESARO.LeerEMPRESA()
                    If Not IsNothing(objEMPRESARO.oBEEMPRESA.dblMONTODEUDA) Then
                        txtMontDeu.Text = objEMPRESARO.oBEEMPRESA.dblMONTODEUDA
                    End If
                    'If objSOLICITUDRO.oBESOLICITUD.strSTSSOL.Trim.ToUpper <> "APROBADO" Then
                    '    txtMsg.Text = PromPeru.Configuration.Mail_messege.BodyMessege(objEMPRESARO.oBEEMPRESA, objSOLICITUDRO.oBESOLICITUD).Replace("<br>", "\n")
                    'End If
                End If
                lblEval.Text = objSOLICITUDRO.oBESOLICITUD.strSTSSOL
                lblLic.Text = objSOLICITUDRO.oBESOLICITUD.strNUMLIC
            End If
        End If
    End Sub

    Protected Sub dllCamEst_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dllCamEst.SelectedIndexChanged
        If dllCamEst.SelectedItem.Text.ToUpper.Equals("APROBADO") Then
            Dim objSol As New BE.clsBE_SOLICITUD
            Dim objSOLICITUDRO As New BC.clsBC_SOLICITUDRO
            If Not IsNothing(Request.QueryString("idsol")) Then
                ID = CType(Request.QueryString("idsol"), Int64)
                objSOLICITUDRO.oBESOLICITUD.lngID = ID
                objSOLICITUDRO.LeerSOLICITUD()

                If Not IsNothing(Request.QueryString("id")) Then
                    Dim objEMPRESARO As New BC.clsBC_EMPRESARO
                    objEMPRESARO.oBEEMPRESA.lngID = CType(Request.QueryString("id"), Int64)
                    objEMPRESARO.LeerEMPRESA()
                    If Not IsNothing(objEMPRESARO.oBEEMPRESA.dblMONTODEUDA) Then
                        txtMontDeu.Text = objEMPRESARO.oBEEMPRESA.dblMONTODEUDA
                    End If
                    If objSOLICITUDRO.oBESOLICITUD.strSTSSOL.Trim.ToUpper <> "APROBADO" Then
                        txtMsg.Text = Mail_messege.BodyMessege(objEMPRESARO.oBEEMPRESA, objSOLICITUDRO.oBESOLICITUD)
                    End If
                End If
                lblEval.Text = objSOLICITUDRO.oBESOLICITUD.strSTSSOL
            End If
        Else
            txtMsg.Text = ""
        End If
        ocultar1.Visible = dllCamEst.SelectedValue = 7
        ocultar2.Visible = dllCamEst.SelectedValue = 7
    End Sub
End Class