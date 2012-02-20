Imports PromPeru.Configuration.Enumerators

Public Class wucMensaje
    Inherits System.Web.UI.UserControl



#Region "Propiedades"
    Public Property CssClass As String
        Get
            Return ViewState("_CssClass_")
        End Get
        Set(ByVal value As String)
            ViewState("_CssClass_") = value
        End Set
    End Property
    Public Property TipoMsg As tipoMensaje
        Set(ByVal value As tipoMensaje)
            ViewState("_TipoMsg_") = value
            If CssClass Is Nothing Then
                Select Case value
                    Case tipoMensaje.Fallido
                        Div_Msg.Attributes.Add("Class", "Div_MsgError")
                        tdTitMensaje.Attributes.Add("Class", "ErroTitle")
                    Case tipoMensaje.Correcto
                        Div_Msg.Attributes.Add("Class", "Div_MsgAceptado")
                        tdTitMensaje.Attributes.Add("Class", "AceptadoTitle")
                    Case tipoMensaje.Simple
                        Div_Msg.Attributes.Add("Class", "Div_MsgSimple")
                        tdTitMensaje.Attributes.Add("Class", "SimpleTitle")
                End Select
            Else
                Div_Msg.Attributes.Add("Class", CssClass)
            End If
        End Set
        Get
            Return ViewState("_TipoMsg_")
        End Get
    End Property
    Public WriteOnly Property TitMsg As String
        Set(ByVal value As String)
            lblTitMensaje.Text = value
            'lblTitMensaje.Text = "&nbsp;&nbsp;&nbsp;" & value & "&nbsp;&nbsp;&nbsp;"
        End Set
    End Property
    Public WriteOnly Property DetMsg As String
        Set(ByVal value As String)
            lblCuerpoMsg.Text = value
        End Set
    End Property
    Public Overrides Property Visible As Boolean
        Get
            Return MyBase.Visible
        End Get
        Set(ByVal value As Boolean)
            'If value Then
            '    btnAceptarOk.Focus()
            'End If
            MyBase.Visible = value
        End Set
    End Property

#End Region

    Public Event AceptarOKBtn As EventHandler
    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptarOk.Click
        'If Me.TipoMsg = tipoMensaje.Correcto Or Me.TipoMsg = tipoMensaje.Simple Then
        'If Not IsNothing(AceptarOKBtn) Then
        'End If
        RaiseEvent AceptarOKBtn(sender, e)
        'End If
        'MyBase.Visible = False
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblCuerpoMsg.Attributes.Remove("onfocus")
        lblCuerpoMsg.Attributes.Remove("onblur")
        lblCuerpoMsg.CssClass = "Con_FormGrillaItemStyleMull"
    End Sub

End Class