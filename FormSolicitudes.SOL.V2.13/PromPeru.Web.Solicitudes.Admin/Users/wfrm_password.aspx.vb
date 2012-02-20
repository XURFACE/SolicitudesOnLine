Imports MP.DW.BL
Imports PromPeru.Configuration.Konstantes
Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Public Class wfrm_password
    Inherits System.Web.UI.Page



    Protected Sub btnPwd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPwd.Click
        Try
            If Not IsNothing(Session(kstrNombreSessionAdm)) Then
                Dim objBCRead As New BC.clsBC_USUARIORO
                objBCRead.oBEUSUARIO.intID = CType(Session(kstrNombreSessionAdm), BE.clsBE_USUARIO).intID
                objBCRead.LeerUSUARIO()
                If Encripta(AlgoritmoDeEncriptacion.MD5, txtPwdact.Text) = DesEncripta(objBCRead.oBEUSUARIO.strPASSWORD) Then
                    Dim objBCWrite As New BC.clsBC_USUARIOTX
                    objBCWrite.oBEUSUARIO = CType(Session(kstrNombreSessionAdm), BE.clsBE_USUARIO)
                    objBCWrite.oBEUSUARIO.strPASSWORD = Encripta(Encripta(AlgoritmoDeEncriptacion.MD5, txtpwd.Text))
                    DatosAuditoria(objBCWrite.oBEUSUARIO, "ActualizaPwd", "")
                    objBCWrite.LstUSUARIO.Add(objBCWrite.oBEUSUARIO)
                    objBCWrite.ModificarUSUARIO()
                    ScriptManager.RegisterStartupScript(Me, Me.GetType, "", "parent.$.modal().closePopup();", True)
                Else
                    Throw New Exception("Contraseña actual incorrecta")
                End If
            End If
        Catch ex As Exception
            lblMsg.Text = ex.Message
            lblMsg.Visible = True
        End Try

    End Sub
End Class