Imports CapaNegocios
Imports CapaEntidad
Imports System.Reflection

Public Class frm_perfiles
    Dim pos_per_id As Integer = 0
    Dim per_i As Integer = 0
    Dim per_nombr As Integer = 1
    Dim PER_DESCRIPCIO As Integer = 2
    Dim per_estad As Integer = 3
    Private Sub frm_perfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If fun_recuperaDatos() = False Then
                MsgBox("No existe Perfiles")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Function fun_recuperaDatos() As Boolean
        Try
            fun_recuperaDatos = False
            'Dim str_cadenaSql As String = ""
            'str_cadenaSql = str_cadenaSql & " select top 10 per_id,per_nombre,per_descripcion,per_estado "
            'str_cadenaSql = str_cadenaSql & " from seg_perfil"
            'str_cadenaSql = str_cadenaSql & " where per_nombre like '" & txt_buscar.Text & "%'"
            'If conectar() = False Then
            '    Exit Function
            'End If
            'dr = fun_ExecuteReader(str_cadenaSql)
            dgv_datos.Rows.Clear()
            Dim obj As New cls_CN_perfil
            Dim lista As New List(Of cls_CE_perfil)

            lista = obj.fun_CN_pefil(txt_buscar.Text)
            'dgv_datos = ConvertToDataTable(lista)

            For Each i In lista
                dgv_datos.Rows.Add(i.Per_Id, i.Per_Nombre, i.Per_Descripcion, i.Per_estado)
            Next


            ' dgv_datos.DataSource = lista

            'If dr.HasRows Then
            '    While dr.Read
            '        dgv_datos.Rows.Add(dr("per_id"), dr("per_nombre"), dr("per_descripcion"), dr("per_estado"))
            '    End While
            'End If
            fun_recuperaDatos = True
        Catch ex As Exception
            fun_recuperaDatos = False
            MsgBox(ex.Message)
        Finally

        End Try
    End Function

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            If fun_recuperaDatos() = False Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellContentClick

    End Sub

    Private Sub dgv_datos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                Dim frm As New frm_matPerfiles
                frm.txt_codigo.Text = dgv_datos.Rows(e.RowIndex).Cells(pos_per_id).Value
                frm.ShowDialog()
                fun_recuperaDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            Dim frm As New frm_matPerfiles
            frm.txt_codigo.Text = 0
            frm.ShowDialog()
            fun_recuperaDatos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub
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