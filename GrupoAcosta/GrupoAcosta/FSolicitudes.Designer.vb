﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSolicitudes
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
        Me.GBNuevaSolicitud = New System.Windows.Forms.GroupBox()
        Me.LBCamposObligatoriosAst = New System.Windows.Forms.Label()
        Me.LBLValidarCliente = New System.Windows.Forms.Label()
        Me.LBCamposObligatorios = New System.Windows.Forms.Label()
        Me.TXTCliente = New System.Windows.Forms.TextBox()
        Me.CMBCliente = New System.Windows.Forms.ComboBox()
        Me.LBLCliente = New System.Windows.Forms.Label()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNModificar = New System.Windows.Forms.Button()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.GBSolicitudes = New System.Windows.Forms.GroupBox()
        Me.DGVSolicitudes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BNTReporteSolicitudes = New System.Windows.Forms.Button()
        Me.GBNuevaSolicitud.SuspendLayout()
        Me.GBSolicitudes.SuspendLayout()
        CType(Me.DGVSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBNuevaSolicitud
        '
        Me.GBNuevaSolicitud.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GBNuevaSolicitud.Controls.Add(Me.LBCamposObligatoriosAst)
        Me.GBNuevaSolicitud.Controls.Add(Me.LBLValidarCliente)
        Me.GBNuevaSolicitud.Controls.Add(Me.LBCamposObligatorios)
        Me.GBNuevaSolicitud.Controls.Add(Me.TXTCliente)
        Me.GBNuevaSolicitud.Controls.Add(Me.CMBCliente)
        Me.GBNuevaSolicitud.Controls.Add(Me.LBLCliente)
        Me.GBNuevaSolicitud.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBNuevaSolicitud.Location = New System.Drawing.Point(12, 12)
        Me.GBNuevaSolicitud.Name = "GBNuevaSolicitud"
        Me.GBNuevaSolicitud.Size = New System.Drawing.Size(639, 102)
        Me.GBNuevaSolicitud.TabIndex = 3
        Me.GBNuevaSolicitud.TabStop = False
        Me.GBNuevaSolicitud.Text = "Nueva Solicitud"
        '
        'LBCamposObligatoriosAst
        '
        Me.LBCamposObligatoriosAst.AutoSize = True
        Me.LBCamposObligatoriosAst.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatoriosAst.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatoriosAst.Location = New System.Drawing.Point(533, 72)
        Me.LBCamposObligatoriosAst.Name = "LBCamposObligatoriosAst"
        Me.LBCamposObligatoriosAst.Size = New System.Drawing.Size(12, 15)
        Me.LBCamposObligatoriosAst.TabIndex = 46
        Me.LBCamposObligatoriosAst.Text = "*"
        '
        'LBLValidarCliente
        '
        Me.LBLValidarCliente.AutoSize = True
        Me.LBLValidarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidarCliente.ForeColor = System.Drawing.Color.Red
        Me.LBLValidarCliente.Location = New System.Drawing.Point(533, 30)
        Me.LBLValidarCliente.Name = "LBLValidarCliente"
        Me.LBLValidarCliente.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidarCliente.TabIndex = 33
        Me.LBLValidarCliente.Text = "*"
        '
        'LBCamposObligatorios
        '
        Me.LBCamposObligatorios.AutoSize = True
        Me.LBCamposObligatorios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCamposObligatorios.ForeColor = System.Drawing.Color.Red
        Me.LBCamposObligatorios.Location = New System.Drawing.Point(396, 72)
        Me.LBCamposObligatorios.Name = "LBCamposObligatorios"
        Me.LBCamposObligatorios.Size = New System.Drawing.Size(125, 15)
        Me.LBCamposObligatorios.TabIndex = 45
        Me.LBCamposObligatorios.Text = "Campos Obligatorios"
        '
        'TXTCliente
        '
        Me.TXTCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTCliente.Enabled = False
        Me.TXTCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCliente.Location = New System.Drawing.Point(547, 51)
        Me.TXTCliente.Name = "TXTCliente"
        Me.TXTCliente.Size = New System.Drawing.Size(66, 20)
        Me.TXTCliente.TabIndex = 32
        Me.TXTCliente.Visible = False
        '
        'CMBCliente
        '
        Me.CMBCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBCliente.Enabled = False
        Me.CMBCliente.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCliente.FormattingEnabled = True
        Me.CMBCliente.Location = New System.Drawing.Point(146, 30)
        Me.CMBCliente.Name = "CMBCliente"
        Me.CMBCliente.Size = New System.Drawing.Size(361, 25)
        Me.CMBCliente.TabIndex = 31
        '
        'LBLCliente
        '
        Me.LBLCliente.AutoSize = True
        Me.LBLCliente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCliente.Location = New System.Drawing.Point(15, 35)
        Me.LBLCliente.Name = "LBLCliente"
        Me.LBLCliente.Size = New System.Drawing.Size(48, 20)
        Me.LBLCliente.TabIndex = 4
        Me.LBLCliente.Text = "Cliente"
        '
        'BTNAgregar
        '
        Me.BTNAgregar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAgregar.Location = New System.Drawing.Point(17, 16)
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
        Me.BTNSalir.Location = New System.Drawing.Point(430, 16)
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
        Me.BTNGuardar.Location = New System.Drawing.Point(102, 16)
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
        Me.BTNCancelar.Location = New System.Drawing.Point(348, 16)
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
        Me.BTNModificar.Location = New System.Drawing.Point(184, 16)
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
        Me.BTNEliminar.Location = New System.Drawing.Point(266, 16)
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
        Me.LBLBuscar.Location = New System.Drawing.Point(709, 235)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(97, 20)
        Me.LBLBuscar.TabIndex = 33
        Me.LBLBuscar.Text = "Buscar (Cliente)"
        '
        'TXTBuscar
        '
        Me.TXTBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(655, 267)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(188, 20)
        Me.TXTBuscar.TabIndex = 32
        '
        'GBSolicitudes
        '
        Me.GBSolicitudes.BackColor = System.Drawing.Color.DarkKhaki
        Me.GBSolicitudes.Controls.Add(Me.DGVSolicitudes)
        Me.GBSolicitudes.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSolicitudes.Location = New System.Drawing.Point(12, 133)
        Me.GBSolicitudes.Name = "GBSolicitudes"
        Me.GBSolicitudes.Size = New System.Drawing.Size(639, 271)
        Me.GBSolicitudes.TabIndex = 34
        Me.GBSolicitudes.TabStop = False
        Me.GBSolicitudes.Text = "Solicitud Productos"
        '
        'DGVSolicitudes
        '
        Me.DGVSolicitudes.BackgroundColor = System.Drawing.Color.DarkKhaki
        Me.DGVSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSolicitudes.Location = New System.Drawing.Point(6, 24)
        Me.DGVSolicitudes.Name = "DGVSolicitudes"
        Me.DGVSolicitudes.Size = New System.Drawing.Size(627, 241)
        Me.DGVSolicitudes.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Controls.Add(Me.BTNSalir)
        Me.GroupBox1.Controls.Add(Me.BTNAgregar)
        Me.GroupBox1.Controls.Add(Me.BTNCancelar)
        Me.GroupBox1.Controls.Add(Me.BTNGuardar)
        Me.GroupBox1.Controls.Add(Me.BTNEliminar)
        Me.GroupBox1.Controls.Add(Me.BTNModificar)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 421)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 56)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BNTReporteSolicitudes
        '
        Me.BNTReporteSolicitudes.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNTReporteSolicitudes.Location = New System.Drawing.Point(713, 294)
        Me.BNTReporteSolicitudes.Margin = New System.Windows.Forms.Padding(4)
        Me.BNTReporteSolicitudes.Name = "BNTReporteSolicitudes"
        Me.BNTReporteSolicitudes.Size = New System.Drawing.Size(74, 33)
        Me.BNTReporteSolicitudes.TabIndex = 36
        Me.BNTReporteSolicitudes.Text = "Ver"
        Me.BNTReporteSolicitudes.UseVisualStyleBackColor = True
        '
        'FSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual2
        Me.ClientSize = New System.Drawing.Size(850, 484)
        Me.Controls.Add(Me.BNTReporteSolicitudes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBSolicitudes)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GBNuevaSolicitud)
        Me.Name = "FSolicitudes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO SOLICITUDES"
        Me.GBNuevaSolicitud.ResumeLayout(False)
        Me.GBNuevaSolicitud.PerformLayout()
        Me.GBSolicitudes.ResumeLayout(False)
        CType(Me.DGVSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBNuevaSolicitud As System.Windows.Forms.GroupBox
    Friend WithEvents LBLValidarCliente As System.Windows.Forms.Label
    Friend WithEvents TXTCliente As System.Windows.Forms.TextBox
    Friend WithEvents CMBCliente As System.Windows.Forms.ComboBox
    Friend WithEvents LBLCliente As System.Windows.Forms.Label
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNModificar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GBSolicitudes As System.Windows.Forms.GroupBox
    Friend WithEvents DGVSolicitudes As System.Windows.Forms.DataGridView
    Friend WithEvents LBCamposObligatoriosAst As System.Windows.Forms.Label
    Friend WithEvents LBCamposObligatorios As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BNTReporteSolicitudes As System.Windows.Forms.Button
End Class
