Imports CapaEntidad
Imports CapaNegocios

Public Class frm_variablesSistema
    Dim pos_id As Integer = 0
    Dim pos_cod As Integer = 1
    Dim pos_descripcion As Integer = 2
    Dim pos_estado As Integer = 3
    Dim pos_accion As Integer = 4
    Private Sub frm_variablesSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If recuperar(txt_buscar.Text) = False Then
                MsgBox("No existe datos")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            dgv_datos.Rows.Add("", "", "", 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            Dim fila As Integer
            Dim valor As Integer
            If dgv_datos.RowCount > 0 Then
                fila = dgv_datos.RowCount - 1
                valor = Val(dgv_datos(pos_id, fila).Value)
                If valor = 0 Then
                    dgv_datos.Rows.RemoveAt(fila)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try

            If recuperar(txt_buscar.Text) = False Then
                MsgBox("no se encontro resultado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function recuperar(buscar) As Boolean
        Try
            recuperar = False
            dgv_datos.Rows.Clear()
            Dim obj As New cls_CN_variables_sistema
            Dim lista As New List(Of cls_CE_cab_parametrica)
            lista = obj.fun_CN_recuperar(buscar)
            If lista Is Nothing Then
                Exit Function
            End If
            Dim n As Integer
            n = lista.Count - 1
            For i = 0 To n
                dgv_datos.Rows.Add(lista(i).CABP_ID, lista(i).CABP_CODIGO, lista(i).CABP_DESCRIPCION, lista(i).CABP_ESTADO)
            Next
            recuperar = True
        Catch ex As Exception
            recuperar = False
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
                    recuperar(txt_buscar.Text)
                Else
                    MsgBox("Error al grabar")
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_grabar() As Boolean
        Try
            fun_grabar = False

            Dim obj As New cls_CN_variables_sistema
            Dim lista As New List(Of cls_CE_cab_parametrica)

            For i = 0 To dgv_datos.RowCount - 1
                If Val(dgv_datos(pos_accion, i).Value) > 0 Then
                    Dim objcb As New cls_CE_cab_parametrica

                    If dgv_datos(pos_accion, i).Value = 1 Then
                        objcb.CABP_ID = 0
                    Else
                        objcb.CABP_ID = dgv_datos(pos_id, i).Value
                    End If
                    objcb.CABP_CODIGO = dgv_datos(pos_cod, i).Value
                    objcb.CABP_DESCRIPCION = dgv_datos(pos_descripcion, i).Value
                    objcb.CABP_ESTADO = dgv_datos(pos_estado, i).Value
                    objcb.ACCION = dgv_datos(pos_accion, i).Value
                    lista.Add(objcb)
                End If
            Next

            fun_grabar = obj.fun_CN_grabar(lista)


        Catch ex As Exception
            fun_grabar = False

            MsgBox(ex.Message)
        End Try

    End Function


    Function fun_validar() As Boolean
        Try
            fun_validar = False

            'Valida Detalle de Productos
            Dim i As Integer
            For i = 0 To dgv_datos.RowCount - 1
                If (dgv_datos.Rows(i).Cells(pos_cod).Value) = "" Or (dgv_datos.Rows(i).Cells(pos_descripcion).Value = "") Then
                    MsgBox("Ingrese los datos en la fila:  [" & i + 1 & "] ", vbInformation + vbOKOnly, "Sistema")
                    Exit Function
                End If
            Next i
            fun_validar = True
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_validar = False
        End Try
    End Function

    Private Sub dgv_datos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellValueChanged
        Try
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
End Class