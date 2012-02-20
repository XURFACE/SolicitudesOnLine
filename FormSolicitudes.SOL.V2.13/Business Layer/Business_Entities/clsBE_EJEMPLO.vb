Namespace MP.DW.BL.BE
    ''' <summary>
    ''' Escrito por: Alejandro Mayta C.
    ''' Fecha Creacion:05/01/2012
    ''' Proposito: Representa la entidad EJEMPLO
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    <Serializable()> _
    Public Class clsBE_EJEMPLO
        Inherits clsBE_BASE

        ''' <summary>
        ''' Miembros privados de la entidad EJEMPLO
        ''' </summary>
        ''' <remarks></remarks>
#Region "Declaracion de Miembros"
        Private _intItem As Integer
        Private _intID As Integer
        Private _strDESCRIPCION As String
        Private _strTIPOLIC As String
        Private _blnIND_ACTIVO As Nullable(Of Boolean)
        Private _strRUTA_ARCHIVO As String
#End Region

        ''' <summary>
        ''' Propiedades de la entidad EJEMPLO
        ''' </summary>
#Region "Propiedades"
        Public Property Item As Integer
            Get
                Return _intItem
            End Get
            Set(ByVal Value As Integer)
                _intItem = Value
            End Set
        End Property

        Public Property intID() As Integer
            Get
                Return _intID
            End Get
            Set(ByVal Value As Integer)
                _intID = Value
            End Set
        End Property

        Public Property strDESCRIPCION() As String
            Get
                Return _strDESCRIPCION
            End Get
            Set(ByVal Value As String)
                _strDESCRIPCION = Value
            End Set
        End Property

        Public Property strTIPOLIC() As String
            Get
                Return _strTIPOLIC
            End Get
            Set(ByVal Value As String)
                _strTIPOLIC = Value
            End Set
        End Property

        Public Property blnIND_ACTIVO() As Nullable(Of Boolean)
            Get
                Return _blnIND_ACTIVO
            End Get
            Set(ByVal Value As Nullable(Of Boolean))
                _blnIND_ACTIVO = Value
            End Set
        End Property

        Public Property strRUTA_ARCHIVO() As String
            Get
                Return _strRUTA_ARCHIVO
            End Get
            Set(ByVal Value As String)
                _strRUTA_ARCHIVO = Value
            End Set
        End Property

#End Region

        ''' <summary>
        ''' Metodos de la  de la entidad EJEMPLO
        ''' </summary>
#Region "Declaracion de Metodos"
        Public Function getClone() As clsBE_EJEMPLO
            Return CType(Me.MemberwiseClone, clsBE_EJEMPLO)
        End Function
#End Region

    End Class
End Namespace