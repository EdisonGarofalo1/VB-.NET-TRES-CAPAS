Imports CapaEntidad
Public Class cls_CD_tipo_movimiento

    Function fun_CD_carga_movimiento(ByRef buscar As String) As List(Of cls_CE_tipo_movimiento)
        Try
            fun_CD_carga_movimiento = Nothing
            Dim str_cadenasql As String = "SELECT [TIPMOV_ID] ,[TIPMOV_DESCRIPCION] ,[TIPMOV_ESTADO] FROM [dbo].[TIPO_MOVIMIENTO] where TIPMOV_DESCRIPCION like '" & buscar & "%'"

            If conectar() = False Then
                Exit Function
            End If

            Dim lista As New List(Of cls_CE_tipo_movimiento)

            dr = fun_ExecuteReader(str_cadenasql)
            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_tipo_movimiento
                    With obj
                        obj.TIPMOV_ID = IIf(dr("TIPMOV_ID") Is Nothing, 0, dr("TIPMOV_ID"))
                        obj.TIPMOV_DESCRIPCION = IIf(dr("TIPMOV_DESCRIPCION") Is Nothing, "", dr("TIPMOV_DESCRIPCION"))
                        obj.TIPMOV_ESTADO = IIf(dr("TIPMOV_ESTADO") Is Nothing, "I", dr("TIPMOV_ESTADO"))
                    End With
                    lista.Add(obj)
                End While

            End If
            Return lista
        Catch ex As Exception
            fun_CD_carga_movimiento = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function


    Function fun_CD_recuperarXcodigo(ByRef codigo As String) As cls_CE_tipo_movimiento
        Try
            fun_CD_recuperarXcodigo = Nothing
            Dim str_cadenasql As String = "SELECT [TIPMOV_ID] ,[TIPMOV_DESCRIPCION] ,[TIPMOV_ESTADO] FROM [dbo].[TIPO_MOVIMIENTO] where TIPMOV_ID = " & codigo

            If conectar() = False Then
                Exit Function
            End If

            Dim lista As New List(Of cls_CE_tipo_movimiento)

            dr = fun_ExecuteReader(str_cadenasql)
            Dim obj As New cls_CE_tipo_movimiento
            If dr.HasRows Then
                While dr.Read

                    With obj
                        obj.TIPMOV_ID = IIf(dr("TIPMOV_ID") Is Nothing, 0, dr("TIPMOV_ID"))
                        obj.TIPMOV_DESCRIPCION = IIf(dr("TIPMOV_DESCRIPCION") Is Nothing, "", dr("TIPMOV_DESCRIPCION"))
                        obj.TIPMOV_ESTADO = IIf(dr("TIPMOV_ESTADO") Is Nothing, "I", dr("TIPMOV_ESTADO"))
                    End With

                End While

            End If
            Return obj
        Catch ex As Exception
            fun_CD_recuperarXcodigo = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function fun_CD_grabar(ByVal tipo As cls_CE_tipo_movimiento) As Boolean
        Try
            fun_CD_grabar = False
            Dim str_cadenasql As String = ""
            If conectar() = False Then
                Exit Function

            End If
            If tipo.TIPMOV_ID = 0 Then

                str_cadenasql = str_cadenasql & "INSERT INTO [dbo].[TIPO_MOVIMIENTO]([TIPMOV_DESCRIPCION],[TIPMOV_ESTADO])"
                str_cadenasql = str_cadenasql & "values ( '" & tipo.TIPMOV_DESCRIPCION & "' , '" & tipo.TIPMOV_ESTADO & "' )"
            Else
                str_cadenasql = str_cadenasql & "UPDATE [dbo].[TIPO_MOVIMIENTO] SET "
                str_cadenasql = str_cadenasql & "[TIPMOV_DESCRIPCION] = '" & tipo.TIPMOV_DESCRIPCION & "'"
                str_cadenasql = str_cadenasql & " ,[TIPMOV_ESTADO] = '" & tipo.TIPMOV_ESTADO & "'"
                str_cadenasql = str_cadenasql & "  where [TIPMOV_ID]= " & tipo.TIPMOV_ID
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
