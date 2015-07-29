<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FIngreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FIngreso))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNAcceder = New System.Windows.Forms.Button()
        Me.TBAlias = New System.Windows.Forms.TextBox()
        Me.TBClave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBIniciarSesion = New System.Windows.Forms.GroupBox()
        Me.CBAlias = New System.Windows.Forms.ComboBox()
        Me.LBClaveObligatorio = New System.Windows.Forms.Label()
        Me.LBAliasObligatorio = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GBIniciarSesion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alias:"
        '
        'BTNAcceder
        '
        Me.BTNAcceder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNAcceder.Location = New System.Drawing.Point(7, 19)
        Me.BTNAcceder.Name = "BTNAcceder"
        Me.BTNAcceder.Size = New System.Drawing.Size(75, 23)
        Me.BTNAcceder.TabIndex = 3
        Me.BTNAcceder.Text = "Acceder"
        Me.BTNAcceder.UseVisualStyleBackColor = True
        '
        'TBAlias
        '
        Me.TBAlias.BackColor = System.Drawing.Color.Yellow
        Me.TBAlias.Location = New System.Drawing.Point(255, 27)
        Me.TBAlias.MaxLength = 30
        Me.TBAlias.Name = "TBAlias"
        Me.TBAlias.Size = New System.Drawing.Size(33, 20)
        Me.TBAlias.TabIndex = 1
        Me.TBAlias.TabStop = False
        Me.TBAlias.Visible = False
        '
        'TBClave
        '
        Me.TBClave.BackColor = System.Drawing.Color.Beige
        Me.TBClave.Location = New System.Drawing.Point(57, 66)
        Me.TBClave.MaxLength = 12
        Me.TBClave.Name = "TBClave"
        Me.TBClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBClave.Size = New System.Drawing.Size(175, 20)
        Me.TBClave.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Clave:"
        '
        'GBIniciarSesion
        '
        Me.GBIniciarSesion.BackColor = System.Drawing.Color.Transparent
        Me.GBIniciarSesion.Controls.Add(Me.CBAlias)
        Me.GBIniciarSesion.Controls.Add(Me.LBClaveObligatorio)
        Me.GBIniciarSesion.Controls.Add(Me.LBAliasObligatorio)
        Me.GBIniciarSesion.Controls.Add(Me.Label1)
        Me.GBIniciarSesion.Controls.Add(Me.Label2)
        Me.GBIniciarSesion.Controls.Add(Me.TBAlias)
        Me.GBIniciarSesion.Controls.Add(Me.TBClave)
        Me.GBIniciarSesion.Location = New System.Drawing.Point(12, 68)
        Me.GBIniciarSesion.Name = "GBIniciarSesion"
        Me.GBIniciarSesion.Size = New System.Drawing.Size(315, 102)
        Me.GBIniciarSesion.TabIndex = 1
        Me.GBIniciarSesion.TabStop = False
        Me.GBIniciarSesion.Text = "Iniciar Sesión:"
        '
        'CBAlias
        '
        Me.CBAlias.BackColor = System.Drawing.Color.Beige
        Me.CBAlias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAlias.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBAlias.FormattingEnabled = True
        Me.CBAlias.Location = New System.Drawing.Point(57, 27)
        Me.CBAlias.Name = "CBAlias"
        Me.CBAlias.Size = New System.Drawing.Size(175, 21)
        Me.CBAlias.TabIndex = 1
        '
        'LBClaveObligatorio
        '
        Me.LBClaveObligatorio.AutoSize = True
        Me.LBClaveObligatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBClaveObligatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBClaveObligatorio.ForeColor = System.Drawing.Color.Red
        Me.LBClaveObligatorio.Location = New System.Drawing.Point(234, 66)
        Me.LBClaveObligatorio.Name = "LBClaveObligatorio"
        Me.LBClaveObligatorio.Size = New System.Drawing.Size(15, 20)
        Me.LBClaveObligatorio.TabIndex = 28
        Me.LBClaveObligatorio.Text = "*"
        '
        'LBAliasObligatorio
        '
        Me.LBAliasObligatorio.AutoSize = True
        Me.LBAliasObligatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBAliasObligatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBAliasObligatorio.ForeColor = System.Drawing.Color.Red
        Me.LBAliasObligatorio.Location = New System.Drawing.Point(234, 28)
        Me.LBAliasObligatorio.Name = "LBAliasObligatorio"
        Me.LBAliasObligatorio.Size = New System.Drawing.Size(15, 20)
        Me.LBAliasObligatorio.TabIndex = 27
        Me.LBAliasObligatorio.Text = "*"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BTNSalir)
        Me.GroupBox2.Controls.Add(Me.BTNAcceder)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(91, 102)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'BTNSalir
        '
        Me.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNSalir.Location = New System.Drawing.Point(7, 48)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(75, 23)
        Me.BTNSalir.TabIndex = 4
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(315, 31)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(118, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(17, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Campos Obligatorios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Grupo Acosta C.A"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox3.Location = New System.Drawing.Point(-65, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(535, 6)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(435, 6)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Silver
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox4.Location = New System.Drawing.Point(0, 208)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(435, 3)
        Me.PictureBox4.TabIndex = 101
        Me.PictureBox4.TabStop = False
        '
        'FIngreso
        '
        Me.AcceptButton = Me.BTNAcceder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.BTNSalir
        Me.ClientSize = New System.Drawing.Size(435, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBIniciarSesion)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - INICIAR SESIÓN"
        Me.GBIniciarSesion.ResumeLayout(False)
        Me.GBIniciarSesion.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNAcceder As System.Windows.Forms.Button
    Friend WithEvents TBAlias As System.Windows.Forms.TextBox
    Friend WithEvents TBClave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GBIniciarSesion As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LBClaveObligatorio As System.Windows.Forms.Label
    Friend WithEvents LBAliasObligatorio As System.Windows.Forms.Label
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CBAlias As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
