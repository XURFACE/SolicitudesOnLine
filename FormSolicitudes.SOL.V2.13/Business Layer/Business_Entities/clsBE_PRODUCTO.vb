Namespace MP.DW.BL.BE
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion:23/12/2011
	''' Proposito: Representa la entidad PRODUCTO
	''' Fecha Modificacion:
	''' </summary>
	'''

	<Serializable()> _
	Public Class clsBE_PRODUCTO
		Inherits clsBE_BASE

		''' <summary>
		''' Miembros privados de la entidad PRODUCTO
		''' </summary>
		''' <remarks></remarks>
#Region "Declaracion de Miembros" 
		Private _intItem As Integer
		Private _lngID As Long
		Private _lngIDSOLICITUD As Long
		Private _strMARCA As String
		Private _strNOMBRE As String
		Private _dblPORC_FABRICACION As Double
		Private _dblPORC_UNIDVENC As Double
		Private _dblPORC_VALORVENTA As Double
        Private _strRUTAREFERENCIAS As String
        Private _strRUTAREGISTROINDECOPI As String
		Private _BE_SOLICITUD As New clsBE_SOLICITUD
#End Region

		''' <summary>
		''' Propiedades de la entidad PRODUCTO
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

		Public Property strMARCA() As String
			Get
				Return _strMARCA
			End Get
			Set(ByVal Value As String)
				_strMARCA = Value
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

		Public Property dblPORC_FABRICACION() As Double
			Get
				Return _dblPORC_FABRICACION
			End Get
			Set(ByVal Value As Double)
				_dblPORC_FABRICACION = Value
			End Set
		End Property

		Public Property dblPORC_UNIDVENC() As Double
			Get
				Return _dblPORC_UNIDVENC
			End Get
			Set(ByVal Value As Double)
				_dblPORC_UNIDVENC = Value
			End Set
		End Property

		Public Property dblPORC_VALORVENTA() As Double
			Get
				Return _dblPORC_VALORVENTA
			End Get
			Set(ByVal Value As Double)
				_dblPORC_VALORVENTA = Value
			End Set
		End Property

		Public Property strRUTAREFERENCIAS() As String
			Get
				Return _strRUTAREFERENCIAS
			End Get
			Set(ByVal Value As String)
				_strRUTAREFERENCIAS = Value
			End Set
        End Property

        Public Property strRUTAREGISTROINDECOPI() As String
            Get
                Return _strRUTAREGISTROINDECOPI
            End Get
            Set(ByVal Value As String)
                _strRUTAREGISTROINDECOPI = Value
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
		''' Metodos de la  de la entidad PRODUCTO
		''' </summary>
#Region "Declaracion de Metodos" 
		Public Function getClone() As clsBE_PRODUCTO
			Dim objclsBE_PRODUCTO As clsBE_PRODUCTO
			objclsBE_PRODUCTO = CType(Me.MemberwiseClone, clsBE_PRODUCTO)
			objclsBE_PRODUCTO.BE_SOLICITUD = CType(BE_SOLICITUD.getClone, clsBE_SOLICITUD)
			return objclsBE_PRODUCTO
		End Function
#End Region

	End Class
End Namespace


