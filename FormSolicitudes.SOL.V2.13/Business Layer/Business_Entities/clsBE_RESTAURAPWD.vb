Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad RESTAURAPWD
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_RESTAURAPWD
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad RESTAURAPWD
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _uidCLAVECONFIRMACION As Guid
		Private _strCODUSUARIO As String
#End Region

		''' <summary>
		''' Propiedades de la entidad RESTAURAPWD
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

		Public Property uidCLAVECONFIRMACION() As Guid
			Get
				Return _uidCLAVECONFIRMACION
			End Get
			Set(ByVal Value As Guid)
				_uidCLAVECONFIRMACION = Value
			End Set
		End Property

		Public Property strCODUSUARIO() As String
			Get
				Return _strCODUSUARIO
			End Get
			Set(ByVal Value As String)
				_strCODUSUARIO = Value
			End Set
		End Property

#End Region

		''' <summary>
		''' Metodos de la  de la entidad RESTAURAPWD
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_RESTAURAPWD
			Return CType(Me.MemberwiseClone, clsBE_RESTAURAPWD)
		End Function
#End Region

	End Class
End Namespace


