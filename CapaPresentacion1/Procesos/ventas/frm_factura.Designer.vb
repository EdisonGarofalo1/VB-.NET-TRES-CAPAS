<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_factura
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_cambio = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_efectivo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_total_pagar = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_total_unidades = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_eli = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chk_validar = New System.Windows.Forms.CheckBox()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.msk_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_identificacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_num_fac = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_Anular = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_datos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ayuda = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lleva_iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox6.Controls.Add(Me.txt_cambio)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txt_efectivo)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.txt_total_pagar)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.txt_total_unidades)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 455)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(747, 86)
        Me.GroupBox6.TabIndex = 31
        Me.GroupBox6.TabStop = False
        '
        'txt_cambio
        '
        Me.txt_cambio.BackColor = System.Drawing.Color.Turquoise
        Me.txt_cambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cambio.Location = New System.Drawing.Point(581, 28)
        Me.txt_cambio.Name = "txt_cambio"
        Me.txt_cambio.ReadOnly = True
        Me.txt_cambio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_cambio.Size = New System.Drawing.Size(142, 44)
        Me.txt_cambio.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(581, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 13)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "CAMBIO $:"
        '
        'txt_efectivo
        '
        Me.txt_efectivo.BackColor = System.Drawing.Color.Honeydew
        Me.txt_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_efectivo.Location = New System.Drawing.Point(371, 28)
        Me.txt_efectivo.Name = "txt_efectivo"
        Me.txt_efectivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_efectivo.Size = New System.Drawing.Size(162, 44)
        Me.txt_efectivo.TabIndex = 23
        Me.txt_efectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(370, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "EFECTIVO $:"
        '
        'txt_total_pagar
        '
        Me.txt_total_pagar.BackColor = System.Drawing.Color.Turquoise
        Me.txt_total_pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_pagar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_total_pagar.Location = New System.Drawing.Point(159, 29)
        Me.txt_total_pagar.Name = "txt_total_pagar"
        Me.txt_total_pagar.ReadOnly = True
        Me.txt_total_pagar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_total_pagar.Size = New System.Drawing.Size(181, 44)
        Me.txt_total_pagar.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(156, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "TOTAL POR PAGAR:"
        '
        'txt_total_unidades
        '
        Me.txt_total_unidades.BackColor = System.Drawing.Color.Honeydew
        Me.txt_total_unidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_unidades.Location = New System.Drawing.Point(23, 29)
        Me.txt_total_unidades.Name = "txt_total_unidades"
        Me.txt_total_unidades.ReadOnly = True
        Me.txt_total_unidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_total_unidades.Size = New System.Drawing.Size(96, 44)
        Me.txt_total_unidades.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "TOTAL UNIDADES:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btn_eli)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.chk_validar)
        Me.GroupBox1.Controls.Add(Me.chk_estado)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.msk_fecha)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.txt_nombres)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_identificacion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_num_fac)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(827, 212)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'btn_eli
        '
        Me.btn_eli.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_eli.Image = Global.CapaPresentacion1.My.Resources.Resources.Equis2
        Me.btn_eli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eli.Location = New System.Drawing.Point(649, 148)
        Me.btn_eli.Name = "btn_eli"
        Me.btn_eli.Size = New System.Drawing.Size(56, 52)
        Me.btn_eli.TabIndex = 3
        Me.btn_eli.Text = "Eliminar"
        Me.btn_eli.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eli.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancelar.Image = Global.CapaPresentacion1.My.Resources.Resources.cancel
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(710, 148)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(59, 52)
        Me.btn_cancelar.TabIndex = 32
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txt_total)
        Me.GroupBox5.Controls.Add(Me.txt_iva)
        Me.GroupBox5.Controls.Add(Me.txt_subtotal)
        Me.GroupBox5.Location = New System.Drawing.Point(594, 46)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 96)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Iva %:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Sub Total:"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(72, 63)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_total.Size = New System.Drawing.Size(107, 20)
        Me.txt_total.TabIndex = 27
        '
        'txt_iva
        '
        Me.txt_iva.Location = New System.Drawing.Point(72, 40)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.ReadOnly = True
        Me.txt_iva.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_iva.Size = New System.Drawing.Size(107, 20)
        Me.txt_iva.TabIndex = 25
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(72, 15)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_subtotal.Size = New System.Drawing.Size(107, 20)
        Me.txt_subtotal.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Image = Global.CapaPresentacion1.My.Resources.Resources.FindMedium1
        Me.Button2.Location = New System.Drawing.Point(231, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 25)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(464, 44)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Consumidor Final"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chk_validar
        '
        Me.chk_validar.AutoSize = True
        Me.chk_validar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_validar.Location = New System.Drawing.Point(286, 42)
        Me.chk_validar.Name = "chk_validar"
        Me.chk_validar.Size = New System.Drawing.Size(65, 17)
        Me.chk_validar.TabIndex = 21
        Me.chk_validar.Text = "Validar"
        Me.chk_validar.UseVisualStyleBackColor = True
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_estado.Location = New System.Drawing.Point(729, 15)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(65, 17)
        Me.chk_estado.TabIndex = 21
        Me.chk_estado.Text = "Estado"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(85, 126)
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(265, 32)
        Me.txt_direccion.TabIndex = 5
        '
        'msk_fecha
        '
        Me.msk_fecha.Location = New System.Drawing.Point(509, 14)
        Me.msk_fecha.Mask = "00/00/0000"
        Me.msk_fecha.Name = "msk_fecha"
        Me.msk_fecha.Size = New System.Drawing.Size(67, 20)
        Me.msk_fecha.TabIndex = 20
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(86, 98)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(155, 20)
        Me.txt_telefono.TabIndex = 6
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(86, 71)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(265, 20)
        Me.txt_nombres.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nombre:"
        '
        'txt_identificacion
        '
        Me.txt_identificacion.Location = New System.Drawing.Point(86, 43)
        Me.txt_identificacion.Name = "txt_identificacion"
        Me.txt_identificacion.Size = New System.Drawing.Size(139, 20)
        Me.txt_identificacion.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(461, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Fecha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Dirección:"
        '
        'txt_num_fac
        '
        Me.txt_num_fac.Location = New System.Drawing.Point(86, 12)
        Me.txt_num_fac.Name = "txt_num_fac"
        Me.txt_num_fac.Size = New System.Drawing.Size(139, 20)
        Me.txt_num_fac.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ruc/ci:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num fac."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_imprimir)
        Me.GroupBox4.Controls.Add(Me.btn_Anular)
        Me.GroupBox4.Controls.Add(Me.btn_Nuevo)
        Me.GroupBox4.Controls.Add(Me.btn_grabar)
        Me.GroupBox4.Location = New System.Drawing.Point(762, 222)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(77, 237)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(11, 123)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(54, 51)
        Me.btn_imprimir.TabIndex = 34
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_Anular
        '
        Me.btn_Anular.Location = New System.Drawing.Point(12, 12)
        Me.btn_Anular.Name = "btn_Anular"
        Me.btn_Anular.Size = New System.Drawing.Size(54, 51)
        Me.btn_Anular.TabIndex = 33
        Me.btn_Anular.Text = "Anular"
        Me.btn_Anular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Anular.UseVisualStyleBackColor = True
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Nuevo.Image = Global.CapaPresentacion1.My.Resources.Resources.Limpiar1
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Nuevo.Location = New System.Drawing.Point(12, 67)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(54, 51)
        Me.btn_Nuevo.TabIndex = 30
        Me.btn_Nuevo.Text = "Limpiar"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Nuevo.UseVisualStyleBackColor = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_grabar.Image = Global.CapaPresentacion1.My.Resources.Resources.save1
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(11, 179)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(54, 51)
        Me.btn_grabar.TabIndex = 31
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.dgv_datos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(744, 233)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'dgv_datos
        '
        Me.dgv_datos.AllowUserToAddRows = False
        Me.dgv_datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.codigo, Me.ayuda, Me.descripcion, Me.Cantidad, Me.precio, Me.subtotal, Me.lleva_iva, Me.iva_pro, Me.total})
        Me.dgv_datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_datos.Location = New System.Drawing.Point(3, 16)
        Me.dgv_datos.Name = "dgv_datos"
        Me.dgv_datos.Size = New System.Drawing.Size(738, 214)
        Me.dgv_datos.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        '
        'ayuda
        '
        Me.ayuda.HeaderText = "?"
        Me.ayuda.Name = "ayuda"
        Me.ayuda.Width = 20
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 200
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 60
        '
        'precio
        '
        Me.precio.HeaderText = "Precio/u"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 80
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Sub Total"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 80
        '
        'lleva_iva
        '
        Me.lleva_iva.HeaderText = "LLeva_Iva"
        Me.lleva_iva.Name = "lleva_iva"
        Me.lleva_iva.ReadOnly = True
        Me.lleva_iva.Width = 70
        '
        'iva_pro
        '
        Me.iva_pro.HeaderText = "IVA"
        Me.iva_pro.Name = "iva_pro"
        Me.iva_pro.ReadOnly = True
        Me.iva_pro.Width = 80
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Visible = False
        Me.total.Width = 80
        '
        'frm_factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 553)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "frm_factura"
        Me.Text = "frm_factura"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txt_cambio As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_efectivo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_total_pagar As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_total_unidades As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_imprimir As Button
    Friend WithEvents btn_Anular As Button
    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_iva As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents chk_validar As CheckBox
    Friend WithEvents chk_estado As CheckBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents msk_fecha As MaskedTextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_identificacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_num_fac As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_eli As Button
    Friend WithEvents dgv_datos As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents ayuda As DataGridViewButtonColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents lleva_iva As DataGridViewTextBoxColumn
    Friend WithEvents iva_pro As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
