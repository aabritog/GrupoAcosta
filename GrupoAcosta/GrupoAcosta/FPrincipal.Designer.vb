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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPrincipal))
        Me.SSFPrincipal = New System.Windows.Forms.StatusStrip()
        Me.TSSLUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLAlias = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLRol = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLFechaHoraActual = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MSFPrincipal = New System.Windows.Forms.MenuStrip()
        Me.TSMIPersonas = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMISolicitudes = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMICrearSolicitudes = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIConsultarSolicitudes = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIProcesarSolicitudes = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIConfiguracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMITablasdelSistema = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIDepartamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMICargos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIEstadodeSolicitud = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIMovimientosdeSolicitud = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIEstados = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIMunicipios = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIProductoEntrante = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMINivelesdeUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRoles = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMISistema = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRespaldoRestauracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIManualdeUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIAcercade = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.SSFPrincipal.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
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
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(359, 27)
        Me.ToolStripStatusLabel5.Text = "GRUPO ACOSTA  MARINE SERVICES C.A - RIF J-30998360-1"
        '
        'MSFPrincipal
        '
        Me.MSFPrincipal.BackColor = System.Drawing.Color.Olive
        Me.MSFPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIPersonas, Me.TSMIProveedores, Me.TSMIClientes, Me.TSMISolicitudes, Me.TSMIConfiguracion, Me.TSMIAyuda, Me.CerrarSesiónToolStripMenuItem})
        Me.MSFPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MSFPrincipal.Name = "MSFPrincipal"
        Me.MSFPrincipal.Padding = New System.Windows.Forms.Padding(7, 6, 0, 4)
        Me.MSFPrincipal.Size = New System.Drawing.Size(1020, 34)
        Me.MSFPrincipal.TabIndex = 1
        Me.MSFPrincipal.Text = "Configuración"
        '
        'TSMIPersonas
        '
        Me.TSMIPersonas.BackColor = System.Drawing.Color.Olive
        Me.TSMIPersonas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMIPersonas.ForeColor = System.Drawing.Color.White
        Me.TSMIPersonas.Name = "TSMIPersonas"
        Me.TSMIPersonas.Size = New System.Drawing.Size(79, 24)
        Me.TSMIPersonas.Text = "Personas"
        '
        'TSMIProveedores
        '
        Me.TSMIProveedores.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMIProveedores.ForeColor = System.Drawing.Color.White
        Me.TSMIProveedores.Name = "TSMIProveedores"
        Me.TSMIProveedores.Size = New System.Drawing.Size(99, 24)
        Me.TSMIProveedores.Text = "Proveedores"
        '
        'TSMIClientes
        '
        Me.TSMIClientes.BackColor = System.Drawing.Color.Olive
        Me.TSMIClientes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMIClientes.ForeColor = System.Drawing.Color.White
        Me.TSMIClientes.Name = "TSMIClientes"
        Me.TSMIClientes.Size = New System.Drawing.Size(71, 24)
        Me.TSMIClientes.Text = "Clientes"
        '
        'TSMISolicitudes
        '
        Me.TSMISolicitudes.BackColor = System.Drawing.Color.Olive
        Me.TSMISolicitudes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMICrearSolicitudes, Me.TSMIConsultarSolicitudes, Me.TSMIProcesarSolicitudes})
        Me.TSMISolicitudes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMISolicitudes.ForeColor = System.Drawing.Color.White
        Me.TSMISolicitudes.Name = "TSMISolicitudes"
        Me.TSMISolicitudes.Size = New System.Drawing.Size(91, 24)
        Me.TSMISolicitudes.Text = "Solicitudes"
        '
        'TSMICrearSolicitudes
        '
        Me.TSMICrearSolicitudes.BackColor = System.Drawing.Color.Olive
        Me.TSMICrearSolicitudes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMICrearSolicitudes.ForeColor = System.Drawing.Color.White
        Me.TSMICrearSolicitudes.Name = "TSMICrearSolicitudes"
        Me.TSMICrearSolicitudes.Size = New System.Drawing.Size(212, 24)
        Me.TSMICrearSolicitudes.Text = "Crear Solicitudes"
        '
        'TSMIConsultarSolicitudes
        '
        Me.TSMIConsultarSolicitudes.BackColor = System.Drawing.Color.Olive
        Me.TSMIConsultarSolicitudes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMIConsultarSolicitudes.ForeColor = System.Drawing.Color.White
        Me.TSMIConsultarSolicitudes.Name = "TSMIConsultarSolicitudes"
        Me.TSMIConsultarSolicitudes.Size = New System.Drawing.Size(212, 24)
        Me.TSMIConsultarSolicitudes.Text = "Consultar Solicitudes"
        '
        'TSMIProcesarSolicitudes
        '
        Me.TSMIProcesarSolicitudes.BackColor = System.Drawing.Color.Olive
        Me.TSMIProcesarSolicitudes.ForeColor = System.Drawing.Color.White
        Me.TSMIProcesarSolicitudes.Name = "TSMIProcesarSolicitudes"
        Me.TSMIProcesarSolicitudes.Size = New System.Drawing.Size(212, 24)
        Me.TSMIProcesarSolicitudes.Text = "Procesar Solicitudes"
        '
        'TSMIConfiguracion
        '
        Me.TSMIConfiguracion.BackColor = System.Drawing.Color.Olive
        Me.TSMIConfiguracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMITablasdelSistema, Me.TSMINivelesdeUsuario, Me.TSMISistema})
        Me.TSMIConfiguracion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMIConfiguracion.ForeColor = System.Drawing.Color.White
        Me.TSMIConfiguracion.Name = "TSMIConfiguracion"
        Me.TSMIConfiguracion.Size = New System.Drawing.Size(109, 24)
        Me.TSMIConfiguracion.Text = "Configuración"
        '
        'TSMITablasdelSistema
        '
        Me.TSMITablasdelSistema.BackColor = System.Drawing.Color.Olive
        Me.TSMITablasdelSistema.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIDepartamentos, Me.TSMICargos, Me.TSMIProductos, Me.TSMIEstadodeSolicitud, Me.TSMIMovimientosdeSolicitud, Me.TSMIEstados, Me.TSMIMunicipios, Me.TSMIProductoEntrante})
        Me.TSMITablasdelSistema.ForeColor = System.Drawing.Color.White
        Me.TSMITablasdelSistema.Name = "TSMITablasdelSistema"
        Me.TSMITablasdelSistema.Size = New System.Drawing.Size(196, 24)
        Me.TSMITablasdelSistema.Text = "Tablas del Sistema"
        '
        'TSMIDepartamentos
        '
        Me.TSMIDepartamentos.BackColor = System.Drawing.Color.White
        Me.TSMIDepartamentos.ForeColor = System.Drawing.Color.Olive
        Me.TSMIDepartamentos.Name = "TSMIDepartamentos"
        Me.TSMIDepartamentos.Size = New System.Drawing.Size(237, 24)
        Me.TSMIDepartamentos.Text = "Departamentos"
        '
        'TSMICargos
        '
        Me.TSMICargos.BackColor = System.Drawing.Color.White
        Me.TSMICargos.ForeColor = System.Drawing.Color.Olive
        Me.TSMICargos.Name = "TSMICargos"
        Me.TSMICargos.Size = New System.Drawing.Size(237, 24)
        Me.TSMICargos.Text = "Cargos"
        '
        'TSMIProductos
        '
        Me.TSMIProductos.BackColor = System.Drawing.Color.White
        Me.TSMIProductos.ForeColor = System.Drawing.Color.Olive
        Me.TSMIProductos.Name = "TSMIProductos"
        Me.TSMIProductos.Size = New System.Drawing.Size(237, 24)
        Me.TSMIProductos.Text = "Productos"
        '
        'TSMIEstadodeSolicitud
        '
        Me.TSMIEstadodeSolicitud.BackColor = System.Drawing.Color.White
        Me.TSMIEstadodeSolicitud.ForeColor = System.Drawing.Color.Olive
        Me.TSMIEstadodeSolicitud.Name = "TSMIEstadodeSolicitud"
        Me.TSMIEstadodeSolicitud.Size = New System.Drawing.Size(237, 24)
        Me.TSMIEstadodeSolicitud.Text = "Estados de Solicitud"
        '
        'TSMIMovimientosdeSolicitud
        '
        Me.TSMIMovimientosdeSolicitud.BackColor = System.Drawing.Color.White
        Me.TSMIMovimientosdeSolicitud.ForeColor = System.Drawing.Color.Olive
        Me.TSMIMovimientosdeSolicitud.Name = "TSMIMovimientosdeSolicitud"
        Me.TSMIMovimientosdeSolicitud.Size = New System.Drawing.Size(237, 24)
        Me.TSMIMovimientosdeSolicitud.Text = "Movimientos de Solicitud"
        '
        'TSMIEstados
        '
        Me.TSMIEstados.BackColor = System.Drawing.Color.White
        Me.TSMIEstados.ForeColor = System.Drawing.Color.Olive
        Me.TSMIEstados.Name = "TSMIEstados"
        Me.TSMIEstados.Size = New System.Drawing.Size(237, 24)
        Me.TSMIEstados.Text = "Estados"
        '
        'TSMIMunicipios
        '
        Me.TSMIMunicipios.BackColor = System.Drawing.Color.White
        Me.TSMIMunicipios.ForeColor = System.Drawing.Color.Olive
        Me.TSMIMunicipios.Name = "TSMIMunicipios"
        Me.TSMIMunicipios.Size = New System.Drawing.Size(237, 24)
        Me.TSMIMunicipios.Text = "Municipios"
        '
        'TSMIProductoEntrante
        '
        Me.TSMIProductoEntrante.ForeColor = System.Drawing.Color.Olive
        Me.TSMIProductoEntrante.Name = "TSMIProductoEntrante"
        Me.TSMIProductoEntrante.Size = New System.Drawing.Size(237, 24)
        Me.TSMIProductoEntrante.Text = "Producto Entrante"
        '
        'TSMINivelesdeUsuario
        '
        Me.TSMINivelesdeUsuario.BackColor = System.Drawing.Color.Olive
        Me.TSMINivelesdeUsuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIUsuarios, Me.TSMIRoles})
        Me.TSMINivelesdeUsuario.ForeColor = System.Drawing.Color.White
        Me.TSMINivelesdeUsuario.Name = "TSMINivelesdeUsuario"
        Me.TSMINivelesdeUsuario.Size = New System.Drawing.Size(196, 24)
        Me.TSMINivelesdeUsuario.Text = "Niveles de Usuario"
        '
        'TSMIUsuarios
        '
        Me.TSMIUsuarios.BackColor = System.Drawing.Color.White
        Me.TSMIUsuarios.ForeColor = System.Drawing.Color.Olive
        Me.TSMIUsuarios.Name = "TSMIUsuarios"
        Me.TSMIUsuarios.Size = New System.Drawing.Size(133, 24)
        Me.TSMIUsuarios.Text = "Usuarios"
        '
        'TSMIRoles
        '
        Me.TSMIRoles.BackColor = System.Drawing.Color.White
        Me.TSMIRoles.ForeColor = System.Drawing.Color.Olive
        Me.TSMIRoles.Name = "TSMIRoles"
        Me.TSMIRoles.Size = New System.Drawing.Size(133, 24)
        Me.TSMIRoles.Text = "Roles"
        '
        'TSMISistema
        '
        Me.TSMISistema.BackColor = System.Drawing.Color.Olive
        Me.TSMISistema.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIRespaldoRestauracion})
        Me.TSMISistema.ForeColor = System.Drawing.Color.White
        Me.TSMISistema.Name = "TSMISistema"
        Me.TSMISistema.Size = New System.Drawing.Size(196, 24)
        Me.TSMISistema.Text = "Sistema"
        '
        'TSMIRespaldoRestauracion
        '
        Me.TSMIRespaldoRestauracion.ForeColor = System.Drawing.Color.Olive
        Me.TSMIRespaldoRestauracion.Name = "TSMIRespaldoRestauracion"
        Me.TSMIRespaldoRestauracion.Size = New System.Drawing.Size(221, 24)
        Me.TSMIRespaldoRestauracion.Text = "Respaldo/Restauración"
        '
        'TSMIAyuda
        '
        Me.TSMIAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIManualdeUsuario, Me.TSMIAcercade})
        Me.TSMIAyuda.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMIAyuda.ForeColor = System.Drawing.Color.White
        Me.TSMIAyuda.Name = "TSMIAyuda"
        Me.TSMIAyuda.Size = New System.Drawing.Size(60, 24)
        Me.TSMIAyuda.Text = "Ayuda"
        '
        'TSMIManualdeUsuario
        '
        Me.TSMIManualdeUsuario.BackColor = System.Drawing.Color.Olive
        Me.TSMIManualdeUsuario.ForeColor = System.Drawing.Color.White
        Me.TSMIManualdeUsuario.Name = "TSMIManualdeUsuario"
        Me.TSMIManualdeUsuario.Size = New System.Drawing.Size(194, 24)
        Me.TSMIManualdeUsuario.Text = "Manual de Usuario"
        '
        'TSMIAcercade
        '
        Me.TSMIAcercade.BackColor = System.Drawing.Color.Olive
        Me.TSMIAcercade.ForeColor = System.Drawing.Color.White
        Me.TSMIAcercade.Name = "TSMIAcercade"
        Me.TSMIAcercade.Size = New System.Drawing.Size(194, 24)
        Me.TSMIAcercade.Text = "Acerca de..."
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
        Me.PictureBox4.Size = New System.Drawing.Size(1594, 2)
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(0, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1594, 1)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox3.Location = New System.Drawing.Point(0, 34)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1594, 3)
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'FPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Olive
        Me.BackgroundImage = Global.GrupoAcosta.My.Resources.Resources.LOGO_actual_12_ANIVERSARIO_GAMSCA_hoy1
        Me.ClientSize = New System.Drawing.Size(1020, 740)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.SSFPrincipal)
        Me.Controls.Add(Me.MSFPrincipal)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Olive
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents TSMIPersonas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIConfiguracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSSLUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLAlias As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLRol As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLFechaHoraActual As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSMITablasdelSistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIDepartamentos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMICargos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerFechaHoraActual As System.Windows.Forms.Timer
    Friend WithEvents TSMIProveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIEstadodeSolicitud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIMovimientosdeSolicitud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIEstados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIMunicipios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMISolicitudes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMINivelesdeUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRoles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMICrearSolicitudes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIConsultarSolicitudes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TSMIClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIProcesarSolicitudes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIProductoEntrante As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMISistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRespaldoRestauracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIManualdeUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIAcercade As System.Windows.Forms.ToolStripMenuItem
End Class
