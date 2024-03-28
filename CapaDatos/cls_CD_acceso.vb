Imports CapaEntidad

Public Class cls_CD_acceso
    Function CD_recuperardatos(ByVal descripcionp As String, ByVal descripcionh As String) As List(Of Integer)
        Try
            CD_recuperardatos = Nothing
            Dim lista As New List(Of Integer)
            Dim cadenasql As String = ""
            If descripcionp = "0" Then 'no tiene padre
                cadenasql = "select * from seg_menu where men_Id_MenuPadre=0 and men_descripcion= '" & descripcionh & "'"
            Else
                cadenasql = cadenasql & "select * from seg_menu where men_Id_MenuPadre=(select men_Id from seg_Menu where men_Descripcion='" & descripcionp & "')"
                cadenasql = cadenasql & " and men_descripcion='" & descripcionh & "' "
            End If
            conectar()
            dr = fun_ExecuteReader(cadenasql)
            If dr.HasRows Then
                While dr.Read
                    Dim int_cod_padre As Integer
                    int_cod_padre = dr("men_id_MenuPadre")
                    lista.Add(int_cod_padre)
                End While
            End If
            Return lista
        Catch ex As Exception
            CD_recuperardatos = Nothing
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
    Function fun_CD_Cargar_accesos(ByVal cbo_perfil As String, ByVal int_cod_padre As Integer) As List(Of cls_CE_acceso)

        Try
            fun_CD_Cargar_accesos = Nothing
            conectar()
            dr = fun_ExecuteReader("sp_selpermisospadre", cbo_perfil, int_cod_padre)
            'dgv_accesos.Rows.Clear() 'limpio el data grid
            Dim lista As New List(Of cls_CE_acceso)

            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_acceso

                    obj.Acc_id = IIf(dr("acc_id") Is DBNull.Value, 0, dr("acc_id"))
                    obj.Men_Id = IIf(dr("men_id") Is DBNull.Value, 0, dr("men_id"))
                    obj.Per_Id = IIf(dr("per_id") Is DBNull.Value, 0, dr("per_id"))
                    obj.Men_nombreFrm = IIf(dr("men_nombreFrm") Is DBNull.Value, "", dr("men_nombreFrm"))
                    obj.Men_descripcion = IIf(dr("men_Descripcion") Is DBNull.Value, "", dr("men_Descripcion"))
                    obj.Acc_estado = IIf(dr("acc_estado") Is DBNull.Value, "", dr("acc_estado"))
                    lista.Add(obj)
                End While
            End If
            Return lista
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_CD_Cargar_accesos = Nothing
        Finally
            desconectar()
        End Try
    End Function
    Function fun_CD_grabar_acceso(ByVal c_codigo As Integer, ByVal cbo_perfil As Integer, ByVal c_m_codigo As Integer, ByVal estado As String, ByVal c_men_accion As Integer) As Boolean
        Try
            fun_CD_grabar_acceso = False
            conectar()
            fun_ExecuteNonQuery("sp_mant_accesos", c_codigo, cbo_perfil, c_m_codigo, estado, c_men_accion)
            Return True

        Catch ex As Exception
            fun_CD_grabar_acceso = False
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Function
End Class
