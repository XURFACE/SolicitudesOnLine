Imports MP.DW.BL
Imports MP.DW.UTL.clsUTL_EnvioCorreo
Imports MP.DW.UTL.clsUTL_Helpers
Imports PromPeru.Configuration
Public Class wfrm_DetalleSolicitud
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargaDatosSol()
        End If
    End Sub
    Private Sub CargaDatosSol()
        Dim objEMPRESARO As New BC.clsBC_EMPRESARO
        Dim objSOLICITUD As New BC.clsBC_SOLICITUDRO
        Dim objPRODUCTORO As New BC.clsBC_PRODUCTORO

        Dim objAPLICACIONRO As New BC.clsBC_APLICACIONRO
        Dim objAplData As New DataTable

        '        Dim idEmp As Int64
        Dim idSol As Int64

        If Not IsNothing(Request.QueryString("id")) Then

            objEMPRESARO.oBEEMPRESA.lngID = CLngMP(Request.QueryString("id"))
            objEMPRESARO.LeerEMPRESA()
            cargarRefEmpresa()
        End If

        If Not IsNothing(Request.QueryString("idSol")) Then
            idSol = CType(Request.QueryString("idSol"), Int64)
            objAplData = objAPLICACIONRO.LeerListaToDTAAPLICACIONBYSOL(idSol)
            objSOLICITUD.oBESOLICITUD.lngID = idSol
            objSOLICITUD.LeerSOLICITUD()


            Dim objAmbito As New BC.clsBC_AMBITOUSORO
            objAmbito.LeerListaAMBITOUSO(idSol)
            grvAmbitoUso.DataSource = objAmbito.LstAMBITOUSO
            grvAmbitoUso.DataBind()

            Dim objDetalle As New BC.clsBC_DET_USORO
            objDetalle.oBEDET_USO.lngIDSOLICITUD = idSol
            objDetalle.LeerListaDET_USO_ByIdSol()
            gViewDU.DataSource = objDetalle.LstDET_USO
            gViewDU.DataBind()

            cargarDocsAdic(idSol)
            If Not String.IsNullOrEmpty(objSOLICITUD.oBESOLICITUD.strDECLARACIONJUR) Then
                If objSOLICITUD.oBESOLICITUD.strDECLARACIONJUR.Split("/").Length > 1 Then
                    lblDeclaracion.Text = objSOLICITUD.oBESOLICITUD.strDECLARACIONJUR.Split("/")(1)
                    lnkDeclaracion.Text = "Ver declaración"
                    lnkDeclaracion.NavigateUrl = ConfigurationManager.AppSettings("rutaImagenCorto") & objSOLICITUD.oBESOLICITUD.strDECLARACIONJUR
                Else
                    lblDeclaracion.Text = objSOLICITUD.oBESOLICITUD.strDECLARACIONJUR
                    lnkDeclaracion.Visible = False
                End If
            End If


            If objSOLICITUD.oBESOLICITUD.strTIPOLIC.ToUpper.Contains("PRODUCTO") Then
                Dim objProdData As New DataTable
                objProdData = objPRODUCTORO.LeerListaToDTPRODUCTOSOL(idSol)
                If objProdData.Rows.Count > 0 Then
                    cargarRefProductos(objProdData.Rows(0)(0))
                End If
                grvProd.DataSource = objProdData
                grvProd.DataBind()
            ElseIf objSOLICITUD.oBESOLICITUD.strTIPOLIC.ToUpper.Contains("EVENTO") Then
                Dim objEvento As New BC.clsBC_EVENTORO
                objEvento.LeerEVENTO(idSol)

                lblNombre.Text = objEvento.oBEEVENTO.strNOMBRE
                lblOrganizador.Text = objEvento.oBEEVENTO.strORGANIZADOR

                If Not IsNothing(objEvento.oBEEVENTO.strREFERENCIA) AndAlso objEvento.oBEEVENTO.strREFERENCIA.Split("/").Length > 1 Then
                    lblRefEvento.Text = objEvento.oBEEVENTO.strREFERENCIA.Split("/")(1)
                    lnkreferencia.Visible = True
                    lnkreferencia.Text = "Ver referencia"
                    lnkreferencia.NavigateUrl = ConfigurationManager.AppSettings("rutaImagenCorto") & objEvento.oBEEVENTO.strREFERENCIA
                Else
                    lblRefEvento.Text = objEvento.oBEEVENTO.strREFERENCIA
                    lnkreferencia.Visible = False
                End If

                lblDescEvento.Text = objEvento.oBEEVENTO.strDESCRIPCION

                If Not IsNothing(objEvento.oBEEVENTO.strRUTAAGENDA) AndAlso objEvento.oBEEVENTO.strRUTAAGENDA.Split("/").Length > 1 Then
                    lblAgenda.Text = objEvento.oBEEVENTO.strRUTAAGENDA.Split("/")(1)
                    kplnkAgenda.Text = "Ver agenda"
                    kplnkAgenda.NavigateUrl = ConfigurationManager.AppSettings("rutaImagenCorto") & objEvento.oBEEVENTO.strRUTAAGENDA
                Else
                    lblAgenda.Text = objEvento.oBEEVENTO.strRUTAAGENDA
                    kplnkAgenda.Visible = False
                End If


                lblEdicEvnto.Text = objEvento.oBEEVENTO.strNUMEDICION
                lblPer.Text = objEvento.oBEEVENTO.strPERIODO
                lblLugar.Text = objEvento.oBEEVENTO.strLUGAR
                If Not String.IsNullOrEmpty(objEvento.oBEEVENTO.dtmFECHA) AndAlso objEvento.oBEEVENTO.dtmFECHA.Split("_=_").Length > 2 Then
                    lblFecha.Text = "Del " & objEvento.oBEEVENTO.dtmFECHA.Split("_=_")(0) & " al " & objEvento.oBEEVENTO.dtmFECHA.Split("_=_")(2)
                Else
                    lblFecha.Text = ""
                End If
                lblDescPubEvnto.Text = objEvento.oBEEVENTO.strDESCPUBLICOGRL
                lblPart.Text = objEvento.oBEEVENTO.intNUMPART
                lblCosto.Text = objEvento.oBEEVENTO.dblCOSTOPROM
                lblAuspiciadores.Text = objEvento.oBEEVENTO.strAUSPICIADORES
            End If
        End If
        Select Case objEMPRESARO.oBEEMPRESA.strTIPOEMPRESA
            Case "PERSONA JURÍDICA"
                txtload.Text = "0"
            Case "PERSONA JURÍDICA EXTRANJERA"
                txtload.Text = "1"
            Case "PERSONA NATURAL CON NEGOCIO"
                txtload.Text = "2"
            Case "ORGANISMO ESTATAL"
                txtload.Text = "3"
        End Select

        txtRazonSoc.Text = objEMPRESARO.oBEEMPRESA.strRAZONSOCIAL
        Txt_Expediente.Text = objEMPRESARO.oBEEMPRESA.strNROEXPEDIENTE
        Txt_RUC.Text = objEMPRESARO.oBEEMPRESA.strRUC
        txtRepresentante.Text = objEMPRESARO.oBEEMPRESA.strREPRESENTANTE
        txtCargo.Text = objEMPRESARO.oBEEMPRESA.strCARGO
        txtdniRepr.Text = objEMPRESARO.oBEEMPRESA.strDNI
        lblNameGiro.Text = objEMPRESARO.oBEEMPRESA.strGIRO
        txtWeb.Text = objEMPRESARO.oBEEMPRESA.strWEB
        txtDireccion.Text = objEMPRESARO.oBEEMPRESA.strDOMICILIO
        lblDistr.Text = objEMPRESARO.oBEEMPRESA.strNOMBREDIST
        lbldpto.Text = objEMPRESARO.oBEEMPRESA.strNOMBREDPTO
        lblProv.Text = objEMPRESARO.oBEEMPRESA.strNOMBREPROV
        txtPartida.Text = objEMPRESARO.oBEEMPRESA.strNUMPARTIDA
        lblTray.Text = objEMPRESARO.oBEEMPRESA.strDET_GIRO
        lblRef.Text = objEMPRESARO.oBEEMPRESA.strREFERENCIAS
        lblAct.Text = objEMPRESARO.oBEEMPRESA.strCOMPROMISO
        txtCgoRepres.Text = objEMPRESARO.oBEEMPRESA.strCARGOREPRESENTANTE
        txtContacto.Text = objEMPRESARO.oBEEMPRESA.strNOMPERCONTACTO
        lblNomProg.Text = objEMPRESARO.oBEEMPRESA.strNOMBREPROGRAMASOCIAL
        lbldetProg.Text = objEMPRESARO.oBEEMPRESA.strDET_PROGRAMASOCIAL

        trProgRotNom.Visible = objEMPRESARO.oBEEMPRESA.strNOMBREPROGRAMASOCIAL.Trim.Length > 0
        trProgNom.Visible = objEMPRESARO.oBEEMPRESA.strNOMBREPROGRAMASOCIAL.Trim.Length > 0
        trProgRotDet.Visible = objEMPRESARO.oBEEMPRESA.strDET_PROGRAMASOCIAL.Trim.Length > 0
        trProgDet.Visible = objEMPRESARO.oBEEMPRESA.strDET_PROGRAMASOCIAL.Trim.Length > 0

        lblObjetivo.Text = objEMPRESARO.oBEEMPRESA.strOBJETIVO
        lblDetObjetivo.Text = objEMPRESARO.oBEEMPRESA.strOBJ_PORQUE

        If objEMPRESARO.oBEEMPRESA.strRUTALICENCIA <> "" Then
            lnkLF.Text = "ver licencia"
            lnkLF.NavigateUrl = ConfigurationManager.AppSettings("rutaImagenCorto") & objEMPRESARO.oBEEMPRESA.strRUTALICENCIA
        Else
            lnkLF.Text = ""
        End If
        If objEMPRESARO.oBEEMPRESA.strRUTARUC <> "" Then
            lnkRuc.Text = "ver RUC"
            lnkRuc.NavigateUrl = ConfigurationManager.AppSettings("rutaImagenCorto") & objEMPRESARO.oBEEMPRESA.strRUTARUC
        Else
            lnkRuc.Text = ""
        End If
        If objEMPRESARO.oBEEMPRESA.strRUTADNI <> "" Then
            lnkDNI.Text = "ver documento de identidad"
            lnkDNI.NavigateUrl = ConfigurationManager.AppSettings("rutaImagenCorto") & objEMPRESARO.oBEEMPRESA.strRUTADNI
        Else
            lnkDNI.Text = ""
        End If
        If objEMPRESARO.oBEEMPRESA.strRUTAVIGPODER <> "" Then
            lnkVP.Text = "ver Vigencia"
            lnkVP.NavigateUrl = ConfigurationManager.AppSettings("rutaImagenCorto") & objEMPRESARO.oBEEMPRESA.strRUTAVIGPODER
        Else
            lnkVP.Text = ""
        End If

        txtTelefono.Text = objEMPRESARO.oBEEMPRESA.strNUMTEL
        txtmail.Text = objEMPRESARO.oBEEMPRESA.strEMAIL
        txtCiudad.Text = objEMPRESARO.oBEEMPRESA.strCIUDAD
        txtPais.Text = objEMPRESARO.oBEEMPRESA.strPAIS

        If objEMPRESARO.oBEEMPRESA.strTIPOEMPRESA = "Persona Jurídica" Then
            txtload.Text = Enumerators.tipoPersona.juridico
        ElseIf objEMPRESARO.oBEEMPRESA.strTIPOEMPRESA = "Persona Jurídica Extranjera" Then
            txtload.Text = Enumerators.tipoPersona.juridico_Extrangero
        ElseIf objEMPRESARO.oBEEMPRESA.strTIPOEMPRESA = "Persona Natural con Negocio" Then
            txtload.Text = Enumerators.tipoPersona.natural_Negocio
        ElseIf objEMPRESARO.oBEEMPRESA.strTIPOEMPRESA = "Organismo Estatal" Then
            txtload.Text = Enumerators.tipoPersona.org_estatal
        End If
        lblEstadoActual.Text = objSOLICITUD.oBESOLICITUD.strSTSSOL.ToUpper

        trRefProds1.Visible = objSOLICITUD.oBESOLICITUD.strTIPOLIC.ToUpper.Contains("PRODUCTO")
        trRefProds2.Visible = objSOLICITUD.oBESOLICITUD.strTIPOLIC.ToUpper.Contains("PRODUCTO")
        trRotProd1.Visible = objSOLICITUD.oBESOLICITUD.strTIPOLIC.ToUpper.Contains("PRODUCTO")
        trRotProd2.Visible = objSOLICITUD.oBESOLICITUD.strTIPOLIC.ToUpper.Contains("PRODUCTO")

        trRotEvento.Visible = objSOLICITUD.oBESOLICITUD.strTIPOLIC.ToUpper.Contains("EVENTO")
        trEvento.Visible = objSOLICITUD.oBESOLICITUD.strTIPOLIC.ToUpper.Contains("EVENTO")

        lblUSO.Text = "4. DATOS RELACIONADOS AL USO " & objSOLICITUD.oBESOLICITUD.strTIPOLIC.ToUpper

        lblRptaUso.Text = objSOLICITUD.oBESOLICITUD.strRPTAUSOMARCAPAIS



        grvAplicUso.DataSource = objAplData
        grvAplicUso.DataBind()
    End Sub
    Private Sub grvAplicUso_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grvAplicUso.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim ddl As DropDownList = e.Row.FindControl("ddlEstado")
            If Not IsNothing(ddl) Then
                Dim itm As ListItem = ddl.Items.FindByValue(grvAplicUso.DataKeys(e.Row.RowIndex).Values(1))
                ddl.SelectedIndex = ddl.Items.IndexOf(itm)
            End If
        End If


    End Sub

    Protected Sub grvAplicUso_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles grvAplicUso.RowCommand
        Dim strCommand As String = e.CommandName
        Dim intIndex As Integer

        If strCommand <> "Page" Then
            intIndex = CInt(e.CommandSource.parent.parent.rowindex)

            If strCommand = "cmdHabilitar" Then
                Dim chkAprob As CheckBox
                Dim objAPLICACIONTX As New BC.clsBC_APLICACIONTX
                chkAprob = grvAplicUso.Rows(intIndex).FindControl("chkAprob")
                objAPLICACIONTX.oBEAPLICACION.lngID = grvAplicUso.DataKeys(intIndex).Values(0)
                'objAPLICACIONTX.oBEAPLICACION.intSTSAPLICACION = 
                objAPLICACIONTX.oBEAPLICACION.intSTSAPLICACION = IIf(chkAprob.Checked, 1, 0)
                objAPLICACIONTX.LstAPLICACION.Add(objAPLICACIONTX.oBEAPLICACION)
                objAPLICACIONTX.ModificarAPLICACION()

                'idobj = grvAplicUso.DataKeys(intIndex).Values(0)
            End If
        End If
    End Sub

    Protected Sub chkAprob_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

        Dim ddl As DropDownList = CType(sender, DropDownList)
        Dim row As GridViewRow = DirectCast(DirectCast(ddl.Parent, DataControlFieldCell).Parent, GridViewRow)
        Dim intRowIndex As Int32 = row.RowIndex
        Dim objAPLICACIONTX As New BC.clsBC_APLICACIONTX
        Dim objAPLICACIONRO As New BC.clsBC_APLICACIONRO

        If Not IsNothing(Request.QueryString("idSol")) Then
            objAPLICACIONRO.oBEAPLICACION.lngID = grvAplicUso.DataKeys(intRowIndex).Values(0)
            objAPLICACIONRO.LeerAPLICACION()
            objAPLICACIONTX.oBEAPLICACION = objAPLICACIONRO.oBEAPLICACION
            objAPLICACIONTX.oBEAPLICACION.intSTSAPLICACION = ddl.SelectedValue
            objAPLICACIONTX.LstAPLICACION.Add(objAPLICACIONTX.oBEAPLICACION)
            objAPLICACIONTX.ModificarAPLICACION()
        End If
    End Sub

    Private Sub cargarRefEmpresa()
        Dim objREf As New BC.clsBC_REF_EMPRESARO
        GVDocs.DataSource = objREf.LeerListaToDTREF_EMPRESA(CType(Request.QueryString("id"), Long))
        GVDocs.DataBind()
    End Sub
    Private Sub cargarRefProductos(ByVal idProd As Long)
        Dim objREf As New BC.clsBC_REF_PRODUCTOSRO
        grvProdRef.DataSource = objREf.LeerListaToDTREF_PRODUCTOS(idProd)
        grvProdRef.DataBind()
    End Sub
    Private Sub cargarDocsAdic(ByVal idsol As Long)
        Dim objDocs As New BC.clsBC_DOCUMENTOS_ADICIONALESRO
        grvarcAdic.DataSource = objDocs.LeerListaToDTDOCUMENTOS_ADICIONALES(idsol)
        grvarcAdic.DataBind()
    End Sub

    Protected Sub btnAtras_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAtras.Click
        Response.Redirect("wfrm_solicitudes.aspx")
    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        CargaDatosSol()
    End Sub

    Private Sub grvarcAdic_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grvarcAdic.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then

        End If
    End Sub

    Protected Sub RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) _
        Handles GVDocs.RowDataBound, grvProd.RowDataBound, grvProdRef.RowDataBound, grvarcAdic.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim hylnk As HyperLink = e.Row.FindControl("lnkRF")
            If Not IsNothing(hylnk) Then _
                hylnk.NavigateUrl = ConfigurationManager.AppSettings("rutaImagenCorto") & hylnk.NavigateUrl
        End If
    End Sub

    Protected Sub btn_load_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_load.Click
        cargarDocsAdic(Request.QueryString("idSol"))
    End Sub

    Protected Sub btnSolicitar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSolicitar.Click
        Try
            Dim strbl As New Text.StringBuilder
            Dim strBody As String = "El evaluador ha considerado que para su solicitud sea aprobada se agreguen siguientes archivos adicionales:<br><ul>{0}</ul><br>" & _
                                    "Para ello ingrese al sistema de Solicitudes En línea desde http://peru.info"
            For Each dr As GridViewRow In grvarcAdic.Rows
                Dim hylnk As HyperLink = dr.FindControl("lnkRF")
                If Not IsNothing(hylnk) Then
                    If Not String.IsNullOrEmpty(hylnk.NavigateUrl.Trim.Replace("&nbsp;", "")) Then
                        strbl.Append("<li>" & dr.Cells(0).Text & "</li>")
                    End If
                End If
            Next
            SendSimpleMessage("Marca país - Archivos adicionales", txtmail.Text, "", "Se requiere archivos adicionales", "&nbsp;",
                              String.Format(strBody, strbl.ToString), _
                              ConfigurationManager.AppSettings("ServerSMTP"), ConfigurationManager.AppSettings("PortSMTP"))
        Catch ex As Exception
            ltrMsg.Text = Formatomsgerr(ex.Message.Split(New Char() {"/"}, StringSplitOptions.RemoveEmptyEntries))
        End Try

    End Sub
End Class