Namespace MP.DW.BL.BE
    ''' <summary>
    ''' Escrito por: Alejandro Mayta C.
    ''' Fecha Creacion:23/12/2011
    ''' Proposito: Representa la entidad EMPRESA
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    <Serializable()> _
    Public Class clsBE_EMPRESA
        Inherits clsBE_BASE

        ''' <summary>
        ''' Miembros privados de la entidad EMPRESA
        ''' </summary>
        ''' <remarks></remarks>
#Region "Declaracion de Miembros"
        Private _intItem As Integer
        Private _lngID As Long
        Private _lngIDUSUARIO As Long
        Private _strRAZONSOCIAL As String = ""
        Private _strREPRESENTANTE As String = ""
        Private _strCARGO As String = ""
        Private _strCARGOREPRESENTANTE As String = ""
        Private _strDNI As String = ""
        Private _strRUTADNI As String = ""
        Private _strRUC As String = ""
        Private _strRUTARUC As String = ""
        Private _strRUTAVIGPODER As String = ""
        Private _strGIRO As String = ""
        Private _strDET_GIRO As String = ""
        Private _strWEB As String = ""
        Private _strDOMICILIO As String = ""
        Private _strNUMPARTIDA As String = ""
        Private _strNUMTEL As String = ""
        Private _strEMAIL As String = ""
        Private _strNOMPERCONTACTO As String = ""
        Private _strMSGORG As String = ""
        Private _strREFERENCIAS As String = ""
        Private _strCOMPROMISO As String = ""
        Private _strNOMBREPROGRAMASOCIAL As String = ""
        Private _strDET_PROGRAMASOCIAL As String = ""
        Private _strRUTALICENCIA As String = ""
        Private _strCOD_DPTO As String = ""
        Private _strCOD_PROV As String = ""
        Private _strCOD_DIST As String = ""
        Private _strOBJETIVO As String = ""
        Private _strOBJ_PORQUE As String = ""
        Private _strTIPOEMPRESA As String = ""
        Private _dblMONTODEUDA As String = ""
        Private _strCIUDAD As String = ""
        Private _strPAIS As String = ""
        Private _strNROEXPEDIENTE As String = ""
        Private _strTIPODOCUMENTO As String = ""
        Private _BE_CLIENT_USER As New clsBE_CLIENT_USER
        Private _strNOMBREPROV As String = ""
        Private _strNOMBREDPTO As String = ""
        Private _strNOMBREDIST As String = ""
        Private _strRENOVACION As String = ""
