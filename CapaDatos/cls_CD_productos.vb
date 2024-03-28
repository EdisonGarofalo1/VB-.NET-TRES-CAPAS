Imports CapaEntidad
Public Class cls_CD_productos
    Function fun_CD_recuperar_productos(ByVal buscar As String) As List(Of cls_CE_producto)

        Try
            fun_CD_recuperar_productos = Nothing
            Dim str_cadenasql As String = ""
            str_cadenasql = str_cadenasql & "SELECT * "
            str_cadenasql = str_cadenasql & " FROM [dbo].[PRODUCTOS] where PRO_DESCRIPCION like'" & buscar & "%'"

            If conectar() = False Then
                Exit Function
            End If
            Dim lista As New List(Of cls_CE_producto)
            dr = fun_ExecuteReader(str_cadenasql)
            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_producto
                    With obj
                        .PRO_ID = IIf(dr("PRO_ID") Is Nothing, 0, dr("PRO_ID"))
                        .CAT_ID = IIf(dr("CAT_ID") Is Nothing, 0, dr("CAT_ID"))
                        .PRO_CODIGO = IIf(dr("PRO_CODIGO") Is Nothing, "", dr("PRO_CODIGO"))
                        .PRO_DESCRIPCION = IIf(dr("PRO_DESCRIPCION") Is Nothing, "", dr("PRO_DESCRIPCION"))
                        .PRO_LLEVA_IVA = IIf(dr("PRO_LLEVA_IVA") Is Nothing, False, dr("PRO_LLEVA_IVA"))
                        .PRO_PRECIO = IIf(dr("PRO_PRECIO") Is Nothing, 0, dr("PRO_PRECIO"))
                        .PRO_ESTADO = IIf(dr("PRO_ESTADO") Is Nothing, "I", dr("PRO_ESTADO"))
                    End With
                    lista.Add(obj)
                End While
            End If
            Return lista
        Catch ex As Exception
            fun_CD_recuperar_productos = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function fun_CD_carg_categoria() As DataTable
        Try
            fun_CD_carg_categoria = Nothing
            Dim str_cadenasql As String = " select * from CATEGORIAS where CAT_ESTADO='A' "

            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader(str_cadenasql)
            Dim tabla As New DataTable
            If dr.HasRows Then
                tabla.Load(dr)
            End If
            Return tabla
        Catch ex As Exception
            fun_CD_carg_categoria = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function fun_CD_recuperarXid(ByVal id As String) As cls_CE_producto
        Try

            fun_CD_recuperarXid = Nothing

            Dim strcadenasql As String = " select * from PRODUCTOS where PRO_ID= " & id

            If conectar() = False Then
                Exit Function

            End If
            Dim obj As New cls_CE_producto
            dr = fun_ExecuteReader(strcadenasql)
            If dr.HasRows Then
                While dr.Read

                    With obj
                        .PRO_ID = IIf(dr("PRO_ID") Is Nothing, 0, dr("PRO_ID"))
                        .CAT_ID = IIf(dr("CAT_ID") Is Nothing, 0, dr("CAT_ID"))
                        .PRO_CODIGO = IIf(dr("PRO_CODIGO") Is Nothing, "", dr("PRO_CODIGO"))
                        .PRO_DESCRIPCION = IIf(dr("PRO_DESCRIPCION") Is Nothing, "", dr("PRO_DESCRIPCION"))
                        .PRO_LLEVA_IVA = IIf(dr("PRO_LLEVA_IVA") Is Nothing, False, dr("PRO_LLEVA_IVA"))
                        .PRO_PRECIO = IIf(dr("PRO_PRECIO") Is Nothing, 0, dr("PRO_PRECIO"))
                        .PRO_ESTADO = IIf(dr("PRO_ESTADO") Is Nothing, "I", dr("PRO_ESTADO"))
                    End With

                End While
            End If
            Return obj

        Catch ex As Exception
            MsgBox(ex.Message)

            fun_CD_recuperarXid = Nothing
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function fun_CD_grabar(ByVal pro As cls_CE_producto) As Boolean
        Try
            fun_CD_grabar = False
            Dim str_cadenasql As String = ""
            If conectar() = False Then
                Exit Function
            End If

            If pro.PRO_ID = 0 Then
                str_cadenasql = str_cadenasql & " INSERT INTO [dbo].[PRODUCTOS] ([CAT_ID] ,[PRO_CODIGO] ,[PRO_DESCRIPCION],[PRO_PRECIO] ,[PRO_LLEVA_IVA] ,[PRO_ESTADO])"
                str_cadenasql = str_cadenasql & "VALUES"
                str_cadenasql = str_cadenasql & " ( " & pro.CAT_ID
                str_cadenasql = str_cadenasql & " , '" & pro.PRO_CODIGO & "'"
                str_cadenasql = str_cadenasql & " , '" & pro.PRO_DESCRIPCION & "'"
                str_cadenasql = str_cadenasql & " , " & pro.PRO_PRECIO
                str_cadenasql = str_cadenasql & " , '" & pro.PRO_LLEVA_IVA & "'"
                str_cadenasql = str_cadenasql & " , '" & pro.PRO_ESTADO & "' )"
            Else
                str_cadenasql = str_cadenasql & " UPDATE [dbo].[PRODUCTOS]"
                str_cadenasql = str_cadenasql & " SET [CAT_ID] =  " & pro.CAT_ID
                str_cadenasql = str_cadenasql & " ,[PRO_CODIGO] = '" & pro.PRO_CODIGO & "' "
                str_cadenasql = str_cadenasql & " ,[PRO_DESCRIPCION] = '" & pro.PRO_DESCRIPCION & "' "
                str_cadenasql = str_cadenasql & " ,[PRO_PRECIO] = " & pro.PRO_PRECIO
                str_cadenasql = str_cadenasql & " ,[PRO_LLEVA_IVA] =  '" & pro.PRO_LLEVA_IVA & "'"
                str_cadenasql = str_cadenasql & " ,[PRO_ESTADO] = '" & pro.PRO_ESTADO & "' "
                str_cadenasql = str_cadenasql & "   WHERE [PRO_ID] = " & pro.PRO_ID
            End If

            If fun_ExecuteNonQuery(str_cadenasql) = True Then
                fun_CD_grabar = True
            End If
        Catch ex As Exception
            fun_CD_grabar = False
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Function
End Class
