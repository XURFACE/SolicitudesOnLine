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
                    lbldpto.Text = objSolicitudTotal.BE_EMPRESA.strCOD_DPTO
                    lblProv.Text = objSolicitudTotal.BE_EMPRESA.strCOD_PROV

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

                    cargarGridProducto()
                    cargarDetalleUso()
                End If

            End If
        End If
        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
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

        grvProd.DataSource = objSolicitudTotal.LIST_BE_PRODUCTO
        grvProd.DataBind()

    End Sub
    Private Sub cargarDetalleUso()
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        gViewDU.DataSource = objSolicitudTotal.LIST_BE_DETUSO
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
    Private Sub guardarFormulario()
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
        guardarEmpresa(objSolicitudTotal.BE_EMPRESA, objSolicitudTotal.Existe)

        If Not IsNothing(Session("SessionInst")) Then
            objSolicitudTotal.BE_SOLICITUD_INST.strDECLARACIONJUR = guardarArchivosPaso(FUAjaxDJurada)
            objSolicitudTotal.BE_SOLICITUD_INST.lngIDEMP = objSolicitudTotal.BE_EMPRESA.lngID
            guardarSolicitud(objSolicitudTotal.BE_SOLICITUD_INST)
            ' ambitoUso(objSolicitudTotal.BE_SOLICITUD_INST.lngID)
        End If
        If Not IsNothing(Session("SessionProd")) Then
            objSolicitudTotal.BE_SOLICITUD_PROD.strDECLARACIONJUR = guardarArchivosPaso(FUAjaxDJurada)
            objSolicitudTotal.BE_SOLICITUD_PROD.lngIDEMP = objSolicitudTotal.BE_EMPRESA.lngID
            guardarSolicitud(objSolicitudTotal.BE_SOLICITUD_PROD)
            Dim LST_PRODUCT As New List(Of BE.clsBE_PRODUCTO)

            If Not IsNothing(objSolicitudTotal.LIST_BE_PRODUCTO) Then
                For Each BE_PRODUC In objSolicitudTotal.LIST_BE_PRODUCTO
                    BE_PRODUC.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_PROD.lngID

                    LST_PRODUCT.Add(BE_PRODUC)
                Next
                objSolicitudTotal.LIST_BE_PRODUCTO = LST_PRODUCT
            End If

            If Not IsNothing(objSolicitudTotal.LIST_BE_REF_EMPRESA) Then
                For Each obj In objSolicitudTotal.LIST_BE_REF_EMPRESA
                    obj.lngIDEMPRESA = objSolicitudTotal.BE_EMPRESA.lngID
                Next
            End If
            guardarListaProductos(objSolicitudTotal.LIST_BE_PRODUCTO)
            guardarEmpresaRef(objSolicitudTotal.LIST_BE_REF_EMPRESA)

            If Not IsNothing(objSolicitudTotal.LIST_BE_PRODUCTO_REF) Then
                If objSolicitudTotal.LIST_BE_PRODUCTO.Count > 0 Then
                    For Each obj In objSolicitudTotal.LIST_BE_PRODUCTO_REF
                        obj.lngID_PROD = objSolicitudTotal.LIST_BE_PRODUCTO(0).lngID
                    Next
                    guardarProductoRef(objSolicitudTotal.LIST_BE_PRODUCTO_REF)
                End If


            End If

            ' ambitoUso(objSolicitudTotal.BE_SOLICITUD_PROD.lngID)

        End If

        If Not IsNothing(Session("SessionEvent")) Then
            objSolicitudTotal.BE_SOLICITUD_EVENT.strDECLARACIONJUR = guardarArchivosPaso(FUAjaxDJurada)
            objSolicitudTotal.BE_SOLICITUD_EVENT.lngIDEMP = objSolicitudTotal.BE_EMPRESA.lngID
            guardarSolicitud(objSolicitudTotal.BE_SOLICITUD_EVENT)

            objSolicitudTotal.BE_EVENTO.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_EVENT.lngID
            guardarEvento(objSolicitudTotal.BE_EVENTO)

            'ambitoUso(objSolicitudTotal.BE_SOLICITUD_EVENT.lngID)
        End If

    End Sub
    Private Sub guardarDETUSO()
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        Dim objclsBC_DETUSOTX As New BC.clsBC_DET_USOTX
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        For Each objDU As BE.clsBE_DET_USO In objSolicitudTotal.LIST_BE_DETUSO
            If objDU.strTIPOLIC = "INSTITUCION" Then
                objDU.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_INST.lngID
            ElseIf objDU.strTIPOLIC = "PRODUCTO" Then
                objDU.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_PROD.lngID
            ElseIf objDU.strTIPOLIC = "EVENTO" Then
                objDU.lngIDSOLICITUD = objSolicitudTotal.BE_SOLICITUD_EVENT.lngID
            End If

        Next

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
    Private Sub guardarEmpresaRef(ByRef LIST_BE_EMPRESA_REF As List(Of BE.clsBE_REF_EMPRESA))
        Dim objClsBC_EMPRESA_REFTX As New BC.clsBC_REF_EMPRESATX
        objClsBC_EMPRESA_REFTX.LstREF_EMPRESA = LIST_BE_EMPRESA_REF
        For Each obj As BE.clsBE_REF_EMPRESA In objClsBC_EMPRESA_REFTX.LstREF_EMPRESA
            DatosAuditoria(obj, Me.ToString.Substring(4), "")
        Next
        objClsBC_EMPRESA_REFTX.InsertarREF_EMPRESA()
    End Sub

    Protected Sub Btn_Seguir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Seguir.Click
        guardarFormulario()
        guardarDETUSO()

        EnviarMail()

        Response.Redirect("WFRM_Termino.aspx")
    End Sub
    Private Sub EnviarMail()

        For i As Int32 = 1 To 2
            Dim mail As String = System.Configuration.ConfigurationManager.AppSettings("MailPROMPERU" & i)
            MP.DW.UTL.clsUTL_EnvioCorreo.SendSimpleMessage("Registro solicitud finalizada", mail, System.Configuration.ConfigurationManager.AppSettings("MailPROMPERU3"), _
                                                           "Registro finalizado", "&nbsp;", "Se ha culminado el registro de su solicitud de Uso de Marca País Perú", _
                                                           ConfigurationManager.AppSettings("ServerSMTP"), ConfigurationManager.AppSettings("PortSMTP"))
        Next

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Response.Redirect("WFRM_Paso08.aspx")
    End Sub

    Protected Sub grvProd_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grvProd.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim lnk As HyperLink = e.Row.Cells(2).FindControl("lnkMarca")
            lnk.Text = nombreLink(lnk.Text)
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
            If e.Row.Cells(1).Text = "0" Then
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