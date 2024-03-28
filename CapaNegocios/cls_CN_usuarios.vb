Imports CapaDatos
Imports CapaEntidad
Public Class cls_CN_usuarios
    Function CN_recuperarUsuarios(ByVal ci As String) As List(Of cls_CE_usuarios)
        Dim obj As New cls_CD_usuarios
        CN_recuperarUsuarios = obj.CD_recuperarUsuarios(ci)

    End Function
    Function CN_recuperarPerfiles() As DataTable
        Dim obj As New cls_CD_usuarios
        CN_recuperarPerfiles = obj.CD_recuperarPerfiles
    End Function
    Function CN_fun_GrabarUsurio(ByVal lista As List(Of cls_CE_usuarios)) As Boolean
        Dim obj As New cls_CD_usuarios
        CN_fun_GrabarUsurio = obj.CD_fun_GrabarUsurio(lista)
    End Function
    Function Cn_fun_usuarioexiste(ByVal usuario As String, ByVal id_usuario As Integer) As Boolean

        Dim obj As New cls_CD_usuarios
        obj.CD_fun_usuarioexiste(usuario, id_usuario)
    End Function
    Function fun_buscarusuariosxApe(txt_buscar) As List(Of cls_CE_usuarios)
        Dim obj As New cls_CD_usuarios
        fun_buscarusuariosxApe = obj.fun_buscarusuariosxApe(txt_buscar)
    End Function
End Class
