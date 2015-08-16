<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRoles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRoles))
        Me.TBNuevoRol = New System.Windows.Forms.TextBox()
        Me.BTNCrearRol = New System.Windows.Forms.Button()
        Me.DGVRoles = New System.Windows.Forms.DataGridView()
        Me.GBRoles = New System.Windows.Forms.GroupBox()
        Me.LBValidarNuevoRol = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.LNNombreAtencion = New System.Windows.Forms.Label()
        Me.LBCamposObligatoriosAst = New System.Windows.Forms.Label()
        Me.LBCamposObligatorios = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBRoles.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBNuevoRol
        '
        Me.TBNuevoRol.BackColor = System.Drawing.Color.White
        Me.TBNuevoRol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNuevoRol.Location = New System.Drawing.Point(132, 33)
        Me.TBNuevoRol.Name = "TBNuevoRol"
        Me.TBNuevoRol.Size = New System.Drawing.Size(245, 25)
        Me.TBNuevoRol.TabIndex = 1
        '
        'BTNCrearRol
        '
        Me.BTNCrearRol.Location = New System.Drawing.Point(10, 15)
        Me.BTNCrearRol.Name = "BTNCrearRol"
        Me.BTNCrearRol.Size = New System.Drawing.Size(75, 29)
        Me.BTNCrearRol.TabIndex = 2
        Me.BTNCrearRol.Text = "Crear"
        Me.BTNCrearRol.UseVisualStyleBackColor = True
        '
        'DGVRoles
        '
        Me.DGVRoles.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DGVRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRoles.Location = New System.Drawing.Point(9, 16)
        Me.DGVRoles.Name = "DGVRoles"
        Me.DGVRoles.RowHeadersVisible = False
        Me.DGVRoles.ShowCellToolTips = False
        Me.DGVRoles.Size = New System.Drawing.Size(293, 228)
        Me.DGVRoles.TabIndex = 2
        Me.DGVRoles.TabStop = False
        '
        'GBRoles
        '
        Me.GBRoles.BackColor = System.Drawing.Color.White
        Me.GBRoles.Controls.Add(Me.LBCamposObligatoriosAst)
        Me.GBRoles.Controls.Add(Me.Label1)
        Me.GBRoles.Controls.Add(Me.LBCamposObligatorios)
        Me.GBRoles.Controls.Add(Me.LBValidarNuevoRol)
        Me.GBRoles.Controls.Add(Me.TBNuevoRol)
        Me.GBRoles.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBRoles.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GBRoles.Location = New System.Drawing.Point(12, 68)
        Me.GBRoles.Name = "GBRoles"
        Me.GBRoles.Size = New System.Drawing.Size(430, 93)
        Me.GBRoles.TabIndex = 3
        Me.GBRoles.TabStop = False
        Me.GBRoles.Text = "Nuevo Rol:"
        '
        'LBValidarNuevoRol
        '
        Me.LBValidarNuevoRol.AutoSize = True
        Me.LBValidarNuevoRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarNuevoRol.ForeColor = System.Drawing.Color.Red
        Me.LBValidarNuevoRol.Location = New System.Drawing.Point(383, 33)
        Me.LBValidarNuevoRol.Name = "LBValidarNuevoRol"
        Me.LBValidarNuevoRol.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarNuevoRol.TabIndex = 19
        Me.LBValidarNuevoRol.Text = "*"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.DGVRoles)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 252)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BTNEliminar)
        Me.GroupBox2.Controls.Add(Me.BTNSalir)
        Me.GroupBox2.Controls.Add(Me.BTNCrearRol)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(346, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 120)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Enabled = False
        Me.BTNEliminar.Location = New System.Drawing.Point(10, 50)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(75, 29)
        Me.BTNEliminar.TabIndex = 4
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'BTNSalir
        '
        Me.BTNSalir.Location = New System.Drawing.Point(10, 85)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(75, 29)
        Me.BTNSalir.TabIndex = 3
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'LNNombreAtencion
        '
        Me.LNNombreAtencion.AutoSize = True
        Me.LNNombreAtencion.BackColor = System.Drawing.Color.White
        Me.LNNombreAtencion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNNombreAtencion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LNNombreAtencion.Location = New System.Drawing.Point(12, 25)
        Me.LNNombreAtencion.Name = "LNNombreAtencion"
        Me.LNNombreAtencion.Size = New System.Drawing.Size(111, 20)
        Me.LNNombreAtencion.TabIndex = 95
        Me.LNNombreAtencion.Text = "MÓDULO ROLES"
        '
        'LBCamposObligatoriosAst
        '
        Me.LBCamposObligatoriosAst.AutoSize = True
        Me.LBCamposObligatoriosAst.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatoriosAst.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.LBCamposObligatoriosAst.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatoriosAst.Location = New System.Drawing.Point(383, 73)
        Me.LBCamposObligatoriosAst.Name = "LBCamposObligatoriosAst"
        Me.LBCamposObligatoriosAst.Size = New System.Drawing.Size(14, 17)
        Me.LBCamposObligatoriosAst.TabIndex = 97
        Me.LBCamposObligatoriosAst.Text = "*"
        '
        'LBCamposObligatorios
        '
        Me.LBCamposObligatorios.AutoSize = True
        Me.LBCamposObligatorios.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatorios.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatorios.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatorios.Location = New System.Drawing.Point(258, 74)
        Me.LBCamposObligatorios.Name = "LBCamposObligatorios"
        Me.LBCamposObligatorios.Size = New System.Drawing.Size(119, 16)
        Me.LBCamposObligatorios.TabIndex = 96
        Me.LBCamposObligatorios.Text = "Campos Obligatorios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nombre:"
        '
        'FRoles
        '
        Me.AcceptButton = Me.BTNCrearRol
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.ClientSize = New System.Drawing.Size(445, 438)
        Me.Controls.Add(Me.LNNombreAtencion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBRoles)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRoles"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO ROLES"
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBRoles.ResumeLayout(False)
        Me.GBRoles.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBNuevoRol As System.Windows.Forms.TextBox
    Friend WithEvents BTNCrearRol As System.Windows.Forms.Button
    Friend WithEvents DGVRoles As System.Windows.Forms.DataGridView
    Friend WithEvents GBRoles As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBValidarNuevoRol As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents LNNombreAtencion As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatoriosAst As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatorios As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
