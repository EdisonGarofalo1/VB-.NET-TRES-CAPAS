Imports CapaEntidad
Imports CapaNegocios
Public Class frm_mantProductos
    Dim bandera As Boolean
    Private Sub frm_mantProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_recupera_combo() = False Then
                MsgBox("no se pudo crgar combo")
                Exit Sub
            End If
            If txt_id.Text <> 0 Then

                If fun_recupera_proxcodigo() = False Then
                    MsgBox("error al cargar datos")


                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_recupera_combo() As Boolean
        Try
            fun_recupera_combo = False
            bandera = False
            Dim tabla As New DataTable

            Dim obj As New cls_CN_productos
            tabla = obj.fun_CN_carg_categoria
            If tabla Is Nothing Then
                Exit Function
            End If
            cbo_categoría.DataSource = tabla
            cbo_categoría.DisplayMember = "CAT_DESCRIPCION"
            cbo_categoría.ValueMember = "CAT_ID"

            fun_recupera_combo = True
            bandera = True
        Catch ex As Exception
            bandera = False
            fun_recupera_combo = False
            MsgBox(ex.Message)
        End Try
    End Function


    Function fun_recupera_proxcodigo() As Boolean
        Try
            fun_recupera_proxcodigo = False

            Dim obj As New cls_CN_productos
            Dim objpro As New cls_CE_producto
            objpro = obj.fun_CN_recuperarXid(txt_id.Text)
            If objpro Is Nothing Then
                Exit Function
            End If
            With objpro


                cbo_categoría.SelectedValue = .CAT_ID
                txt_codigo.Text = .PRO_CODIGO
                txt_descripcion.Text = .PRO_DESCRIPCION
                txt_precio.Text = .PRO_PRECIO
                chk_estado.Checked = False
                chk_iva.Checked = .PRO_LLEVA_IVA
                If .PRO_ESTADO = "A" Then
                    chk_estado.Checked = True
                End If

            End With
            fun_recupera_proxcodigo = True
        Catch ex As Exception
            fun_recupera_proxcodigo = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If fun_grabar() = True Then
                MsgBox(" ok ")
                Me.Close()

            Else
                MsgBox("error al grabar")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_grabar() As Boolean
        Try
            fun_grabar = False
            Dim obj As New cls_CE_producto
            obj.PRO_ID = txt_id.Text
            obj.PRO_CODIGO = txt_codigo.Text
            obj.PRO_DESCRIPCION = txt_descripcion.Text
            obj.PRO_PRECIO = txt_precio.Text
            obj.PRO_LLEVA_IVA = chk_iva.Checked
            obj.PRO_ESTADO = "I"
            obj.CAT_ID = cbo_categoría.SelectedValue
            If chk_estado.Checked = True Then
                obj.PRO_ESTADO = "A"
            End If

            Dim objp As New cls_CN_productos
            fun_grabar = objp.fun_CN_grabar(obj)
        Catch ex As Exception
            fun_grabar = False
            MsgBox(ex.Message)
        End Try
    End Function
End Class