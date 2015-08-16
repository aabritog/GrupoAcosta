<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDireccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FDireccion))
        Me.GBNuevaDireccion = New System.Windows.Forms.GroupBox()
        Me.LBCamposObligatoriosAst = New System.Windows.Forms.Label()
        Me.LBLValidarCliente = New System.Windows.Forms.Label()
        Me.LBCamposObligatorios = New System.Windows.Forms.Label()
        Me.TXTCliente = New System.Windows.Forms.TextBox()
        Me.CMBCliente = New System.Windows.Forms.ComboBox()
        Me.LBLValidarDireccion = New System.Windows.Forms.Label()
        Me.TXTDireccion = New System.Windows.Forms.TextBox()
        Me.LBLCliente = New System.Windows.Forms.Label()
        Me.LBLDireccion = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNModificar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.GBCDireccionCliente = New System.Windows.Forms.GroupBox()
        Me.DGVDireccion = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBNuevaDireccion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBCDireccionCliente.SuspendLayout()
        CType(Me.DGVDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBNuevaDireccion
        '
        Me.GBNuevaDireccion.BackColor = System.Drawing.Color.White
        Me.GBNuevaDireccion.Controls.Add(Me.LBCamposObligatoriosAst)
        Me.GBNuevaDireccion.Controls.Add(Me.LBLValidarCliente)
        Me.GBNuevaDireccion.Controls.Add(Me.LBCamposObligatorios)
        Me.GBNuevaDireccion.Controls.Add(Me.TXTCliente)
        Me.GBNuevaDireccion.Controls.Add(Me.CMBCliente)
        Me.GBNuevaDireccion.Controls.Add(Me.LBLValidarDireccion)
        Me.GBNuevaDireccion.Controls.Add(Me.TXTDireccion)
        Me.GBNuevaDireccion.Controls.Add(Me.LBLCliente)
        Me.GBNuevaDireccion.Controls.Add(Me.LBLDireccion)
        Me.GBNuevaDireccion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBNuevaDireccion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GBNuevaDireccion.Location = New System.Drawing.Point(18, 77)
        Me.GBNuevaDireccion.Name = "GBNuevaDireccion"
        Me.GBNuevaDireccion.Size = New System.Drawing.Size(533, 137)
        Me.GBNuevaDireccion.TabIndex = 2
        Me.GBNuevaDireccion.TabStop = False
        Me.GBNuevaDireccion.Text = "Nueva Direccion"
        '
        'LBCamposObligatoriosAst
        '
        Me.LBCamposObligatoriosAst.AutoSize = True
        Me.LBCamposObligatoriosAst.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatoriosAst.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.LBCamposObligatoriosAst.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatoriosAst.Location = New System.Drawing.Point(444, 117)
        Me.LBCamposObligatoriosAst.Name = "LBCamposObligatoriosAst"
        Me.LBCamposObligatoriosAst.Size = New System.Drawing.Size(14, 17)
        Me.LBCamposObligatoriosAst.TabIndex = 48
        Me.LBCamposObligatoriosAst.Text = "*"
        '
        'LBLValidarCliente
        '
        Me.LBLValidarCliente.AutoSize = True
        Me.LBLValidarCliente.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarCliente.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarCliente.Location = New System.Drawing.Point(444, 30)
        Me.LBLValidarCliente.Name = "LBLValidarCliente"
        Me.LBLValidarCliente.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarCliente.TabIndex = 33
        Me.LBLValidarCliente.Text = "*"
        '
        'LBCamposObligatorios
        '
        Me.LBCamposObligatorios.AutoSize = True
        Me.LBCamposObligatorios.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatorios.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatorios.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatorios.Location = New System.Drawing.Point(315, 119)
        Me.LBCamposObligatorios.Name = "LBCamposObligatorios"
        Me.LBCamposObligatorios.Size = New System.Drawing.Size(119, 16)
        Me.LBCamposObligatorios.TabIndex = 47
        Me.LBCamposObligatorios.Text = "Campos Obligatorios"
        '
        'TXTCliente
        '
        Me.TXTCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTCliente.Enabled = False
        Me.TXTCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCliente.Location = New System.Drawing.Point(461, 53)
        Me.TXTCliente.Name = "TXTCliente"
        Me.TXTCliente.Size = New System.Drawing.Size(66, 20)
        Me.TXTCliente.TabIndex = 32
        Me.TXTCliente.Visible = False
        '
        'CMBCliente
        '
        Me.CMBCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBCliente.Enabled = False
        Me.CMBCliente.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCliente.FormattingEnabled = True
        Me.CMBCliente.Location = New System.Drawing.Point(176, 30)
        Me.CMBCliente.Name = "CMBCliente"
        Me.CMBCliente.Size = New System.Drawing.Size(262, 25)
        Me.CMBCliente.TabIndex = 31
        '
        'LBLValidarDireccion
        '
        Me.LBLValidarDireccion.AutoSize = True
        Me.LBLValidarDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarDireccion.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarDireccion.Location = New System.Drawing.Point(444, 76)
        Me.LBLValidarDireccion.Name = "LBLValidarDireccion"
        Me.LBLValidarDireccion.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarDireccion.TabIndex = 28
        Me.LBLValidarDireccion.Text = "*"
        '
        'TXTDireccion
        '
        Me.TXTDireccion.BackColor = System.Drawing.Color.White
        Me.TXTDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDireccion.Enabled = False
        Me.TXTDireccion.Location = New System.Drawing.Point(176, 76)
        Me.TXTDireccion.MaxLength = 30
        Me.TXTDireccion.Name = "TXTDireccion"
        Me.TXTDireccion.Size = New System.Drawing.Size(262, 25)
        Me.TXTDireccion.TabIndex = 5
        '
        'LBLCliente
        '
        Me.LBLCliente.AutoSize = True
        Me.LBLCliente.BackColor = System.Drawing.Color.Transparent
        Me.LBLCliente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCliente.Location = New System.Drawing.Point(15, 35)
        Me.LBLCliente.Name = "LBLCliente"
        Me.LBLCliente.Size = New System.Drawing.Size(51, 20)
        Me.LBLCliente.TabIndex = 4
        Me.LBLCliente.Text = "Cliente:"
        '
        'LBLDireccion
        '
        Me.LBLDireccion.AutoSize = True
        Me.LBLDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LBLDireccion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDireccion.Location = New System.Drawing.Point(15, 79)
        Me.LBLDireccion.Name = "LBLDireccion"
        Me.LBLDireccion.Size = New System.Drawing.Size(64, 20)
        Me.LBLDireccion.TabIndex = 3
        Me.LBLDireccion.Text = "Direccion:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BTNAgregar)
        Me.GroupBox2.Controls.Add(Me.BTNSalir)
        Me.GroupBox2.Controls.Add(Me.BTNGuardar)
        Me.GroupBox2.Controls.Add(Me.BTNCancelar)
        Me.GroupBox2.Controls.Add(Me.BTNModificar)
        Me.GroupBox2.Controls.Add(Me.BTNEliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(560, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(85, 254)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'BTNAgregar
        '
        Me.BTNAgregar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAgregar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNAgregar.Location = New System.Drawing.Point(7, 11)
        Me.BTNAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNAgregar.Name = "BTNAgregar"
        Me.BTNAgregar.Size = New System.Drawing.Size(74, 33)
        Me.BTNAgregar.TabIndex = 16
        Me.BTNAgregar.Text = "Agregar"
        Me.BTNAgregar.UseVisualStyleBackColor = True
        '
        'BTNSalir
        '
        Me.BTNSalir.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSalir.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNSalir.Location = New System.Drawing.Point(7, 213)
        Me.BTNSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(74, 32)
        Me.BTNSalir.TabIndex = 21
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'BTNGuardar
        '
        Me.BTNGuardar.Enabled = False
        Me.BTNGuardar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGuardar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNGuardar.Location = New System.Drawing.Point(7, 52)
        Me.BTNGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(74, 33)
        Me.BTNGuardar.TabIndex = 17
        Me.BTNGuardar.Text = "Guardar"
        Me.BTNGuardar.UseVisualStyleBackColor = True
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Enabled = False
        Me.BTNCancelar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCancelar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNCancelar.Location = New System.Drawing.Point(7, 172)
        Me.BTNCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(74, 33)
        Me.BTNCancelar.TabIndex = 20
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNModificar
        '
        Me.BTNModificar.Enabled = False
        Me.BTNModificar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNModificar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNModificar.Location = New System.Drawing.Point(7, 90)
        Me.BTNModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNModificar.Name = "BTNModificar"
        Me.BTNModificar.Size = New System.Drawing.Size(74, 33)
        Me.BTNModificar.TabIndex = 18
        Me.BTNModificar.Text = "Modificar"
        Me.BTNModificar.UseVisualStyleBackColor = True
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Enabled = False
        Me.BTNEliminar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEliminar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNEliminar.Location = New System.Drawing.Point(7, 131)
        Me.BTNEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(74, 33)
        Me.BTNEliminar.TabIndex = 19
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'LBLBuscar
        '
        Me.LBLBuscar.AutoSize = True
        Me.LBLBuscar.BackColor = System.Drawing.Color.Transparent
        Me.LBLBuscar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBuscar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLBuscar.Location = New System.Drawing.Point(33, 245)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(135, 20)
        Me.LBLBuscar.TabIndex = 31
        Me.LBLBuscar.Text = "Buscar (Descripcion)"
        '
        'TXTBuscar
        '
        Me.TXTBuscar.BackColor = System.Drawing.Color.White
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(194, 245)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(262, 20)
        Me.TXTBuscar.TabIndex = 3
        '
        'GBCDireccionCliente
        '
        Me.GBCDireccionCliente.BackColor = System.Drawing.Color.White
        Me.GBCDireccionCliente.Controls.Add(Me.DGVDireccion)
        Me.GBCDireccionCliente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBCDireccionCliente.Location = New System.Drawing.Point(12, 278)
        Me.GBCDireccionCliente.Name = "GBCDireccionCliente"
        Me.GBCDireccionCliente.Size = New System.Drawing.Size(533, 195)
        Me.GBCDireccionCliente.TabIndex = 32
        Me.GBCDireccionCliente.TabStop = False
        '
        'DGVDireccion
        '
        Me.DGVDireccion.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DGVDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDireccion.Location = New System.Drawing.Point(6, 15)
        Me.DGVDireccion.Name = "DGVDireccion"
        Me.DGVDireccion.Size = New System.Drawing.Size(521, 174)
        Me.DGVDireccion.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(14, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "MÓDULO DIRECCIÓN-CLIENTE"
        '
        'FDireccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.ClientSize = New System.Drawing.Size(657, 475)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GBCDireccionCliente)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBNuevaDireccion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FDireccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO DIRECCION-CLIENTE"
        Me.GBNuevaDireccion.ResumeLayout(False)
        Me.GBNuevaDireccion.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GBCDireccionCliente.ResumeLayout(False)
        CType(Me.DGVDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBNuevaDireccion As System.Windows.Forms.GroupBox
    Friend WithEvents TXTCliente As System.Windows.Forms.TextBox
    Friend WithEvents CMBCliente As System.Windows.Forms.ComboBox
    Friend WithEvents LBLValidarDireccion As System.Windows.Forms.Label
    Friend WithEvents TXTDireccion As System.Windows.Forms.TextBox
    Friend WithEvents LBLCliente As System.Windows.Forms.Label
    Friend WithEvents LBLDireccion As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNModificar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GBCDireccionCliente As System.Windows.Forms.GroupBox
    Friend WithEvents DGVDireccion As System.Windows.Forms.DataGridView
    Friend WithEvents LBLValidarCliente As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatoriosAst As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatorios As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
