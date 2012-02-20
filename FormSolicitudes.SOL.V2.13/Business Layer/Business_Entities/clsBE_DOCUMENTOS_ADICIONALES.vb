Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:10/01/2012
	''' Proposito: Representa la entidad DOCUMENTOS_ADICIONALES
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_DOCUMENTOS_ADICIONALES
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad DOCUMENTOS_ADICIONALES
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _lngID As Long
		Private _lngIDSOLICITUD As Long
		Private _strDESCRIPCION As String
		Private _strRUTA_ARCHIVO As String
#End Region

		''' <summary>
		''' Propiedades de la entidad DOCUMENTOS_ADICIONALES
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

		Public Property lngID() As Long
			Get
				Return _lngID
			End Get
			Set(ByVal Value As Long)
				_lngID = Value
			End Set
		End Property

		Public Property lngIDSOLICITUD() As Long
			Get
				Return _lngIDSOLICITUD
			End Get
			Set(ByVal Value As Long)
				_lngIDSOLICITUD = Value
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
		''' Metodos de la  de la entidad DOCUMENTOS_ADICIONALES
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_DOCUMENTOS_ADICIONALES
			Return CType(Me.MemberwiseClone, clsBE_DOCUMENTOS_ADICIONALES)
		End Function
#End Region

	End Class
End Namespace


