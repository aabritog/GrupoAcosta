<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FUsuario))
        Me.GBUsuario = New System.Windows.Forms.GroupBox()
        Me.DGVUsuario = New System.Windows.Forms.DataGridView()
        Me.GBNuevoUsuario = New System.Windows.Forms.GroupBox()
        Me.LBCamposObligatoriosAst = New System.Windows.Forms.Label()
        Me.TXTRol = New System.Windows.Forms.TextBox()
        Me.LBCamposObligatorios = New System.Windows.Forms.Label()
        Me.TXTPersonasNoUsuarios = New System.Windows.Forms.TextBox()
        Me.LBLValidarRol = New System.Windows.Forms.Label()
        Me.LBLValidarConfirmarClave = New System.Windows.Forms.Label()
        Me.LBLValidarClave = New System.Windows.Forms.Label()
        Me.LBLValidarSeudonimo = New System.Windows.Forms.Label()
        Me.LBLPSeleccionada = New System.Windows.Forms.Label()
        Me.LBLNinguno = New System.Windows.Forms.Label()
        Me.BTNPersona = New System.Windows.Forms.Button()
        Me.CMBRol = New System.Windows.Forms.ComboBox()
        Me.TXTClave = New System.Windows.Forms.TextBox()
        Me.TXTConfirmarClave = New System.Windows.Forms.TextBox()
        Me.TXTSeudonimo = New System.Windows.Forms.TextBox()
        Me.LBLROl = New System.Windows.Forms.Label()
        Me.LBLConfirmarCLave = New System.Windows.Forms.Label()
        Me.LBLCLave = New System.Windows.Forms.Label()
        Me.LBLSeudonimo = New System.Windows.Forms.Label()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.BTNModificar = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNNuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBUsuario.SuspendLayout()
        CType(Me.DGVUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBNuevoUsuario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBUsuario
        '
        Me.GBUsuario.BackColor = System.Drawing.Color.White
        Me.GBUsuario.Controls.Add(Me.DGVUsuario)
        Me.GBUsuario.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBUsuario.Location = New System.Drawing.Point(19, 324)
        Me.GBUsuario.Name = "GBUsuario"
        Me.GBUsuario.Size = New System.Drawing.Size(563, 205)
        Me.GBUsuario.TabIndex = 99
        Me.GBUsuario.TabStop = False
        '
        'DGVUsuario
        '
        Me.DGVUsuario.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DGVUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsuario.Location = New System.Drawing.Point(7, 12)
        Me.DGVUsuario.Name = "DGVUsuario"
        Me.DGVUsuario.Size = New System.Drawing.Size(551, 186)
        Me.DGVUsuario.TabIndex = 98
        Me.DGVUsuario.TabStop = False
        '
        'GBNuevoUsuario
        '
        Me.GBNuevoUsuario.BackColor = System.Drawing.Color.White
        Me.GBNuevoUsuario.Controls.Add(Me.LBCamposObligatoriosAst)
        Me.GBNuevoUsuario.Controls.Add(Me.TXTRol)
        Me.GBNuevoUsuario.Controls.Add(Me.LBCamposObligatorios)
        Me.GBNuevoUsuario.Controls.Add(Me.TXTPersonasNoUsuarios)
        Me.GBNuevoUsuario.Controls.Add(Me.LBLValidarRol)
        Me.GBNuevoUsuario.Controls.Add(Me.LBLValidarConfirmarClave)
        Me.GBNuevoUsuario.Controls.Add(Me.LBLValidarClave)
        Me.GBNuevoUsuario.Controls.Add(Me.LBLValidarSeudonimo)
        Me.GBNuevoUsuario.Controls.Add(Me.LBLPSeleccionada)
        Me.GBNuevoUsuario.Controls.Add(Me.LBLNinguno)
        Me.GBNuevoUsuario.Controls.Add(Me.BTNPersona)
        Me.GBNuevoUsuario.Controls.Add(Me.CMBRol)
        Me.GBNuevoUsuario.Controls.Add(Me.TXTClave)
        Me.GBNuevoUsuario.Controls.Add(Me.TXTConfirmarClave)
        Me.GBNuevoUsuario.Controls.Add(Me.TXTSeudonimo)
        Me.GBNuevoUsuario.Controls.Add(Me.LBLROl)
        Me.GBNuevoUsuario.Controls.Add(Me.LBLConfirmarCLave)
        Me.GBNuevoUsuario.Controls.Add(Me.LBLCLave)
        Me.GBNuevoUsuario.Controls.Add(Me.LBLSeudonimo)
        Me.GBNuevoUsuario.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBNuevoUsuario.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GBNuevoUsuario.Location = New System.Drawing.Point(19, 82)
        Me.GBNuevoUsuario.Name = "GBNuevoUsuario"
        Me.GBNuevoUsuario.Size = New System.Drawing.Size(556, 227)
        Me.GBNuevoUsuario.TabIndex = 8
        Me.GBNuevoUsuario.TabStop = False
        Me.GBNuevoUsuario.Text = "Nuevo Usuario"
        '
        'LBCamposObligatoriosAst
        '
        Me.LBCamposObligatoriosAst.AutoSize = True
        Me.LBCamposObligatoriosAst.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatoriosAst.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.LBCamposObligatoriosAst.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatoriosAst.Location = New System.Drawing.Point(417, 207)
        Me.LBCamposObligatoriosAst.Name = "LBCamposObligatoriosAst"
        Me.LBCamposObligatoriosAst.Size = New System.Drawing.Size(14, 17)
        Me.LBCamposObligatoriosAst.TabIndex = 54
        Me.LBCamposObligatoriosAst.Text = "*"
        '
        'TXTRol
        '
        Me.TXTRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTRol.Enabled = False
        Me.TXTRol.Location = New System.Drawing.Point(513, 138)
        Me.TXTRol.Name = "TXTRol"
        Me.TXTRol.Size = New System.Drawing.Size(43, 25)
        Me.TXTRol.TabIndex = 27
        Me.TXTRol.TabStop = False
        Me.TXTRol.Visible = False
        '
        'LBCamposObligatorios
        '
        Me.LBCamposObligatorios.AutoSize = True
        Me.LBCamposObligatorios.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatorios.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatorios.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatorios.Location = New System.Drawing.Point(286, 208)
        Me.LBCamposObligatorios.Name = "LBCamposObligatorios"
        Me.LBCamposObligatorios.Size = New System.Drawing.Size(119, 16)
        Me.LBCamposObligatorios.TabIndex = 55
        Me.LBCamposObligatorios.Text = "Campos Obligatorios"
        '
        'TXTPersonasNoUsuarios
        '
        Me.TXTPersonasNoUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTPersonasNoUsuarios.Enabled = False
        Me.TXTPersonasNoUsuarios.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPersonasNoUsuarios.Location = New System.Drawing.Point(531, 59)
        Me.TXTPersonasNoUsuarios.Name = "TXTPersonasNoUsuarios"
        Me.TXTPersonasNoUsuarios.Size = New System.Drawing.Size(25, 20)
        Me.TXTPersonasNoUsuarios.TabIndex = 26
        Me.TXTPersonasNoUsuarios.TabStop = False
        Me.TXTPersonasNoUsuarios.Visible = False
        '
        'LBLValidarRol
        '
        Me.LBLValidarRol.AutoSize = True
        Me.LBLValidarRol.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarRol.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarRol.Location = New System.Drawing.Point(417, 145)
        Me.LBLValidarRol.Name = "LBLValidarRol"
        Me.LBLValidarRol.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarRol.TabIndex = 23
        Me.LBLValidarRol.Text = "*"
        '
        'LBLValidarConfirmarClave
        '
        Me.LBLValidarConfirmarClave.AutoSize = True
        Me.LBLValidarConfirmarClave.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarConfirmarClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarConfirmarClave.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarConfirmarClave.Location = New System.Drawing.Point(417, 102)
        Me.LBLValidarConfirmarClave.Name = "LBLValidarConfirmarClave"
        Me.LBLValidarConfirmarClave.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarConfirmarClave.TabIndex = 22
        Me.LBLValidarConfirmarClave.Text = "*"
        '
        'LBLValidarClave
        '
        Me.LBLValidarClave.AutoSize = True
        Me.LBLValidarClave.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarClave.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarClave.Location = New System.Drawing.Point(417, 64)
        Me.LBLValidarClave.Name = "LBLValidarClave"
        Me.LBLValidarClave.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarClave.TabIndex = 21
        Me.LBLValidarClave.Text = "*"
        '
        'LBLValidarSeudonimo
        '
        Me.LBLValidarSeudonimo.AutoSize = True
        Me.LBLValidarSeudonimo.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidarSeudonimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarSeudonimo.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarSeudonimo.Location = New System.Drawing.Point(417, 29)
        Me.LBLValidarSeudonimo.Name = "LBLValidarSeudonimo"
        Me.LBLValidarSeudonimo.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarSeudonimo.TabIndex = 20
        Me.LBLValidarSeudonimo.Text = "*"
        '
        'LBLPSeleccionada
        '
        Me.LBLPSeleccionada.AutoSize = True
        Me.LBLPSeleccionada.BackColor = System.Drawing.Color.Transparent
        Me.LBLPSeleccionada.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPSeleccionada.Location = New System.Drawing.Point(14, 203)
        Me.LBLPSeleccionada.Name = "LBLPSeleccionada"
        Me.LBLPSeleccionada.Size = New System.Drawing.Size(146, 20)
        Me.LBLPSeleccionada.TabIndex = 10
        Me.LBLPSeleccionada.Text = "Persona seleccionada:"
        '
        'LBLNinguno
        '
        Me.LBLNinguno.AutoSize = True
        Me.LBLNinguno.BackColor = System.Drawing.Color.Transparent
        Me.LBLNinguno.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNinguno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLNinguno.Location = New System.Drawing.Point(166, 204)
        Me.LBLNinguno.Name = "LBLNinguno"
        Me.LBLNinguno.Size = New System.Drawing.Size(59, 20)
        Me.LBLNinguno.TabIndex = 9
        Me.LBLNinguno.Text = "Ninguna"
        '
        'BTNPersona
        '
        Me.BTNPersona.Enabled = False
        Me.BTNPersona.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPersona.Location = New System.Drawing.Point(439, 28)
        Me.BTNPersona.Name = "BTNPersona"
        Me.BTNPersona.Size = New System.Drawing.Size(117, 25)
        Me.BTNPersona.TabIndex = 5
        Me.BTNPersona.Text = "Persona (ir) >>"
        Me.BTNPersona.UseVisualStyleBackColor = True
        '
        'CMBRol
        '
        Me.CMBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBRol.Enabled = False
        Me.CMBRol.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBRol.FormattingEnabled = True
        Me.CMBRol.Location = New System.Drawing.Point(137, 141)
        Me.CMBRol.Name = "CMBRol"
        Me.CMBRol.Size = New System.Drawing.Size(274, 24)
        Me.CMBRol.TabIndex = 4
        '
        'TXTClave
        '
        Me.TXTClave.BackColor = System.Drawing.Color.White
        Me.TXTClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTClave.Enabled = False
        Me.TXTClave.Location = New System.Drawing.Point(137, 64)
        Me.TXTClave.MaxLength = 32
        Me.TXTClave.Name = "TXTClave"
        Me.TXTClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTClave.Size = New System.Drawing.Size(274, 25)
        Me.TXTClave.TabIndex = 2
        Me.TXTClave.UseSystemPasswordChar = True
        '
        'TXTConfirmarClave
        '
        Me.TXTConfirmarClave.BackColor = System.Drawing.Color.White
        Me.TXTConfirmarClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTConfirmarClave.Enabled = False
        Me.TXTConfirmarClave.Location = New System.Drawing.Point(137, 102)
        Me.TXTConfirmarClave.MaxLength = 32
        Me.TXTConfirmarClave.Name = "TXTConfirmarClave"
        Me.TXTConfirmarClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTConfirmarClave.Size = New System.Drawing.Size(274, 25)
        Me.TXTConfirmarClave.TabIndex = 3
        Me.TXTConfirmarClave.UseSystemPasswordChar = True
        '
        'TXTSeudonimo
        '
        Me.TXTSeudonimo.BackColor = System.Drawing.Color.White
        Me.TXTSeudonimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTSeudonimo.Enabled = False
        Me.TXTSeudonimo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSeudonimo.Location = New System.Drawing.Point(134, 29)
        Me.TXTSeudonimo.MaxLength = 10
        Me.TXTSeudonimo.Name = "TXTSeudonimo"
        Me.TXTSeudonimo.Size = New System.Drawing.Size(277, 25)
        Me.TXTSeudonimo.TabIndex = 1
        '
        'LBLROl
        '
        Me.LBLROl.AutoSize = True
        Me.LBLROl.BackColor = System.Drawing.Color.Transparent
        Me.LBLROl.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLROl.Location = New System.Drawing.Point(14, 145)
        Me.LBLROl.Name = "LBLROl"
        Me.LBLROl.Size = New System.Drawing.Size(31, 20)
        Me.LBLROl.TabIndex = 3
        Me.LBLROl.Text = "Rol:"
        '
        'LBLConfirmarCLave
        '
        Me.LBLConfirmarCLave.AutoSize = True
        Me.LBLConfirmarCLave.BackColor = System.Drawing.Color.Transparent
        Me.LBLConfirmarCLave.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLConfirmarCLave.Location = New System.Drawing.Point(14, 104)
        Me.LBLConfirmarCLave.Name = "LBLConfirmarCLave"
        Me.LBLConfirmarCLave.Size = New System.Drawing.Size(99, 20)
        Me.LBLConfirmarCLave.TabIndex = 2
        Me.LBLConfirmarCLave.Text = "Confirmar clave:"
        '
        'LBLCLave
        '
        Me.LBLCLave.AutoSize = True
        Me.LBLCLave.BackColor = System.Drawing.Color.Transparent
        Me.LBLCLave.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCLave.Location = New System.Drawing.Point(14, 69)
        Me.LBLCLave.Name = "LBLCLave"
        Me.LBLCLave.Size = New System.Drawing.Size(43, 20)
        Me.LBLCLave.TabIndex = 1
        Me.LBLCLave.Text = "Clave:"
        '
        'LBLSeudonimo
        '
        Me.LBLSeudonimo.AutoSize = True
        Me.LBLSeudonimo.BackColor = System.Drawing.Color.Transparent
        Me.LBLSeudonimo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSeudonimo.Location = New System.Drawing.Point(14, 32)
        Me.LBLSeudonimo.Name = "LBLSeudonimo"
        Me.LBLSeudonimo.Size = New System.Drawing.Size(76, 20)
        Me.LBLSeudonimo.TabIndex = 0
        Me.LBLSeudonimo.Text = "Seudonimo:"
        '
        'TXTBuscar
        '
        Me.TXTBuscar.BackColor = System.Drawing.Color.White
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Enabled = False
        Me.TXTBuscar.Location = New System.Drawing.Point(591, 214)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(223, 20)
        Me.TXTBuscar.TabIndex = 5
        '
        'LBLBuscar
        '
        Me.LBLBuscar.AutoSize = True
        Me.LBLBuscar.BackColor = System.Drawing.Color.Transparent
        Me.LBLBuscar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBuscar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLBuscar.Location = New System.Drawing.Point(616, 191)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(196, 20)
        Me.LBLBuscar.TabIndex = 10
        Me.LBLBuscar.Text = "Buscar(Nombre, ó Seudonimo)"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BTNSalir)
        Me.GroupBox1.Controls.Add(Me.BTNCancelar)
        Me.GroupBox1.Controls.Add(Me.BTNEliminar)
        Me.GroupBox1.Controls.Add(Me.BTNModificar)
        Me.GroupBox1.Controls.Add(Me.BTNGuardar)
        Me.GroupBox1.Controls.Add(Me.BTNNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(658, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(86, 215)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'BTNSalir
        '
        Me.BTNSalir.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSalir.Location = New System.Drawing.Point(6, 182)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(75, 27)
        Me.BTNSalir.TabIndex = 11
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCancelar.Location = New System.Drawing.Point(6, 147)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(75, 29)
        Me.BTNCancelar.TabIndex = 10
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Enabled = False
        Me.BTNEliminar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEliminar.Location = New System.Drawing.Point(6, 114)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(75, 27)
        Me.BTNEliminar.TabIndex = 9
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'BTNModificar
        '
        Me.BTNModificar.Enabled = False
        Me.BTNModificar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNModificar.Location = New System.Drawing.Point(6, 80)
        Me.BTNModificar.Name = "BTNModificar"
        Me.BTNModificar.Size = New System.Drawing.Size(75, 28)
        Me.BTNModificar.TabIndex = 7
        Me.BTNModificar.Text = "Modificar"
        Me.BTNModificar.UseVisualStyleBackColor = True
        '
        'BTNGuardar
        '
        Me.BTNGuardar.Enabled = False
        Me.BTNGuardar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGuardar.Location = New System.Drawing.Point(6, 47)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(75, 27)
        Me.BTNGuardar.TabIndex = 7
        Me.BTNGuardar.Text = "Guardar"
        Me.BTNGuardar.UseVisualStyleBackColor = True
        '
        'BTNNuevo
        '
        Me.BTNNuevo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNuevo.Location = New System.Drawing.Point(6, 16)
        Me.BTNNuevo.Name = "BTNNuevo"
        Me.BTNNuevo.Size = New System.Drawing.Size(75, 25)
        Me.BTNNuevo.TabIndex = 6
        Me.BTNNuevo.Text = "Nuevo"
        Me.BTNNuevo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(15, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "MÓDULO USUARIO"
        '
        'FUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.ClientSize = New System.Drawing.Size(821, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GBNuevoUsuario)
        Me.Controls.Add(Me.GBUsuario)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO USUARIO"
        Me.GBUsuario.ResumeLayout(False)
        CType(Me.DGVUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBNuevoUsuario.ResumeLayout(False)
        Me.GBNuevoUsuario.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents DGVUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents GBNuevoUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents LBLROl As System.Windows.Forms.Label
    Friend WithEvents LBLConfirmarCLave As System.Windows.Forms.Label
    Friend WithEvents LBLCLave As System.Windows.Forms.Label
    Friend WithEvents LBLSeudonimo As System.Windows.Forms.Label
    Friend WithEvents BTNPersona As System.Windows.Forms.Button
    Friend WithEvents CMBRol As System.Windows.Forms.ComboBox
    Friend WithEvents TXTClave As System.Windows.Forms.TextBox
    Friend WithEvents TXTConfirmarClave As System.Windows.Forms.TextBox
    Friend WithEvents TXTSeudonimo As System.Windows.Forms.TextBox
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents BTNModificar As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNNuevo As System.Windows.Forms.Button
    Friend WithEvents LBLPSeleccionada As System.Windows.Forms.Label
    Friend WithEvents LBLNinguno As System.Windows.Forms.Label
    Friend WithEvents LBLValidarSeudonimo As System.Windows.Forms.Label
    Friend WithEvents LBLValidarRol As System.Windows.Forms.Label
    Friend WithEvents LBLValidarConfirmarClave As System.Windows.Forms.Label
    Friend WithEvents LBLValidarClave As System.Windows.Forms.Label
    Friend WithEvents TXTPersonasNoUsuarios As System.Windows.Forms.TextBox
    Friend WithEvents TXTRol As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatoriosAst As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatorios As System.Windows.Forms.Label



End Class
