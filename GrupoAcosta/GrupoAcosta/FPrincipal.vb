Public Class FPrincipal

    Private Sub PersonaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonaToolStripMenuItem.Click
        FPersona.ShowDialog()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click
        FUsuario.ShowDialog()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Close()
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

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        FProveedores.ShowDialog()
    End Sub

    Private Sub FPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerFechaHoraActual.Enabled = True
    End Sub

    Private Sub TimerHoraActual_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFechaHoraActual.Tick
        TSSLFechaHoraActual.Text = "| Fecha/hora actual:  " & Date.Now & " | "
    End Sub
End Class