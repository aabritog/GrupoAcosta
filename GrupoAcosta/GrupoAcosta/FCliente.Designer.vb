<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCliente
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
        Me.GBCliente = New System.Windows.Forms.GroupBox()
        Me.LBLValidarProvincia = New System.Windows.Forms.Label()
        Me.CMBProvincia = New System.Windows.Forms.ComboBox()
        Me.LBLProvincia = New System.Windows.Forms.Label()
        Me.LBCamposObligatoriosAst = New System.Windows.Forms.Label()
        Me.LBCamposObligatorios = New System.Windows.Forms.Label()
        Me.LVTelefono = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNAgregarTelefono = New System.Windows.Forms.Button()
        Me.LBLValidarDireccion = New System.Windows.Forms.Label()
        Me.TXTDireccion = New System.Windows.Forms.TextBox()
        Me.LBLDireccion = New System.Windows.Forms.Label()
        Me.LBLValidarRif = New System.Windows.Forms.Label()
        Me.LBLValidarMunicipio = New System.Windows.Forms.Label()
        Me.TXTRif = New System.Windows.Forms.TextBox()
        Me.LBLRif = New System.Windows.Forms.Label()
        Me.CMBMunicipio = New System.Windows.Forms.ComboBox()
        Me.LBLValidarCliente = New System.Windows.Forms.Label()
        Me.TXTCliente = New System.Windows.Forms.TextBox()
        Me.LBLMunicipio = New System.Windows.Forms.Label()
        Me.LBLCliente = New System.Windows.Forms.Label()
        Me.TXTMunicipio = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNModificar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.GBC = New System.Windows.Forms.GroupBox()
        Me.DGVCliente = New System.Windows.Forms.DataGridView()
        Me.TXTProvincia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBCliente.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBC.SuspendLayout()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBCliente
        '
        Me.GBCliente.BackColor = System.Drawing.Color.White
        Me.GBCliente.Controls.Add(Me.LBLValidarProvincia)
        Me.GBCliente.Controls.Add(Me.CMBProvincia)
        Me.GBCliente.Controls.Add(Me.LBLProvincia)
        Me.GBCliente.Controls.Add(Me.LBCamposObligatoriosAst)
        Me.GBCliente.Controls.Add(Me.LBCamposObligatorios)
        Me.GBCliente.Controls.Add(Me.LVTelefono)
        Me.GBCliente.Controls.Add(Me.Label1)
        Me.GBCliente.Controls.Add(Me.BTNAgregarTelefono)
        Me.GBCliente.Controls.Add(Me.LBLValidarDireccion)
        Me.GBCliente.Controls.Add(Me.TXTDireccion)
        Me.GBCliente.Controls.Add(Me.LBLDireccion)
        Me.GBCliente.Controls.Add(Me.LBLValidarRif)
        Me.GBCliente.Controls.Add(Me.LBLValidarMunicipio)
        Me.GBCliente.Controls.Add(Me.TXTRif)
        Me.GBCliente.Controls.Add(Me.LBLRif)
        Me.GBCliente.Controls.Add(Me.CMBMunicipio)
        Me.GBCliente.Controls.Add(Me.LBLValidarCliente)
        Me.GBCliente.Controls.Add(Me.TXTCliente)
        Me.GBCliente.Controls.Add(Me.LBLMunicipio)
        Me.GBCliente.Controls.Add(Me.LBLCliente)
        Me.GBCliente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBCliente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GBCliente.Location = New System.Drawing.Point(12, 76)
        Me.GBCliente.Name = "GBCliente"
        Me.GBCliente.Size = New System.Drawing.Size(532, 266)
        Me.GBCliente.TabIndex = 1
        Me.GBCliente.TabStop = False
        Me.GBCliente.Text = "Nuevo Cliente"
        '
        'LBLValidarProvincia
        '
        Me.LBLValidarProvincia.AutoSize = True
        Me.LBLValidarProvincia.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarProvincia.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarProvincia.Location = New System.Drawing.Point(438, 60)
        Me.LBLValidarProvincia.Name = "LBLValidarProvincia"
        Me.LBLValidarProvincia.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarProvincia.TabIndex = 47
        Me.LBLValidarProvincia.Text = "*"
        '
        'CMBProvincia
        '
        Me.CMBProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CMBProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBProvincia.Enabled = False
        Me.CMBProvincia.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBProvincia.FormattingEnabled = True
        Me.CMBProvincia.Location = New System.Drawing.Point(153, 61)
        Me.CMBProvincia.Name = "CMBProvincia"
        Me.CMBProvincia.Size = New System.Drawing.Size(259, 25)
        Me.CMBProvincia.TabIndex = 2
        '
        'LBLProvincia
        '
        Me.LBLProvincia.AutoSize = True
        Me.LBLProvincia.BackColor = System.Drawing.Color.Transparent
        Me.LBLProvincia.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProvincia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLProvincia.Location = New System.Drawing.Point(16, 61)
        Me.LBLProvincia.Name = "LBLProvincia"
        Me.LBLProvincia.Size = New System.Drawing.Size(63, 20)
        Me.LBLProvincia.TabIndex = 45
        Me.LBLProvincia.Text = "Provincia:"
        '
        'LBCamposObligatoriosAst
        '
        Me.LBCamposObligatoriosAst.AutoSize = True
        Me.LBCamposObligatoriosAst.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatoriosAst.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatoriosAst.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatoriosAst.Location = New System.Drawing.Point(438, 241)
        Me.LBCamposObligatoriosAst.Name = "LBCamposObligatoriosAst"
        Me.LBCamposObligatoriosAst.Size = New System.Drawing.Size(14, 17)
        Me.LBCamposObligatoriosAst.TabIndex = 44
        Me.LBCamposObligatoriosAst.Text = "*"
        '
        'LBCamposObligatorios
        '
        Me.LBCamposObligatorios.AutoSize = True
        Me.LBCamposObligatorios.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatorios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatorios.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatorios.Location = New System.Drawing.Point(287, 243)
        Me.LBCamposObligatorios.Name = "LBCamposObligatorios"
        Me.LBCamposObligatorios.Size = New System.Drawing.Size(125, 15)
        Me.LBCamposObligatorios.TabIndex = 43
        Me.LBCamposObligatorios.Text = "Campos Obligatorios"
        '
        'LVTelefono
        '
        Me.LVTelefono.BackColor = System.Drawing.Color.White
        Me.LVTelefono.Location = New System.Drawing.Point(245, 211)
        Me.LVTelefono.Name = "LVTelefono"
        Me.LVTelefono.Size = New System.Drawing.Size(167, 24)
        Me.LVTelefono.TabIndex = 6
        Me.LVTelefono.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(15, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Telefono:"
        '
        'BTNAgregarTelefono
        '
        Me.BTNAgregarTelefono.Enabled = False
        Me.BTNAgregarTelefono.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAgregarTelefono.Location = New System.Drawing.Point(153, 211)
        Me.BTNAgregarTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNAgregarTelefono.Name = "BTNAgregarTelefono"
        Me.BTNAgregarTelefono.Size = New System.Drawing.Size(74, 24)
        Me.BTNAgregarTelefono.TabIndex = 41
        Me.BTNAgregarTelefono.Text = "Agregar >>"
        Me.BTNAgregarTelefono.UseVisualStyleBackColor = True
        '
        'LBLValidarDireccion
        '
        Me.LBLValidarDireccion.AutoSize = True
        Me.LBLValidarDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarDireccion.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarDireccion.Location = New System.Drawing.Point(438, 175)
        Me.LBLValidarDireccion.Name = "LBLValidarDireccion"
        Me.LBLValidarDireccion.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarDireccion.TabIndex = 40
        Me.LBLValidarDireccion.Text = "*"
        '
        'TXTDireccion
        '
        Me.TXTDireccion.BackColor = System.Drawing.Color.White
        Me.TXTDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDireccion.Enabled = False
        Me.TXTDireccion.Location = New System.Drawing.Point(153, 175)
        Me.TXTDireccion.MaxLength = 30
        Me.TXTDireccion.Name = "TXTDireccion"
        Me.TXTDireccion.Size = New System.Drawing.Size(259, 25)
        Me.TXTDireccion.TabIndex = 5
        '
        'LBLDireccion
        '
        Me.LBLDireccion.AutoSize = True
        Me.LBLDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LBLDireccion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDireccion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLDireccion.Location = New System.Drawing.Point(16, 180)
        Me.LBLDireccion.Name = "LBLDireccion"
        Me.LBLDireccion.Size = New System.Drawing.Size(64, 20)
        Me.LBLDireccion.TabIndex = 38
        Me.LBLDireccion.Text = "Direccion:"
        '
        'LBLValidarRif
        '
        Me.LBLValidarRif.AutoSize = True
        Me.LBLValidarRif.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarRif.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarRif.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarRif.Location = New System.Drawing.Point(438, 137)
        Me.LBLValidarRif.Name = "LBLValidarRif"
        Me.LBLValidarRif.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarRif.TabIndex = 37
        Me.LBLValidarRif.Text = "*"
        '
        'LBLValidarMunicipio
        '
        Me.LBLValidarMunicipio.AutoSize = True
        Me.LBLValidarMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarMunicipio.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarMunicipio.Location = New System.Drawing.Point(438, 99)
        Me.LBLValidarMunicipio.Name = "LBLValidarMunicipio"
        Me.LBLValidarMunicipio.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarMunicipio.TabIndex = 33
        Me.LBLValidarMunicipio.Text = "*"
        '
        'TXTRif
        '
        Me.TXTRif.BackColor = System.Drawing.Color.White
        Me.TXTRif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTRif.Enabled = False
        Me.TXTRif.Location = New System.Drawing.Point(153, 137)
        Me.TXTRif.MaxLength = 15
        Me.TXTRif.Name = "TXTRif"
        Me.TXTRif.Size = New System.Drawing.Size(259, 25)
        Me.TXTRif.TabIndex = 4
        '
        'LBLRif
        '
        Me.LBLRif.AutoSize = True
        Me.LBLRif.BackColor = System.Drawing.Color.Transparent
        Me.LBLRif.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRif.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLRif.Location = New System.Drawing.Point(16, 142)
        Me.LBLRif.Name = "LBLRif"
        Me.LBLRif.Size = New System.Drawing.Size(27, 20)
        Me.LBLRif.TabIndex = 35
        Me.LBLRif.Text = "Rif:"
        '
        'CMBMunicipio
        '
        Me.CMBMunicipio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CMBMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBMunicipio.Enabled = False
        Me.CMBMunicipio.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMunicipio.FormattingEnabled = True
        Me.CMBMunicipio.Location = New System.Drawing.Point(153, 99)
        Me.CMBMunicipio.Name = "CMBMunicipio"
        Me.CMBMunicipio.Size = New System.Drawing.Size(259, 25)
        Me.CMBMunicipio.TabIndex = 3
        '
        'LBLValidarCliente
        '
        Me.LBLValidarCliente.AutoSize = True
        Me.LBLValidarCliente.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarCliente.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarCliente.Location = New System.Drawing.Point(438, 24)
        Me.LBLValidarCliente.Name = "LBLValidarCliente"
        Me.LBLValidarCliente.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarCliente.TabIndex = 28
        Me.LBLValidarCliente.Text = "*"
        '
        'TXTCliente
        '
        Me.TXTCliente.BackColor = System.Drawing.Color.White
        Me.TXTCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCliente.Enabled = False
        Me.TXTCliente.Location = New System.Drawing.Point(153, 24)
        Me.TXTCliente.MaxLength = 30
        Me.TXTCliente.Name = "TXTCliente"
        Me.TXTCliente.Size = New System.Drawing.Size(259, 25)
        Me.TXTCliente.TabIndex = 1
        '
        'LBLMunicipio
        '
        Me.LBLMunicipio.AutoSize = True
        Me.LBLMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.LBLMunicipio.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMunicipio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLMunicipio.Location = New System.Drawing.Point(16, 104)
        Me.LBLMunicipio.Name = "LBLMunicipio"
        Me.LBLMunicipio.Size = New System.Drawing.Size(65, 20)
        Me.LBLMunicipio.TabIndex = 4
        Me.LBLMunicipio.Text = "Municipio:"
        '
        'LBLCliente
        '
        Me.LBLCliente.AutoSize = True
        Me.LBLCliente.BackColor = System.Drawing.Color.Transparent
        Me.LBLCliente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCliente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLCliente.Location = New System.Drawing.Point(15, 24)
        Me.LBLCliente.Name = "LBLCliente"
        Me.LBLCliente.Size = New System.Drawing.Size(51, 20)
        Me.LBLCliente.TabIndex = 3
        Me.LBLCliente.Text = "Cliente:"
        '
        'TXTMunicipio
        '
        Me.TXTMunicipio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTMunicipio.Enabled = False
        Me.TXTMunicipio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMunicipio.Location = New System.Drawing.Point(550, 173)
        Me.TXTMunicipio.Name = "TXTMunicipio"
        Me.TXTMunicipio.Size = New System.Drawing.Size(66, 20)
        Me.TXTMunicipio.TabIndex = 32
        Me.TXTMunicipio.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox2.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual2
        Me.GroupBox2.Controls.Add(Me.BTNAgregar)
        Me.GroupBox2.Controls.Add(Me.BTNSalir)
        Me.GroupBox2.Controls.Add(Me.BTNGuardar)
        Me.GroupBox2.Controls.Add(Me.BTNCancelar)
        Me.GroupBox2.Controls.Add(Me.BTNModificar)
        Me.GroupBox2.Controls.Add(Me.BTNEliminar)
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(577, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(87, 254)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'BTNAgregar
        '
        Me.BTNAgregar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.LBLBuscar.Location = New System.Drawing.Point(28, 362)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(105, 20)
        Me.LBLBuscar.TabIndex = 29
        Me.LBLBuscar.Text = "Buscar (Cliente)"
        '
        'TXTBuscar
        '
        Me.TXTBuscar.BackColor = System.Drawing.Color.White
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(165, 362)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(259, 20)
        Me.TXTBuscar.TabIndex = 7
        '
        'GBC
        '
        Me.GBC.BackColor = System.Drawing.Color.DarkKhaki
        Me.GBC.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.GBC.Controls.Add(Me.DGVCliente)
        Me.GBC.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBC.Location = New System.Drawing.Point(12, 393)
        Me.GBC.Name = "GBC"
        Me.GBC.Size = New System.Drawing.Size(532, 190)
        Me.GBC.TabIndex = 30
        Me.GBC.TabStop = False
        '
        'DGVCliente
        '
        Me.DGVCliente.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCliente.Location = New System.Drawing.Point(6, 13)
        Me.DGVCliente.Name = "DGVCliente"
        Me.DGVCliente.Size = New System.Drawing.Size(520, 174)
        Me.DGVCliente.TabIndex = 23
        '
        'TXTProvincia
        '
        Me.TXTProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTProvincia.Enabled = False
        Me.TXTProvincia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTProvincia.Location = New System.Drawing.Point(550, 139)
        Me.TXTProvincia.Name = "TXTProvincia"
        Me.TXTProvincia.Size = New System.Drawing.Size(66, 20)
        Me.TXTProvincia.TabIndex = 33
        Me.TXTProvincia.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(14, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "MÓDULO CLIENTE"
        '
        'FCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.ClientSize = New System.Drawing.Size(672, 583)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTProvincia)
        Me.Controls.Add(Me.GBC)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBCliente)
        Me.Controls.Add(Me.TXTMunicipio)
        Me.Name = "FCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO CLIENTE"
        Me.GBCliente.ResumeLayout(False)
        Me.GBCliente.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GBC.ResumeLayout(False)
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBCliente As System.Windows.Forms.GroupBox
    Friend WithEvents LBLValidarCliente As System.Windows.Forms.Label
    Friend WithEvents TXTCliente As System.Windows.Forms.TextBox
    Friend WithEvents LBLMunicipio As System.Windows.Forms.Label
    Friend WithEvents LBLCliente As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNModificar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GBC As System.Windows.Forms.GroupBox
    Friend WithEvents DGVCliente As System.Windows.Forms.DataGridView
    Friend WithEvents CMBMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents TXTMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents LBLValidarMunicipio As System.Windows.Forms.Label
    Friend WithEvents LBLValidarRif As System.Windows.Forms.Label
    Friend WithEvents TXTRif As System.Windows.Forms.TextBox
    Friend WithEvents LBLRif As System.Windows.Forms.Label
    Friend WithEvents LBLValidarDireccion As System.Windows.Forms.Label
    Friend WithEvents TXTDireccion As System.Windows.Forms.TextBox
    Friend WithEvents LBLDireccion As System.Windows.Forms.Label
    Friend WithEvents LVTelefono As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNAgregarTelefono As System.Windows.Forms.Button
    Friend WithEvents LBCamposObligatorios As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatoriosAst As System.Windows.Forms.Label
    Friend WithEvents LBLValidarProvincia As System.Windows.Forms.Label
    Friend WithEvents CMBProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents LBLProvincia As System.Windows.Forms.Label
    Friend WithEvents TXTProvincia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
