Public Class FEspere

    Private Sub FEspere_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub

    Private Sub FEspere_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        If FRespaldoRestaura.RespaldarRestaurar = "Restaurar" Then
            Dim host As String = "localhost"
            Dim puerto As String = "5433"
            Dim bd As String = "GRUPOACOSTA"
            Dim Ruta As String = Application.StartupPath & "\Restaura.bat"
            Ruta = Chr(34) & Ruta & Chr(34)
            Ruta &= " " & host & " " & puerto & "  " & bd & " " & FRespaldoRestaura.TBArchivoBackup.Text.Trim
            Try
                Shell(Ruta, AppWinStyle.Hide, True)
                FRespaldoRestaura.TBArchivoBackup.Clear()
                FRespaldoRestaura.RBRestaurar.Checked = False
                MsgBox("Restauración del sistema realizada exitosamente...", MsgBoxStyle.Information)
            Catch
                MsgBox("Ocurrio un error al realizar la restauración del sistema...", MsgBoxStyle.Information)
            End Try
            Me.Close()
        End If

        If FRespaldoRestaura.RespaldarRestaurar = "Respaldar" Then
            Dim host As String = "localhost"
            Dim puerto As String = "5433"
            Dim bd As String = "GRUPOACOSTA"
            Dim password As String = "root"


            Dim Ruta As String = Application.StartupPath & "\Respaldo.bat"
            Ruta = Chr(34) & Ruta & Chr(34)
            Ruta &= " " & host & " " & puerto & " " & FRespaldoRestaura.TBArchivoBackup.Text.Trim & " " & bd
            Try
                Shell(Ruta, AppWinStyle.Hide, True)
                FRespaldoRestaura.BTNRespaldar.Enabled = False
                FRespaldoRestaura.TBArchivoBackup.Clear()
                FRespaldoRestaura.RBRespaldo.Checked = False
                MsgBox("Respaldo del sistema realizado exitosamente...", MsgBoxStyle.Information)
            Catch
                MsgBox("Ocurrio un error al realizar el respaldo del sistema...", MsgBoxStyle.Information)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub FEspere_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class