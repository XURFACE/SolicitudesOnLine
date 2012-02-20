Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad AMBITOUSO
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_AMBITOUSO
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad AMBITOUSO
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _lngID As Long
		Private _lngIDSOLICITUD As Long
		Private _lngIDEVENTO As Long
		Private _intIDPUBLICO As Integer
        Private _intIDDETPUBLICO As Integer
        Private _strPUBLICO As String
        Private _strDETPUBLICO As String
		Private _strLISTADETALLADA As String
		Private _BE_SOLICITUD As New clsBE_SOLICITUD
#End Region

		''' <summary>
		''' Propiedades de la entidad AMBITOUSO
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

		Public Property lngIDEVENTO() As Long
			Get
				Return _lngIDEVENTO
			End Get
			Set(ByVal Value As Long)
				_lngIDEVENTO = Value
			End Set
		End Property

		Public Property intIDPUBLICO() As Integer
			Get
				Return _intIDPUBLICO
			End Get
			Set(ByVal Value As Integer)
				_intIDPUBLICO = Value
			End Set
		End Property

		Public Property intIDDETPUBLICO() As Integer
			Get
				Return _intIDDETPUBLICO
			End Get
			Set(ByVal Value As Integer)
				_intIDDETPUBLICO = Value
			End Set
        End Property

        Public Property strPUBLICO() As String
            Get
                Return _strPUBLICO
            End Get
            Set(ByVal Value As String)
                _strPUBLICO = Value
            End Set
        End Property

        Public Property strDETPUBLICO() As String
            Get
                Return _strDETPUBLICO
            End Get
            Set(ByVal Value As String)
                _strDETPUBLICO = Value
            End Set
        End Property

		Public Property strLISTADETALLADA() As String
			Get
				Return _strLISTADETALLADA
			End Get
			Set(ByVal Value As String)
				_strLISTADETALLADA = Value
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
		''' Metodos de la  de la entidad AMBITOUSO
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_AMBITOUSO
			Dim objclsBE_AMBITOUSO As clsBE_AMBITOUSO
			objclsBE_AMBITOUSO = CType(Me.MemberwiseClone, clsBE_AMBITOUSO)
			objclsBE_AMBITOUSO.BE_SOLICITUD = CType(BE_SOLICITUD.getClone, clsBE_SOLICITUD)
			return objclsBE_AMBITOUSO
		End Function
#End Region

	End Class
End Namespace


