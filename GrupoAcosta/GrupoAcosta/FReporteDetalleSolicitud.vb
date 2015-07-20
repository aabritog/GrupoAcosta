Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows

Public Class FReporteDetalleSolicitud

    Friend nombre_reporte As String = ""

    Dim ruta As String
    Dim rpt As New ReportDocument

    Friend Sub llenarDSInformacionSolicitudes(ByVal ruta As String)
        Dim miDs As DataSet1 = New DataSet1
        Dim ta As New DataSet1TableAdapters.V_detalle_solicitudTableAdapter

        Try
            ta.FillByDetallesSolicitud(miDs.V_detalle_solicitud)
            rpt.Load(ruta)
            rpt.SetDataSource(miDs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CRVDetalleSolicitud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRVDetalleSolicitud.Load

        If nombre_reporte = "Visualizar_Solicitudes" Then
            ruta = "C:\GitHub\GrupoAcosta\GrupoAcosta\GrupoAcosta\Reports\RDetalleSolicitud.rpt"
            llenarDSInformacionSolicitudes(ruta) : CRVDetalleSolicitud.ReportSource = rpt
            Exit Sub
        End If

    End Sub

End Class