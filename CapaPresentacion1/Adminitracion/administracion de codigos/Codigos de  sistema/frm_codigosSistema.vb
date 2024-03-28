Imports CapaNegocios
Imports CapaEntidad

Public Class frm_codigosSistema
    Dim pos_id As Integer = 0
    Dim pos_cod As Integer = 1
    Dim pos_desc As Integer = 2
    Dim pos_valo As Integer = 3
    Dim pos_estd As Integer = 4
    Dim pos_accion As Integer = 5
    Dim boo_combocargado As Boolean



    Private Sub frm_codigosSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_cargar_variables() = False Then
                MsgBox("no se pudo  cargar datos")
            Else
                fun_recuperar_datos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_recuperar_datos() As Boolean
        Try
            fun_recuperar_datos = False
            Dim lista As New List(Of cls_CE_detalle_parametrica)
            Dim obj As New cls_CN_cad_paramentrica

            lista = obj.fun_CN_carg_dell_parmetrica(cbo_varSistema.SelectedValue)
            dgv_datos.Rows.Clear()
            Dim n As Integer
            n = lista.Count - 1
            For i = 0 To n
                dgv_datos.Rows.Add(lista.Item(i).CABP_ID, lista.Item(i).DETP_CODIGO, lista.Item(i).DETP_DESCRIPCION, lista.Item(i).DETP_VALOR, lista.Item(i).DETP_ESTADO)
            Next

            If n >= 0 Then
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_recuperar_datos = False

        End Try
    End Function
    Function fun_cargar_variables() As Boolean
        Try
            fun_cargar_variables = False
            boo_combocargado = False
            Dim tabla As New DataTable

            Dim obj As New cls_CN_cad_paramentrica
            tabla = obj.fun_CN_carg_variables
            cbo_varSistema.DataSource = tabla
            cbo_varSistema.DisplayMember = "CABP_descripcion"
            cbo_varSistema.ValueMember = "CABP_id"
            fun_cargar_variables = True
            boo_combocargado = True

        Catch ex As Exception
            MsgBox(ex.Message)
            fun_cargar_variables = False
            boo_combocargado = False
        End Try
    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try


            dgv_datos.Rows.Add("", "", "", 0, 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try

            Dim filas As Integer
            Dim valor As Integer
            If dgv_datos.RowCount > 0 Then
                filas = dgv_datos.Rows.Count - 1
                valor = Val(dgv_datos(pos_id, filas).Value)
                If valor = 0 Then
                    dgv_datos.Rows.RemoveAt(filas)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_grabar() As Boolean
        Try
            fun_grabar = False
            Dim fila As Integer
            Dim lista As New List(Of cls_CE_detalle_parametrica)

            For fila = 0 To dgv_datos.RowCount - 1
                If Val(dgv_datos(pos_accion, fila).Value) > 0 Then

                    Dim objdetalle As New cls_CE_detalle_parametrica
                    If (dgv_datos(pos_accion, fila).Value = 1) Then
                        objdetalle.DETP_ID = 0
                    Else
                        objdetalle.DETP_ID = dgv_datos(pos_id, fila).Value

                    End If
                    objdetalle.DET_Accion = Val(dgv_datos(pos_accion, fila).Value)
                    objdetalle.DETP_VALOR = dgv_datos(pos_valo, fila).Value
                    objdetalle.CABP_ID = cbo_varSistema.SelectedValue
                    objdetalle.DETP_ESTADO = dgv_datos(pos_estd, fila).Value
                    objdetalle.DETP_CODIGO = dgv_datos(pos_cod, fila).Value
                    objdetalle.DETP_DESCRIPCION = dgv_datos(pos_desc, fila).Value

                    lista.Add(objdetalle)
                End If
            Next

            If lista Is Nothing Then
                Exit Function
            End If
            Dim obj As New cls_CN_cad_paramentrica
            If obj.fun_CN_guardar(lista) = True Then
                fun_grabar = True
            End If

        Catch ex As Exception
            fun_grabar = False
            MsgBox(ex.Message)
        End Try

    End Function
    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If MsgBox("Registrar Movimiento...?", vbQuestion + vbYesNo, "Sistema") = vbYes Then
                If fun_validar() = False Then
                    Exit Sub
                End If
                If fun_grabar() = True Then
                    MsgBox("La operación se registró con éxito")
                    dgv_datos.Rows.Clear()
                    fun_recuperar_datos()
                Else
                    MsgBox("Error al grabar")
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_varSistema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_varSistema.SelectedIndexChanged
        Try
            If boo_combocargado = True Then
                If fun_recuperar_datos() = False Then
                    MsgBox("No hay registros")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgv_datos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellValueChanged
        Try
            Dim intcant As String
            intcant = dgv_datos.RowCount
            If dgv_datos.RowCount > 0 Then

                If Val(dgv_datos.Rows(e.RowIndex).Cells("ID").Value) = 0 Then
                    dgv_datos.Rows(e.RowIndex).Cells("ACCION").Value = 1
                Else
                    dgv_datos.Rows(e.RowIndex).Cells("ACCION").Value = 2
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function fun_validar() As Boolean
        Try
            fun_validar = False
            For i = 0 To dgv_datos.RowCount - 1
                If (dgv_datos.Rows(i).Cells(pos_cod).Value) = "" Or (dgv_datos.Rows(i).Cells(pos_desc).Value) = "" Then

                    MsgBox("Ingrese los datos en la fila:  [" & i + 1 & "] ", vbInformation + vbOKOnly, "Sistema")
                    Exit Function
                End If

            Next
            fun_validar = True
        Catch ex As Exception
            fun_validar = False
            MsgBox(ex.Message)
        End Try
    End Function
End Class