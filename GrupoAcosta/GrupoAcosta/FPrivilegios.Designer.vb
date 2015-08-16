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
        Me.LBValidarRoles = New System.Windows.Forms.Label()
        Me.LBCamposObligatoriosAst = New System.Windows.Forms.Label()
        Me.LBCamposObligatorios = New System.Windows.Forms.Label()
        Me.TXTRol = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGVPrivilegios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBAsignacionPrivilegios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVPrivilegios
        '
        Me.DGVPrivilegios.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DGVPrivilegios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPrivilegios.Location = New System.Drawing.Point(12, 15)
        Me.DGVPrivilegios.Name = "DGVPrivilegios"
        Me.DGVPrivilegios.RowHeadersVisible = False
        Me.DGVPrivilegios.Size = New System.Drawing.Size(368, 474)
        Me.DGVPrivilegios.TabIndex = 0
        Me.DGVPrivilegios.TabStop = False
        '
        'BTNGuardar
        '
        Me.BTNGuardar.Location = New System.Drawing.Point(6, 13)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(75, 34)
        Me.BTNGuardar.TabIndex = 2
        Me.BTNGuardar.Text = "Guardar"
        Me.BTNGuardar.UseVisualStyleBackColor = True
        '
        'BTNSalir
        '
        Me.BTNSalir.Location = New System.Drawing.Point(6, 53)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(75, 33)
        Me.BTNSalir.TabIndex = 3
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'CBRol
        '
        Me.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBRol.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBRol.FormattingEnabled = True
        Me.CBRol.Location = New System.Drawing.Point(157, 33)
        Me.CBRol.Name = "CBRol"
        Me.CBRol.Size = New System.Drawing.Size(249, 28)
        Me.CBRol.TabIndex = 1
        '
        'LBRoles
        '
        Me.LBRoles.AutoSize = True
        Me.LBRoles.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBRoles.Location = New System.Drawing.Point(9, 38)
        Me.LBRoles.Name = "LBRoles"
        Me.LBRoles.Size = New System.Drawing.Size(50, 17)
        Me.LBRoles.TabIndex = 6
        Me.LBRoles.Text = "Roles:"
        '
        'GBAsignacionPrivilegios
        '
        Me.GBAsignacionPrivilegios.BackColor = System.Drawing.Color.White
        Me.GBAsignacionPrivilegios.Controls.Add(Me.LBValidarRoles)
        Me.GBAsignacionPrivilegios.Controls.Add(Me.LBCamposObligatoriosAst)
        Me.GBAsignacionPrivilegios.Controls.Add(Me.LBRoles)
        Me.GBAsignacionPrivilegios.Controls.Add(Me.LBCamposObligatorios)
        Me.GBAsignacionPrivilegios.Controls.Add(Me.CBRol)
        Me.GBAsignacionPrivilegios.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBAsignacionPrivilegios.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GBAsignacionPrivilegios.Location = New System.Drawing.Point(12, 70)
        Me.GBAsignacionPrivilegios.Name = "GBAsignacionPrivilegios"
        Me.GBAsignacionPrivilegios.Size = New System.Drawing.Size(446, 91)
        Me.GBAsignacionPrivilegios.TabIndex = 7
        Me.GBAsignacionPrivilegios.TabStop = False
        Me.GBAsignacionPrivilegios.Text = "Asignación de Privilegios"
        '
        'LBValidarRoles
        '
        Me.LBValidarRoles.AutoSize = True
        Me.LBValidarRoles.BackColor = System.Drawing.Color.Transparent
        Me.LBValidarRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBValidarRoles.ForeColor = System.Drawing.Color.Red
        Me.LBValidarRoles.Location = New System.Drawing.Point(420, 33)
        Me.LBValidarRoles.Name = "LBValidarRoles"
        Me.LBValidarRoles.Size = New System.Drawing.Size(14, 18)
        Me.LBValidarRoles.TabIndex = 52
        Me.LBValidarRoles.Text = "*"
        '
        'LBCamposObligatoriosAst
        '
        Me.LBCamposObligatoriosAst.AutoSize = True
        Me.LBCamposObligatoriosAst.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatoriosAst.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.LBCamposObligatoriosAst.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatoriosAst.Location = New System.Drawing.Point(420, 74)
        Me.LBCamposObligatoriosAst.Name = "LBCamposObligatoriosAst"
        Me.LBCamposObligatoriosAst.Size = New System.Drawing.Size(14, 17)
        Me.LBCamposObligatoriosAst.TabIndex = 52
        Me.LBCamposObligatoriosAst.Text = "*"
        '
        'LBCamposObligatorios
        '
        Me.LBCamposObligatorios.AutoSize = True
        Me.LBCamposObligatorios.BackColor = System.Drawing.Color.Transparent
        Me.LBCamposObligatorios.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatorios.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatorios.Location = New System.Drawing.Point(287, 72)
        Me.LBCamposObligatorios.Name = "LBCamposObligatorios"
        Me.LBCamposObligatorios.Size = New System.Drawing.Size(119, 16)
        Me.LBCamposObligatorios.TabIndex = 53
        Me.LBCamposObligatorios.Text = "Campos Obligatorios"
        '
        'TXTRol
        '
        Me.TXTRol.BackColor = System.Drawing.Color.Yellow
        Me.TXTRol.Location = New System.Drawing.Point(467, 104)
        Me.TXTRol.Name = "TXTRol"
        Me.TXTRol.ReadOnly = True
        Me.TXTRol.Size = New System.Drawing.Size(32, 20)
        Me.TXTRol.TabIndex = 7
        Me.TXTRol.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BTNGuardar)
        Me.GroupBox1.Controls.Add(Me.BTNSalir)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(435, 222)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 92)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.DGVPrivilegios)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(389, 499)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "MÓDULO PRIVILEGIOS"
        '
        'FPrivilegios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.ClientSize = New System.Drawing.Size(531, 669)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTRol)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBAsignacionPrivilegios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FPrivilegios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO PRIVILEGIOS"
        CType(Me.DGVPrivilegios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBAsignacionPrivilegios.ResumeLayout(False)
        Me.GBAsignacionPrivilegios.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVPrivilegios As System.Windows.Forms.DataGridView
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents CBRol As System.Windows.Forms.ComboBox
    Friend WithEvents LBRoles As System.Windows.Forms.Label
    Friend WithEvents GBAsignacionPrivilegios As System.Windows.Forms.GroupBox
    Friend WithEvents TXTRol As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatoriosAst As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatorios As System.Windows.Forms.Label
    Friend WithEvents LBValidarRoles As System.Windows.Forms.Label
End Class
