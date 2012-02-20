Imports MP.DW.BL
Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Public Class wfrm_DetalleSolicitud
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsNothing(Request.QueryString("idsol")) Then
            FillData()
            FillDataAplicacion()
            FillDataDocuments()
        End If
    End Sub

    Private Sub FillData()

        Dim objBC As New BC.clsBC_SOLICITUDRO
        Dim idsol As Long = CType(Request.QueryString("idsol"), Long)
        Dim dt As Data.DataTable = objBC.LeerListaToDTSOLICITUDESBYID(idsol)

        Dim objDetalle As New BC.clsBC_DET_USORO
        objDetalle.oBEDET_USO.lngIDSOLICITUD = idsol
        objDetalle.LeerListaDET_USO_ByIdSol()
        gViewDU.DataSource = objDetalle.LstDET_USO
        gViewDU.DataBind()

        Dim objAmbito As New BC.clsBC_AMBITOUSORO
        objAmbito.LeerListaAMBITOUSO(idsol)
        grvAmbitoUso.DataSource = objAmbito.LstAMBITOUSO
        grvAmbitoUso.DataBind()

        If (Not IsNothing(dt) And dt.Rows.Count > 0) Then
            txtRazonSoc.Text = dt.Rows(0)("RAZONSOCIAL").ToString
            Txt_RUC.Text = dt.Rows(0)("RUC").ToString
            txtRepresentante.Text = dt.Rows(0)("REPRESENTANTE").ToString
            txtCargo.Text = dt.Rows(0)("CARGO").ToString
            txtdniRepr.Text = dt.Rows(0)("DNI").ToString
            txtWeb.Text = dt.Rows(0)("WEB").ToString
            txtDireccion.Text = dt.Rows(0)("DOMICILIO").ToString
            txtCgoRepres.Text = dt.Rows(0)("CARGO_REPRESENTANTE").ToString

            lblNameGiro.Text = dt.Rows(0)("GIRO").ToString
            lbldpto.Text = dt.Rows(0)("COD_DPTO")
            lblProv.Text = dt.Rows(0)("COD_PROV")
            lblDistr.Text = dt.Rows(0)("COD_DIST")
            txtCiudad.Text = dt.Rows(0)("CIUDAD")
            txtPais.Text = dt.Rows(0)("PAIS")
            If dt.Rows(0)("RUTALICENCIA") <> "" Then
                lnkLF.NavigateUrl = dt.Rows(0)("RUTALICENCIA")
                lnkLF.Text = "ver licencia"
            Else
                lnkLF.Text = ""
            End If
            If dt.Rows(0)("RUTARUC") <> "" Then
                lnkRuc.Text = "ver RUC"
                lnkRuc.NavigateUrl = dt.Rows(0)("RUTARUC")
            Else
                lnkRuc.Text = ""
            End If
            If dt.Rows(0)("RUTAVIGPODER") <> "" Then
                lnkVP.Text = "ver Vigencia"
                lnkVP.NavigateUrl = dt.Rows(0)("RUTAVIGPODER")
            Else
                lnkVP.Text = ""
            End If
            If dt.Rows(0)("RUTADNI") <> "" Then
                lnkDNI.Text = "ver documento de identidad"
                lnkDNI.NavigateUrl = dt.Rows(0)("RUTADNI")
            Else
                lnkDNI.Text = ""
            End If
            txtdniRepr.Text = dt.Rows(0)("DNI")
            txtContacto.Text = dt.Rows(0)("DNI")
            txtPartida.Text = dt.Rows(0)("NUMPARTIDA").ToString

            txtTelefono.Text = dt.Rows(0)("NUMTEL").ToString
            txtmail.Text = dt.Rows(0)("EMAIL").ToString
            lblTray.Text = dt.Rows(0)("DET_GIRO").ToString

            lblAct.Text = dt.Rows(0)("COMPROMISO").ToString
            lblNomProg.Text = dt.Rows(0)("NOMBREPROGRAMASOCIAL").ToString
            lbldetProg.Text = dt.Rows(0)("DET_PROGRAMASOCIAL").ToString

            trProgRotNom.Visible = dt.Rows(0)("NOMBREPROGRAMASOCIAL").ToString.Trim.Length > 0
            trProgNom.Visible = dt.Rows(0)("NOMBREPROGRAMASOCIAL").ToString.Trim.Length > 0
            trProgRotDet.Visible = dt.Rows(0)("DET_PROGRAMASOCIAL").ToString.Trim.Length > 0
            trProgDet.Visible = dt.Rows(0)("DET_PROGRAMASOCIAL").ToString.Trim.Length > 0



            lblRptaUso.Text = dt.Rows(0)("RPTAUSOMARCAPAIS").ToString



            cargarReferenciaEmpresa(dt.Rows(0)("IDEMPRESA").ToString)

            'LUso.Text = dt.Rows(0)("TIPOLIC").ToString

            THState.Text = dt.Rows(0)("STSSOL").ToString.Trim

            If dt.Rows(0)("TIPO_EMPRESA").ToString.ToUpper = "PERSONA JURÍDICA" Then
                txtload.Text = "0"
            ElseIf dt.Rows(0)("TIPO_EMPRESA").ToString.ToUpper = "PERSONA JURÍDICA EXTRANJERA" Then
                txtload.Text = "1"
            ElseIf dt.Rows(0)("TIPO_EMPRESA").ToString.ToUpper = "PERSONA NATURAL CON NEGOCIO" Then
                txtload.Text = "2"
            ElseIf dt.Rows(0)("TIPO_EMPRESA").ToString.ToUpper = "ORGANISMO ESTATAL" Then
                txtload.Text = "3"
            End If

            trRefProds1.Visible = dt.Rows(0)("TIPOLIC").ToString.Trim.ToUpper.Contains("PRODUCTO")
            trRotProd1.Visible = dt.Rows(0)("TIPOLIC").ToString.Trim.ToUpper.Contains("PRODUCTO")
            trRotProd2.Visible = dt.Rows(0)("TIPOLIC").ToString.Trim.ToUpper.Contains("PRODUCTO")

            trgrvEvento.Visible = dt.Rows(0)("TIPOLIC").ToString.Trim.ToUpper.Contains("EVENTO")
            trEvento.Visible = dt.Rows(0)("TIPOLIC").ToString.Trim.ToUpper.Contains("EVENTO")

            lblUSO.Text = "DATOS RELACIONADOS AL USO: " & dt.Rows(0)("TIPOLIC")

            If dt.Rows(0)("TIPOLIC").ToString.Trim = "EVENTO" Then
                cargarEvento(CType(dt.Rows(0)("IDSOL"), Int64))                
            ElseIf dt.Rows(0)("TIPOLIC").ToString.Trim = "PRODUCTO" Then
                FillDataProductos()
            End If
            Dim estado As String = dt.Rows(0)("STSSOL")

            If estado.Trim.ToUpper.ToString = "APROBADO" Then
                LBAddDocs.Visible = False
            Else
                trArtes.Visible = False
                'lnkAddApl.Visible = False
            End If

        End If

    End Sub
    Private Sub cargarReferenciaEmpresa(ByVal id As Long)
        Dim objREFEMPRESARO As New BC.clsBC_REF_EMPRESARO

        GVRefEmpresa.DataSource = objREFEMPRESARO.LeerListaToDTREF_EMPRESA(id)
        GVRefEmpresa.DataBind()
    End Sub
    Private Sub cargarEvento(ByVal idsol As Long)
        Dim objEvento As New BC.clsBC_EVENTORO
        objEvento.LeerEVENTO(idsol)

        lblNombre.Text = objEvento.oBEEVENTO.strNOMBRE
        lblOrganizador.Text = objEvento.oBEEVENTO.strORGANIZADOR
        lblRefEvento.Text = objEvento.oBEEVENTO.strREFERENCIA
        lblDescEvento.Text = objEvento.oBEEVENTO.strDESCRIPCION
        lblAgenda.Text = objEvento.oBEEVENTO.strRUTAAGENDA

        If Not IsNothing(objEvento.oBEEVENTO.strREFERENCIA) AndAlso objEvento.oBEEVENTO.strREFERENCIA.Split("/").Length > 1 Then
            lblRefEvento.Text = objEvento.oBEEVENTO.strREFERENCIA.Split("/")(1)
            lnkreferencia.Visible = True
            lnkreferencia.Text = "Ver referencia"
            lnkreferencia.NavigateUrl = objEvento.oBEEVENTO.strREFERENCIA
        Else
            lblRefEvento.Text = objEvento.oBEEVENTO.strREFERENCIA
            lnkreferencia.Visible = False
        End If

        If Not IsNothing(objEvento.oBEEVENTO.strRUTAAGENDA) AndAlso objEvento.oBEEVENTO.strRUTAAGENDA.Split("/").Length > 1 Then
            lblAgenda.Text = objEvento.oBEEVENTO.strRUTAAGENDA.Split("/")(1)
            kplnkAgenda.Text = "Ver agenda"
            kplnkAgenda.NavigateUrl = objEvento.oBEEVENTO.strRUTAAGENDA
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
    End Sub
    Private Sub FillDataProductos()
        Dim objBCProductos As New BC.clsBC_PRODUCTORO
        Dim idSol As Int64 = CType(Request.QueryString("idsol"), Int64)
        Dim dt As Data.DataTable = objBCProductos.LeerListaToDTPRODUCTOSOL(idSol)

        If Not IsNothing(dt) Then
            grvProd.DataSource = dt
            grvProd.DataBind()

        End If

    End Sub

    Private Sub FillDataAplicacion()
        Dim objBCApl As New BC.clsBC_APLICACIONRO
        Dim idsol As Int64 = CType(Request.QueryString("idsol"), Int64)
        Dim dt As Data.DataTable = objBCApl.LeerListaToDTAAPLICACIONBYSOL(idsol)
        If Not IsNothing(dt) Then
            grvApl.DataSource = dt
            grvApl.DataBind()
        End If
    End Sub


    Private Sub FillDataDocuments()
        Dim objBCApl As New BC.clsBC_DOCUMENTOS_ADICIONALESRO
        Dim idsol As Int64 = CType(Request.QueryString("idsol"), Int64)
        Dim dt As Data.DataTable = objBCApl.LeerListaToDTDOCUMENTOS_ADICIONALES(idsol)
        If Not IsNothing(dt) Then
            GVDocs.DataSource = dt
            GVDocs.DataBind()
        End If
    End Sub

    Protected Sub GVDocs_RowCommand(sender As Object, e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVDocs.RowCommand

        If e.CommandName = "DeleteDoc" Then

            Dim objBCApl As New BC.clsBC_DOCUMENTOS_ADICIONALESTX
            objBCApl.oBEDOCUMENTOS_ADICIONALES.lngID = CType(e.CommandArgument, Long)
            objBCApl.LstDOCUMENTOS_ADICIONALES.Add(objBCApl.oBEDOCUMENTOS_ADICIONALES)
            objBCApl.EliminarDOCUMENTOS_ADICIONALES()
            FillDataDocuments()
        End If
    End Sub

    Protected Sub GVDocs_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GVDocs.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow And THState.Text.Trim().Equals("APROBADO") Then
            e.Row.Cells(2).Visible = False
        End If

    End Sub

    
    Protected Sub grvApl_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grvApl.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Select Case (e.Row.Cells(3).Text)
                Case "0"
                    e.Row.Cells(3).Text = "EN TRAMITE"
                Case "1"
                    e.Row.Cells(3).Text = "APROBADO"
                Case "2"
                    e.Row.Cells(3).Text = "RECHAZADO"
            End Select



        End If
    End Sub

    Protected Sub grvApl_RowCommand(sender As Object, e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles grvApl.RowCommand
        If e.CommandName = "DeleteApp" Then

            Dim objBCApl As New BC.clsBC_APLICACIONTX

            objBCApl.oBEAPLICACION.lngID = CType(e.CommandArgument, Long)
            objBCApl.LstAPLICACION.Add(objBCApl.oBEAPLICACION)
            objBCApl.EliminarAPLICACION()
            FillDataAplicacion()
        End If
    End Sub
End Class