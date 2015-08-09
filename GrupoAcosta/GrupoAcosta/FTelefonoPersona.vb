Public Class FTelefonoPersona

    'Se declara variable de tipo clase para el manejo de funciones genericas
    Dim objCGenerica As CGenerica = New CGenerica


    'Función que permite cargar el DataGridView que muestra la información de las personas.
    Private Sub cargarDGVTelefono()

        Dim sCadenaSQL As String = "select t.nid,t.stelefono,t.nid_persona from telefono_persona t inner join persona p on t.nid_persona = p.nid where nid_persona = " & FPersona.DGVPersona.CurrentRow.Cells("nid").Value & ""

        Dim dtDGVTelefono As New DataTable
        Dim bsDGVTelefono As New BindingSource
        Dim BCDGVTelefono As New DataGridViewButtonColumn()

        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVTelefono, bsDGVTelefono)


        With DGVTelefono
            .RowHeadersVisible = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            '.MultiSelect = False
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            .DataSource = bsDGVTelefono
            .ClearSelection()

        End With

        With DGVTelefono.Columns("nid")
            .Visible = False
            .HeaderText = "NID"
            .Width = "90"
            .DisplayIndex = "0"

        End With
        With DGVTelefono.Columns("stelefono")
            .HeaderText = "Teléfonos registrados"
            .Width = "237"
            .DisplayIndex = "1"
        End With

        With DGVTelefono.Columns("nid_persona")
            .Visible = False
            .HeaderText = "Id Persona"
            .Width = "180"
            .DisplayIndex = "2"
        End With
    End Sub

    Private Sub TXTTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTTelefono.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTTelefono, LBValidarTelefono)
        DGVTelefono.ClearSelection()
    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click

        Dim sSQLAddtelefono_persona As String

        If FPersona.nAction = 1 Then

            If Len(TXTTelefono.Text) = 0 Then
                MsgBox("Ingrese el teléfono.", MsgBoxStyle.Information)
                TXTTelefono.Focus()
                Exit Sub
            ElseIf Len(TXTTelefono.Text) < 11 Then
                MsgBox("El formato del telefono es de 11 numeros, verifique.", MsgBoxStyle.Information)
                TXTTelefono.Focus()
                Exit Sub
            End If

            FPersona.LVTelefonos.Items.Add(TXTTelefono.Text)
            Me.Dispose()

        ElseIf FPersona.nAction = 3 Then

            If Len(TXTTelefono.Text) = 0 Then
                MsgBox("Ingrese el teléfono.", MsgBoxStyle.Information)
                TXTTelefono.Focus()
                Exit Sub
            ElseIf Len(TXTTelefono.Text) < 11 Then
                MsgBox("El formato del telefono es de 11 numeros, verifique.", MsgBoxStyle.Information)
                TXTTelefono.Focus()
                Exit Sub
            End If

            sSQLAddtelefono_persona = "insert into telefono_persona (nid_persona, stelefono) values (" & FPersona.DGVPersona.CurrentRow.Cells("nid").Value & ",'" & TXTTelefono.Text & "')"
            objCGenerica.accederBD(sSQLAddtelefono_persona)
            cargarDGVTelefono()
            TXTTelefono.Clear()
            MsgBox("Se agrego el teléfono exitosamente", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub FTelefono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TXTTelefono.Focus()
        If FPersona.nAction = 1 Then
            Me.Size = New Size(431, 194)
            GroupBox2.Size = New Size(280, 100)
        ElseIf FPersona.nAction = 3 Then
            DGVTelefono.Visible = True
            cargarDGVTelefono()
        End If

    End Sub

    Private Sub DGVTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGVTelefono.KeyPress

        Dim sSQLEliminarTelefono = "delete from telefono_persona where nid=" & DGVTelefono.CurrentRow.Cells("nid").Value & ""

        If e.KeyChar = StrConv(ChrW(Keys.D), VbStrConv.Lowercase) Then
            objCGenerica.accederBD(sSQLEliminarTelefono)
            MsgBox("Teléfono eliminado exitosamente.", MsgBoxStyle.Information)
            cargarDGVTelefono()
        End If

    End Sub


    Private Sub TXTTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTTelefono.KeyPress
        objCGenerica.SoloNumero(e)
    End Sub

    Private Sub TXTTelefono_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTTelefono.Enter
        DGVTelefono.ClearSelection()
    End Sub

End Class