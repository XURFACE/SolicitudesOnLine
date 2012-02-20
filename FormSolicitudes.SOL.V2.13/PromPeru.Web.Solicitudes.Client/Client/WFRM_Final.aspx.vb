Imports PromPeru.Configuration
Imports MP.DW.BL
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL
Imports System.Data
Imports Subgurim.Controles
Imports System.Configuration.ConfigurationManager
Public Class WFRM_Final
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
                Dim objSolicitudTotal As BE.clsBE_SOLICITUDTOTAL = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
                If Not IsNothing(objSolicitudTotal.BE_EMPRESA) Then
                    txtTipoEmpresa.Text = objSolicitudTotal.tipo_persona
                    txtRepresentante.Text = objSolicitudTotal.BE_EMPRESA.strREPRESENTANTE
                    txtCargo.Text = objSolicitudTotal.BE_EMPRESA.strCARGO
                    txtdniRepr.Text = objSolicitudTotal.BE_EMPRESA.strDNI
                    lblNameGiro.Text = objSolicitudTotal.BE_EMPRESA.strGIRO

                    txtWeb.Text = objSolicitudTotal.BE_EMPRESA.strWEB
                    txtDireccion.Text = objSolicitudTotal.BE_EMPRESA.strDOMICILIO
                    txtTelefono.Text = objSolicitudTotal.BE_EMPRESA.strNUMTEL
                    txtmail.Text = objSolicitudTotal.BE_EMPRESA.strEMAIL
                    txtContacto.Text = objSolicitudTotal.BE_EMPRESA.strNOMPERCONTACTO
                    Txt_RUC.Text = objSolicitudTotal.BE_EMPRESA.strRUC

                    txtRazonSoc.Text = objSolicitudTotal.BE_EMPRESA.strRAZONSOCIAL
                    txtPartida.Text = objSolicitudTotal.BE_EMPRESA.strNUMPARTIDA
                    lbldpto.Text = objSolicitudTotal.BE_EMPRESA.strNOMBREDPTO
                    lblProv.Text = objSolicitudTotal.BE_EMPRESA.strNOMBREPROV
                    lblDistr.Text = objSolicitudTotal.BE_EMPRESA.strNOMBREDIST
                    lblAct.Text = objSolicitudTotal.BE_EMPRESA.strCOMPROMISO
                    lbldetProg.Text = objSolicitudTotal.BE_EMPRESA.strDET_PROGRAMASOCIAL
                    lblNomProg.Text = objSolicitudTotal.BE_EMPRESA.strNOMBREPROGRAMASOCIAL

                    trProgRotNom.Visible = objSolicitudTotal.BE_EMPRESA.strNOMBREPROGRAMASOCIAL.Trim.Length > 0
                    trProgNom.Visible = objSolicitudTotal.BE_EMPRESA.strNOMBREPROGRAMASOCIAL.Trim.Length > 0
                    trProgRotDet.Visible = objSolicitudTotal.BE_EMPRESA.strDET_PROGRAMASOCIAL.Trim.Length > 0
                    trProgDet.Visible = objSolicitudTotal.BE_EMPRESA.strDET_PROGRAMASOCIAL.Trim.Length > 0

                    txtCgoRepres.Text = objSolicitudTotal.BE_EMPRESA.strCARGOREPRESENTANTE
                    txtCiudad.Text = objSolicitudTotal.BE_EMPRESA.strCIUDAD
                    txtPais.Text = objSolicitudTotal.BE_EMPRESA.strPAIS

                    If objSolicitudTotal.BE_EMPRESA.strRUTARUC <> "" Then
                        lnkRuc.NavigateUrl = objSolicitudTotal.BE_EMPRESA.strRUTARUC
                        lnkRuc.Text = "ver RUC"
                    End If
                    lnkRuc.Visible = objSolicitudTotal.BE_EMPRESA.strRUTARUC <> ""

                    If objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA <> "" Then
                        lnkLF.NavigateUrl = objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA
                        lnkLF.Text = "ver licencia"
                    End If
                    lnkLF.Visible = objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA <> ""

                    If objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER <> "" Then
                        lnkVP.NavigateUrl = objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER
                        lnkVP.Text = "ver vigencia"
                    Else
                        lnkVP.Text = ""
                    End If
                    lnkVP.Visible = objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER <> ""

                    If objSolicitudTotal.BE_EMPRESA.strRUTADNI <> "" Then
                        lnkDNI.NavigateUrl = objSolicitudTotal.BE_EMPRESA.strRUTADNI
                        lnkDNI.Text = "ver documento de identidad"
                    Else
                        lnkDNI.Text = ""
                    End If
                    lnkDNI.Visible = objSolicitudTotal.BE_EMPRESA.strRUTADNI <> ""
                    trRotProd1.Visible = Not IsNothing(Session("SessionProd"))
                    trRotProd2.Visible = Not IsNothing(Session("SessionProd"))
                    trEvento.Visible = Not IsNothing(Session("SessionEvent"))
                    trRotEvento.Visible = Not IsNothing(Session("SessionEvent"))

                    lblTray.Text = objSolicitudTotal.BE_EMPRESA.strDET_GIRO

                    If Not IsNothing(Session("SessionInst")) Then _
                        lblRptaUso.Text = objSolicitudTotal.BE_SOLICITUD_INST.strRPTAUSOMARCAPAIS
                    If Not IsNothing(Session("SessionProd")) Then _
                        lblRptaUso.Text = objSolicitudTotal.BE_SOLICITUD_PROD.strRPTAUSOMARCAPAIS
                    If Not IsNothing(Session("SessionEvent")) Then
                        lblRptaUso.Text = objSolicitudTotal.BE_SOLICITUD_EVENT.strRPTAUSOMARCAPAIS

                        lblNombre.Text = objSolicitudTotal.BE_EVENTO.strNOMBRE
                        lblOrganizador.Text = objSolicitudTotal.BE_EVENTO.strORGANIZADOR

                        If objSolicitudTotal.BE_EVENTO.strREFERENCIA.Split("/").Length > 1 Then
                            lblRefEvento.Text = objSolicitudTotal.BE_EVENTO.strREFERENCIA.Split("/")(1)
                            lnkRef.Visible = True
                            lnkRef.Text = "Ver referencia"
                            lnkRef.NavigateUrl = objSolicitudTotal.BE_EVENTO.strREFERENCIA
                        Else
                            lblRefEvento.Text = objSolicitudTotal.BE_EVENTO.strREFERENCIA
                            lnkRef.Visible = False
                        End If

                        lblDescEvento.Text = objSolicitudTotal.BE_EVENTO.strDESCRIPCION

                        If objSolicitudTotal.BE_EVENTO.strRUTAAGENDA.Split("/").Length > 1 Then
                            lblAgenda.Text = objSolicitudTotal.BE_EVENTO.strRUTAAGENDA.Split("/")(1)
                            kplnkAgenda.Text = "Ver agenda"
                            kplnkAgenda.NavigateUrl = objSolicitudTotal.BE_EVENTO.strRUTAAGENDA
                        Else
                            lblAgenda.Text = objSolicitudTotal.BE_EVENTO.strRUTAAGENDA
                            kplnkAgenda.Visible = False
                        End If


                        lblEdicEvnto.Text = objSolicitudTotal.BE_EVENTO.strNUMEDICION
                        lblPer.Text = objSolicitudTotal.BE_EVENTO.strPERIODO
                        lblLugar.Text = objSolicitudTotal.BE_EVENTO.strLUGAR
                        If Not String.IsNullOrEmpty(objSolicitudTotal.BE_EVENTO.dtmFECHA) AndAlso objSolicitudTotal.BE_EVENTO.dtmFECHA.Split("_=_").Length > 2 Then

                            lblFecha.Text = "Del " & objSolicitudTotal.BE_EVENTO.dtmFECHA.Split("_=_")(0) & " al " & objSolicitudTotal.BE_EVENTO.dtmFECHA.Split("_=_")(2)
                        Else
                            lblFecha.Text = ""
                        End If

                        lblDescPubEvnto.Text = objSolicitudTotal.BE_EVENTO.strDESCPUBLICOGRL
                        lblPart.Text = objSolicitudTotal.BE_EVENTO.intNUMPART
                        lblCosto.Text = objSolicitudTotal.BE_EVENTO.dblCOSTOPROM
                        lblAuspiciadores.Text = objSolicitudTotal.BE_EVENTO.strAUSPICIADORES
                    End If

                    grvambito.DataSource = objSolicitudTotal.LIST_BE_AMBITOUSO
                    grvambito.DataBind()

                    cargarGridProducto()
                    cargarDetalleUso()
                    cargarReferenciaEmpresa()

                    ScriptManager.RegisterStartupScript(Me, Me.GetType, "", "mostrarCampos()", True)
                End If

            End If
            guardarArchivos()
        End If
    End Sub
    Private Sub guardarArchivos()
        Dim objSolTtl As BE.clsBE_SOLICITUDTOTAL = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        If FUAjaxDJurada.IsPosting Then

            clsUTL_AjaxFU.managePost(FUAjaxDJurada)

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

    Private Sub cargarGridProducto()
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        If objSolicitudTotal.LIST_BE_PRODUCTO.Count = 0 Then
            Dim cllObj As New List(Of BE.clsBE_PRODUCTO)
            Dim obj As New BE.clsBE_PRODUCTO
            obj.strMARCA = "-1"
            cllObj.Add(obj)
            grvProd.DataSource = cllObj
        Else
            grvProd.DataSource = objSolicitudTotal.LIST_BE_PRODUCTO
        End If


        grvProd.DataBind()

    End Sub
    Private Sub cargarReferenciaEmpresa()
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        GVRefEmpresa.DataSource = objSolicitudTotal.LIST_BE_REF_EMPRESA
        GVRefEmpresa.DataBind()
    End Sub
    Private Sub cargarDetalleUso()
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        If objSolicitudTotal.LIST_BE_DETUSO.Count = 0 Then
            Dim cllObj As New List(Of BE.clsBE_DET_USO)
            Dim obj As New BE.clsBE_DET_USO
            obj.strTIPOLIC = "-1"
            cllObj.Add(obj)
            gViewDU.DataSource = cllObj
        Else
            gViewDU.DataSource = objSolicitudTotal.LIST_BE_DETUSO
        End If
        gViewDU.DataBind()
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

    'Metodos para guardar la data del formulario
    Private Sub guardarFormulario(ByRef xstrNombreEmpresa As String, ByRef xstrTipoLic As String)
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        guardarEmpresa(objSolicitudTotal.BE_EMPRESA, objSolicitudTotal.Existe)
        guardarEmpresaRef(objSolicitudTotal.LIST_BE_REF_EMPRESA, objSolicitudTotal.BE_EMPRESA.lngID)

        xstrNombreEmpresa = objSolicitudTotal.BE_EMPRESA.strRAZONSOCIAL
        xstrTipoLic = ""

        Dim lstAmbitoUso As New List(Of BE.clsBE_AMBITOUSO)
        If Not IsNothing(Session("SessionInst")) Then
            objSolicitudTotal.BE_SOLICITUD_INST.strDECLARACIONJUR = guardarArchivosPaso(FUAjaxDJurada)
            objSolicitudTotal.BE_SOLICITUD_INST.lngIDEMP = objSolicitudTotal.BE_EMPRESA.lngID
            guardarSolicitud(objSolicitudTotal.BE_SOLICITUD_INST)
            ' ambitoUso(objSolicitudTotal.BE_SOLICITUD_INST.lngID)
            xstrTipoLic += "INSTITUCIONAL, "
            'ámbito
            For Each objambito As BE.clsBE_AMBITOUSO In objSolicitudTotal.LIST_BE_AMBITOUSO
                objambito.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_INST.lngID
                lstAmbitoUso.Add(objambito)
            Next
        End If

        If Not IsNothing(Session("SessionProd")) Then
            objSolicitudTotal.BE_SOLICITUD_PROD.strDECLARACIONJUR = guardarArchivosPaso(FUAjaxDJurada)
            objSolicitudTotal.BE_SOLICITUD_PROD.lngIDEMP = objSolicitudTotal.BE_EMPRESA.lngID
            guardarSolicitud(objSolicitudTotal.BE_SOLICITUD_PROD)
            xstrTipoLic += "PRODUCTOS, "
            Dim LST_PRODUCT As New List(Of BE.clsBE_PRODUCTO)

            If Not IsNothing(objSolicitudTotal.LIST_BE_PRODUCTO) Then
                For Each BE_PRODUC In objSolicitudTotal.LIST_BE_PRODUCTO
                    BE_PRODUC.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_PROD.lngID

                    LST_PRODUCT.Add(BE_PRODUC)
                Next
                objSolicitudTotal.LIST_BE_PRODUCTO = LST_PRODUCT
            End If
            guardarListaProductos(objSolicitudTotal.LIST_BE_PRODUCTO)

            If Not IsNothing(objSolicitudTotal.LIST_BE_PRODUCTO_REF) Then
                If objSolicitudTotal.LIST_BE_PRODUCTO.Count > 0 Then
                    For Each obj In objSolicitudTotal.LIST_BE_PRODUCTO_REF
                        obj.lngID_PROD = objSolicitudTotal.LIST_BE_PRODUCTO(0).lngID
                    Next
                    guardarProductoRef(objSolicitudTotal.LIST_BE_PRODUCTO_REF)
                End If
            End If

            For Each objambito As BE.clsBE_AMBITOUSO In objSolicitudTotal.LIST_BE_AMBITOUSO
                objambito.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_PROD.lngID
                lstAmbitoUso.Add(objambito)
            Next
        End If

        If Not IsNothing(Session("SessionEvent")) Then
            objSolicitudTotal.BE_SOLICITUD_EVENT.strDECLARACIONJUR = guardarArchivosPaso(FUAjaxDJurada)
            objSolicitudTotal.BE_SOLICITUD_EVENT.lngIDEMP = objSolicitudTotal.BE_EMPRESA.lngID
            guardarSolicitud(objSolicitudTotal.BE_SOLICITUD_EVENT)

            objSolicitudTotal.BE_EVENTO.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_EVENT.lngID
            guardarEvento(objSolicitudTotal.BE_EVENTO)
            xstrTipoLic += "EVENTO, "
            For Each objambito As BE.clsBE_AMBITOUSO In objSolicitudTotal.LIST_BE_AMBITOUSO
                objambito.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_EVENT.lngID
                lstAmbitoUso.Add(objambito)
            Next
        End If

        Dim objbcambito As New BC.clsBC_AMBITOUSOTX
        objbcambito.LstAMBITOUSO = lstAmbitoUso
        objbcambito.InsertarAMBITOUSO()

        guardarDETUSO(objSolicitudTotal)

        xstrTipoLic = xstrTipoLic.Substring(0, xstrTipoLic.Length - 2)
    End Sub
    Private Sub guardarDETUSO(ByVal objSolicitudTotal As BE.clsBE_SOLICITUDTOTAL)

        Dim objclsBC_DETUSOTX As New BC.clsBC_DET_USOTX
        
        For Each objDU As BE.clsBE_DET_USO In objSolicitudTotal.LIST_BE_DETUSO
            If objDU.strTIPOLIC = "INSTITUCIONAL" Then
                objDU.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_INST.lngID
            ElseIf objDU.strTIPOLIC = "PRODUCTO" Then
                objDU.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_PROD.lngID
            ElseIf objDU.strTIPOLIC = "EVENTO" Then
                objDU.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_EVENT.lngID
            End If

        Next
        objclsBC_DETUSOTX.LstDET_USO = objSolicitudTotal.LIST_BE_DETUSO
        objclsBC_DETUSOTX.InsertarDET_USO()
    End Sub
    Private Sub guardarEmpresa(ByRef _BE_EMPRESA As BE.clsBE_EMPRESA, ByVal existe As Boolean)

        Dim objclsBC_EMPRESATX As New BC.clsBC_EMPRESATX
        DatosAuditoria(_BE_EMPRESA, Me.ToString.Substring(4), "")
        objclsBC_EMPRESATX.LstEMPRESA.Add(_BE_EMPRESA)
        If existe Then
            objclsBC_EMPRESATX.ModificarEMPRESA()
        Else
            objclsBC_EMPRESATX.InsertarEMPRESA()
        End If

        _BE_EMPRESA = objclsBC_EMPRESATX.LstEMPRESA(0)

    End Sub
    Private Sub guardarSolicitud(ByRef _BE_SOLICITUD As BE.clsBE_SOLICITUD)
        Dim objclsBC_SOLICITUDTX As New BC.clsBC_SOLICITUDTX
        DatosAuditoria(_BE_SOLICITUD, Me.ToString.Substring(4), "")
        objclsBC_SOLICITUDTX.LstSOLICITUD.Add(_BE_SOLICITUD)
        If _BE_SOLICITUD.lngID = 0 Then
            objclsBC_SOLICITUDTX.InsertarSOLICITUD()
        Else
            objclsBC_SOLICITUDTX.ModificarSOLICITUD()
        End If

        _BE_SOLICITUD = objclsBC_SOLICITUDTX.LstSOLICITUD(0)
    End Sub
    Private Sub guardarProducto(ByRef _BE_PRODUCTO As BE.clsBE_PRODUCTO)
        Dim objclsBC_PRODUCTOTX As New BC.clsBC_PRODUCTOTX
        DatosAuditoria(_BE_PRODUCTO, Me.ToString.Substring(4), "")
        objclsBC_PRODUCTOTX.LstPRODUCTO.Add(_BE_PRODUCTO)
        objclsBC_PRODUCTOTX.InsertarPRODUCTO()
        _BE_PRODUCTO = objclsBC_PRODUCTOTX.LstPRODUCTO(0)
    End Sub

    Private Sub guardarProductoRef(ByVal _LIST_BE_REF_PRODUCTO As List(Of BE.clsBE_REF_PRODUCTOS))
        Dim objclsBC_REFPRODUCTX As New BC.clsBC_REF_PRODUCTOSTX
        objclsBC_REFPRODUCTX.LstREF_PRODUCTOS = _LIST_BE_REF_PRODUCTO
        objclsBC_REFPRODUCTX.InsertarREF_PRODUCTOS()
    End Sub


    Private Sub guardarEvento(ByRef _BE_PRODUCTO As BE.clsBE_EVENTO)
        Dim objclsBC_EVENTOTX As New BC.clsBC_EVENTOTX
        DatosAuditoria(_BE_PRODUCTO, Me.ToString.Substring(4), "")
        objclsBC_EVENTOTX.LstEVENTO.Add(_BE_PRODUCTO)
        objclsBC_EVENTOTX.InsertarEVENTO()
        _BE_PRODUCTO = objclsBC_EVENTOTX.LstEVENTO(0)
    End Sub
    Private Sub guardarListaProductos(ByRef LIST_BE_PRODUCTO As List(Of BE.clsBE_PRODUCTO))
        Dim objclsBC_PRODUCTOTX As New BC.clsBC_PRODUCTOTX
        objclsBC_PRODUCTOTX.LstPRODUCTO = LIST_BE_PRODUCTO
        For Each obj As BE.clsBE_PRODUCTO In objclsBC_PRODUCTOTX.LstPRODUCTO
            DatosAuditoria(obj, Me.ToString.Substring(4), "")
        Next
        objclsBC_PRODUCTOTX.InsertarPRODUCTO()
        LIST_BE_PRODUCTO = objclsBC_PRODUCTOTX.LstPRODUCTO
    End Sub
    Private Sub guardarEmpresaRef(ByRef LIST_BE_EMPRESA_REF As List(Of BE.clsBE_REF_EMPRESA), ByVal idEmp As Long)
        Dim objClsBC_EMPRESA_REFTX As New BC.clsBC_REF_EMPRESATX
        objClsBC_EMPRESA_REFTX.LstREF_EMPRESA = LIST_BE_EMPRESA_REF
        For Each obj As BE.clsBE_REF_EMPRESA In objClsBC_EMPRESA_REFTX.LstREF_EMPRESA
            DatosAuditoria(obj, Me.ToString.Substring(4), "")
            obj.lngIDEMPRESA = idEmp
        Next
        objClsBC_EMPRESA_REFTX.InsertarREF_EMPRESA()
    End Sub


    Protected Sub Btn_Seguir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Seguir.Click
        Try
            If guardarArchivosPaso(FUAjaxDJurada) = "" Then
                Throw New Exception("Seleccione la Declaración Jurada Obligatorio")
                Exit Sub
            End If


            Dim strEmp, strtipoLic As String

            guardarFormulario(strEmp, strtipoLic)
            'guardarDETUSO()

            EnviarMail()

            Response.Redirect("WFRM_Termino.aspx")
        Catch ex As Exception
            msg.Text = Formatomsgerr(ex.Message.Split(New Char() {"/"}, StringSplitOptions.RemoveEmptyEntries))
        End Try

    End Sub
    Private Sub EnviarMail()

        Dim strEmp As String
        Dim strtipoLic As String

        Dim objSolicitudTotal As BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        strEmp = objSolicitudTotal.BE_EMPRESA.strRAZONSOCIAL
        strtipoLic = ""


        If Not IsNothing(Session("SessionInst")) Then
            strtipoLic = "INSTITUCIONAL"
        End If

        If Not IsNothing(Session("SessionProd")) Then
            If (Not strtipoLic.Equals("")) Then
                strtipoLic += ","
            End If

            strtipoLic += "PRODUCTOS"
        End If

        If Not IsNothing(Session("SessionEvent")) Then
            If (Not strtipoLic.Equals("")) Then
                strtipoLic += ","
            End If
            strtipoLic += "EVENTO"
        End If


        If Not IsNothing(Session(Konstantes.kstrNombreSession)) Then
            Dim objBC_USUARIO As BE.clsBE_CLIENT_USER
            objBC_USUARIO = Session(Konstantes.kstrNombreSession)
            MP.DW.UTL.clsUTL_EnvioCorreo.SendSimpleMessage("Registro solicitud finalizada", objBC_USUARIO.strMAILUSR, "", _
                                                           "SOLICITUD ENVIADA", "&nbsp;", _
                                                           strEmp & " ha culminado el trámite de solicitud de licencia de uso " & strtipoLic, _
                                                           ConfigurationManager.AppSettings("ServerSMTP"), ConfigurationManager.AppSettings("PortSMTP"))
        End If
        If Not IsNothing(System.Configuration.ConfigurationManager.AppSettings("mailpromperu3")) Then
            MP.DW.UTL.clsUTL_EnvioCorreo.SendSimpleMessage("Registro solicitud finalizada", System.Configuration.ConfigurationManager.AppSettings("mailpromperu3"), "", _
                                                           "SOLICITUD ENVIADA", "&nbsp;", _
                                                           strEmp & " ha culminado el trámite de solicitud de licencia de uso " & strtipoLic, _
                                                           ConfigurationManager.AppSettings("ServerSMTP"), ConfigurationManager.AppSettings("PortSMTP"))
        End If

      

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Response.Redirect("WFRM_Paso08.aspx")
    End Sub

    Protected Sub grvProd_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grvProd.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells(0).Text = "-1" Then
                e.Row.Visible = False
            Else
                Dim lnk As HyperLink = e.Row.Cells(2).FindControl("lnkMarca")
                lnk.Text = nombreLink(lnk.Text)
            End If

        End If
    End Sub
    Private Function nombreLink(ByVal ruta As String) As String
        Dim link() As String
        If ruta <> "" Then
            link = ruta.Split("/")
            Return link(link.Length - 1)
        End If
        Return ""
    End Function

    Protected Sub gViewDU_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gViewDU.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells(0).Text = "-1" Then
                e.Row.Visible = False
            ElseIf e.Row.Cells(1).Text = "0" Then
                e.Row.Cells(1).Text = "Pagina Web"
            ElseIf e.Row.Cells(1).Text = "1" Then
                e.Row.Cells(1).Text = "Panaderia/Impresos"
            ElseIf e.Row.Cells(1).Text = "2" Then
                e.Row.Cells(1).Text = "Material Institucional"
            ElseIf e.Row.Cells(1).Text = "3" Then
                e.Row.Cells(1).Text = "Web/Redes Sociales"
            ElseIf e.Row.Cells(1).Text = "4" Then
                e.Row.Cells(1).Text = "Otros"
            End If
        End If
    End Sub

End Class