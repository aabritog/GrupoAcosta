﻿Public Class FPrincipal

    Private Sub PersonaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonaToolStripMenuItem.Click
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

    Private Sub DepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem.Click
        FDepartamento.ShowDialog()
    End Sub

    Private Sub CargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargosToolStripMenuItem.Click
        FCargo.ShowDialog()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem.Click
        FDepartamento.ShowDialog()
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

    Private Sub ProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        FProveedores.ShowDialog()
    End Sub

    Private Sub EstadosDeSolicitudToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadosDeSolicitudToolStripMenuItem.Click
        FEstado_Solicitud.ShowDialog()
    End Sub

    Private Sub MovimientosDeSolicitudToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeSolicitudToolStripMenuItem.Click
        FMovimiento.ShowDialog()
    End Sub

    Private Sub EstadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadosToolStripMenuItem.Click
        FProvincia.ShowDialog()
    End Sub

    Private Sub MunicipiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MunicipiosToolStripMenuItem.Click
        FMunicipio.ShowDialog()
    End Sub

    Private Sub SolicitudesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudesToolStripMenuItem.Click

    End Sub

    Private Sub RolesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RolesToolStripMenuItem.Click
        FUsuario.ShowDialog()
    End Sub

    Private Sub RolesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RolesToolStripMenuItem1.Click
        FRol.ShowDialog()
    End Sub

    Private Sub CrearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearToolStripMenuItem.Click
        FSolicitudes.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        FCliente.ShowDialog()
    End Sub
End Class