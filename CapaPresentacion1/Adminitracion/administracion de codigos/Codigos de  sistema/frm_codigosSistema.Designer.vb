<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_codigosSistema
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbo_varSistema = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_datos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.per_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PER_DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.per_estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ACCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.cbo_varSistema)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(577, 71)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'cbo_varSistema
        '
        Me.cbo_varSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_varSistema.FormattingEnabled = True
        Me.cbo_varSistema.Location = New System.Drawing.Point(11, 32)
        Me.cbo_varSistema.Name = "cbo_varSistema"
        Me.cbo_varSistema.Size = New System.Drawing.Size(227, 21)
        Me.cbo_varSistema.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar:"
        '
        'dgv_datos
        '
        Me.dgv_datos.AllowUserToAddRows = False
        Me.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.per_id, Me.PER_DESCRIPCION, Me.VALOR, Me.per_estado, Me.ACCION})
        Me.dgv_datos.Location = New System.Drawing.Point(5, 19)
        Me.dgv_datos.Name = "dgv_datos"
        Me.dgv_datos.Size = New System.Drawing.Size(628, 272)
        Me.dgv_datos.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'per_id
        '
        Me.per_id.HeaderText = "CÓDIGO"
        Me.per_id.Name = "per_id"
        '
        'PER_DESCRIPCION
        '
        Me.PER_DESCRIPCION.HeaderText = "DESCRIPCIÓN"
        Me.PER_DESCRIPCION.Name = "PER_DESCRIPCION"
        Me.PER_DESCRIPCION.Width = 250
        '
        'VALOR
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.VALOR.DefaultCellStyle = DataGridViewCellStyle1
        Me.VALOR.HeaderText = "VALOR"
        Me.VALOR.Name = "VALOR"
        '
        'per_estado
        '
        Me.per_estado.HeaderText = "ESTADO"
        Me.per_estado.Name = "per_estado"
        Me.per_estado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.per_estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.per_estado.Width = 60
        '
        'ACCION
        '
        Me.ACCION.HeaderText = "ACCION"
        Me.ACCION.Name = "ACCION"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btn_nuevo)
        Me.GroupBox2.Controls.Add(Me.btn_grabar)
        Me.GroupBox2.Controls.Add(Me.btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 382)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(577, 75)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(222, 14)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(80, 55)
        Me.btn_nuevo.TabIndex = 5
        Me.btn_nuevo.Text = "Añadir Fila"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(394, 14)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(80, 55)
        Me.btn_grabar.TabIndex = 4
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminar.Location = New System.Drawing.Point(308, 14)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(80, 55)
        Me.btn_eliminar.TabIndex = 3
        Me.btn_eliminar.Text = "Eliminar Fila"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(479, 14)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 55)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cerrar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.dgv_datos)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 297)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'frm_codigosSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 459)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_codigosSistema"
        Me.Text = "frm_codigosSistema"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbo_varSistema As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_datos As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents per_id As DataGridViewTextBoxColumn
    Friend WithEvents PER_DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents VALOR As DataGridViewTextBoxColumn
    Friend WithEvents per_estado As DataGridViewCheckBoxColumn
    Friend WithEvents ACCION As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
