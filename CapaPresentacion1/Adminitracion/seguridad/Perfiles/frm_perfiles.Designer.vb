<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_perfiles
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_datos = New System.Windows.Forms.DataGridView()
        Me.per_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.per_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PER_DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.per_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_buscar)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(503, 75)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar Perfil:"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(55, 32)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(403, 20)
        Me.txt_buscar.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btn_nuevo)
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(503, 75)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(308, 14)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(80, 55)
        Me.btn_nuevo.TabIndex = 3
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(394, 14)
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
        Me.GroupBox1.Location = New System.Drawing.Point(27, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 184)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'dgv_datos
        '
        Me.dgv_datos.AllowUserToAddRows = False
        Me.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.per_id, Me.per_nombre, Me.PER_DESCRIPCION, Me.per_estado})
        Me.dgv_datos.Location = New System.Drawing.Point(6, 19)
        Me.dgv_datos.Name = "dgv_datos"
        Me.dgv_datos.ReadOnly = True
        Me.dgv_datos.Size = New System.Drawing.Size(480, 150)
        Me.dgv_datos.TabIndex = 0
        '
        'per_id
        '
        Me.per_id.HeaderText = "CODIGO"
        Me.per_id.Name = "per_id"
        Me.per_id.ReadOnly = True
        Me.per_id.Width = 60
        '
        'per_nombre
        '
        Me.per_nombre.HeaderText = "NOMBRE"
        Me.per_nombre.Name = "per_nombre"
        Me.per_nombre.ReadOnly = True
        Me.per_nombre.Width = 150
        '
        'PER_DESCRIPCION
        '
        Me.PER_DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.PER_DESCRIPCION.Name = "PER_DESCRIPCION"
        Me.PER_DESCRIPCION.ReadOnly = True
        Me.PER_DESCRIPCION.Width = 150
        '
        'per_estado
        '
        Me.per_estado.HeaderText = "ESTADO"
        Me.per_estado.Name = "per_estado"
        Me.per_estado.ReadOnly = True
        Me.per_estado.Width = 60
        '
        'frm_perfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 380)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frm_perfiles"
        Me.Text = "frm_perfiles"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_datos As DataGridView
    Friend WithEvents per_id As DataGridViewTextBoxColumn
    Friend WithEvents per_nombre As DataGridViewTextBoxColumn
    Friend WithEvents PER_DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents per_estado As DataGridViewTextBoxColumn
End Class
