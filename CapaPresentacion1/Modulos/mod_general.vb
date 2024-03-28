Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text.RegularExpressions

Module mod_general
    Public g_str_nombre_usuario As String
    Public g_str_id_usuario As Integer
    Public g_str_perfilusuario As Integer
    Public formatodecimal As String = "##,##0.00"
    Public g_str_Fecha As String

    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)
    End Function

    Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function
    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Public Function fun_validacedula(ByVal cedula As String) As Boolean
        fun_validacedula = False
        Dim tamanioc As Integer
        tamanioc = Int(Len(cedula))
        Dim u_digito, i As Integer
        Dim ST, SP, SI, digitov, SD As Integer
        ST = 0
        SP = 0
        SI = 0
        If tamanioc = 10 And IsNumeric(cedula) Then

            u_digito = Int(Mid(cedula, 10, 1))
            For i = 1 To 9
                If (i Mod 2) = 0 Then
                    'par
                    SP = SP + Int(Mid(cedula, i, 1))
                Else
                    'impar
                    If (Int(Mid(cedula, i, 1)) * 2) > 9 Then
                        SI = SI + ((Int(Mid(cedula, i, 1)) * 2) - 9)
                    Else
                        SI = SI + (Int(Mid(cedula, i, 1)) * 2)
                    End If
                End If
            Next
            ST = SP + SI
            SD = ST
            If (SD Mod 10) = 0 Then
                digitov = 0
            Else
                While ((SD Mod 10) <> 0)
                    SD = SD + 1
                End While
                digitov = SD - ST
            End If
            If digitov = u_digito Then
                fun_validacedula = True
            Else
                fun_validacedula = False
            End If
        Else
            fun_validacedula = False
        End If
    End Function
End Module
