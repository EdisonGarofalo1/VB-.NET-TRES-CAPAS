Public Class cls_CE_usuarios
    Dim _usu_id As Integer
    Dim _per_Id As Integer
    Dim _usu_cedula As String
    Dim _usu_nombres As String
    Dim _usu_apellidos As String
    Dim _usu_direccion As String
    Dim _usu_telefono As String
    Dim _usu_email As String
    Dim _usu_usuario As String
    Dim _usu_clave As String
    Dim _usu_foto As Byte()
    Dim _usu_estado As Char

    Public Property Usu_id As Integer
        Get
            Return _usu_id
        End Get
        Set(value As Integer)
            _usu_id = value
        End Set
    End Property

    Public Property Per_Id As Integer
        Get
            Return _per_Id
        End Get
        Set(value As Integer)
            _per_Id = value
        End Set
    End Property

    Public Property Usu_cedula As String
        Get
            Return _usu_cedula
        End Get
        Set(value As String)
            _usu_cedula = value
        End Set
    End Property

    Public Property Usu_nombres As String
        Get
            Return _usu_nombres
        End Get
        Set(value As String)
            _usu_nombres = value
        End Set
    End Property

    Public Property Usu_apellidos As String
        Get
            Return _usu_apellidos
        End Get
        Set(value As String)
            _usu_apellidos = value
        End Set
    End Property

    Public Property Usu_direccion As String
        Get
            Return _usu_direccion
        End Get
        Set(value As String)
            _usu_direccion = value
        End Set
    End Property

    Public Property Usu_telefono As String
        Get
            Return _usu_telefono
        End Get
        Set(value As String)
            _usu_telefono = value
        End Set
    End Property

    Public Property Usu_email As String
        Get
            Return _usu_email
        End Get
        Set(value As String)
            _usu_email = value
        End Set
    End Property

    Public Property Usu_usuario As String
        Get
            Return _usu_usuario
        End Get
        Set(value As String)
            _usu_usuario = value
        End Set
    End Property

    Public Property Usu_clave As String
        Get
            Return _usu_clave
        End Get
        Set(value As String)
            _usu_clave = value
        End Set
    End Property

    Public Property Usu_foto As Byte()
        Get
            Return _usu_foto
        End Get
        Set(value As Byte())
            _usu_foto = value
        End Set
    End Property

    Public Property Usu_estado As Char
        Get
            Return _usu_estado
        End Get
        Set(value As Char)
            _usu_estado = value
        End Set
    End Property
End Class
