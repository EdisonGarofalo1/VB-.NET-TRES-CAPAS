Public Class cls_CE_acceso

    Dim _acc_id As Integer
    Dim _per_Id As Integer
    Dim _men_Id As Integer
    Dim _acc_estado As String
    Dim _men_descripcion As String
    Dim _men_nombreFrm As String

    Public Property Acc_id As Integer
        Get
            Return _acc_id
        End Get
        Set(value As Integer)
            _acc_id = value
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

    Public Property Men_Id As Integer
        Get
            Return _men_Id
        End Get
        Set(value As Integer)
            _men_Id = value
        End Set
    End Property

    Public Property Acc_estado As String
        Get
            Return _acc_estado
        End Get
        Set(value As String)
            _acc_estado = value
        End Set
    End Property

    Public Property Men_descripcion As String
        Get
            Return _men_descripcion
        End Get
        Set(value As String)
            _men_descripcion = value
        End Set
    End Property

    Public Property Men_nombreFrm As String
        Get
            Return _men_nombreFrm
        End Get
        Set(value As String)
            _men_nombreFrm = value
        End Set
    End Property
End Class
