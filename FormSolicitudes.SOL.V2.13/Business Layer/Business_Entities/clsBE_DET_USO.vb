Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad DET_USO
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_DET_USO
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad DET_USO
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _lngID As Long
		Private _lngIDSOLICITUD As Long
		Private _strTIPOLIC As String
        Private _intSUBTIPO As String
		Private _strDESCRIPCION As String
		Private _BE_SOLICITUD As New clsBE_SOLICITUD
#End Region

		''' <summary>
		''' Propiedades de la entidad DET_USO
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

		Public Property strTIPOLIC() As String
			Get
				Return _strTIPOLIC
			End Get
			Set(ByVal Value As String)
				_strTIPOLIC = Value
			End Set
		End Property

        Public Property intSUBTIPO() As String
            Get
                Return _intSUBTIPO
            End Get
            Set(ByVal Value As String)
                _intSUBTIPO = Value
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
		''' Metodos de la  de la entidad DET_USO
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_DET_USO
			Dim objclsBE_DET_USO As clsBE_DET_USO
			objclsBE_DET_USO = CType(Me.MemberwiseClone, clsBE_DET_USO)
			objclsBE_DET_USO.BE_SOLICITUD = CType(BE_SOLICITUD.getClone, clsBE_SOLICITUD)
			return objclsBE_DET_USO
		End Function
#End Region

	End Class
End Namespace


