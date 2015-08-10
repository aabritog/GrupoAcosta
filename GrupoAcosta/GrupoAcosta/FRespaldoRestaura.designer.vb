<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRespaldoRestaura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRespaldoRestaura))
        Me.BTNRespaldar = New System.Windows.Forms.Button()
        Me.BTNRestaurar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.TBArchivoBackup = New System.Windows.Forms.TextBox()
        Me.OFDSeleccionarArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.BTNExaminar = New System.Windows.Forms.Button()
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LNNombreAtencion = New System.Windows.Forms.Label()
        Me.SFDArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBRestaurar = New System.Windows.Forms.RadioButton()
        Me.RBRespaldo = New System.Windows.Forms.RadioButton()
        Me.GBDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNRespaldar
        '
        Me.BTNRespaldar.Enabled = False
        Me.BTNRespaldar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNRespaldar.Location = New System.Drawing.Point(12, 19)
        Me.BTNRespaldar.Name = "BTNRespaldar"
        Me.BTNRespaldar.Size = New System.Drawing.Size(75, 23)
        Me.BTNRespaldar.TabIndex = 2
        Me.BTNRespaldar.Text = "Respaldar"
        Me.BTNRespaldar.UseVisualStyleBackColor = True
        '
        'BTNRestaurar
        '
        Me.BTNRestaurar.Enabled = False
        Me.BTNRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNRestaurar.Location = New System.Drawing.Point(12, 48)
        Me.BTNRestaurar.Name = "BTNRestaurar"
        Me.BTNRestaurar.Size = New System.Drawing.Size(75, 23)
        Me.BTNRestaurar.TabIndex = 3
        Me.BTNRestaurar.Text = "Restaurar"
        Me.BTNRestaurar.UseVisualStyleBackColor = True
        '
        'BTNSalir
        '
        Me.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNSalir.Location = New System.Drawing.Point(12, 77)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(75, 23)
        Me.BTNSalir.TabIndex = 4
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'TBArchivoBackup
        '
        Me.TBArchivoBackup.BackColor = System.Drawing.Color.Beige
        Me.TBArchivoBackup.Location = New System.Drawing.Point(13, 34)
        Me.TBArchivoBackup.Name = "TBArchivoBackup"
        Me.TBArchivoBackup.ReadOnly = True
        Me.TBArchivoBackup.Size = New System.Drawing.Size(293, 20)
        Me.TBArchivoBackup.TabIndex = 10
        Me.TBArchivoBackup.TabStop = False
        '
        'OFDSeleccionarArchivo
        '
        Me.OFDSeleccionarArchivo.FileName = "OpenFileDialog1"
        '
        'BTNExaminar
        '
        Me.BTNExaminar.Enabled = False
        Me.BTNExaminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNExaminar.Location = New System.Drawing.Point(231, 60)
        Me.BTNExaminar.Name = "BTNExaminar"
        Me.BTNExaminar.Size = New System.Drawing.Size(75, 26)
        Me.BTNExaminar.TabIndex = 1
        Me.BTNExaminar.Text = "Examinar..."
        Me.BTNExaminar.UseVisualStyleBackColor = True
        '
        'GBDatos
        '
        Me.GBDatos.BackColor = System.Drawing.Color.White
        Me.GBDatos.Controls.Add(Me.BTNExaminar)
        Me.GBDatos.Controls.Add(Me.TBArchivoBackup)
        Me.GBDatos.Location = New System.Drawing.Point(12, 131)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(324, 99)
        Me.GBDatos.TabIndex = 12
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Archivo de Restauracion/Ubicación archivo de Respaldo"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BTNRespaldar)
        Me.GroupBox1.Controls.Add(Me.BTNRestaurar)
        Me.GroupBox1.Controls.Add(Me.BTNSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(342, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(98, 153)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Silver
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Location = New System.Drawing.Point(0, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(461, 6)
        Me.PictureBox4.TabIndex = 96
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Navy
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 6)
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Silver
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox3.Location = New System.Drawing.Point(0, 249)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(461, 6)
        Me.PictureBox3.TabIndex = 94
        Me.PictureBox3.TabStop = False
        '
        'LNNombreAtencion
        '
        Me.LNNombreAtencion.AutoSize = True
        Me.LNNombreAtencion.BackColor = System.Drawing.Color.White
        Me.LNNombreAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNNombreAtencion.ForeColor = System.Drawing.Color.Navy
        Me.LNNombreAtencion.Location = New System.Drawing.Point(12, 31)
        Me.LNNombreAtencion.Name = "LNNombreAtencion"
        Me.LNNombreAtencion.Size = New System.Drawing.Size(253, 20)
        Me.LNNombreAtencion.TabIndex = 97
        Me.LNNombreAtencion.Text = "MENÚ RESPALDO/RESTAURAR"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.RBRestaurar)
        Me.GroupBox2.Controls.Add(Me.RBRespaldo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 48)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Elija lo que desee hacer"
        '
        'RBRestaurar
        '
        Me.RBRestaurar.AutoSize = True
        Me.RBRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RBRestaurar.Location = New System.Drawing.Point(217, 20)
        Me.RBRestaurar.Name = "RBRestaurar"
        Me.RBRestaurar.Size = New System.Drawing.Size(77, 18)
        Me.RBRestaurar.TabIndex = 1
        Me.RBRestaurar.TabStop = True
        Me.RBRestaurar.Text = "Restaurar"
        Me.RBRestaurar.UseVisualStyleBackColor = True
        '
        'RBRespaldo
        '
        Me.RBRespaldo.AutoSize = True
        Me.RBRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RBRespaldo.Location = New System.Drawing.Point(23, 20)
        Me.RBRespaldo.Name = "RBRespaldo"
        Me.RBRespaldo.Size = New System.Drawing.Size(76, 18)
        Me.RBRespaldo.TabIndex = 0
        Me.RBRespaldo.TabStop = True
        Me.RBRespaldo.Text = "Respaldo"
        Me.RBRespaldo.UseVisualStyleBackColor = True
        '
        'FRespaldoRestaura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        'Me.BackgroundImage = Global.DynastyEnfermeria.My.Resources.Resources.dyn_marca_agua_conf
        Me.ClientSize = New System.Drawing.Size(461, 255)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LNNombreAtencion)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRespaldoRestaura"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamento de Enfermería - Ménu Respaldo/Restaurar"
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNRespaldar As System.Windows.Forms.Button
    Friend WithEvents BTNRestaurar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents TBArchivoBackup As System.Windows.Forms.TextBox
    Friend WithEvents OFDSeleccionarArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BTNExaminar As System.Windows.Forms.Button
    Friend WithEvents GBDatos As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents LNNombreAtencion As System.Windows.Forms.Label
    Friend WithEvents SFDArchivo As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBRestaurar As System.Windows.Forms.RadioButton
    Friend WithEvents RBRespaldo As System.Windows.Forms.RadioButton
End Class
