Imports MP.DW.BL
Imports MP.DW.BL.BC
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL
Imports System.Data
Imports PromPeru.Configuration.Enumerators
Imports PromPeru.Configuration
Imports Subgurim.Controles
Public Class WFRM_Paso07
    Inherits System.Web.UI.Page
    Protected Sub Btn_Seguir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Seguir.Click
        Dim pasos As New Rastro
        Dim strMsg As String = ""
        Dim guid As String = "public"
        pasos = CType(Session(Konstantes.kstrPasos), Rastro)



        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
            objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)


            objSolicitudTotal.BE_EVENTO.strNOMBRE = txtNomEvento.Text
            objSolicitudTotal.BE_EVENTO.strORGANIZADOR = txtOrg.Text
            objSolicitudTotal.BE_EVENTO.strREFERENCIA = txtRefEvento.Text
            objSolicitudTotal.BE_EVENTO.strDESCRIPCION = txtDescEvento.Text

            'objSolicitudTotal.BE_EVENTO.strRUTAAGENDA = AdjRef.FileName.ToString

            objSolicitudTotal.BE_EVENTO.strNUMEDICION = txtEdicEvento.Text
            objSolicitudTotal.BE_EVENTO.intTIPOPERIODO = CType(txtPeriEvento.Text, Int32)
            objSolicitudTotal.BE_EVENTO.strLUGAR = txtRealiz.Text
            'IIf(txtFecha.Text <> "", objSolicitudTotal.BE_EVENTO.dtmFECHA = txtFecha.Text, txtFecha.Text = "")

            objSolicitudTotal.BE_EVENTO.strDESCPUBLICOGRL = txtDescPGEvento.Text
            objSolicitudTotal.BE_EVENTO.intNUMPART = CType(txtPtesAtes.Text, Int32)
            objSolicitudTotal.BE_EVENTO.dblCOSTOPROM = CType(txtCPartAsistEvento.Text, Double)
            objSolicitudTotal.BE_EVENTO.strAUSPICIADORES = txtAuspPatron.Text

            objSolicitudTotal.BE_EVENTO.strRUTAAGENDA = guardarArchivosPaso(FUAjaxRef)
            'If crearCarpeta(ConfigurationManager.AppSettings("RutaSubida"), strMsg, guid) Then
            '    objSolicitudTotal.BE_EVENTO.strRUTAAGENDA = strMsg & IIf(lblAPE.Text <> "", lblAPE.Text, AdjRef.FileName)
            '    ' Subirarchivo(AdjRef, objSolicitudTotal.BE_EVENTO.strRUTAAGENDA)

            'End If

            Session(Konstantes.kstrSessionTotal) = objSolicitudTotal

        End If



        ''Try
        'Dim objclsBC_SOLICITUDTX As New BC.clsBC_SOLICITUDTX
        'Dim objSolicitud As New BE.clsBE_SOLICITUD
        'objSolicitud = CType(Session("SessionEvent"), BE.clsBE_SOLICITUD)
        'DatosAuditoria(objSolicitud, Me.ToString.Substring(4), "")
        'objclsBC_SOLICITUDTX.LstSOLICITUD.Add(objSolicitud)
        'objclsBC_SOLICITUDTX.InsertarSOLICITUD()
        'Session("SessionEvent") = objclsBC_SOLICITUDTX.LstSOLICITUD(0)


        'Dim objclsBC_EVENTOTX As New clsBC_EVENTOTX
        'Dim objEvento As New BE.clsBE_EVENTO()
        'objEvento.strNOMBRE = txtNomEvento.Text
        'objEvento.lngIDSOLICITUD = objclsBC_SOLICITUDTX.LstSOLICITUD(0).lngID
        'objEvento.BE_SOLICITUD = objclsBC_SOLICITUDTX.LstSOLICITUD(0)
        'objEvento.strORGANIZADOR = txtOrg.Text
        'objEvento.strREFERENCIA = txtRefEvento.Text
        'objEvento.strDESCRIPCION = txtDescEvento.Text
        'objEvento.strRUTAAGENDA = AdjRef.FileName.ToString
        'objEvento.strNUMEDICION = txtEdicEvento.Text
        'objEvento.intTIPOPERIODO = CType(txtPeriEvento.Text, Int32)
        'objEvento.strLUGAR = txtRealiz.Text
        'objEvento.dtmFECHA = txtFecha.Text
        'objEvento.strDESCPUBLICOGRL = txtDescPGEvento.Text
        'objEvento.intNUMPART = CType(txtPtesAtes.Text, Int32)
        'objEvento.dblCOSTOPROM = CType(txtCPartAsistEvento.Text, Double)
        'objEvento.strAUSPICIADORES = txtAuspPatron.Text

        'DatosAuditoria(objEvento, Me.ToString.Substring(4), "")

        'objclsBC_EVENTOTX.LstEVENTO.Add(objEvento)

        'If objclsBC_EVENTOTX.InsertarEVENTO() Then
        '    Dim strMsg As String = ""
        '    Dim lstclsBE_EVENTO As New List(Of BE.clsBE_EVENTO)
        '    For Each objEvent As BE.clsBE_EVENTO In objclsBC_EVENTOTX.LstEVENTO
        '        If crearCarpeta(ConfigurationManager.AppSettings("RutaSubida"), strMsg, CstrMP(objEvento.lngID)) Then
        '            objEvent.strRUTAAGENDA = strMsg & AdjRef.FileName
        '            Subirarchivo(AdjRef, objEvent.strRUTAAGENDA)

        '            lstclsBE_EVENTO.Add(objEvent)
        '        End If

        '        objclsBC_EVENTOTX.LstEVENTO = lstclsBE_EVENTO

        '        Session("idEvento") = objclsBC_EVENTOTX.LstEVENTO(0).lngID
        '        If objclsBC_EVENTOTX.ModificarEVENTO() Then

        '            Response.Redirect("WFRM_Paso08.aspx")
        '        End If
        '    Next
        'End If


        'Catch ex As Exception

        'End Try
        pasos.PASOS.Push(7)
        Response.Redirect("WFRM_Paso08.aspx")
    End Sub
    Private Sub Subirarchivo(ByVal xfup As FileUpload, ByVal xstrRuta As String)
        Try
            If xfup.HasFile Then
                xfup.SaveAs(xstrRuta)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub bt_atras_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_atras.Click
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
                Dim file() As String
                objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)


                txtNomEvento.Text = objSolicitudTotal.BE_EVENTO.strNOMBRE
                txtOrg.Text = objSolicitudTotal.BE_EVENTO.strORGANIZADOR
                txtRefEvento.Text = objSolicitudTotal.BE_EVENTO.strREFERENCIA
                txtDescEvento.Text = objSolicitudTotal.BE_EVENTO.strDESCRIPCION
                txtEdicEvento.Text = objSolicitudTotal.BE_EVENTO.strNUMEDICION
                txtPeriEvento.Text = objSolicitudTotal.BE_EVENTO.intTIPOPERIODO
                txtRealiz.Text = objSolicitudTotal.BE_EVENTO.strLUGAR
                txtFecha.Text = IIf(objSolicitudTotal.BE_EVENTO.dtmFECHA Is Nothing, "", objSolicitudTotal.BE_EVENTO.dtmFECHA.ToString)
                txtDescPGEvento.Text = objSolicitudTotal.BE_EVENTO.strDESCPUBLICOGRL
                txtPtesAtes.Text = objSolicitudTotal.BE_EVENTO.intNUMPART
                txtCPartAsistEvento.Text = objSolicitudTotal.BE_EVENTO.dblCOSTOPROM
                txtAuspPatron.Text = objSolicitudTotal.BE_EVENTO.strAUSPICIADORES


                If objSolicitudTotal.BE_EVENTO.strRUTAAGENDA <> "" Then
                    file = objSolicitudTotal.BE_EVENTO.strRUTAAGENDA.Split("\")
                    If file(file.Length - 1) <> "" Then
                        FUAjaxRef.Visible = False
                        ' AdjRef.Visible = False
                        lnkAPE.Visible = True
                        btnAPE.Visible = True
                        lnkAPE.Text = file(file.Length - 1)
                    End If

                End If
            End If
        End If
        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            guardarArchivos()
        End If
    End Sub
    Private Sub guardarArchivos()
        Dim objSolTtl As BE.clsBE_SOLICITUDTOTAL = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        If FUAjaxRef.IsPosting Then
            ' objSolTtl.BE_EVENTO.strRUTAAGENDA = clsUTL_AjaxFU.managePost(FUAjaxRef)
            clsUTL_AjaxFU.managePost(FUAjaxRef)
        End If
    End Sub
    Private Function guardarArchivosPaso(ByRef FUAjax As FileUploaderAJAX)
        Dim rutas As List(Of String)
        rutas = clsUTL_AjaxFU.historialFUAjax(FUAjax)
        If Not IsNothing(rutas) Then
            If rutas.Count > 0 Then
                Return rutas(0).ToString
            End If
        End If
        Return ""
    End Function

    Protected Sub btnAPE_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAPE.Click
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        objSolicitudTotal.BE_EVENTO.strRUTAAGENDA = ""
        Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
        btnAPE.Visible = False
        lnkAPE.Visible = False
        lnkAPE.Text = ""
        'AdjRef.Visible = True
        FUAjaxRef.Visible = True
    End Sub
End Class

