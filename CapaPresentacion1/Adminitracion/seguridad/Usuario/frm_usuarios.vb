Imports CapaEntidad
Imports CapaNegocios
Public Class frm_usuarios
    Private Sub frm_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_buscarusuariosxApe(txt_buscar.Text) = False Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function fun_buscarusuariosxApe(ByVal buscar As String) As Boolean
        Try
            fun_buscarusuariosxApe = False
            'If conectar() = False Then
            '    Exit Function
            'End If
            'dr = fun_ExecuteReader("sp_sel_ListaUsiariosxApe", txt_buscar.Text)
            'dgv_usuarios.Rows.Clear()
            'If dr.HasRows Then
            '    While dr.Read
            '        dgv_usuarios.Rows.Add(dr("usu_cedula"),
            '            dr("nombres"), dr("per_nombre"), dr("usu_estado"))
            '    End While
            Dim lista As New List(Of cls_CE_usuarios)
            Dim obj As New cls_CN_usuarios
            lista = obj.fun_buscarusuariosxApe(buscar)
            Dim n As Integer
            n = lista.Count - 1
            If n >= 0 Then
                For i = 0 To n
                    dgv_usuarios.Rows.Add(lista(i).Usu_cedula, lista(i).Usu_nombres, lista(i).Usu_apellidos, lista(i).Usu_estado)
                Next

                fun_buscarusuariosxApe = True
            End If

            'End If
        Catch ex As Exception
            fun_buscarusuariosxApe = False
            MsgBox(ex.Message)
        Finally
            '    dr.Close()
            '    desconectar()
        End Try
    End Function

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            If fun_buscarusuariosxApe(txt_buscar.Text) = False Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellDoubleClick
        Try
            If e.RowIndex > -1 Then


                g_str_cedula = dgv_usuarios.Rows(e.RowIndex).Cells(0).Value
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class