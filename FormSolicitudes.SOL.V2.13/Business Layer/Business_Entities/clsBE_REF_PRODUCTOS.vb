Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad REF_PRODUCTOS
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_REF_PRODUCTOS
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad REF_PRODUCTOS
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _lngid As Long
		Private _strRUTA_REF As String
		Private _lngID_PROD As Long
		Private _BE_PRODUCTO As New clsBE_PRODUCTO
#End Region

		''' <summary>
		''' Propiedades de la entidad REF_PRODUCTOS
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

		Public Property lngid() As Long
			Get
				Return _lngid
			End Get
			Set(ByVal Value As Long)
				_lngid = Value
			End Set
		End Property

		Public Property strRUTA_REF() As String
			Get
				Return _strRUTA_REF
			End Get
			Set(ByVal Value As String)
				_strRUTA_REF = Value
			End Set
		End Property

		Public Property lngID_PROD() As Long
			Get
				Return _lngID_PROD
			End Get
			Set(ByVal Value As Long)
				_lngID_PROD = Value
			End Set
		End Property

		Public Property BE_PRODUCTO() As clsBE_PRODUCTO
			Get
				Return _BE_PRODUCTO
			End Get
			Set(ByVal Value As clsBE_PRODUCTO)
				_BE_PRODUCTO = Value
			End Set
		End Property

#End Region

		''' <summary>
		''' Metodos de la  de la entidad REF_PRODUCTOS
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_REF_PRODUCTOS
			Dim objclsBE_REF_PRODUCTOS As clsBE_REF_PRODUCTOS
			objclsBE_REF_PRODUCTOS = CType(Me.MemberwiseClone, clsBE_REF_PRODUCTOS)
			objclsBE_REF_PRODUCTOS.BE_PRODUCTO = CType(BE_PRODUCTO.getClone, clsBE_PRODUCTO)
			return objclsBE_REF_PRODUCTOS
		End Function
#End Region

	End Class
End Namespace


