Imports CapaEntidad
Public Class cls_CD_Menu
    Function CD_recuperardatos(ByVal descripcionp As String, ByVal descripcionh As String) As List(Of cls_CE_Menu)
        Try
            CD_recuperardatos = Nothing
            Dim cadenasql As String = ""
            If descripcionp = "0" Then 'no tiene padre
                cadenasql = "select * from seg_menu where men_Id_MenuPadre=0 and men_descripcion= '" & descripcionh & "'"
            Else
                cadenasql = cadenasql & "select * from seg_menu where men_Id_MenuPadre=(select men_Id from seg_Menu where men_Descripcion='" & descripcionp & "')"
                cadenasql = cadenasql & " and men_descripcion='" & descripcionh & "' "

            End If
            conectar()
            dr = fun_ExecuteReader(cadenasql)
            Dim lista As New List(Of cls_CE_Menu)

            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_Menu
                    obj.Men_Id = dr("men_id")
                    obj.Men_Id_MenuPadre = dr("men_id_MenuPadre")
                    obj.Men_Descripcion = dr("men_descripcion")
                    obj.Men_Posicion = dr("men_posicion")
                    obj.Men_nombreFrm = IIf(dr("men_nombreFrm") Is DBNull.Value, "", dr("men_nombreFrm"))
                    obj.Men_estado = dr("men_estado")
                    'If dr("men_estado") = "A" Then
                    '    chk_estado.Checked = True
                    'Else
                    '    chk_estado.Checked = False
                    'End If
                    obj.Men_ForAsociado = dr("men_ForAsociado")
                    'chk_frm_Asociado.Checked = dr("men_ForAsociado")
                    'If chk_frm_Asociado.Checked = False Then
                    '    chk_frm_Asociado.Enabled = False
                    '    txt_nombreformulario.Enabled = False

                    'Else
                    '    chk_frm_Asociado.Enabled = True
                    '    txt_nombreformulario.Enabled = True
                    'End If
                    lista.Add(obj)
                End While
                'gru_menu.Enabled = True
            End If
            Return lista
        Catch ex As Exception
            CD_recuperardatos = Nothing
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function fun_CD_CargarDatos() As List(Of cls_CE_Menu)
        Try

            fun_CD_CargarDatos = Nothing
            'dataSetArbol = New DataSet("DataSetArbol")
            'tablaArbol = dataSetArbol.Tables.Add("TablaArbol")
            'tablaArbol.Columns.Add("NombreNodo", GetType(String))
            'tablaArbol.Columns.Add("IdentificadorNodo", GetType(Integer))
            'tablaArbol.Columns.Add("IdentificadorPadre", GetType(Integer))
            conectar()
            Dim cadenasql As String
            cadenasql = "select * from seg_menu"
            dr = fun_ExecuteReader(cadenasql)
            Dim lista As New List(Of cls_CE_Menu)


            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_Menu
                    obj.Men_Descripcion = dr("men_Descripcion")
                    obj.Men_Id = dr("men_id")
                    obj.Men_Id_MenuPadre = dr("men_Id_MenuPadre")
                    lista.Add(obj)
                End While
            End If
            Return lista
        Catch ex As Exception
            fun_CD_CargarDatos = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Function CD_btn_Grabar(ByVal chk_agregar As Boolean, ByVal chk_estado As Boolean, ByVal txt_nodopadre As String, ByVal txt_nodoHijo As String, ByVal txt_descripcion As String,
             ByVal txt_pos As String, ByVal chk_frm_Asociado As Boolean, ByVal txt_nombreformulario As String, ByVal rbtn_subMenu As Boolean, ByVal txt_descripcionSub As String,
               ByVal txt_posSub As String, ByVal txt_nombreformularioSub As String, ByVal chk_frm_AsociadoSub As Boolean) As Boolean

        Try
            CD_btn_Grabar = False

            Dim cadenasql As String = ""
            Dim int_asociado As Integer = 0
            Dim estado As String = ""
            Dim str_frm As String = ""

            If chk_agregar = False Then

                If chk_estado = True Then
                    estado = "A"
                Else
                    estado = "E"
                End If

                'ingresa o modifica menu principal
                If txt_nodopadre = "" And txt_nodoHijo = "" Then
                    ' MsgBox("Se crea el nodo padre")
                    If txt_descripcion = "" Or txt_pos = "" Then
                        MsgBox("Ingrese el La descripción y pa posición")
                    Else
                        cadenasql = cadenasql & " Insert into seg_menu ( men_Id_MenuPadre,men_Descripcion,men_posicion,men_ForAsociado,men_estado) "
                        cadenasql = cadenasql & " values (" & 0 & "," & "'" & txt_descripcion & "'," & txt_pos & "," & 0 & ",'" & estado & "')"
                    End If
                Else
                    'actualizo la cabecera

                    If chk_frm_Asociado = True Then
                        int_asociado = 1
                    Else
                        int_asociado = 0
                    End If

                    cadenasql = cadenasql & " Update seg_menu "
                    cadenasql = cadenasql & " set men_Descripcion='" & txt_descripcion & "',"
                    cadenasql = cadenasql & " men_posicion=" & txt_pos & ","
                    cadenasql = cadenasql & " men_ForAsociado=" & int_asociado & ","
                    If txt_nombreformulario = "" Then
                        str_frm = "Null"
                        cadenasql = cadenasql & " men_nombreFrm=" & str_frm & ","
                    Else
                        str_frm = txt_nombreformulario
                        cadenasql = cadenasql & " men_nombreFrm='" & str_frm & "',"
                    End If

                    cadenasql = cadenasql & " men_estado='" & estado & "'"
                    cadenasql = cadenasql & " where men_id=" & txt_nodoHijo & " and men_id_MenuPadre=" & txt_nodopadre
                End If
            Else
                If chk_estado = True Then
                    estado = "A"
                Else
                    estado = "E"
                End If

                'ingresa menú o sub menu con padre
                If txt_nombreformulario <> "" Then
                    MsgBox("No se puede Agregar Un Sub menú si tiene un formulario asociado")
                    Exit Function
                End If
                If rbtn_subMenu = True Then
                    'ingreso sub menú padre

                    If txt_descripcion = "" Or txt_pos = "" Then
                        MsgBox("Ingrese los datos requeridos")
                        Exit Function
                    End If
                    cadenasql = cadenasql & " Insert into seg_menu ( men_Id_MenuPadre,men_Descripcion,men_posicion,men_ForAsociado,men_estado) "
                    cadenasql = cadenasql & " values (" & txt_nodoHijo & "," & "'" & txt_descripcionSub & "'," & txt_posSub & "," & 0 & ",'" & estado & "')"
                Else
                    'inbreso dub menú hijo
                    If txt_descripcionSub = "" Or txt_posSub = "" Or txt_nombreformularioSub = "" Then
                        MsgBox("Ingrese los datos requeridos")
                        Exit Function
                    End If
                    If chk_frm_AsociadoSub = True Then
                        int_asociado = 1
                    Else
                        int_asociado = 0
                    End If
                    cadenasql = cadenasql & " Insert into seg_menu ( men_Id_MenuPadre,men_Descripcion,men_posicion,men_ForAsociado,men_nombreFrm,men_estado) "
                    cadenasql = cadenasql & " values (" & txt_nodoHijo & "," & "'" & txt_descripcionSub & "'," & txt_posSub & "," & int_asociado & ",'" & txt_nombreformularioSub & "','" & estado & "')"
                    'ojo falta verificar
                End If
            End If
            conectar()
            If fun_ExecuteNonQuery(cadenasql) Then
                CD_btn_Grabar = True
                MsgBox("La operación se realizó con éxito")

            Else
                MsgBox("No se pudo concluir Error")
            End If


        Catch ex As Exception
            CD_btn_Grabar = False
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Function
End Class
