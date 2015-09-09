Public Class FEstado_Solicitud

    Dim objCGenerica As CGenerica = New CGenerica

    Dim bsDGVEstadoSolicitudFilter As New BindingSource

    Public nAction As Integer

    Private Sub mostrarDGVEstadoSolicitud()

        Dim sCadenaSQL As String = "select d.nid, d.s_descripcion, d.s_descripcioncorta from estado_solicitud d where d.s_activo = '1' order by s_descripcion"

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Dim dtDGVEstadoSolicitud As New DataTable
            Dim bsDGVEstadoSolicitud As New BindingSource

            objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVEstadoSolicitud, bsDGVEstadoSolicitud)
            bsDGVEstadoSolicitudFilter = bsDGVEstadoSolicitud

            With DGVEstadoSolicitud
                .Columns.Clear()
                .RowHeadersVisible = False
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = bsDGVEstadoSolicitud
                .ClearSelection()

            End With

            With DGVEstadoSolicitud.Columns("nid")
                .Visible = False
                .HeaderText = "NID"
                .Width = "90"
                .DisplayIndex = "0"

            End With
            With DGVEstadoSolicitud.Columns("s_descripcion")
                '.Visible = True
                .HeaderText = "Descripcion"
                .Width = "220"
                .DisplayIndex = "1"

            End With
            With DGVEstadoSolicitud.Columns("s_descripcioncorta")
                '.Visible = True
                .HeaderText = "Descripcion Corta"
                .Width = "220"
                .DisplayIndex = "2"

            End With

        End Using

    End Sub

    'Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    nAction = 1

    '    TXTDescripcion.Enabled = True
    '    TXTDescripcionCorta.Enabled = True
    '    TXTBuscar.Enabled = False
    '    BTNEliminar.Enabled = False
    '    BTNModificar.Enabled = False
    '    BTNAgregar.Enabled = False
    '    BTNGuardar.Enabled = True
    '    BTNCancelar.Enabled = True
    '    TXTDescripcion.Focus()
    '    DGVEstadoSolicitud.Enabled = False
    '    DGVEstadoSolicitud.ClearSelection()

    'End Sub

    'Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If Len(TXTDescripcion.Text) = 0 Then
    '        MsgBox("Rellene el campo Descripción", MsgBoxStyle.Information)
    '        TXTDescripcion.Focus()
    '        Exit Sub
    '    End If

    '    If Len(TXTDescripcionCorta.Text) = 0 Then
    '        MsgBox("Rellene el campo Descripción Corta", MsgBoxStyle.Information)
    '        TXTDescripcionCorta.Focus()
    '        Exit Sub
    '    End If

    '    'Si la acción es insertar (crear un nuevo registro).
    '    If nAction = 1 Then

    '        Dim SQLGuardar As String = ""
    '        SQLGuardar = "insert into estado_solicitud (s_descripcion, s_descripcioncorta, d_fecha, s_activo) values ('" & TXTDescripcion.Text & "', '" & TXTDescripcionCorta.Text & "', '" & Date.Today.ToString("yyyy-MM-dd") & "', '1')"

    '        objCGenerica.accederBD(SQLGuardar)

    '        mostrarDGVEstadoSolicitud()

    '        BTNCancelar_Click(sender, e)

    '        nAction = 0

    '        MsgBox("Se ha agregado el estado de la solicitud exitosamente.", MsgBoxStyle.Information)

    '        'Si la acción es modificar (modificar registr existente).

    '    ElseIf nAction = 2 Then

    '        Dim SQLActualizar As String = ""
    '        SQLActualizar = "UPDATE estado_solicitud SET s_descripcion='" & TXTDescripcion.Text & "',s_descripcioncorta='" & TXTDescripcionCorta.Text & "', d_fecha= '" & Date.Today.ToString("yyyy-MM-dd") & "' WHERE nid=" & DGVEstadoSolicitud.CurrentRow.Cells("nid").Value & ""

    '        objCGenerica.accederBD(SQLActualizar)
    '        mostrarDGVEstadoSolicitud()
    '        BTNCancelar_Click(sender, e)

    '        nAction = 0

    '        MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

    '    End If

    'End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        ''Se habilitan/deshabilitan los objetos
        'TXTDescripcion.Enabled = False
        'TXTDescripcionCorta.Enabled = False
        TXTBuscar.Enabled = True
        'BTNAgregar.Enabled = True
        'BTNModificar.Enabled = False
        'BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        'BTNGuardar.Enabled = False
        DGVEstadoSolicitud.Enabled = True

        'Se limpia contenido de los objetos
        'TXTDescripcion.Clear()
        'TXTDescripcionCorta.Clear()
        TXTBuscar.Clear()

        DGVEstadoSolicitud.Enabled = True
        'Se limpia la seleccion del DataGridView
        DGVEstadoSolicitud.ClearSelection()

        nAction = 0

    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos
        'TXTDescripcion.Enabled = True
        'TXTDescripcionCorta.Enabled = True
        TXTBuscar.Enabled = False
        'BTNAgregar.Enabled = False
        'BTNEliminar.Enabled = False
        'BTNCancelar.Enabled = True
        'BTNModificar.Enabled = False
        'BTNGuardar.Enabled = True
        ''Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        'TXTDescripcion.Text = Trim(DGVEstadoSolicitud.CurrentRow.Cells("s_descripcion").Value)
        ''TXTClave.Text = Trim(DGVUsuario.CurrentRow.Cells("s_clave").Value)
        'TXTDescripcionCorta.Text = Trim(DGVEstadoSolicitud.CurrentRow.Cells("s_descripcioncorta").Value)

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    'Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Se declara el elemento eliminar para registros 
    '    If MsgBox("¿Esta seguro de querer eliminar a este estado de la solicitud?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        Dim SQLEliminarEstadoSolicitud As String = ""
    '        SQLEliminarEstadoSolicitud = "DELETE FROM estado_solicitud WHERE nid=" & DGVEstadoSolicitud.CurrentRow.Cells("nid").Value & ""
    '        objCGenerica.accederBD(SQLEliminarEstadoSolicitud)
    '        mostrarDGVEstadoSolicitud()
    '        BTNCancelar_Click(sender, e)
    '        MsgBox("Se ha eliminado el estado de la solicitud", MsgBoxStyle.Information)
    '    Else
    '        DGVEstadoSolicitud.ClearSelection()
    '    End If

    'End Sub

    Private Sub DGVRol_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVEstadoSolicitud.CellClick

        'BTNModificar.Enabled = True
        'BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        bsDGVEstadoSolicitudFilter.Filter = "s_descripcion like '%" & TXTBuscar.Text & "%' "

        If Len(TXTBuscar.Text) = 0 Then
            DGVEstadoSolicitud.ClearSelection()
        Else
            BTNCancelar.Enabled = True
        End If

    End Sub

    'Private Sub TXTDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    objCGenerica.valCampoObligatorio(Me.TXTDescripcion, LBLValidarDescripcion)
    'End Sub

    'Private Sub TXTDescripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    '    objCGenerica.SoloLetra(e)
    'End Sub

   Private Sub FEstado_Solicitud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mostrarDGVEstadoSolicitud()

        DGVEstadoSolicitud.ClearSelection()

    End Sub

    'Private Sub TXTDescripcionCorta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    objCGenerica.valCampoObligatorio(Me.TXTDescripcionCorta, LBLValidarDescripcioncorta)
    'End Sub


    'Private Sub TXTDescripcionCorta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    objCGenerica.SoloLetra(e)
    'End Sub
End Class