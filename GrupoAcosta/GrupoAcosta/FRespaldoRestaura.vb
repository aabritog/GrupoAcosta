Public Class FRespaldoRestaura

    Friend RespaldarRestaurar As String = ""

    Private Sub BtRespaldar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRespaldar.Click

        If Len(TBArchivoBackup.Text) = 0 Then
            MsgBox("Debe seleccionar una ubicación para guardar el archivo de respaldo.", MsgBoxStyle.Information)
            BTNExaminar.Focus()
        Else
            RespaldarRestaurar = "Respaldar"
            FEspere.ShowDialog()
        End If
    End Sub

    Private Sub BtExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNExaminar.Click
        If RBRestaurar.Checked = True Then
            OFDSeleccionarArchivo.ShowDialog()
            TBArchivoBackup.Text = OFDSeleccionarArchivo.FileName
        End If
        If RBRespaldo.Checked = True Then
            SFDArchivo.ShowDialog()
            TBArchivoBackup.Text = SFDArchivo.FileName
        End If

    End Sub

    Private Sub Fmantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With OFDSeleccionarArchivo
            .InitialDirectory = "C:\Respaldo" 'Application.StartupPath
            .Multiselect = False
            .Filter = "Archivos de backup (*.backup)|*.backup|Todos los archivos (*.*)|*.*"
            .FilterIndex = 1
            .FileName = ""
            .AddExtension = True
            .DefaultExt = "backup"
            .CheckFileExists = False
            .CheckPathExists = True
        End With
        With SFDArchivo
            .InitialDirectory = "C:\Respaldo" 'Application.StartupPath
            .Filter = "Archivos de backup (*.backup)|*.backup|Todos los archivos (*.*)|*.*"
            .FilterIndex = 1
            .FileName = "GrupoAcosta." & Replace(Date.Today, "/", "-")
            .AddExtension = True
            .DefaultExt = "backup"
            .CheckFileExists = False
            .CheckPathExists = True
        End With
    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click
        Me.Dispose()
    End Sub

    Private Sub BtRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRestaurar.Click
        If Len(TBArchivoBackup.Text) = 0 Then
            MsgBox("Debe seleccionar un archivo para la restauración", MsgBoxStyle.Information)
            BTNExaminar.Focus()
        Else
            RespaldarRestaurar = "Restaurar"
            FEspere.ShowDialog()
        End If

    End Sub

    Private Sub FRespaldoRestaura_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub RBRespaldo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBRespaldo.CheckedChanged
        If RBRespaldo.Checked = True Then
            BTNExaminar.Enabled = True
            BTNRespaldar.Enabled = True
        Else
            BTNExaminar.Enabled = False
            BTNRespaldar.Enabled = False
        End If
    End Sub

    Private Sub RBRestaurar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBRestaurar.CheckedChanged
        If RBRestaurar.Checked = True Then
            BTNExaminar.Enabled = True
            BTNRestaurar.Enabled = True
        Else
            BTNExaminar.Enabled = False
            BTNRestaurar.Enabled = False
        End If
    End Sub
End Class