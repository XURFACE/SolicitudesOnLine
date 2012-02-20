Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad PARAMETRO
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_PARAMETRO
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad PARAMETRO
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _intID As Integer
		Private _strDESCPARAM As String
		Private _intCODMAESTRO As Integer
		Private _BE_MAESTRO As New clsBE_MAESTRO
#End Region

		''' <summary>
		''' Propiedades de la entidad PARAMETRO
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

		Public Property strDESCPARAM() As String
			Get
				Return _strDESCPARAM
			End Get
			Set(ByVal Value As String)
				_strDESCPARAM = Value
			End Set
		End Property

		Public Property intCODMAESTRO() As Integer
			Get
				Return _intCODMAESTRO
			End Get
			Set(ByVal Value As Integer)
				_intCODMAESTRO = Value
			End Set
		End Property

		Public Property BE_MAESTRO() As clsBE_MAESTRO
			Get
				Return _BE_MAESTRO
			End Get
			Set(ByVal Value As clsBE_MAESTRO)
				_BE_MAESTRO = Value
			End Set
		End Property

#End Region

		''' <summary>
		''' Metodos de la  de la entidad PARAMETRO
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_PARAMETRO
			Dim objclsBE_PARAMETRO As clsBE_PARAMETRO
			objclsBE_PARAMETRO = CType(Me.MemberwiseClone, clsBE_PARAMETRO)
			objclsBE_PARAMETRO.BE_MAESTRO = CType(BE_MAESTRO.getClone, clsBE_MAESTRO)
			return objclsBE_PARAMETRO
		End Function
#End Region

	End Class
End Namespace


