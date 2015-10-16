<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSolicitudesConsulta
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLBuscar = New System.Windows.Forms.Label()
        Me.TXTBuscar = New System.Windows.Forms.TextBox()
        Me.GBPersonasUsuarios = New System.Windows.Forms.GroupBox()
        Me.DGVConsultaSolicitudes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.BTNVerSolicitud = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BTNReporteSolicitudes = New System.Windows.Forms.Button()
        Me.BTNSolicitudIniciada = New System.Windows.Forms.Button()
        Me.BTNSolicitudProceso = New System.Windows.Forms.Button()
        Me.BTNSolicitudFinalizada = New System.Windows.Forms.Button()
        Me.TXTDTPDos = New System.Windows.Forms.TextBox()
        Me.TXTDTPUno = New System.Windows.Forms.TextBox()
        Me.DTPUno = New System.Windows.Forms.DateTimePicker()
        Me.DTPDos = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLValidar2 = New System.Windows.Forms.Label()
        Me.LBLValidar1 = New System.Windows.Forms.Label()
        Me.GBPersonasUsuarios.SuspendLayout()
        CType(Me.DGVConsultaSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(8, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "MÓDULO CONSULTA SOLICITUDES"
        '
        'LBLBuscar
        '
        Me.LBLBuscar.AutoSize = True
        Me.LBLBuscar.BackColor = System.Drawing.Color.Transparent
        Me.LBLBuscar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBuscar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LBLBuscar.Location = New System.Drawing.Point(51, 73)
        Me.LBLBuscar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLBuscar.Name = "LBLBuscar"
        Me.LBLBuscar.Size = New System.Drawing.Size(154, 20)
        Me.LBLBuscar.TabIndex = 50
        Me.LBLBuscar.Text = "Buscar(Nombre Cliente)"
        '
        'TXTBuscar
        '
        Me.TXTBuscar.BackColor = System.Drawing.Color.White
        Me.TXTBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBuscar.Location = New System.Drawing.Point(6, 97)
        Me.TXTBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTBuscar.Name = "TXTBuscar"
        Me.TXTBuscar.Size = New System.Drawing.Size(225, 20)
        Me.TXTBuscar.TabIndex = 49
        '
        'GBPersonasUsuarios
        '
        Me.GBPersonasUsuarios.BackColor = System.Drawing.Color.White
        Me.GBPersonasUsuarios.Controls.Add(Me.DGVConsultaSolicitudes)
        Me.GBPersonasUsuarios.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPersonasUsuarios.Location = New System.Drawing.Point(6, 139)
        Me.GBPersonasUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.GBPersonasUsuarios.Name = "GBPersonasUsuarios"
        Me.GBPersonasUsuarios.Padding = New System.Windows.Forms.Padding(4)
        Me.GBPersonasUsuarios.Size = New System.Drawing.Size(477, 260)
        Me.GBPersonasUsuarios.TabIndex = 3
        Me.GBPersonasUsuarios.TabStop = False
        '
        'DGVConsultaSolicitudes
        '
        Me.DGVConsultaSolicitudes.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DGVConsultaSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVConsultaSolicitudes.Location = New System.Drawing.Point(6, 18)
        Me.DGVConsultaSolicitudes.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVConsultaSolicitudes.Name = "DGVConsultaSolicitudes"
        Me.DGVConsultaSolicitudes.Size = New System.Drawing.Size(465, 242)
        Me.DGVConsultaSolicitudes.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BTNEliminar)
        Me.GroupBox1.Controls.Add(Me.BTNVerSolicitud)
        Me.GroupBox1.Controls.Add(Me.BTNSalir)
        Me.GroupBox1.Controls.Add(Me.BTNCancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 406)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 52)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Enabled = False
        Me.BTNEliminar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEliminar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNEliminar.Location = New System.Drawing.Point(122, 10)
        Me.BTNEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(74, 38)
        Me.BTNEliminar.TabIndex = 55
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'BTNVerSolicitud
        '
        Me.BTNVerSolicitud.Enabled = False
        Me.BTNVerSolicitud.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNVerSolicitud.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNVerSolicitud.Location = New System.Drawing.Point(10, 10)
        Me.BTNVerSolicitud.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNVerSolicitud.Name = "BTNVerSolicitud"
        Me.BTNVerSolicitud.Size = New System.Drawing.Size(104, 38)
        Me.BTNVerSolicitud.TabIndex = 54
        Me.BTNVerSolicitud.Text = "Ver Solicitud"
        Me.BTNVerSolicitud.UseVisualStyleBackColor = True
        '
        'BTNSalir
        '
        Me.BTNSalir.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSalir.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNSalir.Location = New System.Drawing.Point(288, 9)
        Me.BTNSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(74, 39)
        Me.BTNSalir.TabIndex = 53
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Enabled = False
        Me.BTNCancelar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCancelar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNCancelar.Location = New System.Drawing.Point(204, 9)
        Me.BTNCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(76, 38)
        Me.BTNCancelar.TabIndex = 53
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Location = New System.Drawing.Point(418, 406)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(42, 20)
        Me.TextBox1.TabIndex = 53
        Me.TextBox1.Visible = False
        '
        'BTNReporteSolicitudes
        '
        Me.BTNReporteSolicitudes.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNReporteSolicitudes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNReporteSolicitudes.Location = New System.Drawing.Point(509, 128)
        Me.BTNReporteSolicitudes.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNReporteSolicitudes.Name = "BTNReporteSolicitudes"
        Me.BTNReporteSolicitudes.Size = New System.Drawing.Size(96, 50)
        Me.BTNReporteSolicitudes.TabIndex = 56
        Me.BTNReporteSolicitudes.Text = "Reporte de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Solicitudes"
        Me.BTNReporteSolicitudes.UseVisualStyleBackColor = True
        '
        'BTNSolicitudIniciada
        '
        Me.BTNSolicitudIniciada.Enabled = False
        Me.BTNSolicitudIniciada.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSolicitudIniciada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNSolicitudIniciada.Location = New System.Drawing.Point(491, 203)
        Me.BTNSolicitudIniciada.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSolicitudIniciada.Name = "BTNSolicitudIniciada"
        Me.BTNSolicitudIniciada.Size = New System.Drawing.Size(138, 48)
        Me.BTNSolicitudIniciada.TabIndex = 57
        Me.BTNSolicitudIniciada.Text = "Reporte Solicitudes en ""Inicio"""
        Me.BTNSolicitudIniciada.UseVisualStyleBackColor = True
        '
        'BTNSolicitudProceso
        '
        Me.BTNSolicitudProceso.Enabled = False
        Me.BTNSolicitudProceso.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSolicitudProceso.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNSolicitudProceso.Location = New System.Drawing.Point(491, 277)
        Me.BTNSolicitudProceso.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSolicitudProceso.Name = "BTNSolicitudProceso"
        Me.BTNSolicitudProceso.Size = New System.Drawing.Size(138, 48)
        Me.BTNSolicitudProceso.TabIndex = 58
        Me.BTNSolicitudProceso.Text = "Reporte Solicitudes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " en ""Proceso"""
        Me.BTNSolicitudProceso.UseVisualStyleBackColor = True
        '
        'BTNSolicitudFinalizada
        '
        Me.BTNSolicitudFinalizada.Enabled = False
        Me.BTNSolicitudFinalizada.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSolicitudFinalizada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNSolicitudFinalizada.Location = New System.Drawing.Point(491, 345)
        Me.BTNSolicitudFinalizada.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSolicitudFinalizada.Name = "BTNSolicitudFinalizada"
        Me.BTNSolicitudFinalizada.Size = New System.Drawing.Size(138, 54)
        Me.BTNSolicitudFinalizada.TabIndex = 59
        Me.BTNSolicitudFinalizada.Text = "Reporte Solicitudes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ""Finalizadas"""
        Me.BTNSolicitudFinalizada.UseVisualStyleBackColor = True
        '
        'TXTDTPDos
        '
        Me.TXTDTPDos.BackColor = System.Drawing.Color.DarkOrange
        Me.TXTDTPDos.Location = New System.Drawing.Point(518, 12)
        Me.TXTDTPDos.Name = "TXTDTPDos"
        Me.TXTDTPDos.Size = New System.Drawing.Size(42, 20)
        Me.TXTDTPDos.TabIndex = 60
        Me.TXTDTPDos.Visible = False
        '
        'TXTDTPUno
        '
        Me.TXTDTPUno.BackColor = System.Drawing.Color.DarkOrange
        Me.TXTDTPUno.Location = New System.Drawing.Point(387, 112)
        Me.TXTDTPUno.Name = "TXTDTPUno"
        Me.TXTDTPUno.Size = New System.Drawing.Size(42, 20)
        Me.TXTDTPUno.TabIndex = 61
        Me.TXTDTPUno.Visible = False
        '
        'DTPUno
        '
        Me.DTPUno.Location = New System.Drawing.Point(387, 38)
        Me.DTPUno.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.DTPUno.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.DTPUno.Name = "DTPUno"
        Me.DTPUno.Size = New System.Drawing.Size(200, 20)
        Me.DTPUno.TabIndex = 62
        '
        'DTPDos
        '
        Me.DTPDos.Location = New System.Drawing.Point(387, 84)
        Me.DTPDos.Name = "DTPDos"
        Me.DTPDos.Size = New System.Drawing.Size(200, 20)
        Me.DTPDos.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(299, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "DESDE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(299, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "HASTA:"
        '
        'LBLValidar2
        '
        Me.LBLValidar2.AutoSize = True
        Me.LBLValidar2.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidar2.ForeColor = System.Drawing.Color.Red
        Me.LBLValidar2.Location = New System.Drawing.Point(605, 84)
        Me.LBLValidar2.Name = "LBLValidar2"
        Me.LBLValidar2.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidar2.TabIndex = 66
        Me.LBLValidar2.Text = "*"
        '
        'LBLValidar1
        '
        Me.LBLValidar1.AutoSize = True
        Me.LBLValidar1.BackColor = System.Drawing.Color.Transparent
        Me.LBLValidar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValidar1.ForeColor = System.Drawing.Color.Red
        Me.LBLValidar1.Location = New System.Drawing.Point(605, 38)
        Me.LBLValidar1.Name = "LBLValidar1"
        Me.LBLValidar1.Size = New System.Drawing.Size(14, 18)
        Me.LBLValidar1.TabIndex = 67
        Me.LBLValidar1.Text = "*"
        '
        'FSolicitudesConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.ClientSize = New System.Drawing.Size(648, 463)
        Me.Controls.Add(Me.LBLValidar1)
        Me.Controls.Add(Me.LBLValidar2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPDos)
        Me.Controls.Add(Me.DTPUno)
        Me.Controls.Add(Me.TXTDTPUno)
        Me.Controls.Add(Me.TXTDTPDos)
        Me.Controls.Add(Me.BTNSolicitudFinalizada)
        Me.Controls.Add(Me.BTNSolicitudProceso)
        Me.Controls.Add(Me.BTNSolicitudIniciada)
        Me.Controls.Add(Me.BTNReporteSolicitudes)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBPersonasUsuarios)
        Me.Controls.Add(Me.LBLBuscar)
        Me.Controls.Add(Me.TXTBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FSolicitudesConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A - MÓDULO CONSULTA SOLICITUDES"
        Me.GBPersonasUsuarios.ResumeLayout(False)
        CType(Me.DGVConsultaSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBLBuscar As System.Windows.Forms.Label
    Friend WithEvents TXTBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GBPersonasUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents DGVConsultaSolicitudes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNSalir As System.Windows.Forms.Button
    Friend WithEvents BTNVerSolicitud As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents BTNReporteSolicitudes As System.Windows.Forms.Button
    Friend WithEvents BTNSolicitudIniciada As System.Windows.Forms.Button
    Friend WithEvents BTNSolicitudProceso As System.Windows.Forms.Button
    Friend WithEvents BTNSolicitudFinalizada As System.Windows.Forms.Button
    Friend WithEvents TXTDTPDos As System.Windows.Forms.TextBox
    Friend WithEvents TXTDTPUno As System.Windows.Forms.TextBox
    Friend WithEvents DTPUno As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDos As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBLValidar2 As System.Windows.Forms.Label
    Friend WithEvents LBLValidar1 As System.Windows.Forms.Label
End Class
