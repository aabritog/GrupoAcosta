Public Class FProvincia

    Dim objCGenerica As CGenerica = New CGenerica

    Dim bsDGVProvinciaFilter As New BindingSource

    Public nAction As Integer

    Private Sub mostrarDGVProvincia()

        Dim sCadenaSQL As String = "select d.nid, d.s_provincia from provincia d order by s_provincia"

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Dim dtDGVProvincia As New DataTable
            Dim bsDGVProvincia As New BindingSource

            objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVProvincia, bsDGVProvincia)
            bsDGVProvinciaFilter = bsDGVProvincia

            With DGVProvincia
                .RowHeadersVisible = False
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = bsDGVProvincia
                .ClearSelection()

            End With

            With DGVProvincia.Columns("nid")
                .Visible = False
                .HeaderText = "NID"
                .Width = "90"
                .DisplayIndex = "0"

            End With
            With DGVProvincia.Columns("s_provincia")
                '.Visible = True
                .HeaderText = "Provincia"
                .Width = "180"
                .DisplayIndex = "1"

            End With

        End Using

    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click

        nAction = 1

        TXTProvincia.Enabled = True
        TXTBuscar.Enabled = False
        BTNEliminar.Enabled = False
        BTNModificar.Enabled = False
        BTNAgregar.Enabled = False
        BTNGuardar.Enabled = True
        BTNCancelar.Enabled = True
        TXTProvincia.Focus()
        DGVProvincia.Enabled = False
        DGVProvincia.ClearSelection()

    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        If Len(TXTProvincia.Text) = 0 Then
            MsgBox("Rellene el campo provincia", MsgBoxStyle.Information)
            TXTProvincia.Focus()
            Exit Sub
        End If

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then

            Dim SQLGuardar As String = ""
            SQLGuardar = "insert into provincia (s_provincia) values ('" & TXTProvincia.Text & "')"

            objCGenerica.accederBD(SQLGuardar)

            mostrarDGVProvincia()

            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se ha agregado la provincia exitosamente.", MsgBoxStyle.Information)

            'Si la acción es modificar (modificar registr existente).

        ElseIf nAction = 2 Then

            Dim SQLActualizar As String = ""
            SQLActualizar = "UPDATE cliente SET s_provincia='" & TXTProvincia.Text & "' WHERE nid=" & DGVProvincia.CurrentRow.Cells("nid").Value & ""

            objCGenerica.accederBD(SQLActualizar)
            mostrarDGVProvincia()
            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos
        TXTProvincia.Enabled = False
        TXTBuscar.Enabled = True
        BTNAgregar.Enabled = True
        BTNModificar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNGuardar.Enabled = False
        DGVProvincia.Enabled = True

        'Se limpia contenido de los objetos
        TXTProvincia.Clear()
        TXTBuscar.Clear()

        DGVProvincia.Enabled = True
        'Se limpia la seleccion del DataGridView
        DGVProvincia.ClearSelection()

        nAction = 0

    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNModificar.Click

        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos
        TXTProvincia.Enabled = True
        TXTBuscar.Enabled = False
        BTNAgregar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = True
        BTNModificar.Enabled = False
        BTNGuardar.Enabled = True
        'Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        TXTProvincia.Text = Trim(DGVProvincia.CurrentRow.Cells("s_provincia").Value)

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        'Se declara el elemento eliminar para registros 
        If MsgBox("¿Esta seguro de querer eliminar esta provincia?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQLEliminarProvincia As String = ""
            SQLEliminarProvincia = "DELETE FROM provincia WHERE nid=" & DGVProvincia.CurrentRow.Cells("nid").Value & ""
            objCGenerica.accederBD(SQLEliminarProvincia)
            mostrarDGVProvincia()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado la provincia", MsgBoxStyle.Information)
        Else
            DGVProvincia.ClearSelection()
        End If

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        bsDGVProvinciaFilter.Filter = "s_provincia like '%" & TXTBuscar.Text & "%' "

        If Len(TXTBuscar.Text) = 0 Then
            DGVProvincia.ClearSelection()
        Else
            BTNCancelar.Enabled = True
        End If

    End Sub

    Private Sub TXTProvincia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTProvincia.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTProvincia, LBLValidarProvincia)

    End Sub

    Private Sub TXTProvincia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTProvincia.KeyPress

        objCGenerica.SoloLetra(e)

    End Sub

    Private Sub FProvincia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mostrarDGVProvincia()
        DGVProvincia.ClearSelection()

    End Sub

    Private Sub DGVProvincia_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVProvincia.CellClick
        BTNModificar.Enabled = True
        BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True
    End Sub

    Private Sub LBCamposObligatorios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBCamposObligatorios.Click

    End Sub
End Class