﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPersonasUsuarios
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
        Me.GBPersonasUsuarios = New System.Windows.Forms.GroupBox()
        Me.DGVPersonasNoUsuarios = New System.Windows.Forms.DataGridView()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNSeleccionar = New System.Windows.Forms.Button()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.GBPersonasUsuarios.SuspendLayout()
        CType(Me.DGVPersonasNoUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBPersonasUsuarios
        '
        Me.GBPersonasUsuarios.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.GBPersonasUsuarios.Controls.Add(Me.DGVPersonasNoUsuarios)
        Me.GBPersonasUsuarios.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPersonasUsuarios.Location = New System.Drawing.Point(13, 73)
        Me.GBPersonasUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.GBPersonasUsuarios.Name = "GBPersonasUsuarios"
        Me.GBPersonasUsuarios.Padding = New System.Windows.Forms.Padding(4)
        Me.GBPersonasUsuarios.Size = New System.Drawing.Size(543, 243)
        Me.GBPersonasUsuarios.TabIndex = 0
        Me.GBPersonasUsuarios.TabStop = False
        Me.GBPersonasUsuarios.Text = "Persona que no son usuarios del sistema"
        '
        'DGVPersonasNoUsuarios
        '
        Me.DGVPersonasNoUsuarios.BackgroundColor = System.Drawing.Color.Olive
        Me.DGVPersonasNoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPersonasNoUsuarios.Location = New System.Drawing.Point(7, 22)
        Me.DGVPersonasNoUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVPersonasNoUsuarios.Name = "DGVPersonasNoUsuarios"
        Me.DGVPersonasNoUsuarios.Size = New System.Drawing.Size(529, 214)
        Me.DGVPersonasNoUsuarios.TabIndex = 0
        '
        'TXTBuscar
        '
        Me.TXTBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(20, 40)
        Me.TXTBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(225, 25)
        Me.TXTBuscar.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual2
        Me.GroupBox1.Controls.Add(Me.BTNCancelar)
        Me.GroupBox1.Controls.Add(Me.BTNSeleccionar)
        Me.GroupBox1.Location = New System.Drawing.Point(356, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(193, 58)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Enabled = False
        Me.BTNCancelar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCancelar.Location = New System.Drawing.Point(109, 14)
        Me.BTNCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(76, 38)
        Me.BTNCancelar.TabIndex = 1
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNSeleccionar
        '
        Me.BTNSeleccionar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSeleccionar.Location = New System.Drawing.Point(8, 14)
        Me.BTNSeleccionar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSeleccionar.Name = "BTNSeleccionar"
        Me.BTNSeleccionar.Size = New System.Drawing.Size(93, 38)
        Me.BTNSeleccionar.TabIndex = 0
        Me.BTNSeleccionar.Text = "Seleccionar"
        Me.BTNSeleccionar.UseVisualStyleBackColor = True
        '
        'LBLBuscar
        '
        Me.LBLBuscar.AutoSize = True
        Me.LBLBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLBuscar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBuscar.Location = New System.Drawing.Point(77, 16)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(117, 20)
        Me.LBLBuscar.TabIndex = 14
        Me.LBLBuscar.Text = "Buscar(Nombre, Ci)"
        '
        'FPersonasUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCAactual2
        Me.ClientSize = New System.Drawing.Size(564, 322)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.GBPersonasUsuarios)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FPersonasUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO PERSONA NO USUARIO"
        Me.GBPersonasUsuarios.ResumeLayout(False)
        CType(Me.DGVPersonasNoUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBPersonasUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents DGVPersonasNoUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNSeleccionar As System.Windows.Forms.Button
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label

   

End Class
