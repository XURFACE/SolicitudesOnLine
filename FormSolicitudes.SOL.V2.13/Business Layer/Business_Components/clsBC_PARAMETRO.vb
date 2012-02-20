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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla PARAMETRO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_PARAMETROTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCPARAMETROTX As clsDALC_PARAMETROTX
		Public oBEPARAMETRO As clsBE_PARAMETRO
		Public LstPARAMETRO As New List(Of clsBE_PARAMETRO)
		
		Sub New()
			oDALCPARAMETROTX = New clsDALC_PARAMETROTX
			oBEPARAMETRO = New clsBE_PARAMETRO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEPARAMETRO = New clsBE_PARAMETRO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarPARAMETRO() As Boolean
			Try
				Return oDALCPARAMETROTX.InsertarPARAMETRO(LstPARAMETRO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarPARAMETRO() As Boolean
			Try
				Return oDALCPARAMETROTX.EliminarPARAMETRO(LstPARAMETRO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarPARAMETRO() As Boolean
			Try
				Return oDALCPARAMETROTX.ModificarPARAMETRO(LstPARAMETRO)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla PARAMETRO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_PARAMETRORO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCPARAMETRORO As clsDALC_PARAMETRORO
		Public oBEPARAMETRO As clsBE_PARAMETRO
		Public LstPARAMETRO As New List(Of clsBE_PARAMETRO)
		Public oDTPARAMETRO As New DataTable
		
		Sub New()
			oDALCPARAMETRORO = New clsDALC_PARAMETRORO
			oBEPARAMETRO = New clsBE_PARAMETRO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEPARAMETRO = New clsBE_PARAMETRO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: PARAMETRO filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerPARAMETRO
			Try
				oBEPARAMETRO = oDALCPARAMETRORO.LeerPARAMETRO(oBEPARAMETRO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaPARAMETRO()
			Try
				LstPARAMETRO = oDALCPARAMETRORO.LeerListaPARAMETRO()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaPARAMETRO_Paged()
			Try
				LstPARAMETRO = oDALCPARAMETRORO.LeerListaPARAMETRO_Paged(oBEPARAMETRO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTPARAMETRO() As Datatable
			Try
				oDTPARAMETRO = oDALCPARAMETRORO.LeerListaToDTPARAMETRO()
				Return oDTPARAMETRO
			Catch ex As Exception
				Throw ex
			End Try
		End Function 
		
	End Class
#End Region
End Namespace


