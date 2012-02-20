Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad clsBE_BASE
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_BASE

#Region "Declaracion de Miembros" 
		Private _strAUD_SERVICIO As String
		Private _strAUD_REGISTRO_AFECTADO As String
		Private _strAUD_MATRICULA_USR As String
		Private _strAUD_NOM_MAQ As String
		Private _strAUD_IP_MAQ As String
		Private _strAUD_USR_GENERICO As String
		Private _dtmFILTRO_FECHA_INI As Object
		Private _dtmFILTRO_FECHA_FIN As Object
		Private _intROWNUMBER  As Integer
		Private _intPAGESIZE  As Integer
		Private _intCURRENTPAGE  As Integer
		Private _intITEMCOUNT  As Integer
#End Region

#Region "Propiedades" 
		Public Property strAUD_SERVICIO() As String
			Get
				Return _strAUD_SERVICIO
			End Get
			Set(ByVal value As String)
				_strAUD_SERVICIO = value
			End Set
		End Property
		Public Property strAUD_REGISTRO_AFECTADO() As String
			Get
				Return _strAUD_REGISTRO_AFECTADO
			End Get
			Set(ByVal value As String)
				_strAUD_REGISTRO_AFECTADO = value
			End Set
		End Property
		Public Property strAUD_MATRICULA_USR() As String
			Get
				Return _strAUD_MATRICULA_USR
			End Get
			Set(ByVal value As String)
				_strAUD_MATRICULA_USR = value
			End Set
		End Property
		Public Property strAUD_NOM_MAQ() As String
			Get
				Return _strAUD_NOM_MAQ
			End Get
			Set(ByVal value As String)
				_strAUD_NOM_MAQ = value
			End Set
		End Property
		Public Property strAUD_IP_MAQ() As String
			Get
				Return _strAUD_IP_MAQ
			End Get
			Set(ByVal value As String)
				_strAUD_IP_MAQ = value
			End Set
		End Property
		Public Property strAUD_USR_GENERICO() As String
			Get
				Return _strAUD_USR_GENERICO
			End Get
			Set(ByVal value As String)
				_strAUD_USR_GENERICO = value
			End Set
		End Property
		Public Property dtmFILTRO_FECHA_INI() As Object
			Get
				Return _dtmFILTRO_FECHA_INI
			End Get
			Set(ByVal value As Object)
				_dtmFILTRO_FECHA_INI = value
			End Set
		End Property
		Public Property dtmFILTRO_FECHA_FIN() As Object
			Get
				Return _dtmFILTRO_FECHA_FIN
			End Get
			Set(ByVal value As Object)
				_dtmFILTRO_FECHA_FIN = value
			End Set
		End Property
		Public Property intROWNUMBER() As Integer
			Get
				Return _intROWNUMBER
			End Get
			Set(ByVal value As Integer)
				_intROWNUMBER = value
			End Set
		End Property
		Public Property intPAGESIZE() As Integer
			Get
				Return _intPAGESIZE
			End Get
			Set(ByVal value As Integer)
				_intPAGESIZE = value
			End Set
		End Property
		Public Property intCURRENTPAGE() As Integer
			Get
				Return _intCURRENTPAGE
			End Get
			Set(ByVal value As Integer)
				_intCURRENTPAGE = value
			End Set
		End Property
		Public Property intITEMCOUNT() As Integer
			Get
				Return _intITEMCOUNT
			End Get
			Set(ByVal value As Integer)
				_intITEMCOUNT = value
			End Set
		End Property
#End Region


	End Class
End Namespace


