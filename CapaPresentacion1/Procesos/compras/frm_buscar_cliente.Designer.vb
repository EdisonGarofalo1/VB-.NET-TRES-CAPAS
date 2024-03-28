<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_buscar_cliente
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.dgv_datos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.per_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PER_DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.per_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.txt_buscar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(462, 45)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar:"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(63, 14)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(377, 20)
        Me.txt_buscar.TabIndex = 0
        '
        'dgv_datos
        '
        Me.dgv_datos.AllowUserToAddRows = False
        Me.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.per_id, Me.PER_DESCRIPCION, Me.per_estado})
        Me.dgv_datos.Location = New System.Drawing.Point(12, 58)
        Me.dgv_datos.Name = "dgv_datos"
        Me.dgv_datos.ReadOnly = True
        Me.dgv_datos.Size = New System.Drawing.Size(462, 191)
        Me.dgv_datos.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 252)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(462, 75)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(351, 11)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 58)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cerrar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'per_id
        '
        Me.per_id.HeaderText = "IDENTIDICACIÓN"
        Me.per_id.Name = "per_id"
        Me.per_id.ReadOnly = True
        '
        'PER_DESCRIPCION
        '
        Me.PER_DESCRIPCION.HeaderText = "NOMBRES"
        Me.PER_DESCRIPCION.Name = "PER_DESCRIPCION"
        Me.PER_DESCRIPCION.ReadOnly = True
        Me.PER_DESCRIPCION.Width = 250
        '
        'per_estado
        '
        Me.per_estado.HeaderText = "ESTADO"
        Me.per_estado.Name = "per_estado"
        Me.per_estado.ReadOnly = True
        Me.per_estado.Width = 60
        '
        'frm_buscar_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 348)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv_datos)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frm_buscar_cliente"
        Me.Text = "frm_buscar_cliente"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents dgv_datos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents per_id As DataGridViewTextBoxColumn
    Friend WithEvents PER_DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents per_estado As DataGridViewTextBoxColumn
End Class
