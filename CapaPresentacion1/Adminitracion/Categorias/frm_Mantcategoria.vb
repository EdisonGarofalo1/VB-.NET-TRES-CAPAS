Imports CapaEntidad
Imports CapaNegocios
Public Class frm_Mantcategoria
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_Mantcategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            chk_estado.Checked = True
            If txt_codigo.Text <> 0 Then
                If fun_recuperar_datos() = False Then
                    MsgBox("no exite datos")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_recuperar_datos() As Boolean
        Try
            fun_recuperar_datos = False

            Dim lista As New List(Of cls_CE_categorias)
            Dim obj As New cls_CN_categorias

            lista = obj.fun_CN_recuperaXcodigo(txt_codigo.Text)
            If lista Is Nothing Then
                Exit Function

            End If
            For i = 0 To lista.Count - 1
                txt_descripcion.Text = lista(i).CAT_DESCRIPCION
                If lista(i).CAT_ESTADO = "A" Then
                    chk_estado.Checked = True
                Else
                    chk_estado.Checked = False

                End If
            Next
            fun_recuperar_datos = True
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_recuperar_datos = False
        End Try
    End Function

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If fun_grabar = False Then
                MsgBox("error al grabar")
            Else
                MsgBox(" :) grabado")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_grabar() As Boolean
        Try
            fun_grabar = False
            Dim obj As New cls_CE_categorias
            Dim objCN As New cls_CN_categorias
            obj.CAT_ID = txt_codigo.Text
            obj.CAT_DESCRIPCION = txt_descripcion.Text
            If chk_estado.Checked = False Then
                obj.CAT_ESTADO = "E"
            Else
                obj.CAT_ESTADO = "A"
            End If

            fun_grabar = objCN.fun_CN_grabar(obj)

        Catch ex As Exception
            fun_grabar = False
            MsgBox(ex.Message)
        End Try
    End Function

End Class