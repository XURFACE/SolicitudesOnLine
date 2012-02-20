Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad UBIGEO
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_UBIGEO
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad UBIGEO
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _strCOD_UBIGEO As String
		Private _strCOD_TOTAL As String
		Private _strNOMBRE_LARGO As String
		Private _strNOMBRE_CORTO As String
		Private _strCOD_DPTO As String
		Private _strCOD_PROV As String
		Private _strCOD_DIST As String
#End Region

		''' <summary>
		''' Propiedades de la entidad UBIGEO
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

		Public Property strCOD_UBIGEO() As String
			Get
				Return _strCOD_UBIGEO
			End Get
			Set(ByVal Value As String)
				_strCOD_UBIGEO = Value
			End Set
		End Property

		Public Property strCOD_TOTAL() As String
			Get
				Return _strCOD_TOTAL
			End Get
			Set(ByVal Value As String)
				_strCOD_TOTAL = Value
			End Set
		End Property

		Public Property strNOMBRE_LARGO() As String
			Get
				Return _strNOMBRE_LARGO
			End Get
			Set(ByVal Value As String)
				_strNOMBRE_LARGO = Value
			End Set
		End Property

		Public Property strNOMBRE_CORTO() As String
			Get
				Return _strNOMBRE_CORTO
			End Get
			Set(ByVal Value As String)
				_strNOMBRE_CORTO = Value
			End Set
		End Property

		Public Property strCOD_DPTO() As String
			Get
				Return _strCOD_DPTO
			End Get
			Set(ByVal Value As String)
				_strCOD_DPTO = Value
			End Set
		End Property

		Public Property strCOD_PROV() As String
			Get
				Return _strCOD_PROV
			End Get
			Set(ByVal Value As String)
				_strCOD_PROV = Value
			End Set
		End Property

		Public Property strCOD_DIST() As String
			Get
				Return _strCOD_DIST
			End Get
			Set(ByVal Value As String)
				_strCOD_DIST = Value
			End Set
		End Property

#End Region

		''' <summary>
		''' Metodos de la  de la entidad UBIGEO
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_UBIGEO
			Return CType(Me.MemberwiseClone, clsBE_UBIGEO)
		End Function
#End Region

	End Class
End Namespace


