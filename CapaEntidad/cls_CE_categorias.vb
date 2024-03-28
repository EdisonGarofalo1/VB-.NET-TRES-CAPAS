Public Class cls_CE_categorias
    Dim _CAT_ID As Integer
    Dim _CAT_DESCRIPCION As String
    Dim _CAT_ESTADO As String

    Public Property CAT_ID As Integer
        Get
            Return _CAT_ID
        End Get
        Set(value As Integer)
            _CAT_ID = value
        End Set
    End Property

    Public Property CAT_DESCRIPCION As String
        Get
            Return _CAT_DESCRIPCION
        End Get
        Set(value As String)
            _CAT_DESCRIPCION = value
        End Set
    End Property

    Public Property CAT_ESTADO As String
        Get
            Return _CAT_ESTADO
        End Get
        Set(value As String)
            _CAT_ESTADO = value
        End Set
    End Property
End Class
