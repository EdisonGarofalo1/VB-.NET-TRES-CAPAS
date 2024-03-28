
Imports CapaDatos
Imports CapaEntidad
Public Class cls_CN_cad_paramentrica
    Function fun_CN_carg_variables() As DataTable
        Try
            Dim obj As New cls_CD_Parametrica
            fun_CN_carg_variables = obj.fun_CN_carg_variables()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Function fun_CN_carg_dell_parmetrica(ByVal id As String) As List(Of cls_CE_detalle_parametrica)
        Try
            Dim obj As New cls_CD_Parametrica
            fun_CN_carg_dell_parmetrica = obj.fun_CN_carg_dell_parmetrica(id)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function fun_CN_guardar(ByVal lista As List(Of cls_CE_detalle_parametrica)) As Boolean
        Try
            Dim obj As New cls_CD_Parametrica
            fun_CN_guardar = obj.fun_CD_guardar(lista)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Class
