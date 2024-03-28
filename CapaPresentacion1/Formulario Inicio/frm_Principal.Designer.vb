<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Principal
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
        Me.MenuPpal = New System.Windows.Forms.MenuStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.rslbl_nombre = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPpal
        '
        Me.MenuPpal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPpal.Name = "MenuPpal"
        Me.MenuPpal.Size = New System.Drawing.Size(284, 24)
        Me.MenuPpal.TabIndex = 5
        Me.MenuPpal.Text = "MenuStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rslbl_nombre})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 236)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(284, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'rslbl_nombre
        '
        Me.rslbl_nombre.Name = "rslbl_nombre"
        Me.rslbl_nombre.Size = New System.Drawing.Size(88, 22)
        Me.rslbl_nombre.Text = "ToolStripLabel1"
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuPpal)
        Me.IsMdiContainer = True
        Me.Name = "frm_Principal"
        Me.Text = "frm_Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuPpal As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents rslbl_nombre As ToolStripLabel
End Class
