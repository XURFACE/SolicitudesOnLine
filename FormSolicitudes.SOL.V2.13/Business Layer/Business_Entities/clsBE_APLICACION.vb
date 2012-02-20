Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad APLICACION
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_APLICACION
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad APLICACION
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _lngID As Long
		Private _strDECRIPCION As String
		Private _lngIDSOLICITUD As Long
		Private _intSTSAPLICACION As Integer
		Private _strRUTA_IMAGEN As String
		Private _BE_SOLICITUD As New clsBE_SOLICITUD
#End Region

		''' <summary>
		''' Propiedades de la entidad APLICACION
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

		Public Property strDECRIPCION() As String
			Get
				Return _strDECRIPCION
			End Get
			Set(ByVal Value As String)
				_strDECRIPCION = Value
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

		Public Property intSTSAPLICACION() As Integer
			Get
				Return _intSTSAPLICACION
			End Get
			Set(ByVal Value As Integer)
				_intSTSAPLICACION = Value
			End Set
		End Property

		Public Property strRUTA_IMAGEN() As String
			Get
				Return _strRUTA_IMAGEN
			End Get
			Set(ByVal Value As String)
				_strRUTA_IMAGEN = Value
			End Set
		End Property

		Public Property BE_SOLICITUD() As clsBE_SOLICITUD
			Get
				Return _BE_SOLICITUD
			End Get
			Set(ByVal Value As clsBE_SOLICITUD)
				_BE_SOLICITUD = Value
			End Set
		End Property

#End Region

		''' <summary>
		''' Metodos de la  de la entidad APLICACION
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_APLICACION
			Dim objclsBE_APLICACION As clsBE_APLICACION
			objclsBE_APLICACION = CType(Me.MemberwiseClone, clsBE_APLICACION)
			objclsBE_APLICACION.BE_SOLICITUD = CType(BE_SOLICITUD.getClone, clsBE_SOLICITUD)
			return objclsBE_APLICACION
		End Function
#End Region

	End Class
End Namespace


