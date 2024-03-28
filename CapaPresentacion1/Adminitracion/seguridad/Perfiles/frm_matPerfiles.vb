Imports CapaEntidad
Imports CapaNegocios
Public Class frm_matPerfiles
    Private Sub frm_matPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If txt_codigo.Text <> 0 Then
                If fun_recuperaPerfil(txt_codigo.Text) = False Then
                    MsgBox("No existe el perfil")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function fun_recuperaPerfil(ByVal codigo As Integer) As Boolean
        Try
            fun_recuperaPerfil = False
            'Dim str_cadenaSql As String = ""
            'str_cadenaSql = str_cadenaSql & " select per_id,per_nombre,per_descripcion,per_estado "
            'str_cadenaSql = str_cadenaSql & " from seg_perfil"
            'str_cadenaSql = str_cadenaSql & " where per_id = " & codigo
            'If conectar() = False Then
            '    Exit Function
            'End If
            'dr = fun_ExecuteReader(str_cadenaSql)
            Dim lista As New List(Of cls_CE_perfil)
            Dim obj As New cls_CN_perfil

            lista = obj.fun_CN_recuperaperfil(codigo)
            If lista IsNot Nothing Then
                txt_codigo.Text = lista(0).Per_Id

                txt_nombre.Text = lista(0).Per_Nombre
                txt_descripcion.Text = lista(0).Per_Descripcion
                If (lista(0).Per_estado = "A") Then
                    chk_estado.Checked = True
                Else
                    chk_estado.Checked = False
                End If
                fun_recuperaPerfil = True
            End If
        Catch ex As Exception
            fun_recuperaPerfil = False
            MsgBox(ex.Message)
        Finally
            'dr.Close()
            'desconectar()
        End Try
    End Function
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If fun_grabar() = False Then
                MsgBox("Error al grbar")
            Else
                MsgBox("La operación se realizó con éxito ")
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Function fun_grabar() As Boolean
        Try
            fun_grabar = False

            Dim lista As New List(Of cls_CE_perfil)
            Dim obj As New cls_CN_perfil

            Dim perfil As New cls_CE_perfil

            ''Dim str_cadenaSql As String = ""
            ''Dim estado As String
            If chk_estado.Checked = True Then
                perfil.Per_estado = "A"
            Else
                perfil.Per_estado = "E"
            End If

            perfil.Per_Id = txt_codigo.Text
            perfil.Per_Nombre = txt_nombre.Text
            perfil.Per_Descripcion = txt_descripcion.Text

            lista.Add(perfil)

            If obj.fun_CN_guardar(lista) = True Then
                fun_grabar = True
            End If
        Catch ex As Exception
            fun_grabar = False
            MsgBox(ex.Message)
        Finally
            'desconectar()
        End Try
    End Function
End Class