Imports CapaEntidad

Public Class cls_CD_perfil
    Public Sub New(ByRef cadenaConec As String)
        str_cadenaConexion = cadenaConec
    End Sub
    Public Sub New()
    End Sub
    Function fun_recuperaDatos(ByVal buscar As String) As List(Of cls_CE_perfil)
        Try
            fun_recuperaDatos = Nothing
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & " select top 10 per_id,per_nombre,per_descripcion,per_estado "
            str_cadenaSql = str_cadenaSql & " from seg_perfil"
            str_cadenaSql = str_cadenaSql & " where per_nombre like '" & buscar & "%'"
            If conectar() = False Then
                Exit Function
            End If
            Dim lista As New List(Of cls_CE_perfil)

            dr = fun_ExecuteReader(str_cadenaSql)


            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_perfil
                    obj.Per_Id = dr("per_id")
                    obj.Per_Nombre = dr("per_nombre")
                    obj.Per_Descripcion = dr("per_descripcion")
                    obj.Per_estado = dr("per_estado")

                    lista.Add(obj)
                End While
            End If
            Return lista
        Catch ex As Exception
            fun_recuperaDatos = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function CD_fun_recuperaperfil(ByVal codigo As String) As List(Of cls_CE_perfil)
        Try
            CD_fun_recuperaperfil = Nothing
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & " select top 10 per_id,per_nombre,per_descripcion,per_estado "
            str_cadenaSql = str_cadenaSql & " from seg_perfil"
            str_cadenaSql = str_cadenaSql & " where per_id = " & codigo
            If conectar() = False Then
                Exit Function
            End If
            Dim lista As New List(Of cls_CE_perfil)

            dr = fun_ExecuteReader(str_cadenaSql)


            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_perfil
                    obj.Per_Id = dr("per_id")
                    obj.Per_Nombre = dr("per_nombre")
                    obj.Per_Descripcion = dr("per_descripcion")
                    obj.Per_estado = dr("per_estado")

                    lista.Add(obj)
                End While
            End If
            Return lista
        Catch ex As Exception
            CD_fun_recuperaperfil = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function CD_fun_grabar(ByVal lista As List(Of cls_CE_perfil)) As Boolean
        Try
            CD_fun_grabar = False
            Dim str_cadenaSql As String = ""

            If lista(0).Per_Id = 0 Then
                'insert
                str_cadenaSql = str_cadenaSql & "insert into seg_Perfil (per_Nombre,per_descripcion,per_estado) "
                str_cadenaSql = str_cadenaSql & " values( '" & lista(0).Per_Nombre & "','" & lista(0).Per_Descripcion & "','" & lista(0).Per_estado & "')"
            Else
                'update
                str_cadenaSql = str_cadenaSql & " Update seg_perfil set "
                str_cadenaSql = str_cadenaSql & " per_nombre= '" & lista(0).Per_Nombre & "',"
                str_cadenaSql = str_cadenaSql & " per_descripcion= '" & lista(0).Per_Descripcion & "',"
                str_cadenaSql = str_cadenaSql & " per_estado= '" & lista(0).Per_estado & "'"
                str_cadenaSql = str_cadenaSql & " where per_id=" & lista(0).Per_Id
            End If

            If conectar() = False Then
                Exit Function
            End If
            If fun_ExecuteNonQuery(str_cadenaSql) = True Then
                CD_fun_grabar = True
            End If

        Catch ex As Exception
            CD_fun_grabar = False
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Function
End Class
