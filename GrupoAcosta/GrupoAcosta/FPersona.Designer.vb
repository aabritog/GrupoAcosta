<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPersona))
        Me.GBPersona = New System.Windows.Forms.GroupBox()
        Me.DGVPersona = New System.Windows.Forms.DataGridView()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.BTNModificar = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.GBNuevoRegistro = New System.Windows.Forms.GroupBox()
        Me.LVTelefonos = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNAgregarTelefono = New System.Windows.Forms.Button()
        Me.LBCamposObligatoriosAst = New System.Windows.Forms.Label()
        Me.LBValidadNacionalidad = New System.Windows.Forms.Label()
        Me.LBCamposObligatorios = New System.Windows.Forms.Label()
        Me.LBValidarCargo = New System.Windows.Forms.Label()
        Me.LBValidarDpto = New System.Windows.Forms.Label()
        Me.LBValidarSexo = New System.Windows.Forms.Label()
        Me.LBValidarFechaNacimiento = New System.Windows.Forms.Label()
        Me.LBValidarCi = New System.Windows.Forms.Label()
        Me.LBValidarApellido2 = New System.Windows.Forms.Label()
        Me.LBValidarApellido1 = New System.Windows.Forms.Label()
        Me.LBValidarNombre1 = New System.Windows.Forms.Label()
        Me.CMBDepartamento = New System.Windows.Forms.ComboBox()
        Me.LBLDepartamento = New System.Windows.Forms.Label()
        Me.CMBCargo = New System.Windows.Forms.ComboBox()
        Me.CMBSexo = New System.Windows.Forms.ComboBox()
        Me.TXTCorreo = New System.Windows.Forms.TextBox()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.TXTCI = New System.Windows.Forms.TextBox()
        Me.CMBNacionalidad = New System.Windows.Forms.ComboBox()
        Me.TXTApellido2 = New System.Windows.Forms.TextBox()
        Me.TXTApellido1 = New System.Windows.Forms.TextBox()
        Me.TXTNombre2 = New System.Windows.Forms.TextBox()
        Me.TXTNombre1 = New System.Windows.Forms.TextBox()
        Me.LBLCargo = New System.Windows.Forms.Label()
        Me.LBLSexo = New System.Windows.Forms.Label()
        Me.LBLCorreo = New System.Windows.Forms.Label()
        Me.LBLFecha = New System.Windows.Forms.Label()
        Me.LBLCI = New System.Windows.Forms.Label()
        Me.LBLApellido2 = New System.Windows.Forms.Label()
        Me.LBLNombre2 = New System.Windows.Forms.Label()
        Me.LBLApellido1 = New System.Windows.Forms.Label()
        Me.LBLNombre1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.TXTFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.TXTCargo = New System.Windows.Forms.TextBox()
        Me.TXTSexo = New System.Windows.Forms.TextBox()
        Me.TXTDepartamento = New System.Windows.Forms.TextBox()
        Me.TXTNacionalidad = New System.Windows.Forms.TextBox()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTFPersona = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBPersona.SuspendLayout()
        CType(Me.DGVPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBNuevoRegistro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBPersona
        '
        Me.GBPersona.BackColor = System.Drawing.Color.White
        Me.GBPersona.Controls.Add(Me.DGVPersona)
        Me.GBPersona.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPersona.Location = New System.Drawing.Point(14, 487)
        Me.GBPersona.Margin = New System.Windows.Forms.Padding(4)
        Me.GBPersona.Name = "GBPersona"
        Me.GBPersona.Padding = New System.Windows.Forms.Padding(4)
        Me.GBPersona.Size = New System.Drawing.Size(749, 200)
        Me.GBPersona.TabIndex = 2
        Me.GBPersona.TabStop = False
        '
        'DGVPersona
        '
        Me.DGVPersona.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DGVPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPersona.Location = New System.Drawing.Point(8, 12)
        Me.DGVPersona.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVPersona.Name = "DGVPersona"
        Me.DGVPersona.Size = New System.Drawing.Size(733, 180)
        Me.DGVPersona.TabIndex = 99
        Me.DGVPersona.TabStop = False
        Me.TTFPersona.SetToolTip(Me.DGVPersona, "Personas registradas en el sistema")
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Enabled = False
        Me.BTNCancelar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCancelar.Location = New System.Drawing.Point(13, 178)
        Me.BTNCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(74, 33)
        Me.BTNCancelar.TabIndex = 4
        Me.BTNCancelar.Text = "Cancelar"
        Me.TTFPersona.SetToolTip(Me.BTNCancelar, "Presione aquí para cancelar cualquier cambio en la ventana actual")
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Enabled = False
        Me.BTNEliminar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEliminar.Location = New System.Drawing.Point(13, 137)
        Me.BTNEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(74, 33)
        Me.BTNEliminar.TabIndex = 3
        Me.BTNEliminar.Text = "Eliminar"
        Me.TTFPersona.SetToolTip(Me.BTNEliminar, "Presione aquí para eliminar la persona seleccionada del listado")
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'BTNModificar
        '
        Me.BTNModificar.Enabled = False
        Me.BTNModificar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNModificar.Location = New System.Drawing.Point(13, 96)
        Me.BTNModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNModificar.Name = "BTNModificar"
        Me.BTNModificar.Size = New System.Drawing.Size(74, 33)
        Me.BTNModificar.TabIndex = 2
        Me.BTNModificar.Text = "Modificar"
        Me.TTFPersona.SetToolTip(Me.BTNModificar, "Presione aquí para modificar la persona seleccionada del listado")
        Me.BTNModificar.UseVisualStyleBackColor = True
        '
        'BTNGuardar
        '
        Me.BTNGuardar.Enabled = False
        Me.BTNGuardar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGuardar.Location = New System.Drawing.Point(13, 55)
        Me.BTNGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(74, 33)
        Me.BTNGuardar.TabIndex = 1
        Me.BTNGuardar.Text = "Guardar"
        Me.TTFPersona.SetToolTip(Me.BTNGuardar, "Presione aquí para guardar los cambios")
        Me.BTNGuardar.UseVisualStyleBackColor = True
        '
        'TXTBuscar
        '
        Me.TXTBuscar.BackColor = System.Drawing.Color.White
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBuscar.Location = New System.Drawing.Point(519, 419)
        Me.TXTBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(252, 25)
        Me.TXTBuscar.TabIndex = 13
        Me.TTFPersona.SetToolTip(Me.TXTBuscar, "Escriba aquí para buscar una persona del listado")
        '
        'LBLBuscar
        '
        Me.LBLBuscar.AutoSize = True
        Me.LBLBuscar.BackColor = System.Drawing.Color.Transparent
        Me.LBLBuscar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBuscar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLBuscar.Location = New System.Drawing.Point(551, 392)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(204, 20)
        Me.LBLBuscar.TabIndex = 1
        Me.LBLBuscar.Text = "Buscar (Nombres, Apellidos, C.I)"
        '
        'GBNuevoRegistro
        '
        Me.GBNuevoRegistro.BackColor = System.Drawing.Color.White
        Me.GBNuevoRegistro.Controls.Add(Me.LVTelefonos)
        Me.GBNuevoRegistro.Controls.Add(Me.Label1)
        Me.GBNuevoRegistro.Controls.Add(Me.BTNAgregarTelefono)
        Me.GBNuevoRegistro.Controls.Add(Me.LBCamposObligatoriosAst)
        Me.GBNuevoRegistro.Controls.Add(Me.LBValidadNacionalidad)
        Me.GBNuevoRegistro.Controls.Add(Me.LBCamposObligatorios)
        Me.GBNuevoRegistro.Controls.Add(Me.LBValidarCargo)
        Me.GBNuevoRegistro.Controls.Add(Me.LBValidarDpto)
        Me.GBNuevoRegistro.Controls.Add(Me.LBValidarSexo)
        Me.GBNuevoRegistro.Controls.Add(Me.LBValidarFechaNacimiento)
        Me.GBNuevoRegistro.Controls.Add(Me.LBValidarCi)
        Me.GBNuevoRegistro.Controls.Add(Me.LBValidarApellido2)
        Me.GBNuevoRegistro.Controls.Add(Me.LBValidarApellido1)
        Me.GBNuevoRegistro.Controls.Add(Me.LBValidarNombre1)
        Me.GBNuevoRegistro.Controls.Add(Me.CMBDepartamento)
        Me.GBNuevoRegistro.Controls.Add(Me.LBLDepartamento)
        Me.GBNuevoRegistro.Controls.Add(Me.CMBCargo)
        Me.GBNuevoRegistro.Controls.Add(Me.CMBSexo)
        Me.GBNuevoRegistro.Controls.Add(Me.TXTCorreo)
        Me.GBNuevoRegistro.Controls.Add(Me.DTPFecha)
        Me.GBNuevoRegistro.Controls.Add(Me.TXTCI)
        Me.GBNuevoRegistro.Controls.Add(Me.CMBNacionalidad)
        Me.GBNuevoRegistro.Controls.Add(Me.TXTApellido2)
        Me.GBNuevoRegistro.Controls.Add(Me.TXTApellido1)
        Me.GBNuevoRegistro.Controls.Add(Me.TXTNombre2)
        Me.GBNuevoRegistro.Controls.Add(Me.TXTNombre1)
        Me.GBNuevoRegistro.Controls.Add(Me.LBLCargo)
        Me.GBNuevoRegistro.Controls.Add(Me.LBLSexo)
        Me.GBNuevoRegistro.Controls.Add(Me.LBLCorreo)
        Me.GBNuevoRegistro.Controls.Add(Me.LBLFecha)
        Me.GBNuevoRegistro.Controls.Add(Me.LBLCI)
        Me.GBNuevoRegistro.Controls.Add(Me.LBLApellido2)
        Me.GBNuevoRegistro.Controls.Add(Me.LBLNombre2)
        Me.GBNuevoRegistro.Controls.Add(Me.LBLApellido1)
        Me.GBNuevoRegistro.Controls.Add(Me.LBLNombre1)
        Me.GBNuevoRegistro.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBNuevoRegistro.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GBNuevoRegistro.Location = New System.Drawing.Point(14, 73)
        Me.GBNuevoRegistro.Name = "GBNuevoRegistro"
        Me.GBNuevoRegistro.Size = New System.Drawing.Size(498, 407)
        Me.GBNuevoRegistro.TabIndex = 5
        Me.GBNuevoRegistro.TabStop = False
        Me.GBNuevoRegistro.Text = "Registrar Nueva Persona"
        '
        'LVTelefonos
        '
        Me.LVTelefonos.BackColor = System.Drawing.Color.White
        Me.LVTelefonos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVTelefonos.Location = New System.Drawing.Point(271, 252)
        Me.LVTelefonos.MultiSelect = False
        Me.LVTelefonos.Name = "LVTelefonos"
        Me.LVTelefonos.Size = New System.Drawing.Size(177, 29)
        Me.LVTelefonos.TabIndex = 9
        Me.LVTelefonos.UseCompatibleStateImageBehavior = False
        Me.LVTelefonos.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Telefono:"
        '
        'BTNAgregarTelefono
        '
        Me.BTNAgregarTelefono.Enabled = False
        Me.BTNAgregarTelefono.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAgregarTelefono.Location = New System.Drawing.Point(190, 254)
        Me.BTNAgregarTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNAgregarTelefono.Name = "BTNAgregarTelefono"
        Me.BTNAgregarTelefono.Size = New System.Drawing.Size(74, 24)
        Me.BTNAgregarTelefono.TabIndex = 23
        Me.BTNAgregarTelefono.Text = "Agregar >>"
        Me.TTFPersona.SetToolTip(Me.BTNAgregarTelefono, "Presione aquí para agregar los telefonos de la persona")
        Me.BTNAgregarTelefono.UseVisualStyleBackColor = True
        '
        'LBCamposObligatoriosAst
        '
        Me.LBCamposObligatoriosAst.AutoSize = True
        Me.LBCamposObligatoriosAst.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatoriosAst.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.LBCamposObligatoriosAst.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatoriosAst.Location = New System.Drawing.Point(456, 388)
        Me.LBCamposObligatoriosAst.Name = "LBCamposObligatoriosAst"
        Me.LBCamposObligatoriosAst.Size = New System.Drawing.Size(14, 17)
        Me.LBCamposObligatoriosAst.TabIndex = 18
        Me.LBCamposObligatoriosAst.Text = "*"
        '
        'LBValidadNacionalidad
        '
        Me.LBValidadNacionalidad.AutoSize = True
        Me.LBValidadNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidadNacionalidad.ForeColor = System.Drawing.Color.Red
        Me.LBValidadNacionalidad.Location = New System.Drawing.Point(229, 164)
        Me.LBValidadNacionalidad.Name = "LBValidadNacionalidad"
        Me.LBValidadNacionalidad.Size = New System.Drawing.Size(14, 18)
        Me.LBValidadNacionalidad.TabIndex = 30
        Me.LBValidadNacionalidad.Text = "*"
        '
        'LBCamposObligatorios
        '
        Me.LBCamposObligatorios.AutoSize = True
        Me.LBCamposObligatorios.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatorios.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatorios.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatorios.Location = New System.Drawing.Point(323, 386)
        Me.LBCamposObligatorios.Name = "LBCamposObligatorios"
        Me.LBCamposObligatorios.Size = New System.Drawing.Size(119, 16)
        Me.LBCamposObligatorios.TabIndex = 19
        Me.LBCamposObligatorios.Text = "Campos Obligatorios"
        '
        'LBValidarCargo
        '
        Me.LBValidarCargo.AutoSize = True
        Me.LBValidarCargo.BackColor = System.Drawing.Color.Transparent
        Me.LBValidarCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarCargo.ForeColor = System.Drawing.Color.Red
        Me.LBValidarCargo.Location = New System.Drawing.Point(454, 353)
        Me.LBValidarCargo.Name = "LBValidarCargo"
        Me.LBValidarCargo.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarCargo.TabIndex = 29
        Me.LBValidarCargo.Text = "*"
        '
        'LBValidarDpto
        '
        Me.LBValidarDpto.AutoSize = True
        Me.LBValidarDpto.BackColor = System.Drawing.Color.Transparent
        Me.LBValidarDpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarDpto.ForeColor = System.Drawing.Color.Red
        Me.LBValidarDpto.Location = New System.Drawing.Point(454, 318)
        Me.LBValidarDpto.Name = "LBValidarDpto"
        Me.LBValidarDpto.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarDpto.TabIndex = 28
        Me.LBValidarDpto.Text = "*"
        '
        'LBValidarSexo
        '
        Me.LBValidarSexo.AutoSize = True
        Me.LBValidarSexo.BackColor = System.Drawing.Color.Transparent
        Me.LBValidarSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarSexo.ForeColor = System.Drawing.Color.Red
        Me.LBValidarSexo.Location = New System.Drawing.Point(454, 285)
        Me.LBValidarSexo.Name = "LBValidarSexo"
        Me.LBValidarSexo.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarSexo.TabIndex = 27
        Me.LBValidarSexo.Text = "*"
        '
        'LBValidarFechaNacimiento
        '
        Me.LBValidarFechaNacimiento.AutoSize = True
        Me.LBValidarFechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.LBValidarFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarFechaNacimiento.ForeColor = System.Drawing.Color.Red
        Me.LBValidarFechaNacimiento.Location = New System.Drawing.Point(454, 190)
        Me.LBValidarFechaNacimiento.Name = "LBValidarFechaNacimiento"
        Me.LBValidarFechaNacimiento.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarFechaNacimiento.TabIndex = 25
        Me.LBValidarFechaNacimiento.Text = "*"
        '
        'LBValidarCi
        '
        Me.LBValidarCi.AutoSize = True
        Me.LBValidarCi.BackColor = System.Drawing.Color.Transparent
        Me.LBValidarCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarCi.ForeColor = System.Drawing.Color.Red
        Me.LBValidarCi.Location = New System.Drawing.Point(454, 159)
        Me.LBValidarCi.Name = "LBValidarCi"
        Me.LBValidarCi.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarCi.TabIndex = 24
        Me.LBValidarCi.Text = "*"
        '
        'LBValidarApellido2
        '
        Me.LBValidarApellido2.AutoSize = True
        Me.LBValidarApellido2.BackColor = System.Drawing.Color.Transparent
        Me.LBValidarApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarApellido2.ForeColor = System.Drawing.Color.Red
        Me.LBValidarApellido2.Location = New System.Drawing.Point(454, 128)
        Me.LBValidarApellido2.Name = "LBValidarApellido2"
        Me.LBValidarApellido2.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarApellido2.TabIndex = 23
        Me.LBValidarApellido2.Text = "*"
        '
        'LBValidarApellido1
        '
        Me.LBValidarApellido1.AutoSize = True
        Me.LBValidarApellido1.BackColor = System.Drawing.Color.Transparent
        Me.LBValidarApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarApellido1.ForeColor = System.Drawing.Color.Red
        Me.LBValidarApellido1.Location = New System.Drawing.Point(454, 90)
        Me.LBValidarApellido1.Name = "LBValidarApellido1"
        Me.LBValidarApellido1.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarApellido1.TabIndex = 22
        Me.LBValidarApellido1.Text = "*"
        '
        'LBValidarNombre1
        '
        Me.LBValidarNombre1.AutoSize = True
        Me.LBValidarNombre1.BackColor = System.Drawing.Color.Transparent
        Me.LBValidarNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarNombre1.ForeColor = System.Drawing.Color.Red
        Me.LBValidarNombre1.Location = New System.Drawing.Point(454, 26)
        Me.LBValidarNombre1.Name = "LBValidarNombre1"
        Me.LBValidarNombre1.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarNombre1.TabIndex = 19
        Me.LBValidarNombre1.Text = "*"
        '
        'CMBDepartamento
        '
        Me.CMBDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBDepartamento.Enabled = False
        Me.CMBDepartamento.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBDepartamento.FormattingEnabled = True
        Me.CMBDepartamento.Location = New System.Drawing.Point(190, 318)
        Me.CMBDepartamento.Name = "CMBDepartamento"
        Me.CMBDepartamento.Size = New System.Drawing.Size(258, 25)
        Me.CMBDepartamento.TabIndex = 11
        Me.TTFPersona.SetToolTip(Me.CMBDepartamento, "Seleccione aquí para seleccionar el departamento al cual pertenece la persona")
        '
        'LBLDepartamento
        '
        Me.LBLDepartamento.AutoSize = True
        Me.LBLDepartamento.BackColor = System.Drawing.Color.Transparent
        Me.LBLDepartamento.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDepartamento.Location = New System.Drawing.Point(16, 327)
        Me.LBLDepartamento.Name = "LBLDepartamento"
        Me.LBLDepartamento.Size = New System.Drawing.Size(90, 20)
        Me.LBLDepartamento.TabIndex = 19
        Me.LBLDepartamento.Text = "Departamento:"
        '
        'CMBCargo
        '
        Me.CMBCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBCargo.Enabled = False
        Me.CMBCargo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCargo.FormattingEnabled = True
        Me.CMBCargo.Location = New System.Drawing.Point(190, 351)
        Me.CMBCargo.Name = "CMBCargo"
        Me.CMBCargo.Size = New System.Drawing.Size(258, 25)
        Me.CMBCargo.TabIndex = 12
        Me.TTFPersona.SetToolTip(Me.CMBCargo, "Seleccione aquí para seleccionar el cargo que tiene asignado la persona dentro en" & _
                " la empresa")
        '
        'CMBSexo
        '
        Me.CMBSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBSexo.Enabled = False
        Me.CMBSexo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBSexo.FormattingEnabled = True
        Me.CMBSexo.Items.AddRange(New Object() {"", "Femenino", "Masculino"})
        Me.CMBSexo.Location = New System.Drawing.Point(190, 284)
        Me.CMBSexo.Name = "CMBSexo"
        Me.CMBSexo.Size = New System.Drawing.Size(258, 25)
        Me.CMBSexo.TabIndex = 10
        Me.TTFPersona.SetToolTip(Me.CMBSexo, "Seleccione aquí para seleccionar el sexo de la persona")
        '
        'TXTCorreo
        '
        Me.TXTCorreo.BackColor = System.Drawing.Color.White
        Me.TXTCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TXTCorreo.Enabled = False
        Me.TXTCorreo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCorreo.Location = New System.Drawing.Point(190, 224)
        Me.TXTCorreo.MaxLength = 50
        Me.TXTCorreo.Name = "TXTCorreo"
        Me.TXTCorreo.Size = New System.Drawing.Size(258, 25)
        Me.TXTCorreo.TabIndex = 8
        '
        'DTPFecha
        '
        Me.DTPFecha.Enabled = False
        Me.DTPFecha.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(190, 191)
        Me.DTPFecha.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.DTPFecha.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(258, 25)
        Me.DTPFecha.TabIndex = 7
        Me.TTFPersona.SetToolTip(Me.DTPFecha, "Seleccione/escriba aquí la fecha de nacimiento de la persona a registrar")
        Me.DTPFecha.Value = New Date(1940, 1, 1, 0, 0, 0, 0)
        '
        'TXTCI
        '
        Me.TXTCI.BackColor = System.Drawing.Color.White
        Me.TXTCI.Enabled = False
        Me.TXTCI.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCI.Location = New System.Drawing.Point(246, 157)
        Me.TXTCI.MaxLength = 20
        Me.TXTCI.Name = "TXTCI"
        Me.TXTCI.Size = New System.Drawing.Size(202, 25)
        Me.TXTCI.TabIndex = 6
        '
        'CMBNacionalidad
        '
        Me.CMBNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBNacionalidad.Enabled = False
        Me.CMBNacionalidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBNacionalidad.FormattingEnabled = True
        Me.CMBNacionalidad.Items.AddRange(New Object() {"", "V", "E"})
        Me.CMBNacionalidad.Location = New System.Drawing.Point(190, 156)
        Me.CMBNacionalidad.Name = "CMBNacionalidad"
        Me.CMBNacionalidad.Size = New System.Drawing.Size(35, 24)
        Me.CMBNacionalidad.TabIndex = 13
        Me.TTFPersona.SetToolTip(Me.CMBNacionalidad, "Presione aquí para elegir la nacionalidad de la persona")
        '
        'TXTApellido2
        '
        Me.TXTApellido2.BackColor = System.Drawing.Color.White
        Me.TXTApellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTApellido2.Enabled = False
        Me.TXTApellido2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTApellido2.Location = New System.Drawing.Point(190, 125)
        Me.TXTApellido2.MaxLength = 15
        Me.TXTApellido2.Name = "TXTApellido2"
        Me.TXTApellido2.Size = New System.Drawing.Size(258, 25)
        Me.TXTApellido2.TabIndex = 4
        '
        'TXTApellido1
        '
        Me.TXTApellido1.BackColor = System.Drawing.Color.White
        Me.TXTApellido1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTApellido1.Enabled = False
        Me.TXTApellido1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTApellido1.Location = New System.Drawing.Point(190, 91)
        Me.TXTApellido1.MaxLength = 15
        Me.TXTApellido1.Name = "TXTApellido1"
        Me.TXTApellido1.Size = New System.Drawing.Size(258, 25)
        Me.TXTApellido1.TabIndex = 3
        '
        'TXTNombre2
        '
        Me.TXTNombre2.BackColor = System.Drawing.Color.White
        Me.TXTNombre2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNombre2.Enabled = False
        Me.TXTNombre2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNombre2.Location = New System.Drawing.Point(190, 58)
        Me.TXTNombre2.MaxLength = 30
        Me.TXTNombre2.Name = "TXTNombre2"
        Me.TXTNombre2.Size = New System.Drawing.Size(258, 25)
        Me.TXTNombre2.TabIndex = 2
        '
        'TXTNombre1
        '
        Me.TXTNombre1.BackColor = System.Drawing.Color.White
        Me.TXTNombre1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNombre1.Enabled = False
        Me.TXTNombre1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNombre1.Location = New System.Drawing.Point(190, 26)
        Me.TXTNombre1.MaxLength = 30
        Me.TXTNombre1.Name = "TXTNombre1"
        Me.TXTNombre1.Size = New System.Drawing.Size(258, 25)
        Me.TXTNombre1.TabIndex = 1
        '
        'LBLCargo
        '
        Me.LBLCargo.AutoSize = True
        Me.LBLCargo.BackColor = System.Drawing.Color.Transparent
        Me.LBLCargo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCargo.Location = New System.Drawing.Point(16, 360)
        Me.LBLCargo.Name = "LBLCargo"
        Me.LBLCargo.Size = New System.Drawing.Size(46, 20)
        Me.LBLCargo.TabIndex = 8
        Me.LBLCargo.Text = "Cargo:"
        '
        'LBLSexo
        '
        Me.LBLSexo.AutoSize = True
        Me.LBLSexo.BackColor = System.Drawing.Color.Transparent
        Me.LBLSexo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSexo.Location = New System.Drawing.Point(16, 293)
        Me.LBLSexo.Name = "LBLSexo"
        Me.LBLSexo.Size = New System.Drawing.Size(40, 20)
        Me.LBLSexo.TabIndex = 7
        Me.LBLSexo.Text = "Sexo:"
        '
        'LBLCorreo
        '
        Me.LBLCorreo.AutoSize = True
        Me.LBLCorreo.BackColor = System.Drawing.Color.Transparent
        Me.LBLCorreo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCorreo.Location = New System.Drawing.Point(16, 232)
        Me.LBLCorreo.Name = "LBLCorreo"
        Me.LBLCorreo.Size = New System.Drawing.Size(50, 20)
        Me.LBLCorreo.TabIndex = 6
        Me.LBLCorreo.Text = "Correo:"
        '
        'LBLFecha
        '
        Me.LBLFecha.AutoSize = True
        Me.LBLFecha.BackColor = System.Drawing.Color.Transparent
        Me.LBLFecha.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFecha.Location = New System.Drawing.Point(16, 199)
        Me.LBLFecha.Name = "LBLFecha"
        Me.LBLFecha.Size = New System.Drawing.Size(129, 20)
        Me.LBLFecha.TabIndex = 5
        Me.LBLFecha.Text = "Fecha de Nacimiento:"
        '
        'LBLCI
        '
        Me.LBLCI.AutoSize = True
        Me.LBLCI.BackColor = System.Drawing.Color.Transparent
        Me.LBLCI.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCI.Location = New System.Drawing.Point(16, 165)
        Me.LBLCI.Name = "LBLCI"
        Me.LBLCI.Size = New System.Drawing.Size(30, 20)
        Me.LBLCI.TabIndex = 4
        Me.LBLCI.Text = "C.I :"
        '
        'LBLApellido2
        '
        Me.LBLApellido2.AutoSize = True
        Me.LBLApellido2.BackColor = System.Drawing.Color.Transparent
        Me.LBLApellido2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLApellido2.Location = New System.Drawing.Point(15, 133)
        Me.LBLApellido2.Name = "LBLApellido2"
        Me.LBLApellido2.Size = New System.Drawing.Size(105, 20)
        Me.LBLApellido2.TabIndex = 3
        Me.LBLApellido2.Text = "Apellido Materno:"
        '
        'LBLNombre2
        '
        Me.LBLNombre2.AutoSize = True
        Me.LBLNombre2.BackColor = System.Drawing.Color.Transparent
        Me.LBLNombre2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNombre2.Location = New System.Drawing.Point(16, 66)
        Me.LBLNombre2.Name = "LBLNombre2"
        Me.LBLNombre2.Size = New System.Drawing.Size(109, 20)
        Me.LBLNombre2.TabIndex = 2
        Me.LBLNombre2.Text = "Segundo Nombre:"
        '
        'LBLApellido1
        '
        Me.LBLApellido1.AutoSize = True
        Me.LBLApellido1.BackColor = System.Drawing.Color.Transparent
        Me.LBLApellido1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLApellido1.Location = New System.Drawing.Point(16, 99)
        Me.LBLApellido1.Name = "LBLApellido1"
        Me.LBLApellido1.Size = New System.Drawing.Size(103, 20)
        Me.LBLApellido1.TabIndex = 1
        Me.LBLApellido1.Text = "Apellido Paterno:"
        '
        'LBLNombre1
        '
        Me.LBLNombre1.AutoSize = True
        Me.LBLNombre1.BackColor = System.Drawing.Color.Transparent
        Me.LBLNombre1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNombre1.Location = New System.Drawing.Point(16, 34)
        Me.LBLNombre1.Name = "LBLNombre1"
        Me.LBLNombre1.Size = New System.Drawing.Size(95, 20)
        Me.LBLNombre1.TabIndex = 0
        Me.LBLNombre1.Text = "Primer Nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BTNAgregar)
        Me.GroupBox1.Controls.Add(Me.BTNSalir)
        Me.GroupBox1.Controls.Add(Me.BTNCancelar)
        Me.GroupBox1.Controls.Add(Me.BTNGuardar)
        Me.GroupBox1.Controls.Add(Me.BTNEliminar)
        Me.GroupBox1.Controls.Add(Me.BTNModificar)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(591, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(98, 259)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'BTNAgregar
        '
        Me.BTNAgregar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAgregar.Location = New System.Drawing.Point(13, 14)
        Me.BTNAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNAgregar.Name = "BTNAgregar"
        Me.BTNAgregar.Size = New System.Drawing.Size(74, 33)
        Me.BTNAgregar.TabIndex = 24
        Me.BTNAgregar.Text = "Agregar"
        Me.BTNAgregar.UseVisualStyleBackColor = True
        '
        'BTNSalir
        '
        Me.BTNSalir.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSalir.Location = New System.Drawing.Point(13, 220)
        Me.BTNSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(74, 32)
        Me.BTNSalir.TabIndex = 23
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'TXTFechaNacimiento
        '
        Me.TXTFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTFechaNacimiento.Enabled = False
        Me.TXTFechaNacimiento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFechaNacimiento.Location = New System.Drawing.Point(519, 202)
        Me.TXTFechaNacimiento.Name = "TXTFechaNacimiento"
        Me.TXTFechaNacimiento.Size = New System.Drawing.Size(66, 20)
        Me.TXTFechaNacimiento.TabIndex = 8
        Me.TXTFechaNacimiento.Visible = False
        '
        'TXTCargo
        '
        Me.TXTCargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTCargo.Enabled = False
        Me.TXTCargo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCargo.Location = New System.Drawing.Point(519, 338)
        Me.TXTCargo.Name = "TXTCargo"
        Me.TXTCargo.Size = New System.Drawing.Size(36, 20)
        Me.TXTCargo.TabIndex = 10
        Me.TXTCargo.Visible = False
        '
        'TXTSexo
        '
        Me.TXTSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTSexo.Enabled = False
        Me.TXTSexo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSexo.Location = New System.Drawing.Point(519, 274)
        Me.TXTSexo.Name = "TXTSexo"
        Me.TXTSexo.Size = New System.Drawing.Size(66, 20)
        Me.TXTSexo.TabIndex = 11
        Me.TXTSexo.Visible = False
        '
        'TXTDepartamento
        '
        Me.TXTDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTDepartamento.Enabled = False
        Me.TXTDepartamento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDepartamento.Location = New System.Drawing.Point(519, 304)
        Me.TXTDepartamento.Name = "TXTDepartamento"
        Me.TXTDepartamento.Size = New System.Drawing.Size(36, 20)
        Me.TXTDepartamento.TabIndex = 12
        Me.TXTDepartamento.Visible = False
        '
        'TXTNacionalidad
        '
        Me.TXTNacionalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTNacionalidad.Enabled = False
        Me.TXTNacionalidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNacionalidad.Location = New System.Drawing.Point(519, 171)
        Me.TXTNacionalidad.Name = "TXTNacionalidad"
        Me.TXTNacionalidad.Size = New System.Drawing.Size(36, 20)
        Me.TXTNacionalidad.TabIndex = 13
        Me.TXTNacionalidad.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(10, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "MÓDULO PERSONA"
        '
        'FPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.ClientSize = New System.Drawing.Size(774, 690)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTNacionalidad)
        Me.Controls.Add(Me.TXTDepartamento)
        Me.Controls.Add(Me.TXTSexo)
        Me.Controls.Add(Me.TXTCargo)
        Me.Controls.Add(Me.TXTFechaNacimiento)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBNuevoRegistro)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GBPersona)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO PERSONA"
        Me.GBPersona.ResumeLayout(False)
        CType(Me.DGVPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBNuevoRegistro.ResumeLayout(False)
        Me.GBNuevoRegistro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBPersona As System.Windows.Forms.GroupBox
    Friend WithEvents DGVPersona As System.Windows.Forms.DataGridView
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents BTNModificar As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents GBNuevoRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents LBLCargo As System.Windows.Forms.Label
    Friend WithEvents LBLSexo As System.Windows.Forms.Label
    Friend WithEvents LBLCorreo As System.Windows.Forms.Label
    Friend WithEvents LBLFecha As System.Windows.Forms.Label
    Friend WithEvents LBLCI As System.Windows.Forms.Label
    Friend WithEvents LBLApellido2 As System.Windows.Forms.Label
    Friend WithEvents LBLNombre2 As System.Windows.Forms.Label
    Friend WithEvents LBLApellido1 As System.Windows.Forms.Label
    Friend WithEvents LBLNombre1 As System.Windows.Forms.Label
    Friend WithEvents TXTApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents TXTApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTNombre2 As System.Windows.Forms.TextBox
    Friend WithEvents TXTNombre1 As System.Windows.Forms.TextBox
    Friend WithEvents CMBNacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents TXTCI As System.Windows.Forms.TextBox
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMBCargo As System.Windows.Forms.ComboBox
    Friend WithEvents CMBSexo As System.Windows.Forms.ComboBox
    Friend WithEvents TXTCorreo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As GrupoAcosta.DataSet1
    Friend WithEvents TXTFechaNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents TXTCargo As System.Windows.Forms.TextBox
    Friend WithEvents TXTSexo As System.Windows.Forms.TextBox
    Friend WithEvents CMBDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents LBLDepartamento As System.Windows.Forms.Label
    Friend WithEvents TXTDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents LBValidarCargo As System.Windows.Forms.Label
    Friend WithEvents LBValidarDpto As System.Windows.Forms.Label
    Friend WithEvents LBValidarSexo As System.Windows.Forms.Label
    Friend WithEvents LBValidarFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents LBValidarCi As System.Windows.Forms.Label
    Friend WithEvents LBValidarApellido2 As System.Windows.Forms.Label
    Friend WithEvents LBValidarApellido1 As System.Windows.Forms.Label
    Friend WithEvents LBValidarNombre1 As System.Windows.Forms.Label
    Friend WithEvents LBValidadNacionalidad As System.Windows.Forms.Label
    Friend WithEvents TXTNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents LBCamposObligatoriosAst As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatorios As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNAgregarTelefono As System.Windows.Forms.Button
    Friend WithEvents LVTelefonos As System.Windows.Forms.ListView
    Friend WithEvents TTFPersona As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button

End Class
