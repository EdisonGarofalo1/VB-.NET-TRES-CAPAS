Imports CapaEntidad
Imports CapaDatos
Public Class cls_CN_compras
    Function fun_recuperar_cabezera(ByVal num As String) As cls_CE_facturas
        Try
            Dim obj As New cls_CD_compras
            fun_recuperar_cabezera = obj.fun_CD_recuperar_cabezera(num)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN_lineas() As Integer
        Try


            Dim obj As New cls_CD_compras
            fun_CN_lineas = obj.fun_CD_lineas
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function fun_CN_recuperar_detalles(ByVal nun_doc As String) As List(Of cls_CE_detalleFactura)
        Try

            Dim obj As New cls_CD_compras
            fun_CN_recuperar_detalles = obj.fun_CD_recuperar_detalles(nun_doc)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN_recuperar_usuario(ByVal nun_doc As String) As cls_CE_clientes
        Try

            Dim obj As New cls_CD_compras
            fun_CN_recuperar_usuario = obj.fun_CD_recuperar_usuario(nun_doc)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function cls_CN_cargarproducto(ByVal buscar As String) As List(Of cls_CE_producto)
        Try
            Dim obj As New cls_CD_compras
            cls_CN_cargarproducto = obj.cls_CD_cargarproducto(buscar)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN_carProducto(ByVal codigo As String) As List(Of cls_CE_producto)
        Try
            Dim obj As New cls_CD_compras
            fun_CN_carProducto = obj.fun_carProducto(codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function fun_CN_Grabar(ByVal lista_1 As cls_CE_facturas, ByVal lista_2 As List(Of cls_CE_detalleFactura)) As Boolean
        Try
            Dim obj As New cls_CD_compras
            fun_CN_Grabar = obj.fun_CD_Grabar(lista_1, lista_2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Class
