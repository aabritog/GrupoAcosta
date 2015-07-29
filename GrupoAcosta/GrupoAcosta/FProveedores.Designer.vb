<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProveedores
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
        Me.LBLValidarDescripcioncorta = New System.Windows.Forms.Label()
        Me.LBCamposObligatorios = New System.Windows.Forms.Label()
        Me.LVTelefono = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNAgregarTelefono = New System.Windows.Forms.Button()
        Me.LBLValidarRif = New System.Windows.Forms.Label()
        Me.LBLValidarDireccion = New System.Windows.Forms.Label()
        Me.TXTDireccion = New System.Windows.Forms.TextBox()
        Me.TXTRif = New System.Windows.Forms.TextBox()
        Me.LBLDireccion = New System.Windows.Forms.Label()
        Me.LBLRif = New System.Windows.Forms.Label()
        Me.LBLValidarDescripcion = New System.Windows.Forms.Label()
        Me.TXTDescripcionCorta = New System.Windows.Forms.TextBox()
        Me.TXTDescripcion = New System.Windows.Forms.TextBox()
        Me.LBLDescripcionCorta = New System.Windows.Forms.Label()
        Me.LBLDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNModificar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.GBDRol = New System.Windows.Forms.GroupBox()
        Me.DGVProveedores = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GBDRol.SuspendLayout()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.GroupBox1.Controls.Add(Me.LBCamposObligatoriosAst)
        Me.GroupBox1.Controls.Add(Me.LBLValidarDescripcioncorta)
        Me.GroupBox1.Controls.Add(Me.LBCamposObligatorios)
        Me.GroupBox1.Controls.Add(Me.LVTelefono)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BTNAgregarTelefono)
        Me.GroupBox1.Controls.Add(Me.LBLValidarRif)
        Me.GroupBox1.Controls.Add(Me.LBLValidarDireccion)
        Me.GroupBox1.Controls.Add(Me.TXTDireccion)
        Me.GroupBox1.Controls.Add(Me.TXTRif)
        Me.GroupBox1.Controls.Add(Me.LBLDireccion)
        Me.GroupBox1.Controls.Add(Me.LBLRif)
        Me.GroupBox1.Controls.Add(Me.LBLValidarDescripcion)
        Me.GroupBox1.Controls.Add(Me.TXTDescripcionCorta)
        Me.GroupBox1.Controls.Add(Me.TXTDescripcion)
        Me.GroupBox1.Controls.Add(Me.LBLDescripcionCorta)
        Me.GroupBox1.Controls.Add(Me.LBLDescripcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 245)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Proveedor"
        '
        'LBCamposObligatoriosAst
        '
        Me.LBCamposObligatoriosAst.AutoSize = True
        Me.LBCamposObligatoriosAst.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBCamposObligatoriosAst.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatoriosAst.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatoriosAst.Location = New System.Drawing.Point(470, 220)
        Me.LBCamposObligatoriosAst.Name = "LBCamposObligatoriosAst"
        Me.LBCamposObligatoriosAst.Size = New System.Drawing.Size(12, 15)
        Me.LBCamposObligatoriosAst.TabIndex = 46
        Me.LBCamposObligatoriosAst.Text = "*"
        '
        'LBLValidarDescripcioncorta
        '
        Me.LBLValidarDescripcioncorta.AutoSize = True
        Me.LBLValidarDescripcioncorta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLValidarDescripcioncorta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarDescripcioncorta.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarDescripcioncorta.Location = New System.Drawing.Point(469, 59)
        Me.LBLValidarDescripcioncorta.Name = "LBLValidarDescripcioncorta"
        Me.LBLValidarDescripcioncorta.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarDescripcioncorta.TabIndex = 40
        Me.LBLValidarDescripcioncorta.Text = "*"
        '
        'LBCamposObligatorios
        '
        Me.LBCamposObligatorios.AutoSize = True
        Me.LBCamposObligatorios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBCamposObligatorios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatorios.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatorios.Location = New System.Drawing.Point(337, 220)
        Me.LBCamposObligatorios.Name = "LBCamposObligatorios"
        Me.LBCamposObligatorios.Size = New System.Drawing.Size(125, 15)
        Me.LBCamposObligatorios.TabIndex = 45
        Me.LBCamposObligatorios.Text = "Campos Obligatorios"
        '
        'LVTelefono
        '
        Me.LVTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LVTelefono.Location = New System.Drawing.Point(281, 173)
        Me.LVTelefono.Name = "LVTelefono"
        Me.LVTelefono.Size = New System.Drawing.Size(150, 28)
        Me.LVTelefono.TabIndex = 38
        Me.LVTelefono.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Telefono:"
        '
        'BTNAgregarTelefono
        '
        Me.BTNAgregarTelefono.Enabled = False
        Me.BTNAgregarTelefono.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAgregarTelefono.Location = New System.Drawing.Point(185, 173)
        Me.BTNAgregarTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNAgregarTelefono.Name = "BTNAgregarTelefono"
        Me.BTNAgregarTelefono.Size = New System.Drawing.Size(74, 24)
        Me.BTNAgregarTelefono.TabIndex = 36
        Me.BTNAgregarTelefono.Text = "Agregar >>"
        Me.BTNAgregarTelefono.UseVisualStyleBackColor = True
        '
        'LBLValidarRif
        '
        Me.LBLValidarRif.AutoSize = True
        Me.LBLValidarRif.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLValidarRif.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarRif.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarRif.Location = New System.Drawing.Point(469, 94)
        Me.LBLValidarRif.Name = "LBLValidarRif"
        Me.LBLValidarRif.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarRif.TabIndex = 34
        Me.LBLValidarRif.Text = "*"
        '
        'LBLValidarDireccion
        '
        Me.LBLValidarDireccion.AutoSize = True
        Me.LBLValidarDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLValidarDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarDireccion.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarDireccion.Location = New System.Drawing.Point(469, 133)
        Me.LBLValidarDireccion.Name = "LBLValidarDireccion"
        Me.LBLValidarDireccion.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarDireccion.TabIndex = 33
        Me.LBLValidarDireccion.Text = "*"
        '
        'TXTDireccion
        '
        Me.TXTDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDireccion.Enabled = False
        Me.TXTDireccion.Location = New System.Drawing.Point(185, 133)
        Me.TXTDireccion.MaxLength = 30
        Me.TXTDireccion.Name = "TXTDireccion"
        Me.TXTDireccion.Size = New System.Drawing.Size(246, 25)
        Me.TXTDireccion.TabIndex = 32
        '
        'TXTRif
        '
        Me.TXTRif.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTRif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTRif.Enabled = False
        Me.TXTRif.Location = New System.Drawing.Point(185, 94)
        Me.TXTRif.MaxLength = 30
        Me.TXTRif.Name = "TXTRif"
        Me.TXTRif.Size = New System.Drawing.Size(246, 25)
        Me.TXTRif.TabIndex = 31
        '
        'LBLDireccion
        '
        Me.LBLDireccion.AutoSize = True
        Me.LBLDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLDireccion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDireccion.Location = New System.Drawing.Point(15, 138)
        Me.LBLDireccion.Name = "LBLDireccion"
        Me.LBLDireccion.Size = New System.Drawing.Size(64, 20)
        Me.LBLDireccion.TabIndex = 30
        Me.LBLDireccion.Text = "Direccion:"
        '
        'LBLRif
        '
        Me.LBLRif.AutoSize = True
        Me.LBLRif.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLRif.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRif.Location = New System.Drawing.Point(15, 99)
        Me.LBLRif.Name = "LBLRif"
        Me.LBLRif.Size = New System.Drawing.Size(27, 20)
        Me.LBLRif.TabIndex = 29
        Me.LBLRif.Text = "Rif:"
        '
        'LBLValidarDescripcion
        '
        Me.LBLValidarDescripcion.AutoSize = True
        Me.LBLValidarDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLValidarDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarDescripcion.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarDescripcion.Location = New System.Drawing.Point(469, 24)
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
        Me.TXTDescripcionCorta.Size = New System.Drawing.Size(246, 25)
        Me.TXTDescripcionCorta.TabIndex = 6
        '
        'TXTDescripcion
        '
        Me.TXTDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDescripcion.Enabled = False
        Me.TXTDescripcion.Location = New System.Drawing.Point(185, 24)
        Me.TXTDescripcion.MaxLength = 30
        Me.TXTDescripcion.Name = "TXTDescripcion"
        Me.TXTDescripcion.Size = New System.Drawing.Size(246, 25)
        Me.TXTDescripcion.TabIndex = 5
        '
        'LBLDescripcionCorta
        '
        Me.LBLDescripcionCorta.AutoSize = True
        Me.LBLDescripcionCorta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLDescripcionCorta.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDescripcionCorta.Location = New System.Drawing.Point(15, 64)
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual2
        Me.GroupBox3.Controls.Add(Me.BTNAgregar)
        Me.GroupBox3.Controls.Add(Me.BTNSalir)
        Me.GroupBox3.Controls.Add(Me.BTNGuardar)
        Me.GroupBox3.Controls.Add(Me.BTNCancelar)
        Me.GroupBox3.Controls.Add(Me.BTNModificar)
        Me.GroupBox3.Controls.Add(Me.BTNEliminar)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(622, 221)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(86, 254)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
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
        Me.LBLBuscar.Location = New System.Drawing.Point(609, 153)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(123, 20)
        Me.LBLBuscar.TabIndex = 34
        Me.LBLBuscar.Text = "Buscar (Descripcion)"
        '
        'TXTBuscar
        '
        Me.TXTBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(550, 176)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(227, 20)
        Me.TXTBuscar.TabIndex = 33
        '
        'GBDRol
        '
        Me.GBDRol.BackColor = System.Drawing.Color.DarkKhaki
        Me.GBDRol.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.GBDRol.Controls.Add(Me.DGVProveedores)
        Me.GBDRol.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDRol.Location = New System.Drawing.Point(16, 273)
        Me.GBDRol.Name = "GBDRol"
        Me.GBDRol.Size = New System.Drawing.Size(528, 215)
        Me.GBDRol.TabIndex = 35
        Me.GBDRol.TabStop = False
        Me.GBDRol.Text = "Roles en el Sistema"
        '
        'DGVProveedores
        '
        Me.DGVProveedores.BackgroundColor = System.Drawing.Color.Olive
        Me.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProveedores.Location = New System.Drawing.Point(6, 21)
        Me.DGVProveedores.Name = "DGVProveedores"
        Me.DGVProveedores.Size = New System.Drawing.Size(516, 181)
        Me.DGVProveedores.TabIndex = 23
        '
        'FProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual1
        Me.ClientSize = New System.Drawing.Size(779, 491)
        Me.Controls.Add(Me.GBDRol)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO PROVEEDORES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GBDRol.ResumeLayout(False)
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLValidarDescripcion As System.Windows.Forms.Label
    Friend WithEvents TXTDescripcionCorta As System.Windows.Forms.TextBox
    Friend WithEvents TXTDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents LBLDescripcionCorta As System.Windows.Forms.Label
    Friend WithEvents LBLDescripcion As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNModificar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GBDRol As System.Windows.Forms.GroupBox
    Friend WithEvents DGVProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents TXTDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TXTRif As System.Windows.Forms.TextBox
    Friend WithEvents LBLDireccion As System.Windows.Forms.Label
    Friend WithEvents LBLRif As System.Windows.Forms.Label
    Friend WithEvents LBLValidarRif As System.Windows.Forms.Label
    Friend WithEvents LBLValidarDireccion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNAgregarTelefono As System.Windows.Forms.Button
    Friend WithEvents LVTelefono As System.Windows.Forms.ListView
    Friend WithEvents LBLValidarDescripcioncorta As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatoriosAst As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatorios As System.Windows.Forms.Label
End Class
