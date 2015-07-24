<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.SSFPrincipal = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLFechaHoraActual = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MSFPrincipal = New System.Windows.Forms.MenuStrip()
        Me.PersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitudesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosDeSolicitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosDeSolicitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MunicipiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NivelesDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerFechaHoraActual = New System.Windows.Forms.Timer(Me.components)
        Me.SSFPrincipal.SuspendLayout()
        Me.MSFPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'SSFPrincipal
        '
        Me.SSFPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.TSSLFechaHoraActual, Me.ToolStripStatusLabel5})
        Me.SSFPrincipal.Location = New System.Drawing.Point(0, 726)
        Me.SSFPrincipal.Name = "SSFPrincipal"
        Me.SSFPrincipal.Size = New System.Drawing.Size(1350, 22)
        Me.SSFPrincipal.TabIndex = 0
        Me.SSFPrincipal.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(106, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario: Ninguno |"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(91, 17)
        Me.ToolStripStatusLabel2.Text = "Alias: Ninguno |"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(83, 17)
        Me.ToolStripStatusLabel3.Text = "Rol: Ninguno |"
        '
        'TSSLFechaHoraActual
        '
        Me.TSSLFechaHoraActual.Name = "TSSLFechaHoraActual"
        Me.TSSLFechaHoraActual.Size = New System.Drawing.Size(87, 17)
        Me.TSSLFechaHoraActual.Text = "Hora: 00:00:00 |"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(203, 17)
        Me.ToolStripStatusLabel5.Text = "GRUPO ACOSTA C.A - RIF J-000000-1"
        '
        'MSFPrincipal
        '
        Me.MSFPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonaToolStripMenuItem, Me.ProveedoresToolStripMenuItem1, Me.SolicitudesToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MSFPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MSFPrincipal.Name = "MSFPrincipal"
        Me.MSFPrincipal.Size = New System.Drawing.Size(1350, 24)
        Me.MSFPrincipal.TabIndex = 1
        Me.MSFPrincipal.Text = "Configuración"
        '
        'PersonaToolStripMenuItem
        '
        Me.PersonaToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonaToolStripMenuItem.Name = "PersonaToolStripMenuItem"
        Me.PersonaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PersonaToolStripMenuItem.Text = "Personas"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(81, 20)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'SolicitudesToolStripMenuItem
        '
        Me.SolicitudesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearToolStripMenuItem, Me.ConsultarToolStripMenuItem})
        Me.SolicitudesToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitudesToolStripMenuItem.Name = "SolicitudesToolStripMenuItem"
        Me.SolicitudesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.SolicitudesToolStripMenuItem.Text = "Solicitudes"
        '
        'CrearToolStripMenuItem
        '
        Me.CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        Me.CrearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CrearToolStripMenuItem.Text = "Crear"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.NivelesDeUsuarioToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentosToolStripMenuItem, Me.CargosToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.EstadosDeSolicitudToolStripMenuItem, Me.MovimientosDeSolicitudToolStripMenuItem, Me.EstadosToolStripMenuItem, Me.MunicipiosToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MantenimientoToolStripMenuItem.Text = "Tablas del sistema"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'CargosToolStripMenuItem
        '
        Me.CargosToolStripMenuItem.Name = "CargosToolStripMenuItem"
        Me.CargosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.CargosToolStripMenuItem.Text = "Cargos"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ProductoToolStripMenuItem.Text = "Productos"
        '
        'EstadosDeSolicitudToolStripMenuItem
        '
        Me.EstadosDeSolicitudToolStripMenuItem.Name = "EstadosDeSolicitudToolStripMenuItem"
        Me.EstadosDeSolicitudToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EstadosDeSolicitudToolStripMenuItem.Text = "Estados de solicitud"
        '
        'MovimientosDeSolicitudToolStripMenuItem
        '
        Me.MovimientosDeSolicitudToolStripMenuItem.Name = "MovimientosDeSolicitudToolStripMenuItem"
        Me.MovimientosDeSolicitudToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.MovimientosDeSolicitudToolStripMenuItem.Text = "Movimientos de solicitud"
        '
        'EstadosToolStripMenuItem
        '
        Me.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem"
        Me.EstadosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EstadosToolStripMenuItem.Text = "Estados"
        '
        'MunicipiosToolStripMenuItem
        '
        Me.MunicipiosToolStripMenuItem.Name = "MunicipiosToolStripMenuItem"
        Me.MunicipiosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.MunicipiosToolStripMenuItem.Text = "Municipios"
        '
        'NivelesDeUsuarioToolStripMenuItem
        '
        Me.NivelesDeUsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RolesToolStripMenuItem, Me.RolesToolStripMenuItem1})
        Me.NivelesDeUsuarioToolStripMenuItem.Name = "NivelesDeUsuarioToolStripMenuItem"
        Me.NivelesDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.NivelesDeUsuarioToolStripMenuItem.Text = "Niveles de usuario"
        '
        'RolesToolStripMenuItem
        '
        Me.RolesToolStripMenuItem.Name = "RolesToolStripMenuItem"
        Me.RolesToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.RolesToolStripMenuItem.Text = "Usuarios"
        '
        'RolesToolStripMenuItem1
        '
        Me.RolesToolStripMenuItem1.Name = "RolesToolStripMenuItem1"
        Me.RolesToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.RolesToolStripMenuItem1.Text = "Roles"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'TimerFechaHoraActual
        '
        '
        'FPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 748)
        Me.Controls.Add(Me.SSFPrincipal)
        Me.Controls.Add(Me.MSFPrincipal)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MSFPrincipal
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA C.A"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SSFPrincipal.ResumeLayout(False)
        Me.SSFPrincipal.PerformLayout()
        Me.MSFPrincipal.ResumeLayout(False)
        Me.MSFPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SSFPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents MSFPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents PersonaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLFechaHoraActual As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerFechaHoraActual As System.Windows.Forms.Timer
    Friend WithEvents ProveedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadosDeSolicitudToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosDeSolicitudToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MunicipiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolicitudesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NivelesDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RolesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RolesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
