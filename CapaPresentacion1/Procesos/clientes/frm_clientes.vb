Imports CapaEntidad
Imports CapaNegocios


Public Class frm_clientes
    Dim pos_id As Integer = 0
    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_recuperar() = False Then
                MsgBox("error al cragar datos")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_recuperar() As Boolean
        Try
            fun_recuperar = False

            Dim lista As New List(Of cls_CE_clientes)
            Dim obj As New cls_CN_clientes
            lista = obj.fun_CN_recuperar(txt_buscar.Text)
            If lista Is Nothing Then
                Exit Function
            End If
            dgv_datos.Rows.Clear()

            For i = 0 To lista.Count - 1
                dgv_datos.Rows.Add(lista(i).PER_ID, lista(i).PER_IDENTIFICACION, lista(i).PER_NOMBRES, lista(i).PER_ESTADO)
            Next

            fun_recuperar = True
        Catch ex As Exception
            fun_recuperar = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            If fun_recuperar() = False Then
                MsgBox("no se encontraron personas")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim frm As New frm_mantClientes
        frm.txt_id.Text = 0
        frm.ShowDialog()
        fun_recuperar()
    End Sub

    Private Sub dgv_datos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellDoubleClick
        Try

            If e.RowIndex >= 0 Then
                Dim frm As New frm_mantClientes
                frm.txt_id.Text = dgv_datos.Rows(e.RowIndex).Cells(pos_id).Value
                frm.ShowDialog()
                fun_recuperar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class