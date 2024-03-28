Imports CapaEntidad
Imports CapaNegocios
Public Class frm_productos

    Dim pos_id As Integer = 0

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            If fun_recuperar() = False Then
                MsgBox("no se pudo cargar los datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Function fun_recuperar() As Boolean
        Try
            fun_recuperar = False

            Dim lista As New List(Of cls_CE_producto)
            Dim obj As New cls_CN_productos

            dgv_datos.Rows.Clear()
            lista = obj.fun_CN_recuperar_productos(txt_buscar.Text)

            If lista Is Nothing Then
                Exit Function
            End If

            For i = 0 To lista.Count - 1
                dgv_datos.Rows.Add(lista(i).PRO_ID, lista(i).PRO_CODIGO, lista(i).PRO_DESCRIPCION, lista(i).PRO_PRECIO, lista(i).PRO_LLEVA_IVA, lista(i).PRO_ESTADO)
            Next
            Return True
        Catch ex As Exception
            fun_recuperar = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub frm_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_recuperar() = False Then
                MsgBox("error al cargar datos")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            Dim frm As New frm_mantProductos
            frm.txt_id.Text = 0
            frm.chk_estado.Checked = True
            frm.ShowDialog()

            fun_recuperar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgv_datos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellDoubleClick
        Try
            Dim frm As New frm_mantProductos
            frm.txt_id.Text = dgv_datos.Rows(e.RowIndex).Cells("ID").Value
            frm.ShowDialog()
            fun_recuperar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class