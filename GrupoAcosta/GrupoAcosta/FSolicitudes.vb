Public Class FSolicitudes

    Dim objCGenerica As CGenerica = New CGenerica

    Dim bsDGVSolicitudesFilter As New BindingSource
    Friend nId_solicitud As Integer

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

    Private Sub mostrarDGVSolicitudes()

        'Dim sCadenaSQL As String = "select nid, s_descripcion, s_descripcioncorta from producto where s_activo = '1' order by s_descripcion"

        Dim sCadenaSQL As String = "select p.nid, p.s_descripcion, p.s_descripcioncorta from producto p where s_activo = '1' order by p.s_descripcion"


        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Dim dtDGVSolicitudes As New DataTable
            Dim bsDGVSolicitudes As New BindingSource
            Dim CHECKDGVSolicitudes As New DataGridViewCheckBoxColumn
            Dim TXTDGVSolicitudes As New DataGridViewTextBoxColumn

            objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVSolicitudes, bsDGVSolicitudes)
            bsDGVSolicitudesFilter = bsDGVSolicitudes

            With DGVSolicitudes
                .Columns.Clear()
                .RowHeadersVisible = False
                '.ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = bsDGVSolicitudes
                .ClearSelection()

            End With

            With DGVSolicitudes.Columns("nid")
                .Visible = False
                .HeaderText = "NID"
                .Width = "90"
                .DisplayIndex = "0"

            End With
            With DGVSolicitudes.Columns("s_descripcion")
                '.Visible = False
                .HeaderText = "Descripcion"
                .Width = "300"
                .DisplayIndex = "1"
                .ReadOnly = True

            End With
            With DGVSolicitudes.Columns("s_descripcioncorta")
                '.Visible = True
                .HeaderText = "Descripcion Corta"
                .Width = "200"
                .DisplayIndex = "2"
                .ReadOnly = True

            End With

            With CHECKDGVSolicitudes
                .Name = "select"
                '.DataPropertyName = "activo_privilegio"
                .FalseValue = "0"
                .TrueValue = "1"
                .HeaderText = "Incluir"
                .Width = "60"
                .ReadOnly = False
            End With

            With TXTDGVSolicitudes
                .Name = "nCantidad"
                '.DataPropertyName = "activo_privilegio"
                '.FalseValue = "0"
                '.TrueValue = "1"
                .HeaderText = "Cantidad"
                .Width = "60"
                .ReadOnly = False
            End With

            DGVSolicitudes.Columns.Add(CHECKDGVSolicitudes)
            DGVSolicitudes.Columns.Add(TXTDGVSolicitudes)

        End Using

    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click

        cargarCMBCliente()
        mostrarDGVSolicitudes()
        nAction = 1

        CMBCliente.Enabled = True
        TXTBuscar.Enabled = False
        BTNEliminar.Enabled = False
        BTNModificar.Enabled = False
        BTNAgregar.Enabled = False
        BTNGuardar.Enabled = True
        BTNCancelar.Enabled = True
        TXTCliente.Focus()
        DGVSolicitudes.Enabled = True
        DGVSolicitudes.ClearSelection()

    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        Dim sId_solicitud As String

        Dim SQLGuardar As String = ""
        Dim nIndice As Integer = 0
        Dim nTexto As String = "0"


        If Len(TXTCliente.Text) = 0 Then
            MsgBox("Rellene el campo Cliente", MsgBoxStyle.Information)
            TXTCliente.Focus()
            Exit Sub
        End If

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then

            While nIndice < DGVSolicitudes.RowCount

                If DGVSolicitudes.Rows(nIndice).Cells("select").Value = "1" Then
                    'SQLGuardar = "UPDATE rol_privilegio SET activo=" & CBool(DGVPrivilegios.Rows(i).Cells("activo_privilegio").Value) & " WHERE id_rol=" & CInt(DGVPrivilegios.Rows(i).Cells("id_rol").Value) & " AND id_privilegio=" & CInt(DGVPrivilegios.Rows(i).Cells("id_privilegio").Value) & ""

                    If Len(DGVSolicitudes.Rows(nIndice).Cells("nCantidad").Value) = 0 Then
                        MsgBox("Especifique la cantidad para todos los productos seleccionados", MsgBoxStyle.Information)
                        Exit Sub

                    Else

                        SQLGuardar = "insert into solicitudes (nid_cliente, s_verificacion, d_fecha) values (" & TXTCliente.Text & ", '2', '" & Date.Today.ToString("yyyy-MM-dd") & "') returning nid"
                        sId_solicitud = ""

                        objCGenerica.accederBD(SQLGuardar, sId_solicitud)

                        nId_solicitud = CInt(Trim(sId_solicitud))

                        SQLGuardar = "insert into solicitud_historial (nid_solicitud, nid_estado, d_fecha, n_orden) values (" & nId_solicitud & ", 1, '" & Date.Today.ToString("yyyy-MM-dd") & "', 1)"

                        objCGenerica.accederBD(SQLGuardar)

                        SQLGuardar = "insert into solicitud_historial_movimiento (nid_solicitud,nid_movimiento,d_fecha, n_orden) values (" & nId_solicitud & ", 1, '" & Date.Today.ToString("yyyy-MM-dd") & "', 1)"

                        objCGenerica.accederBD(SQLGuardar)

                        While nIndice < DGVSolicitudes.RowCount

                            If DGVSolicitudes.Rows(nIndice).Cells("select").Value = "1" Then

                                If Len(DGVSolicitudes.Rows(nIndice).Cells("nCantidad").Value) = 0 Then
                                    MsgBox("Especifique la cantidad para todos los productos seleccionados", MsgBoxStyle.Information)
                                    Exit Sub
                                Else
                                    SQLGuardar = "insert into solicitud_producto (nid_solicitud, nid_producto, n_cantidad_requerida, s_existencia) values (" & nId_solicitud & ", " & DGVSolicitudes.Rows(nIndice).Cells("nid").Value & ", " & DGVSolicitudes.Rows(nIndice).Cells("nCantidad").Value & ", '2')"
                                    objCGenerica.accederBD(SQLGuardar)
                                End If

                            End If

                            nIndice = 1 + nIndice

                        End While

                    End If
                End If

            End While

            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se ha agregado la solicitud exitosamente.", MsgBoxStyle.Information)

            If MsgBox("¿Desea ver el detalle de la solicitud creada?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                FReporte.sNombre_reporte = "RDetalleSolicitud2"
                FReporte.ShowDialog()
                Me.Dispose()
            Else
                Me.Dispose()
            End If

            'Si la acción es modificar (modificar registr existente).

        ElseIf nAction = 2 Then

            Dim SQLActualizar As String = ""
            SQLActualizar = "UPDATE solicitudes SET nid_cliente= '" & TXTCliente.Text & "' WHERE nid=" & DGVSolicitudes.CurrentRow.Cells("nid").Value & ""

            objCGenerica.accederBD(SQLActualizar)
            mostrarDGVSolicitudes()
            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos

        CMBCliente.Enabled = False
        TXTBuscar.Enabled = True
        BTNAgregar.Enabled = True
        BTNModificar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNGuardar.Enabled = False
        DGVSolicitudes.Enabled = True

        'Se limpia contenido de los objetos
        TXTCliente.Clear()
        TXTBuscar.Clear()

        DGVSolicitudes.Enabled = True
        'Se limpia la seleccion del DataGridView
        DGVSolicitudes.ClearSelection()
        DGVSolicitudes.Columns.Clear()
        CMBCliente.DataSource = Nothing
        mostrarDGVSolicitudes()
        nAction = 0

    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNModificar.Click

        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos
        CMBCliente.Enabled = True
        TXTBuscar.Enabled = False
        BTNAgregar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = True
        BTNModificar.Enabled = False
        BTNGuardar.Enabled = True
        cargarCMBCliente()
        'Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        TXTCliente.Text = Trim(DGVSolicitudes.CurrentRow.Cells("nid_cliente").Value)
        'TXTClave.Text = Trim(DGVUsuario.CurrentRow.Cells("s_clave").Value)
        CMBCliente.SelectedValue = Trim(DGVSolicitudes.CurrentRow.Cells("nid_cliente").Value)

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        'Se declara el elemento eliminar para registros 
        If MsgBox("¿Esta seguro de querer eliminar esta solicitud?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQLEliminarSolicitudes As String = ""
            SQLEliminarSolicitudes = "DELETE FROM Solicitudes WHERE nid=" & DGVSolicitudes.CurrentRow.Cells("nid").Value & ""
            objCGenerica.accederBD(SQLEliminarSolicitudes)
            mostrarDGVSolicitudes()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado la solicitud", MsgBoxStyle.Information)
        Else
            DGVSolicitudes.ClearSelection()
        End If

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged
        bsDGVSolicitudesFilter.Filter = "s_descripcion like '%" & TXTBuscar.Text & "%' "

        If Len(TXTBuscar.Text) = 0 Then
            DGVSolicitudes.ClearSelection()
        Else
            BTNCancelar.Enabled = True
        End If
    End Sub

    Private Sub CMBCliente_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBCliente.SelectionChangeCommitted
        TXTCliente.Text = CMBCliente.SelectedValue
    End Sub

    Private Sub TXTCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCliente.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTCliente, LBLValidarCliente)
    End Sub

    Private Sub FSolicitudes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarDGVSolicitudes()
        DGVSolicitudes.ClearSelection()
        BTNAgregar_Click(sender, e)

    End Sub
    Private Sub DGVSolicitudes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVSolicitudes.CellClick
        BTNModificar.Enabled = True
        BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True
    End Sub

    Private Sub BNTReporteSolicitudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNTReporteSolicitudes.Click

        FReporte.sNombre_reporte = "Visualizar_Solicitudes"
        FReporte.ShowDialog()

    End Sub

End Class