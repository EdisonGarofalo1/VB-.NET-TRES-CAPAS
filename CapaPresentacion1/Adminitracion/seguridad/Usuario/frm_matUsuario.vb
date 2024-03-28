Imports CapaEntidad
Imports CapaNegocios
Public Class frm_matUsuario
    Dim bool_comboperfil As Boolean
    Dim id_usuario As Integer
    Private Sub frm_matUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            id_usuario = 0
            chk_validar.Checked = True
            If fun_cargar_perfiles() = False Then
                MsgBox("Error, No se pudo cargar los perfiles")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_cargar_perfiles() As Boolean
        Try
            fun_cargar_perfiles = False
            Dim obj As New cls_CN_usuarios
            cbo_perfil.DataSource = obj.CN_recuperarPerfiles
            cbo_perfil.DisplayMember = "per_nombre"
            cbo_perfil.ValueMember = "per_id"
            fun_cargar_perfiles = True

        Catch ex As Exception

            fun_cargar_perfiles = False
        End Try
    End Function
    Sub limpiar()
        txt_cedula.Text = ""
        txt_apellidos.Text = ""
        txt_nombres.Text = ""
        txt_direccion.Text = ""
        txt_correo.Text = ""
        txt_telefono.Text = ""
        txt_usuario.Text = ""
        txt_clave.Text = ""
        pb_foto.Image = Nothing
        pb_foto.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & "imgxdefecto.jpg")
    End Sub

    Private Sub txt_cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedula.KeyPress
        Try
            If Asc(e.KeyChar) = 9 Or Asc(e.KeyChar) = 13 Then
                If fun_recuperaUsuario(txt_cedula.Text) = False Then
                    MsgBox("No existe el usuario", MsgBoxStyle.Information)
                    limpiar()

                    txt_cedula.Focus() 'limpiar
                    id_usuario = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_recuperaUsuario(ByVal ci As String) As Boolean
        Try
            fun_recuperaUsuario = False
            Dim obj As New cls_CN_usuarios
            Dim lista As New List(Of cls_CE_usuarios)
            lista = obj.CN_recuperarUsuarios(ci)
            Dim n As Integer
            n = lista.Count - 1
            If n >= 0 Then
                For i = 0 To n
                    id_usuario = lista(i).Usu_id
                    'cbo_perfil.SelectedValue = dr("per_id")
                    txt_nombres.Text = lista(i).Usu_nombres
                    txt_apellidos.Text = lista(i).Usu_apellidos
                    txt_direccion.Text = lista(i).Usu_direccion
                    txt_telefono.Text = lista(i).Usu_telefono
                    txt_correo.Text = lista(i).Usu_email
                    txt_usuario.Text = lista(i).Usu_usuario
                    txt_clave.Text = lista(i).Usu_clave
                    'foto
                    If lista(i).Usu_estado = "A" Then
                        chk_estado.Checked = True
                    Else
                        chk_estado.Checked = False
                    End If


                    pb_foto.Image = ByteArrayToImage(DirectCast(lista(i).Usu_foto, Byte()))

                Next

                fun_recuperaUsuario = True
            Else
                fun_recuperaUsuario = False
            End If

        Catch ex As Exception
            fun_recuperaUsuario = False
        End Try
    End Function
    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If fun_validardatos() = True Then
                If fun_GrabarUsurio() = True Then
                    MsgBox("La operación se realizo con éxito")
                Else
                    MsgBox("Error al Grabar")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_GrabarUsurio() As Boolean
        Try

            fun_GrabarUsurio = False
            Dim obj As New cls_CE_usuarios
            Dim lista As New List(Of cls_CE_usuarios)
            Dim obn As New cls_CN_usuarios
            obj.Usu_id = id_usuario
            obj.Usu_cedula = txt_cedula.Text
            obj.Per_Id = cbo_perfil.SelectedValue
            obj.Usu_nombres = txt_nombres.Text
            obj.Usu_apellidos = txt_apellidos.Text
            obj.Usu_direccion = txt_direccion.Text
            obj.Usu_telefono = txt_telefono.Text
            obj.Usu_email = txt_correo.Text
            obj.Usu_usuario = txt_usuario.Text
            obj.Usu_clave = txt_clave.Text
            'foto
            If chk_estado.Checked = True Then
                obj.Usu_estado = "A"
            Else
                obj.Usu_estado = "I"
            End If


            Dim mifoto As Byte()
            mifoto = ImageToByteArray(pb_foto.Image)

            obj.Usu_foto = mifoto

            lista.Add(obj)
            If obn.CN_fun_GrabarUsurio(lista) = True Then
                fun_GrabarUsurio = True
            End If



        Catch ex As Exception
            fun_GrabarUsurio = False
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            limpiar()
            id_usuario = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            Dim archivo As New OpenFileDialog
            archivo.Filter = "Archivo JPG|*.jpg"
            If archivo.ShowDialog = DialogResult.OK Then
                pb_foto.Image = Image.FromFile(archivo.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_validardatos() As Boolean
        Try
            fun_validardatos = False
            If txt_clave.Text = String.Empty Then
                MsgBox("Ingrese la clave del usuario", MsgBoxStyle.Exclamation)
                txt_clave.Focus()
                Exit Function
            End If
            If chk_validar.Checked = True Then
                If fun_validacedula(txt_cedula.Text) = False Then
                    MsgBox("Número de cédula incorrecto", MsgBoxStyle.Exclamation)
                    Exit Function
                End If
            End If
            If txt_nombres.Text = String.Empty Then
                MsgBox("Ingrese el nombre del usuario", MsgBoxStyle.Exclamation)
                txt_nombres.Focus()
                Exit Function
            End If
            If txt_apellidos.Text = String.Empty Then
                MsgBox("Ingrese el apellido del usuario", MsgBoxStyle.Exclamation)
                txt_apellidos.Focus()
                Exit Function
            End If
            If txt_usuario.Text = String.Empty Then
                MsgBox("Ingrese el nombre del usuario", MsgBoxStyle.Exclamation)
                txt_usuario.Focus()
                Exit Function
            End If


            If fun_usuarioexiste(txt_usuario.Text) = True Then
                MsgBox("El nombre del usuario ya existe", MsgBoxStyle.Exclamation)
                txt_usuario.Focus()
                Exit Function
            End If

            If txt_clave.Text = String.Empty Then
                MsgBox("Ingrese el nombre la clave", MsgBoxStyle.Exclamation)
                txt_clave.Focus()
                Exit Function
            End If

            If txt_correo.Text <> String.Empty Then
                If validar_Mail(LCase(txt_correo.Text)) = False Then
                    MessageBox.Show("Dirección de correo electronico no valida,el correo debe tener el formato: nombre@dominio.com, " &
                    " por favor seleccione un correo valido", "Validación de     correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_correo.Focus()
                    Exit Function
                End If
            End If
            fun_validardatos = True
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_validardatos = False
        End Try

    End Function
    Function fun_usuarioexiste(ByVal usuario As String) As Boolean
        Try
            fun_usuarioexiste = False
            Dim obj As cls_CN_usuarios
            If obj.Cn_fun_usuarioexiste(txt_usuario.Text, id_usuario) = True Then
                fun_usuarioexiste = True
            End If
        Catch ex As Exception
            fun_usuarioexiste = False

        End Try
    End Function

    Private Sub btn_buscausuario_Click(sender As Object, e As EventArgs) Handles btn_buscausuario.Click
        Try
            g_str_cedula = ""

            frm_usuarios.ShowDialog()

            If g_str_cedula <> "" Then
                txt_cedula.Text = g_str_cedula
                txt_cedula_KeyPress(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class