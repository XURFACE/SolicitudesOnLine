Imports MP.DW.BL
Namespace MP.DW.BL.BE

    <Serializable()> _
    Public Class clsBE_SOLICITUDTOTAL
        Inherits clsBE_BASE
#Region "Declaracion de Miembros"

        Private _BE_EMPRESA As New clsBE_EMPRESA
        Private _LIST_BE_REF_EMPRESA As New List(Of clsBE_REF_EMPRESA)
        Private _BE_UBIGEO As New clsBE_UBIGEO
        Private _BE_SOLICITUD_INST As New clsBE_SOLICITUD
        Private _BE_SOLICITUD_PROD As New clsBE_SOLICITUD
        Private _BE_SOLICITUD_EVENT As New clsBE_SOLICITUD
        Private _LIST_BE_PRODUCTO As New List(Of clsBE_PRODUCTO)
        Private _LIST_BE_PRODUCTO_REF As New List(Of clsBE_REF_PRODUCTOS)
        Private _BE_EVENTO As New clsBE_EVENTO
        Private _LIST_BE_DETUSO As New List(Of clsBE_DET_USO)
        Private _LIST_BE_AMBITOUSO As New List(Of clsBE_AMBITOUSO)
        Private _tipo_persona As UShort = 10
        Private _Existe As Boolean = False
        Private _Renovar As Boolean = False

#End Region

#Region "Propiedades"
        Public Property BE_EMPRESA() As clsBE_EMPRESA
            Get
                Return _BE_EMPRESA
            End Get
            Set(ByVal Value As clsBE_EMPRESA)
                _BE_EMPRESA = Value
            End Set
        End Property

        Public Property LIST_BE_REF_EMPRESA() As List(Of clsBE_REF_EMPRESA)
            Get
                Return _LIST_BE_REF_EMPRESA
            End Get
            Set(ByVal Value As List(Of clsBE_REF_EMPRESA))
                _LIST_BE_REF_EMPRESA = Value
            End Set
        End Property


        Public Property BE_UBIGEO() As clsBE_UBIGEO
            Get
                Return _BE_UBIGEO
            End Get
            Set(ByVal Value As clsBE_UBIGEO)
                _BE_UBIGEO = Value
            End Set
        End Property
        Public Property BE_SOLICITUD_INST() As clsBE_SOLICITUD
            Get
                Return _BE_SOLICITUD_INST
            End Get
            Set(ByVal Value As clsBE_SOLICITUD)
                _BE_SOLICITUD_INST = Value
            End Set
        End Property
        Public Property BE_SOLICITUD_PROD() As clsBE_SOLICITUD
            Get
                Return _BE_SOLICITUD_PROD
            End Get
            Set(ByVal Value As clsBE_SOLICITUD)
                _BE_SOLICITUD_PROD = Value
            End Set
        End Property
        Public Property BE_SOLICITUD_EVENT() As clsBE_SOLICITUD
            Get
                Return _BE_SOLICITUD_EVENT
            End Get
            Set(ByVal Value As clsBE_SOLICITUD)
                _BE_SOLICITUD_EVENT = Value
            End Set
        End Property



        Public Property LIST_BE_PRODUCTO() As List(Of clsBE_PRODUCTO)
            Get
                Return _LIST_BE_PRODUCTO
            End Get
            Set(ByVal Value As List(Of clsBE_PRODUCTO))
                _LIST_BE_PRODUCTO = Value
            End Set
        End Property

        Public Property LIST_BE_PRODUCTO_REF() As List(Of clsBE_REF_PRODUCTOS)
            Get
                Return _LIST_BE_PRODUCTO_REF
            End Get
            Set(ByVal Value As List(Of clsBE_REF_PRODUCTOS))
                _LIST_BE_PRODUCTO_REF = Value
            End Set
        End Property
        Public Property BE_EVENTO() As clsBE_EVENTO
            Get
                Return _BE_EVENTO
            End Get
            Set(ByVal Value As clsBE_EVENTO)
                _BE_EVENTO = Value
            End Set
        End Property
        Public Property LIST_BE_DETUSO() As List(Of clsBE_DET_USO)
            Get
                Return _LIST_BE_DETUSO
            End Get
            Set(ByVal Value As List(Of clsBE_DET_USO))
                _LIST_BE_DETUSO = Value
            End Set
        End Property
        Public Property LIST_BE_AMBITOUSO() As List(Of clsBE_AMBITOUSO)
            Get
                Return _LIST_BE_AMBITOUSO
            End Get
            Set(ByVal Value As List(Of clsBE_AMBITOUSO))
                _LIST_BE_AMBITOUSO = Value
            End Set
        End Property

        Public Property tipo_persona As UShort
            Get
                Return _tipo_persona
            End Get
            Set(ByVal Value As UShort)
                _tipo_persona = Value
            End Set
        End Property

        Public Property Existe As Boolean
            Get
                Return _Existe
            End Get
            Set(ByVal Value As Boolean)
                _Existe = Value
            End Set
        End Property
        Public Property Renovar As Boolean
            Get
                Return _Renovar
            End Get
            Set(ByVal Value As Boolean)
                _Renovar = Value
            End Set
        End Property

#End Region
    End Class
End Namespace
