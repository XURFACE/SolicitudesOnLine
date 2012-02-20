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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla APLICACION
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_APLICACIONTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCAPLICACIONTX As clsDALC_APLICACIONTX
		Public oBEAPLICACION As clsBE_APLICACION
		Public LstAPLICACION As New List(Of clsBE_APLICACION)
		
		Sub New()
			oDALCAPLICACIONTX = New clsDALC_APLICACIONTX
			oBEAPLICACION = New clsBE_APLICACION
		End Sub
		
		Public Sub NuevaEntidad()
			oBEAPLICACION = New clsBE_APLICACION
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarAPLICACION() As Boolean
			Try
				Return oDALCAPLICACIONTX.InsertarAPLICACION(LstAPLICACION)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarAPLICACION() As Boolean
			Try
				Return oDALCAPLICACIONTX.EliminarAPLICACION(LstAPLICACION)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarAPLICACION() As Boolean
			Try
				Return oDALCAPLICACIONTX.ModificarAPLICACION(LstAPLICACION)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla APLICACION
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_APLICACIONRO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCAPLICACIONRO As clsDALC_APLICACIONRO
		Public oBEAPLICACION As clsBE_APLICACION
		Public LstAPLICACION As New List(Of clsBE_APLICACION)
		Public oDTAPLICACION As New DataTable
		
		Sub New()
			oDALCAPLICACIONRO = New clsDALC_APLICACIONRO
			oBEAPLICACION = New clsBE_APLICACION
		End Sub
		
		Public Sub NuevaEntidad()
			oBEAPLICACION = New clsBE_APLICACION
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: APLICACION filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerAPLICACION
			Try
				oBEAPLICACION = oDALCAPLICACIONRO.LeerAPLICACION(oBEAPLICACION)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaAPLICACION()
			Try
				LstAPLICACION = oDALCAPLICACIONRO.LeerListaAPLICACION()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaAPLICACION_Paged()
			Try
				LstAPLICACION = oDALCAPLICACIONRO.LeerListaAPLICACION_Paged(oBEAPLICACION)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTAPLICACION() As Datatable
			Try
				oDTAPLICACION = oDALCAPLICACIONRO.LeerListaToDTAPLICACION()
				Return oDTAPLICACION
			Catch ex As Exception
				Throw ex
			End Try
        End Function

        Public Function LeerListaToDTAAPLICACIONBYSOL(ByVal idsol As Int64) As DataTable
            Try
                oDTAPLICACION = oDALCAPLICACIONRO.LeerListaToDTAAPLICACIONBYSOL(idsol)
                Return oDTAPLICACION
            Catch ex As Exception
                Throw ex
            End Try
        End Function
		
	End Class
#End Region
End Namespace


