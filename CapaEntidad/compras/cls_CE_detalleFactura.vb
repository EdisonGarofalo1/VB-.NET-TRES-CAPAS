Public Class cls_CE_detalleFactura
    Dim _PRO_ID As Integer
    Dim _CAT_ID As Integer
    Dim _PRO_CODIGO As String
    Dim _PRO_DESCRIPCION As String
    Dim _PRO_PRECIO As Double
    Dim _PRO_LLEVA_IVA As Boolean
    Dim _PRO_ESTADO As String
    Dim _DET_CANTIDAD As Integer
    Dim _DET_BASE_IMPONIBLE As Double
    Dim _DET_IVA As Double
    Dim _DET_TOTAL As Double

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

    Public Property DET_CANTIDAD As Integer
        Get
            Return _DET_CANTIDAD
        End Get
        Set(value As Integer)
            _DET_CANTIDAD = value
        End Set
    End Property

    Public Property DET_BASE_IMPONIBLE As Double
        Get
            Return _DET_BASE_IMPONIBLE
        End Get
        Set(value As Double)
            _DET_BASE_IMPONIBLE = value
        End Set
    End Property

    Public Property DET_IVA As Double
        Get
            Return _DET_IVA
        End Get
        Set(value As Double)
            _DET_IVA = value
        End Set
    End Property

    Public Property DET_TOTAL As Double
        Get
            Return _DET_TOTAL
        End Get
        Set(value As Double)
            _DET_TOTAL = value
        End Set
    End Property
End Class
