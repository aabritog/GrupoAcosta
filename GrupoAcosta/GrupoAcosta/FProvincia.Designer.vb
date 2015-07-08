<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProvincia
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
        Me.GBNuevaProvincia = New System.Windows.Forms.GroupBox()
        Me.LBLValidarProvincia = New System.Windows.Forms.Label()
        Me.TXTProvincia = New System.Windows.Forms.TextBox()
        Me.LBLProvincia = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNModificar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.GBCProvincia = New System.Windows.Forms.GroupBox()
        Me.DGVProvincia = New System.Windows.Forms.DataGridView()
        Me.GBNuevaProvincia.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBCProvincia.SuspendLayout()
        CType(Me.DGVProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBNuevaProvincia
        '
        Me.GBNuevaProvincia.Controls.Add(Me.LBLValidarProvincia)
        Me.GBNuevaProvincia.Controls.Add(Me.TXTProvincia)
        Me.GBNuevaProvincia.Controls.Add(Me.LBLProvincia)
        Me.GBNuevaProvincia.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBNuevaProvincia.Location = New System.Drawing.Point(12, 12)
        Me.GBNuevaProvincia.Name = "GBNuevaProvincia"
        Me.GBNuevaProvincia.Size = New System.Drawing.Size(353, 88)
        Me.GBNuevaProvincia.TabIndex = 2
        Me.GBNuevaProvincia.TabStop = False
        Me.GBNuevaProvincia.Text = "Nueva Provincia"
        '
        'LBLValidarProvincia
        '
        Me.LBLValidarProvincia.AutoSize = True
        Me.LBLValidarProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarProvincia.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarProvincia.Location = New System.Drawing.Point(320, 42)
        Me.LBLValidarProvincia.Name = "LBLValidarProvincia"
        Me.LBLValidarProvincia.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarProvincia.TabIndex = 28
        Me.LBLValidarProvincia.Text = "*"
        '
        'TXTProvincia
        '
        Me.TXTProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTProvincia.Enabled = False
        Me.TXTProvincia.Location = New System.Drawing.Point(162, 37)
        Me.TXTProvincia.MaxLength = 30
        Me.TXTProvincia.Name = "TXTProvincia"
        Me.TXTProvincia.Size = New System.Drawing.Size(121, 25)
        Me.TXTProvincia.TabIndex = 5
        '
        'LBLProvincia
        '
        Me.LBLProvincia.AutoSize = True
        Me.LBLProvincia.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProvincia.Location = New System.Drawing.Point(15, 42)
        Me.LBLProvincia.Name = "LBLProvincia"
        Me.LBLProvincia.Size = New System.Drawing.Size(60, 20)
        Me.LBLProvincia.TabIndex = 3
        Me.LBLProvincia.Text = "Provincia"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNAgregar)
        Me.GroupBox2.Controls.Add(Me.BTNSalir)
        Me.GroupBox2.Controls.Add(Me.BTNGuardar)
        Me.GroupBox2.Controls.Add(Me.BTNCancelar)
        Me.GroupBox2.Controls.Add(Me.BTNModificar)
        Me.GroupBox2.Controls.Add(Me.BTNEliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(93, 254)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
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
        Me.LBLBuscar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBuscar.Location = New System.Drawing.Point(39, 126)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(109, 20)
        Me.LBLBuscar.TabIndex = 32
        Me.LBLBuscar.Text = "Buscar (Provincia)"
        '
        'TXTBuscar
        '
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(174, 126)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(176, 20)
        Me.TXTBuscar.TabIndex = 31
        '
        'GBCProvincia
        '
        Me.GBCProvincia.Controls.Add(Me.DGVProvincia)
        Me.GBCProvincia.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBCProvincia.Location = New System.Drawing.Point(12, 164)
        Me.GBCProvincia.Name = "GBCProvincia"
        Me.GBCProvincia.Size = New System.Drawing.Size(366, 136)
        Me.GBCProvincia.TabIndex = 33
        Me.GBCProvincia.TabStop = False
        Me.GBCProvincia.Text = "Provincias en el Sistema"
        '
        'DGVProvincia
        '
        Me.DGVProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProvincia.Location = New System.Drawing.Point(6, 24)
        Me.DGVProvincia.Name = "DGVProvincia"
        Me.DGVProvincia.Size = New System.Drawing.Size(347, 102)
        Me.DGVProvincia.TabIndex = 23
        '
        'FProvincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 307)
        Me.Controls.Add(Me.GBCProvincia)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBNuevaProvincia)
        Me.Name = "FProvincia"
        Me.Text = "Módulo Provincia-Grupo Acosta"
        Me.GBNuevaProvincia.ResumeLayout(False)
        Me.GBNuevaProvincia.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GBCProvincia.ResumeLayout(False)
        CType(Me.DGVProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBNuevaProvincia As System.Windows.Forms.GroupBox
    Friend WithEvents LBLValidarProvincia As System.Windows.Forms.Label
    Friend WithEvents TXTProvincia As System.Windows.Forms.TextBox
    Friend WithEvents LBLProvincia As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNModificar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GBCProvincia As System.Windows.Forms.GroupBox
    Friend WithEvents DGVProvincia As System.Windows.Forms.DataGridView
End Class
