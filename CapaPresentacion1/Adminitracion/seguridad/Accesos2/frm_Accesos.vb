Imports Capa_Entidad
Imports Capa_Negocio
Public Class frm_Accesos
    Dim bool_comboperfil As Boolean
    Private dataSetArbol As System.Data.DataSet
    'Dim bool_cargarcombo As Boolean
    Dim int_cod_padre As Integer


    Dim c_codigo As Integer = 0
    Dim c_m_codigo As Integer = 1
    Dim c_per_codigo As Integer = 2
    Dim c_descripcion As Integer = 3
    Dim c_formulario As Integer = 4
    Dim c_men_estado As Integer = 5
    Dim c_men_accion As Integer = 6

    Private Sub frm_Accesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarTipoPerfil()
                CargarDatos()
                CrearNodosDelPadre(0, Nothing)


        Catch ex As Exception

        End Try
    End Sub

    Sub cargarTipoPerfil()
        Try
            Dim obj As New cls_CN_combos
            Dim lista As New List(Of cls_CE_perfiles)
            lista = obj.CN_recuperarTipoPerfil
            Dim n As Integer
            n = lista.Count
            If n >= 0 Then
                cbo_perfil.DataSource = lista
                cbo_perfil.DisplayMember = "NOMBRE"
                cbo_perfil.ValueMember = "CODIGO"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CrearNodosDelPadre(ByVal indicePadre As Integer, ByVal nodePadre As TreeNode)
        Try
            Dim dataViewHijos As New DataView

            ' Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
            dataViewHijos = New DataView(dataSetArbol.Tables("TablaArbol"))

            dataViewHijos.RowFilter = dataSetArbol.Tables("TablaArbol").Columns("IdentificadorPadre").ColumnName + " = " + indicePadre.ToString()

            ' Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
            For Each dataRowCurrent As DataRowView In dataViewHijos

                Dim nuevoNodo As New TreeNode
                nuevoNodo.Text = dataRowCurrent("NombreNodo").ToString().Trim()

                ' si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
                ' del primer nivel que no dependen de otro nodo.
                If nodePadre Is Nothing Then
                    Tvw_Menu.Nodes.Add(nuevoNodo)
                Else
                    ' se añade el nuevo nodo al nodo padre.
                    nodePadre.Nodes.Add(nuevoNodo)
                End If

                ' Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
                CrearNodosDelPadre(Int32.Parse(dataRowCurrent("IdentificadorNodo").ToString()), nuevoNodo)
            Next dataRowCurrent

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CargarDatos()
        Try
            Dim tablaArbol As New DataTable

            dataSetArbol = New DataSet("DataSetArbol")
            tablaArbol = dataSetArbol.Tables.Add("TablaArbol")
            tablaArbol.Columns.Add("NombreNodo", GetType(String))
            tablaArbol.Columns.Add("IdentificadorNodo", GetType(Integer))
            tablaArbol.Columns.Add("IdentificadorPadre", GetType(Integer))

            Dim lista As New List(Of cls_CE_menu)
            lista = Nothing
            Dim obj As New cls_CN_menu
            lista = obj.CN_fun_cargarMenu()
            Tvw_Menu.Nodes.Clear()

            Dim i As Integer
            For i = 0 To lista.Count - 1

                InsertarDataRow(lista.Item(i).DESCRIPCION_MENU, lista.Item(i).ID_MENU, lista.Item(i).MENU_ID_MENU_PADRE)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub InsertarDataRow(ByVal column1 As String, ByVal column2 As Integer, ByVal column3 As Integer)
        Dim nuevaFila As DataRow
        nuevaFila = dataSetArbol.Tables("TablaArbol").NewRow()
        nuevaFila("NombreNodo") = column1
        nuevaFila("IdentificadorNodo") = column2
        nuevaFila("IdentificadorPadre") = column3
        dataSetArbol.Tables("TablaArbol").Rows.Add(nuevaFila)
    End Sub

    Private Sub Tvw_Menu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Tvw_Menu.AfterSelect
        Try
            Dim des_nodopadre, des_nodohijo As String
            If e.Node IsNot Nothing Then
                If e.Node.Parent IsNot Nothing Then
                    des_nodopadre = Trim(e.Node.Parent.Text)
                Else
                    des_nodopadre = 0
                End If
                des_nodohijo = Trim(e.Node.Text)
                'MsgBox(des_nodopadre & " " & des_nodohijo)

                recuperardatos(des_nodopadre, des_nodohijo)
                Cargar_accesos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub recuperardatos(ByVal descripcionp As String, ByVal descripcionh As String)
        Try

            Dim lista As New List(Of cls_CE_menu)
            lista = Nothing
            Dim obj As New cls_CN_menu
            lista = obj.CN_fun_recuperarMenu(descripcionp, descripcionh)
            If lista.Count >= 0 Then
                Dim i As Integer
                For i = 0 To lista.Count - 1
                    int_cod_padre = lista.Item(i).MENU_ID_MENU_PADRE
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Cargar_accesos()

        Try
            Dim estado As Boolean

            Dim lista As New List(Of cls_CE_accesos)
            lista = Nothing
            Dim obj As New cls_CN_accesos
            lista = obj.CN_fun_cargarDatos(cbo_perfil.SelectedValue, int_cod_padre)
            dgv_accesos.Rows.Clear()

            Dim i As Integer
            For i = 0 To lista.Count - 1
                If lista.Item(i).ESTADO_ACCESO = "E" Then
                    estado = False
                Else
                    estado = True
                End If
                dgv_accesos.Rows.Add(lista.Item(i).ID_ACCESO, lista.Item(i).FK_ID_MENU, lista.Item(i).FK_ID_PERFIL, lista.Item(i).DESCRIPCION_MENU,
                                     lista.Item(i).MENU_NOMBRE_FORM, estado)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub dgv_accesos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_accesos.CellValueChanged
        Try
            Dim intcant As String
            intcant = dgv_accesos.RowCount
            If dgv_accesos.RowCount - 1 >= 0 Then

                If Val(dgv_accesos.Rows(e.RowIndex).Cells("id_permisos").Value) = 0 Then
                    dgv_accesos.Rows(e.RowIndex).Cells("Accion").Value = 1
                Else
                    dgv_accesos.Rows(e.RowIndex).Cells("Accion").Value = 2
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Grabar_Click(sender As Object, e As EventArgs) Handles btn_Grabar.Click
        Try
            If dgv_accesos.Rows.Count > 0 Then
                If fun_grabar_accesos() = True Then
                    MsgBox("La operación se realizó con éxito")
                    Cargar_accesos()
                Else
                    MsgBox("Error al grabar")
                End If
            Else
                MsgBox("No hay Datos Para Grabar")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function fun_grabar_accesos()
        Try
            fun_grabar_accesos = False

            Dim obj As New cls_CN_accesos
            Dim estado As String

            With dgv_accesos
                For fila = 0 To .RowCount - 1
                    If Val(dgv_accesos(c_men_accion, fila).Value) > 0 Then
                        If dgv_accesos(c_men_estado, fila).Value = True Then
                            estado = "A"
                        Else
                            estado = "E"
                        End If
                        fun_grabar_accesos = obj.CN_fun_grabaraccesos(Val(dgv_accesos(c_codigo, fila).Value), Val(cbo_perfil.SelectedValue),
                                                Val(dgv_accesos(c_m_codigo, fila).Value), estado, Val(dgv_accesos(c_men_accion, fila).Value))

                    End If
                Next
            End With
            fun_grabar_accesos = True
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_grabar_accesos = False

        End Try
    End Function

    Private Sub cbo_perfil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_perfil.SelectedIndexChanged
        Try
            If bool_comboperfil = True Then
                dgv_accesos.Rows.Clear()
                CargarDatos()
                CrearNodosDelPadre(0, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class