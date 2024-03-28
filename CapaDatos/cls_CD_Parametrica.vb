Imports CapaEntidad
Public Class cls_CD_Parametrica

    Function fun_CN_carg_variables() As DataTable
        Try
            fun_CN_carg_variables = Nothing
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & " select CABP_id,CABP_descripcion "
            str_cadenaSql = str_cadenaSql & " from CAB_PARAMETRICA"
            str_cadenaSql = str_cadenaSql & " where CABP_estado = 'True'"
            If conectar() = False Then
                Exit Function
            End If

            dr = fun_ExecuteReader(str_cadenaSql)
            If dr.HasRows Then
                Dim tabla As New DataTable
                tabla.Load(dr)
                Return tabla
            Else
                Return Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            fun_CN_carg_variables = Nothing
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function fun_CD_guardar(ByVal lista As List(Of cls_CE_detalle_parametrica)) As Boolean
        Try
            fun_CD_guardar = False
            Dim str_cadenaSql As String = ""
            'dgv(pos_id, T_Ln_Fila).Value

            ' Dim fila As Integer
            If conectar() = False Then
                Exit Function
            End If

            For i = 0 To lista.Count - 1

                If (lista(i).DET_Accion = 1) Then
                    'insert
                    str_cadenaSql = ""
                    str_cadenaSql = str_cadenaSql & "insert into  DET_PARAMETRICA (DETP_CODIGO,DETP_DESCRIPCION,DETP_VALOR,CABP_ID,DETP_ESTADO ) "
                    str_cadenaSql = str_cadenaSql & " values( "
                    str_cadenaSql = str_cadenaSql & "'" & lista(i).DETP_CODIGO & "',"
                    str_cadenaSql = str_cadenaSql & "'" & lista(i).DETP_DESCRIPCION & "',"
                    str_cadenaSql = str_cadenaSql & "" & lista(i).DETP_VALOR & ","
                    str_cadenaSql = str_cadenaSql & "" & lista(i).CABP_ID & ","
                    str_cadenaSql = str_cadenaSql & "'" & lista(i).DETP_ESTADO & "')"
                Else
                    'update
                    str_cadenaSql = ""
                    str_cadenaSql = str_cadenaSql & "update DET_PARAMETRICA set "
                    str_cadenaSql = str_cadenaSql & " DETP_CODIGO ='" & lista(i).DETP_CODIGO & "',"
                    str_cadenaSql = str_cadenaSql & " DETP_DESCRIPCION ='" & lista(i).DETP_DESCRIPCION & "',"
                    str_cadenaSql = str_cadenaSql & " DETP_VALOR =" & lista(i).DETP_VALOR & ","
                    str_cadenaSql = str_cadenaSql & " DETP_ESTADO ='" & lista(i).DETP_ESTADO & "'"
                    str_cadenaSql = str_cadenaSql & " where DETP_id=" & lista(i).DETP_ID
                End If

                If fun_ExecuteNonQuery(str_cadenaSql) = False Then
                    Exit Function
                End If

            Next i
            fun_CD_guardar = True
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_CD_guardar = False
        Finally
            desconectar()

        End Try
    End Function

    Function fun_CN_carg_dell_parmetrica(ByVal id_cab As String) As List(Of cls_CE_detalle_parametrica)
        Try

            fun_CN_carg_dell_parmetrica = Nothing
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & " SELECT DETP_ID,DETP_CODIGO,DETP_DESCRIPCION,DETP_VALOR,CABP_ID,DETP_ESTADO  "
            str_cadenaSql = str_cadenaSql & "  FROM DET_PARAMETRICA"
            str_cadenaSql = str_cadenaSql & " where CABP_ID= " & id_cab
            If conectar() = False Then
                Exit Function
            End If

            dr = fun_ExecuteReader(str_cadenaSql)

            Dim lista As New List(Of cls_CE_detalle_parametrica)

            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_detalle_parametrica

                    obj.CABP_ID = IIf(dr("DETP_ID") Is DBNull.Value, 0, dr("DETP_ID"))
                    obj.DETP_CODIGO = IIf(dr("DETP_CODIGO") Is DBNull.Value, "", dr("DETP_CODIGO"))
                    obj.DETP_DESCRIPCION = IIf(dr("DETP_DESCRIPCION") Is DBNull.Value, "", dr("DETP_DESCRIPCION"))
                    obj.DETP_VALOR = IIf(dr("DETP_VALOR") Is DBNull.Value, 0, dr("DETP_VALOR"))
                    obj.DETP_ESTADO = dr("DETP_ESTADO")
                    lista.Add(obj)
                End While
            End If
            Return lista
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_CN_carg_dell_parmetrica = Nothing
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function


End Class
