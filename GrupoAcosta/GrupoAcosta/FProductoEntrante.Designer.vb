<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProductoEntrante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FProductoEntrante))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLValidarProveedor = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTProveedor = New System.Windows.Forms.TextBox()
        Me.CMBProveedor = New System.Windows.Forms.ComboBox()
        Me.LBLProveedor = New System.Windows.Forms.Label()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LBLCliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLPSeleccionada = New System.Windows.Forms.Label()
        Me.LBLNinguno = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGVProductoEntrante = New System.Windows.Forms.DataGridView()
        Me.GBProductoEntrante = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVProductoEntrante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(457, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 17)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "*"
        '
        'LBLValidarProveedor
        '
        Me.LBLValidarProveedor.AutoSize = True
        Me.LBLValidarProveedor.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarProveedor.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarProveedor.Location = New System.Drawing.Point(457, 110)
        Me.LBLValidarProveedor.Name = "LBLValidarProveedor"
        Me.LBLValidarProveedor.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarProveedor.TabIndex = 33
        Me.LBLValidarProveedor.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(313, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 15)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Campos Obligatorios"
        '
        'TXTProveedor
        '
        Me.TXTProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTProveedor.Enabled = False
        Me.TXTProveedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTProveedor.Location = New System.Drawing.Point(405, 68)
        Me.TXTProveedor.Name = "TXTProveedor"
        Me.TXTProveedor.Size = New System.Drawing.Size(66, 20)
        Me.TXTProveedor.TabIndex = 32
        Me.TXTProveedor.Visible = False
        '
        'CMBProveedor
        '
        Me.CMBProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBProveedor.Enabled = False
        Me.CMBProveedor.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBProveedor.FormattingEnabled = True
        Me.CMBProveedor.Location = New System.Drawing.Point(176, 108)
        Me.CMBProveedor.Name = "CMBProveedor"
        Me.CMBProveedor.Size = New System.Drawing.Size(262, 25)
        Me.CMBProveedor.TabIndex = 1
        '
        'LBLProveedor
        '
        Me.LBLProveedor.AutoSize = True
        Me.LBLProveedor.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProveedor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLProveedor.Location = New System.Drawing.Point(15, 108)
        Me.LBLProveedor.Name = "LBLProveedor"
        Me.LBLProveedor.Size = New System.Drawing.Size(69, 20)
        Me.LBLProveedor.TabIndex = 4
        Me.LBLProveedor.Text = "Proveedor:"
        '
        'LBLBuscar
        '
        Me.LBLBuscar.AutoSize = True
        Me.LBLBuscar.BackColor = System.Drawing.Color.Transparent
        Me.LBLBuscar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBuscar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLBuscar.Location = New System.Drawing.Point(27, 272)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(135, 20)
        Me.LBLBuscar.TabIndex = 37
        Me.LBLBuscar.Text = "Buscar (Descripcion)"
        '
        'TXTBuscar
        '
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(188, 272)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(262, 20)
        Me.TXTBuscar.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.LBLCliente)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.LBLPSeleccionada)
        Me.GroupBox3.Controls.Add(Me.LBLNinguno)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.LBLValidarProveedor)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TXTProveedor)
        Me.GroupBox3.Controls.Add(Me.CMBProveedor)
        Me.GroupBox3.Controls.Add(Me.LBLProveedor)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(546, 191)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Producto Entrante"
        '
        'LBLCliente
        '
        Me.LBLCliente.AutoSize = True
        Me.LBLCliente.BackColor = System.Drawing.Color.Transparent
        Me.LBLCliente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCliente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLCliente.Location = New System.Drawing.Point(172, 68)
        Me.LBLCliente.Name = "LBLCliente"
        Me.LBLCliente.Size = New System.Drawing.Size(59, 20)
        Me.LBLCliente.TabIndex = 52
        Me.LBLCliente.Text = "Ninguna"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(15, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Cliente:"
        '
        'LBLPSeleccionada
        '
        Me.LBLPSeleccionada.AutoSize = True
        Me.LBLPSeleccionada.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPSeleccionada.Location = New System.Drawing.Point(15, 30)
        Me.LBLPSeleccionada.Name = "LBLPSeleccionada"
        Me.LBLPSeleccionada.Size = New System.Drawing.Size(140, 20)
        Me.LBLPSeleccionada.TabIndex = 40
        Me.LBLPSeleccionada.Text = "Solicitud Seleccionada:"
        '
        'LBLNinguno
        '
        Me.LBLNinguno.AutoSize = True
        Me.LBLNinguno.BackColor = System.Drawing.Color.Transparent
        Me.LBLNinguno.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNinguno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLNinguno.Location = New System.Drawing.Point(172, 30)
        Me.LBLNinguno.Name = "LBLNinguno"
        Me.LBLNinguno.Size = New System.Drawing.Size(59, 20)
        Me.LBLNinguno.TabIndex = 39
        Me.LBLNinguno.Text = "Ninguna"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Proveedor:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BTNSalir)
        Me.GroupBox1.Controls.Add(Me.BTNCancelar)
        Me.GroupBox1.Controls.Add(Me.BTNGuardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(569, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(90, 137)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'BTNSalir
        '
        Me.BTNSalir.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSalir.Location = New System.Drawing.Point(9, 96)
        Me.BTNSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(74, 32)
        Me.BTNSalir.TabIndex = 5
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Enabled = False
        Me.BTNCancelar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCancelar.Location = New System.Drawing.Point(7, 55)
        Me.BTNCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(74, 33)
        Me.BTNCancelar.TabIndex = 4
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNGuardar
        '
        Me.BTNGuardar.Enabled = False
        Me.BTNGuardar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGuardar.Location = New System.Drawing.Point(7, 14)
        Me.BTNGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(74, 33)
        Me.BTNGuardar.TabIndex = 1
        Me.BTNGuardar.Text = "Guardar"
        Me.BTNGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.DGVProductoEntrante)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(546, 191)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'DGVProductoEntrante
        '
        Me.DGVProductoEntrante.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DGVProductoEntrante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductoEntrante.Location = New System.Drawing.Point(6, 14)
        Me.DGVProductoEntrante.Name = "DGVProductoEntrante"
        Me.DGVProductoEntrante.Size = New System.Drawing.Size(534, 174)
        Me.DGVProductoEntrante.TabIndex = 23
        '
        'GBProductoEntrante
        '
        Me.GBProductoEntrante.BackgroundImage = CType(resources.GetObject("GBProductoEntrante.BackgroundImage"), System.Drawing.Image)
        Me.GBProductoEntrante.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBProductoEntrante.Location = New System.Drawing.Point(12, 12)
        Me.GBProductoEntrante.Name = "GBProductoEntrante"
        Me.GBProductoEntrante.Size = New System.Drawing.Size(588, 154)
        Me.GBProductoEntrante.TabIndex = 3
        Me.GBProductoEntrante.TabStop = False
        Me.GBProductoEntrante.Text = "Producto Entrante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "MÓDULO PRODUCTO ENTRANTE"
        '
        'FProductoEntrante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.ClientSize = New System.Drawing.Size(671, 495)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "FProductoEntrante"
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO PRODUCTO ENTRANTE"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGVProductoEntrante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBProductoEntrante As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBLValidarProveedor As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTProveedor As System.Windows.Forms.TextBox
    Friend WithEvents CMBProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents LBLProveedor As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVProductoEntrante As System.Windows.Forms.DataGridView
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents LBLPSeleccionada As System.Windows.Forms.Label
    Friend WithEvents LBLNinguno As System.Windows.Forms.Label
    Friend WithEvents LBLCliente As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
