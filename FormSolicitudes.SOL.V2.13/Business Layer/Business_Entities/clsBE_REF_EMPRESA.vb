Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad REF_EMPRESA
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_REF_EMPRESA
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad REF_EMPRESA
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _lngID As Long
		Private _lngIDEMPRESA As Long
		Private _strRUTA_REF As String
		Private _BE_EMPRESA As New clsBE_EMPRESA
#End Region

		''' <summary>
		''' Propiedades de la entidad REF_EMPRESA
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

		Public Property lngIDEMPRESA() As Long
			Get
				Return _lngIDEMPRESA
			End Get
			Set(ByVal Value As Long)
				_lngIDEMPRESA = Value
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

		Public Property BE_EMPRESA() As clsBE_EMPRESA
			Get
				Return _BE_EMPRESA
			End Get
			Set(ByVal Value As clsBE_EMPRESA)
				_BE_EMPRESA = Value
			End Set
		End Property

#End Region

		''' <summary>
		''' Metodos de la  de la entidad REF_EMPRESA
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_REF_EMPRESA
			Dim objclsBE_REF_EMPRESA As clsBE_REF_EMPRESA
			objclsBE_REF_EMPRESA = CType(Me.MemberwiseClone, clsBE_REF_EMPRESA)
			objclsBE_REF_EMPRESA.BE_EMPRESA = CType(BE_EMPRESA.getClone, clsBE_EMPRESA)
			return objclsBE_REF_EMPRESA
		End Function
#End Region

	End Class
End Namespace


