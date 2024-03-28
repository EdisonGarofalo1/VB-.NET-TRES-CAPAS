Imports CapaEntidad
Imports CapaNegocios
Public Class frm_categoria
    Dim pos_id As Integer = 0
    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            If fun_recuperarDatos() = False Then
                MsgBox("no se encontraron datos")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_recuperarDatos() As Boolean
        Try
            fun_recuperarDatos = False
            dgv_datos.Rows.Clear()
            Dim lista As New List(Of cls_CE_categorias)
            Dim obj As New cls_CN_categorias

            lista = obj.fun_CN_recuperar_categoria(txt_buscar.Text)
            For i = 0 To lista.Count - 1
                dgv_datos.Rows.Add(lista(i).CAT_ID, lista(i).CAT_DESCRIPCION, lista(i).CAT_ESTADO)
            Next
            If lista Is Nothing Then
                Exit Function
            End If
            fun_recuperarDatos = True
        Catch ex As Exception
            fun_recuperarDatos = False
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub frm_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_recuperarDatos() = False Then
                MsgBox("No existe datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgv_datos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                Dim frm As New frm_Mantcategoria
                frm.txt_codigo.text = dgv_datos.Rows(e.RowIndex).Cells(pos_id).Value
                frm.ShowDialog()
                fun_recuperarDatos()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try

            Dim frm As New frm_Mantcategoria
            frm.txt_codigo.text = 0
            frm.ShowDialog()
                fun_recuperarDatos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class