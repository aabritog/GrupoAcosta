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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.LNNombreAtencion = New System.Windows.Forms.Label()
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBRoles.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBNuevoRol
        '
        Me.TBNuevoRol.BackColor = System.Drawing.Color.Beige
        Me.TBNuevoRol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNuevoRol.Location = New System.Drawing.Point(11, 24)
        Me.TBNuevoRol.Name = "TBNuevoRol"
        Me.TBNuevoRol.Size = New System.Drawing.Size(245, 20)
        Me.TBNuevoRol.TabIndex = 1
        '
        'BTNCrearRol
        '
        Me.BTNCrearRol.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNCrearRol.Location = New System.Drawing.Point(10, 21)
        Me.BTNCrearRol.Name = "BTNCrearRol"
        Me.BTNCrearRol.Size = New System.Drawing.Size(75, 23)
        Me.BTNCrearRol.TabIndex = 2
        Me.BTNCrearRol.Text = "Crear"
        Me.BTNCrearRol.UseVisualStyleBackColor = True
        '
        'DGVRoles
        '
        Me.DGVRoles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRoles.Location = New System.Drawing.Point(10, 21)
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
        Me.GBRoles.Controls.Add(Me.LBValidarNuevoRol)
        Me.GBRoles.Controls.Add(Me.TBNuevoRol)
        Me.GBRoles.Location = New System.Drawing.Point(12, 68)
        Me.GBRoles.Name = "GBRoles"
        Me.GBRoles.Size = New System.Drawing.Size(317, 55)
        Me.GBRoles.TabIndex = 3
        Me.GBRoles.TabStop = False
        Me.GBRoles.Text = "Nuevo Rol:"
        '
        'LBValidarNuevoRol
        '
        Me.LBValidarNuevoRol.AutoSize = True
        Me.LBValidarNuevoRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarNuevoRol.ForeColor = System.Drawing.Color.Red
        Me.LBValidarNuevoRol.Location = New System.Drawing.Point(262, 26)
        Me.LBValidarNuevoRol.Name = "LBValidarNuevoRol"
        Me.LBValidarNuevoRol.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarNuevoRol.TabIndex = 19
        Me.LBValidarNuevoRol.Text = "*"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.DGVRoles)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 261)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Roles en sistema:"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 396)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(317, 31)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(108, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(7, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Campos Obligatorios"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BTNEliminar)
        Me.GroupBox2.Controls.Add(Me.BTNSalir)
        Me.GroupBox2.Controls.Add(Me.BTNCrearRol)
        Me.GroupBox2.Location = New System.Drawing.Point(338, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 126)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Enabled = False
        Me.BTNEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNEliminar.Location = New System.Drawing.Point(10, 50)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminar.TabIndex = 4
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'BTNSalir
        '
        Me.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNSalir.Location = New System.Drawing.Point(10, 79)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(75, 23)
        Me.BTNSalir.TabIndex = 3
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'LNNombreAtencion
        '
        Me.LNNombreAtencion.AutoSize = True
        Me.LNNombreAtencion.BackColor = System.Drawing.Color.White
        Me.LNNombreAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNNombreAtencion.ForeColor = System.Drawing.Color.Navy
        Me.LNNombreAtencion.Location = New System.Drawing.Point(12, 25)
        Me.LNNombreAtencion.Name = "LNNombreAtencion"
        Me.LNNombreAtencion.Size = New System.Drawing.Size(115, 20)
        Me.LNNombreAtencion.TabIndex = 95
        Me.LNNombreAtencion.Text = "MENÚ ROLES"
        '
        'FRoles
        '
        Me.AcceptButton = Me.BTNCrearRol
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual2
        Me.ClientSize = New System.Drawing.Size(448, 438)
        Me.Controls.Add(Me.LNNombreAtencion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBRoles)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRoles"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamento de Enfermería - Ménu Roles"
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBRoles.ResumeLayout(False)
        Me.GBRoles.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBNuevoRol As System.Windows.Forms.TextBox
    Friend WithEvents BTNCrearRol As System.Windows.Forms.Button
    Friend WithEvents DGVRoles As System.Windows.Forms.DataGridView
    Friend WithEvents GBRoles As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LBValidarNuevoRol As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents LNNombreAtencion As System.Windows.Forms.Label
End Class
