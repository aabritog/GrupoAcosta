
Public Class FSolicitudesConsulta

    Dim objCGenerica As CGenerica = New CGenerica

    Dim DatosDataTableDGVConsultaSolicitudes As New DataTable
    Dim DatosBindingSourceDGVConsultaSolicitudes As New BindingSource
    Public nIdSolicitud As Integer
    Public nIndice As Integer = 0
    Friend nId_solicitud As Integer


    Private maxValue As Date = #1/1/1900#
    Private minValue As Date = #1/1/2100#

    Private Sub mostrarDGVConsultaSolicitudes()

        Dim CadenaSQL As String = ""

        'CadenaSQL = "select p.nid, p.s_nombre1 ||' '|| p.s_apellido1 ||' '|| p.s_apellido2 s_nombre, p.s_dni from persona p where p.nid not in (select nid_persona from usuario) and p.s_activo = '1'"
        CadenaSQL = "select nid_solicitud, s_cliente, d_fecha_solicitud from v_estado_solicitud where (estado_solicitud = 1 or estado_solicitud =  2) group by nid_solicitud, s_cliente, d_fecha_solicitud order by nid_solicitud"

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

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        DGVConsultaSolicitudes.Enabled = True

        DGVConsultaSolicitudes.ClearSelection()

        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNVerSolicitud.Enabled = False
        BTNReporteSolicitudes.Enabled = True
        BTNSolicitudIniciada.Enabled = True
        TXTDTPUno.Clear()
        TXTDTPDos.Clear()

        BTNSolicitudProceso.Enabled = True

        BTNSolicitudFinalizada.Enabled = True
        DTPUno.Enabled = True
        DTPDos.Enabled = True
        '        DTPUno.Value = "01-01-1940"
        '       DTPDos.Value = "01-01-1940"

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub FSolicitudesConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarDGVConsultaSolicitudes()
        DGVConsultaSolicitudes.ClearSelection()

        BTNSolicitudIniciada.Enabled = True

        BTNSolicitudProceso.Enabled = True

        BTNSolicitudFinalizada.Enabled = True

        '----------------------------------
        Dim contador As Integer = 0
        'cargarDGVConsultasFecha()

        For contador = 0 To DGVConsultaSolicitudes.RowCount - 1
            If DGVConsultaSolicitudes.Rows(contador).Cells("d_fecha_solicitud").Value < minValue Then
                minValue = DGVConsultaSolicitudes.Rows(contador).Cells("d_fecha_solicitud").Value
            End If
        Next
        DTPUno.MinDate = minValue
        DTPDos.MinDate = minValue
        DTPUno.Value = minValue
        For contador = 0 To DGVConsultaSolicitudes.RowCount - 1
            If DGVConsultaSolicitudes.Rows(contador).Cells("d_fecha_solicitud").Value > maxValue Then
                maxValue = DGVConsultaSolicitudes.Rows(contador).Cells("d_fecha_solicitud").Value
            End If
        Next
        DTPUno.MaxDate = maxValue
        DTPDos.MaxDate = maxValue
        DTPDos.Value = maxValue
        '--------------------------------------------

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

        BTNSolicitudIniciada.Enabled = False

        BTNSolicitudProceso.Enabled = False

        BTNSolicitudFinalizada.Enabled = False

        DTPUno.Enabled = False
        DTPDos.Enabled = False

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

        FReporte.sNombre_reporte = "RDetalleSolicitudEspecifica"
        FReporte.nId_solicitud = TextBox1.Text
        FReporte.ShowDialog()
        Me.Dispose()

    End Sub

    Private Sub BTNReporteSolicitudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNReporteSolicitudes.Click

        BTNCancelar.Enabled = True

        If Len(TXTDTPUno.Text) = 0 Then
            MsgBox("Selecciona la Fecha Inicia", MsgBoxStyle.Information)
            TXTDTPUno.Focus()
            Exit Sub
        End If


        If Len(TXTDTPDos.Text) = 0 Then
            MsgBox("Selecciona la Fecha Final", MsgBoxStyle.Information)
            TXTDTPDos.Focus()
            Exit Sub
        End If

        FReporte.sNombre_reporte = "Visualizar_Solicitudes"
        FReporte.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub BTNSolicitudIniciada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSolicitudIniciada.Click

        BTNCancelar.Enabled = True

        If Len(TXTDTPUno.Text) = 0 Then
            MsgBox("Selecciona la Fecha Inicia", MsgBoxStyle.Information)
            TXTDTPUno.Focus()
            Exit Sub
        End If


        If Len(TXTDTPDos.Text) = 0 Then
            MsgBox("Selecciona la Fecha Final", MsgBoxStyle.Information)
            TXTDTPDos.Focus()
            Exit Sub
        End If
        FReporte.sNombre_reporte = "Visualizar_Uno"
        FReporte.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub BTNSolicitudProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSolicitudProceso.Click

        BTNCancelar.Enabled = True

        If Len(TXTDTPUno.Text) = 0 Then
            MsgBox("Selecciona la Fecha Inicia", MsgBoxStyle.Information)
            TXTDTPUno.Focus()
            Exit Sub
        End If


        If Len(TXTDTPDos.Text) = 0 Then
            MsgBox("Selecciona la Fecha Final", MsgBoxStyle.Information)
            TXTDTPDos.Focus()
            Exit Sub
        End If

        FReporte.sNombre_reporte = "Visualizar_Dos"
        FReporte.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub BTNSolicitudFinalizada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSolicitudFinalizada.Click

        BTNCancelar.Enabled = True

        If Len(TXTDTPUno.Text) = 0 Then
            MsgBox("Selecciona la Fecha Inicia", MsgBoxStyle.Information)
            TXTDTPUno.Focus()
            Exit Sub
        End If


        If Len(TXTDTPDos.Text) = 0 Then
            MsgBox("Selecciona la Fecha Final", MsgBoxStyle.Information)
            TXTDTPDos.Focus()
            Exit Sub
        End If

        FReporte.sNombre_reporte = "Visualizar_Tres"
        FReporte.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub DTPUno_CloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPUno.CloseUp
        TXTDTPUno.Text = DTPUno.Value.Date
    End Sub

    Private Sub DTPDos_CloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPDos.CloseUp
        TXTDTPDos.Text = DTPDos.Value.Date
    End Sub

    Private Sub TXTDTPUno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDTPUno.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTDTPUno, LBLValidar1)
    End Sub

    Private Sub TXTDTPDos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDTPDos.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTDTPDos, LBLValidar2)
    End Sub

    Private Sub DTPUno_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPUno.Leave
        DTPUno_CloseUp(sender, e)
    End Sub

    Private Sub DTPDos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPDos.Leave
        DTPDos_CloseUp(sender, e)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class





