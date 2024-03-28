Imports CapaDatos
Imports CapaEntidad
Public Class cls_CN_categorias
    Function fun_CN_recuperar_categoria(ByVal buscar As String) As List(Of cls_CE_categorias)
        Try
            Dim obj As New cls_CD_categorias
            fun_CN_recuperar_categoria = obj.fun_CD_recuperar_categoria(buscar)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function fun_CN_recuperaXcodigo(ByVal codigo) As List(Of cls_CE_categorias)
        Try
            Dim obj As New cls_CD_categorias
            fun_CN_recuperaXcodigo = obj.fun_CD_recuperaXcodigo(codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN_grabar(ByVal objctg As cls_CE_categorias) As Boolean
        Try
            Dim obj As New cls_CD_categorias
            fun_CN_grabar = obj.fun_CD_grabar(objctg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Class
