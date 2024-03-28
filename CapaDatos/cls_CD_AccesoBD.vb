Imports CapaEntidad
Public Class cls_CD_AccesoBD

    Public Sub New(ByRef cadenaConec As String)
        str_cadenaConexion = cadenaConec
    End Sub
    Public Sub New()
    End Sub
    Public Function CD_fun_verificarConexion() As Boolean
        CD_fun_verificarConexion = False
        Try
            If conectar() = True Then
                CD_fun_verificarConexion = True
                desconectar()
            End If
        Catch ex As Exception
            CD_fun_verificarConexion = False
        End Try

    End Function

    Function CD_fun_listUsuario(ByVal usuario As String, ByVal clave As String) As List(Of cls_CE_AccesoBD)
        Try
            CD_fun_listUsuario = Nothing
            Dim lista As New List(Of cls_CE_AccesoBD)


            Dim str_consultasql As String = ""
            str_consultasql = str_consultasql & " select usu_nombres,usu_apellidos,usu_id,per_Id "
            str_consultasql = str_consultasql & " From seg_usuarios "
            str_consultasql = str_consultasql & " Where usu_usuario ='" & usuario & "'"
            str_consultasql = str_consultasql & " And usu_clave ='" & clave & "' and usu_estado='A'"

            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader(str_consultasql)
            If dr.HasRows Then
                While dr.Read

                    Dim objregistro As New cls_CE_AccesoBD
                    objregistro.Nombre_usuario = dr("usu_nombres") & " " & dr("usu_apellidos")
                    objregistro.Id_usuario = dr("usu_id")
                    objregistro.Perfilusuario = dr("per_id")
                    lista.Add(objregistro)
                End While

            End If
            Return lista
        Catch ex As Exception
            CD_fun_listUsuario = Nothing
            'MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
End Class
