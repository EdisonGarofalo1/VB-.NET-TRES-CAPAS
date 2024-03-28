Imports CapaDatos
Imports CapaEntidad
Public Class cls_CN_tipo_movimiento

    Function fun_CN_carga_movimiento(ByVal buscar As String) As List(Of cls_CE_tipo_movimiento)
        Try
            Dim obj As New cls_CD_tipo_movimiento
            fun_CN_carga_movimiento = obj.fun_CD_carga_movimiento(buscar)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function fun_CN_recuperarXcodigo(ByVal codigo As String) As cls_CE_tipo_movimiento
        Try
            Dim obj As New cls_CD_tipo_movimiento
            fun_CN_recuperarXcodigo = obj.fun_CD_recuperarXcodigo(codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN_grabar(ByVal tipo As cls_CE_tipo_movimiento) As Boolean
        Try

            Dim obj As New cls_CD_tipo_movimiento
            fun_CN_grabar = obj.fun_CD_grabar(tipo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class
