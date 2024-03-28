Imports System.Data.SqlClient
Imports CapaEntidad

Public Class cls_CD_usuarios
    Function CD_recuperarUsuarios(ByVal ci As String) As List(Of cls_CE_usuarios)
        Try
            CD_recuperarUsuarios = Nothing
            Dim lista As New List(Of cls_CE_usuarios)

            Dim str_cadena As String = " "

            str_cadena = " Select * from seg_usuarios where usu_cedula = '" & ci & "'"

            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader(str_cadena)
            If dr.HasRows Then
                While dr.Read
                    Dim objRegistro As New cls_CE_usuarios
                    objRegistro.Usu_id = dr("usu_id")
                    objRegistro.Per_Id = dr("per_id")
                    objRegistro.Usu_nombres = dr("usu_nombres")
                    objRegistro.Usu_apellidos = dr("usu_apellidos")
                    objRegistro.Usu_direccion = dr("usu_direccion")
                    objRegistro.Usu_telefono = dr("usu_telefono")
                    objRegistro.Usu_email = dr("usu_email")
                    objRegistro.Usu_usuario = dr("usu_usuario")
                    objRegistro.Usu_clave = dr("usu_clave")
                    objRegistro.Usu_foto = dr("usu_foto")
                    objRegistro.Usu_estado = dr("usu_estado")

                    lista.Add(objRegistro)

                End While
            End If

            Return lista

        Catch ex As Exception
            CD_recuperarUsuarios = Nothing
        Finally
            dr.Close()
            desconectar()

        End Try
    End Function

    Function CD_recuperarPerfiles() As DataTable
        Try
            CD_recuperarPerfiles = Nothing
            Dim str_cadenasql As String = ""
            str_cadenasql = "select *from seg_perfil"
            If conectar() = False Then
                Exit Function
            End If

            dr = fun_ExecuteReader(str_cadenasql)
            If dr.HasRows Then
                Dim dt As New DataTable
                dt.Load(dr)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            CD_recuperarPerfiles = Nothing
        End Try

    End Function
    Function CD_fun_GrabarUsurio(ByVal lista As List(Of cls_CE_usuarios)) As Boolean
        Try
            CD_fun_GrabarUsurio = False

            Dim cnn As New SqlConnection(str_cadenaConexion)
            Dim cmm As New SqlCommand("sp_mantusuario", cnn)
            cmm.CommandType = CommandType.StoredProcedure
            cmm.Parameters.AddWithValue("@usu_id", lista(0).Usu_id)
            cmm.Parameters.AddWithValue("@per_id", lista(0).Per_Id)
            cmm.Parameters.AddWithValue("@usu_cedula", lista(0).Usu_cedula)
            cmm.Parameters.AddWithValue("@usu_nombres", lista(0).Usu_nombres)
            cmm.Parameters.AddWithValue("@usu_apellidos", lista(0).Usu_apellidos)
            cmm.Parameters.AddWithValue("@usu_direccion", lista(0).Usu_direccion)
            cmm.Parameters.AddWithValue("@usu_telefono", lista(0).Usu_telefono)
            cmm.Parameters.AddWithValue("@usu_email", lista(0).Usu_email)
            cmm.Parameters.AddWithValue("@usu_usuario", lista(0).Usu_usuario)
            cmm.Parameters.AddWithValue("@usu_clave", lista(0).Usu_clave)


            cmm.Parameters.Add("@usu_foto", System.Data.SqlDbType.Image).Value =(lista(0).Usu_foto)
            cmm.Parameters.AddWithValue("@usu_estado", lista(0).Usu_estado)
            'ejecutar
            Try
                cnn.Open()
                cmm.ExecuteNonQuery()

                CD_fun_GrabarUsurio = True
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Dispose()
                cmm.Dispose()
            End Try

        Catch ex As Exception
            CD_fun_GrabarUsurio = False
            MsgBox(ex.Message)
        End Try
    End Function

    Function CD_fun_usuarioexiste(ByVal usuario As String, ByVal id_usuario As Integer) As Boolean
        Try
            CD_fun_usuarioexiste = False
            Dim usuexiste As String = ""
            Dim cadena_sql As String = ""
            cadena_sql = cadena_sql & "select usu_usuario"
            cadena_sql = cadena_sql & " from seg_usuarios"
            cadena_sql = cadena_sql & " where "
            cadena_sql = cadena_sql & "  usu_usuario like '" & usuario & "'"
            cadena_sql = cadena_sql & "  and usu_id =" & id_usuario
            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader(cadena_sql)
            If dr.HasRows Then
                While dr.Read
                    usuexiste = dr("usu_usuario")
                End While
            End If
            If usuexiste <> "" Then
                CD_fun_usuarioexiste = True
            End If
            dr = fun_ExecuteReader(cadena_sql)
        Catch ex As Exception
            CD_fun_usuarioexiste = False
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function fun_buscarusuariosxApe(txt_buscar) As List(Of cls_CE_usuarios)
        Try
            fun_buscarusuariosxApe = Nothing
            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader("sp_sel_ListaUsiariosxApe", txt_buscar)
            Dim lista As New List(Of cls_CE_usuarios)

            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_usuarios
                    obj.Usu_cedula = dr("usu_cedula")
                    obj.Usu_nombres = dr("nombres")
                    obj.Usu_apellidos = dr("per_nombre")
                    obj.Usu_estado = dr("usu_estado")
                    lista.Add(obj)
                End While

            End If
            Return lista
        Catch ex As Exception
            fun_buscarusuariosxApe = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function

End Class
