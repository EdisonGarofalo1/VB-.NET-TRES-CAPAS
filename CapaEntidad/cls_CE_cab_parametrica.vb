Public Class cls_CE_cab_parametrica
    Dim _CABP_ID As Integer
    Dim _CABP_CODIGO As String
    Dim _CABP_DESCRIPCION As String
    Dim _CABP_ESTADO As Boolean
    Dim _ACCION As Integer

    Public Property CABP_ID As Integer
        Get
            Return _CABP_ID
        End Get
        Set(value As Integer)
            _CABP_ID = value
        End Set
    End Property

    Public Property CABP_CODIGO As String
        Get
            Return _CABP_CODIGO
        End Get
        Set(value As String)
            _CABP_CODIGO = value
        End Set
    End Property

    Public Property CABP_DESCRIPCION As String
        Get
            Return _CABP_DESCRIPCION
        End Get
        Set(value As String)
            _CABP_DESCRIPCION = value
        End Set
    End Property

    Public Property CABP_ESTADO As Boolean
        Get
            Return _CABP_ESTADO
        End Get
        Set(value As Boolean)
            _CABP_ESTADO = value
        End Set
    End Property

    Public Property ACCION As Integer
        Get
            Return _ACCION
        End Get
        Set(value As Integer)
            _ACCION = value
        End Set
    End Property
End Class
