Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows

Public Class FReporte

    Friend nombre_reporte As String = ""

    Dim ruta As String
    Dim rpt As New ReportDocument

    Friend Sub llenarDSInformacionPersona(ByVal ruta As String)
        Dim miDs As DataSet1 = New DataSet1
        Dim ta As New DataSet1TableAdapters.V__persona_departamento_cargoTableAdapter

        Try
            ta.FillByAllPerson(miDs.V__persona_departamento_cargo)
            rpt.Load(ruta)
            rpt.SetDataSource(miDs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If nombre_reporte = "Visualizar_Persona" Then
            ruta = "C:\GitHub\GrupoAcosta\GrupoAcosta\GrupoAcosta\Reports\RPersona.rpt"
            llenarDSInformacionPersona(ruta) : CRVVisorReportes.ReportSource = rpt
            Exit Sub
        End If

    End Sub
End Class