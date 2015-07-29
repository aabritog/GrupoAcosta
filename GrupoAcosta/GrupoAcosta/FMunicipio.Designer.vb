<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMunicipio
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
        Me.GBNuevoMunicipio = New System.Windows.Forms.GroupBox()
        Me.LBCamposObligatoriosAst = New System.Windows.Forms.Label()
        Me.LBCamposObligatorios = New System.Windows.Forms.Label()
        Me.LBLValidarProvincia = New System.Windows.Forms.Label()
        Me.TXTProvincia = New System.Windows.Forms.TextBox()
        Me.CMBProvincia = New System.Windows.Forms.ComboBox()
        Me.LBLValidarMunicipio = New System.Windows.Forms.Label()
        Me.TXTMunicipio = New System.Windows.Forms.TextBox()
        Me.LBLProvincia = New System.Windows.Forms.Label()
        Me.LBLMunicipio = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNModificar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.GBMunicipios = New System.Windows.Forms.GroupBox()
        Me.DGVMunicipio = New System.Windows.Forms.DataGridView()
        Me.GBNuevoMunicipio.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBMunicipios.SuspendLayout()
        CType(Me.DGVMunicipio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBNuevoMunicipio
        '
        Me.GBNuevoMunicipio.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.GBNuevoMunicipio.Controls.Add(Me.LBCamposObligatoriosAst)
        Me.GBNuevoMunicipio.Controls.Add(Me.LBCamposObligatorios)
        Me.GBNuevoMunicipio.Controls.Add(Me.LBLValidarProvincia)
        Me.GBNuevoMunicipio.Controls.Add(Me.TXTProvincia)
        Me.GBNuevoMunicipio.Controls.Add(Me.CMBProvincia)
        Me.GBNuevoMunicipio.Controls.Add(Me.LBLValidarMunicipio)
        Me.GBNuevoMunicipio.Controls.Add(Me.TXTMunicipio)
        Me.GBNuevoMunicipio.Controls.Add(Me.LBLProvincia)
        Me.GBNuevoMunicipio.Controls.Add(Me.LBLMunicipio)
        Me.GBNuevoMunicipio.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBNuevoMunicipio.Location = New System.Drawing.Point(12, 12)
        Me.GBNuevoMunicipio.Name = "GBNuevoMunicipio"
        Me.GBNuevoMunicipio.Size = New System.Drawing.Size(514, 129)
        Me.GBNuevoMunicipio.TabIndex = 2
        Me.GBNuevoMunicipio.TabStop = False
        Me.GBNuevoMunicipio.Text = "Nuevo Municipio"
        '
        'LBCamposObligatoriosAst
        '
        Me.LBCamposObligatoriosAst.AutoSize = True
        Me.LBCamposObligatoriosAst.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBCamposObligatoriosAst.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatoriosAst.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatoriosAst.Location = New System.Drawing.Point(444, 101)
        Me.LBCamposObligatoriosAst.Name = "LBCamposObligatoriosAst"
        Me.LBCamposObligatoriosAst.Size = New System.Drawing.Size(12, 15)
        Me.LBCamposObligatoriosAst.TabIndex = 48
        Me.LBCamposObligatoriosAst.Text = "*"
        '
        'LBCamposObligatorios
        '
        Me.LBCamposObligatorios.AutoSize = True
        Me.LBCamposObligatorios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBCamposObligatorios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatorios.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatorios.Location = New System.Drawing.Point(310, 101)
        Me.LBCamposObligatorios.Name = "LBCamposObligatorios"
        Me.LBCamposObligatorios.Size = New System.Drawing.Size(125, 15)
        Me.LBCamposObligatorios.TabIndex = 47
        Me.LBCamposObligatorios.Text = "Campos Obligatorios"
        '
        'LBLValidarProvincia
        '
        Me.LBLValidarProvincia.AutoSize = True
        Me.LBLValidarProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLValidarProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarProvincia.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarProvincia.Location = New System.Drawing.Point(445, 68)
        Me.LBLValidarProvincia.Name = "LBLValidarProvincia"
        Me.LBLValidarProvincia.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarProvincia.TabIndex = 33
        Me.LBLValidarProvincia.Text = "*"
        '
        'TXTProvincia
        '
        Me.TXTProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTProvincia.Enabled = False
        Me.TXTProvincia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTProvincia.Location = New System.Drawing.Point(448, 46)
        Me.TXTProvincia.Name = "TXTProvincia"
        Me.TXTProvincia.Size = New System.Drawing.Size(66, 20)
        Me.TXTProvincia.TabIndex = 32
        Me.TXTProvincia.Visible = False
        '
        'CMBProvincia
        '
        Me.CMBProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBProvincia.Enabled = False
        Me.CMBProvincia.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBProvincia.FormattingEnabled = True
        Me.CMBProvincia.Location = New System.Drawing.Point(185, 67)
        Me.CMBProvincia.Name = "CMBProvincia"
        Me.CMBProvincia.Size = New System.Drawing.Size(241, 25)
        Me.CMBProvincia.TabIndex = 31
        '
        'LBLValidarMunicipio
        '
        Me.LBLValidarMunicipio.AutoSize = True
        Me.LBLValidarMunicipio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLValidarMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarMunicipio.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarMunicipio.Location = New System.Drawing.Point(445, 23)
        Me.LBLValidarMunicipio.Name = "LBLValidarMunicipio"
        Me.LBLValidarMunicipio.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarMunicipio.TabIndex = 28
        Me.LBLValidarMunicipio.Text = "*"
        '
        'TXTMunicipio
        '
        Me.TXTMunicipio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMunicipio.Enabled = False
        Me.TXTMunicipio.Location = New System.Drawing.Point(185, 19)
        Me.TXTMunicipio.MaxLength = 30
        Me.TXTMunicipio.Name = "TXTMunicipio"
        Me.TXTMunicipio.Size = New System.Drawing.Size(241, 25)
        Me.TXTMunicipio.TabIndex = 5
        '
        'LBLProvincia
        '
        Me.LBLProvincia.AutoSize = True
        Me.LBLProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLProvincia.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProvincia.Location = New System.Drawing.Point(15, 68)
        Me.LBLProvincia.Name = "LBLProvincia"
        Me.LBLProvincia.Size = New System.Drawing.Size(60, 20)
        Me.LBLProvincia.TabIndex = 4
        Me.LBLProvincia.Text = "Provincia"
        '
        'LBLMunicipio
        '
        Me.LBLMunicipio.AutoSize = True
        Me.LBLMunicipio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLMunicipio.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMunicipio.Location = New System.Drawing.Point(15, 29)
        Me.LBLMunicipio.Name = "LBLMunicipio"
        Me.LBLMunicipio.Size = New System.Drawing.Size(62, 20)
        Me.LBLMunicipio.TabIndex = 3
        Me.LBLMunicipio.Text = "Municipio"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual2
        Me.GroupBox2.Controls.Add(Me.BTNAgregar)
        Me.GroupBox2.Controls.Add(Me.BTNSalir)
        Me.GroupBox2.Controls.Add(Me.BTNGuardar)
        Me.GroupBox2.Controls.Add(Me.BTNCancelar)
        Me.GroupBox2.Controls.Add(Me.BTNModificar)
        Me.GroupBox2.Controls.Add(Me.BTNEliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(532, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(85, 254)
        Me.GroupBox2.TabIndex = 24
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
        'LBLBuscar
        '
        Me.LBLBuscar.AutoSize = True
        Me.LBLBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLBuscar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBuscar.Location = New System.Drawing.Point(27, 159)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(111, 20)
        Me.LBLBuscar.TabIndex = 31
        Me.LBLBuscar.Text = "Buscar (Municipio)"
        '
        'TXTBuscar
        '
        Me.TXTBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(197, 161)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(241, 20)
        Me.TXTBuscar.TabIndex = 30
        '
        'GBMunicipios
        '
        Me.GBMunicipios.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.GBMunicipios.Controls.Add(Me.DGVMunicipio)
        Me.GBMunicipios.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMunicipios.Location = New System.Drawing.Point(12, 194)
        Me.GBMunicipios.Name = "GBMunicipios"
        Me.GBMunicipios.Size = New System.Drawing.Size(514, 193)
        Me.GBMunicipios.TabIndex = 32
        Me.GBMunicipios.TabStop = False
        Me.GBMunicipios.Text = "Municipios en el Sistema"
        '
        'DGVMunicipio
        '
        Me.DGVMunicipio.BackgroundColor = System.Drawing.Color.Olive
        Me.DGVMunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMunicipio.Location = New System.Drawing.Point(6, 24)
        Me.DGVMunicipio.Name = "DGVMunicipio"
        Me.DGVMunicipio.Size = New System.Drawing.Size(502, 159)
        Me.DGVMunicipio.TabIndex = 23
        '
        'FMunicipio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual2
        Me.ClientSize = New System.Drawing.Size(629, 390)
        Me.Controls.Add(Me.GBMunicipios)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBNuevoMunicipio)
        Me.Name = "FMunicipio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO MUNICIPIO"
        Me.GBNuevoMunicipio.ResumeLayout(False)
        Me.GBNuevoMunicipio.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GBMunicipios.ResumeLayout(False)
        CType(Me.DGVMunicipio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBNuevoMunicipio As System.Windows.Forms.GroupBox
    Friend WithEvents LBLValidarProvincia As System.Windows.Forms.Label
    Friend WithEvents TXTProvincia As System.Windows.Forms.TextBox
    Friend WithEvents CMBProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents LBLValidarMunicipio As System.Windows.Forms.Label
    Friend WithEvents TXTMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents LBLProvincia As System.Windows.Forms.Label
    Friend WithEvents LBLMunicipio As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNModificar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GBMunicipios As System.Windows.Forms.GroupBox
    Friend WithEvents DGVMunicipio As System.Windows.Forms.DataGridView
    Friend WithEvents LBCamposObligatoriosAst As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatorios As System.Windows.Forms.Label
End Class
