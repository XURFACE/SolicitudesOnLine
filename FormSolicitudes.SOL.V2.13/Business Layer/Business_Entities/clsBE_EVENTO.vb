Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad EVENTO
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_EVENTO
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad EVENTO
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _lngID As Long
        Private _lngIDSOLICITUD As Long
        Private _strNOMBRE
		Private _strORGANIZADOR As String
		Private _strREFERENCIA As String
		Private _strDESCRIPCION As String
		Private _strRUTAAGENDA As String
        Private _strNUMEDICION As String
        Private _intTIPOPERIODO As Integer
        Private _strTIPOPERIODO As String
		Private _strLUGAR As String
        Private _dtmFECHA As String
		Private _strDESCPUBLICOGRL As String
		Private _intNUMPART As Integer
		Private _dblCOSTOPROM As Double
		Private _strAUSPICIADORES As String
		Private _BE_SOLICITUD As New clsBE_SOLICITUD
#End Region

		''' <summary>
		''' Propiedades de la entidad EVENTO
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
        Public Property strNOMBRE() As String
            Get
                Return _strNOMBRE
            End Get
            Set(ByVal Value As String)
                _strNOMBRE = Value
            End Set
        End Property

		Public Property strORGANIZADOR() As String
			Get
				Return _strORGANIZADOR
			End Get
			Set(ByVal Value As String)
				_strORGANIZADOR = Value
			End Set
		End Property

		Public Property strREFERENCIA() As String
			Get
				Return _strREFERENCIA
			End Get
			Set(ByVal Value As String)
				_strREFERENCIA = Value
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

		Public Property strRUTAAGENDA() As String
			Get
				Return _strRUTAAGENDA
			End Get
			Set(ByVal Value As String)
				_strRUTAAGENDA = Value
			End Set
		End Property

		Public Property strNUMEDICION() As String
			Get
				Return _strNUMEDICION
			End Get
			Set(ByVal Value As String)
				_strNUMEDICION = Value
			End Set
		End Property

		Public Property intTIPOPERIODO() As Integer
			Get
				Return _intTIPOPERIODO
			End Get
			Set(ByVal Value As Integer)
				_intTIPOPERIODO = Value
			End Set
        End Property

        Public Property strPERIODO() As String
            Get
                Return _strTIPOPERIODO
            End Get
            Set(ByVal Value As String)
                _strTIPOPERIODO = Value
            End Set
        End Property

		Public Property strLUGAR() As String
			Get
				Return _strLUGAR
			End Get
			Set(ByVal Value As String)
				_strLUGAR = Value
			End Set
		End Property

        Public Property dtmFECHA() As String
            Get
                Return _dtmFECHA
            End Get
            Set(ByVal Value As String)
                _dtmFECHA = Value
            End Set
        End Property

		Public Property strDESCPUBLICOGRL() As String
			Get
				Return _strDESCPUBLICOGRL
			End Get
			Set(ByVal Value As String)
				_strDESCPUBLICOGRL = Value
			End Set
		End Property

		Public Property intNUMPART() As Integer
			Get
				Return _intNUMPART
			End Get
			Set(ByVal Value As Integer)
				_intNUMPART = Value
			End Set
		End Property

		Public Property dblCOSTOPROM() As Double
			Get
				Return _dblCOSTOPROM
			End Get
			Set(ByVal Value As Double)
				_dblCOSTOPROM = Value
			End Set
		End Property

		Public Property strAUSPICIADORES() As String
			Get
				Return _strAUSPICIADORES
			End Get
			Set(ByVal Value As String)
				_strAUSPICIADORES = Value
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
		''' Metodos de la  de la entidad EVENTO
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_EVENTO
			Dim objclsBE_EVENTO As clsBE_EVENTO
			objclsBE_EVENTO = CType(Me.MemberwiseClone, clsBE_EVENTO)
			objclsBE_EVENTO.BE_SOLICITUD = CType(BE_SOLICITUD.getClone, clsBE_SOLICITUD)
			return objclsBE_EVENTO
		End Function
#End Region

	End Class
End Namespace


