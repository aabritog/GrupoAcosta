Public Class FSolicitudProductos

    Dim DatosDataTableDGVSolicitudesSistema As New DataTable
    Dim DatosBindingSourceDGVSolicitudesSistema As New BindingSource
    Public nIdSolicitud As Integer
    Public nIndice As Integer = 0

    Private Sub mostrarDGVSolicitudesSistema()

        Dim CadenaSQL As String = ""

        'CadenaSQL = "select p.nid, p.s_nombre1 ||' '|| p.s_apellido1 ||' '|| p.s_apellido2 s_nombre, p.s_dni from persona p where p.nid not in (select nid_persona from usuario) and p.s_activo = '1'"
        CadenaSQL = "select nid_solicitud, s_cliente, d_fecha_solicitud from v_detalle_solicitud group by nid_solicitud, s_cliente, d_fecha_solicitud order by nid_solicitud"

        DatosDataTableDGVSolicitudesSistema.Clear()

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Using DatosDataAdapter As New Odbc.OdbcDataAdapter(CadenaSQL, conexion)
                DatosDataAdapter.Fill(DatosDataTableDGVSolicitudesSistema)
                DatosBindingSourceDGVSolicitudesSistema.DataSource = DatosDataTableDGVSolicitudesSistema
            End Using


            With DGVSolicitudesSistema
                .RowHeadersVisible = False
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = DatosBindingSourceDGVSolicitudesSistema
                .ClearSelection()

            End With
            With DGVSolicitudesSistema.Columns("nid_solicitud")
                .Visible = True
                .HeaderText = "N° de Solicitud"
                .Width = "100"
                .DisplayIndex = "0"

            End With
            With DGVSolicitudesSistema.Columns("s_cliente")
                '.Visible = True
                .HeaderText = "Cliente"
                .Width = "250"
                .DisplayIndex = "1"

            End With

            With DGVSolicitudesSistema.Columns("d_fecha_solicitud")
                '.Visible = True
                .HeaderText = "Fecha de la Solicitud"
                .Width = "110"
                .DisplayIndex = "2"
            End With
        End Using

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos
        DGVSolicitudesSistema.Enabled = True

        'Se limpia la seleccion del DataGridView
        DGVSolicitudesSistema.ClearSelection()

        Me.Dispose()

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        DatosBindingSourceDGVSolicitudesSistema.Filter = "s_cliente like '%" & TXTBuscar.Text & "%'"

    End Sub

    Private Sub Solicitud_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DGVSolicitudesSistema.ClearSelection()

        mostrarDGVSolicitudesSistema()

        BTNSiguiente.Enabled = True


    End Sub

    Private Sub BTNSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSiguiente.Click

        If DGVSolicitudesSistema.SelectedRows.Count > 0 Then

            nIdSolicitud = DGVSolicitudesSistema.CurrentRow.Cells("nid_solicitud").Value

            'FUsuarios.TBValidarIdPersona.Text = DGVPersonasNoUsuarios.CurrentRow.Cells("id").Value

            TXTSoliictudesSistema.Text = DGVSolicitudesSistema.CurrentRow.Cells("nid_solicitud").Value
            FProductoEntrante.LBLNinguno.Text = DGVSolicitudesSistema.CurrentRow.Cells("nid_solicitud").Value
            FProductoEntrante.LBLCliente.Text = DGVSolicitudesSistema.CurrentRow.Cells("s_cliente").Value
            'sIdSolicitud()

            'Me.Close()

            FProductoEntrante.ShowDialog()

        Else

            MsgBox("Debe Seleccionar una Solicitud para que sea Procesada", MsgBoxStyle.Information)

            Exit Sub

        End If
    End Sub

End Class