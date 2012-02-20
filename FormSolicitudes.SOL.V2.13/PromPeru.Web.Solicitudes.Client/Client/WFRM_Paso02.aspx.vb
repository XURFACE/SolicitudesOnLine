Imports PromPeru.Configuration.Enumerators
Imports PromPeru.Configuration
Imports MP.DW.BL
Public Class WFRM_Paso02
    Inherits System.Web.UI.Page



    Private Sub Btn_Seguir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Seguir.Click
        Dim pasos As New Rastro
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        pasos = CType(Session(Konstantes.kstrPasos), Rastro)
        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
            Dim strTipo As String = ""

            If Rb_pjuridica.Checked Then
                objSolicitudTotal.tipo_persona = 0
                objSolicitudTotal.BE_EMPRESA.strTIPOEMPRESA = "Persona Jurídica"
                Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
                strTipo = tipoPersona.juridico
            End If

            If Rb_pJuridicaExt.Checked Then
                objSolicitudTotal.tipo_persona = 1
                objSolicitudTotal.BE_EMPRESA.strTIPOEMPRESA = "Persona Jurídica Extranjera"
                Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
                strTipo = tipoPersona.juridico_Extrangero
            End If

            If Rb_pnaturalneg.Checked Then
                objSolicitudTotal.tipo_persona = 2
                objSolicitudTotal.BE_EMPRESA.strTIPOEMPRESA = "Persona Natural con Negocio"
                Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
                strTipo = tipoPersona.natural_Negocio
            End If

            If Rb_orgestatal.Checked Then
                objSolicitudTotal.tipo_persona = 3
                objSolicitudTotal.BE_EMPRESA.strTIPOEMPRESA = "Organismo Estatal"
                Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
                strTipo = tipoPersona.org_estatal
            End If
            If String.IsNullOrEmpty(strTipo) Then
                lblMsjError.Visible = True
                lblMsjError.Text = "Debe seleccionar un tipo de persona"
                Exit Sub
            End If
            pasos.PASOS.Push(2)
            ResponseRedirect(strTipo)
        End If
    End Sub
    Private Sub ResponseRedirect(ByVal xstrtTipo As String)
        Dim strbld As New Text.StringBuilder
        If Not IsNothing(Request.QueryString("id")) Then
            strbld.Append("id=" & Request.QueryString("id") & "&")
        End If
        If Not IsNothing(Request.QueryString("idsol")) Then
            strbld.Append("idsol=" & Request.QueryString("idsol"))
        End If

        Response.Redirect("WFRM_Paso03.aspx?tipo=" & xstrtTipo & "&" & strbld.ToString)
    End Sub
    Protected Sub Btn_Cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Dim pasos As New Rastro
        Dim page As String = "Main.aspx"
        If Not IsNothing(Session(Konstantes.kstrPasos)) Then
            pasos = CType(Session(Konstantes.kstrPasos), Rastro)
            page = String.Concat("WFRM_Paso0", pasos.PASOS.Pop(), ".aspx")
        End If
        Response.Redirect(page)
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        If IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            Response.Redirect("WFRM_Paso01.aspx")
        End If

        If Not IsPostBack Then
            If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
                Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
                objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
                If objSolicitudTotal.tipo_persona = tipoPersona.juridico Then
                    Rb_pjuridica.Checked = True
                ElseIf objSolicitudTotal.tipo_persona = tipoPersona.juridico_Extrangero Then
                    Rb_pJuridicaExt.Checked = True
                ElseIf objSolicitudTotal.tipo_persona = tipoPersona.natural_Negocio Then
                    Rb_pnaturalneg.Checked = True
                ElseIf objSolicitudTotal.tipo_persona = tipoPersona.org_estatal Then
                    Rb_orgestatal.Checked = True
                End If

            End If

        End If
        If Not IsNothing(Request.QueryString("tipo")) Then
            Rb_pjuridica.Checked = Request.QueryString("tipo") = tipoPersona.juridico
            Rb_pJuridicaExt.Checked = Request.QueryString("tipo") = tipoPersona.juridico_Extrangero
            Rb_pnaturalneg.Checked = Request.QueryString("tipo") = tipoPersona.natural_Negocio
            Rb_orgestatal.Checked = Request.QueryString("tipo") = tipoPersona.org_estatal
        End If
    End Sub
End Class