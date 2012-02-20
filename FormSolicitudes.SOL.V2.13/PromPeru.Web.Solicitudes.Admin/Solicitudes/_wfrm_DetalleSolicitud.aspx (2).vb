Imports MP.DW.BL
Public Class wfrm_DetalleSolicitud
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim objEMPRESARO As New BC.clsBC_EMPRESARO
            Dim objSOLICITUD As New BC.clsBC_SOLICITUDRO
            Dim objEmpresa As New BE.clsBE_EMPRESA
            Dim objPRODUCTORO As New BC.clsBC_PRODUCTORO
            Dim objProdData As New DataTable
            Dim objAPLICACIONRO As New BC.clsBC_APLICACIONRO
            Dim objAplData As New DataTable

            Dim idEmp As Int64
            Dim idSol As Int64

            If Not IsNothing(Request.QueryString("id")) Then
                idEmp = CType(Request.QueryString("id"), Int64)
                objEmpresa.lngID = idEmp
                objEMPRESARO.oBEEMPRESA = objEmpresa
                objEMPRESARO.LeerEMPRESA()

                cargarRefEmpresa()
            End If

            If Not IsNothing(Request.QueryString("idSol")) Then
                idSol = CType(Request.QueryString("idSol"), Int64)
                objProdData = objPRODUCTORO.LeerListaToDTPRODUCTOSOL(idSol)
                objAplData = objAPLICACIONRO.LeerListaToDTAAPLICACIONBYSOL(idSol)
                objSOLICITUD.oBESOLICITUD.lngID = idSol
                objSOLICITUD.LeerSOLICITUD()


                cargarDocsAdic(idSol)
                If objProdData.Rows.Count > 0 Then
                    cargarRefProductos(objProdData.Rows(0)(0))
                End If

            End If

            txtRazonSoc.Text = objEMPRESARO.oBEEMPRESA.strRAZONSOCIAL
            Txt_RUC.Text = objEMPRESARO.oBEEMPRESA.strRUC
            txtRepresentante.Text = objEMPRESARO.oBEEMPRESA.strREPRESENTANTE
            txtCargo.Text = objEMPRESARO.oBEEMPRESA.strCARGO
            txtdniRepr.Text = objEMPRESARO.oBEEMPRESA.strDNI
            lblNameGiro.Text = objEMPRESARO.oBEEMPRESA.strGIRO
            txtWeb.Text = objEMPRESARO.oBEEMPRESA.strWEB
            txtDireccion.Text = objEMPRESARO.oBEEMPRESA.strDOMICILIO
            lblDistr.Text = objEMPRESARO.oBEEMPRESA.strCOD_DIST
            lbldpto.Text = objEMPRESARO.oBEEMPRESA.strCOD_DPTO
            lblProv.Text = objEMPRESARO.oBEEMPRESA.strCOD_PROV
            txtPartida.Text = objEMPRESARO.oBEEMPRESA.strNUMPARTIDA
            If objEMPRESARO.oBEEMPRESA.strRUTALICENCIA <> "" Then
                lnkLF.Text = "ver licencia"
                lnkLF.NavigateUrl = objEMPRESARO.oBEEMPRESA.strRUTALICENCIA
            Else
                lnkLF.Text = ""
            End If
            If objEMPRESARO.oBEEMPRESA.strRUTARUC <> "" Then
                lnkRuc.Text = "ver RUC"
                lnkRuc.NavigateUrl = objEMPRESARO.oBEEMPRESA.strRUTARUC
            Else
                lnkRuc.Text = ""
            End If
            If objEMPRESARO.oBEEMPRESA.strRUTADNI <> "" Then
                lnkDNI.Text = "ver documento de identidad"
                lnkDNI.NavigateUrl = objEMPRESARO.oBEEMPRESA.strRUTADNI
            Else
                lnkDNI.Text = ""
            End If
            If objEMPRESARO.oBEEMPRESA.strRUTAVIGPODER <> "" Then
                lnkVP.Text = "ver Vigencia"
                lnkVP.NavigateUrl = objEMPRESARO.oBEEMPRESA.strRUTAVIGPODER
            Else
                lnkVP.Text = ""
            End If

            txtTelefono.Text = objEMPRESARO.oBEEMPRESA.strNUMTEL
            txtmail.Text = objEMPRESARO.oBEEMPRESA.strEMAIL
            txtCiudad.Text = objEMPRESARO.oBEEMPRESA.strCIUDAD
            txtPais.Text = objEMPRESARO.oBEEMPRESA.strPAIS

            If objEMPRESARO.oBEEMPRESA.strTIPOEMPRESA = "Persona Jurídica" Then
                txtload.Text = "0"
            ElseIf objEMPRESARO.oBEEMPRESA.strTIPOEMPRESA = "Persona Jurídica Extranjera" Then
                txtload.Text = "1"
            ElseIf objEMPRESARO.oBEEMPRESA.strTIPOEMPRESA = "Persona Natural con Negocio" Then
                txtload.Text = "2"
            ElseIf objEMPRESARO.oBEEMPRESA.strTIPOEMPRESA = "Organismo Estatal" Then
                txtload.Text = "3"
            End If
            lblEstadoActual.Text = objSOLICITUD.oBESOLICITUD.strSTSSOL.ToUpper
            LUso.Text = objSOLICITUD.oBESOLICITUD.strTIPOLIC.ToUpper
            'lblRotProd.Visible = objSOLICITUD.oBESOLICITUD.strTIPOLIC.ToUpper.Contains("PRODUCTO")

            grvProd.DataSource = objProdData
            grvProd.DataBind()

            grvAplicUso.DataSource = objAplData
            grvAplicUso.DataBind()

        End If
    End Sub

    Private Sub grvAplicUso_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grvAplicUso.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim chkAprob As CheckBox
            chkAprob = e.Row.FindControl("chkAprob")
            If Not IsNothing(chkAprob) Then
                chkAprob.Checked = grvAplicUso.DataKeys(e.Row.RowIndex).Values(1) = 1
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

        Dim chkbox As CheckBox = CType(sender, CheckBox)
        Dim row As GridViewRow = DirectCast(DirectCast(chkbox.Parent, DataControlFieldCell).Parent, GridViewRow)
        Dim intRowIndex As Int32 = row.RowIndex
        Dim objAPLICACIONTX As New BC.clsBC_APLICACIONTX
        Dim objAPLICACIONRO As New BC.clsBC_APLICACIONRO

        If Not IsNothing(Request.QueryString("idSol")) Then
            objAPLICACIONRO.oBEAPLICACION.lngID = grvAplicUso.DataKeys(intRowIndex).Values(0)
            objAPLICACIONRO.LeerAPLICACION()
            objAPLICACIONTX.oBEAPLICACION = objAPLICACIONRO.oBEAPLICACION
            objAPLICACIONTX.oBEAPLICACION.intSTSAPLICACION = IIf(chkbox.Checked, 1, 0)
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
End Class