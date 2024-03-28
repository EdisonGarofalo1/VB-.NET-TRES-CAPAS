Imports CapaEntidad
Public Class cls_CD_variables_sistema
    Function fun_CD_grabar(ByVal lista As List(Of cls_CE_cab_parametrica)) As Boolean
        Try
            fun_CD_grabar = False
            Dim str_cadenaSql As String = ""

            Dim n As Integer
            n = lista.Count - 1
            For i = 0 To n
                If (lista(i).ACCION = 1) Then
                    'insert
                    str_cadenaSql = ""
                    str_cadenaSql = str_cadenaSql & "insert into  CAB_PARAMETRICA (CABP_CODIGO,CABP_descripcion,CABP_estado) "
                    str_cadenaSql = str_cadenaSql & " values( "
                    str_cadenaSql = str_cadenaSql & "'" & lista(i).CABP_CODIGO & "',"
                    str_cadenaSql = str_cadenaSql & "'" & lista(i).CABP_DESCRIPCION & "',"
                    str_cadenaSql = str_cadenaSql & "'" & lista(i).CABP_ESTADO & "')"
                Else
                    'update
                    str_cadenaSql = ""
                    str_cadenaSql = str_cadenaSql & "update CAB_PARAMETRICA set "
                    str_cadenaSql = str_cadenaSql & " CABP_CODIGO ='" & lista(i).CABP_CODIGO & "',"
                    str_cadenaSql = str_cadenaSql & " CABP_descripcion ='" & lista(i).CABP_DESCRIPCION & "',"
                    str_cadenaSql = str_cadenaSql & " CABP_estado ='" & lista(i).CABP_ESTADO & "'"
                    str_cadenaSql = str_cadenaSql & " where CABP_id=" & lista(i).CABP_ID
                End If
            Next



            If conectar() = False Then
                Exit Function
            End If
            If fun_ExecuteNonQuery(str_cadenaSql) = False Then
                Exit Function
            End If
            fun_CD_grabar = True
        Catch ex As Exception
            fun_CD_grabar = False
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Function

    Function fun_CD_recuperar(ByVal buscar As String) As List(Of cls_CE_cab_parametrica)
        Try
            fun_CD_recuperar = Nothing
            Dim str_cadenasql As String = ""
            str_cadenasql = str_cadenasql & "select CABP_id,CABP_CODIGO,CABP_descripcion,CABP_estado "
            str_cadenasql = str_cadenasql & " from CAB_PARAMETRICA"
            str_cadenasql = str_cadenasql & " where CABP_descripcion like '" & buscar & "%'"
            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader(str_cadenasql)
            Dim lista As New List(Of cls_CE_cab_parametrica)
            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_cab_parametrica
                    obj.CABP_ID = IIf(dr("CABP_id") Is Nothing, 0, dr("CABP_id"))
                    obj.CABP_CODIGO = IIf(dr("CABP_CODIGO") Is Nothing, "", dr("CABP_CODIGO"))
                    obj.CABP_DESCRIPCION = IIf(dr("CABP_descripcion") Is Nothing, "", dr("CABP_descripcion"))
                    obj.CABP_ESTADO = IIf(dr("CABP_estado") Is Nothing, False, dr("CABP_estado"))
                    lista.Add(obj)
                End While
            End If
            Return lista

        Catch ex As Exception
            fun_CD_recuperar = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()

        End Try
    End Function


End Class
