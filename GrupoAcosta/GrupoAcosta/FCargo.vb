Imports GrupoAcosta.CGenerica

Public Class FCargo

    Dim objCGenerica As CGenerica = New CGenerica

    Dim bsDGVCargoFilter As New BindingSource

    Public nAction As Integer

    Private Sub cargarCMBDepartamento()

        Dim sCadenaSQL As String = "select nid, s_descripcion from Departamento where s_activo = '1' order by s_descripcion"

        Dim dtCMBDepartamento As New DataTable
        Dim bsCMBDepartamento As New BindingSource

        dtCMBDepartamento.Clear()
        bsCMBDepartamento.Clear()
        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtCMBDepartamento, bsCMBDepartamento)

        With CMBDepartamento
            .DataSource = bsCMBDepartamento
            .DisplayMember = "s_descripcion"
            .ValueMember = "nid"
        End With
    End Sub

    Private Sub mostrarDGVCargo()

        Dim sCadenaSQL As String = "select d.nid, d.s_descripcion, d.s_descripcioncorta, d.nid_departamento, c.s_descripcion s_departamento from cargo d inner join departamento c on d.nid_departamento = c.nid and d.s_activo = '1' order by s_descripcion"

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Dim dtDGVCargo As New DataTable
            Dim bsDGVCargo As New BindingSource

            objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVCargo, bsDGVCargo)
            bsDGVCargoFilter = bsDGVCargo

            With DGVCargo
                .RowHeadersVisible = False
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = bsDGVCargo
                .ClearSelection()

            End With

            With DGVCargo.Columns("nid")
                .Visible = False
                .HeaderText = "NID"
                .Width = "90"
                .DisplayIndex = "0"

            End With
            With DGVCargo.Columns("s_descripcion")
                '.Visible = True
                .HeaderText = "Descripcion"
                .Width = "180"
                .DisplayIndex = "1"

            End With
            With DGVCargo.Columns("s_descripcioncorta")
                .HeaderText = "Descripcion Corta"
                .Width = "180"
                .DisplayIndex = "2"

            End With

            With DGVCargo.Columns("nid_departamento")
                .Visible = False
                .HeaderText = "ID Departamento"
                .Width = "20"
                .DisplayIndex = "3"
            End With

            With DGVCargo.Columns("s_departamento")
                '.Visible = True
                .HeaderText = "Departamento"
                .Width = "280"
                .DisplayIndex = "4"
            End With

        End Using

    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click

        cargarCMBDepartamento()

        nAction = 1

        TXTDescripcion.Enabled = True
        TXTDescripcionCorta.Enabled = True
        TXTBuscar.Enabled = False
        CMBDepartamento.Enabled = True
        BTNEliminar.Enabled = False
        BTNModificar.Enabled = False
        BTNAgregar.Enabled = False
        BTNGuardar.Enabled = True
        BTNCancelar.Enabled = True
        TXTDescripcion.Focus()
        DGVCargo.Enabled = False
        DGVCargo.ClearSelection()

    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        Dim sExisteCargoDescripcion As String
        Dim sSQLVerificarExisteCargoDescripcion As String
        Dim sExisteCargoDepartamento As String
        Dim sSQLVerificarExisteCargoDepartamento As String

        If Len(TXTDescripcion.Text) = 0 Then
            MsgBox("Rellene el campo Descripción", MsgBoxStyle.Information)
            TXTDescripcion.Focus()
            Exit Sub
        End If

        If Len(TXTDescripcionCorta.Text) = 0 Then
            MsgBox("Rellene el campo Descripción Corta", MsgBoxStyle.Information)
            TXTDescripcionCorta.Focus()
            Exit Sub
        End If

        If Len(TXTDepartamento.Text) = 0 Then
            MsgBox("Seleccione el departamento", MsgBoxStyle.Information)
            CMBDepartamento.Focus()
            Exit Sub
        End If

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then

            sExisteCargoDescripcion = ""
            'Antes de agregar un cargo se verifica que no exista un cargo con la misma dexcripcion (descripcion).
            '.................................................................................................................................
            sSQLVerificarExisteCargoDescripcion = "SELECT s_descripcion FROM cargo WHERE s_descripcion='" & TXTDescripcion.Text & " '"
            objCGenerica.accederBD(sSQLVerificarExisteCargoDescripcion, sExisteCargoDescripcion)

            If sExisteCargoDescripcion <> "" Then
                MsgBox("Ya existe un cargo con la misma descripcion, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            sExisteCargoDepartamento = ""
            'Antes de agregar un cargo se verifica que no exista este cargo en un departamento (descripcion).
            '.................................................................................................................................
            sSQLVerificarExisteCargoDepartamento = "SELECT nid_departamento FROM cargo WHERE nid_departamento='" & TXTDepartamento.Text & " '"
            objCGenerica.accederBD(sSQLVerificarExisteCargoDepartamento, sExisteCargoDepartamento)

            If sExisteCargoDescripcion <> "" Then
                MsgBox("Ya existe este cargo en un departamento, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            Dim SQLGuardar As String = ""
            SQLGuardar = "insert into cargo (s_descripcion, s_descripcioncorta, d_fecha, nid_departamento, s_activo) values ('" & TXTDescripcion.Text & "', '" & TXTDescripcionCorta.Text & "', '" & Date.Today.ToString("yyyy-MM-dd") & "', " & TXTDepartamento.Text & ", '1')"

            objCGenerica.accederBD(SQLGuardar)

            mostrarDGVCargo()

            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se ha agregado el cargo exitosamente.", MsgBoxStyle.Information)

            'Si la acción es modificar (modificar registr existente).

        ElseIf nAction = 2 Then

            sExisteCargoDescripcion = ""
            'Antes de agregar un cargo se verifica que no exista un cargo con la misma dexcripcion (descripcion).
            '.................................................................................................................................
            sSQLVerificarExisteCargoDescripcion = "SELECT s_descripcion FROM cargo WHERE s_descripcion='" & TXTDescripcion.Text & "' EXCEPT SELECT nid FROM cargo WHERE s_descripcion='" & DGVCargo.CurrentRow.Cells("s_descripcion").Value & "' "
            objCGenerica.accederBD(sSQLVerificarExisteCargoDescripcion, sExisteCargoDescripcion)

            If sExisteCargoDescripcion <> "" Then
                MsgBox("Ya existe un cargo con la misma descripcion, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            sExisteCargoDepartamento = ""
            'Antes de agregar un cargo se verifica que no exista este cargo en un departamento (descripcion).
            '.................................................................................................................................
            sSQLVerificarExisteCargoDepartamento = "SELECT nid_departamento FROM cargo WHERE nid_departamento='" & TXTDepartamento.Text & " 'EXCEPT SELECT nid FROM cargo WHERE nid_departamento='" & DGVCargo.CurrentRow.Cells("nid_departamento").Value & "' "
            objCGenerica.accederBD(sSQLVerificarExisteCargoDepartamento, sExisteCargoDepartamento)

            If sExisteCargoDescripcion <> "" Then
                MsgBox("Ya existe este cargo en un departamento, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            Dim SQLActualizar As String = ""
            SQLActualizar = "UPDATE cargo SET s_descripcion='" & TXTDescripcion.Text & "',s_descripcioncorta='" & TXTDescripcionCorta.Text & "', d_fecha= '" & Date.Today.ToString("yyyy-MM-dd") & "',nid_departamento=" & TXTDepartamento.Text & " WHERE nid=" & DGVCargo.CurrentRow.Cells("nid").Value & ""

            objCGenerica.accederBD(SQLActualizar)
            mostrarDGVCargo()
            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos
        TXTDescripcion.Enabled = False
        CMBDepartamento.Enabled = False
        TXTBuscar.Enabled = True
        CMBDepartamento.Enabled = False
        BTNAgregar.Enabled = True
        BTNModificar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNGuardar.Enabled = False
        DGVCargo.Enabled = True

        'Se limpia contenido de los objetos
        TXTDescripcion.Clear()
        TXTDescripcionCorta.Clear()
        TXTDepartamento.Clear()
        TXTBuscar.Clear()

        DGVCargo.Enabled = True
        'Se limpia la seleccion del DataGridView
        DGVCargo.ClearSelection()

        CMBDepartamento.DataSource = Nothing

        nAction = 0

    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNModificar.Click

        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos
        TXTDescripcion.Enabled = True
        TXTDescripcionCorta.Enabled = True
        TXTBuscar.Enabled = False
        CMBDepartamento.Enabled = True
        BTNAgregar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = True
        BTNModificar.Enabled = False
        BTNGuardar.Enabled = True
        cargarCMBDepartamento()
        'Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        TXTDescripcion.Text = Trim(DGVCargo.CurrentRow.Cells("s_descripcion").Value)
        'TXTClave.Text = Trim(DGVUsuario.CurrentRow.Cells("s_clave").Value)
        TXTDescripcionCorta.Text = Trim(DGVCargo.CurrentRow.Cells("s_descripcioncorta").Value)
        TXTDepartamento.Text = Trim(DGVCargo.CurrentRow.Cells("nid_departamento").Value)
        CMBDepartamento.SelectedValue = Trim(DGVCargo.CurrentRow.Cells("nid_departamento").Value)
    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        'Se declara el elemento eliminar para registros 
        If MsgBox("¿Esta seguro de querer eliminar a este Cargo?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQLEliminarCargo As String = ""
            SQLEliminarCargo = "DELETE FROM cargo WHERE nid=" & DGVCargo.CurrentRow.Cells("nid").Value & ""
            objCGenerica.accederBD(SQLEliminarCargo)
            mostrarDGVCargo()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado el cargo", MsgBoxStyle.Information)
        Else
            DGVCargo.ClearSelection()
        End If

    End Sub

    Private Sub DGVCargo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCargo.CellClick

        BTNModificar.Enabled = True
        BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        bsDGVCargoFilter.Filter = "s_descripcion like '%" & TXTBuscar.Text & "%' "

        If Len(TXTBuscar.Text) = 0 Then
            DGVCargo.ClearSelection()
        Else
            BTNCancelar.Enabled = True
        End If

    End Sub

    Private Sub TXTDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDescripcion.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTDescripcion, LBLValidarDescripcion)
    End Sub

    Private Sub TXTDescripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTDescripcion.KeyPress

        objCGenerica.SoloLetra(e)
    End Sub

    Private Sub CMBDepartamento_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBDepartamento.SelectionChangeCommitted
        TXTDepartamento.Text = CMBDepartamento.SelectedValue
    End Sub

    Private Sub FCargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarDGVCargo()
        DGVCargo.ClearSelection()
    End Sub

    Private Sub TXTDepartamento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDepartamento.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTDepartamento, LBLValidarDepartamento)
    End Sub

    Private Sub TXTDescripcionCorta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDescripcionCorta.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTDescripcionCorta, LBLValidarDescripcioncorta)
    End Sub


    Private Sub TXTDescripcionCorta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTDescripcionCorta.KeyPress
        objCGenerica.SoloLetra(e)
    End Sub

    Private Sub GBCargos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBCargos.Enter

    End Sub

    Private Sub LBLBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLBuscar.Click

    End Sub
End Class