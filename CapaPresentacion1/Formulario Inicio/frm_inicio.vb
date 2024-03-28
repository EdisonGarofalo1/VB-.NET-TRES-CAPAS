Imports System.IO
Imports CapaNegocios

Imports CapaEntidad
Public Class frm_inicio
    Dim str_cadenaConexion As String
    Private Sub frm_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_usuario.Text = "root"
            txt_clave.Text = "sa"
            If fun_leerDatosConexion() = False Then
                MsgBox("Error al iniciar,comunique al proveedor...")
                Me.Close()
            Else
                Dim obj As New cls_CN_AccesoBD
                If obj.CN_fun_verificaConec(str_cadenaConexion) = True Then
                    'MsgBox("Se Conecto con exito")
                Else
                    MsgBox("Error al Conectar....")
                    Me.Close()
                End If

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Function fun_leerDatosConexion() As Boolean

        Try
            fun_leerDatosConexion = False

            Dim str_servidor As String = ""
            Dim str_Base As String = ""
            Dim str_usuario As String = ""
            Dim str_clave As String = ""


            Dim Directorio As String = ""
            Directorio = System.AppDomain.CurrentDomain.BaseDirectory() & "DatosParaConectar.txt" 'busca donde esta el archivo
            Dim objeto As New StreamReader(Directorio) 'permite leerel  archivo que creaste
            Dim vector_txt As New ArrayList()
            Dim lineas_txt As String = ""
            Do
                lineas_txt = objeto.ReadLine
                If Not lineas_txt Is Nothing Then
                    vector_txt.Add(lineas_txt)
                End If
            Loop Until lineas_txt Is Nothing
            objeto.Close()

            Dim cadena As String = ""
            For Each lineas_txt In vector_txt
                cadena = cadena & lineas_txt
            Next
            Dim cortar = cadena.Split(":")
            str_servidor = cortar(1)
            str_Base = cortar(3)
            str_usuario = cortar(5)
            str_clave = cortar(7)
            g_str_Fecha = cortar(9)
            If str_usuario = "" Then
                ' conectar sin clave
                str_cadenaConexion = "Data Source=" & str_servidor & ";Initial Catalog=" & str_Base & " ; Integrated Security=true;"
            Else
                ' conectar con clave
                str_cadenaConexion = "Data Source=" & str_servidor & ";Initial Catalog=" & str_Base & ";User ID=" & str_usuario & ";password=" & str_clave
            End If
            fun_leerDatosConexion = True
        Catch ex As Exception
            fun_leerDatosConexion = False
            MsgBox(ex.Message)

        End Try
    End Function


    Function fun_leerdatos() As Boolean
        Try
            fun_leerdatos = False

            Dim str_servidor As String
            Dim str_BD As String
            Dim str_usuario As String
            Dim str_clave As String

            Dim directorio As String

            directorio = System.AppDomain.CurrentDomain.BaseDirectory() & "DatosParaConectar.txt"

            Dim objReader As New StreamReader(directorio)
            Dim sline As String = ""
            Dim arrText As New ArrayList()
            Do
                sline = objReader.ReadLine
                If Not sline Is Nothing Then
                    arrText.Add(sline)
                End If
            Loop Until sline Is Nothing
            objReader.Close()

            Dim cadena As String = ""
            For Each sline In arrText
                cadena = cadena & sline
            Next
            Dim arr = cadena.Split(":")

            str_servidor = arr(1)
            str_BD = arr(3)
            str_usuario = arr(5)
            str_clave = arr(7)
            If str_usuario <> "" Then
                str_cadenaConexion = "Data Source=" & str_servidor &
            ";Initial Catalog=" & str_BD & ";User ID=" & str_usuario & ";password=" & str_clave
            Else
                str_cadenaConexion = "Data Sourse=" & str_servidor & " ; Initial catalog= " & str_BD & ";Integrated Security=true; "
            End If
            fun_leerdatos = True

        Catch ex As Exception
            fun_leerdatos = False
        End Try
    End Function
    Function fun_verificar() As Boolean
        Try
            fun_verificar = False
            If txt_usuario.Text = "" Then
                MsgBox("Ingrese el Nombre del Usuario")
                txt_usuario.Focus()
                Exit Function
            End If
            If txt_clave.Text = "" Then
                MsgBox("Ingrese la clave del Usuario")
                txt_clave.Focus()
                Exit Function
            End If
            fun_verificar = True
        Catch ex As Exception
            fun_verificar = False
        End Try
    End Function



  

    Private Sub btn_Aceptar_Click_1(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Try
            Dim lista As New List(Of cls_CE_AccesoBD)
            Dim obj As New cls_CN_AccesoBD
            If fun_verificar() = False Then
                Exit Sub
            End If
            lista = obj.CN_fun_ListaUsuario(txt_usuario.Text, txt_clave.Text)
            If lista IsNot Nothing Then
                g_str_nombre_usuario = lista(0).Nombre_usuario
                g_str_id_usuario = lista(0).Id_usuario
                g_str_perfilusuario = lista(0).Perfilusuario
                Dim frm As New frm_Principal
                Me.Hide()
                frm.Show()
            Else
                MsgBox("Usuario o Clave Incorrecta")
                txt_usuario.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class