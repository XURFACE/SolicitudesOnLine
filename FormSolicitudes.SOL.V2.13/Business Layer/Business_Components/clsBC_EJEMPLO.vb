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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla EJEMPLO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_EJEMPLOTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_EJEMPLO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCEJEMPLOTX As clsDALC_EJEMPLOTX
		Public oBEEJEMPLO As clsBE_EJEMPLO
		Public LstEJEMPLO As New List(Of clsBE_EJEMPLO)
		
		Sub New()
			oDALCEJEMPLOTX = New clsDALC_EJEMPLOTX
			oBEEJEMPLO = New clsBE_EJEMPLO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEEJEMPLO = New clsBE_EJEMPLO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos EJEMPLO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarEJEMPLO() As Boolean
			Try
				Return oDALCEJEMPLOTX.InsertarEJEMPLO(LstEJEMPLO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: EJEMPLO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarEJEMPLO() As Boolean
			Try
				Return oDALCEJEMPLOTX.EliminarEJEMPLO(LstEJEMPLO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: EJEMPLO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarEJEMPLO() As Boolean
			Try
				Return oDALCEJEMPLOTX.ModificarEJEMPLO(LstEJEMPLO)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla EJEMPLO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_EJEMPLORO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_EJEMPLO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCEJEMPLORO As clsDALC_EJEMPLORO
		Public oBEEJEMPLO As clsBE_EJEMPLO
		Public LstEJEMPLO As New List(Of clsBE_EJEMPLO)
		Public oDTEJEMPLO As New DataTable
		
		Sub New()
			oDALCEJEMPLORO = New clsDALC_EJEMPLORO
			oBEEJEMPLO = New clsBE_EJEMPLO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEEJEMPLO = New clsBE_EJEMPLO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: EJEMPLO filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerEJEMPLO
			Try
				oBEEJEMPLO = oDALCEJEMPLORO.LeerEJEMPLO(oBEEJEMPLO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: EJEMPLO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaEJEMPLO()
			Try
				LstEJEMPLO = oDALCEJEMPLORO.LeerListaEJEMPLO()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:EJEMPLO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaEJEMPLO_Paged()
			Try
				LstEJEMPLO = oDALCEJEMPLORO.LeerListaEJEMPLO_Paged(oBEEJEMPLO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: EJEMPLO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTEJEMPLO() As Datatable
			Try
				oDTEJEMPLO = oDALCEJEMPLORO.LeerListaToDTEJEMPLO()
				Return oDTEJEMPLO
			Catch ex As Exception
				Throw ex
			End Try
		End Function 
		
	End Class
#End Region
End Namespace


