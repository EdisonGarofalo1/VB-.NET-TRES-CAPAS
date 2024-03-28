Public Class cls_CE_clientes
    Dim _PER_ID As Integer
    Dim _PER_IDENTIFICACION As String
    Dim _CP_SEXO As Integer
    Dim _CP_ESTADO_CIVIL As Integer
    Dim _PER_NOMBRES As String
    Dim _PER_TELEFONO As String
    Dim _PER_DIRECCION As String
    Dim _PER_ESTADO As String

    Public Property PER_ID As Integer
        Get
            Return _PER_ID
        End Get
        Set(value As Integer)
            _PER_ID = value
        End Set
    End Property

    Public Property PER_IDENTIFICACION As String
        Get
            Return _PER_IDENTIFICACION
        End Get
        Set(value As String)
            _PER_IDENTIFICACION = value
        End Set
    End Property

    Public Property CP_SEXO As Integer
        Get
            Return _CP_SEXO
        End Get
        Set(value As Integer)
            _CP_SEXO = value
        End Set
    End Property

    Public Property CP_ESTADO_CIVIL As Integer
        Get
            Return _CP_ESTADO_CIVIL
        End Get
        Set(value As Integer)
            _CP_ESTADO_CIVIL = value
        End Set
    End Property

    Public Property PER_NOMBRES As String
        Get
            Return _PER_NOMBRES
        End Get
        Set(value As String)
            _PER_NOMBRES = value
        End Set
    End Property

    Public Property PER_TELEFONO As String
        Get
            Return _PER_TELEFONO
        End Get
        Set(value As String)
            _PER_TELEFONO = value
        End Set
    End Property

    Public Property PER_DIRECCION As String
        Get
            Return _PER_DIRECCION
        End Get
        Set(value As String)
            _PER_DIRECCION = value
        End Set
    End Property

    Public Property PER_ESTADO As String
        Get
            Return _PER_ESTADO
        End Get
        Set(value As String)
            _PER_ESTADO = value
        End Set
    End Property
End Class
