Public Class cls_CE_detalle_parametrica

    Dim _DETP_ID As Integer
    Dim _DETP_CODIGO As String
    Dim _DETP_DESCRIPCION As String
    Dim _DETP_VALOR As Integer
    Dim _CABP_ID As Integer
    Dim _DETP_ESTADO As Boolean
    Dim _DET_Accion As Integer
    Public Property DETP_ID As Integer
        Get
            Return _DETP_ID
        End Get
        Set(value As Integer)
            _DETP_ID = value
        End Set
    End Property

    Public Property DETP_CODIGO As String
        Get
            Return _DETP_CODIGO
        End Get
        Set(value As String)
            _DETP_CODIGO = value
        End Set
    End Property

    Public Property DETP_DESCRIPCION As String
        Get
            Return _DETP_DESCRIPCION
        End Get
        Set(value As String)
            _DETP_DESCRIPCION = value
        End Set
    End Property

    Public Property DETP_VALOR As Integer
        Get
            Return _DETP_VALOR
        End Get
        Set(value As Integer)
            _DETP_VALOR = value
        End Set
    End Property

    Public Property CABP_ID As Integer
        Get
            Return _CABP_ID
        End Get
        Set(value As Integer)
            _CABP_ID = value
        End Set
    End Property

    Public Property DETP_ESTADO As Boolean
        Get
            Return _DETP_ESTADO
        End Get
        Set(value As Boolean)
            _DETP_ESTADO = value
        End Set
    End Property

    Public Property DET_Accion As Integer
        Get
            Return _DET_Accion
        End Get
        Set(value As Integer)
            _DET_Accion = value
        End Set
    End Property
End Class
