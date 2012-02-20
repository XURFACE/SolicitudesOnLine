Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad CLIENT_USER
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_CLIENT_USER
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad CLIENT_USER
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _lngID As Long
		Private _strLOGINUSR As String
		Private _strPWDUSR As String
		Private _strNOMUSR As String
		Private _strAPUSR As String
		Private _strAMUSR As String
		Private _strMAILUSR As String
		Private _dtmFECHAREG As Nullable(Of DateTime)
		Private _intESTADOUSR As Integer
        Private _strCODVERIFICACION As String
        Private _strEXPEDIENTES As String
#End Region

		''' <summary>
		''' Propiedades de la entidad CLIENT_USER
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

		Public Property strLOGINUSR() As String
			Get
				Return _strLOGINUSR
			End Get
			Set(ByVal Value As String)
				_strLOGINUSR = Value
			End Set
		End Property

		Public Property strPWDUSR() As String
			Get
				Return _strPWDUSR
			End Get
			Set(ByVal Value As String)
				_strPWDUSR = Value
			End Set
		End Property

		Public Property strNOMUSR() As String
			Get
				Return _strNOMUSR
			End Get
			Set(ByVal Value As String)
				_strNOMUSR = Value
			End Set
		End Property

		Public Property strAPUSR() As String
			Get
				Return _strAPUSR
			End Get
			Set(ByVal Value As String)
				_strAPUSR = Value
			End Set
		End Property

		Public Property strAMUSR() As String
			Get
				Return _strAMUSR
			End Get
			Set(ByVal Value As String)
				_strAMUSR = Value
			End Set
		End Property

		Public Property strMAILUSR() As String
			Get
				Return _strMAILUSR
			End Get
			Set(ByVal Value As String)
				_strMAILUSR = Value
			End Set
		End Property

		Public Property dtmFECHAREG() As Nullable(Of DateTime)
			Get
				Return _dtmFECHAREG
			End Get
			Set(ByVal Value As  Nullable(Of DateTime))
				_dtmFECHAREG = Value
			End Set
		End Property

		Public Property intESTADOUSR() As Integer
			Get
				Return _intESTADOUSR
			End Get
			Set(ByVal Value As Integer)
				_intESTADOUSR = Value
			End Set
		End Property

		Public Property strCODVERIFICACION() As String
			Get
				Return _strCODVERIFICACION
			End Get
			Set(ByVal Value As String)
				_strCODVERIFICACION = Value
			End Set
        End Property

        Public Property strEXPEDIENTES() As String
            Get
                Return _strEXPEDIENTES
            End Get
            Set(ByVal Value As String)
                _strEXPEDIENTES = Value
            End Set
        End Property

#End Region

		''' <summary>
		''' Metodos de la  de la entidad CLIENT_USER
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_CLIENT_USER
			Return CType(Me.MemberwiseClone, clsBE_CLIENT_USER)
		End Function
#End Region

	End Class
End Namespace


