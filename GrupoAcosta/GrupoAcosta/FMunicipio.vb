Public Class FMunicipio

    Dim objCGenerica As CGenerica = New CGenerica

    Dim bsDGVMunicipioFilter As New BindingSource

    Public nAction As Integer

    Private Sub cargarCMBProvincia()

        Dim sCadenaSQL As String = "select nid, s_provincia from provincia order by s_provincia"

        Dim dtCMBProvincia As New DataTable
        Dim bsCMBProvincia As New BindingSource

        dtCMBProvincia.Clear()
        bsCMBProvincia.Clear()
        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtCMBProvincia, bsCMBProvincia)

        With CMBProvincia
            .DataSource = bsCMBProvincia
            .DisplayMember = "s_provincia"
            .ValueMember = "nid"
        End With
    End Sub

    Private Sub mostrarDGVMunicipio()

        Dim sCadenaSQL As String = "select d.nid, d.s_municipio, d.nid_provincia, s_provincia from municipio d inner join provincia p on d.nid_provincia = p.nid order by s_municipio"

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Dim dtDGVMunicipio As New DataTable
            Dim bsDGVMunicipio As New BindingSource

            objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVMunicipio, bsDGVMunicipio)
            bsDGVMunicipioFilter = bsDGVMunicipio

            With DGVMunicipio
                .RowHeadersVisible = False
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = bsDGVMunicipio
                .ClearSelection()

            End With

            With DGVMunicipio.Columns("nid")
                .Visible = False
                .HeaderText = "NID"
                .Width = "90"
                .DisplayIndex = "0"

            End With
            With DGVMunicipio.Columns("s_municipio")
                '.Visible = True
                .HeaderText = "Municipio"
                .Width = "180"
                .DisplayIndex = "1"

            End With
            With DGVMunicipio.Columns("nid_provincia")
                .Visible = False
                .HeaderText = "ID Provincia"
                .Width = "220"
                .DisplayIndex = "2"

            End With

            With DGVMunicipio.Columns("s_provincia")
                '.Visible = True
                .HeaderText = "Provincia"
                .Width = "220"
                .DisplayIndex = "3"

            End With

        End Using

    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click

        cargarCMBProvincia()

        nAction = 1

        TXTMunicipio.Enabled = True
        CMBProvincia.Enabled = True
        TXTBuscar.Enabled = False
        BTNEliminar.Enabled = False
        BTNModificar.Enabled = False
        BTNAgregar.Enabled = False
        BTNGuardar.Enabled = True
        BTNCancelar.Enabled = True
        TXTMunicipio.Focus()
        DGVMunicipio.Enabled = False
        DGVMunicipio.ClearSelection()

    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        If Len(TXTMunicipio.Text) = 0 Then
            MsgBox("Rellene el campo municipio", MsgBoxStyle.Information)
            TXTMunicipio.Focus()
            Exit Sub
        End If

        If Len(TXTProvincia.Text) = 0 Then
            MsgBox("Rellene el campo provincia", MsgBoxStyle.Information)
            TXTProvincia.Focus()
            Exit Sub
        End If

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then

            Dim SQLGuardar As String = ""
            SQLGuardar = "insert into municipio (s_municipio, nid_provincia) values ('" & TXTMunicipio.Text & "', " & TXTProvincia.Text & ")"

            objCGenerica.accederBD(SQLGuardar)

            mostrarDGVMunicipio()

            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se ha agregado el municipio exitosamente.", MsgBoxStyle.Information)

            'Si la acción es modificar (modificar registr existente).

        ElseIf nAction = 2 Then

            Dim SQLActualizar As String = ""
            SQLActualizar = "UPDATE municipio SET s_municipio='" & TXTMunicipio.Text & "', nid_provincia= " & TXTProvincia.Text & "WHERE nid=" & DGVMunicipio.CurrentRow.Cells("nid").Value & ""

            objCGenerica.accederBD(SQLActualizar)
            mostrarDGVMunicipio()
            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos
        TXTMunicipio.Enabled = False
        CMBProvincia.Enabled = False
        TXTBuscar.Enabled = True
        BTNAgregar.Enabled = True
        BTNModificar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNGuardar.Enabled = False
        DGVMunicipio.Enabled = True

        'Se limpia contenido de los objetos
        TXTMunicipio.Clear()
        TXTBuscar.Clear()

        DGVMunicipio.Enabled = True
        'Se limpia la seleccion del DataGridView
        DGVMunicipio.ClearSelection()

        CMBProvincia.DataSource = Nothing
        nAction = 0

    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNModificar.Click

        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos
        TXTMunicipio.Enabled = True
        CMBProvincia.Enabled = True
        TXTBuscar.Enabled = False
        BTNAgregar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = True
        BTNModificar.Enabled = False
        BTNGuardar.Enabled = True
        cargarCMBProvincia()
        'Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        TXTMunicipio.Text = Trim(DGVMunicipio.CurrentRow.Cells("s_municipio").Value)
        'TXTClave.Text = Trim(DGVUsuario.CurrentRow.Cells("s_clave").Value)
        TXTProvincia.Text = Trim(DGVMunicipio.CurrentRow.Cells("nid_provincia").Value)
        CMBProvincia.SelectedValue = Trim(DGVMunicipio.CurrentRow.Cells("nid_provincia").Value)

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        'Se declara el elemento eliminar para registros 
        If MsgBox("¿Esta seguro de querer eliminar a este municipio?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQLEliminarMunicipio As String = ""
            SQLEliminarMunicipio = "DELETE FROM municipio WHERE nid=" & DGVMunicipio.CurrentRow.Cells("nid").Value & ""
            objCGenerica.accederBD(SQLEliminarMunicipio)
            mostrarDGVMunicipio()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado el municipio", MsgBoxStyle.Information)
        Else
            DGVMunicipio.ClearSelection()
        End If

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        bsDGVMunicipioFilter.Filter = "s_municipio like '%" & TXTBuscar.Text & "%' "

        If Len(TXTBuscar.Text) = 0 Then
            DGVMunicipio.ClearSelection()
        Else
            BTNCancelar.Enabled = True
        End If

    End Sub

    Private Sub TXTMunicipio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTMunicipio.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTMunicipio, LBLValidarMunicipio)

    End Sub

    Private Sub CMBProvincia_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBProvincia.SelectionChangeCommitted

        TXTProvincia.Text = CMBProvincia.SelectedValue

    End Sub

    Private Sub TXTProvincia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTProvincia.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTProvincia, LBLValidarProvincia)

    End Sub

    Private Sub FMunicipio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarDGVMunicipio()
        DGVMunicipio.ClearSelection()
    End Sub

    Private Sub DGVMunicipio_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVMunicipio.CellClick

        BTNModificar.Enabled = True
        BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True

    End Sub

End Class