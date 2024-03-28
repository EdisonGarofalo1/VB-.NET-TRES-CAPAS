Imports CapaEntidad
Imports CapaNegocios
Public Class frm_compras
    Implements IArticulo
    Dim int_id_fila As Integer
    Dim lng_id_factura As Long
    Dim c_id As Integer = 0
    Dim c_codigo As Integer = 1
    Dim c_descripcion As Integer = 3
    Dim c_cantidad As Integer = 4
    Dim c_precio As Integer = 5
    Dim c_total As Integer = 6
    Dim c_llevaIva As Integer = 7
    Dim c_Iva As Integer = 8
    Dim id_usuario As Integer = 0
    Dim list_cabezera As New cls_CE_facturas
    Dim list_detalle As New List(Of cls_CE_detalleFactura)
    Public Function cargarDatagrid(Art As E_Articulo) As Boolean Implements IArticulo.cargarDatagrid
        Try
            dgv_datos(c_codigo, int_id_fila).Value = Convert.ToString(Art.codigo)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub frm_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' cargarTipoDocumento()
            sub_generarLineas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_identificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_identificacion.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If funRecuperarUsuario(txt_identificacion.Text) = False Then
                    MsgBox("El usuario no Existe..")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_numDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numDoc.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If fun_recuperarFactura(txt_numDoc.Text) = False Then
                    lng_id_factura = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub limpiar()
        '//list_cabezera.Clear()
        list_detalle.Clear()
        txt_numDoc.Text = ""
        txt_direccion.Text = ""
        txt_identificacion.Text = ""
        txt_nombres.Text = ""
        txt_telefono.Text = ""
        txt_subTotal.Text = ""
        txt_iva.Text = ""
        txt_total.Text = ""
        dgv_datos.Rows.Clear()
        lng_id_factura = 0
        sub_generarLineas()
        chk_estado.Checked = True
        dap_fechaMov.Text = Now
        'sub_generarLineas()

    End Sub
    Function fun_recuperarFactura(ByVal numdoc As String) As Boolean
        Try
            fun_recuperarFactura = False

            If fun_recuperaCabecera(txt_numDoc.Text) = False Then
                limpiar()
                Exit Function
            Else
                If fun_recuperarDetalle(lng_id_factura) = False Then
                    limpiar()
                    Exit Function
                End If
            End If
            fun_recuperarFactura = True
        Catch ex As Exception
            fun_recuperarFactura = False
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_recuperaCabecera(ByVal num As String) As Boolean
        Try
            fun_recuperaCabecera = False
            Dim obj As New cls_CE_facturas
            Dim objc As New cls_CN_compras

            obj = objc.fun_recuperar_cabezera(num)
            If obj Is Nothing Then
                Exit Function
            End If
            With obj

                lng_id_factura = .CABMOV_ID
                txt_identificacion.Text = .PER_IDENTIFICACION
                txt_nombres.Text = .PER_NOMBRES
                txt_direccion.Text = .PER_DIRECCION
                txt_telefono.Text = .PER_TELEFONO
                txt_subTotal.Text = .CABMOV_BASE_IMPONIBLE
                txt_iva.Text = .CABMOV_IVA
                txt_total.Text = .CABMOV_VALOR_FINAL
                dap_fechaMov.Text = .CABMOV_FECHA
            End With

            fun_recuperaCabecera = True
        Catch ex As Exception
            fun_recuperaCabecera = False
            MsgBox(ex.Message)
        End Try
    End Function

    Function fun_recuperarDetalle(ByVal id_cb As String) As Boolean
        Try
            fun_recuperarDetalle = False
            Dim lista As New List(Of cls_CE_detalleFactura)
            Dim obj As New cls_CN_compras
            lista = obj.fun_CN_recuperar_detalles(id_cb)

            If lista Is Nothing Then
                Exit Function
            End If
            dgv_datos.Rows.Clear()
            For i = 0 To lista.Count - 1
                dgv_datos.Rows.Add(lista(i).PRO_ID, lista(i).PRO_CODIGO, "?", lista(i).PRO_DESCRIPCION, lista(i).DET_CANTIDAD, Format(lista(i).PRO_PRECIO), lista(i).DET_BASE_IMPONIBLE, lista(i).PRO_LLEVA_IVA, lista(i).DET_IVA)
            Next
            fun_recuperarDetalle = True
        Catch ex As Exception
            fun_recuperarDetalle = False
            MsgBox(ex.Message)

        End Try
    End Function

    Function funRecuperarUsuario(ByVal numdoc As String) As Boolean
        Try
            funRecuperarUsuario = False
            Dim obj As New cls_CE_clientes
            Dim objc As New cls_CN_compras
            obj = objc.fun_CN_recuperar_usuario(numdoc)
            If obj Is Nothing Then
                Exit Function
            End If

            txt_nombres.Text = obj.PER_NOMBRES
            txt_direccion.Text = obj.PER_DIRECCION
            txt_telefono.Text = obj.PER_TELEFONO
            id_usuario = obj.PER_ID
            funRecuperarUsuario = True

        Catch ex As Exception
            funRecuperarUsuario = False
            MsgBox(ex.Message)


        End Try
    End Function

    Sub sub_generarLineas()
        Try
            Dim tamanio As Integer
            tamanio = fun_Num_LineasFactura()

            For i = 1 To tamanio
                dgv_datos.Rows.Add("", "", "?")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function fun_Num_LineasFactura() As Integer
        Try
            fun_Num_LineasFactura = 0
            Dim valor As Integer = 0
            Dim obj As New cls_CN_compras
            valor = CInt(obj.fun_CN_lineas)

            Return valor
        Catch ex As Exception
            Return 0
            MsgBox(ex.Message)
        End Try
    End Function





    Private Sub dgv_datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellContentClick
        Try
            If lng_id_factura = 0 Then
                If dgv_datos.RowCount > 0 Then

                    If dgv_datos.Columns(e.ColumnIndex).Name = "ayuda" Then

                        int_id_fila = e.RowIndex
                        Dim frm As New frm_AyudaProductos
                        frm.CargarArticulo = Me
                        frm.ShowDialog()
                    End If
                      End If
                End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_datos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellValueChanged
        Try
            Dim Num_fila As Integer = 0
            If lng_id_factura = 0 Then

                If dgv_datos.RowCount > 0 Then
                    Num_fila = e.RowIndex 'capturo lam posicion de la fila
                    If dgv_datos.Columns(e.ColumnIndex).Name = "CODIGO" Then
                        If fun_cargarProducto(dgv_datos.Rows(Num_fila).Cells("CODIGO").Value, Num_fila) = False Then

                            'limpiar las celdas delas fila accionada
                            '  MsgBox("" & dgv_datos.Rows(Num_fila).Cells("CODIGO").Value)
                        End If

                    End If
                    If dgv_datos.Columns(e.ColumnIndex).Name = "CANTIDAD" Or dgv_datos.Columns(e.ColumnIndex).Name = "PRECIO" Then
                        MUltiplicarItem(Num_fila)
                        sumarItem()

                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub MUltiplicarItem(ByVal fila As Integer)
        Dim IVA As Double
        Dim cantidad As Double
        Dim precio As Double
        cantidad = CDbl(dgv_datos.Rows(fila).Cells(c_cantidad).Value)
        precio = CDbl(dgv_datos.Rows(fila).Cells(c_precio).Value)
        dgv_datos.Rows(fila).Cells(c_total).Value = Format(precio * cantidad, formatodecimal)

        If dgv_datos.Rows(fila).Cells(c_total).Value = True Then
            IVA = CDbl(dgv_datos.Rows(fila).Cells(c_total).Value) * 0.12
            dgv_datos.Rows(fila).Cells(c_Iva).Value = IVA
        End If
    End Sub

    Sub sumarItem()
        Dim subtotal As Double = 0
        Dim iva As Double = 0
        Dim total As Double = 0
        For fila = 0 To dgv_datos.RowCount - 1
            If Val(dgv_datos.Rows(fila).Cells(c_id).Value) > 0 Then


                subtotal = subtotal + CDbl(dgv_datos.Rows(fila).Cells(c_total).Value)
                iva = iva + CDbl(dgv_datos.Rows(fila).Cells(c_Iva).Value)
            End If
        Next
        total = iva + subtotal
        txt_subTotal.Text = subtotal
        txt_iva.Text = iva
        txt_total.Text = total
    End Sub

    Function fun_cargarProducto(ByVal codigo As String, ByVal fila As Integer) As Boolean
        Try
            fun_cargarProducto = False
            Dim lista As New List(Of cls_CE_producto)
            Dim obj As New cls_CN_compras
            lista = obj.fun_CN_carProducto(codigo)
            If lista Is Nothing Then
                Exit Function
            End If
            For i = 0 To lista.Count - 1
                dgv_datos.Rows(fila).Cells(c_id).Value = lista(i).PRO_ID
                dgv_datos.Rows(fila).Cells(c_descripcion).Value = lista(i).PRO_DESCRIPCION
                dgv_datos.Rows(fila).Cells(c_cantidad).Value = 1
                dgv_datos.Rows(fila).Cells(c_precio).Value = lista(i).PRO_PRECIO
                dgv_datos.Rows(fila).Cells(c_llevaIva).Value = lista(i).PRO_LLEVA_IVA
            Next

            fun_cargarProducto = True


        Catch ex As Exception
            fun_cargarProducto = False



        End Try

    End Function


    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()

    End Sub
    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If MessageBox.Show("¿Desea realmente guardar la factura?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If verificacion() = False Then
                    Exit Sub
                Else
                    If lng_id_factura = 0 Then
                        Dim obj As New cls_CN_compras
                        If llenar_lista() = False Then
                            Exit Sub
                        End If

                        If obj.fun_CN_Grabar(list_cabezera, list_detalle) = False Then
                                Exit Sub
                            Else
                                MsgBox("Factura Guardada con exitos")

                            End If
                        Else
                            MsgBox("Factura Registrada")

                    End If



                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function verificacion() As Boolean
        Try
            verificacion = False
            If txt_numDoc.Text = "" Then
                MsgBox("llene campo documento")
                Exit Function
            End If
            If chk_validar.Checked = True Then

                If fun_validacedula(txt_identificacion.Text) = False Then
                MsgBox("cedula incorrecta")
                Exit Function
            End If
                MsgBox("cedula valida")
            End If
            If txt_nombres.Text = "" Then
                MsgBox("ingrese campo nombre")
                Exit Function
            End If

            If txt_total.Text = "" Or txt_total.Text = "0.00" Then
                MsgBox("ingrese pproductos")
                Exit Function
            End If
            verificacion = True

        Catch ex As Exception
            verificacion = False

            MsgBox(ex.Message)

        End Try
    End Function



    Function llenar_lista() As Boolean
        Try
            llenar_lista = False

            Dim obj As New cls_CE_facturas
            With obj
                .PER_ID = id_usuario
                .CABMOV_ID = lng_id_factura
                .CABMOV_NUM_DOC = txt_numDoc.Text
                .PER_IDENTIFICACION = txt_identificacion.Text
                .PER_NOMBRES = txt_nombres.Text
                .PER_DIRECCION = txt_direccion.Text
                .PER_TELEFONO = txt_telefono.Text
                .CABMOV_BASE_IMPONIBLE = txt_subTotal.Text
                .CABMOV_IVA=txt_iva.Text
                .CABMOV_VALOR_FINAL = txt_total.Text
                .CABMOV_FECHA = dap_fechaMov.Text
                .USUARIO = g_str_id_usuario
            End With
            list_cabezera = obj
            'list_cabezera.Add(obj)

            If dgv_datos.RowCount > 0 Then


                For i = 0 To dgv_datos.RowCount - 1
                    If dgv_datos.Rows(i).Cells(c_codigo).Value <> "" Then


                        Dim obj_d As New cls_CE_detalleFactura
                        With obj_d

                            .CAT_ID = dgv_datos.Rows(i).Cells(c_id).Value
                            .PRO_DESCRIPCION = dgv_datos.Rows(i).Cells(c_descripcion).Value
                            .DET_CANTIDAD = dgv_datos.Rows(i).Cells(c_cantidad).Value
                            .PRO_PRECIO = CDbl(dgv_datos.Rows(i).Cells(c_precio).Value)
                            .PRO_LLEVA_IVA = dgv_datos.Rows(i).Cells(c_llevaIva).Value
                            .PRO_CODIGO = dgv_datos.Rows(i).Cells(c_codigo).Value
                            .DET_BASE_IMPONIBLE = CDbl(dgv_datos.Rows(i).Cells(c_total).Value)
                            .DET_IVA = CDbl(dgv_datos.Rows(i).Cells(c_Iva).Value)
                            .DET_TOTAL = CDbl(dgv_datos.Rows(i).Cells(c_total).Value)

                        End With
                        list_detalle.Add(obj_d)
                    End If
                Next
            End If
            llenar_lista = True
        Catch ex As Exception
            llenar_lista = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_validar.CheckedChanged

    End Sub

    Private Sub btn_ayuda_Click(sender As Object, e As EventArgs) Handles btn_ayuda.Click
        Try
            g_str_cedula = ""
            frm_buscar_cliente.ShowDialog()
            If g_str_cedula <> "" Then
                txt_identificacion.Text = g_str_cedula
                txt_identificacion_KeyPress(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_numDoc_TextChanged(sender As Object, e As EventArgs) Handles txt_numDoc.TextChanged

    End Sub
End Class