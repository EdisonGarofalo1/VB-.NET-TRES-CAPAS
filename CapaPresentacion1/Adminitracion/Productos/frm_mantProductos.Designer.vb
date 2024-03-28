<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mantProductos
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
        Me.chk_iva = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_categoría = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Id = New System.Windows.Forms.Label()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.chk_iva)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_precio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbo_categoría)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.Id)
        Me.GroupBox1.Controls.Add(Me.chk_estado)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 227)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'chk_iva
        '
        Me.chk_iva.AutoSize = True
        Me.chk_iva.Location = New System.Drawing.Point(92, 197)
        Me.chk_iva.Name = "chk_iva"
        Me.chk_iva.Size = New System.Drawing.Size(70, 17)
        Me.chk_iva.TabIndex = 13
        Me.chk_iva.Text = "Lleva Iva"
        Me.chk_iva.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.chk_iva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chk_iva.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Precio:"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(92, 161)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre: "
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(92, 130)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(268, 20)
        Me.txt_descripcion.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Categoría:"
        '
        'cbo_categoría
        '
        Me.cbo_categoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_categoría.FormattingEnabled = True
        Me.cbo_categoría.Location = New System.Drawing.Point(92, 89)
        Me.cbo_categoría.Name = "cbo_categoría"
        Me.cbo_categoría.Size = New System.Drawing.Size(121, 21)
        Me.cbo_categoría.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(92, 52)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 5
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id.Location = New System.Drawing.Point(6, 16)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(25, 16)
        Me.Id.TabIndex = 4
        Me.Id.Text = "Id:"
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Location = New System.Drawing.Point(374, 27)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(59, 17)
        Me.chk_estado.TabIndex = 3
        Me.chk_estado.Text = "Estado"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(92, 18)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btn_grabar)
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 75)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_grabar.Image = Global.CapaPresentacion1.My.Resources.Resources.saveas
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(267, 14)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(80, 55)
        Me.btn_grabar.TabIndex = 3
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancelar.Image = Global.CapaPresentacion1.My.Resources.Resources.cancel
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(353, 14)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 55)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cerrar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'frm_mantProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 338)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_mantProductos"
        Me.Text = "frm_mantProductos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_iva As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_categoría As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents Id As Label
    Friend WithEvents chk_estado As CheckBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_cancelar As Button
End Class
