Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad MAESTRO
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_MAESTRO
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad MAESTRO
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _intID As Integer
		Private _strDESCMAESTRO As String
#End Region

		''' <summary>
		''' Propiedades de la entidad MAESTRO
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

		Public Property strDESCMAESTRO() As String
			Get
				Return _strDESCMAESTRO
			End Get
			Set(ByVal Value As String)
				_strDESCMAESTRO = Value
			End Set
		End Property

#End Region

		''' <summary>
		''' Metodos de la  de la entidad MAESTRO
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_MAESTRO
			Return CType(Me.MemberwiseClone, clsBE_MAESTRO)
		End Function
#End Region

	End Class
End Namespace


