Imports CapaEntidad
Imports CapaDatos
Public Class cls_CN_perfil

    Function fun_CN_pefil(ByVal buscar As String) As List(Of cls_CE_perfil)
        Try
            fun_CN_pefil = Nothing
            Dim obj As New cls_CD_perfil
            fun_CN_pefil = obj.fun_recuperaDatos(buscar)

        Catch ex As Exception
            fun_CN_pefil = Nothing
        End Try

    End Function
    Function fun_CN_recuperaperfil(ByVal codigo As String) As List(Of cls_CE_perfil)
        Dim obj As New cls_CD_perfil
        fun_CN_recuperaperfil = obj.CD_fun_recuperaperfil(codigo)
    End Function
    Function fun_CN_guardar(ByRef lista As List(Of cls_CE_perfil)) As Boolean
        Dim obj As New cls_CD_perfil
        fun_CN_guardar = obj.CD_fun_grabar(lista)
    End Function
End Class
