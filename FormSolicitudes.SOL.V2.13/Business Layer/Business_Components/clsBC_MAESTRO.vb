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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla MAESTRO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_MAESTROTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCMAESTROTX As clsDALC_MAESTROTX
		Public oBEMAESTRO As clsBE_MAESTRO
		Public LstMAESTRO As New List(Of clsBE_MAESTRO)
		
		Sub New()
			oDALCMAESTROTX = New clsDALC_MAESTROTX
			oBEMAESTRO = New clsBE_MAESTRO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEMAESTRO = New clsBE_MAESTRO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarMAESTRO() As Boolean
			Try
				Return oDALCMAESTROTX.InsertarMAESTRO(LstMAESTRO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarMAESTRO() As Boolean
			Try
				Return oDALCMAESTROTX.EliminarMAESTRO(LstMAESTRO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarMAESTRO() As Boolean
			Try
				Return oDALCMAESTROTX.ModificarMAESTRO(LstMAESTRO)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla MAESTRO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_MAESTRORO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCMAESTRORO As clsDALC_MAESTRORO
		Public oBEMAESTRO As clsBE_MAESTRO
		Public LstMAESTRO As New List(Of clsBE_MAESTRO)
		Public oDTMAESTRO As New DataTable
		
		Sub New()
			oDALCMAESTRORO = New clsDALC_MAESTRORO
			oBEMAESTRO = New clsBE_MAESTRO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEMAESTRO = New clsBE_MAESTRO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: MAESTRO filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerMAESTRO
			Try
				oBEMAESTRO = oDALCMAESTRORO.LeerMAESTRO(oBEMAESTRO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaMAESTRO()
			Try
				LstMAESTRO = oDALCMAESTRORO.LeerListaMAESTRO()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaMAESTRO_Paged()
			Try
				LstMAESTRO = oDALCMAESTRORO.LeerListaMAESTRO_Paged(oBEMAESTRO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTMAESTRO() As Datatable
			Try
				oDTMAESTRO = oDALCMAESTRORO.LeerListaToDTMAESTRO()
				Return oDTMAESTRO
			Catch ex As Exception
				Throw ex
			End Try
		End Function 
		
	End Class
#End Region
End Namespace


