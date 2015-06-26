<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTelefono
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
        Me.components = New System.ComponentModel.Container()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.TXTTelefono = New System.Windows.Forms.TextBox()
        Me.LBValidarTelefono = New System.Windows.Forms.Label()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGVTelefono = New System.Windows.Forms.DataGridView()
        Me.TTFTelefono = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNAgregar
        '
        Me.BTNAgregar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAgregar.Location = New System.Drawing.Point(13, 15)
        Me.BTNAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNAgregar.Name = "BTNAgregar"
        Me.BTNAgregar.Size = New System.Drawing.Size(74, 33)
        Me.BTNAgregar.TabIndex = 2
        Me.BTNAgregar.Text = "Agregar"
        Me.TTFTelefono.SetToolTip(Me.BTNAgregar, "Presione aquí para agregar un teléfono ")
        Me.BTNAgregar.UseVisualStyleBackColor = True
        '
        'TXTTelefono
        '
        Me.TXTTelefono.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTelefono.Location = New System.Drawing.Point(16, 31)
        Me.TXTTelefono.MaxLength = 11
        Me.TXTTelefono.Name = "TXTTelefono"
        Me.TXTTelefono.Size = New System.Drawing.Size(160, 25)
        Me.TXTTelefono.TabIndex = 1
        Me.TTFTelefono.SetToolTip(Me.TXTTelefono, "Ingrese aquí el teléfono a registrar")
        '
        'LBValidarTelefono
        '
        Me.LBValidarTelefono.AutoSize = True
        Me.LBValidarTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarTelefono.ForeColor = System.Drawing.Color.Red
        Me.LBValidarTelefono.Location = New System.Drawing.Point(178, 38)
        Me.LBValidarTelefono.Name = "LBValidarTelefono"
        Me.LBValidarTelefono.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarTelefono.TabIndex = 25
        Me.LBValidarTelefono.Text = "*"
        '
        'BTNCancelar
        '
        Me.BTNCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNCancelar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCancelar.Location = New System.Drawing.Point(13, 57)
        Me.BTNCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(74, 33)
        Me.BTNCancelar.TabIndex = 3
        Me.BTNCancelar.Text = "Cancelar"
        Me.TTFTelefono.SetToolTip(Me.BTNCancelar, "Presione aquí para salir de la ventana actual")
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCancelar)
        Me.GroupBox1.Controls.Add(Me.BTNAgregar)
        Me.GroupBox1.Location = New System.Drawing.Point(298, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 103)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGVTelefono)
        Me.GroupBox2.Controls.Add(Me.TXTTelefono)
        Me.GroupBox2.Controls.Add(Me.LBValidarTelefono)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 203)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese teléfono:"
        '
        'DGVTelefono
        '
        Me.DGVTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTelefono.Location = New System.Drawing.Point(16, 78)
        Me.DGVTelefono.Name = "DGVTelefono"
        Me.DGVTelefono.Size = New System.Drawing.Size(240, 109)
        Me.DGVTelefono.TabIndex = 26
        Me.DGVTelefono.TabStop = False
        Me.TTFTelefono.SetToolTip(Me.DGVTelefono, "Telefonos registrados de la persona en tratamiento")
        Me.DGVTelefono.Visible = False
        '
        'FTelefono
        '
        Me.AcceptButton = Me.BTNAgregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BTNCancelar
        Me.ClientSize = New System.Drawing.Size(415, 247)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FTelefono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FTelefono"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button
    Friend WithEvents TXTTelefono As System.Windows.Forms.TextBox
    Friend WithEvents LBValidarTelefono As System.Windows.Forms.Label
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVTelefono As System.Windows.Forms.DataGridView
    Friend WithEvents TTFTelefono As System.Windows.Forms.ToolTip
End Class
