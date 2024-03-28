Imports CapaEntidad
Imports CapaNegocios

Public Class frm_tipoMovimiento
    Private Sub frm_tipoMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_cargar_tipo() = False Then
                MsgBox("no se pudo cargar los datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function fun_cargar_tipo() As Boolean
        Try
            fun_cargar_tipo = False

            Dim obj As New cls_CN_tipo_movimiento
            Dim lista As New List(Of cls_CE_tipo_movimiento)

            lista = obj.fun_CN_carga_movimiento(txt_buscar.Text)

            If lista Is Nothing Then
                Exit Function
            End If
            dgv_datos.Rows.Clear()

            For i = 0 To lista.Count - 1
                dgv_datos.Rows.Add(lista(i).TIPMOV_ID, lista(i).TIPMOV_DESCRIPCION, lista(i).TIPMOV_ESTADO)
            Next

            fun_cargar_tipo = True
        Catch ex As Exception
            fun_cargar_tipo = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            If fun_cargar_tipo() = False Then
                MsgBox("no se encontaron resultados")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            Dim frm As New frm_MantMovimiento
            frm.txt_codigo.Text = 0
            frm.ShowDialog()
            fun_cargar_tipo()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgv_datos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellDoubleClick
        Try
            Dim frm As New frm_MantMovimiento
            frm.txt_codigo.Text = dgv_datos.Rows(e.RowIndex).Cells("per_id").Value
            frm.ShowDialog()
            fun_cargar_tipo()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class