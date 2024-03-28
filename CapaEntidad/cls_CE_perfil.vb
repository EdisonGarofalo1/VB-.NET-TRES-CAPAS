Public Class cls_CE_perfil
    Dim _per_Id As Integer
    Dim _per_Nombre As String
    Dim _per_Descripcion As String
    Dim _per_estado As String

    Public Property Per_Id As Integer
        Get
            Return _per_Id
        End Get
        Set(value As Integer)
            _per_Id = value
        End Set
    End Property

    Public Property Per_Nombre As String
        Get
            Return _per_Nombre
        End Get
        Set(value As String)
            _per_Nombre = value
        End Set
    End Property

    Public Property Per_Descripcion As String
        Get
            Return _per_Descripcion
        End Get
        Set(value As String)
            _per_Descripcion = value
        End Set
    End Property

    Public Property Per_estado As String
        Get
            Return _per_estado
        End Get
        Set(value As String)
            _per_estado = value
        End Set
    End Property
End Class
