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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla PRODUCTO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_PRODUCTOTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCPRODUCTOTX As clsDALC_PRODUCTOTX
		Public oBEPRODUCTO As clsBE_PRODUCTO
		Public LstPRODUCTO As New List(Of clsBE_PRODUCTO)
		
		Sub New()
			oDALCPRODUCTOTX = New clsDALC_PRODUCTOTX
			oBEPRODUCTO = New clsBE_PRODUCTO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEPRODUCTO = New clsBE_PRODUCTO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarPRODUCTO() As Boolean
			Try
				Return oDALCPRODUCTOTX.InsertarPRODUCTO(LstPRODUCTO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarPRODUCTO() As Boolean
			Try
				Return oDALCPRODUCTOTX.EliminarPRODUCTO(LstPRODUCTO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarPRODUCTO() As Boolean
			Try
				Return oDALCPRODUCTOTX.ModificarPRODUCTO(LstPRODUCTO)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla PRODUCTO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_PRODUCTORO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCPRODUCTORO As clsDALC_PRODUCTORO
		Public oBEPRODUCTO As clsBE_PRODUCTO
		Public LstPRODUCTO As New List(Of clsBE_PRODUCTO)
		Public oDTPRODUCTO As New DataTable
		
		Sub New()
			oDALCPRODUCTORO = New clsDALC_PRODUCTORO
			oBEPRODUCTO = New clsBE_PRODUCTO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEPRODUCTO = New clsBE_PRODUCTO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: PRODUCTO filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerPRODUCTO
			Try
				oBEPRODUCTO = oDALCPRODUCTORO.LeerPRODUCTO(oBEPRODUCTO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaPRODUCTO()
			Try
				LstPRODUCTO = oDALCPRODUCTORO.LeerListaPRODUCTO()
			Catch ex As Exception
				Throw ex
			End Try
        End Sub
        Public Sub LeerListaPRODUCTOSOL(ByVal idSol As Int64)
            Try
                LstPRODUCTO = oDALCPRODUCTORO.LeerListaPRODUCTOSOL(idSol)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaPRODUCTO_Paged()
			Try
				LstPRODUCTO = oDALCPRODUCTORO.LeerListaPRODUCTO_Paged(oBEPRODUCTO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTPRODUCTO() As Datatable
			Try
				oDTPRODUCTO = oDALCPRODUCTORO.LeerListaToDTPRODUCTO()
				Return oDTPRODUCTO
			Catch ex As Exception
				Throw ex
			End Try
        End Function
        Public Function LeerListaToDTPRODUCTOSOL(ByVal idSol As Int64) As DataTable
            Try
                oDTPRODUCTO = oDALCPRODUCTORO.LeerListaToDTPRODUCTOSOL(idSol)
                Return oDTPRODUCTO
            Catch ex As Exception
                Throw ex
            End Try
        End Function
		
	End Class
#End Region
End Namespace


