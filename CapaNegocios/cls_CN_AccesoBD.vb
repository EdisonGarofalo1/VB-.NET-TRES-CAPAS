Imports CapaDatos
Imports CapaEntidad
Public Class cls_CN_AccesoBD
    Public Function CN_fun_verificaConec(ByVal cadenaConec As String) As Boolean
        Try
            Dim objecto As New cls_CD_AccesoBD(cadenaConec)
            CN_fun_verificaConec = objecto.CD_fun_verificarConexion

        Catch ex As Exception
            CN_fun_verificaConec = False
        End Try
    End Function
    Function CN_fun_ListaUsuario(ByVal usuario As String, ByVal clave As String) As List(Of cls_CE_AccesoBD)
        Try
            Dim obj As New cls_CD_AccesoBD
            CN_fun_ListaUsuario = obj.CD_fun_listUsuario(usuario, clave)
        Catch ex As Exception

        End Try


    End Function


End Class
