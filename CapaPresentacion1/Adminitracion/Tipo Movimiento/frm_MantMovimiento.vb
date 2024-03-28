Imports CapaEntidad
Imports CapaNegocios

Public Class frm_MantMovimiento
    Private Sub frm_MantMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_recuperarxCod() = False Then
                MsgBox("error no se pudo cargar los datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function fun_recuperarxCod() As Boolean
        Try
            fun_recuperarxCod = False
            Dim obj As New cls_CE_tipo_movimiento
            Dim objt As New cls_CN_tipo_movimiento

            obj = objt.fun_CN_recuperarXcodigo(txt_codigo.Text)
            If obj Is Nothing Then
                Exit Function
            End If

            txt_descripcion.Text = obj.TIPMOV_DESCRIPCION
            chk_estado.Checked = False
            If obj.TIPMOV_ESTADO = "A" Then
                chk_estado.Checked = True
            End If


            fun_recuperarxCod = True
        Catch ex As Exception
            fun_recuperarxCod = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If fun_grabar() = True Then
                MsgBox("ok..grabado ")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_grabar() As Boolean
        Try
            fun_grabar = False

            Dim obj As New cls_CE_tipo_movimiento

            obj.TIPMOV_ID = txt_codigo.Text
            obj.TIPMOV_DESCRIPCION = txt_descripcion.Text
            obj.TIPMOV_ESTADO = "I"
            If chk_estado.Checked = True Then
                obj.TIPMOV_ESTADO = "A"
            End If

            Dim objt As New cls_CN_tipo_movimiento
            fun_grabar = objt.fun_CN_grabar(obj)
        Catch ex As Exception
            fun_grabar = False
            MsgBox(ex.Message)
        End Try
    End Function
End Class