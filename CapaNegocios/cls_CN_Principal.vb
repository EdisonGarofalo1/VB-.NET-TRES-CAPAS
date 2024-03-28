Imports CapaEntidad
Imports CapaDatos
Public Class cls_CN_Principal
    Function CN_fun_listamenu(ByVal id_perfilmenu As String) As List(Of Principal_CE_AcessoBD)
        Try
            Dim obj As New cls_CD_Principal
            CN_fun_listamenu = obj.CD_cargar_menu(id_perfilmenu)

        Catch ex As Exception
            CN_fun_listamenu = Nothing
        End Try
    End Function
End Class
