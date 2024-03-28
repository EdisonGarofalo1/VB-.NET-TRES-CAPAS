<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Accesos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Accesos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_Grabar = New System.Windows.Forms.Button()
        Me.gru_principal = New System.Windows.Forms.GroupBox()
        Me.Perfiles = New System.Windows.Forms.Label()
        Me.cbo_perfil = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tvw_Menu = New System.Windows.Forms.TreeView()
        Me.gru_menu = New System.Windows.Forms.GroupBox()
        Me.dgv_accesos = New System.Windows.Forms.DataGridView()
        Me.id_permisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.per_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.programa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.accion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.gru_principal.SuspendLayout()
        Me.gru_menu.SuspendLayout()
        CType(Me.dgv_accesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Controls.Add(Me.btn_Grabar)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 399)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(918, 85)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(689, 8)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(88, 64)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Cerrar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_Grabar
        '
        Me.btn_Grabar.Image = CType(resources.GetObject("btn_Grabar.Image"), System.Drawing.Image)
        Me.btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Grabar.Location = New System.Drawing.Point(560, 8)
        Me.btn_Grabar.Name = "btn_Grabar"
        Me.btn_Grabar.Size = New System.Drawing.Size(88, 64)
        Me.btn_Grabar.TabIndex = 2
        Me.btn_Grabar.Text = "Grabar"
        Me.btn_Grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Grabar.UseVisualStyleBackColor = True
        '
        'gru_principal
        '
        Me.gru_principal.BackColor = System.Drawing.SystemColors.Control
        Me.gru_principal.Controls.Add(Me.Perfiles)
        Me.gru_principal.Controls.Add(Me.cbo_perfil)
        Me.gru_principal.Controls.Add(Me.Label1)
        Me.gru_principal.Controls.Add(Me.Tvw_Menu)
        Me.gru_principal.Controls.Add(Me.gru_menu)
        Me.gru_principal.Location = New System.Drawing.Point(7, 1)
        Me.gru_principal.Name = "gru_principal"
        Me.gru_principal.Size = New System.Drawing.Size(918, 384)
        Me.gru_principal.TabIndex = 10
        Me.gru_principal.TabStop = False
        '
        'Perfiles
        '
        Me.Perfiles.AutoSize = True
        Me.Perfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Perfiles.Location = New System.Drawing.Point(13, 24)
        Me.Perfiles.Name = "Perfiles"
        Me.Perfiles.Size = New System.Drawing.Size(53, 16)
        Me.Perfiles.TabIndex = 18
        Me.Perfiles.Text = "Perfiles"
        '
        'cbo_perfil
        '
        Me.cbo_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_perfil.FormattingEnabled = True
        Me.cbo_perfil.Location = New System.Drawing.Point(72, 19)
        Me.cbo_perfil.Name = "cbo_perfil"
        Me.cbo_perfil.Size = New System.Drawing.Size(224, 21)
        Me.cbo_perfil.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 16
        '
        'Tvw_Menu
        '
        Me.Tvw_Menu.Location = New System.Drawing.Point(6, 66)
        Me.Tvw_Menu.Name = "Tvw_Menu"
        Me.Tvw_Menu.Size = New System.Drawing.Size(254, 302)
        Me.Tvw_Menu.TabIndex = 1
        '
        'gru_menu
        '
        Me.gru_menu.BackColor = System.Drawing.SystemColors.Control
        Me.gru_menu.Controls.Add(Me.dgv_accesos)
        Me.gru_menu.Location = New System.Drawing.Point(263, 66)
        Me.gru_menu.Name = "gru_menu"
        Me.gru_menu.Size = New System.Drawing.Size(636, 312)
        Me.gru_menu.TabIndex = 0
        Me.gru_menu.TabStop = False
        '
        'dgv_accesos
        '
        Me.dgv_accesos.AllowUserToAddRows = False
        Me.dgv_accesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_accesos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_permisos, Me.codigo, Me.per_codigo, Me.programa, Me.descripcion, Me.estado, Me.accion})
        Me.dgv_accesos.Location = New System.Drawing.Point(14, 33)
        Me.dgv_accesos.Name = "dgv_accesos"
        Me.dgv_accesos.Size = New System.Drawing.Size(616, 239)
        Me.dgv_accesos.TabIndex = 1
        '
        'id_permisos
        '
        Me.id_permisos.HeaderText = "Id Permisos"
        Me.id_permisos.Name = "id_permisos"
        Me.id_permisos.ReadOnly = True
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 80
        '
        'per_codigo
        '
        Me.per_codigo.HeaderText = "per_codigo"
        Me.per_codigo.Name = "per_codigo"
        Me.per_codigo.ReadOnly = True
        Me.per_codigo.Visible = False
        '
        'programa
        '
        Me.programa.HeaderText = "Menú"
        Me.programa.Name = "programa"
        Me.programa.ReadOnly = True
        Me.programa.Width = 180
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Formulario"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.estado.Width = 50
        '
        'accion
        '
        Me.accion.HeaderText = "Acción"
        Me.accion.Name = "accion"
        Me.accion.ReadOnly = True
        '
        'frm_Accesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 492)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gru_principal)
        Me.Name = "frm_Accesos"
        Me.Text = "frm_Accesos"
        Me.GroupBox2.ResumeLayout(False)
        Me.gru_principal.ResumeLayout(False)
        Me.gru_principal.PerformLayout()
        Me.gru_menu.ResumeLayout(False)
        CType(Me.dgv_accesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Grabar As System.Windows.Forms.Button
    Friend WithEvents gru_principal As System.Windows.Forms.GroupBox
    Friend WithEvents Perfiles As System.Windows.Forms.Label
    Friend WithEvents cbo_perfil As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tvw_Menu As System.Windows.Forms.TreeView
    Friend WithEvents gru_menu As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_accesos As System.Windows.Forms.DataGridView
    Friend WithEvents id_permisos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents per_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents programa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents accion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
