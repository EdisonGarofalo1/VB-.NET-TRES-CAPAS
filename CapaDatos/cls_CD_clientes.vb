Imports CapaEntidad
Public Class cls_CD_clientes
    Function fun_CD_recuperar(ByVal buscar As String) As List(Of cls_CE_clientes)
        Try
            fun_CD_recuperar = Nothing
            Dim srt_cadenasql As String = " select PER_ID, PER_IDENTIFICACION,PER_NOMBRES,CP_SEXO,CP_ESTADO_CIVIL,PER_DIRECCION,PER_ESTADO from  [PERSONAS] where PER_NOMBRES like '" & buscar & "%'"
            Dim lista As New List(Of cls_CE_clientes)
            If conectar() = False Then
                Exit Function
            End If

            dr = fun_ExecuteReader(srt_cadenasql)
            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_clientes
                    With obj
                        obj.PER_ID = IIf(dr("PER_ID") Is Nothing, 0, dr("PER_ID"))
                        obj.PER_IDENTIFICACION = IIf(dr("PER_IDENTIFICACION") Is Nothing, "", dr("PER_IDENTIFICACION"))
                        obj.CP_SEXO = IIf(dr("CP_SEXO") Is Nothing, 0, dr("CP_SEXO"))
                        obj.CP_ESTADO_CIVIL = IIf(dr("CP_ESTADO_CIVIL") Is Nothing, 0, dr("CP_ESTADO_CIVIL"))
                        obj.PER_NOMBRES = IIf(dr("PER_NOMBRES") Is Nothing, "", dr("PER_NOMBRES"))
                        obj.PER_DIRECCION = IIf(dr("PER_DIRECCION") Is Nothing, "", dr("PER_DIRECCION"))
                        obj.PER_ESTADO = IIf(dr("PER_ESTADO") Is Nothing, "I", dr("PER_ESTADO"))
                    End With
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
    Function fun_rexuperarxcodigo(ByVal id As String) As cls_CE_clientes
        Try
            fun_rexuperarxcodigo = Nothing
            Dim srt_cadenasql As String = " select * from [dbo].[PERSONAS] where PER_ID = " & id

            If conectar() = False Then
                Exit Function
            End If

            Dim obj As New cls_CE_clientes

            dr = fun_ExecuteReader(srt_cadenasql)
            If dr.HasRows Then
                While dr.Read

                    With obj
                        obj.PER_ID = IIf(dr("PER_ID") Is Nothing, 0, dr("PER_ID"))
                        obj.PER_IDENTIFICACION = IIf(dr("PER_IDENTIFICACION") Is Nothing, "", dr("PER_IDENTIFICACION"))
                        obj.CP_SEXO = IIf(dr("CP_SEXO") Is Nothing, 0, dr("CP_SEXO"))
                        obj.PER_TELEFONO = IIf(dr("PER_TELEFONO") Is Nothing, "", dr("PER_TELEFONO"))

                        obj.CP_ESTADO_CIVIL = IIf(dr("CP_ESTADO_CIVIL") Is Nothing, 0, dr("CP_ESTADO_CIVIL"))
                        obj.PER_NOMBRES = IIf(dr("PER_NOMBRES") Is Nothing, "", dr("PER_NOMBRES"))
                        obj.PER_DIRECCION = IIf(dr("PER_DIRECCION") Is Nothing, "", dr("PER_DIRECCION"))
                        obj.PER_ESTADO = IIf(dr("PER_ESTADO") Is Nothing, "I", dr("PER_ESTADO"))
                    End With

                End While
            End If
            Return obj
        Catch ex As Exception
            fun_rexuperarxcodigo = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function fun_CN__crg_sexo() As DataTable
        Try
            fun_CN__crg_sexo = Nothing
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & " select DEtP_id,DEtP_descripcion "
            str_cadenaSql = str_cadenaSql & " from DET_PARAMETRICA"
            str_cadenaSql = str_cadenaSql & "  where CABP_id=(select CABP_ID from CAB_PARAMETRICA where CABP_ESTADO='True' and CABP_CODIGO='SEX')"
            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader(str_cadenaSql)
            Dim dt As New DataTable
            If dr.HasRows Then

                dt.Load(dr)
            End If

            Return dt
        Catch ex As Exception
            fun_CN__crg_sexo = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function fun_CD__crg_estado() As DataTable
        Try
            fun_CD__crg_estado = Nothing
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & " select DEtP_id,DEtP_descripcion "
            str_cadenaSql = str_cadenaSql & " from DET_PARAMETRICA"
            str_cadenaSql = str_cadenaSql & "  where CABP_id=(select CABP_ID from CAB_PARAMETRICA where CABP_ESTADO='True' and CABP_CODIGO='ESTCIVIL')"
            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader(str_cadenaSql)
            Dim dt As New DataTable
            If dr.HasRows Then

                dt.Load(dr)
            End If

            Return dt
        Catch ex As Exception
            fun_CD__crg_estado = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function fun_CN_grabar(ByVal cliente As cls_CE_clientes) As Boolean
        Try
            fun_CN_grabar = False
            Dim str_cadenaSql As String = ""
            If cliente.PER_ID = 0 Then
                'insert
                str_cadenaSql = str_cadenaSql & "insert into PERSONAS (PER_IDENTIFICACION,CP_SEXO,CP_ESTADO_CIVIL,PER_NOMBRES,PER_TELEFONO,PER_DIRECCION,PER_ESTADO) "
                str_cadenaSql = str_cadenaSql & " values( '" & cliente.PER_IDENTIFICACION & "'," & cliente.CP_SEXO & "," & cliente.CP_ESTADO_CIVIL & ",'" & cliente.PER_NOMBRES & "','" & cliente.PER_TELEFONO & "','" & cliente.PER_DIRECCION & "','" & cliente.PER_ESTADO & "')"

            Else
                'update
                str_cadenaSql = str_cadenaSql & " Update PERSONAS set "
                str_cadenaSql = str_cadenaSql & " PER_IDENTIFICACION= '" & cliente.PER_IDENTIFICACION & "',"
                str_cadenaSql = str_cadenaSql & " CP_SEXO= " & cliente.CP_SEXO & ","
                str_cadenaSql = str_cadenaSql & " CP_ESTADO_CIVIL= " & cliente.CP_ESTADO_CIVIL & ","
                str_cadenaSql = str_cadenaSql & " PER_NOMBRES= '" & cliente.PER_NOMBRES & "',"
                str_cadenaSql = str_cadenaSql & " PER_TELEFONO= '" & cliente.PER_TELEFONO & "',"
                str_cadenaSql = str_cadenaSql & " PER_DIRECCION= '" & cliente.PER_DIRECCION & "',"
                str_cadenaSql = str_cadenaSql & " PER_ESTADO= '" & cliente.PER_ESTADO & "'"
                str_cadenaSql = str_cadenaSql & " where PER_ID=" & cliente.PER_ID
            End If
            If conectar() = False Then
                Exit Function
            End If
            If fun_ExecuteNonQuery(str_cadenaSql) = True Then
                fun_CN_grabar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_CN_grabar = False
        Finally

            desconectar()
        End Try
    End Function
End Class
