
Imports CapaEntidad
Public Class cls_CD_categorias
    Function fun_CD_recuperar_categoria(ByVal buscar As String) As List(Of cls_CE_categorias)
        Try
            fun_CD_recuperar_categoria = Nothing
            Dim str_cadenasql As String = ""
            str_cadenasql = str_cadenasql & " select top 10 cat_id,cat_descripcion,cat_estado "
            str_cadenasql = str_cadenasql & " from categorias"
            str_cadenasql = str_cadenasql & " where cat_descripcion like '" & buscar & "%'"
            If conectar() = False Then
                Exit Function
            End If

            dr = fun_ExecuteReader(str_cadenasql)
            Dim lista As New List(Of cls_CE_categorias)

            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_categorias
                    obj.CAT_ID = IIf(dr("cat_id") Is Nothing, 0, dr("cat_id"))
                    obj.CAT_DESCRIPCION = IIf(dr("cat_descripcion") Is Nothing, "", dr("cat_descripcion"))
                    obj.CAT_ESTADO = IIf(dr("cat_estado") Is Nothing, "", dr("cat_estado"))
                    lista.Add(obj)
                End While
            End If
            Return lista

        Catch ex As Exception
            fun_CD_recuperar_categoria = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()

        End Try
    End Function
    Function fun_CD_recuperaXcodigo(ByVal codigo As String) As List(Of cls_CE_categorias)
        Try
            fun_CD_recuperaXcodigo = Nothing
            Dim str_cadenasql As String = ""
            str_cadenasql = str_cadenasql & " select cat_id,cat_descripcion,cat_estado  "
            str_cadenasql = str_cadenasql & " from categorias"
            str_cadenasql = str_cadenasql & " where cat_id = " & codigo
            If conectar() = False Then
                Exit Function
            End If
            Dim lista As New List(Of cls_CE_categorias)
            dr = fun_ExecuteReader(str_cadenasql)
            If dr.HasRows Then
                While dr.Read
                    Dim objct As New cls_CE_categorias
                    With objct
                        .CAT_ID = IIf(dr("cat_id") Is Nothing, 0, dr("cat_id"))
                        .CAT_DESCRIPCION = IIf(dr("cat_descripcion") Is Nothing, "", dr("cat_descripcion"))
                        .CAT_ESTADO = IIf(dr("cat_estado") Is Nothing, "", dr("cat_estado"))

                    End With
                    lista.Add(objct)
                End While
            End If
            Return lista
        Catch ex As Exception
            fun_CD_recuperaXcodigo = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function fun_CD_grabar(ByVal obj As cls_CE_categorias) As Boolean
        Try
            fun_CD_grabar = False
            Dim str_cadenasql As String = ""

            If obj.CAT_ID = 0 Then
                'insert
                str_cadenasql = str_cadenasql & "insert into categorias (cat_descripcion,cat_estado) "
                str_cadenasql = str_cadenasql & " values( '" & obj.CAT_DESCRIPCION & "','" & obj.CAT_ESTADO & "')"

            Else
                'update
                str_cadenasql = str_cadenasql & " Update categorias set "
                str_cadenasql = str_cadenasql & " cat_descripcion= '" & obj.CAT_DESCRIPCION & "',"
                str_cadenasql = str_cadenasql & " cat_estado= '" & obj.CAT_ESTADO & "'"
                str_cadenasql = str_cadenasql & " where cat_id=" & obj.CAT_ID
            End If

            If conectar() = False Then
                Exit Function
            End If
            If fun_ExecuteNonQuery(str_cadenasql) = True Then
                Return True
            End If
        Catch ex As Exception
            fun_CD_grabar = False
        End Try
    End Function


End Class
