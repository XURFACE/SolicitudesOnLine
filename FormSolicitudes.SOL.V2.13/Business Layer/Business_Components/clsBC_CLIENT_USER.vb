Imports System.Collections.ObjectModel
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data
Imports MP.DW.BL.BE
Imports MP.DW.DAL.DALC

Namespace MP.DW.BL.BC
#Region "Clase Escritura" 
	'<ComVisible(True)> _
	'<Transaction(TransactionOption.Required)> _
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion: 23/12/2011
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla CLIENT_USER
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_CLIENT_USERTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCCLIENT_USERTX As clsDALC_CLIENT_USERTX
		Public oBECLIENT_USER As clsBE_CLIENT_USER
		Public LstCLIENT_USER As New List(Of clsBE_CLIENT_USER)
		
		Sub New()
			oDALCCLIENT_USERTX = New clsDALC_CLIENT_USERTX
			oBECLIENT_USER = New clsBE_CLIENT_USER
		End Sub
		
		Public Sub NuevaEntidad()
			oBECLIENT_USER = New clsBE_CLIENT_USER
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarCLIENT_USER() As Boolean
			Try
				Return oDALCCLIENT_USERTX.InsertarCLIENT_USER(LstCLIENT_USER)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarCLIENT_USER() As Boolean
			Try
				Return oDALCCLIENT_USERTX.EliminarCLIENT_USER(LstCLIENT_USER)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarCLIENT_USER() As Boolean
			Try
				Return oDALCCLIENT_USERTX.ModificarCLIENT_USER(LstCLIENT_USER)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 07/12/2011
        ''' Proposito: Metodo de Eliminación de Datos de la Entidad: CLIENT_USER
        ''' Fecha Modificacion: 
        ''' </summary> 

        Public Function ModificarPWDCLIENT_USER() As Boolean
            Try
                Return oDALCCLIENT_USERTX.ModificarPwdCLIENT_USER(LstCLIENT_USER)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
		
	End Class
#End Region

#Region "Clase Lectura" 
	'<ComVisible(True)> _
	'<Transaction(TransactionOption.Required)> _
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion: 23/12/2011
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla CLIENT_USER
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_CLIENT_USERRO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCCLIENT_USERRO As clsDALC_CLIENT_USERRO
		Public oBECLIENT_USER As clsBE_CLIENT_USER
		Public LstCLIENT_USER As New List(Of clsBE_CLIENT_USER)
		Public oDTCLIENT_USER As New DataTable
		
		Sub New()
			oDALCCLIENT_USERRO = New clsDALC_CLIENT_USERRO
			oBECLIENT_USER = New clsBE_CLIENT_USER
		End Sub
		
		Public Sub NuevaEntidad()
			oBECLIENT_USER = New clsBE_CLIENT_USER
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: CLIENT_USER filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerCLIENT_USER
			Try
				oBECLIENT_USER = oDALCCLIENT_USERRO.LeerCLIENT_USER(oBECLIENT_USER)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaCLIENT_USER()
			Try
				LstCLIENT_USER = oDALCCLIENT_USERRO.LeerListaCLIENT_USER()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaCLIENT_USER_Paged()
			Try
				LstCLIENT_USER = oDALCCLIENT_USERRO.LeerListaCLIENT_USER_Paged(oBECLIENT_USER)
			Catch ex As Exception
				Throw ex
			End Try
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 04/11/2011
        ''' Proposito: Obtiene un campo de la entidad: USUARIO filtrada por el ID o Codigo de la misma.
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Sub LeerUSUARIOLogIn()
            Try
                oBECLIENT_USER = oDALCCLIENT_USERRO.LeerUSUARIObyLogIn(oBECLIENT_USER)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		
        Public Function LeerListaToDTCLIENT_USER(ByVal xstrName As String, ByVal xstrLoginmail As String) As DataTable
            Try
                oDTCLIENT_USER = oDALCCLIENT_USERRO.LeerListaToDTCLIENT_USER(xstrName, xstrLoginmail)
                Return oDTCLIENT_USER
            Catch ex As Exception
                Throw ex
            End Try
        End Function
		
	End Class
#End Region
End Namespace


