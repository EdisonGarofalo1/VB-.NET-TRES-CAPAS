Imports CapaEntidad
Imports CapaNegocios

Public Class frm_mantClientes
    Private Sub frm_mantClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If recuperar_sexo() = False Then
                MsgBox("no se pudo cargar sexo")
                Exit Sub
            End If
            If recuperar_estado() = False Then
                MsgBox("no se pudo cargar estado")
                Exit Sub
            End If
            chk_estado.Checked = True
            chk_validar.Checked = True
            If funrecuperarxcodigo() = False Then
                MsgBox("no recuperar persona")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_validar() As Boolean
        Try
            fun_validar = False
            If chk_validar.Checked = True Then
                If fun_validacedula(txt_identificacion.Text) = False Then
                    MsgBox("Cédula incorrecta")
                    Exit Function
                End If
            Else
                If txt_identificacion.Text = "" Then
                    MsgBox("Ingrese el número de Documento")
                    txt_identificacion.Focus()
                    Exit Function
                End If
            End If

            If txt_nombres.Text = "" Then
                MsgBox("Ingrese el Nombre ")
                txt_nombres.Focus()
                Exit Function
            End If

            If txt_direccion.Text = "" Then
                MsgBox("Ingrese la Dirección ")
                txt_direccion.Focus()
                Exit Function
            End If

            fun_validar = True
        Catch ex As Exception
            fun_validar = False
        End Try
    End Function
    Function funrecuperarxcodigo() As Boolean
        Try
            funrecuperarxcodigo = False
            Dim obj As New cls_CE_clientes
            Dim objp As New cls_CN_clientes

            obj = objp.fun_rexuperarxcodigo(txt_id.Text)
            If objp Is Nothing Then
                Exit Function
            End If
            txt_id.Text = obj.PER_ID
            txt_identificacion.Text = obj.PER_IDENTIFICACION
            txt_nombres.Text = obj.PER_NOMBRES
            txt_direccion.Text = obj.PER_DIRECCION
            txt_telefono.Text = obj.PER_TELEFONO
            cbo_sexo.SelectedValue = obj.CP_SEXO
            cbo_estadoCivil.SelectedValue = obj.CP_ESTADO_CIVIL
            If obj.PER_ESTADO = "A" Then
                chk_estado.Checked = True
            Else
                chk_estado.Checked = False
            End If
            funrecuperarxcodigo = True
        Catch ex As Exception
            funrecuperarxcodigo = False
            MsgBox(ex.Message)
        End Try

    End Function
    Function recuperar_sexo() As Boolean
        Try
            recuperar_sexo = False
            Dim tabla As New DataTable
            Dim obj As New cls_CN_clientes
            tabla = obj.fun_CN__crg_sexo

            cbo_sexo.DataSource = tabla
            cbo_sexo.DisplayMember = "DETP_descripcion"
            cbo_sexo.ValueMember = "DETP_id"
            recuperar_sexo = True

        Catch ex As Exception
            recuperar_sexo = False
            MsgBox(ex.Message)
        End Try
    End Function
    Function recuperar_estado() As Boolean
        Try
            recuperar_estado = False
            Dim tabla As New DataTable
            Dim obj As New cls_CN_clientes
            tabla = obj.fun_CN__crg_estado

            cbo_estadoCivil.DataSource = tabla
            cbo_estadoCivil.DisplayMember = "DETP_descripcion"
            cbo_estadoCivil.ValueMember = "DETP_id"
            recuperar_estado = True

        Catch ex As Exception
            recuperar_estado = False
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If fun_validar() = False Then
                Exit Sub
            End If
            If fun_grabar() = False Then
                MsgBox("Error al grbar")
            Else
                MsgBox("La operación se realizó con éxito ")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function fun_grabar() As Boolean
        Try
            fun_grabar = False

            Dim obj As New cls_CE_clientes
            Dim objc As New cls_CN_clientes

            obj.PER_ID = txt_id.Text
            obj.PER_IDENTIFICACION = txt_identificacion.Text
            obj.CP_SEXO = cbo_sexo.SelectedValue
            obj.PER_TELEFONO = txt_telefono.Text

            obj.CP_ESTADO_CIVIL = cbo_estadoCivil.SelectedValue
            obj.PER_NOMBRES = txt_nombres.Text

            obj.PER_DIRECCION = txt_direccion.Text
            obj.PER_ESTADO = "E"

            If chk_estado.Checked = True Then
                obj.PER_ESTADO = "A"
            End If


            fun_grabar = objc.fun_CN_grabar(obj)


        Catch ex As Exception
            MsgBox(ex.Message)
            fun_grabar = False
        End Try
    End Function
End Class