Public Class cls_CE_producto
    Dim _PRO_ID As Integer
    Dim _CAT_ID As Integer
    Dim _PRO_CODIGO As String
    Dim _PRO_DESCRIPCION As String
    Dim _PRO_PRECIO As Double
    Dim _PRO_LLEVA_IVA As Boolean
    Dim _PRO_ESTADO As String

    Public Property PRO_ID As Integer
        Get
            Return _PRO_ID
        End Get
        Set(value As Integer)
            _PRO_ID = value
        End Set
    End Property

    Public Property CAT_ID As Integer
        Get
            Return _CAT_ID
        End Get
        Set(value As Integer)
            _CAT_ID = value
        End Set
    End Property

    Public Property PRO_CODIGO As String
        Get
            Return _PRO_CODIGO
        End Get
        Set(value As String)
            _PRO_CODIGO = value
        End Set
    End Property

    Public Property PRO_DESCRIPCION As String
        Get
            Return _PRO_DESCRIPCION
        End Get
        Set(value As String)
            _PRO_DESCRIPCION = value
        End Set
    End Property

    Public Property PRO_PRECIO As Double
        Get
            Return _PRO_PRECIO
        End Get
        Set(value As Double)
            _PRO_PRECIO = value
        End Set
    End Property

    Public Property PRO_LLEVA_IVA As Boolean
        Get
            Return _PRO_LLEVA_IVA
        End Get
        Set(value As Boolean)
            _PRO_LLEVA_IVA = value
        End Set
    End Property

    Public Property PRO_ESTADO As String
        Get
            Return _PRO_ESTADO
        End Get
        Set(value As String)
            _PRO_ESTADO = value
        End Set
    End Property
End Class
