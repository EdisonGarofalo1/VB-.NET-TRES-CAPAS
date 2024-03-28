Imports CapaEntidad
Imports CapaDatos

Public Class cls_CN_productos
    Function fun_CN_recuperar_productos(ByVal buscar As String) As List(Of cls_CE_producto)

        Try
            Dim obj As New cls_CD_productos
            fun_CN_recuperar_productos = obj.fun_CD_recuperar_productos(buscar)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN_carg_categoria() As DataTable
        Try
            Dim obj As New cls_CD_productos
            fun_CN_carg_categoria = obj.fun_CD_carg_categoria
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN_recuperarXid(ByVal id As String) As cls_CE_producto
        Try
            Dim obj As New cls_CD_productos
            fun_CN_recuperarXid = obj.fun_CD_recuperarXid(id)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN_grabar(ByVal pro As cls_CE_producto) As Boolean
        Try
            Dim obj As New cls_CD_productos
            fun_CN_grabar = obj.fun_CD_grabar(pro)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


End Class
