Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:07/12/2011
	''' Proposito: Representa la entidad AUDITORIA
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_AUDITORIA
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad AUDITORIA
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _lngAUD_COD As Long
		Private _strAUD_ENTIDAD As String
		Private _strAUD_ACCION_ENTIDAD As String
		Private _strAUD_SERVICIO As String
		Private _strAUD_REGISTRO_AFECTADO As String
		Private _dtmAUD_FECHA As Nullable(Of DateTime)
		Private _strAUD_USR_REGISTER As String
		Private _strAUD_NOM_MAQ As String
		Private _strAUD_IP_MAQ As String
		Private _strAUD_USR_GENERICO As String
#End Region

		''' <summary>
		''' Propiedades de la entidad AUDITORIA
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

		Public Property lngAUD_COD() As Long
			Get
				Return _lngAUD_COD
			End Get
			Set(ByVal Value As Long)
				_lngAUD_COD = Value
			End Set
		End Property

		Public Property strAUD_ENTIDAD() As String
			Get
				Return _strAUD_ENTIDAD
			End Get
			Set(ByVal Value As String)
				_strAUD_ENTIDAD = Value
			End Set
		End Property

		Public Property strAUD_ACCION_ENTIDAD() As String
			Get
				Return _strAUD_ACCION_ENTIDAD
			End Get
			Set(ByVal Value As String)
				_strAUD_ACCION_ENTIDAD = Value
			End Set
		End Property

		Public Property strAUD_SERVICIO() As String
			Get
				Return _strAUD_SERVICIO
			End Get
			Set(ByVal Value As String)
				_strAUD_SERVICIO = Value
			End Set
		End Property

		Public Property strAUD_REGISTRO_AFECTADO() As String
			Get
				Return _strAUD_REGISTRO_AFECTADO
			End Get
			Set(ByVal Value As String)
				_strAUD_REGISTRO_AFECTADO = Value
			End Set
		End Property

		Public Property dtmAUD_FECHA() As Nullable(Of DateTime)
			Get
				Return _dtmAUD_FECHA
			End Get
			Set(ByVal Value As  Nullable(Of DateTime))
				_dtmAUD_FECHA = Value
			End Set
		End Property

		Public Property strAUD_USR_REGISTER() As String
			Get
				Return _strAUD_USR_REGISTER
			End Get
			Set(ByVal Value As String)
				_strAUD_USR_REGISTER = Value
			End Set
		End Property

		Public Property strAUD_NOM_MAQ() As String
			Get
				Return _strAUD_NOM_MAQ
			End Get
			Set(ByVal Value As String)
				_strAUD_NOM_MAQ = Value
			End Set
		End Property

		Public Property strAUD_IP_MAQ() As String
			Get
				Return _strAUD_IP_MAQ
			End Get
			Set(ByVal Value As String)
				_strAUD_IP_MAQ = Value
			End Set
		End Property

		Public Property strAUD_USR_GENERICO() As String
			Get
				Return _strAUD_USR_GENERICO
			End Get
			Set(ByVal Value As String)
				_strAUD_USR_GENERICO = Value
			End Set
		End Property

#End Region

		''' <summary>
		''' Metodos de la  de la entidad AUDITORIA
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_AUDITORIA
			Return CType(Me.MemberwiseClone, clsBE_AUDITORIA)
		End Function
#End Region

	End Class
End Namespace


