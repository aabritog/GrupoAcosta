Public Class FPrincipal

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

    Private Sub MovimientosDeSolicitudToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIMovimientosdeSolicitud.Click
        FMovimiento.ShowDialog()
    End Sub

    Private Sub EstadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIEstados.Click
        FProvincia.ShowDialog()
    End Sub

    Private Sub MunicipiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIMunicipios.Click
        FMunicipio.ShowDialog()
    End Sub

    Private Sub SolicitudesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMISolicitudes.Click

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

    Private Sub ProductoEntranteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIProductoEntrante.Click
        FProductoEntrante.ShowDialog()
    End Sub

    Private Sub RespaldoRestauraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIRespaldoRestauracion.Click
        FRespaldoRestaura.ShowDialog()
    End Sub

    Private Sub TSMIConsultarSolicitudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIConsultarSolicitudes.Click
        FSolicitudesConsulta.ShowDialog()
    End Sub
End Class