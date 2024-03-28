<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Me.gru_principal = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tvw_Menu = New System.Windows.Forms.TreeView()
        Me.gru_menu = New System.Windows.Forms.GroupBox()
        Me.gru_padre = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nodoHijo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_pos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_frm_Asociado = New System.Windows.Forms.CheckBox()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.txt_nombreformulario = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_nodopadre = New System.Windows.Forms.TextBox()
        Me.chk_agregar = New System.Windows.Forms.CheckBox()
        Me.gru_agregar = New System.Windows.Forms.GroupBox()
        Me.gru_datos = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_posSub = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chk_frm_AsociadoSub = New System.Windows.Forms.CheckBox()
        Me.txt_nombreformularioSub = New System.Windows.Forms.TextBox()
        Me.txt_descripcionSub = New System.Windows.Forms.TextBox()
        Me.rbtn_formularioAsociado = New System.Windows.Forms.RadioButton()
        Me.rbtn_subMenu = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_Grabar = New System.Windows.Forms.Button()
        Me.gru_principal.SuspendLayout()
        Me.gru_menu.SuspendLayout()
        Me.gru_padre.SuspendLayout()
        Me.gru_agregar.SuspendLayout()
        Me.gru_datos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gru_principal
        '
        Me.gru_principal.BackColor = System.Drawing.SystemColors.Control
        Me.gru_principal.Controls.Add(Me.Label1)
        Me.gru_principal.Controls.Add(Me.Tvw_Menu)
        Me.gru_principal.Controls.Add(Me.gru_menu)
        Me.gru_principal.Location = New System.Drawing.Point(32, 12)
        Me.gru_principal.Name = "gru_principal"
        Me.gru_principal.Size = New System.Drawing.Size(701, 435)
        Me.gru_principal.TabIndex = 5
        Me.gru_principal.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Menú Principal"
        '
        'Tvw_Menu
        '
        Me.Tvw_Menu.Location = New System.Drawing.Point(6, 37)
        Me.Tvw_Menu.Name = "Tvw_Menu"
        Me.Tvw_Menu.Size = New System.Drawing.Size(288, 334)
        Me.Tvw_Menu.TabIndex = 1
        '
        'gru_menu
        '
        Me.gru_menu.BackColor = System.Drawing.SystemColors.Control
        Me.gru_menu.Controls.Add(Me.gru_padre)
        Me.gru_menu.Controls.Add(Me.chk_agregar)
        Me.gru_menu.Controls.Add(Me.gru_agregar)
        Me.gru_menu.Location = New System.Drawing.Point(328, 15)
        Me.gru_menu.Name = "gru_menu"
        Me.gru_menu.Size = New System.Drawing.Size(362, 415)
        Me.gru_menu.TabIndex = 0
        Me.gru_menu.TabStop = False
        '
        'gru_padre
        '
        Me.gru_padre.BackColor = System.Drawing.SystemColors.Control
        Me.gru_padre.Controls.Add(Me.Label8)
        Me.gru_padre.Controls.Add(Me.Label6)
        Me.gru_padre.Controls.Add(Me.txt_nodoHijo)
        Me.gru_padre.Controls.Add(Me.Label5)
        Me.gru_padre.Controls.Add(Me.txt_pos)
        Me.gru_padre.Controls.Add(Me.Label3)
        Me.gru_padre.Controls.Add(Me.Label2)
        Me.gru_padre.Controls.Add(Me.chk_frm_Asociado)
        Me.gru_padre.Controls.Add(Me.chk_estado)
        Me.gru_padre.Controls.Add(Me.txt_nombreformulario)
        Me.gru_padre.Controls.Add(Me.txt_descripcion)
        Me.gru_padre.Controls.Add(Me.txt_nodopadre)
        Me.gru_padre.Location = New System.Drawing.Point(10, 16)
        Me.gru_padre.Name = "gru_padre"
        Me.gru_padre.Size = New System.Drawing.Size(344, 174)
        Me.gru_padre.TabIndex = 21
        Me.gru_padre.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Id Menú"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(153, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Id Padre"
        '
        'txt_nodoHijo
        '
        Me.txt_nodoHijo.Location = New System.Drawing.Point(13, 26)
        Me.txt_nodoHijo.Name = "txt_nodoHijo"
        Me.txt_nodoHijo.ReadOnly = True
        Me.txt_nodoHijo.Size = New System.Drawing.Size(133, 20)
        Me.txt_nodoHijo.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Posición:"
        '
        'txt_pos
        '
        Me.txt_pos.Location = New System.Drawing.Point(87, 78)
        Me.txt_pos.Name = "txt_pos"
        Me.txt_pos.Size = New System.Drawing.Size(44, 20)
        Me.txt_pos.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Nombre del Formulario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombre Menú:"
        '
        'chk_frm_Asociado
        '
        Me.chk_frm_Asociado.AutoSize = True
        Me.chk_frm_Asociado.Location = New System.Drawing.Point(13, 104)
        Me.chk_frm_Asociado.Name = "chk_frm_Asociado"
        Me.chk_frm_Asociado.Size = New System.Drawing.Size(121, 17)
        Me.chk_frm_Asociado.TabIndex = 22
        Me.chk_frm_Asociado.Text = "Formulario Asociado"
        Me.chk_frm_Asociado.UseVisualStyleBackColor = True
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Location = New System.Drawing.Point(240, 8)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(92, 17)
        Me.chk_estado.TabIndex = 21
        Me.chk_estado.Text = "Estado Activo"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'txt_nombreformulario
        '
        Me.txt_nombreformulario.Location = New System.Drawing.Point(13, 140)
        Me.txt_nombreformulario.Name = "txt_nombreformulario"
        Me.txt_nombreformulario.Size = New System.Drawing.Size(321, 20)
        Me.txt_nombreformulario.TabIndex = 20
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(86, 52)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(248, 20)
        Me.txt_descripcion.TabIndex = 19
        '
        'txt_nodopadre
        '
        Me.txt_nodopadre.Location = New System.Drawing.Point(156, 26)
        Me.txt_nodopadre.Name = "txt_nodopadre"
        Me.txt_nodopadre.ReadOnly = True
        Me.txt_nodopadre.Size = New System.Drawing.Size(151, 20)
        Me.txt_nodopadre.TabIndex = 18
        '
        'chk_agregar
        '
        Me.chk_agregar.AutoSize = True
        Me.chk_agregar.Checked = True
        Me.chk_agregar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_agregar.Location = New System.Drawing.Point(11, 196)
        Me.chk_agregar.Name = "chk_agregar"
        Me.chk_agregar.Size = New System.Drawing.Size(155, 20)
        Me.chk_agregar.TabIndex = 20
        Me.chk_agregar.Text = "Agregar Sub Menú"
        Me.chk_agregar.UseVisualStyleBackColor = True
        '
        'gru_agregar
        '
        Me.gru_agregar.BackColor = System.Drawing.SystemColors.Control
        Me.gru_agregar.Controls.Add(Me.gru_datos)
        Me.gru_agregar.Controls.Add(Me.rbtn_formularioAsociado)
        Me.gru_agregar.Controls.Add(Me.rbtn_subMenu)
        Me.gru_agregar.Location = New System.Drawing.Point(5, 222)
        Me.gru_agregar.Name = "gru_agregar"
        Me.gru_agregar.Size = New System.Drawing.Size(349, 187)
        Me.gru_agregar.TabIndex = 19
        Me.gru_agregar.TabStop = False
        '
        'gru_datos
        '
        Me.gru_datos.BackColor = System.Drawing.SystemColors.Control
        Me.gru_datos.Controls.Add(Me.Label7)
        Me.gru_datos.Controls.Add(Me.txt_posSub)
        Me.gru_datos.Controls.Add(Me.Label9)
        Me.gru_datos.Controls.Add(Me.Label10)
        Me.gru_datos.Controls.Add(Me.chk_frm_AsociadoSub)
        Me.gru_datos.Controls.Add(Me.txt_nombreformularioSub)
        Me.gru_datos.Controls.Add(Me.txt_descripcionSub)
        Me.gru_datos.Location = New System.Drawing.Point(6, 41)
        Me.gru_datos.Name = "gru_datos"
        Me.gru_datos.Size = New System.Drawing.Size(320, 137)
        Me.gru_datos.TabIndex = 24
        Me.gru_datos.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Posición:"
        '
        'txt_posSub
        '
        Me.txt_posSub.Location = New System.Drawing.Point(86, 48)
        Me.txt_posSub.Name = "txt_posSub"
        Me.txt_posSub.Size = New System.Drawing.Size(44, 20)
        Me.txt_posSub.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Nombre del Formulario"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Nombre Menú:"
        '
        'chk_frm_AsociadoSub
        '
        Me.chk_frm_AsociadoSub.AutoSize = True
        Me.chk_frm_AsociadoSub.Location = New System.Drawing.Point(12, 74)
        Me.chk_frm_AsociadoSub.Name = "chk_frm_AsociadoSub"
        Me.chk_frm_AsociadoSub.Size = New System.Drawing.Size(121, 17)
        Me.chk_frm_AsociadoSub.TabIndex = 30
        Me.chk_frm_AsociadoSub.Text = "Formulario Asociado"
        Me.chk_frm_AsociadoSub.UseVisualStyleBackColor = True
        '
        'txt_nombreformularioSub
        '
        Me.txt_nombreformularioSub.Location = New System.Drawing.Point(12, 110)
        Me.txt_nombreformularioSub.Name = "txt_nombreformularioSub"
        Me.txt_nombreformularioSub.Size = New System.Drawing.Size(294, 20)
        Me.txt_nombreformularioSub.TabIndex = 29
        '
        'txt_descripcionSub
        '
        Me.txt_descripcionSub.Location = New System.Drawing.Point(85, 22)
        Me.txt_descripcionSub.Name = "txt_descripcionSub"
        Me.txt_descripcionSub.Size = New System.Drawing.Size(217, 20)
        Me.txt_descripcionSub.TabIndex = 28
        '
        'rbtn_formularioAsociado
        '
        Me.rbtn_formularioAsociado.AutoSize = True
        Me.rbtn_formularioAsociado.Location = New System.Drawing.Point(141, 15)
        Me.rbtn_formularioAsociado.Name = "rbtn_formularioAsociado"
        Me.rbtn_formularioAsociado.Size = New System.Drawing.Size(144, 17)
        Me.rbtn_formularioAsociado.TabIndex = 23
        Me.rbtn_formularioAsociado.TabStop = True
        Me.rbtn_formularioAsociado.Text = "Asociado a un Formulario"
        Me.rbtn_formularioAsociado.UseVisualStyleBackColor = True
        '
        'rbtn_subMenu
        '
        Me.rbtn_subMenu.AutoSize = True
        Me.rbtn_subMenu.Location = New System.Drawing.Point(6, 15)
        Me.rbtn_subMenu.Name = "rbtn_subMenu"
        Me.rbtn_subMenu.Size = New System.Drawing.Size(74, 17)
        Me.rbtn_subMenu.TabIndex = 22
        Me.rbtn_subMenu.TabStop = True
        Me.rbtn_subMenu.Text = "Sub Menú"
        Me.rbtn_subMenu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.btn_limpiar)
        Me.GroupBox2.Controls.Add(Me.btn_nuevo)
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Controls.Add(Me.btn_Grabar)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 472)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 85)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(337, 15)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(88, 64)
        Me.btn_limpiar.TabIndex = 5
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(243, 15)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(88, 64)
        Me.btn_nuevo.TabIndex = 4
        Me.btn_nuevo.Text = "Nuevo Raíz"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(539, 15)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(88, 64)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Cerrar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_Grabar
        '
        Me.btn_Grabar.Location = New System.Drawing.Point(436, 15)
        Me.btn_Grabar.Name = "btn_Grabar"
        Me.btn_Grabar.Size = New System.Drawing.Size(88, 64)
        Me.btn_Grabar.TabIndex = 2
        Me.btn_Grabar.Text = "Grabar"
        Me.btn_Grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Grabar.UseVisualStyleBackColor = True
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 569)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gru_principal)
        Me.Name = "frm_menu"
        Me.Text = "frm_menu"
        Me.gru_principal.ResumeLayout(False)
        Me.gru_principal.PerformLayout()
        Me.gru_menu.ResumeLayout(False)
        Me.gru_menu.PerformLayout()
        Me.gru_padre.ResumeLayout(False)
        Me.gru_padre.PerformLayout()
        Me.gru_agregar.ResumeLayout(False)
        Me.gru_agregar.PerformLayout()
        Me.gru_datos.ResumeLayout(False)
        Me.gru_datos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gru_principal As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tvw_Menu As TreeView
    Friend WithEvents gru_menu As GroupBox
    Friend WithEvents gru_padre As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nodoHijo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_pos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chk_frm_Asociado As CheckBox
    Friend WithEvents chk_estado As CheckBox
    Friend WithEvents txt_nombreformulario As TextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_nodopadre As TextBox
    Friend WithEvents chk_agregar As CheckBox
    Friend WithEvents gru_agregar As GroupBox
    Friend WithEvents gru_datos As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_posSub As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents chk_frm_AsociadoSub As CheckBox
    Friend WithEvents txt_nombreformularioSub As TextBox
    Friend WithEvents txt_descripcionSub As TextBox
    Friend WithEvents rbtn_formularioAsociado As RadioButton
    Friend WithEvents rbtn_subMenu As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_Grabar As Button
End Class
