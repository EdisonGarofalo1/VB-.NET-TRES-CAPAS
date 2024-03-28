Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing

Module mod_AccesoBD
    'variables para conectar a la base de datos

    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Public dr As SqlDataReader
    Public str_cadenaConexion As String
    Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function
    Public Function conectar() As Boolean
        Try
            conectar = False
            cnn = New SqlConnection
            cnn.ConnectionString = str_cadenaConexion
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            conectar = True
        Catch ex As Exception
            conectar = False
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function desconectar() As Boolean
        Try
            desconectar = False
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                desconectar = True
            End If


        Catch ex As Exception
            desconectar = False
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function fun_ExecuteReader(ByVal cadenasql As String, Optional i As Integer = 0) As SqlDataReader
        Try
            cmd = New SqlCommand
            cmd.CommandText = cadenasql
            If i = 0 Then
                cmd.CommandType = CommandType.Text
            Else
                cmd.CommandType = CommandType.StoredProcedure
            End If
            cmd.Connection = cnn
            Return cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function fun_ExecuteReader(ByVal procedimiento As String, ByVal ParamArray parametro() As String) As SqlDataReader
        Dim i As Integer
        Try
            cmd = New SqlCommand
            cmd.CommandText = procedimiento
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            'cargar los parametros
            SqlCommandBuilder.DeriveParameters(cmd) 'trae los parametros
            For i = 1 To parametro.Length
                CType(cmd.Parameters(i), SqlParameter).Value = parametro(i - 1)
            Next
            Return cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function fun_ExecuteNonQuery(ByVal cadena As String) As Boolean
        Try
            'graba o actualiza pasando una cadena de texto
            cmd = New SqlCommand
            cmd.CommandText = cadena
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function fun_ExecuteNonQuery(ByVal procedimiento As String, ByVal ParamArray parametro() As String) As Boolean
        Dim i As Integer
        Try
            'graba o actualiza
            cmd = New SqlCommand
            cmd.CommandText = procedimiento
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            'cargar los parametros
            SqlCommandBuilder.DeriveParameters(cmd) 'trae los parametros
            For i = 1 To parametro.Length
                CType(cmd.Parameters(i), SqlParameter).Value = parametro(i - 1)
            Next
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


End Module
