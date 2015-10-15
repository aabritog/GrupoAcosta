Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows

Public Class FReporte

    Friend sNombre_reporte As String = ""
    Public nId_solicitud As Integer
    Friend nId_persona As Integer
    Dim ruta As String
    Dim rpt As New ReportDocument

    Friend Sub llenarDSInformacionPersona(ByVal ruta As String, ByRef nIdPersona As Integer)
        Dim miDs As DataSet1 = New DataSet1
        Dim ta As New DataSet1TableAdapters.v_persona_departamento_cargoTableAdapter

        Try
            ta.FillByVisuaPer(miDs.v_persona_departamento_cargo, nIdPersona)
            rpt.Load(ruta)
            rpt.SetDataSource(miDs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Friend Sub ListadoSolicitudes(ByVal ruta As String)
        Dim miDs As DataSet1 = New DataSet1
        Dim ta As New DataSet1TableAdapters.v_detalle_solicitudTableAdapter

        Try
            ta.FillByListadoSolicitudes(miDs.v_detalle_solicitud)
            rpt.Load(ruta)
            rpt.SetDataSource(miDs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Friend Sub EstadoUno(ByVal ruta As String)
        Dim miDs As DataSet1 = New DataSet1
        Dim ta As New DataSet1TableAdapters.v_estado_solicitudTableAdapter

        Try
            ta.FillByEstadoUno(miDs.v_estado_solicitud)
            rpt.Load(ruta)
            rpt.SetDataSource(miDs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Friend Sub EstadoDos(ByVal ruta As String)
        Dim miDs As DataSet1 = New DataSet1
        Dim ta As New DataSet1TableAdapters.v_estado_solicitudTableAdapter

        Try
            ta.FillByEstadoDos(miDs.v_estado_solicitud)
            rpt.Load(ruta)
            rpt.SetDataSource(miDs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Friend Sub EstadoTres(ByVal ruta As String)
        Dim miDs As DataSet1 = New DataSet1
        Dim ta As New DataSet1TableAdapters.v_estado_solicitudTableAdapter

        Try
            ta.FillByEstadoTres(miDs.v_estado_solicitud)
            rpt.Load(ruta)
            rpt.SetDataSource(miDs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Sub DetalleSolicitud2(ByVal ruta As String, ByRef nIdSolicitud As Integer)
        Dim miDs As DataSet1 = New DataSet1
        Dim ta As New DataSet1TableAdapters.v_detalle_solicitudTableAdapter

        Try
            ta.FillByDetalleSolicitud2(miDs.v_detalle_solicitud, nIdSolicitud)
            rpt.Load(ruta)
            rpt.SetDataSource(miDs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CRVVisorReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRVVisorReportes.Load

        If sNombre_reporte = "Visualizar_Persona" Then
            ruta = "C:\GitHub\GrupoAcosta\GrupoAcosta\GrupoAcosta\Reports\RPersona.rpt"
            llenarDSInformacionPersona(ruta, nId_persona) : CRVVisorReportes.ReportSource = rpt
            Exit Sub

        End If

        If sNombre_reporte = "Visualizar_Solicitudes" Then
            ruta = "C:\GitHub\GrupoAcosta\GrupoAcosta\GrupoAcosta\Reports\RDetalleSolicitud.rpt"
            ListadoSolicitudes(ruta) : CRVVisorReportes.ReportSource = rpt
            Exit Sub
        End If

        If sNombre_reporte = "Visualizar_Uno" Then
            ruta = "C:\GitHub\GrupoAcosta\GrupoAcosta\GrupoAcosta\Reports\REstadoUno.rpt"
            EstadoUno(ruta) : CRVVisorReportes.ReportSource = rpt
            Exit Sub
        End If

        If sNombre_reporte = "Visualizar_Dos" Then
            ruta = "C:\GitHub\GrupoAcosta\GrupoAcosta\GrupoAcosta\Reports\REstadoDos.rpt"
            EstadoDos(ruta) : CRVVisorReportes.ReportSource = rpt
            Exit Sub
        End If
        If sNombre_reporte = "Visualizar_Tres" Then
            ruta = "C:\GitHub\GrupoAcosta\GrupoAcosta\GrupoAcosta\Reports\REstadoTres.rpt"
            EstadoTres(ruta) : CRVVisorReportes.ReportSource = rpt
            Exit Sub
        End If

        'Reporte que muestra el detalle de una solicitud especifica
        If sNombre_reporte = "RDetalleSolicitudEspecifica" Then
            Me.Text = "Grupo Acosta C.A - Detalle de solicitud"
            ruta = "C:\GitHub\GrupoAcosta\GrupoAcosta\GrupoAcosta\Reports\RDetalleSolicitudEspecifica.rpt"
            DetalleSolicitud2(ruta, nId_solicitud) : CRVVisorReportes.ReportSource = rpt
            Exit Sub
        End If

    End Sub

End Class