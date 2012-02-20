Imports PromPeru.Configuration.Enumerators

Public Class uc_GiroSector
    Inherits System.Web.UI.UserControl
    Public Property SelectedValue As String
        Set(ByVal value As String)
            If ddlGiro.Items.Count > 0 AndAlso Not IsNothing(value) AndAlso value.Trim.Length > 0 Then
                Dim lisit As ListItem = ddlGiro.Items.FindByValue(value)
                If Not IsNothing(lisit) Then
                    ddlGiro.SelectedIndex = ddlGiro.Items.IndexOf(lisit)
                Else
                    ddlGiro.SelectedIndex = 0
                End If
            End If
        End Set
        Get
            Return ddlGiro.SelectedValue
        End Get
    End Property
    Public Property SelectecItem As ListItem
        Set(ByVal value As ListItem)
            If ddlGiro.Items.Count > 0 Then               
                ddlGiro.SelectedIndex = ddlGiro.Items.IndexOf(value)
            End If
        End Set
        Get
            Return ddlGiro.SelectedItem
        End Get
    End Property
    Private Sub LoadDdl(ByVal xtipo As tipoLista)
        Dim dt As New DataTable
        dt.Columns.Add("key")
        dt.Columns.Add("value")
        Dim dr As DataRow = dt.NewRow()

        If xtipo = tipoLista.Giro Then
            dr("key") = 1
            dr("value") = "AGROINDUSTRIA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 2
            dr("value") = "ALIMENTOS, BEBIDAS Y LICORES"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 3
            dr("value") = "ARTESANÍAS Y REGALOS"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 4
            dr("value") = "ASOCIACIONES, GREMIOS E INSTITUCIONES "
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 5
            dr("value") = "ASESORIA JURIDICA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 6
            dr("value") = "AUTOMOTRIZ"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 7
            dr("value") = "BANCA Y FINANZAS"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 8
            dr("value") = "CAFÉ Y CACAO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 9
            dr("value") = "CALZADO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 10
            dr("value") = "COMUNICACIONES Y PRENSA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 11
            dr("value") = "COMERCIO EXTERIOR"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 12
            dr("value") = "CONSULTORÍA EMPRESARIAL"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 13
            dr("value") = "DEPORTES, CULTURA Y RECREACIÓN"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 14
            dr("value") = "EDUCACIÓN"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 15
            dr("value") = "ELECTRODOMÉSTICOS, MUEBLES Y ENSERES"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 16
            dr("value") = "HIDROCARBUROS y ELECTRICIDAD"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 17
            dr("value") = "HOTELERIA Y TURISMO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 18
            dr("value") = "IMPRENTAS E EDITORIALES"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 19
            dr("value") = "INDUSTRIA QUÍMICA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 20
            dr("value") = "INFORMÁTICA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 21
            dr("value") = "INGENIERÍA, MINERÍA Y CONSTRUCCIÓN"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 22
            dr("value") = "JOYERIA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 23
            dr("value") = "MARKETING Y PUBLICIDAD"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 24
            dr("value") = "MANUFACTURA DIVERSA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 25
            dr("value") = "METALMECÁNICA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 26
            dr("value") = "OPERADORES LOGÍSTICOS"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 27
            dr("value") = "PESCA Y ACUICULTURA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 28
            dr("value") = "PLÁSTICOS, ENVASES Y ENVOLTURAS"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 29
            dr("value") = "RESTAURANTES"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 30
            dr("value") = "RETAIL Y SERVICIOS DIVERSOS"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 31
            dr("value") = "HIGIENE Y BELLEZA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 32
            dr("value") = "SECTOR PÚBLICO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 33
            dr("value") = "SEGURIDAD Y VIGILANCIA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 34
            dr("value") = "TEXTILES Y CONFECCIONES"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 35
            dr("value") = "TRANSPORTE "
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 36
            dr("value") = "OTROS"
            dt.Rows.Add(dr) : dr = dt.NewRow
        ElseIf xtipo = tipoLista.Sector Then
            dr("key") = 37
            dr("value") = "MINISTERIO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 38
            dr("value") = "ORGANISMO PÚBLICO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 39
            dr("value") = "GOBIERNO REGIONAL"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 40
            dr("value") = "GOBIERNO LOCAL"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 41
            dr("value") = "OTROS ORGANISMOS"
            dt.Rows.Add(dr) : dr = dt.NewRow
        Else
            dr("key") = 0
            dr("value") = "--MOSTRAR TODOS--"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 1
            dr("value") = "AGROINDUSTRIA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 2
            dr("value") = "ALIMENTOS, BEBIDAS Y LICORES"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 3
            dr("value") = "ARTESANÍAS Y REGALOS"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 4
            dr("value") = "ASOCIACIONES, GREMIOS E INSTITUCIONES "
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 5
            dr("value") = "ASESORIA JURIDICA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 6
            dr("value") = "AUTOMOTRIZ"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 7
            dr("value") = "BANCA Y FINANZAS"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 8
            dr("value") = "CAFÉ Y CACAO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 9
            dr("value") = "CALZADO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 10
            dr("value") = "COMUNICACIONES Y PRENSA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 11
            dr("value") = "COMERCIO EXTERIOR"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 12
            dr("value") = "CONSULTORÍA EMPRESARIAL"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 13
            dr("value") = "DEPORTES, CULTURA Y RECREACIÓN"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 14
            dr("value") = "EDUCACIÓN"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 15
            dr("value") = "ELECTRODOMÉSTICOS, MUEBLES Y ENSERES"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 16
            dr("value") = "HIDROCARBUROS y ELECTRICIDAD"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 17
            dr("value") = "HOTELERIA Y TURISMO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 18
            dr("value") = "IMPRENTAS E EDITORIALES"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 19
            dr("value") = "INDUSTRIA QUÍMICA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 20
            dr("value") = "INFORMÁTICA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 21
            dr("value") = "INGENIERÍA, MINERÍA Y CONSTRUCCIÓN"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 22
            dr("value") = "JOYERIA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 23
            dr("value") = "MARKETING Y PUBLICIDAD"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 24
            dr("value") = "MANUFACTURA DIVERSA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 25
            dr("value") = "METALMECÁNICA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 26
            dr("value") = "OPERADORES LOGÍSTICOS"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 27
            dr("value") = "PESCA Y ACUICULTURA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 28
            dr("value") = "PLÁSTICOS, ENVASES Y ENVOLTURAS"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 29
            dr("value") = "RESTAURANTES"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 30
            dr("value") = "RETAIL Y SERVICIOS DIVERSOS"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 31
            dr("value") = "HIGIENE Y BELLEZA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 32
            dr("value") = "SECTOR PÚBLICO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 33
            dr("value") = "SEGURIDAD Y VIGILANCIA"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 34
            dr("value") = "TEXTILES Y CONFECCIONES"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 35
            dr("value") = "TRANSPORTE "
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 36
            dr("value") = "OTROS"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 37
            dr("value") = "MINISTERIO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 38
            dr("value") = "ORGANISMO PÚBLICO"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 39
            dr("value") = "GOBIERNO REGIONAL"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 40
            dr("value") = "GOBIERNO LOCAL"
            dt.Rows.Add(dr) : dr = dt.NewRow
            dr("key") = 41
            dr("value") = "OTROS ORGANISMOS"
            dt.Rows.Add(dr) : dr = dt.NewRow
        End If

        ddlGiro.DataSource = dt
        ddlGiro.DataValueField = "key"
        ddlGiro.DataTextField = "value"
        ddlGiro.DataBind()
    End Sub
    Public Property Tipo As tipoLista
        Get
            Return ViewState("_tipo_")
        End Get
        Set(ByVal value As tipoLista)
            ViewState("_tipo_") = value
            LoadDdl(value)
        End Set
    End Property



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class