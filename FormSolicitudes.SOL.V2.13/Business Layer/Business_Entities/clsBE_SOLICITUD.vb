Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad SOLICITUD
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_SOLICITUD
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad SOLICITUD
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _lngID As Long
		Private _lngIDEMP As Long
		Private _strTIPOLIC As String
		Private _strRPTAUSOMARCAPAIS As String
		Private _intIDAPLICACION As Integer
        Private _strSTSSOL As String
        Private _strREFCONSULADO As String
        Private _strDECLARACIONJUR As String
        Private _strNUMLIC As String
        Private _BE_EMPRESA As New clsBE_EMPRESA
#End Region

		''' <summary>
		''' Propiedades de la entidad SOLICITUD
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

		Public Property lngIDEMP() As Long
			Get
				Return _lngIDEMP
			End Get
			Set(ByVal Value As Long)
				_lngIDEMP = Value
			End Set
		End Property

		Public Property strTIPOLIC() As String
			Get
				Return _strTIPOLIC
			End Get
			Set(ByVal Value As String)
				_strTIPOLIC = Value
			End Set
		End Property

		Public Property strRPTAUSOMARCAPAIS() As String
			Get
				Return _strRPTAUSOMARCAPAIS
			End Get
			Set(ByVal Value As String)
				_strRPTAUSOMARCAPAIS = Value
			End Set
		End Property

		Public Property intIDAPLICACION() As Integer
			Get
				Return _intIDAPLICACION
			End Get
			Set(ByVal Value As Integer)
				_intIDAPLICACION = Value
			End Set
		End Property

		Public Property strSTSSOL() As String
			Get
				Return _strSTSSOL
			End Get
			Set(ByVal Value As String)
				_strSTSSOL = Value
			End Set
        End Property

        Public Property strREFCONSULADO() As String
            Get
                Return _strREFCONSULADO
            End Get
            Set(ByVal Value As String)
                _strREFCONSULADO = Value
            End Set
        End Property

        Public Property strDECLARACIONJUR() As String
            Get
                Return _strDECLARACIONJUR
            End Get
            Set(ByVal Value As String)
                _strDECLARACIONJUR = Value
            End Set
        End Property

        Public Property strNUMLIC() As String
            Get
                Return _strNUMLIC
            End Get
            Set(ByVal Value As String)
                _strNUMLIC = Value
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
		''' Metodos de la  de la entidad SOLICITUD
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_SOLICITUD
			Dim objclsBE_SOLICITUD As clsBE_SOLICITUD
			objclsBE_SOLICITUD = CType(Me.MemberwiseClone, clsBE_SOLICITUD)
			objclsBE_SOLICITUD.BE_EMPRESA = CType(BE_EMPRESA.getClone, clsBE_EMPRESA)
			return objclsBE_SOLICITUD
		End Function
#End Region

	End Class
End Namespace


