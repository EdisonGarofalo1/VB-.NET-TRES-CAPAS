Imports CapaEntidad
Imports CapaNegocios
Public Class frm_AyudaProductos
    Public Property CargarArticulo() As IArticulo
    Private Sub frm_AyudaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_recuperaDatos() = False Then
                MsgBox("no se pudo cargar datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged

        Try
            If fun_recuperaDatos() = False Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_recuperaDatos() As Boolean
        Try
            fun_recuperaDatos = False
            Dim lista As New List(Of cls_CE_producto)

            Dim objl As New cls_CN_compras
            lista = objl.cls_CN_cargarproducto(txt_buscar.Text)
            If lista Is Nothing Then
                Exit Function
            End If
            dgv_datos.Rows.Clear()
            For i = 0 To lista.Count - 1
                dgv_datos.Rows.Add(lista(i).PRO_CODIGO, lista(i).PRO_DESCRIPCION, lista(i).PRO_PRECIO)

            Next
            fun_recuperaDatos = True
        Catch ex As Exception
            fun_recuperaDatos = False
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub dgv_datos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellDoubleClick
        Try
            'Si el row en el que hicimos doble click es el encabezado del DataGridView, nos retornamos.
            If e.RowIndex = -1 Then
                Return
            End If

            Dim row As DataGridViewRow = dgv_datos.Rows(e.RowIndex)
            Dim item As New E_Articulo()

            item.codigo = Convert.ToString(row.Cells("codigo").Value)


            'Si no existe la función llamador para nuestro formulario 
            'nos retornamos sin hacer ninguna accion
            If CargarArticulo Is Nothing Then
                Return
            End If
            CargarArticulo.cargarDatagrid(item)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class