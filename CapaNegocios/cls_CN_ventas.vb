Imports CapaEntidad
Imports CapaDatos
Public Class cls_CN_ventas
    Function fun_recuperar_cabezera(ByVal num As String) As cls_CE_ventas
        Try
            Dim obj As New cls_CD_ventas
            fun_recuperar_cabezera = obj.fun_CD_recuperar_cabezera(num)
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_recuperar_cabezera = Nothing
        End Try
    End Function

    Function fun_CN_lineas() As Integer

        Dim obj As New cls_CD_ventas
        fun_CN_lineas = obj.fun_CD_lineas

    End Function

    Function fun_CN_recuperar_detalles(ByVal nun_doc As String) As List(Of cls_CE_detalleventa)
        Try

            Dim obj As New cls_CD_ventas
            fun_CN_recuperar_detalles = obj.fun_CD_recuperar_detalles(nun_doc)
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_CN_recuperar_detalles = Nothing
        End Try
    End Function
    Function fun_CN_recuperar_cliente(ByVal nun_doc As String) As cls_CE_clientes
        Try

            Dim obj As New cls_CD_ventas
            fun_CN_recuperar_cliente = obj.fun_CD_recuperar_cliente(nun_doc)
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_CN_recuperar_cliente = Nothing
        End Try
    End Function

    Function cls_CN_cargarproducto(ByVal buscar As String) As List(Of cls_CE_producto)
        Try
            Dim obj As New cls_CD_ventas
            cls_CN_cargarproducto = obj.cls_CD_Buscarproducto(buscar)
        Catch ex As Exception
            MsgBox(ex.Message)
            cls_CN_cargarproducto = Nothing
        End Try
    End Function

    Function fun_CN_carProducto(ByVal codigo As String) As List(Of cls_CE_producto)
        Try
            Dim obj As New cls_CD_ventas
            fun_CN_carProducto = obj.fun_carProducto(codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_CN_carProducto = Nothing
        End Try
    End Function

    Function fun_CN_Grabar(ByVal lista_1 As List(Of cls_CE_ventas), ByVal lista_2 As List(Of cls_CE_detalleventa)) As Boolean
        Try
            Dim obj As New cls_CD_ventas
            fun_CN_Grabar = obj.fun_CD_Grabar(lista_1, lista_2)
        Catch ex As Exception
            MsgBox(ex.Message)
            fun_CN_Grabar = Nothing
        End Try
    End Function
End Class
