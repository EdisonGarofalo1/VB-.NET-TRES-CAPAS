Imports CapaEntidad
Public Class cls_CD_Principal
    Public Sub New(ByRef cadenaConec As String)
        str_cadenaConexion = cadenaConec
    End Sub
    Public Sub New()
    End Sub


    Function CD_cargar_menu(ByVal id_Perfil As String) As List(Of Principal_CE_AcessoBD)
        Try
            CD_cargar_menu = Nothing
            Dim lista As New List(Of Principal_CE_AcessoBD)
            Dim cadenasql As String = ""
            cadenasql = cadenasql & "select m.* from seg_menu m "
            cadenasql = cadenasql & "where men_estado = 'A'  and men_Id in "
            cadenasql = cadenasql & "(select men_Id from seg_accesos "
            cadenasql = cadenasql & " where per_id=" & id_Perfil & " and acc_estado='A')"

            If conectar() = False Then
                Exit Function
            End If

            dr = fun_ExecuteReader(cadenasql)

            If dr.HasRows Then
                While dr.Read
                    Dim registro As New Principal_CE_AcessoBD
                    With registro

                        .Men_Id = IIf(dr("men_Id") Is DBNull.Value, 0, dr("men_Id"))
                        .Men_Id_MenuPadre = IIf(dr("men_Id_MenuPadre") Is DBNull.Value, 0, dr("men_Id_MenuPadre"))
                        .Men_Descripcion = IIf(dr("men_Descripcion") Is DBNull.Value, "", dr("men_Descripcion"))
                        .Men_Posicion = IIf(dr("men_Posicion") Is DBNull.Value, 0, dr("men_Posicion"))
                        .Men_ForAsociado = IIf(dr("men_ForAsociado") Is DBNull.Value, 0, dr("men_ForAsociado"))
                        .Men_nombreFrm = IIf(dr("men_nombreFrm") Is DBNull.Value, "", dr("men_nombreFrm"))
                        .Men_estado = IIf(dr("men_estado") Is DBNull.Value, "", dr("men_estado"))


                    End With
                    lista.Add(registro)

                End While
            End If
            desconectar()

            Return lista

        Catch ex As Exception
            CD_cargar_menu = Nothing
        End Try

        ' cargar data table a partior de un dataread



    End Function
End Class
