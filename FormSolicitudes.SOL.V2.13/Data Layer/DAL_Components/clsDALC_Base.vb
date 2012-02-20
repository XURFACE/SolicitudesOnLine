Imports System.Collections.Generic
Imports Microsoft.Practices.EnterpriseLibrary.Data
Namespace MP.DW.DAL.DALC

	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion: 23/12/2011
	''' Proposito: Clase base del Layer DAL
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	Public MustInherit Class clsDALC_Base
		Protected m_database As Database

		Sub New()
			m_database = DatabaseFactory.CreateDatabase("strConnWEBPROG")
		End Sub

		Sub New(ByVal database As Database)
			m_database = database
		End Sub

		Public Property DataBase() As Database
			Get
				Return m_database
			End Get
			Set(ByVal value As Database)
				m_database = value
			End Set
		End Property

	End Class
End Namespace

