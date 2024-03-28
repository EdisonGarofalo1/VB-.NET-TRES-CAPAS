Imports CapaEntidad
Imports CapaNegocios

Public Class frm_buscar_cliente
    Private Sub frm_buscar_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_recuperar(txt_buscar.Text) = False Then
                MsgBox("error al cragar datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_recuperar(buscar As String) As Boolean
        Try
            fun_recuperar = False

            Dim lista As New List(Of cls_CE_clientes)
            Dim obj As New cls_CN_clientes
            lista = obj.fun_CN_recuperar(buscar)
            If lista Is Nothing Then
                Exit Function
            End If
            dgv_datos.Rows.Clear()

            For i = 0 To lista.Count - 1
                dgv_datos.Rows.Add(lista(i).PER_IDENTIFICACION, lista(i).PER_NOMBRES, lista(i).PER_ESTADO)
            Next
            fun_recuperar = True
        Catch ex As Exception
            fun_recuperar = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            If fun_recuperar(txt_buscar.Text) = False Then
                MsgBox("no se encontraron personas")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellContentClick

    End Sub

    Private Sub dgv_datos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                Dim frm As New frm_mantClientes
                g_str_cedula = dgv_datos.Rows(e.RowIndex).Cells(0).Value
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class