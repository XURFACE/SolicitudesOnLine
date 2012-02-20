Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad USUARIO
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_USUARIO
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad USUARIO
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _intID As Integer
		Private _strLOGIN As String
		Private _strPASSWORD As String
		Private _strNOMBRE As String
		Private _strPERFIL As String
#End Region

		''' <summary>
		''' Propiedades de la entidad USUARIO
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

		Public Property strLOGIN() As String
			Get
				Return _strLOGIN
			End Get
			Set(ByVal Value As String)
				_strLOGIN = Value
			End Set
		End Property

		Public Property strPASSWORD() As String
			Get
				Return _strPASSWORD
			End Get
			Set(ByVal Value As String)
				_strPASSWORD = Value
			End Set
		End Property

		Public Property strNOMBRE() As String
			Get
				Return _strNOMBRE
			End Get
			Set(ByVal Value As String)
				_strNOMBRE = Value
			End Set
		End Property

		Public Property strPERFIL() As String
			Get
				Return _strPERFIL
			End Get
			Set(ByVal Value As String)
				_strPERFIL = Value
			End Set
		End Property

#End Region

		''' <summary>
		''' Metodos de la  de la entidad USUARIO
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_USUARIO
			Return CType(Me.MemberwiseClone, clsBE_USUARIO)
		End Function
#End Region

	End Class
End Namespace


