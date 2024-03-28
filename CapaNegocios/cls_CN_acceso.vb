Imports CapaDatos
Imports CapaEntidad

Public Class cls_CN_acceso
    Function fun_cargar_perfiles() As DataTable
        Dim obj As New cls_CD_acceso
        fun_cargar_perfiles = obj.CD_recuperarPerfiles
    End Function

    Function CD_recuperardatos(ByVal descripcionp As String, ByVal descripcionh As String) As List(Of Integer)
        Dim obj As New cls_CD_acceso
        CD_recuperardatos = obj.CD_recuperardatos(descripcionp, descripcionh)
    End Function
    Function fun_CN_Cargar_accesos(ByVal cbo_perfil As String, ByVal int_cod_padre As Integer) As List(Of cls_CE_acceso)
        Dim obj As New cls_CD_acceso
        fun_CN_Cargar_accesos = obj.fun_CD_Cargar_accesos(cbo_perfil, int_cod_padre)
    End Function
    Function fun_CN_grabar_acceso(ByVal c_codigo As Integer, ByVal cbo_perfil As Integer, ByVal c_m_codigo As Integer, ByVal estado As String, ByVal c_men_accion As Integer) As Boolean
        Dim obj As New cls_CD_acceso
        fun_CN_grabar_acceso = obj.fun_CD_grabar_acceso(c_codigo, cbo_perfil, c_m_codigo, estado, c_men_accion)
    End Function


End Class
