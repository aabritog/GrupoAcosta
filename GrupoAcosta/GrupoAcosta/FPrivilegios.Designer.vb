<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPrivilegios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPrivilegios))
        Me.DGVPrivilegios = New System.Windows.Forms.DataGridView()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.CBRol = New System.Windows.Forms.ComboBox()
        Me.LBRoles = New System.Windows.Forms.Label()
        Me.GBAsignacionPrivilegios = New System.Windows.Forms.GroupBox()
        Me.TBIdrol = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.DGVPrivilegios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBAsignacionPrivilegios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVPrivilegios
        '
        Me.DGVPrivilegios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVPrivilegios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPrivilegios.Location = New System.Drawing.Point(12, 20)
        Me.DGVPrivilegios.Name = "DGVPrivilegios"
        Me.DGVPrivilegios.RowHeadersVisible = False
        Me.DGVPrivilegios.Size = New System.Drawing.Size(368, 474)
        Me.DGVPrivilegios.TabIndex = 0
        Me.DGVPrivilegios.TabStop = False
        '
        'BTNGuardar
        '
        Me.BTNGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNGuardar.Location = New System.Drawing.Point(11, 19)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardar.TabIndex = 2
        Me.BTNGuardar.Text = "Guardar"
        Me.BTNGuardar.UseVisualStyleBackColor = True
        '
        'BTNSalir
        '
        Me.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNSalir.Location = New System.Drawing.Point(11, 48)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(75, 23)
        Me.BTNSalir.TabIndex = 3
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'CBRol
        '
        Me.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBRol.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBRol.FormattingEnabled = True
        Me.CBRol.Location = New System.Drawing.Point(54, 26)
        Me.CBRol.Name = "CBRol"
        Me.CBRol.Size = New System.Drawing.Size(190, 21)
        Me.CBRol.TabIndex = 1
        '
        'LBRoles
        '
        Me.LBRoles.AutoSize = True
        Me.LBRoles.Location = New System.Drawing.Point(15, 31)
        Me.LBRoles.Name = "LBRoles"
        Me.LBRoles.Size = New System.Drawing.Size(37, 13)
        Me.LBRoles.TabIndex = 6
        Me.LBRoles.Text = "Roles:"
        '
        'GBAsignacionPrivilegios
        '
        Me.GBAsignacionPrivilegios.BackColor = System.Drawing.Color.White
        Me.GBAsignacionPrivilegios.Controls.Add(Me.TBIdrol)
        Me.GBAsignacionPrivilegios.Controls.Add(Me.LBRoles)
        Me.GBAsignacionPrivilegios.Controls.Add(Me.CBRol)
        Me.GBAsignacionPrivilegios.Location = New System.Drawing.Point(12, 12)
        Me.GBAsignacionPrivilegios.Name = "GBAsignacionPrivilegios"
        Me.GBAsignacionPrivilegios.Size = New System.Drawing.Size(395, 73)
        Me.GBAsignacionPrivilegios.TabIndex = 7
        Me.GBAsignacionPrivilegios.TabStop = False
        Me.GBAsignacionPrivilegios.Text = "Asignación de privilegios"
        '
        'TBIdrol
        '
        Me.TBIdrol.BackColor = System.Drawing.Color.Yellow
        Me.TBIdrol.Location = New System.Drawing.Point(317, 13)
        Me.TBIdrol.Name = "TBIdrol"
        Me.TBIdrol.ReadOnly = True
        Me.TBIdrol.Size = New System.Drawing.Size(32, 20)
        Me.TBIdrol.TabIndex = 7
        Me.TBIdrol.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BTNGuardar)
        Me.GroupBox1.Controls.Add(Me.BTNSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(413, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(99, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.DGVPrivilegios)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 503)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Privilegios"
        '
        'FPrivilegios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual2
        Me.ClientSize = New System.Drawing.Size(522, 603)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBAsignacionPrivilegios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FPrivilegios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamento de Enfermería - Privilegios en roles"
        CType(Me.DGVPrivilegios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBAsignacionPrivilegios.ResumeLayout(False)
        Me.GBAsignacionPrivilegios.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVPrivilegios As System.Windows.Forms.DataGridView
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents CBRol As System.Windows.Forms.ComboBox
    Friend WithEvents LBRoles As System.Windows.Forms.Label
    Friend WithEvents GBAsignacionPrivilegios As System.Windows.Forms.GroupBox
    Friend WithEvents TBIdrol As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
