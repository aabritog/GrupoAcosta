<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCargo
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
        Me.LBCamposObligatoriosAst = New System.Windows.Forms.Label()
        Me.LBCamposObligatorios = New System.Windows.Forms.Label()
        Me.LBLValidarDescripcioncorta = New System.Windows.Forms.Label()
        Me.LBLValidarDepartamento = New System.Windows.Forms.Label()
        Me.TXTDepartamento = New System.Windows.Forms.TextBox()
        Me.CMBDepartamento = New System.Windows.Forms.ComboBox()
        Me.LBLDepartamento = New System.Windows.Forms.Label()
        Me.LBLValidarDescripcion = New System.Windows.Forms.Label()
        Me.TXTDescripcionCorta = New System.Windows.Forms.TextBox()
        Me.TXTDescripcion = New System.Windows.Forms.TextBox()
        Me.LBLDescripcionCorta = New System.Windows.Forms.Label()
        Me.LBLDescripcion = New System.Windows.Forms.Label()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.GBCargos = New System.Windows.Forms.GroupBox()
        Me.DGVCargo = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNModificar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GBCargos.SuspendLayout()
        CType(Me.DGVCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.GroupBox1.Controls.Add(Me.LBCamposObligatoriosAst)
        Me.GroupBox1.Controls.Add(Me.LBCamposObligatorios)
        Me.GroupBox1.Controls.Add(Me.LBLValidarDescripcioncorta)
        Me.GroupBox1.Controls.Add(Me.LBLValidarDepartamento)
        Me.GroupBox1.Controls.Add(Me.TXTDepartamento)
        Me.GroupBox1.Controls.Add(Me.CMBDepartamento)
        Me.GroupBox1.Controls.Add(Me.LBLDepartamento)
        Me.GroupBox1.Controls.Add(Me.LBLValidarDescripcion)
        Me.GroupBox1.Controls.Add(Me.TXTDescripcionCorta)
        Me.GroupBox1.Controls.Add(Me.TXTDescripcion)
        Me.GroupBox1.Controls.Add(Me.LBLDescripcionCorta)
        Me.GroupBox1.Controls.Add(Me.LBLDescripcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 167)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Cargo"
        '
        'LBCamposObligatoriosAst
        '
        Me.LBCamposObligatoriosAst.AutoSize = True
        Me.LBCamposObligatoriosAst.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBCamposObligatoriosAst.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatoriosAst.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatoriosAst.Location = New System.Drawing.Point(478, 149)
        Me.LBCamposObligatoriosAst.Name = "LBCamposObligatoriosAst"
        Me.LBCamposObligatoriosAst.Size = New System.Drawing.Size(12, 15)
        Me.LBCamposObligatoriosAst.TabIndex = 46
        Me.LBCamposObligatoriosAst.Text = "*"
        '
        'LBCamposObligatorios
        '
        Me.LBCamposObligatorios.AutoSize = True
        Me.LBCamposObligatorios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBCamposObligatorios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatorios.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatorios.Location = New System.Drawing.Point(326, 149)
        Me.LBCamposObligatorios.Name = "LBCamposObligatorios"
        Me.LBCamposObligatorios.Size = New System.Drawing.Size(125, 15)
        Me.LBCamposObligatorios.TabIndex = 45
        Me.LBCamposObligatorios.Text = "Campos Obligatorios"
        '
        'LBLValidarDescripcioncorta
        '
        Me.LBLValidarDescripcioncorta.AutoSize = True
        Me.LBLValidarDescripcioncorta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLValidarDescripcioncorta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarDescripcioncorta.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarDescripcioncorta.Location = New System.Drawing.Point(478, 61)
        Me.LBLValidarDescripcioncorta.Name = "LBLValidarDescripcioncorta"
        Me.LBLValidarDescripcioncorta.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarDescripcioncorta.TabIndex = 33
        Me.LBLValidarDescripcioncorta.Text = "*"
        '
        'LBLValidarDepartamento
        '
        Me.LBLValidarDepartamento.AutoSize = True
        Me.LBLValidarDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLValidarDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarDepartamento.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarDepartamento.Location = New System.Drawing.Point(478, 108)
        Me.LBLValidarDepartamento.Name = "LBLValidarDepartamento"
        Me.LBLValidarDepartamento.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarDepartamento.TabIndex = 32
        Me.LBLValidarDepartamento.Text = "*"
        '
        'TXTDepartamento
        '
        Me.TXTDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTDepartamento.Enabled = False
        Me.TXTDepartamento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDepartamento.Location = New System.Drawing.Point(469, 85)
        Me.TXTDepartamento.Name = "TXTDepartamento"
        Me.TXTDepartamento.Size = New System.Drawing.Size(66, 20)
        Me.TXTDepartamento.TabIndex = 31
        Me.TXTDepartamento.Visible = False
        '
        'CMBDepartamento
        '
        Me.CMBDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBDepartamento.Enabled = False
        Me.CMBDepartamento.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBDepartamento.FormattingEnabled = True
        Me.CMBDepartamento.Location = New System.Drawing.Point(185, 106)
        Me.CMBDepartamento.Name = "CMBDepartamento"
        Me.CMBDepartamento.Size = New System.Drawing.Size(266, 25)
        Me.CMBDepartamento.TabIndex = 3
        '
        'LBLDepartamento
        '
        Me.LBLDepartamento.AutoSize = True
        Me.LBLDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLDepartamento.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDepartamento.Location = New System.Drawing.Point(15, 114)
        Me.LBLDepartamento.Name = "LBLDepartamento"
        Me.LBLDepartamento.Size = New System.Drawing.Size(90, 20)
        Me.LBLDepartamento.TabIndex = 29
        Me.LBLDepartamento.Text = "Departamento:"
        '
        'LBLValidarDescripcion
        '
        Me.LBLValidarDescripcion.AutoSize = True
        Me.LBLValidarDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLValidarDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarDescripcion.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarDescripcion.Location = New System.Drawing.Point(478, 19)
        Me.LBLValidarDescripcion.Name = "LBLValidarDescripcion"
        Me.LBLValidarDescripcion.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarDescripcion.TabIndex = 28
        Me.LBLValidarDescripcion.Text = "*"
        '
        'TXTDescripcionCorta
        '
        Me.TXTDescripcionCorta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDescripcionCorta.Enabled = False
        Me.TXTDescripcionCorta.Location = New System.Drawing.Point(185, 61)
        Me.TXTDescripcionCorta.MaxLength = 15
        Me.TXTDescripcionCorta.Name = "TXTDescripcionCorta"
        Me.TXTDescripcionCorta.Size = New System.Drawing.Size(266, 25)
        Me.TXTDescripcionCorta.TabIndex = 2
        '
        'TXTDescripcion
        '
        Me.TXTDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDescripcion.Enabled = False
        Me.TXTDescripcion.Location = New System.Drawing.Point(185, 19)
        Me.TXTDescripcion.MaxLength = 30
        Me.TXTDescripcion.Name = "TXTDescripcion"
        Me.TXTDescripcion.Size = New System.Drawing.Size(266, 25)
        Me.TXTDescripcion.TabIndex = 1
        '
        'LBLDescripcionCorta
        '
        Me.LBLDescripcionCorta.AutoSize = True
        Me.LBLDescripcionCorta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLDescripcionCorta.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDescripcionCorta.Location = New System.Drawing.Point(15, 68)
        Me.LBLDescripcionCorta.Name = "LBLDescripcionCorta"
        Me.LBLDescripcionCorta.Size = New System.Drawing.Size(110, 20)
        Me.LBLDescripcionCorta.TabIndex = 4
        Me.LBLDescripcionCorta.Text = "Descripción Corta:"
        '
        'LBLDescripcion
        '
        Me.LBLDescripcion.AutoSize = True
        Me.LBLDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLDescripcion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDescripcion.Location = New System.Drawing.Point(15, 29)
        Me.LBLDescripcion.Name = "LBLDescripcion"
        Me.LBLDescripcion.Size = New System.Drawing.Size(77, 20)
        Me.LBLDescripcion.TabIndex = 3
        Me.LBLDescripcion.Text = "Descripción:"
        '
        'LBLBuscar
        '
        Me.LBLBuscar.AutoSize = True
        Me.LBLBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLBuscar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBuscar.Location = New System.Drawing.Point(27, 190)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(123, 20)
        Me.LBLBuscar.TabIndex = 28
        Me.LBLBuscar.Text = "Buscar (Descripcion)"
        '
        'TXTBuscar
        '
        Me.TXTBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(206, 190)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(257, 20)
        Me.TXTBuscar.TabIndex = 27
        '
        'GBCargos
        '
        Me.GBCargos.BackColor = System.Drawing.Color.DarkKhaki
        Me.GBCargos.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.GBCargos.Controls.Add(Me.DGVCargo)
        Me.GBCargos.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBCargos.Location = New System.Drawing.Point(12, 225)
        Me.GBCargos.Name = "GBCargos"
        Me.GBCargos.Size = New System.Drawing.Size(559, 204)
        Me.GBCargos.TabIndex = 29
        Me.GBCargos.TabStop = False
        Me.GBCargos.Text = "Cargos en el Sistema"
        '
        'DGVCargo
        '
        Me.DGVCargo.BackgroundColor = System.Drawing.Color.Olive
        Me.DGVCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCargo.Location = New System.Drawing.Point(6, 24)
        Me.DGVCargo.Name = "DGVCargo"
        Me.DGVCargo.Size = New System.Drawing.Size(547, 175)
        Me.DGVCargo.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual2
        Me.GroupBox2.Controls.Add(Me.BTNAgregar)
        Me.GroupBox2.Controls.Add(Me.BTNSalir)
        Me.GroupBox2.Controls.Add(Me.BTNGuardar)
        Me.GroupBox2.Controls.Add(Me.BTNCancelar)
        Me.GroupBox2.Controls.Add(Me.BTNModificar)
        Me.GroupBox2.Controls.Add(Me.BTNEliminar)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(577, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(87, 254)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'BTNAgregar
        '
        Me.BTNAgregar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BTNSalir.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BTNGuardar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BTNCancelar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BTNModificar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BTNEliminar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEliminar.Location = New System.Drawing.Point(7, 131)
        Me.BTNEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(74, 33)
        Me.BTNEliminar.TabIndex = 19
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'FCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual1
        Me.ClientSize = New System.Drawing.Size(669, 431)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBCargos)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FCargo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO CARGO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBCargos.ResumeLayout(False)
        CType(Me.DGVCargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLValidarDescripcion As System.Windows.Forms.Label
    Friend WithEvents TXTDescripcionCorta As System.Windows.Forms.TextBox
    Friend WithEvents TXTDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents LBLDescripcionCorta As System.Windows.Forms.Label
    Friend WithEvents LBLDescripcion As System.Windows.Forms.Label
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GBCargos As System.Windows.Forms.GroupBox
    Friend WithEvents DGVCargo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNModificar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents LBLDepartamento As System.Windows.Forms.Label
    Friend WithEvents CMBDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents TXTDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents LBLValidarDepartamento As System.Windows.Forms.Label
    Friend WithEvents LBLValidarDescripcioncorta As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatorios As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatoriosAst As System.Windows.Forms.Label
End Class
