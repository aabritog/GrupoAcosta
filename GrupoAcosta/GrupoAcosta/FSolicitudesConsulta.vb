
Public Class FSolicitudesConsulta

    Dim objCGenerica As CGenerica = New CGenerica

    Dim DatosDataTableDGVConsultaSolicitudes As New DataTable
    Dim DatosBindingSourceDGVConsultaSolicitudes As New BindingSource
    Public nIdSolicitud As Integer
    Public nIndice As Integer = 0
    Friend nId_solicitud As Integer

    Private Sub mostrarDGVConsultaSolicitudes()

        Dim CadenaSQL As String = ""

        'CadenaSQL = "select p.nid, p.s_nombre1 ||' '|| p.s_apellido1 ||' '|| p.s_apellido2 s_nombre, p.s_dni from persona p where p.nid not in (select nid_persona from usuario) and p.s_activo = '1'"
        CadenaSQL = "select nid_solicitud, s_cliente, d_fecha_solicitud from v_detalle_solicitud group by nid_solicitud, s_cliente, d_fecha_solicitud order by nid_solicitud"

        DatosDataTableDGVConsultaSolicitudes.Clear()

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Using DatosDataAdapter As New Odbc.OdbcDataAdapter(CadenaSQL, conexion)
                DatosDataAdapter.Fill(DatosDataTableDGVConsultaSolicitudes)
                DatosBindingSourceDGVConsultaSolicitudes.DataSource = DatosDataTableDGVConsultaSolicitudes
            End Using


            With DGVConsultaSolicitudes
                .RowHeadersVisible = False
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = DatosBindingSourceDGVConsultaSolicitudes
                .ClearSelection()

            End With
            With DGVConsultaSolicitudes.Columns("nid_solicitud")
                .Visible = True
                .HeaderText = "N° de Solicitud"
                .Width = "100"
                .DisplayIndex = "0"

            End With
            With DGVConsultaSolicitudes.Columns("s_cliente")
                '.Visible = True
                .HeaderText = "Cliente"
                .Width = "250"
                .DisplayIndex = "1"

            End With

            With DGVConsultaSolicitudes.Columns("d_fecha_solicitud")
                '.Visible = True
                .HeaderText = "Fecha de la Solicitud"
                .Width = "110"
                .DisplayIndex = "2"
            End With
        End Using

    End Sub

    Private Sub BNTReporteSolicitudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FReporte.sNombre_reporte = "Visualizar_Solicitudes"
        FReporte.ShowDialog()

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        DGVConsultaSolicitudes.Enabled = True

        DGVConsultaSolicitudes.ClearSelection()

        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNVerSolicitud.Enabled = False
        BTNReporteSolicitudes.enabled = True
    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub



    Private Sub FSolicitudesConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarDGVConsultaSolicitudes()
        DGVConsultaSolicitudes.ClearSelection()
    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        DatosBindingSourceDGVConsultaSolicitudes.Filter = "s_cliente like '%" & TXTBuscar.Text & "%'"

    End Sub

    Private Sub DGVConsultaSolicitudes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsultaSolicitudes.CellClick

        nId_solicitud = (DGVConsultaSolicitudes.CurrentRow.Cells("nid_solicitud").Value)

        TextBox1.Text = nId_solicitud

        BTNEliminar.Enabled = True

        BTNCancelar.Enabled = True

        BTNVerSolicitud.Enabled = True

        BTNReporteSolicitudes.Enabled = False


    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        'Se declara el elemento eliminar para registros 
        If MsgBox("¿Esta seguro de querer eliminar esta solicitud?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQLEliminarSolicitudes As String = ""
            SQLEliminarSolicitudes = "DELETE FROM solicitudes WHERE nid=" & DGVConsultaSolicitudes.CurrentRow.Cells("nid_solicitud").Value & ""
            objCGenerica.accederBD(SQLEliminarSolicitudes)
            mostrarDGVConsultaSolicitudes()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado la solicitud", MsgBoxStyle.Information)
        Else
            DGVConsultaSolicitudes.ClearSelection()
        End If
    End Sub

    Private Sub BTNVerSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNVerSolicitud.Click

        FReporte.sNombre_reporte = "RDetalleSolicitud2"
        FReporte.nId_solicitud = TextBox1.Text
        FReporte.ShowDialog()
        Me.Dispose()

    End Sub

    Private Sub BTNReporteSolicitudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNReporteSolicitudes.Click
        FReporte.sNombre_reporte = "Visualizar_Solicitudes"
        FReporte.ShowDialog()
    End Sub
End Class