#End Region

        ''' <summary>
        ''' Propiedades de la entidad EMPRESA
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

        Public Property lngIDUSUARIO() As Long
            Get
                Return _lngIDUSUARIO
            End Get
            Set(ByVal Value As Long)
                _lngIDUSUARIO = Value
            End Set
        End Property

        Public Property strRAZONSOCIAL() As String
            Get
                Return _strRAZONSOCIAL
            End Get
            Set(ByVal Value As String)
                _strRAZONSOCIAL = Value
            End Set
        End Property

        Public Property strREPRESENTANTE() As String
            Get
                Return _strREPRESENTANTE
            End Get
            Set(ByVal Value As String)
                _strREPRESENTANTE = Value
            End Set
        End Property

        Public Property strCARGO() As String
            Get
                Return _strCARGO
            End Get
            Set(ByVal Value As String)
                _strCARGO = Value
            End Set
        End Property

        Public Property strCARGOREPRESENTANTE() As String
            Get
                Return _strCARGOREPRESENTANTE
            End Get
            Set(ByVal Value As String)
                _strCARGOREPRESENTANTE = Value
            End Set
        End Property

        Public Property strDNI() As String
            Get
                Return _strDNI
            End Get
            Set(ByVal Value As String)
                _strDNI = Value
            End Set
        End Property

        Public Property strRUTADNI() As String
            Get
                Return _strRUTADNI
            End Get
            Set(ByVal Value As String)
                _strRUTADNI = Value
            End Set
        End Property

        Public Property strRUC() As String
            Get
                Return _strRUC
            End Get
            Set(ByVal Value As String)
                _strRUC = Value
            End Set
        End Property

        Public Property strRUTARUC() As String
            Get
                Return _strRUTARUC
            End Get
            Set(ByVal Value As String)
                _strRUTARUC = Value
            End Set
        End Property

        Public Property strRUTAVIGPODER() As String
            Get
                Return _strRUTAVIGPODER
            End Get
            Set(ByVal Value As String)
                _strRUTAVIGPODER = Value
            End Set
        End Property

        Public Property strGIRO() As String
            Get
                Return _strGIRO
            End Get
            Set(ByVal Value As String)
                _strGIRO = Value
            End Set
        End Property

        Public Property strDET_GIRO() As String
            Get
                Return _strDET_GIRO
            End Get
            Set(ByVal Value As String)
                _strDET_GIRO = Value
            End Set
        End Property

        Public Property strWEB() As String
            Get
                Return _strWEB
            End Get
            Set(ByVal Value As String)
                _strWEB = Value
            End Set
        End Property

        Public Property strDOMICILIO() As String
            Get
                Return _strDOMICILIO
            End Get
            Set(ByVal Value As String)
                _strDOMICILIO = Value
            End Set
        End Property

        Public Property strNUMPARTIDA() As String
            Get
                Return _strNUMPARTIDA
            End Get
            Set(ByVal Value As String)
                _strNUMPARTIDA = Value
            End Set
        End Property

        Public Property strNUMTEL() As String
            Get
                Return _strNUMTEL
            End Get
            Set(ByVal Value As String)
                _strNUMTEL = Value
            End Set
        End Property

        Public Property strEMAIL() As String
            Get
                Return _strEMAIL
            End Get
            Set(ByVal Value As String)
                _strEMAIL = Value
            End Set
        End Property

        Public Property strNOMPERCONTACTO() As String
            Get
                Return _strNOMPERCONTACTO
            End Get
            Set(ByVal Value As String)
                _strNOMPERCONTACTO = Value
            End Set
        End Property

        Public Property strMSGORG() As String
            Get
                Return _strMSGORG
            End Get
            Set(ByVal Value As String)
                _strMSGORG = Value
            End Set
        End Property

        Public Property strREFERENCIAS() As String
            Get
                Return _strREFERENCIAS
            End Get
            Set(ByVal Value As String)
                _strREFERENCIAS = Value
            End Set
        End Property

        Public Property strCOMPROMISO() As String
            Get
                Return _strCOMPROMISO
            End Get
            Set(ByVal Value As String)
                _strCOMPROMISO = Value
            End Set
        End Property

        Public Property strNOMBREPROGRAMASOCIAL() As String
            Get
                Return _strNOMBREPROGRAMASOCIAL
            End Get
            Set(ByVal Value As String)
                _strNOMBREPROGRAMASOCIAL = Value
            End Set
        End Property

        Public Property strDET_PROGRAMASOCIAL() As String
            Get
                Return _strDET_PROGRAMASOCIAL
            End Get
            Set(ByVal Value As String)
                _strDET_PROGRAMASOCIAL = Value
            End Set
        End Property

        Public Property strRUTALICENCIA() As String
            Get
                Return _strRUTALICENCIA
            End Get
            Set(ByVal Value As String)
                _strRUTALICENCIA = Value
            End Set
        End Property

        Public Property strCOD_DPTO() As String
            Get
                Return _strCOD_DPTO
            End Get
            Set(ByVal Value As String)
                _strCOD_DPTO = Value
            End Set
        End Property

        Public Property strCOD_PROV() As String
            Get
                Return _strCOD_PROV
            End Get
            Set(ByVal Value As String)
                _strCOD_PROV = Value
            End Set
        End Property

        Public Property strCOD_DIST() As String
            Get
                Return _strCOD_DIST
            End Get
            Set(ByVal Value As String)
                _strCOD_DIST = Value
            End Set
        End Property

        Public Property strOBJETIVO() As String
            Get
                Return _strOBJETIVO
            End Get
            Set(ByVal Value As String)
                _strOBJETIVO = Value
            End Set
        End Property

        Public Property strOBJ_PORQUE() As String
            Get
                Return _strOBJ_PORQUE
            End Get
            Set(ByVal Value As String)
                _strOBJ_PORQUE = Value
            End Set
        End Property


        Public Property strTIPOEMPRESA() As String
            Get
                Return _strTIPOEMPRESA
            End Get
            Set(ByVal Value As String)
                _strTIPOEMPRESA = Value
            End Set
        End Property
        Public Property dblMONTODEUDA() As Double
            Get
                Return _dblMONTODEUDA
            End Get
            Set(ByVal value As Double)
                _dblMONTODEUDA = value
            End Set
        End Property
        Public Property strCIUDAD() As String
            Get
                Return _strCIUDAD
            End Get
            Set(ByVal Value As String)
                _strCIUDAD = Value
            End Set
        End Property
        Public Property strPAIS() As String
            Get
                Return _strPAIS
            End Get
            Set(ByVal Value As String)
                _strPAIS = Value
            End Set
        End Property
        Public Property strNROEXPEDIENTE() As String
            Get
                Return _strNROEXPEDIENTE
            End Get
            Set(ByVal Value As String)
                _strNROEXPEDIENTE = Value
            End Set
        End Property

        Public Property strTIPODOCUMENTO() As String
            Get
                Return _strTIPODOCUMENTO
            End Get
            Set(ByVal Value As String)
                _strTIPODOCUMENTO = Value
            End Set
        End Property

        Public Property BE_CLIENT_USER() As clsBE_CLIENT_USER
            Get
                Return _BE_CLIENT_USER
            End Get
            Set(ByVal Value As clsBE_CLIENT_USER)
                _BE_CLIENT_USER = Value
            End Set
        End Property


        Public Property strNOMBREPROV() As String
            Get
                Return _strNOMBREPROV
            End Get
            Set(ByVal Value As String)
                _strNOMBREPROV = Value
            End Set
        End Property
        Public Property strNOMBREDPTO() As String
            Get
                Return _strNOMBREDPTO
            End Get
            Set(ByVal Value As String)
                _strNOMBREDPTO = Value
            End Set
        End Property
        Public Property strNOMBREDIST() As String
            Get
                Return _strNOMBREDIST
            End Get
            Set(ByVal Value As String)
                _strNOMBREDIST = Value
            End Set
        End Property

        Public Property strRENOVACION() As String
            Get
                Return _strRENOVACION
            End Get
            Set(ByVal Value As String)
                _strRENOVACION = Value
            End Set
        End Property
#End Region

        ''' <summary>
        ''' Metodos de la  de la entidad EMPRESA
        ''' </summary>
#Region "Declaracion de Metodos"
        Public Function getClone() As clsBE_EMPRESA
            Dim objclsBE_EMPRESA As clsBE_EMPRESA
            objclsBE_EMPRESA = CType(Me.MemberwiseClone, clsBE_EMPRESA)
            objclsBE_EMPRESA.BE_CLIENT_USER = CType(BE_CLIENT_USER.getClone, clsBE_CLIENT_USER)
            Return objclsBE_EMPRESA
        End Function
#End Region

    End Class
End Namespace


