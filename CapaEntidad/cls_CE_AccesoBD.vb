Public Class cls_CE_AccesoBD
    Dim _nombre_usuario As String
    Dim _id_usuario As Integer
    Dim _perfilusuario As Integer

    Public Property Nombre_usuario As String
        Get
            Return _nombre_usuario
        End Get
        Set(value As String)
            _nombre_usuario = value
        End Set
    End Property

    Public Property Id_usuario As Integer
        Get
            Return _id_usuario
        End Get
        Set(value As Integer)
            _id_usuario = value
        End Set
    End Property

    Public Property Perfilusuario As Integer
        Get
            Return _perfilusuario
        End Get
        Set(value As Integer)
            _perfilusuario = value
        End Set
    End Property
End Class
