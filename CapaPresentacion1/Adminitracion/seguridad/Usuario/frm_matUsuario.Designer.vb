<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_matUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_validar = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_apellidos = New System.Windows.Forms.TextBox()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_perfil = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_buscausuario = New System.Windows.Forms.Button()
        Me.pb_foto = New System.Windows.Forms.PictureBox()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btn_buscausuario)
        Me.GroupBox1.Controls.Add(Me.chk_validar)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_correo)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_cedula)
        Me.GroupBox1.Controls.Add(Me.txt_clave)
        Me.GroupBox1.Controls.Add(Me.txt_usuario)
        Me.GroupBox1.Controls.Add(Me.txt_apellidos)
        Me.GroupBox1.Controls.Add(Me.txt_nombres)
        Me.GroupBox1.Controls.Add(Me.chk_estado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbo_perfil)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 269)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'chk_validar
        '
        Me.chk_validar.AutoSize = True
        Me.chk_validar.Location = New System.Drawing.Point(289, 35)
        Me.chk_validar.Name = "chk_validar"
        Me.chk_validar.Size = New System.Drawing.Size(75, 17)
        Me.chk_validar.TabIndex = 21
        Me.chk_validar.Text = "No Validar"
        Me.chk_validar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btn_buscar)
        Me.GroupBox3.Controls.Add(Me.pb_foto)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(414, 39)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(171, 191)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Foto"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(37, 161)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(98, 24)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Examinar....."
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Dirección:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(210, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Correo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Teléfono:"
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(271, 170)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(116, 20)
        Me.txt_correo.TabIndex = 8
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(89, 170)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(108, 20)
        Me.txt_telefono.TabIndex = 7
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(89, 144)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(298, 20)
        Me.txt_direccion.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cédula:*"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(89, 33)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(151, 20)
        Me.txt_cedula.TabIndex = 3
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(89, 234)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(298, 20)
        Me.txt_clave.TabIndex = 10
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(89, 201)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(298, 20)
        Me.txt_usuario.TabIndex = 9
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Location = New System.Drawing.Point(89, 118)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(298, 20)
        Me.txt_apellidos.TabIndex = 5
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(89, 90)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(298, 20)
        Me.txt_nombres.TabIndex = 4
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Location = New System.Drawing.Point(520, 16)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(59, 17)
        Me.chk_estado.TabIndex = 0
        Me.chk_estado.Text = "Estado"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Clave: *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Usuario: *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Apellidos: *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombres: *"
        '
        'cbo_perfil
        '
        Me.cbo_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_perfil.FormattingEnabled = True
        Me.cbo_perfil.Location = New System.Drawing.Point(89, 60)
        Me.cbo_perfil.Name = "cbo_perfil"
        Me.cbo_perfil.Size = New System.Drawing.Size(298, 21)
        Me.cbo_perfil.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pérfil:*"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.btn_nuevo)
        Me.GroupBox2.Controls.Add(Me.btn_grabar)
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(596, 93)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(258, 19)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(103, 68)
        Me.btn_nuevo.TabIndex = 2
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancelar.Image = Global.CapaPresentacion1.My.Resources.Resources.cancel
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(476, 19)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(103, 68)
        Me.btn_cancelar.TabIndex = 0
        Me.btn_cancelar.Text = "Cerrar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_buscausuario
        '
        Me.btn_buscausuario.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_buscausuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_buscausuario.Image = Global.CapaPresentacion1.My.Resources.Resources.FindMedium1
        Me.btn_buscausuario.Location = New System.Drawing.Point(246, 29)
        Me.btn_buscausuario.Name = "btn_buscausuario"
        Me.btn_buscausuario.Size = New System.Drawing.Size(37, 24)
        Me.btn_buscausuario.TabIndex = 22
        Me.btn_buscausuario.Text = "?"
        Me.btn_buscausuario.UseVisualStyleBackColor = False
        '
        'pb_foto
        '
        Me.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_foto.Location = New System.Drawing.Point(6, 25)
        Me.pb_foto.Name = "pb_foto"
        Me.pb_foto.Size = New System.Drawing.Size(159, 130)
        Me.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto.TabIndex = 0
        Me.pb_foto.TabStop = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_grabar.Image = Global.CapaPresentacion1.My.Resources.Resources.save1
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(367, 19)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(103, 68)
        Me.btn_grabar.TabIndex = 1
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'frm_matUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 428)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frm_matUsuario"
        Me.Text = "frm_matUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_buscausuario As Button
    Friend WithEvents chk_validar As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents pb_foto As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_apellidos As TextBox
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents chk_estado As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_perfil As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_cancelar As Button
End Class
