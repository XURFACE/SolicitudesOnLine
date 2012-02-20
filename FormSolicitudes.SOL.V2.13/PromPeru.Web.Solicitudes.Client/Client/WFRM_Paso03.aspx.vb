Imports MP.DW.BL
Imports MP.DW.BL.BC
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL
Imports System.Data
Imports Subgurim.Controles

Imports PromPeru.Configuration.Enumerators
Imports PromPeru.Configuration.Konstantes
Imports PromPeru.Configuration
Imports System.Web.Services

Imports AjaxPro

Public Class WFRM_Paso03
    Inherits System.Web.UI.Page


    Public dataUbigeo As New DataTable()
    Protected Sub Btn_Seguir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Seguir.Click
        Try
            If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
                Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
                Dim objBCEmpresa As New clsBC_EMPRESARO
                objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

                If CstrMP(Request.QueryString("tipo")) <> tipoPersona.juridico_Extrangero Then
                    objBCEmpresa.LeerEMPRESA(Txt_RUC.Text, CType(Session(Konstantes.kstrNombreSession), BE.clsBE_CLIENT_USER).lngID, objSolicitudTotal.BE_EMPRESA.strTIPOEMPRESA.ToUpper)
                    If objBCEmpresa.oBEEMPRESA.lngID <> 0 AndAlso objSolicitudTotal.Existe = False Then
                        Throw New Exception(String.Format("Ya existe una entidad con el número de RUC: {0}, si desea cargar los datos de esta empresa haga click en Buscar Empresa", Txt_RUC.Text))
                    End If
                Else
                    objBCEmpresa.LeerEMPRESA(txtRazonSoc.Text, CType(Session(Konstantes.kstrNombreSession), BE.clsBE_CLIENT_USER).lngID, objSolicitudTotal.BE_EMPRESA.strTIPOEMPRESA.ToUpper)
                    If objBCEmpresa.oBEEMPRESA.lngID <> 0 AndAlso objSolicitudTotal.Existe = False Then
                        Throw New Exception(String.Format("Ya existe una entidad con la misma razón social {0}, si desea cargar los datos de esta empresa haga click en Buscar Empresa", txtRazonSoc.Text))
                    End If
                End If


                Dim pasos As New Rastro
                Dim file() As String

                pasos = CType(Session(Konstantes.kstrPasos), Rastro)

                Dim guid As String = "public" 'System.Guid.NewGuid.ToString()
                Dim strMsg As String = ""
                objSolicitudTotal.BE_EMPRESA.lngIDUSUARIO = CType(Session(kstrNombreSession), BE.clsBE_CLIENT_USER).lngID

                objSolicitudTotal.BE_EMPRESA.strREPRESENTANTE = txtRepresentante.Text
                objSolicitudTotal.BE_EMPRESA.strCARGO = txtCargo.Text
                objSolicitudTotal.BE_EMPRESA.strDNI = txtdniRepr.Text
                objSolicitudTotal.BE_EMPRESA.strGIRO = uc_Giro.SelectecItem.ToString
                objSolicitudTotal.BE_EMPRESA.strWEB = txtWeb.Text
                objSolicitudTotal.BE_EMPRESA.strDOMICILIO = txtDireccion.Text
                objSolicitudTotal.BE_EMPRESA.strNUMPARTIDA = txtPartida.Text
                objSolicitudTotal.BE_EMPRESA.strNUMTEL = txtTelefono.Text
                objSolicitudTotal.BE_EMPRESA.strEMAIL = txtmail.Text
                objSolicitudTotal.BE_EMPRESA.strNOMPERCONTACTO = txtContacto.Text


                objSolicitudTotal.BE_EMPRESA.strRUC = Txt_RUC.Text
                objSolicitudTotal.BE_EMPRESA.strCOD_DPTO = dlldepartamento.SelectedValue
                objSolicitudTotal.BE_EMPRESA.strCOD_PROV = dllprovincia.SelectedValue
                objSolicitudTotal.BE_EMPRESA.strCOD_DIST = dllDistrito.SelectedValue

                objSolicitudTotal.BE_EMPRESA.strNOMBREDPTO = dlldepartamento.SelectedItem.ToString
                objSolicitudTotal.BE_EMPRESA.strNOMBREDIST = dllDistrito.SelectedItem.ToString
                objSolicitudTotal.BE_EMPRESA.strNOMBREPROV = dllprovincia.SelectedItem.ToString

                objSolicitudTotal.BE_EMPRESA.strRAZONSOCIAL = txtRazonSoc.Text
                objSolicitudTotal.BE_EMPRESA.strCARGOREPRESENTANTE = txtCgoRepres.Text

                objSolicitudTotal.BE_EMPRESA.strCIUDAD = txtCiudad.Text
                objSolicitudTotal.BE_EMPRESA.strPAIS = ddlPaises.SelectedItem.Text.ToString
                objSolicitudTotal.BE_EMPRESA.strTIPODOCUMENTO = ddlTipoDoc.SelectedItem.Text.ToString

                Dim msgErr As New StringBuilder

                If objSolicitudTotal.BE_EMPRESA.strRUTADNI <> "" Then
                    file = objSolicitudTotal.BE_EMPRESA.strRUTADNI.Split("\")
                    If file(file.Length - 1) <> "" Then
                        objSolicitudTotal.BE_EMPRESA.strRUTADNI = file(file.Length - 1)
                    Else
                        If guardarArchivosPaso(FUAjaxDNI, Request.QueryString("tipo") <> tipoPersona.org_estatal, objSolicitudTotal.BE_EMPRESA.strRUTADNI) Then
                            msgErr.Append(String.Format(objSolicitudTotal.BE_EMPRESA.strRUTADNI, lblDNI.Text))
                            objSolicitudTotal.BE_EMPRESA.strRUTADNI = ""
                        End If
                    End If
                Else
                    If guardarArchivosPaso(FUAjaxDNI, Request.QueryString("tipo") <> tipoPersona.org_estatal, objSolicitudTotal.BE_EMPRESA.strRUTADNI) Then
                        msgErr.Append(String.Format(objSolicitudTotal.BE_EMPRESA.strRUTADNI, lblDNI.Text))
                        objSolicitudTotal.BE_EMPRESA.strRUTADNI = ""
                    End If
                End If

                If objSolicitudTotal.BE_EMPRESA.strRUTARUC <> "" Then
                    file = objSolicitudTotal.BE_EMPRESA.strRUTARUC.Split("\")
                    If file(file.Length - 1) <> "" Then
                        objSolicitudTotal.BE_EMPRESA.strRUTARUC = file(file.Length - 1)
                    Else
                        If guardarArchivosPaso(FUAjaxRuc, Request.QueryString("tipo") <> tipoPersona.org_estatal, objSolicitudTotal.BE_EMPRESA.strRUTARUC) Then
                            msgErr.Append(String.Format(objSolicitudTotal.BE_EMPRESA.strRUTARUC, lblRucEtiq.Text))
                            objSolicitudTotal.BE_EMPRESA.strRUTARUC = ""
                        End If

                    End If
                Else
                    If guardarArchivosPaso(FUAjaxRuc, Request.QueryString("tipo") <> tipoPersona.org_estatal, objSolicitudTotal.BE_EMPRESA.strRUTARUC) Then
                        msgErr.Append(String.Format(objSolicitudTotal.BE_EMPRESA.strRUTARUC, lblRucEtiq.Text))
                        objSolicitudTotal.BE_EMPRESA.strRUTARUC = ""
                    End If
                End If

                If objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA <> "" Then
                    file = objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA.Split("\")
                    If file(file.Length - 1) <> "" Then
                        objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA = file(file.Length - 1)
                    Else
                        If guardarArchivosPaso(FUAjaxLF, False, objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA) Then
                            msgErr.Append(String.Format(objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA, RotLicFunc.Text))
                            objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA = ""
                        End If
                    End If
                Else
                    If guardarArchivosPaso(FUAjaxLF, False, objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA) Then
                        msgErr.Append(String.Format(objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA, RotLicFunc.Text))
                        objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA = ""
                    End If
                End If

                If objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER <> "" Then
                    file = objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER.Split("\")
                    If file(file.Length - 1) <> "" Then
                        objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER = file(file.Length - 1)
                    Else
                        If guardarArchivosPaso(FUAjaxVP, Request.QueryString("tipo") = tipoPersona.juridico, objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER) Then
                            msgErr.Append(String.Format(objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER, RtoVigencia.Text))
                            objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER = ""
                        End If
                    End If
                Else
                    If guardarArchivosPaso(FUAjaxVP, Request.QueryString("tipo") = tipoPersona.juridico, objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER) Then
                        msgErr.Append(String.Format(objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER, RtoVigencia.Text))
                        objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER = ""
                    End If
                End If
                If msgErr.Length > 0 Then
                    Throw New Exception(msgErr.ToString)
                End If
                If Request.QueryString("tipo") = tipoPersona.juridico_Extrangero Or
                    Request.QueryString("tipo") = tipoPersona.natural_Negocio Then
                    objSolicitudTotal.BE_EMPRESA.strNUMPARTIDA = Nothing
                ElseIf Request.QueryString("tipo") = tipoPersona.org_estatal Then
                    objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA = Nothing
                    objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER = Nothing
                End If

                Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
                pasos.PASOS.Push(3)
                If objSolicitudTotal.BE_SOLICITUD_EVENT.lngID <> 0 Or objSolicitudTotal.BE_SOLICITUD_INST.lngID <> 0 Or objSolicitudTotal.BE_SOLICITUD_PROD.lngID Then
                    If objSolicitudTotal.BE_EMPRESA.strTIPOEMPRESA.ToUpper = "ORGANISMO ESTATAL" Then
                        Response.Redirect("WFRM_Paso08.aspx")
                    Else
                        Response.Redirect("WFRM_Paso05.aspx")
                    End If
                End If
                Response.Redirect("WFRM_Paso04.aspx")
            End If
        Catch ex As Exception
            lblMsjError.Text = Formatomsgerr(ex.Message.Replace(":", "").Replace("*", "").Split(New Char() {"\"}, StringSplitOptions.RemoveEmptyEntries))
            lblMsjError.Visible = True
        End Try

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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AjaxPro.Utility.RegisterTypeForAjax(GetType(PromPeru.Web.Solicitudes.Client.WFRM_Paso03))
        If Not IsPostBack Then
            Dim objUbigeo As New MP.DW.BL.BC.clsBC_UBIGEORO()
            Dim tipo As Int32 = -1
            dataUbigeo = objUbigeo.LeerListaToDTUBIGEO()

            Session("ubigeo") = dataUbigeo

            If Not IsNothing(Request.QueryString("id")) Then
                RenovarEmpresa()
            End If

            If Not IsNothing(Request.QueryString("tipo")) AndAlso Not String.IsNullOrEmpty(Request.QueryString("tipo")) Then
                If Request.QueryString("tipo") = tipoPersona.juridico_Extrangero Then
                    lblRucEtiq.Text = "Código de registro tributario*:"
                    ddlTipoDoc.Items.Clear()
                    ddlTipoDoc.Items.Add(New ListItem("Cédula de Identidad"))
                    ddlTipoDoc.Items.Add(New ListItem("Pasaporte"))
                    rev.Enabled = ddlTipoDoc.SelectedValue = "DNI"

                End If
                txtTipoEmpresa.Text = CType(Request.QueryString("tipo"), Int32)

                RotLicFunc.Visible = Request.QueryString("tipo") <> tipoPersona.org_estatal
                FUAjaxLF.Visible = Request.QueryString("tipo") <> tipoPersona.org_estatal

                'FUAjaxRuc.Visible = Request.QueryString("tipo") <> tipoPersona.org_estatal And Request.QueryString("tipo") <> tipoPersona.juridico_Extrangero
                FUAjaxRuc.Visible = Request.QueryString("tipo") <> tipoPersona.org_estatal

                txtPartida.Visible = Request.QueryString("tipo") <> tipoPersona.org_estatal And Request.QueryString("tipo") <> tipoPersona.juridico_Extrangero
                RotNPartida.Visible = Request.QueryString("tipo") <> tipoPersona.org_estatal And Request.QueryString("tipo") <> tipoPersona.juridico_Extrangero
                dvLic.Visible = Request.QueryString("tipo") = tipoPersona.juridico_Extrangero
                divInfoRuc.Visible = Request.QueryString("tipo") = tipoPersona.juridico_Extrangero
                rev.Enabled = Request.QueryString("tipo") <> tipoPersona.juridico_Extrangero
                revRuc.Enabled = Request.QueryString("tipo") <> tipoPersona.juridico_Extrangero

                FUAjaxVP.Visible = Request.QueryString("tipo") = tipoPersona.juridico
                RtoVigencia.Visible = Request.QueryString("tipo") = tipoPersona.juridico

                rfvCgoRepre.Enabled = Request.QueryString("tipo") = tipoPersona.juridico

                FUAjaxDNI.Visible = Request.QueryString("tipo") <> tipoPersona.org_estatal

                txtContacto.Visible = Request.QueryString("tipo") <> tipoPersona.natural_Negocio
                rfvPerCont.Enabled = Request.QueryString("tipo") <> tipoPersona.natural_Negocio

                lblPContacto.Visible = Request.QueryString("tipo") <> tipoPersona.natural_Negocio

                txtCargo.Visible = Request.QueryString("tipo") <> tipoPersona.natural_Negocio
                rfvCargo.Enabled = Request.QueryString("tipo") <> tipoPersona.natural_Negocio
                lblCargo.Visible = Request.QueryString("tipo") <> tipoPersona.natural_Negocio
                lblAyudaFichaRUC.Visible = Request.QueryString("tipo") <> tipoPersona.org_estatal

                If Request.QueryString("tipo") = tipoPersona.natural_Negocio Then
                    lblGiro.Text = "Giro Principal del Negocio: *"
                ElseIf Request.QueryString("tipo") = tipoPersona.org_estatal Then
                    lblGiro.Text = "Sector: *"
                End If

                If Request.QueryString("tipo") = tipoPersona.juridico_Extrangero Then
                    lblDNI.Text = "N° de documento de Identidad:*"
                    lblAyudaFichaRUC.Text = "Adjuntar Ficha Registro Tributario"
                    txtdniRepr.MaxLength = 30
                    Txt_RUC.MaxLength = 30
                    Dim strPaises As String() = {"Afganistán", "Akrotiri", "Albania", "Alemania", "Andorra", "Angola", "Anguila", "Antártida", "Antigua y Barbuda", "Antillas Neerlandesas", "Arabia Saudí", "Arctic Ocean", "Argelia", "Argentina", "Armenia", "Aruba", "Ashmore andCartier Islands", "Atlantic Ocean", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bahráin", "Bangladesh", "Barbados", "Bélgica", "Belice", "Benín", "Bermudas", "Bielorrusia", "Birmania Myanmar", "Bolivia", "Bosnia y Hercegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Chad", "Chile", "China", "Chipre", "Clipperton Island", "Colombia", "Comoras", "Congo", "Coral Sea Islands", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dhekelia", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "El Vaticano", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Gaza Strip", "Georgia", "Ghana", "Gibraltar", "Granada", "Grecia", "Groenlandia", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea Ecuatorial", "Guinea-Bissau", "Guyana", "Haití", "Honduras", "Hong Kong", "Hungría", "India", "Indian Ocean", "Indonesia", "Irán", "Iraq", "Irlanda", "Isla Bouvet", "Isla Christmas", "Isla Norfolk", "Islandia", "Islas Caimán", "Islas Cocos", "Islas Cook", "Islas Feroe", "Islas Georgia del Sur y Sandwich del Sur", "Islas Heard y McDonald", "Islas Malvinas", "Islas Marianas del Norte", "IslasMarshall", "Islas Pitcairn", "Islas Salomón", "Islas Turcas y Caicos", "Islas Vírgenes Americanas", "Islas Vírgenes Británicas", "Israel", "Italia", "Jamaica", "Jan Mayen", "Japón", "Jersey", "Jordania", "Kazajistán", "Kenia", "Kirguizistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macao", "Macedonia", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Man, Isle of", "Marruecos", "Mauricio", "Mauritania", "Mayotte", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montserrat", "Mozambique", "Namibia", "Nauru", "Navassa Island", "Nepal", "Nicaragua", "Níger", "Nigeria", "Niue", "Noruega", "Nueva Caledonia", "Nueva Zelanda", "Omán", "Pacific Ocean", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa-Nueva Guinea", "Paracel Islands", "Paraguay", "Perú", "Polinesia Francesa", "Polonia", "Portugal", "Puerto Rico", "Qatar", "Reino Unido", "República Centroafricana", "República Checa", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia", "Sáhara Occidental", "Samoa", "Samoa Americana", "San Cristóbal y Nieves", "San Marino", "San Pedro y Miquelón", "San Vicente y las Granadinas", "Santa Helena", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Southern Ocean", "Spratly Islands", "Sri Lanka", "Suazilandia", "Sudáfrica", "Sudán", "Suecia", "Suiza", "Surinam", "Svalbard y Jan Mayen", "Tailandia", "Taiwán", "Tanzania", "Tayikistán", "TerritorioBritánicodel Océano Indico", "Territorios Australes Franceses", "Timor Oriental", "Togo", "Tokelau", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Unión Europea", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Wake Island", "Wallis y Futuna", "West Bank", "World", "Yemen", "Yibuti", "Zambia", "Zimbabue"}
                    ddlPaises.DataSource = strPaises
                    ddlPaises.DataBind()
                Else
                    lblDNI.Text = "N° de documento de Identidad:*"
                    lblAyudaFichaRUC.Text = "Adjuntar ficha RUC"
                    Dim strPaises As String() = {"Perú"}
                    ddlPaises.DataSource = strPaises
                    ddlPaises.DataBind()
                End If

                If Request.QueryString("tipo") = tipoPersona.org_estatal Then
                    lblRotRazSoc.Text = "Nombre de la entidad*:"
                    uc_Giro.Tipo = tipoLista.Sector
                Else
                    lblRotRazSoc.Text = "Razón social:*"
                    uc_Giro.Tipo = tipoLista.Giro
                End If

                If Request.QueryString("tipo") = tipoPersona.juridico Then
                    lblCgoRepre.Text = "Cargo del Representante Legal*:"
                Else
                    lblCgoRepre.Text = "Cargo del Representante Legal:"
                End If
                FUAjaxRuc.File_RenameIfAlreadyExists = True
                FUAjaxRuc.Directory_CreateIfNotExists = True            
            End If

            cargarEmpresa()
        End If
        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            guardarArchivos()
        End If

        If IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            Response.Redirect("WFRM_Paso01.aspx")
        End If

    End Sub
    Private Sub guardarArchivos()
        Dim objSolTtl As BE.clsBE_SOLICITUDTOTAL = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
        Dim strMsg As String = ""
        If FUAjaxRuc.IsPosting Then
            clsUTL_AjaxFU.managePost(FUAjaxRuc)
        End If
        If FUAjaxLF.IsPosting Then
            clsUTL_AjaxFU.managePost(FUAjaxLF)
        End If
        If FUAjaxVP.IsPosting Then
            clsUTL_AjaxFU.managePost(FUAjaxVP)
        End If
        If FUAjaxDNI.IsPosting Then
            clsUTL_AjaxFU.managePost(FUAjaxDNI)
        End If
    End Sub
    Private Function guardarArchivosPaso(ByRef FUAjax As FileUploaderAJAX, ByVal esObligatorio As Boolean, ByRef xstrRutaRet As String) As Boolean

        Dim rutas As List(Of String)
        rutas = clsUTL_AjaxFU.historialFUAjax(FUAjax)
        If Not IsNothing(rutas) Then
            If rutas.Count > 0 Then
                xstrRutaRet = rutas(0).ToString
                Return False
            Else
                If esObligatorio Then
                    xstrRutaRet = "Adjunte archivo {0} válido\"
                    Return True
                Else
                    xstrRutaRet = ""
                    Return False
                End If
            End If
        Else
            If esObligatorio Then
                xstrRutaRet = "Adjuntar archivo {0} es obligatorio\"
                Return True
            Else
                xstrRutaRet = ""
                Return False
            End If
        End If
    End Function


    Protected Sub Btn_Cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Dim pasos As New Rastro
        Dim page As String = "Main.aspx"
        If Not IsNothing(Session(Konstantes.kstrPasos)) Then
            pasos = CType(Session(Konstantes.kstrPasos), Rastro)
            page = String.Concat("WFRM_Paso0", pasos.PASOS.Pop(), ".aspx")


        End If
        Response.Redirect(page)
    End Sub

    Protected Sub loadDepartamentos(ByVal idProv As String)

        Dim departamentos As New DataTable()
        departamentos = MP.DW.UTL.clsUTL_Helpers.SeleccionFiltro(dataUbigeo, "COD_PROV", idProv)
        MP.DW.UTL.clsUTL_Helpers.llenacombo(dlldepartamento, departamentos, "COD_DPTO", "NOMBRE_CORTO", False, False, "", 0, "")

    End Sub

    Protected Sub loadProvincias(ByVal idDepart As String)

        Dim provincia As New DataTable()
        Dim provincias As New DataTable()
        provincia = MP.DW.UTL.clsUTL_Helpers.SeleccionFiltro(dataUbigeo, "COD_DPTO", idDepart)
        Dim dv As DataView = provincia.DefaultView
        dv.RowFilter = "COD_PROV <> 00"
        provincia = dv.ToTable()
        provincias = MP.DW.UTL.clsUTL_Helpers.SeleccionFiltro(provincia, "COD_DIST", "00")
        MP.DW.UTL.clsUTL_Helpers.llenacombo(dllprovincia, provincias, "COD_PROV", "NOMBRE_CORTO", False, False, "", 0, "")
    End Sub

    Protected Sub loadDistritos(ByVal idDepart As String, ByVal idProv As String)
        Dim distrito As New DataTable()
        Dim distritos As New DataTable()
        distrito = MP.DW.UTL.clsUTL_Helpers.SeleccionFiltro(dataUbigeo, "COD_DPTO", idDepart)
        distritos = MP.DW.UTL.clsUTL_Helpers.SeleccionFiltro(distrito, "COD_PROV", idProv)
        Dim dv As DataView = distritos.DefaultView
        dv.RowFilter = "COD_DIST <> 00"
        distritos = dv.ToTable()
        MP.DW.UTL.clsUTL_Helpers.llenacombo(dllDistrito, distritos, "COD_DIST", "NOMBRE_CORTO", False, False, "", 0, "")
    End Sub

    Protected Sub dllprovincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dllprovincia.SelectedIndexChanged
        Dim objUbigeo As New MP.DW.BL.BC.clsBC_UBIGEORO()
        dataUbigeo = objUbigeo.LeerListaToDTUBIGEO()

        dllDistrito.Items.Clear()
        loadDistritos(dlldepartamento.SelectedValue, dllprovincia.SelectedValue)
    End Sub


    Protected Sub dlldepartamento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dlldepartamento.SelectedIndexChanged
        Dim objUbigeo As New MP.DW.BL.BC.clsBC_UBIGEORO()
        dataUbigeo = objUbigeo.LeerListaToDTUBIGEO()

        dllprovincia.Items.Clear()
        dllDistrito.Items.Clear()
        loadProvincias(dlldepartamento.SelectedValue)
        loadDistritos(dlldepartamento.SelectedValue, dllprovincia.SelectedValue)
    End Sub

    Protected Sub btnQuitDNI_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuitDNI.Click
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        objSolicitudTotal.BE_EMPRESA.strRUTADNI = ""
        Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
        btnQuitDNI.Visible = False
        lnkDNI.Text = ""
        lnkDNI.Visible = False
        FUAjaxDNI.Visible = True
    End Sub

    Protected Sub btnQuitFLF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuitFLF.Click
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA = ""
        Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
        btnQuitFLF.Visible = False
        lnkLF.Text = ""
        lnkLF.Visible = False
        FUAjaxLF.Visible = True
    End Sub

    Protected Sub btnQuitRuc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuitRuc.Click
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        objSolicitudTotal.BE_EMPRESA.strRUTARUC = ""
        Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
        btnQuitRuc.Visible = False
        lnkRuc.Text = ""
        lnkRuc.Visible = False
        FUAjaxRuc.Visible = True
    End Sub
    Private Sub cargarEmpresa()
        Dim depart As String = "00"
        Dim prov As String = "01"
        Dim distr As String = "01"
        Dim file() As String
        Dim objUbigeo As New MP.DW.BL.BC.clsBC_UBIGEORO()
        dataUbigeo = objUbigeo.LeerListaToDTUBIGEO()

        

        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
            objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

            If Not IsNothing(objSolicitudTotal.BE_EMPRESA) Then


                txtRepresentante.Text = objSolicitudTotal.BE_EMPRESA.strREPRESENTANTE
                txtCargo.Text = objSolicitudTotal.BE_EMPRESA.strCARGO
                txtdniRepr.Text = objSolicitudTotal.BE_EMPRESA.strDNI
                uc_Giro.SelectedValue = objSolicitudTotal.BE_EMPRESA.strGIRO
                txtWeb.Text = objSolicitudTotal.BE_EMPRESA.strWEB
                txtDireccion.Text = objSolicitudTotal.BE_EMPRESA.strDOMICILIO
                txtTelefono.Text = objSolicitudTotal.BE_EMPRESA.strNUMTEL
                txtmail.Text = objSolicitudTotal.BE_EMPRESA.strEMAIL
                txtContacto.Text = objSolicitudTotal.BE_EMPRESA.strNOMPERCONTACTO
                Txt_RUC.Text = objSolicitudTotal.BE_EMPRESA.strRUC
                txtRazonSoc.Text = objSolicitudTotal.BE_EMPRESA.strRAZONSOCIAL
                txtPartida.Text = objSolicitudTotal.BE_EMPRESA.strNUMPARTIDA
                depart = objSolicitudTotal.BE_EMPRESA.strCOD_DPTO
                prov = objSolicitudTotal.BE_EMPRESA.strCOD_PROV
                txtCgoRepres.Text = objSolicitudTotal.BE_EMPRESA.strCARGOREPRESENTANTE
                txtCiudad.Text = objSolicitudTotal.BE_EMPRESA.strCIUDAD
                Dim itm As ListItem = ddlPaises.Items.FindByText(objSolicitudTotal.BE_EMPRESA.strPAIS)


                If objSolicitudTotal.Renovar And (Not IsNothing(Request.QueryString("renov")) AndAlso Request.QueryString("renov").Equals("0")) Then
                    Btn_Cancelar.Visible = False
                End If

                If Not IsNothing(itm) Then
                    ddlPaises.SelectedIndex = ddlPaises.Items.IndexOf(itm)
                End If


                If objSolicitudTotal.BE_EMPRESA.strRUTADNI <> "" Then
                    file = objSolicitudTotal.BE_EMPRESA.strRUTADNI.Split("\")
                    If file(file.Length - 1) <> "" Then
                        FUAjaxDNI.Visible = False
                        lnkDNI.Visible = True
                        btnQuitDNI.Visible = True

                        lnkDNI.Text = file(file.Length - 1)
                        lnkDNI.NavigateUrl = objSolicitudTotal.BE_EMPRESA.strRUTADNI
                    End If
                End If
                If objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA <> "" Then
                    file = objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA.Split("\")
                    If file(file.Length - 1) <> "" Then
                        FUAjaxLF.Visible = False
                        lnkLF.Visible = True
                        btnQuitFLF.Visible = True

                        lnkLF.Text = file(file.Length - 1)
                        lnkLF.NavigateUrl = objSolicitudTotal.BE_EMPRESA.strRUTALICENCIA
                    End If
                End If
                If objSolicitudTotal.BE_EMPRESA.strRUTARUC <> "" Then
                    file = objSolicitudTotal.BE_EMPRESA.strRUTARUC.Split("\")
                    If file(file.Length - 1) <> "" Then
                        FUAjaxRuc.Visible = False
                        lnkRuc.Visible = True
                        btnQuitRuc.Visible = True

                        lnkRuc.Text = file(file.Length - 1)
                        lnkRuc.NavigateUrl = objSolicitudTotal.BE_EMPRESA.strRUTARUC
                    End If
                End If

                If objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER <> "" Then
                    file = objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER.Split("\")
                    If file(file.Length - 1) <> "" Then
                        FUAjaxVP.Visible = False
                        lnkVP.Visible = True
                        btnQuitVP.Visible = True

                        lnkVP.Text = file(file.Length - 1)
                        lnkVP.NavigateUrl = objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER
                    End If
                End If



                If prov <> "" Then
                    loadDepartamentos("00")
                    loadProvincias(depart)
                    loadDistritos(depart, prov)

                    dlldepartamento.SelectedValue = objSolicitudTotal.BE_EMPRESA.strCOD_DPTO
                    dllprovincia.SelectedValue = objSolicitudTotal.BE_EMPRESA.strCOD_PROV
                    dllDistrito.SelectedValue = objSolicitudTotal.BE_EMPRESA.strCOD_DIST
                    Exit Sub
                End If


            End If
        End If

        loadDepartamentos("00")
        loadProvincias("01")
        loadDistritos("01", "01")
    End Sub
    Private Sub RenovarEmpresa()
        Dim id As Long = CType(Request.QueryString("id"), Int64)
        Dim idsol As Long = CType(Request.QueryString("idsol"), Int64)
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL

        Dim CLSBE_EMPRESARO As New BC.clsBC_EMPRESARO
        Dim CLSBE_SOLICITUDRO As New BC.clsBC_SOLICITUDRO



        CLSBE_EMPRESARO.oBEEMPRESA.lngID = id
        CLSBE_EMPRESARO.LeerEMPRESA()
        objSolicitudTotal.BE_EMPRESA = CLSBE_EMPRESARO.oBEEMPRESA
        objSolicitudTotal.Existe = True

        objSolicitudTotal.Renovar = True

        CLSBE_SOLICITUDRO.oBESOLICITUD.lngID = idsol
        CLSBE_SOLICITUDRO.LeerSOLICITUD()

        If CLSBE_SOLICITUDRO.oBESOLICITUD.strTIPOLIC = "INSTITUCIONAL" Then
            objSolicitudTotal.BE_SOLICITUD_INST = CLSBE_SOLICITUDRO.oBESOLICITUD
            objSolicitudTotal.BE_SOLICITUD_INST.strSTSSOL = "En evaluación - Documentación"
            Session("SessionInst") = objSolicitudTotal.BE_SOLICITUD_INST
        ElseIf CLSBE_SOLICITUDRO.oBESOLICITUD.strTIPOLIC = "PRODUCTO" Then
            objSolicitudTotal.BE_SOLICITUD_PROD = CLSBE_SOLICITUDRO.oBESOLICITUD
            objSolicitudTotal.BE_SOLICITUD_PROD.strSTSSOL = "En evaluación - Documentación"
            Session("SessionProd") = objSolicitudTotal.BE_SOLICITUD_PROD
        ElseIf CLSBE_SOLICITUDRO.oBESOLICITUD.strTIPOLIC = "EVENTO" Then
            objSolicitudTotal.BE_SOLICITUD_EVENT = CLSBE_SOLICITUDRO.oBESOLICITUD
            objSolicitudTotal.BE_SOLICITUD_EVENT.strSTSSOL = "En evaluación - Documentación"
            Session("SessionEvent") = objSolicitudTotal.BE_SOLICITUD_EVENT
        End If

        Dim pasos As New Rastro
        Session(Konstantes.kstrPasos) = pasos
        'pasos = CType(Session(Konstantes.kstrPasos), Rastro)


        Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
    End Sub

    Protected Sub btnQuitVP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuitVP.Click
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        objSolicitudTotal.BE_EMPRESA.strRUTAVIGPODER = ""
        Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
        btnQuitVP.Visible = False
        lnkVP.Text = ""
        lnkVP.Visible = False
        FUAjaxVP.Visible = True
    End Sub

    Protected Sub btnLoadEmpresa_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadEmpresa.Click
        Dim idEmpresa As Long = CLngMP(txtSearchIdEmpresa.Text)
        Dim objEMPRESARO As New BC.clsBC_EMPRESARO
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        Dim page As String = ""
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        objEMPRESARO.oBEEMPRESA.lngID = idEmpresa
        objEMPRESARO.LeerEMPRESA()
        objSolicitudTotal.BE_EMPRESA = objEMPRESARO.oBEEMPRESA
        objSolicitudTotal.Existe = True

        

        Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
        If page = "" Then
            cargarEmpresa()
        Else
            Response.Redirect(page)
        End If

    End Sub


    <AjaxMethod()>
    Public Function cargarProvincia(ByVal idDepart As String) As String
        Dim resultado As New StringBuilder

        Dim prov As New StringBuilder
        ' Dim objUbigeo As New MP.DW.BL.BC.clsBC_UBIGEORO()
        dataUbigeo = CType(Session("ubigeo"), DataTable)
        Dim provincia As New DataTable()
        Dim provincias As New DataTable()
        provincia = MP.DW.UTL.clsUTL_Helpers.SeleccionFiltro(dataUbigeo, "COD_DPTO", idDepart)
        Dim dv As DataView = provincia.DefaultView
        dv.RowFilter = "COD_PROV <> 00"
        provincia = dv.ToTable()
        provincias = MP.DW.UTL.clsUTL_Helpers.SeleccionFiltro(provincia, "COD_DIST", "00")

        For index As Int32 = 0 To provincias.Rows.Count - 1
            resultado.Append("<option value='")
            resultado.Append(provincias.Rows(index)("COD_PROV"))
            resultado.Append("'>")
            resultado.Append(provincias.Rows(index)("NOMBRE_CORTO"))
            resultado.Append("</option>")
        Next

        Return resultado.ToString

    End Function
    <AjaxMethod()>
    Public Function cargarDistritos(ByVal idDepart As String, ByVal idProv As String) As String
        Dim resultado As New StringBuilder
        ' Dim objUbigeo As New MP.DW.BL.BC.clsBC_UBIGEORO()
        Dim distrito As New DataTable()
        Dim distritos As New DataTable()

        dataUbigeo = CType(Session("ubigeo"), DataTable)

        distrito = MP.DW.UTL.clsUTL_Helpers.SeleccionFiltro(dataUbigeo, "COD_DPTO", idDepart)
        distritos = MP.DW.UTL.clsUTL_Helpers.SeleccionFiltro(distrito, "COD_PROV", idProv)
        Dim dv As DataView = distritos.DefaultView
        dv.RowFilter = "COD_DIST <> 00"
        distritos = dv.ToTable()

        For index As Int32 = 0 To distritos.Rows.Count - 1
            resultado.Append("<option value='")
            resultado.Append(distritos.Rows(index)("COD_DIST"))
            resultado.Append("'>")
            resultado.Append(distritos.Rows(index)("NOMBRE_CORTO"))
            resultado.Append("</option>")
        Next

        Return resultado.ToString
    End Function
    'Public Shared Function saludo() As String
    '    Return "Hola desde Servidor"
    'End Function

    '<WebMethod()> _
    'Public Shared Function cargarDepartamento() As DataTable
    '    Dim idProv As String = "00"
    '    Dim dataUbigeo As New DataTable()
    '    Dim objUbigeo As New MP.DW.BL.BC.clsBC_UBIGEORO()
    '    dataUbigeo = objUbigeo.LeerListaToDTUBIGEO()
    '    Dim departamentos As New DataTable()
    '    departamentos = MP.DW.UTL.clsUTL_Helpers.SeleccionFiltro(dataUbigeo, "COD_PROV", idProv)
    '    Return departamentos
    'End Function


    Protected Sub ddlTipoDoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlTipoDoc.SelectedIndexChanged
        rev.Enabled = ddlTipoDoc.SelectedValue = "DNI"
    End Sub
End Class