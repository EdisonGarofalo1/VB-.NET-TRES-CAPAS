Imports CapaEntidad
Public Class cls_CD_ventas
    Dim id_cabezera As Long = 0
    Public g_str_fecha_salida As String = "dd/MM/yyyy"

    Function fun_CD_lineas() As Integer
        Try
            fun_CD_lineas = 0
            Dim valor As Integer = 0
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & " select DEtP_valor "
            str_cadenaSql = str_cadenaSql & " from DET_PARAMETRICA"
            str_cadenaSql = str_cadenaSql & "  where CABP_id=(select CABP_ID from CAB_PARAMETRICA where CABP_ESTADO='True' and CABP_CODIGO='TAM_FAC')"
            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader(str_cadenaSql)
            If dr.HasRows Then
                While dr.Read
                    valor = dr("DEtP_valor")
                End While
            End If
            Return valor
        Catch ex As Exception
            fun_CD_lineas = 0
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function


    Function fun_CD_recuperar_cabezera(ByVal num As String) As cls_CE_ventas
        Try
            fun_CD_recuperar_cabezera = Nothing
            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader("sp_selCabFactura", num)
            Dim obj As New cls_CE_ventas
            If dr.HasRows Then
                While dr.Read
                    With obj
                        .CABMOV_ID = dr("CABMOV_ID")
                        .PER_IDENTIFICACION = dr("PER_IDENTIFICACION")
                        .PER_NOMBRES = dr("PER_NOMBRES")
                        .PER_DIRECCION = dr("PER_DIRECCION")
                        .PER_TELEFONO = dr("PER_TELEFONO")
                        .CABMOV_BASE_IMPONIBLE = dr("CABMOV_BASE_IMPONIBLE")
                        .CABMOV_IVA = dr("CABMOV_IVA")
                        .CABMOV_VALOR_FINAL = dr("CABMOV_VALOR_FINAL")
                        .CABMOV_FECHA = dr("CABMOV_FECHA")
                    End With
                End While
            End If
            Return obj
        Catch ex As Exception
            fun_CD_recuperar_cabezera = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function

    Function fun_CD_recuperar_detalles(ByVal nun_doc As String) As List(Of cls_CE_detalleventa)
        Try
            fun_CD_recuperar_detalles = Nothing
            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader("sp_selDetalleFactura", nun_doc)

            Dim lista As New List(Of cls_CE_detalleventa)
            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_detalleventa
                    With obj
                        .PRO_ID = dr("PRO_ID")
                        .PRO_CODIGO = dr("PRO_CODIGO")
                        .PRO_DESCRIPCION = dr("PRO_DESCRIPCION")
                        .DET_CANTIDAD = dr("DET_CANTIDAD")
                        .PRO_PRECIO = dr("DET_PRECIO")
                        .DET_BASE_IMPONIBLE = dr("DET_BASE_IMPONIBLE")
                        .PRO_LLEVA_IVA = dr("PRO_LLEVA_IVA")
                        .DET_IVA = dr("DET_IVA")
                    End With
                    lista.Add(obj)
                End While
                Return lista
            End If

        Catch ex As Exception
            fun_CD_recuperar_detalles = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function

    Function fun_CD_recuperar_cliente(ByVal nun_doc As String) As cls_CE_clientes
        Try
            fun_CD_recuperar_cliente = Nothing
            Dim str_cadenaSql As String
            str_cadenaSql = "select * from  personas where per_identificacion = '" & nun_doc & "'"

            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader(str_cadenaSql)
            Dim obj As New cls_CE_clientes
            If dr.HasRows Then
                While dr.Read
                    obj.PER_NOMBRES = dr("per_nombres")
                    obj.PER_DIRECCION = dr("per_direccion")
                    obj.PER_TELEFONO = dr("per_telefono")
                    obj.PER_ID = dr("PER_ID")
                End While
                Return obj
            End If
        Catch ex As Exception
            fun_CD_recuperar_cliente = Nothing
            MsgBox(ex.Message)
        Finally
            desconectar()
            dr.Close()
        End Try
    End Function

    Function cls_CD_Buscarproducto(ByVal buscar As String) As List(Of cls_CE_producto)
        Try
            cls_CD_Buscarproducto = Nothing
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & " select top 10 PRO_id,PRO_CODIGO,PRO_descripcion,PRO_PRECIO,PRO_LLEVA_IVA,PRO_estado "
            str_cadenaSql = str_cadenaSql & " from PRODUCTOS"
            str_cadenaSql = str_cadenaSql & " where PRO_descripcion like '" & buscar & "%'"
            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader(str_cadenaSql)

            Dim lista As New List(Of cls_CE_producto)
            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_producto
                    With obj

                        .PRO_CODIGO = dr("PRO_CODIGO")
                        .PRO_DESCRIPCION = dr("PRO_descripcion")
                        .PRO_PRECIO = dr("PRO_PRECIO")
                    End With
                    lista.Add(obj)
                End While
                Return lista
            End If
        Catch ex As Exception
            cls_CD_Buscarproducto = Nothing
            MsgBox(ex.Message)
            desconectar()
            dr.Close()
        End Try
    End Function

    Function fun_carProducto(ByVal codigo As String) As List(Of cls_CE_producto)
        Try
            fun_carProducto = Nothing
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & " select PRO_ID,PRO_CODIGO,PRO_DESCRIPCION,PRO_PRECIO,PRO_LLEVA_IVA "
            str_cadenaSql = str_cadenaSql & " from PRODUCTOS "
            str_cadenaSql = str_cadenaSql & "  where PRO_ESTADO='A' and PRO_CODIGO='" & codigo & "'"
            If conectar() = False Then
                Exit Function
            End If
            dr = fun_ExecuteReader(str_cadenaSql)
            Dim lista As New List(Of cls_CE_producto)
            If dr.HasRows Then
                While dr.Read
                    Dim obj As New cls_CE_producto
                    With obj

                        .PRO_ID = IIf(dr("PRO_ID") Is Nothing, 0, dr("PRO_ID"))
                        .PRO_DESCRIPCION = IIf(dr("PRO_DESCRIPCION") Is Nothing, "", dr("PRO_DESCRIPCION"))
                        .PRO_LLEVA_IVA = IIf(dr("PRO_LLEVA_IVA") Is Nothing, False, dr("PRO_LLEVA_IVA"))
                        .PRO_PRECIO = IIf(dr("PRO_PRECIO") Is Nothing, 0, dr("PRO_PRECIO"))

                    End With
                    lista.Add(obj)
                End While
                Return lista
            End If
        Catch ex As Exception
            fun_carProducto = Nothing
            MsgBox(ex.Message)
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function

    Function fun_grabar_detalles(ByVal lista_2 As List(Of cls_CE_detalleventa)) As Boolean
        Try
            fun_grabar_detalles = False


            For i = 0 To lista_2.Count - 1
                Dim str_cadenasql As String = ""
                str_cadenasql = str_cadenasql & " INSERT INTO [dbo].[DET_MOVIMIENTO] ([CABMOV_ID] ,[PROD_ID] ,[DET_CANTIDAD] ,[DET_PRECIO] ,[DET_BASE_IMPONIBLE] ,[DET_IVA] ,[DET_TOTAL] ,[DET_ESTADO]) "
                str_cadenasql = str_cadenasql & " values ( " & id_cabezera & ", "
                str_cadenasql = str_cadenasql & lista_2(i).CAT_ID & " , "
                str_cadenasql = str_cadenasql & lista_2(i).DET_CANTIDAD & " , "
                str_cadenasql = str_cadenasql & lista_2(i).PRO_PRECIO & " , "
                str_cadenasql = str_cadenasql & lista_2(i).DET_BASE_IMPONIBLE & " , "
                str_cadenasql = str_cadenasql & lista_2(i).DET_IVA & " , "
                str_cadenasql = str_cadenasql & lista_2(i).DET_TOTAL & " , "
                str_cadenasql = str_cadenasql & " 'A' ) "
                If fun_ExecuteNonQuery(str_cadenasql) = False Then
                    fun_grabar_detalles = False
                    Exit Function
                End If
            Next

            Return True
        Catch ex As Exception
            fun_grabar_detalles = False
            MsgBox(ex.Message)
        End Try
    End Function

    Function fun_grabar_cabezera(ByVal lista_1 As List(Of cls_CE_ventas)) As Boolean
        Try
            fun_grabar_cabezera = False
            Dim str_cadenasql As String = ""

            For i = 0 To lista_1.Count - 1
                str_cadenasql = str_cadenasql & "INSERT INTO [dbo].[CAB_MOVIMIENTO]([CABMOV_NUM_DOC] ,[TIPMOV_ID] ,[CABMOVIMIENTO] ,[PER_ID] ,[CABMOV_FECHA],[CABMOV_BASE_IMPONIBLE]  ,[CABMOV_IVA]  ,[CABMOV_VALOR_FINAL] ,[CABMOV_ESTADO] ,[USUARIO] ,[FECHA_INGRESO],[FECHA_MODIFIC]) "

                str_cadenasql = str_cadenasql & " values ( "
                str_cadenasql = str_cadenasql & lista_1(i).CABMOV_NUM_DOC & " , "
                str_cadenasql = str_cadenasql & 1 & " , '"
                str_cadenasql = str_cadenasql & "EGR' , "
                str_cadenasql = str_cadenasql & lista_1(i).PER_ID & " , '"
                str_cadenasql = str_cadenasql & lista_1(i).CABMOV_FECHA & "'  , "
                str_cadenasql = str_cadenasql & lista_1(i).CABMOV_BASE_IMPONIBLE & " , "
                str_cadenasql = str_cadenasql & lista_1(i).CABMOV_IVA & " , "
                str_cadenasql = str_cadenasql & lista_1(i).CABMOV_VALOR_FINAL & " , "
                str_cadenasql = str_cadenasql & " 'A' , "
                str_cadenasql = str_cadenasql & lista_1(i).USUARIO & " , '"
                str_cadenasql = str_cadenasql & lista_1(i).CABMOV_FECHA & "' , '"
                str_cadenasql = str_cadenasql & lista_1(i).CABMOV_FECHA & "' ) "
            Next

            If fun_ExecuteNonQuery(str_cadenasql) = True Then
                Return True
            End If
        Catch ex As Exception
            fun_grabar_cabezera = False
        End Try
    End Function
    Function fun_recuperar_cabezera(ByVal nun_doc As String) As Boolean
        Try
            fun_recuperar_cabezera = False
            Dim str_cadenasql As String = " select * from CAB_MOVIMIENTO where CABMOV_NUM_DOC =" & nun_doc

            dr = fun_ExecuteReader(str_cadenasql)
            If dr.HasRows Then
                While dr.Read
                    id_cabezera = dr("CABMOV_ID")
                End While
                Return True
            End If

        Catch ex As Exception
            fun_recuperar_cabezera = False
        Finally
            dr.Close()
        End Try
    End Function

    Function fun_CD_Grabar(ByVal lista_1 As List(Of cls_CE_ventas), ByVal lista_2 As List(Of cls_CE_detalleventa)) As Boolean
        Try
            fun_CD_Grabar = False

            If conectar() = False Then
                Exit Function

            End If
            If funIniciarTrans() = False Then
                Exit Function
            End If

            If fun_grabar_cabezera(lista_1) = False Then
                funRollbacktrans()
                Exit Function
            End If
            If fun_recuperar_cabezera(lista_1(0).CABMOV_NUM_DOC) = False Then
                funRollbacktrans()
                Exit Function
            End If

            If fun_grabar_detalles(lista_2) = False Then
                funRollbacktrans()
                Exit Function
            End If

            If funComittrans() = False Then
                funRollbacktrans()
                Exit Function
            End If
            Return True
        Catch ex As Exception
            fun_CD_Grabar = False
            MsgBox(ex.Message)

        Finally
            desconectar()
        End Try
    End Function


    Private Function funIniciarTrans() As Boolean
        Try
            funIniciarTrans = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & "begin tran facturarCompras"
            If fun_ExecuteNonQuery(str_cadenaSql) = False Then ''
                Exit Function
            End If

            funIniciarTrans = True

        Catch ex As Exception
            funIniciarTrans = False
        End Try
    End Function
    Private Function funRollbacktrans() As Boolean
        Try
            funRollbacktrans = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & "rollback tran facturarCompras"
            If fun_ExecuteNonQuery(str_cadenaSql) = False Then ''
                Exit Function
            End If

            funRollbacktrans = True

        Catch ex As Exception
            funRollbacktrans = False

        End Try
    End Function

    Private Function funComittrans() As Boolean
        Try
            funComittrans = False
            Dim str_cadenaSql As String = ""
            str_cadenaSql = str_cadenaSql & "commit tran facturarCompras"
            If fun_ExecuteNonQuery(str_cadenaSql) = False Then ''
                Exit Function
            End If

            funComittrans = True

        Catch ex As Exception
            funComittrans = False

        End Try
    End Function

End Class
