<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_compras
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.txt_subTotal = New System.Windows.Forms.TextBox()
        Me.btn_ayuda = New System.Windows.Forms.Button()
        Me.chk_validar = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dap_fechaMov = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_identificacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_numDoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_datos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ayuda = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L_IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.btn_nuevo)
        Me.GroupBox2.Controls.Add(Me.btn_grabar)
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 418)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 90)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_nuevo.Image = Global.CapaPresentacion1.My.Resources.Resources.Limpiar1
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(479, 19)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(80, 55)
        Me.btn_nuevo.TabIndex = 4
        Me.btn_nuevo.Text = "&Limpiar"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_grabar.Image = Global.CapaPresentacion1.My.Resources.Resources.save1
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(569, 19)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(80, 55)
        Me.btn_grabar.TabIndex = 5
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancelar.Image = Global.CapaPresentacion1.My.Resources.Resources.Equis2
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(660, 19)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 55)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cerrar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.txt_total)
        Me.GroupBox1.Controls.Add(Me.txt_iva)
        Me.GroupBox1.Controls.Add(Me.txt_subTotal)
        Me.GroupBox1.Controls.Add(Me.btn_ayuda)
        Me.GroupBox1.Controls.Add(Me.chk_validar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.chk_estado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dap_fechaMov)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_nombres)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_identificacion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_numDoc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 400)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(588, 373)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(144, 20)
        Me.txt_total.TabIndex = 23
        '
        'txt_iva
        '
        Me.txt_iva.Location = New System.Drawing.Point(588, 345)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(144, 20)
        Me.txt_iva.TabIndex = 22
        '
        'txt_subTotal
        '
        Me.txt_subTotal.Location = New System.Drawing.Point(588, 319)
        Me.txt_subTotal.Name = "txt_subTotal"
        Me.txt_subTotal.Size = New System.Drawing.Size(144, 20)
        Me.txt_subTotal.TabIndex = 21
        '
        'btn_ayuda
        '
        Me.btn_ayuda.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_ayuda.Image = Global.CapaPresentacion1.My.Resources.Resources.FindMedium1
        Me.btn_ayuda.Location = New System.Drawing.Point(285, 45)
        Me.btn_ayuda.Name = "btn_ayuda"
        Me.btn_ayuda.Size = New System.Drawing.Size(36, 24)
        Me.btn_ayuda.TabIndex = 4
        Me.btn_ayuda.Text = "?"
        Me.btn_ayuda.UseVisualStyleBackColor = False
        '
        'chk_validar
        '
        Me.chk_validar.AutoSize = True
        Me.chk_validar.Location = New System.Drawing.Point(334, 50)
        Me.chk_validar.Name = "chk_validar"
        Me.chk_validar.Size = New System.Drawing.Size(57, 17)
        Me.chk_validar.TabIndex = 20
        Me.chk_validar.Text = "validar"
        Me.chk_validar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(542, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(526, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Iva 12%:"
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Location = New System.Drawing.Point(673, 19)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(59, 17)
        Me.chk_estado.TabIndex = 13
        Me.chk_estado.Text = "Estado"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(516, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sub Total:"
        '
        'dap_fechaMov
        '
        Me.dap_fechaMov.Location = New System.Drawing.Point(456, 21)
        Me.dap_fechaMov.Name = "dap_fechaMov"
        Me.dap_fechaMov.Size = New System.Drawing.Size(200, 20)
        Me.dap_fechaMov.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(406, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(458, 48)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.ReadOnly = True
        Me.txt_telefono.Size = New System.Drawing.Size(144, 20)
        Me.txt_telefono.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(391, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Teléfono:"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(135, 98)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.ReadOnly = True
        Me.txt_direccion.Size = New System.Drawing.Size(491, 20)
        Me.txt_direccion.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dirección:"
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(135, 72)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.ReadOnly = True
        Me.txt_nombres.Size = New System.Drawing.Size(491, 20)
        Me.txt_nombres.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombres:"
        '
        'txt_identificacion
        '
        Me.txt_identificacion.Location = New System.Drawing.Point(135, 47)
        Me.txt_identificacion.Name = "txt_identificacion"
        Me.txt_identificacion.Size = New System.Drawing.Size(144, 20)
        Me.txt_identificacion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CI/RUC:"
        '
        'txt_numDoc
        '
        Me.txt_numDoc.Location = New System.Drawing.Point(135, 24)
        Me.txt_numDoc.Name = "txt_numDoc"
        Me.txt_numDoc.Size = New System.Drawing.Size(144, 20)
        Me.txt_numDoc.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Num. Documento:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.dgv_datos)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(740, 190)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'dgv_datos
        '
        Me.dgv_datos.AllowUserToAddRows = False
        Me.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CODIGO, Me.ayuda, Me.DESCRIPCION, Me.CANTIDAD, Me.PRECIO, Me.SUBTOTAL, Me.L_IVA, Me.IVA})
        Me.dgv_datos.Location = New System.Drawing.Point(10, 19)
        Me.dgv_datos.Name = "dgv_datos"
        Me.dgv_datos.Size = New System.Drawing.Size(720, 150)
        Me.dgv_datos.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'CODIGO
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CODIGO.DefaultCellStyle = DataGridViewCellStyle1
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        '
        'ayuda
        '
        Me.ayuda.HeaderText = "?"
        Me.ayuda.Name = "ayuda"
        Me.ayuda.Width = 30
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "DESCRIPCIÓN"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.Width = 300
        '
        'CANTIDAD
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CANTIDAD.DefaultCellStyle = DataGridViewCellStyle2
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Width = 70
        '
        'PRECIO
        '
        Me.PRECIO.HeaderText = "P/U"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.Width = 70
        '
        'SUBTOTAL
        '
        Me.SUBTOTAL.HeaderText = "SUBTOTAL"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'L_IVA
        '
        Me.L_IVA.HeaderText = "L_IVA"
        Me.L_IVA.Name = "L_IVA"
        Me.L_IVA.Width = 50
        '
        'IVA
        '
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        Me.IVA.Width = 50
        '
        'frm_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 521)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_compras"
        Me.Text = "frm_compras"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chk_estado As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dap_fechaMov As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_identificacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_numDoc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgv_datos As DataGridView
    Friend WithEvents chk_validar As CheckBox
    Friend WithEvents btn_ayuda As Button
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_iva As TextBox
    Friend WithEvents txt_subTotal As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents ayuda As DataGridViewButtonColumn
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents L_IVA As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
End Class
