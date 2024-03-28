Imports CapaDatos
Imports CapaEntidad

Public Class cls_CN_clientes
    Function fun_CN_recuperar(ByVal buscar As String) As List(Of cls_CE_clientes)
        Try
            Dim obj As New cls_CD_clientes
            fun_CN_recuperar = obj.fun_CD_recuperar(buscar)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN__crg_sexo() As DataTable
        Try
            Dim obj As New cls_CD_clientes
            fun_CN__crg_sexo = obj.fun_CN__crg_sexo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN__crg_estado() As DataTable
        Try
            Dim obj As New cls_CD_clientes
            fun_CN__crg_estado = obj.fun_CD__crg_estado()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_rexuperarxcodigo(ByVal id As String) As cls_CE_clientes
        Try
            Dim obj As New cls_CD_clientes
            fun_rexuperarxcodigo = obj.fun_rexuperarxcodigo(id)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN_grabar(ByVal cliente As cls_CE_clientes) As Boolean
        Try
            Dim obj As New cls_CD_clientes
            fun_CN_grabar = obj.fun_CN_grabar(cliente)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class
