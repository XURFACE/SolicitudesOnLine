Imports PromPeru.Configuration.Enumerators
Imports PromPeru.Configuration
Imports MP.DW.BL

Public Class WFRM_Paso04
    Inherits System.Web.UI.Page

    Private Sub Btn_Seguir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Seguir.Click

        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            Dim pasos As New Rastro
            Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL

            pasos = CType(Session(Konstantes.kstrPasos), Rastro)



            objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

            Session.Remove("SessionInst")
            Session.Remove("SessionProd")
            Session.Remove("SessionEvent")

            If Not (chbInst.Checked Or chbprod.Checked Or chbEventos.Checked) Then
                lblMessege.Text = "Seleccione una opción"
                lblMessege.Visible = True
                Exit Sub
            End If
            If chbInst.Checked = True Then
                objSolicitudTotal.BE_SOLICITUD_INST.strTIPOLIC = "INSTITUCIONAL"
                objSolicitudTotal.BE_SOLICITUD_INST.strSTSSOL = "En evaluación - Documentación"
                Session("SessionInst") = objSolicitudTotal.BE_SOLICITUD_INST
            End If

            If chbprod.Checked = True Then
                objSolicitudTotal.BE_SOLICITUD_PROD.strTIPOLIC = "PRODUCTO"
                objSolicitudTotal.BE_SOLICITUD_PROD.strSTSSOL = "En evaluación - Documentación"
                Session("SessionProd") = objSolicitudTotal.BE_SOLICITUD_PROD
            End If
            If chbEventos.Checked = True Then
                objSolicitudTotal.BE_SOLICITUD_EVENT.strTIPOLIC = "EVENTO"
                objSolicitudTotal.BE_SOLICITUD_EVENT.strSTSSOL = "En evaluación - Documentación"
                Session("SessionEvent") = objSolicitudTotal.BE_SOLICITUD_EVENT
            End If
            Session(Konstantes.kstrSessionTotal) = objSolicitudTotal

            pasos.PASOS.Push(4)

            If chbInst.Checked Then
                If Not IsNothing(objSolicitudTotal.BE_EMPRESA) AndAlso objSolicitudTotal.BE_EMPRESA.lngID <> 0 Then
                    Dim objbcSol As New BC.clsBC_SOLICITUDRO
                    objbcSol.oBESOLICITUD.strTIPOLIC = "INSTITUCIONAL"
                    objbcSol.oBESOLICITUD.lngIDEMP = objSolicitudTotal.BE_EMPRESA.lngID

                    If objbcSol.LeerListaVigentes().Rows.Count > 0 Then
                        lblMessege.Text = "Ya cuenta con una licencia para USO INSTITUCIONAL"
                        lblMessege.Visible = True
                    Else
                        If objSolicitudTotal.BE_EMPRESA.strTIPOEMPRESA.ToUpper = "ORGANISMO ESTATAL" Then
                            If chbEventos.Checked = True Then
                                Response.Redirect("WFRM_Paso07.aspx")
                            Else
                                Response.Redirect("WFRM_Paso08.aspx")
                            End If
                        Else
                            Response.Redirect("WFRM_Paso05.aspx")
                        End If
                    End If
                Else
                    If objSolicitudTotal.BE_EMPRESA.strTIPOEMPRESA.ToUpper = "ORGANISMO ESTATAL" Then
                        If chbEventos.Checked = True Then
                            Response.Redirect("WFRM_Paso07.aspx")
                        Else
                            Response.Redirect("WFRM_Paso08.aspx")
                        End If
                    Else
                        Response.Redirect("WFRM_Paso05.aspx")
                    End If
                End If
            ElseIf chbprod.Checked = True Then
                Response.Redirect("WFRM_Paso05.aspx")
            ElseIf chbEventos.Checked = True Then
                Response.Redirect("WFRM_Paso07.aspx")
            End If

        End If
    End Sub

    Protected Sub Btn_Cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Cancelar.Click
        Dim pasos As New Rastro
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        Dim page As String = "Main.aspx"
        If Not IsNothing(Session(Konstantes.kstrPasos)) Then
            pasos = CType(Session(Konstantes.kstrPasos), Rastro)
            page = String.Concat("WFRM_Paso0", pasos.PASOS.Pop(), ".aspx?tipo=", objSolicitudTotal.tipo_persona)
        End If
        Response.Redirect(page)

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        If IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            Response.Redirect("WFRM_Paso01.aspx")
        End If

        If Not IsPostBack Then
            If Not IsNothing(Session("SessionInst")) Then
                chbInst.Checked = True
            End If
            If Not IsNothing(Session("SessionProd")) Then
                chbprod.Checked = True
            End If

            If Not IsNothing(Session("SessionEvent")) Then
                chbEventos.Checked = True
            End If


        End If
        If Session(Konstantes.kstrSessionTotal).tipo_persona = Enumerators.tipoPersona.org_estatal Then _
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "", "Ocultarchb(trProd)", True)

    End Sub
End Class