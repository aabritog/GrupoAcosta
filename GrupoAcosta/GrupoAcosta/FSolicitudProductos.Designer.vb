<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSolicitudProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSolicitudProductos))
        Me.DGVSolicitudesSistema = New System.Windows.Forms.DataGridView()
        Me.GBPersonasUsuarios = New System.Windows.Forms.GroupBox()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNSiguiente = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTSoliictudesSistema = New System.Windows.Forms.TextBox()
        CType(Me.DGVSolicitudesSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPersonasUsuarios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVSolicitudesSistema
        '
        Me.DGVSolicitudesSistema.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DGVSolicitudesSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSolicitudesSistema.Location = New System.Drawing.Point(6, 18)
        Me.DGVSolicitudesSistema.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVSolicitudesSistema.Name = "DGVSolicitudesSistema"
        Me.DGVSolicitudesSistema.Size = New System.Drawing.Size(483, 214)
        Me.DGVSolicitudesSistema.TabIndex = 0
        '
        'GBPersonasUsuarios
        '
        Me.GBPersonasUsuarios.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.GBPersonasUsuarios.Controls.Add(Me.DGVSolicitudesSistema)
        Me.GBPersonasUsuarios.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPersonasUsuarios.Location = New System.Drawing.Point(5, 142)
        Me.GBPersonasUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.GBPersonasUsuarios.Name = "GBPersonasUsuarios"
        Me.GBPersonasUsuarios.Padding = New System.Windows.Forms.Padding(4)
        Me.GBPersonasUsuarios.Size = New System.Drawing.Size(501, 238)
        Me.GBPersonasUsuarios.TabIndex = 1
        Me.GBPersonasUsuarios.TabStop = False
        '
        'LBLBuscar
        '
        Me.LBLBuscar.AutoSize = True
        Me.LBLBuscar.BackColor = System.Drawing.Color.Transparent
        Me.LBLBuscar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBuscar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLBuscar.Location = New System.Drawing.Point(50, 76)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(127, 20)
        Me.LBLBuscar.TabIndex = 17
        Me.LBLBuscar.Text = "Buscar(Nombre, Ci)"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BTNSiguiente)
        Me.GroupBox1.Controls.Add(Me.BTNCancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(319, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(175, 58)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'BTNSiguiente
        '
        Me.BTNSiguiente.Enabled = False
        Me.BTNSiguiente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSiguiente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNSiguiente.Location = New System.Drawing.Point(8, 14)
        Me.BTNSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSiguiente.Name = "BTNSiguiente"
        Me.BTNSiguiente.Size = New System.Drawing.Size(76, 38)
        Me.BTNSiguiente.TabIndex = 2
        Me.BTNSiguiente.Text = "Siguiente"
        Me.BTNSiguiente.UseVisualStyleBackColor = True
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCancelar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNCancelar.Location = New System.Drawing.Point(92, 14)
        Me.BTNCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(76, 38)
        Me.BTNCancelar.TabIndex = 1
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'TXTBuscar
        '
        Me.TXTBuscar.BackColor = System.Drawing.Color.White
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(5, 100)
        Me.TXTBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(225, 20)
        Me.TXTBuscar.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 20)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "MÓDULO PRODUCTO ENTRANTE"
        '
        'TXTSoliictudesSistema
        '
        Me.TXTSoliictudesSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTSoliictudesSistema.Enabled = False
        Me.TXTSoliictudesSistema.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSoliictudesSistema.Location = New System.Drawing.Point(283, 94)
        Me.TXTSoliictudesSistema.Name = "TXTSoliictudesSistema"
        Me.TXTSoliictudesSistema.Size = New System.Drawing.Size(25, 20)
        Me.TXTSoliictudesSistema.TabIndex = 43
        Me.TXTSoliictudesSistema.TabStop = False
        Me.TXTSoliictudesSistema.Visible = False
        '
        'FSolicitudProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.ClientSize = New System.Drawing.Size(510, 384)
        Me.Controls.Add(Me.TXTSoliictudesSistema)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.GBPersonasUsuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FSolicitudProductos"
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO SOLICITUD-PRODUCTOS"
        CType(Me.DGVSolicitudesSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBPersonasUsuarios.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVSolicitudesSistema As System.Windows.Forms.DataGridView
    Friend WithEvents GBPersonasUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents BTNSiguiente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTSoliictudesSistema As System.Windows.Forms.TextBox
End Class
