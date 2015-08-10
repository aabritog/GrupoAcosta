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
        Me.TSSLUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLAlias = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLRol = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLFechaHoraActual = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MSFPrincipal = New System.Windows.Forms.MenuStrip()
        Me.PersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitudesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitudProductoEntranteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SSFPrincipal.SuspendLayout()
        Me.MSFPrincipal.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SSFPrincipal
        '
        Me.SSFPrincipal.BackColor = System.Drawing.Color.White
        Me.SSFPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSLUsuario, Me.TSSLAlias, Me.TSSLRol, Me.TSSLFechaHoraActual, Me.ToolStripStatusLabel5})
        Me.SSFPrincipal.Location = New System.Drawing.Point(0, 708)
        Me.SSFPrincipal.Name = "SSFPrincipal"
        Me.SSFPrincipal.Size = New System.Drawing.Size(1020, 32)
        Me.SSFPrincipal.TabIndex = 0
        Me.SSFPrincipal.Text = "StatusStrip1"
        '
        'TSSLUsuario
        '
        Me.TSSLUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSLUsuario.Name = "TSSLUsuario"
        Me.TSSLUsuario.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.TSSLUsuario.Size = New System.Drawing.Size(122, 27)
        Me.TSSLUsuario.Text = "Usuario: Ninguno |"
        '
        'TSSLAlias
        '
        Me.TSSLAlias.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSLAlias.Name = "TSSLAlias"
        Me.TSSLAlias.Size = New System.Drawing.Size(104, 27)
        Me.TSSLAlias.Text = "Alias: Ninguno |"
        '
        'TSSLRol
        '
        Me.TSSLRol.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSLRol.Name = "TSSLRol"
        Me.TSSLRol.Size = New System.Drawing.Size(95, 27)
        Me.TSSLRol.Text = "Rol: Ninguno |"
        '
        'TSSLFechaHoraActual
        '
        Me.TSSLFechaHoraActual.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSLFechaHoraActual.Name = "TSSLFechaHoraActual"
        Me.TSSLFechaHoraActual.Size = New System.Drawing.Size(101, 27)
        Me.TSSLFechaHoraActual.Text = "Hora: 00:00:00 |"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(345, 27)
        Me.ToolStripStatusLabel5.Text = "GRUPO ACOSTA  MARINE SERVICES C.A - RIF J-000000-1"
        '
        'MSFPrincipal
        '
        Me.MSFPrincipal.BackColor = System.Drawing.Color.Olive
        Me.MSFPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonaToolStripMenuItem, Me.ProveedoresToolStripMenuItem1, Me.ClientesToolStripMenuItem, Me.SolicitudesToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MSFPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MSFPrincipal.Name = "MSFPrincipal"
        Me.MSFPrincipal.Padding = New System.Windows.Forms.Padding(6, 6, 0, 4)
        Me.MSFPrincipal.Size = New System.Drawing.Size(1020, 34)
        Me.MSFPrincipal.TabIndex = 1
        Me.MSFPrincipal.Text = "Configuración"
        '
        'PersonaToolStripMenuItem
        '
        Me.PersonaToolStripMenuItem.BackColor = System.Drawing.Color.Olive
        Me.PersonaToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PersonaToolStripMenuItem.Name = "PersonaToolStripMenuItem"
        Me.PersonaToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.PersonaToolStripMenuItem.Text = "Personas"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedoresToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(99, 24)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.Olive
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'SolicitudesToolStripMenuItem
        '
        Me.SolicitudesToolStripMenuItem.BackColor = System.Drawing.Color.Olive
        Me.SolicitudesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SolicitudProductoEntranteToolStripMenuItem})
        Me.SolicitudesToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitudesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SolicitudesToolStripMenuItem.Name = "SolicitudesToolStripMenuItem"
        Me.SolicitudesToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.SolicitudesToolStripMenuItem.Text = "Solicitudes"
        '
        'CrearToolStripMenuItem
        '
        Me.CrearToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CrearToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrearToolStripMenuItem.ForeColor = System.Drawing.Color.Olive
        Me.CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        Me.CrearToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.CrearToolStripMenuItem.Text = "Crear"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ConsultarToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultarToolStripMenuItem.ForeColor = System.Drawing.Color.Olive
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'SolicitudProductoEntranteToolStripMenuItem
        '
        Me.SolicitudProductoEntranteToolStripMenuItem.ForeColor = System.Drawing.Color.Olive
        Me.SolicitudProductoEntranteToolStripMenuItem.Name = "SolicitudProductoEntranteToolStripMenuItem"
        Me.SolicitudProductoEntranteToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.SolicitudProductoEntranteToolStripMenuItem.Text = "Solicitud-Producto Entrante"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.BackColor = System.Drawing.Color.Olive
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.NivelesDeUsuarioToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguraciónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.BackColor = System.Drawing.Color.Olive
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentosToolStripMenuItem, Me.CargosToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.EstadosDeSolicitudToolStripMenuItem, Me.MovimientosDeSolicitudToolStripMenuItem, Me.EstadosToolStripMenuItem, Me.MunicipiosToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.MantenimientoToolStripMenuItem.Text = "Tablas del sistema"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.DepartamentosToolStripMenuItem.ForeColor = System.Drawing.Color.Olive
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(237, 24)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'CargosToolStripMenuItem
        '
        Me.CargosToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CargosToolStripMenuItem.ForeColor = System.Drawing.Color.Olive
        Me.CargosToolStripMenuItem.Name = "CargosToolStripMenuItem"
        Me.CargosToolStripMenuItem.Size = New System.Drawing.Size(237, 24)
        Me.CargosToolStripMenuItem.Text = "Cargos"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ProductoToolStripMenuItem.ForeColor = System.Drawing.Color.Olive
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(237, 24)
        Me.ProductoToolStripMenuItem.Text = "Productos"
        '
        'EstadosDeSolicitudToolStripMenuItem
        '
        Me.EstadosDeSolicitudToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.EstadosDeSolicitudToolStripMenuItem.ForeColor = System.Drawing.Color.Olive
        Me.EstadosDeSolicitudToolStripMenuItem.Name = "EstadosDeSolicitudToolStripMenuItem"
        Me.EstadosDeSolicitudToolStripMenuItem.Size = New System.Drawing.Size(237, 24)
        Me.EstadosDeSolicitudToolStripMenuItem.Text = "Estados de Solicitud"
        '
        'MovimientosDeSolicitudToolStripMenuItem
        '
        Me.MovimientosDeSolicitudToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.MovimientosDeSolicitudToolStripMenuItem.ForeColor = System.Drawing.Color.Olive
        Me.MovimientosDeSolicitudToolStripMenuItem.Name = "MovimientosDeSolicitudToolStripMenuItem"
        Me.MovimientosDeSolicitudToolStripMenuItem.Size = New System.Drawing.Size(237, 24)
        Me.MovimientosDeSolicitudToolStripMenuItem.Text = "Movimientos de Solicitud"
        '
        'EstadosToolStripMenuItem
        '
        Me.EstadosToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.EstadosToolStripMenuItem.ForeColor = System.Drawing.Color.Olive
        Me.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem"
        Me.EstadosToolStripMenuItem.Size = New System.Drawing.Size(237, 24)
        Me.EstadosToolStripMenuItem.Text = "Estados"
        '
        'MunicipiosToolStripMenuItem
        '
        Me.MunicipiosToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.MunicipiosToolStripMenuItem.ForeColor = System.Drawing.Color.Olive
        Me.MunicipiosToolStripMenuItem.Name = "MunicipiosToolStripMenuItem"
        Me.MunicipiosToolStripMenuItem.Size = New System.Drawing.Size(237, 24)
        Me.MunicipiosToolStripMenuItem.Text = "Municipios"
        '
        'NivelesDeUsuarioToolStripMenuItem
        '
        Me.NivelesDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.Olive
        Me.NivelesDeUsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RolesToolStripMenuItem, Me.RolesToolStripMenuItem1})
        Me.NivelesDeUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NivelesDeUsuarioToolStripMenuItem.Name = "NivelesDeUsuarioToolStripMenuItem"
        Me.NivelesDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.NivelesDeUsuarioToolStripMenuItem.Text = "Niveles de Usuario"
        '
        'RolesToolStripMenuItem
        '
        Me.RolesToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.RolesToolStripMenuItem.Name = "RolesToolStripMenuItem"
        Me.RolesToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.RolesToolStripMenuItem.Text = "Usuarios"
        '
        'RolesToolStripMenuItem1
        '
        Me.RolesToolStripMenuItem1.BackColor = System.Drawing.Color.White
        Me.RolesToolStripMenuItem1.Name = "RolesToolStripMenuItem1"
        Me.RolesToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.RolesToolStripMenuItem1.Text = "Roles"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'TimerFechaHoraActual
        '
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox4.Location = New System.Drawing.Point(0, 674)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1366, 2)
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(0, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1366, 1)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox3.Location = New System.Drawing.Point(0, 34)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1366, 3)
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'FPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.ClientSize = New System.Drawing.Size(1020, 740)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.SSFPrincipal)
        Me.Controls.Add(Me.MSFPrincipal)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MSFPrincipal
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPO ACOSTA MARINE SERVICES C.A"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SSFPrincipal.ResumeLayout(False)
        Me.SSFPrincipal.PerformLayout()
        Me.MSFPrincipal.ResumeLayout(False)
        Me.MSFPrincipal.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SSFPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents MSFPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents PersonaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSSLUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLAlias As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLRol As System.Windows.Forms.ToolStripStatusLabel
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
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolicitudProductoEntranteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
