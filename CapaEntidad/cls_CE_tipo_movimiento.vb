Public Class cls_CE_tipo_movimiento
    Dim _TIPMOV_ID As Integer
    Dim _TIPMOV_DESCRIPCION As String
    Dim _TIPMOV_ESTADO As String

    Public Property TIPMOV_ID As Integer
        Get
            Return _TIPMOV_ID
        End Get
        Set(value As Integer)
            _TIPMOV_ID = value
        End Set
    End Property

    Public Property TIPMOV_DESCRIPCION As String
        Get
            Return _TIPMOV_DESCRIPCION
        End Get
        Set(value As String)
            _TIPMOV_DESCRIPCION = value
        End Set
    End Property

    Public Property TIPMOV_ESTADO As String
        Get
            Return _TIPMOV_ESTADO
        End Get
        Set(value As String)
            _TIPMOV_ESTADO = value
        End Set
    End Property
End Class
