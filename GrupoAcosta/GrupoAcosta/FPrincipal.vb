Public Class FPrincipal

    'Instruccion que permite comprobar y cargar los privilegios que tiene el usuario que esta iniciando sesion de acuerdo a el rol que posee en el sistema.
    Public Sub cargarVistaRol()
        Dim CadenaSQL As String = ""
        CadenaSQL = "SELECT s_nombre_objeto,b_activo_privilegios FROM v_rol_privilegios WHERE nid_rol='" & FIngreso.nId_rol & "'"
        Using Conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString) 'Se declara la conexion haciendo uso del using
            Conexion.Open() 'Se abre la conexion
            Dim Comando As New Odbc.OdbcCommand(CadenaSQL, Conexion) 'Se declara el comando que se va a ejecutar y se conecta
            Dim reader As Odbc.OdbcDataReader = Comando.ExecuteReader() 'Se ejecuta la lectura de los valores encontrados en la consulta

            Dim NombreMenu As String
            Dim item As ToolStripItem
            Dim Menu As ToolStripMenuItem

            If reader.HasRows Then
                While reader.Read
                    For i = 0 To MSFPrincipal.Items.Count
                        NombreMenu = Trim(reader("s_nombre_objeto"))
                        For Each Menu In MSFPrincipal.Items
                            If Menu.Name = NombreMenu Then
                                CType(Menu, ToolStripMenuItem).Enabled = CBool(reader("b_activo_privilegios"))
                            End If
                            For Each item In Menu.DropDownItems
                                If item.Name = NombreMenu Then
                                    CType(item, ToolStripMenuItem).Enabled = CBool(reader("b_activo_privilegios"))
                                End If
                            Next
                        Next
                    Next
                End While
            End If
            reader.Close()
            Conexion.Close()
        End Using
    End Sub


    Private Sub PersonaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIPersonas.Click
        FPersona.ShowDialog()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FUsuario.ShowDialog()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Dispose()
        FIngreso.TBAlias.Clear()
        FIngreso.TBClave.Clear()
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIDepartamentos.Click
        FDepartamento.ShowDialog()
    End Sub

    Private Sub CargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMICargos.Click
        FCargo.ShowDialog()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIProductos.Click
        FProducto.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FProveedores.ShowDialog()
    End Sub

    Private Sub FPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerFechaHoraActual.Enabled = True
        TSSLUsuario.Text = "Usuario: " & FIngreso.s_Nombre & " | "
        TSSLAlias.Text = "Alias: " & FIngreso.s_Seudonimo & " | "
        TSSLRol.Text = "Rol: " & FIngreso.s_Rol & " | "
    End Sub

    Private Sub TimerHoraActual_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFechaHoraActual.Tick
        TSSLFechaHoraActual.Text = "Fecha/hora actual:  " & Date.Now & " | "
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIProveedores.Click
        FProveedores.ShowDialog()
    End Sub

    Private Sub EstadosDeSolicitudToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIEstadodeSolicitud.Click
        FEstado_Solicitud.ShowDialog()
    End Sub

    'Private Sub MovimientosDeSolicitudToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FMovimiento.ShowDialog()
    'End Sub

    Private Sub EstadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIEstados.Click
        FProvincia.ShowDialog()
    End Sub

    Private Sub MunicipiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIMunicipios.Click
        FMunicipio.ShowDialog()
    End Sub

    Private Sub RolesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIUsuarios.Click
        FUsuario.ShowDialog()
    End Sub

    Private Sub RolesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIRoles.Click
        FRoles.ShowDialog()
    End Sub

    Private Sub CrearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMICrearSolicitudes.Click
        FSolicitudes.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIClientes.Click
        FCliente.ShowDialog()
    End Sub

    Private Sub SolicitudProductoEntranteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIProcesarSolicitudes.Click
        FSolicitudProductos.ShowDialog()
    End Sub

    'Private Sub ProductoEntranteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIProductoEntrante.Click
    '    FProductoEntrante.ShowDialog()
    'End Sub

    Private Sub RespaldoRestauraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIRespaldoRestauracion.Click
        FRespaldoRestaura.ShowDialog()
    End Sub

    Private Sub TSMIConsultarSolicitudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIConsultarSolicitudes.Click
        FSolicitudesConsulta.ShowDialog()
    End Sub

    Private Sub FPrincipal_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        cargarVistaRol()
    End Sub

    'Private Sub PrivilegiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrivilegiosToolStripMenuItem.Click
    '    FPrivilegios.ShowDialog()

    'End Sub

    Private Sub TSMIAcercade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIAcercade.Click
        FAyuda.ShowDialog()
    End Sub

End Class