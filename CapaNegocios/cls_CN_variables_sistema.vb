
Imports CapaEntidad
Imports CapaDatos
Public Class cls_CN_variables_sistema
    Function fun_CN_recuperar(ByVal buscar As String) As List(Of cls_CE_cab_parametrica)
        Try
            Dim obj As New cls_CD_variables_sistema
            fun_CN_recuperar = obj.fun_CD_recuperar(buscar)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function fun_CN_grabar(ByVal lista As List(Of cls_CE_cab_parametrica)) As Boolean
        Try
            Dim obj As New cls_CD_variables_sistema
            fun_CN_grabar = obj.fun_CD_grabar(lista)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function



End Class
