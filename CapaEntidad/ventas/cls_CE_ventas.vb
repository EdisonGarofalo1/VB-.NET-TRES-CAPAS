Public Class cls_CE_ventas
    'cabezera movimiento
    Dim _CABMOV_ID As Integer
    Dim _CABMOV_NUM_DOC As Integer
    Dim _TIPMOV_ID As Integer
    Dim _CABMOVIMIENTO As String
    Dim _PER_ID As Integer
    Dim _CABMOV_FECHA As Date
    Dim _CABMOV_BASE_IMPONIBLE As Double
    Dim _CABMOV_IVA As Double
    Dim _CABMOV_VALOR_FINAL As Double
    Dim _CABMOV_ESTADO As String
    Dim _USUARIO As Integer
    Dim _FECHA_INGRESO As DateTime
    Dim _FECHA_MODIFIC As DateTime
    'clientes o personas 
    ' Dim _PER_ID As Integer
    Dim _PER_IDENTIFICACION As String
    Dim _CP_SEXO As Integer
    Dim _CP_ESTADO_CIVIL As Integer
    Dim _PER_NOMBRES As String
    Dim _PER_TELEFONO As String
    Dim _PER_DIRECCION As String
    Dim _PER_ESTADO As String

    Public Property CABMOV_ID As Integer
        Get
            Return _CABMOV_ID
        End Get
        Set(value As Integer)
            _CABMOV_ID = value
        End Set
    End Property

    Public Property CABMOV_NUM_DOC As Integer
        Get
            Return _CABMOV_NUM_DOC
        End Get
        Set(value As Integer)
            _CABMOV_NUM_DOC = value
        End Set
    End Property

    Public Property TIPMOV_ID As Integer
        Get
            Return _TIPMOV_ID
        End Get
        Set(value As Integer)
            _TIPMOV_ID = value
        End Set
    End Property

    Public Property CABMOVIMIENTO As String
        Get
            Return _CABMOVIMIENTO
        End Get
        Set(value As String)
            _CABMOVIMIENTO = value
        End Set
    End Property

    Public Property PER_ID As Integer
        Get
            Return _PER_ID
        End Get
        Set(value As Integer)
            _PER_ID = value
        End Set
    End Property

    Public Property CABMOV_FECHA As Date
        Get
            Return _CABMOV_FECHA
        End Get
        Set(value As Date)
            _CABMOV_FECHA = value
        End Set
    End Property

    Public Property CABMOV_BASE_IMPONIBLE As Double
        Get
            Return _CABMOV_BASE_IMPONIBLE
        End Get
        Set(value As Double)
            _CABMOV_BASE_IMPONIBLE = value
        End Set
    End Property

    Public Property CABMOV_IVA As Double
        Get
            Return _CABMOV_IVA
        End Get
        Set(value As Double)
            _CABMOV_IVA = value
        End Set
    End Property

    Public Property CABMOV_VALOR_FINAL As Double
        Get
            Return _CABMOV_VALOR_FINAL
        End Get
        Set(value As Double)
            _CABMOV_VALOR_FINAL = value
        End Set
    End Property

    Public Property CABMOV_ESTADO As String
        Get
            Return _CABMOV_ESTADO
        End Get
        Set(value As String)
            _CABMOV_ESTADO = value
        End Set
    End Property

    Public Property USUARIO As Integer
        Get
            Return _USUARIO
        End Get
        Set(value As Integer)
            _USUARIO = value
        End Set
    End Property

    Public Property FECHA_INGRESO As Date
        Get
            Return _FECHA_INGRESO
        End Get
        Set(value As Date)
            _FECHA_INGRESO = value
        End Set
    End Property

    Public Property FECHA_MODIFIC As Date
        Get
            Return _FECHA_MODIFIC
        End Get
        Set(value As Date)
            _FECHA_MODIFIC = value
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
