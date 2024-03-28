Imports CapaEntidad
Imports CapaDatos
Public Class cls_CN_Menu
    Function fun_CD_CargarDatos() As List(Of cls_CE_Menu)
        Dim obj As New cls_CD_Menu
        fun_CD_CargarDatos = obj.fun_CD_CargarDatos
    End Function
    Function CN_btn_Grabar(ByVal chk_agregar As Boolean, ByVal chk_estado As Boolean, ByVal txt_nodopadre As String, ByVal txt_nodoHijo As String, ByVal txt_descripcion As String,
           ByVal txt_pos As String, ByVal chk_frm_Asociado As Boolean, ByVal txt_nombreformulario As String, ByVal rbtn_subMenu As Boolean, ByVal txt_descripcionSub As String,
             ByVal txt_posSub As String, ByVal txt_nombreformularioSub As String, ByVal chk_frm_AsociadoSub As Boolean) As Boolean

        Dim obj As New cls_CD_Menu
        CN_btn_Grabar = obj.CD_btn_Grabar(chk_agregar, chk_estado, txt_nodopadre, txt_nodoHijo, txt_descripcion,
            txt_pos, chk_frm_Asociado, txt_nombreformulario, rbtn_subMenu, txt_descripcionSub,
              txt_posSub, txt_nombreformularioSub, chk_frm_AsociadoSub)




    End Function
    Function CN_recuperardatos(ByVal descripcionp As String, ByVal descripcionh As String) As List(Of cls_CE_Menu)
        Dim obj As New cls_CD_Menu
        CN_recuperardatos = obj.CD_recuperardatos(descripcionp, descripcionh)
    End Function
End Class
