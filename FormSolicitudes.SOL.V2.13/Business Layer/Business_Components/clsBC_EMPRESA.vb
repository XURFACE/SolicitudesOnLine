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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla EMPRESA
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_EMPRESATX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCEMPRESATX As clsDALC_EMPRESATX
		Public oBEEMPRESA As clsBE_EMPRESA
		Public LstEMPRESA As New List(Of clsBE_EMPRESA)
		
		Sub New()
			oDALCEMPRESATX = New clsDALC_EMPRESATX
			oBEEMPRESA = New clsBE_EMPRESA
		End Sub
		
		Public Sub NuevaEntidad()
			oBEEMPRESA = New clsBE_EMPRESA
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarEMPRESA() As Boolean
			Try
				Return oDALCEMPRESATX.InsertarEMPRESA(LstEMPRESA)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarEMPRESA() As Boolean
			Try
				Return oDALCEMPRESATX.EliminarEMPRESA(LstEMPRESA)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarEMPRESA() As Boolean
			Try
				Return oDALCEMPRESATX.ModificarEMPRESA(LstEMPRESA)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla EMPRESA
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_EMPRESARO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCEMPRESARO As clsDALC_EMPRESARO
		Public oBEEMPRESA As clsBE_EMPRESA
		Public LstEMPRESA As New List(Of clsBE_EMPRESA)
		Public oDTEMPRESA As New DataTable
		
		Sub New()
			oDALCEMPRESARO = New clsDALC_EMPRESARO
			oBEEMPRESA = New clsBE_EMPRESA
		End Sub
		
		Public Sub NuevaEntidad()
			oBEEMPRESA = New clsBE_EMPRESA
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: EMPRESA filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerEMPRESA
			Try
                oBEEMPRESA = oDALCEMPRESARO.LeerEMPRESA(oBEEMPRESA)
			Catch ex As Exception
				Throw ex
			End Try
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Obtiene un campo de la entidad: EMPRESA filtrada por el ID o Codigo de la misma.
        ''' Fecha Modificacion: 
        ''' </summary> 

        Public Sub LeerEMPRESA(ByVal xstrRUC As String, ByVal idUsuario As Long, ByVal xstrTipoPersona As String)
            Try
                oBEEMPRESA = Nothing
                oBEEMPRESA = oDALCEMPRESARO.LeerEMPRESA(xstrRUC, idUsuario, xstrTipoPersona)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaEMPRESA()
			Try
				LstEMPRESA = oDALCEMPRESARO.LeerListaEMPRESA()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaEMPRESA_Paged()
			Try
				LstEMPRESA = oDALCEMPRESARO.LeerListaEMPRESA_Paged(oBEEMPRESA)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTEMPRESA() As Datatable
			Try
				oDTEMPRESA = oDALCEMPRESARO.LeerListaToDTEMPRESA()
				Return oDTEMPRESA
			Catch ex As Exception
				Throw ex
			End Try
        End Function

        Public Function LeerListaToEMPRESABYCLIENTUSER(ByVal lngIDClient As Long)
            Try
                oDTEMPRESA = oDALCEMPRESARO.LeerListaToEMPRESABYCLIENTUSER(lngIDClient)
                Return oDTEMPRESA
            Catch ex As Exception
                Throw ex
            End Try
        End Function


    End Class
#End Region
End Namespace


