Public Class Rastro
    Private _Pasos As New Stack(Of Int32)
    Public Property PASOS() As Stack(Of Int32)
        Get
            Return _Pasos
        End Get
        Set(ByVal Value As Stack(Of Int32))
            _Pasos = Value
        End Set
    End Property
End Class
