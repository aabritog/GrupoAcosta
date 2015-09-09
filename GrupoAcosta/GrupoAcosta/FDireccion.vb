Public Class FDireccion

    Dim objCGenerica As CGenerica = New CGenerica

    Dim bsDGVDireccionFilter As New BindingSource

    Public nAction As Integer

    Private Sub cargarCMBCliente()

        Dim sCadenaSQL As String = "select nid, s_cliente from cliente order by s_cliente"

        Dim dtCMBCliente As New DataTable
        Dim bsCMBCliente As New BindingSource

        dtCMBCliente.Clear()
        bsCMBCliente.Clear()
        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtCMBCliente, bsCMBCliente)

        With CMBCliente
            .DataSource = bsCMBCliente
            .DisplayMember = "s_cliente"
            .ValueMember = "nid"
        End With
    End Sub

    Private Sub mostrarDGVDireccion()

        Dim sCadenaSQL As String = "select d.nid, d.nid_cliente, s_cliente, s_direccion from direccion d inner join cliente c on d.nid_cliente = c.nid order by s_cliente"

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Dim dtDGVDireccion As New DataTable
            Dim bsDGVDireccion As New BindingSource

            objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVDireccion, bsDGVDireccion)
            bsDGVDireccionFilter = bsDGVDireccion

            With DGVDireccion
                .RowHeadersVisible = False
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = bsDGVDireccion
                .ClearSelection()

            End With

            With DGVDireccion.Columns("nid")
                .Visible = False
                .HeaderText = "NID"
                .Width = "90"
                .DisplayIndex = "0"

            End With
            With DGVDireccion.Columns("nid_cliente")
                .Visible = False
                .HeaderText = "ID Cliente"
                .Width = "180"
                .DisplayIndex = "1"

            End With
            With DGVDireccion.Columns("s_cliente")
                '.Visible = True
                .HeaderText = "Cliente"
                .Width = "180"
                .DisplayIndex = "2"

            End With

            With DGVDireccion.Columns("s_direccion")
                '.Visible = True
                .HeaderText = "Direccion"
                .Width = "180"
                .DisplayIndex = "3"

            End With

        End Using

    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click

        cargarCMBCliente()

        nAction = 1

        CMBCliente.Enabled = True
        TXTDireccion.Enabled = True
        TXTBuscar.Enabled = False
        BTNEliminar.Enabled = False
        BTNModificar.Enabled = False
        BTNAgregar.Enabled = False
        BTNGuardar.Enabled = True
        BTNCancelar.Enabled = True
        TXTCliente.Focus()
        DGVDireccion.Enabled = False
        DGVDireccion.ClearSelection()

    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        If Len(TXTCliente.Text) = 0 Then
            MsgBox("Rellene el campo Cliente", MsgBoxStyle.Information)
            TXTCliente.Focus()
            Exit Sub
        End If

        If Len(TXTDireccion.Text) = 0 Then
            MsgBox("Rellene el campo Direccion", MsgBoxStyle.Information)
            TXTDireccion.Focus()
            Exit Sub
        End If

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then

            Dim SQLGuardar As String = ""
            SQLGuardar = "insert into direccion (nid_cliente, s_direccion) values (" & TXTCliente.Text & ", '" & TXTDireccion.Text & "')"

            objCGenerica.accederBD(SQLGuardar)

            mostrarDGVDireccion()

            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se ha agregado la direccion exitosamente.", MsgBoxStyle.Information)

            'Si la acción es modificar (modificar registr existente).

        ElseIf nAction = 2 Then

            Dim SQLActualizar As String = ""
            SQLActualizar = "UPDATE direccion SET nid_cliente= '" & TXTCliente.Text & "', s_direccion= '" & TXTDireccion.Text & "' WHERE nid=" & DGVDireccion.CurrentRow.Cells("nid").Value & ""

            objCGenerica.accederBD(SQLActualizar)
            mostrarDGVDireccion()
            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos

        CMBCliente.Enabled = False
        TXTDireccion.Enabled = False
        TXTBuscar.Enabled = True
        BTNAgregar.Enabled = True
        BTNModificar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNGuardar.Enabled = False
        DGVDireccion.Enabled = True

        'Se limpia contenido de los objetos
        TXTDireccion.Clear()
        TXTCliente.Clear()
        TXTBuscar.Clear()

        DGVDireccion.Enabled = True
        'Se limpia la seleccion del DataGridView
        DGVDireccion.ClearSelection()

        CMBCliente.DataSource = Nothing
        nAction = 0

    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNModificar.Click

        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos
        TXTDireccion.Enabled = True
        CMBCliente.Enabled = True
        TXTBuscar.Enabled = False
        BTNAgregar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = True
        BTNModificar.Enabled = False
        BTNGuardar.Enabled = True
        cargarCMBCliente()
        'Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        TXTCliente.Text = Trim(DGVDireccion.CurrentRow.Cells("nid_cliente").Value)
        'TXTClave.Text = Trim(DGVUsuario.CurrentRow.Cells("s_clave").Value)
        CMBCliente.SelectedValue = Trim(DGVDireccion.CurrentRow.Cells("nid_cliente").Value)
        TXTDireccion.Text = Trim(DGVDireccion.CurrentRow.Cells("s_direccion").Value)

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        'Se declara el elemento eliminar para registros 
        If MsgBox("¿Esta seguro de querer eliminar esta direccion?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQLEliminarDireccion As String = ""
            SQLEliminarDireccion = "DELETE FROM direccion WHERE nid=" & DGVDireccion.CurrentRow.Cells("nid").Value & ""
            objCGenerica.accederBD(SQLEliminarDireccion)
            mostrarDGVDireccion()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado la direccion", MsgBoxStyle.Information)
        Else
            DGVDireccion.ClearSelection()
        End If

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        bsDGVDireccionFilter.Filter = "s_cliente like '%" & TXTBuscar.Text & "%' "

        If Len(TXTBuscar.Text) = 0 Then
            DGVDireccion.ClearSelection()
        Else
            BTNCancelar.Enabled = True
        End If

    End Sub

    Private Sub TXTDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDireccion.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTDireccion, LBLValidarDireccion)
    End Sub

    Private Sub CMBCliente_SelectionChangeCommitted_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBCliente.SelectionChangeCommitted
        TXTCliente.Text = CMBCliente.SelectedValue
    End Sub

    Private Sub TXTCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCliente.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTCliente, LBLValidarCliente)
    End Sub

    Private Sub FDireccion_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarDGVDireccion()
        DGVDireccion.ClearSelection()
    End Sub

    Private Sub DGVDireccion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDireccion.CellClick

        BTNModificar.Enabled = True
        BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True
        BTNAgregar.Enabled = False
    End Sub

  
    Private Sub LBCamposObligatorios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBCamposObligatorios.Click

    End Sub
End Class