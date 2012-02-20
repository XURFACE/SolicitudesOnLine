Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:05/01/2012
	''' Proposito: Representa la entidad FAQ
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_FAQ
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad FAQ
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _intID As Integer
		Private _strPREGUNTA As String
		Private _strRESPUESTA As String
		Private _intNUMORDEN As Integer
		Private _blnIND_ACTIVO As Nullable(Of Boolean)
#End Region

		''' <summary>
		''' Propiedades de la entidad FAQ
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

		Public Property strPREGUNTA() As String
			Get
				Return _strPREGUNTA
			End Get
			Set(ByVal Value As String)
				_strPREGUNTA = Value
			End Set
		End Property

		Public Property strRESPUESTA() As String
			Get
				Return _strRESPUESTA
			End Get
			Set(ByVal Value As String)
				_strRESPUESTA = Value
			End Set
		End Property

		Public Property intNUMORDEN() As Integer
			Get
				Return _intNUMORDEN
			End Get
			Set(ByVal Value As Integer)
				_intNUMORDEN = Value
			End Set
		End Property

		Public Property blnIND_ACTIVO() As Nullable(Of Boolean)
			Get
				Return _blnIND_ACTIVO
			End Get
			Set(ByVal Value As  Nullable(Of Boolean))
				_blnIND_ACTIVO = Value
			End Set
		End Property

#End Region

		''' <summary>
		''' Metodos de la  de la entidad FAQ
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_FAQ
			Return CType(Me.MemberwiseClone, clsBE_FAQ)
		End Function
#End Region

	End Class
End Namespace


