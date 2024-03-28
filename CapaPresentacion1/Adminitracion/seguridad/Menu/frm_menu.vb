Imports CapaEntidad
Imports CapaNegocios

Public Class frm_menu
    Private dataSetArbol As System.Data.DataSet
    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarDatos()
            CrearNodosDelPadre(0, Nothing)
            chk_agregar.Checked = False
            gru_menu.Enabled = False
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
            'conectar()
            'Dim cadenasql As String
            'cadenasql = "select * from seg_menu"
            'dr = fun_ExecuteReader(cadenasql)
            Dim lista As New List(Of cls_CE_Menu)
            Dim obj As New cls_CN_Menu
            Tvw_Menu.Nodes.Clear()
            lista = obj.fun_CD_CargarDatos
            Dim n As Integer
            n = lista.Count - 1
            If n >= 0 Then
                For i = 0 To n
                    InsertarDataRow(lista(i).Men_Descripcion, lista(i).Men_Id, lista(i).Men_Id_MenuPadre)
                Next
            End If
            'Tvw_Menu.Nodes.Clear()
            'If dr.HasRows Then
            '    While dr.Read
            '        InsertarDataRow(dr("men_Descripcion"), dr("men_id"), dr("men_Id_MenuPadre"))
            '    End While
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
            'Finally
            '    dr.Close()
            '    desconectar()
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

    Private Sub btn_Grabar_Click(sender As Object, e As EventArgs) Handles btn_Grabar.Click
        Try
            'Dim cadenasql As String = ""
            'Dim int_asociado As Integer = 0
            'Dim estado As String = ""
            'Dim str_frm As String = ""

            'If chk_agregar.Checked = False Then

            '    If chk_estado.Checked = True Then
            '        estado = "A"
            '    Else
            '        estado = "E"
            '    End If

            '    'ingresa o modifica menu principal
            '    If txt_nodopadre.Text = "" And txt_nodoHijo.Text = "" Then
            '        ' MsgBox("Se crea el nodo padre")
            '        If txt_descripcion.Text = "" Or txt_pos.Text = "" Then
            '            MsgBox("Ingrese el La descripción y pa posición")
            '        Else
            '            cadenasql = cadenasql & " Insert into seg_menu ( men_Id_MenuPadre,men_Descripcion,men_posicion,men_ForAsociado,men_estado) "
            '            cadenasql = cadenasql & " values (" & 0 & "," & "'" & txt_descripcion.Text & "'," & txt_pos.Text & "," & 0 & ",'" & estado & "')"
            '        End If
            '    Else
            '        'actualizo la cabecera

            '        If chk_frm_Asociado.Checked = True Then
            '            int_asociado = 1
            '        Else
            '            int_asociado = 0
            '        End If

            '        cadenasql = cadenasql & " Update seg_menu "
            '        cadenasql = cadenasql & " set men_Descripcion='" & txt_descripcion.Text & "',"
            '        cadenasql = cadenasql & " men_posicion=" & txt_pos.Text & ","
            '        cadenasql = cadenasql & " men_ForAsociado=" & int_asociado & ","
            '        If txt_nombreformulario.Text = "" Then
            '            str_frm = "Null"
            '            cadenasql = cadenasql & " men_nombreFrm=" & str_frm & ","
            '        Else
            '            str_frm = txt_nombreformulario.Text
            '            cadenasql = cadenasql & " men_nombreFrm='" & str_frm & "',"
            '        End If

            '        cadenasql = cadenasql & " men_estado='" & estado & "'"
            '        cadenasql = cadenasql & " where men_id=" & txt_nodoHijo.Text & " and men_id_MenuPadre=" & txt_nodopadre.Text
            '    End If
            'Else
            '    If chk_estado.Checked = True Then
            '        estado = "A"
            '    Else
            '        estado = "E"
            '    End If

            '    'ingresa menú o sub menu con padre
            '    If txt_nombreformulario.Text <> "" Then
            '        MsgBox("No se puede Agregar Un Sub menú si tiene un formulario asociado")
            '        Exit Sub
            '    End If
            '    If rbtn_subMenu.Checked = True Then
            '        'ingreso sub menú padre

            '        If txt_descripcion.Text = "" Or txt_pos.Text = "" Then
            '            MsgBox("Ingrese los datos requeridos")
            '            Exit Sub
            '        End If
            '        cadenasql = cadenasql & " Insert into seg_menu ( men_Id_MenuPadre,men_Descripcion,men_posicion,men_ForAsociado,men_estado) "
            '        cadenasql = cadenasql & " values (" & txt_nodoHijo.Text & "," & "'" & txt_descripcionSub.Text & "'," & txt_posSub.Text & "," & 0 & ",'" & estado & "')"
            '    Else
            '        'inbreso dub menú hijo
            '        If txt_descripcionSub.Text = "" Or txt_posSub.Text = "" Or txt_nombreformularioSub.Text = "" Then
            '            MsgBox("Ingrese los datos requeridos")
            '            Exit Sub
            '        End If
            '        If chk_frm_AsociadoSub.Checked = True Then
            '            int_asociado = 1
            '        Else
            '            int_asociado = 0
            '        End If
            '        cadenasql = cadenasql & " Insert into seg_menu ( men_Id_MenuPadre,men_Descripcion,men_posicion,men_ForAsociado,men_nombreFrm,men_estado) "
            '        cadenasql = cadenasql & " values (" & txt_nodoHijo.Text & "," & "'" & txt_descripcionSub.Text & "'," & txt_posSub.Text & "," & int_asociado & ",'" & txt_nombreformularioSub.Text & "','" & estado & "')"
            '        'ojo falta verificar
            '    End If
            'End If
            'conectar()
            Dim obj As New cls_CN_Menu

            If obj.CN_btn_Grabar(chk_agregar.Checked, chk_estado.Checked, txt_nodopadre.Text, txt_nodoHijo.Text, txt_descripcion.Text,
            txt_pos.Text, chk_frm_Asociado.Checked, txt_nombreformulario.Text, rbtn_subMenu.Checked, txt_descripcionSub.Text,
              txt_posSub.Text, txt_nombreformularioSub.Text, chk_frm_AsociadoSub.Checked) = True Then
                'MsgBox("La operación se realizó con éxito")
                CargarDatos()
                CrearNodosDelPadre(0, Nothing)
                btn_limpiar.PerformClick()
            Else
                MsgBox("No se pudo concluir Error")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'desconectar()
        End Try
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
                recuperardatos(des_nodopadre, des_nodohijo)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub recuperardatos(ByVal descripcionp As String, ByVal descripcionh As String)
        Try
            'Dim cadenasql As String = ""
            'If descripcionp = "0" Then 'no tiene padre
            '    cadenasql = "select * from seg_menu where men_Id_MenuPadre=0 and men_descripcion= '" & descripcionh & "'"
            'Else
            '    cadenasql = cadenasql & "select * from seg_menu where men_Id_MenuPadre=(select men_Id from seg_Menu where men_Descripcion='" & descripcionp & "')"
            '    cadenasql = cadenasql & " and men_descripcion='" & descripcionh & "' "

            'End If
            'conectar()
            'dr = fun_ExecuteReader(cadenasql)
            Dim lista As New List(Of cls_CE_Menu)
            Dim obj As New cls_CN_Menu
            Dim n As Integer
            lista = obj.CN_recuperardatos(descripcionp, descripcionh)
            n = lista.Count - 1

            If n >= 0 Then
                For i = 0 To n


                    txt_nodoHijo.Text = lista(i).Men_Id
                    txt_nodopadre.Text = lista(i).Men_Id_MenuPadre
                    txt_descripcion.Text = lista(i).Men_Descripcion
                    txt_pos.Text = lista(i).Men_Posicion
                    txt_nombreformulario.Text = lista(i).Men_nombreFrm
                    If lista(i).Men_estado ="A"Then
                        chk_estado.Checked = True
                    Else
                        chk_estado.Checked = False
                    End If

                    chk_frm_Asociado.Checked = lista(i).Men_ForAsociado
                    If chk_frm_Asociado.Checked = False Then
                        chk_frm_Asociado.Enabled = False
                        txt_nombreformulario.Enabled = False

                    Else
                        chk_frm_Asociado.Enabled = True
                        txt_nombreformulario.Enabled = True
                    End If

                Next
                gru_menu.Enabled = True
            End If
        Catch ex As Exception
        Finally

        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            txt_nodopadre.Text = ""
            txt_nodoHijo.Text = ""
            txt_descripcion.Text = ""
            txt_pos.Text = ""
            chk_frm_Asociado.Checked = False
            chk_frm_Asociado.Enabled = False
            chk_agregar.Checked = False
            chk_agregar.Enabled = False
            txt_nombreformulario.Text = ""
            txt_nombreformulario.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Try
            txt_nodopadre.Text = ""
            txt_nodoHijo.Text = ""
            txt_descripcion.Text = ""
            txt_pos.Text = ""
            chk_frm_Asociado.Checked = True
            chk_frm_Asociado.Enabled = True
            chk_agregar.Checked = False
            chk_agregar.Enabled = True
            txt_nombreformulario.Text = ""
            txt_nombreformulario.Enabled = False
            txt_descripcionSub.Text = ""
            txt_posSub.Text = ""
            txt_nombreformularioSub.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chk_frm_Asociado_CheckedChanged_1(sender As Object, e As EventArgs) Handles chk_frm_Asociado.CheckedChanged
        If chk_frm_Asociado.Checked = False Then
            txt_nombreformulario.Text = ""
            txt_nombreformulario.Enabled = True
        Else
            txt_nombreformulario.Enabled = False
        End If
    End Sub

    Private Sub chk_agregar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_agregar.CheckedChanged
        gru_agregar.Enabled = chk_agregar.Checked
        gru_padre.Enabled = Not (chk_agregar.Checked)
        If chk_agregar.Checked = True Then
            rbtn_formularioAsociado.Checked = True
            chk_frm_AsociadoSub.Checked = True
            chk_frm_AsociadoSub.Enabled = True
            txt_nombreformularioSub.Text = ""
            txt_nombreformularioSub.Enabled = True

        End If

    End Sub


    Private Sub rbtn_subMenu_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_subMenu.CheckedChanged
        chk_frm_AsociadoSub.Checked = False
        chk_frm_AsociadoSub.Enabled = False
        txt_nombreformularioSub.Enabled = False
        txt_nombreformularioSub.Text = ""
    End Sub

    Private Sub rbtn_formularioAsociado_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_formularioAsociado.CheckedChanged

        chk_frm_AsociadoSub.Checked = True
        chk_frm_AsociadoSub.Enabled = True
        txt_nombreformularioSub.Text = ""
        txt_nombreformularioSub.Enabled = True
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_pos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pos.KeyPress
        'vericicar si es un número
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_posSub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_posSub.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_pos_TextChanged(sender As Object, e As EventArgs) Handles txt_pos.TextChanged

    End Sub
End Class