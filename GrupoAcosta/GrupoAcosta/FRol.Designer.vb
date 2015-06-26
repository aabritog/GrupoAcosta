<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRol
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
        Me.LBLValidarDescripcion = New System.Windows.Forms.Label()
        Me.TXTDescripcionCorta = New System.Windows.Forms.TextBox()
        Me.TXTDescripcion = New System.Windows.Forms.TextBox()
        Me.LBLDescripcionCorta = New System.Windows.Forms.Label()
        Me.LBLDescripcion = New System.Windows.Forms.Label()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.GBRol = New System.Windows.Forms.GroupBox()
        Me.DGVRol = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNModificar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GBRol.SuspendLayout()
        CType(Me.DGVRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBLValidarDescripcion)
        Me.GroupBox1.Controls.Add(Me.TXTDescripcionCorta)
        Me.GroupBox1.Controls.Add(Me.TXTDescripcion)
        Me.GroupBox1.Controls.Add(Me.LBLDescripcionCorta)
        Me.GroupBox1.Controls.Add(Me.LBLDescripcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 103)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Rol"
        '
        'LBLValidarDescripcion
        '
        Me.LBLValidarDescripcion.AutoSize = True
        Me.LBLValidarDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarDescripcion.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarDescripcion.Location = New System.Drawing.Point(328, 19)
        Me.LBLValidarDescripcion.Name = "LBLValidarDescripcion"
        Me.LBLValidarDescripcion.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarDescripcion.TabIndex = 28
        Me.LBLValidarDescripcion.Text = "*"
        '
        'TXTDescripcionCorta
        '
        Me.TXTDescripcionCorta.Enabled = False
        Me.TXTDescripcionCorta.Location = New System.Drawing.Point(185, 61)
        Me.TXTDescripcionCorta.MaxLength = 15
        Me.TXTDescripcionCorta.Name = "TXTDescripcionCorta"
        Me.TXTDescripcionCorta.Size = New System.Drawing.Size(121, 25)
        Me.TXTDescripcionCorta.TabIndex = 6
        '
        'TXTDescripcion
        '
        Me.TXTDescripcion.Enabled = False
        Me.TXTDescripcion.Location = New System.Drawing.Point(185, 19)
        Me.TXTDescripcion.MaxLength = 30
        Me.TXTDescripcion.Name = "TXTDescripcion"
        Me.TXTDescripcion.Size = New System.Drawing.Size(121, 25)
        Me.TXTDescripcion.TabIndex = 5
        '
        'LBLDescripcionCorta
        '
        Me.LBLDescripcionCorta.AutoSize = True
        Me.LBLDescripcionCorta.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDescripcionCorta.Location = New System.Drawing.Point(15, 68)
        Me.LBLDescripcionCorta.Name = "LBLDescripcionCorta"
        Me.LBLDescripcionCorta.Size = New System.Drawing.Size(107, 20)
        Me.LBLDescripcionCorta.TabIndex = 4
        Me.LBLDescripcionCorta.Text = "Descripción Corta"
        '
        'LBLDescripcion
        '
        Me.LBLDescripcion.AutoSize = True
        Me.LBLDescripcion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDescripcion.Location = New System.Drawing.Point(15, 29)
        Me.LBLDescripcion.Name = "LBLDescripcion"
        Me.LBLDescripcion.Size = New System.Drawing.Size(74, 20)
        Me.LBLDescripcion.TabIndex = 3
        Me.LBLDescripcion.Text = "Descripción"
        '
        'LBLBuscar
        '
        Me.LBLBuscar.AutoSize = True
        Me.LBLBuscar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBuscar.Location = New System.Drawing.Point(24, 143)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(123, 20)
        Me.LBLBuscar.TabIndex = 28
        Me.LBLBuscar.Text = "Buscar (Descripcion)"
        '
        'TXTBuscar
        '
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(218, 143)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(176, 20)
        Me.TXTBuscar.TabIndex = 27
        '
        'GBRol
        '
        Me.GBRol.Controls.Add(Me.DGVRol)
        Me.GBRol.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBRol.Location = New System.Drawing.Point(12, 184)
        Me.GBRol.Name = "GBRol"
        Me.GBRol.Size = New System.Drawing.Size(485, 206)
        Me.GBRol.TabIndex = 29
        Me.GBRol.TabStop = False
        Me.GBRol.Text = "Roles en el Sistema"
        '
        'DGVRol
        '
        Me.DGVRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRol.Location = New System.Drawing.Point(6, 24)
        Me.DGVRol.Name = "DGVRol"
        Me.DGVRol.Size = New System.Drawing.Size(473, 174)
        Me.DGVRol.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BTNAgregar)
        Me.GroupBox3.Controls.Add(Me.BTNSalir)
        Me.GroupBox3.Controls.Add(Me.BTNGuardar)
        Me.GroupBox3.Controls.Add(Me.BTNCancelar)
        Me.GroupBox3.Controls.Add(Me.BTNModificar)
        Me.GroupBox3.Controls.Add(Me.BTNEliminar)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(521, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(93, 254)
        Me.GroupBox3.TabIndex = 31
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
        'FRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 397)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GBRol)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRol"
        Me.Text = "Módulo Roles-Grupo Acosta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBRol.ResumeLayout(False)
        CType(Me.DGVRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLValidarDescripcion As System.Windows.Forms.Label
    Friend WithEvents TXTDescripcionCorta As System.Windows.Forms.TextBox
    Friend WithEvents TXTDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents LBLDescripcionCorta As System.Windows.Forms.Label
    Friend WithEvents LBLDescripcion As System.Windows.Forms.Label
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GBRol As System.Windows.Forms.GroupBox
    Friend WithEvents DGVRol As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNModificar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
End Class
