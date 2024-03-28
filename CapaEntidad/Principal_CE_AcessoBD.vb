Public Class Principal_CE_AcessoBD
    Private _men_Id As Integer
    Private _men_Id_MenuPadre As Integer
    Private _men_Descripcion As String
    Private _men_Posicion As Integer
    Private _men_ForAsociado As Integer
    Private _men_nombreFrm As String
    Private _men_estado As String

    Public Property Men_Id As Integer
        Get
            Return _men_Id
        End Get
        Set(value As Integer)
            _men_Id = value
        End Set
    End Property

    Public Property Men_Id_MenuPadre As Integer
        Get
            Return _men_Id_MenuPadre
        End Get
        Set(value As Integer)
            _men_Id_MenuPadre = value
        End Set
    End Property

    Public Property Men_Descripcion As String
        Get
            Return _men_Descripcion
        End Get
        Set(value As String)
            _men_Descripcion = value
        End Set
    End Property

    Public Property Men_Posicion As Integer
        Get
            Return _men_Posicion
        End Get
        Set(value As Integer)
            _men_Posicion = value
        End Set
    End Property

    Public Property Men_ForAsociado As Integer
        Get
            Return _men_ForAsociado
        End Get
        Set(value As Integer)
            _men_ForAsociado = value
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

    Public Property Men_estado As String
        Get
            Return _men_estado
        End Get
        Set(value As String)
            _men_estado = value
        End Set
    End Property
End Class
