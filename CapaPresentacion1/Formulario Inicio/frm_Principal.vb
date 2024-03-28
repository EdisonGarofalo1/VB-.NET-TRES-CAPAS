
Imports System.Reflection
Imports CapaEntidad
Imports CapaNegocios

Public Class frm_Principal
    Dim dtMenus = New DataTable
    Private Sub frm_principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dim str_mensaje, str_titulo As String
            str_mensaje = "Realmente desea salir del Sistema?"
            str_titulo = Me.Text
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox(str_mensaje,
           MsgBoxStyle.DefaultButton2 Or
           MsgBoxStyle.Question Or MsgBoxStyle.YesNo, str_titulo)
            If respuesta = MsgBoxResult.Yes Then
                frm_inicio.Close()
                Me.Close()
                e.Cancel = False
            Else
                e.Cancel = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '   rslbl_nombre.Text = g_str_nombre_usuario
            CargarMenus(g_str_perfilusuario)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargarMenus(id_Perfil As Int32)
        Try

            Dim lista As New List(Of Principal_CE_AcessoBD)
            Dim obj As New cls_CN_Principal
            lista = Nothing

            lista = obj.CN_fun_listamenu(id_Perfil)
            dtMenus = ConvertToDataTable(lista)
            For Each MenuPadre As DataRow In dtMenus.Select("men_Id_MenuPadre=0", "men_Posicion ASC")
                Dim Menu As ToolStripItem
                Menu = New ToolStripMenuItem()
                Menu.Name = MenuPadre("men_Id").ToString()
                Menu.Text = MenuPadre("men_Descripcion").ToString()
                Menu.Tag = MenuPadre("men_nombreFrm").ToString()
                'Averiguando si tiene Hijos o no
                If dtMenus.Select("men_Id_MenuPadre=" & MenuPadre("men_Id")).Length = 0 Then
                    'Sino tiene hijos lo agrego a la barra de menu principal
                    MenuPpal.Items.Add(Menu)
                Else
                    'Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                    MenuPpal.Items.Add(Menu)
                    AgregarMenuHijo(Menu)
                End If
            Next
            dtMenus.clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub AgregarMenuHijo(MenuItemPadre As ToolStripItem)
        Try
            Dim MenuPadre As ToolStripMenuItem = CType(MenuItemPadre, ToolStripMenuItem)
            'Obtengo el ID del menu Enviado para saber si tiene hijos o no
            Dim Id As String = MenuPadre.Name
            'Averiguando si tiene Hijos o no
            If dtMenus.Select("men_Id_MenuPadre=" & Id).Length = 0 Then
                'Si No tiene Hijos Solo Agrego el Evento
                AddHandler MenuPadre.Click, AddressOf AccionarMenu
            Else
                'Si Aun tiene Hijos
                For Each Menu As DataRow In dtMenus.Select("men_Id_MenuPadre=" & Id, "men_Posicion ASC")
                    Dim NuevoMenu As ToolStripItem
                    NuevoMenu = New ToolStripMenuItem()
                    NuevoMenu.Name = Menu("men_Id").ToString()
                    NuevoMenu.Text = Menu("men_Descripcion").ToString()
                    NuevoMenu.Tag = Menu("men_nombreFrm").ToString()
                    'Averiguo se es un separador
                    If Menu("men_Descripcion").ToString() = "-" Then
                        MenuPadre.DropDownItems.Add(NuevoMenu.Text)
                    Else
                        'Obtengo el ID del Menu del foreach
                        If dtMenus.Select("men_Id_MenuPadre=" & Menu("men_Id")).Length = 0 Then
                            'Sino tiene hijos lo agrego al Menu Padre
                            AddHandler NuevoMenu.Click, AddressOf AccionarMenu
                            MenuPadre.DropDownItems.Add(NuevoMenu)
                        Else
                            'Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                            MenuPadre.DropDownItems.Add(NuevoMenu)
                            AgregarMenuHijo(NuevoMenu)

                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub AccionarMenu(sender As Object, e As EventArgs)
        Try

            If sender.GetType() = GetType(ToolStripMenuItem) Then
                Dim NombreFormulario As String = (CType(sender, ToolStripItem)).Tag.ToString()

                If String.IsNullOrEmpty(NombreFormulario) = True Then
                    Exit Sub
                End If
                Dim nombrecompleto As String = Application.ProductName & "." & NombreFormulario
                Dim FormInstanceType As Type = Type.GetType(nombrecompleto, True, True)
                Dim FRM As Object
                FRM = CType(Activator.CreateInstance(FormInstanceType), Form)
                If EstaAbierto(FRM) Then
                    Exit Sub
                Else
                    FRM.MdiParent = Me
                    FRM.StartPosition = FormStartPosition.CenterScreen
                    FRM.MinimizeBox = False

                    FRM.Show()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function EstaAbierto(ByVal Myform As Form) As Boolean
        Try
            EstaAbierto = False
            For Each objForm In My.Application.OpenForms
                If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                    EstaAbierto = True
                End If
            Next
            Return EstaAbierto
        Catch ex As Exception
            EstaAbierto = False
        End Try
    End Function
    Public Shared Function ConvertToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim dt As New DataTable()
        Dim propiedades As PropertyInfo() = GetType(T).GetProperties
        For Each p As PropertyInfo In propiedades
            dt.Columns.Add(p.Name, p.PropertyType)
        Next
        For Each item As T In list
            Dim row As DataRow = dt.NewRow
            For Each p As PropertyInfo In propiedades
                row(p.Name) = p.GetValue(item, Nothing)
            Next
            dt.Rows.Add(row)
        Next
        Return dt
    End Function

End Class