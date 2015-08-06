Public Class FProductoEntrante

    Dim objCGenerica As CGenerica = New CGenerica

    Dim bsDGVProductoEntranteFilter As New BindingSource
    Friend nId_ProductoEntrante As Integer
    Public nAction As Integer

    Private Sub cargarCMBProveedor()

        Dim sCadenaSQL As String = "select nid, s_descripcion from proveedores order by s_descripcion"

        Dim dtCMBProveedor As New DataTable
        Dim bsCMBProveedor As New BindingSource

        dtCMBProveedor.Clear()
        bsCMBProveedor.Clear()
        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtCMBProveedor, bsCMBProveedor)

        With CMBProveedor
            .DataSource = bsCMBProveedor
            .DisplayMember = "s_descripcion"
            .ValueMember = "nid"
        End With
    End Sub

    Private Sub mostrarDGVProductoEntrante()

        'Dim sCadenaSQL As String = "select nid, s_descripcion, s_descripcioncorta from producto where s_activo = '1' order by s_descripcion"

        Dim sCadenaSQL As String = "select p.s_descripcion, p.n_cantidad_requerida_producto from v_detalle_solicitud p order by p.s_descripcion"


        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Dim dtDGVProductoEntrante As New DataTable
            Dim bsDGVProductoEntrante As New BindingSource
            Dim CHECKDGVProductoEntrante As New DataGridViewCheckBoxColumn
            Dim TXTDGVProductoEntrante As New DataGridViewTextBoxColumn

            objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVProductoEntrante, bsDGVProductoEntrante)
            bsDGVProductoEntranteFilter = bsDGVProductoEntrante

            With DGVProductoEntrante
                .Columns.Clear()
                .RowHeadersVisible = False
                '.ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = bsDGVProductoEntrante
                .ClearSelection()

            End With

            With DGVProductoEntrante.Columns("")
                '.Visible = False
                .HeaderText = "Producto"s_descripcion
                .Width = "180"
                .DisplayIndex = "0"
                .ReadOnly = True

            End With
            With DGVProductoEntrante.Columns("n_cantidad_requerida_producto")
                '.Visible = True
                .HeaderText = "Cantidad Requerida"
                .Width = "180"
                .DisplayIndex = "1"
                .ReadOnly = True

            End With

            With CHECKDGVProductoEntrante
                .Name = "select"
                '.DataPropertyName = "activo_privilegio"
                .FalseValue = "0"
                .TrueValue = "0"
                .HeaderText = "Incluir"
                .Width = "60"
                .ReadOnly = False
            End With

            With TXTDGVProductoEntrante
                .Name = "nCantidad"
                '.DataPropertyName = "activo_privilegio"
                '.FalseValue = "0"
                '.TrueValue = "1"
                .HeaderText = "Cantidad Entrante"
                .Width = "60"
                .ReadOnly = False
            End With

            DGVProductoEntrante.Columns.Add(CHECKDGVProductoEntrante)
            DGVProductoEntrante.Columns.Add(TXTDGVProductoEntrante)

        End Using

    End Sub

    'Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click

    '    cargarCMBProveedor()

    '    nAction = 1

    '    CMBProveedor.Enabled = False
    '    'BTNSolicitudes.Enabled = True
    '    TXTBuscar.Enabled = False
    '    BTNEliminar.Enabled = False
    '    BTNModificar.Enabled = False
    '    BTNAgregar.Enabled = False
    '    BTNGuardar.Enabled = True
    '    BTNCancelar.Enabled = True
    '    TXTProveedor.Focus()
    '    DGVProductoEntrante.Enabled = True
    '    DGVProductoEntrante.ClearSelection()

    'End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        Dim sId_ProductoEntrante As String


        Dim SQLGuardar As String = ""
        Dim nIndice As Integer = 0
        Dim nTexto As String = "0"
        Dim sSQLAux As String = ""
        Dim sCantidad_requerida As String = ""
        Dim nCantidad_requerida As Integer

        If Len(TXTProveedor.Text) = 0 Then
            MsgBox("Rellene el campo Cliente", MsgBoxStyle.Information)
            TXTProveedor.Focus()
            Exit Sub
        End If

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then

            While nIndice < DGVProductoEntrante.RowCount

                If DGVProductoEntrante.Rows(nIndice).Cells("select").Value = "1" Then
                    'SQLGuardar = "UPDATE rol_privilegio SET activo=" & CBool(DGVPrivilegios.Rows(i).Cells("activo_privilegio").Value) & " WHERE id_rol=" & CInt(DGVPrivilegios.Rows(i).Cells("id_rol").Value) & " AND id_privilegio=" & CInt(DGVPrivilegios.Rows(i).Cells("id_privilegio").Value) & ""

                    If Len(DGVProductoEntrante.Rows(nIndice).Cells("nCantidad").Value) = 0 Then
                        MsgBox("Especifique la cantidad para todos los productos seleccionados", MsgBoxStyle.Information)
                        Exit Sub

                    Else

                        SQLGuardar = "insert into producto_entrante (nid, nid_proveedor, d_fecha) values (" & TXTProveedor.Text & ", '2', '" & Date.Today.ToString("yyyy-MM-dd") & "') returning nid"
                        sId_ProductoEntrante = ""

                        'SQLGuardar = "insert into solicitudes (nid_cliente, s_verificacion, d_fecha) values (" & TXTProveedor.Text & ", '2', '" & Date.Today.ToString("yyyy-MM-dd") & "') returning nid"
                        'sId_ProductoEntrante = ""

                        'objCGenerica.accederBD(SQLGuardar, sId_ProductoEntrante)

                        'nId_ProductoEntrante = CInt(Trim(sId_ProductoEntrante))

                        'SQLGuardar = "insert into solicitud_historial (nId_ProductoEntrante, nid_estado, d_fecha, n_orden) values (" & nId_ProductoEntrante & ", 1, '" & Date.Today.ToString("yyyy-MM-dd") & "', 1)"

                        'objCGenerica.accederBD(SQLGuardar)

                        'SQLGuardar = "insert into solicitud_historial_movimiento (nId_ProductoEntrante,nid_movimiento,d_fecha, n_orden) values (" & nId_ProductoEntrante & ", 1, '" & Date.Today.ToString("yyyy-MM-dd") & "', 1)"

                        'objCGenerica.accederBD(SQLGuardar)

                        While nIndice < DGVProductoEntrante.RowCount

                            If DGVProductoEntrante.Rows(nIndice).Cells("select").Value = "1" Then

                                sSQLAux = "SELECT n_cantidad_requerida, '' as sCampo2, '' as sCampo3, '' as sCampo4, '' as sCampo5, '' as sCampo6,'' as sCampo7, '' as sCampo8 FROM solicitud_producto WHERE nid_solicitud = " & DGVProductoEntrante.Rows(nIndice).Cells("n_cantidad_requerida_producto").Value & " AND nid_producto =" & DGVProductoEntrante.Rows(nIndice).Cells("s_descripcion").Value & ""
                                objCGenerica.recuperarCamposBD(sSQLAux, sCantidad_requerida)

                                nCantidad_requerida = CInt(sCantidad_requerida)

                                If Len(DGVProductoEntrante.Rows(nIndice).Cells("nCantidad").Value) = 0 Then
                                    MsgBox("Especifique la cantidad para todos los productos seleccionados", MsgBoxStyle.Information)
                                    Exit Sub
                                Else

                                    If DGVProductoEntrante.Rows(nIndice).Cells("nCantidad").Value > nCantidad_requerida Then
                                        'If DGVProductoEntrante.Rows(nIndice).Cells("nCantidad").Value > DGVProductoEntrante.Rows(nIndice).Cells("nCantidadREQUERIDA").ValuE Then
                                        MsgBox("La cantidad entrante del producto supera la requerida", MsgBoxStyle.Information)
                                        Exit Sub
                                    End If

                                    'SQLGuardar = "insert into solicitud_producto (nId_ProductoEntrante, nid_producto, n_cantidad_requerida, s_existencia) values (" & nId_ProductoEntrante & ", " & DGVProductoEntrante.Rows(nIndice).Cells("nid").Value & ", " & DGVProductoEntrante.Rows(nIndice).Cells("nCantidad").Value & ", '2')"
                                    'objCGenerica.accederBD(SQLGuardar)
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
            SQLActualizar = "UPDATE solicitudes SET nid_cliente= '" & TXTProveedor.Text & "' WHERE nid=" & DGVProductoEntrante.CurrentRow.Cells("nid").Value & ""

            objCGenerica.accederBD(SQLActualizar)
            mostrarDGVProductoEntrante()
            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos

        CMBProveedor.Enabled = False
        TXTBuscar.Enabled = True
        'BTNAgregar.Enabled = True
        BTNModificar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNGuardar.Enabled = False
        DGVProductoEntrante.Enabled = True

        'Se limpia contenido de los objetos
        TXTProveedor.Clear()
        TXTBuscar.Clear()

        DGVProductoEntrante.Enabled = True
        'Se limpia la seleccion del DataGridView
        DGVProductoEntrante.ClearSelection()
        'DGVProductoEntrante.columns.Clear()
        CMBProveedor.DataSource = Nothing
        nAction = 0

    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNModificar.Click

        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos
        CMBProveedor.Enabled = True
        TXTBuscar.Enabled = False
        'BTNAgregar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = True
        BTNModificar.Enabled = False
        BTNGuardar.Enabled = True
        cargarCMBProveedor()
        'Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        TXTProveedor.Text = Trim(DGVProductoEntrante.CurrentRow.Cells("nid_proveedor").Value)
        'TXTClave.Text = Trim(DGVUsuario.CurrentRow.Cells("s_clave").Value)
        CMBProveedor.SelectedValue = Trim(DGVProductoEntrante.CurrentRow.Cells("nid_proveedor").Value)

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        'Se declara el elemento eliminar para registros 
        If MsgBox("¿Esta seguro de querer eliminar esta solicitud?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQLEliminarSolicitudes As String = ""
            SQLEliminarSolicitudes = "DELETE FROM Solicitudes WHERE nid=" & DGVProductoEntrante.CurrentRow.Cells("nid").Value & ""
            objCGenerica.accederBD(SQLEliminarSolicitudes)
            mostrarDGVProductoEntrante()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado la solicitud", MsgBoxStyle.Information)
        Else
            DGVProductoEntrante.ClearSelection()
        End If

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged
        bsDGVProductoEntranteFilter.Filter = "s_cliente like '%" & TXTBuscar.Text & "%' "

        If Len(TXTBuscar.Text) = 0 Then
            DGVProductoEntrante.ClearSelection()
        Else
            BTNCancelar.Enabled = True
        End If
    End Sub

    Private Sub CMBProveedor_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBProveedor.SelectionChangeCommitted
        TXTProveedor.Text = CMBProveedor.SelectedValue
    End Sub

    Private Sub TXTProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTProveedor.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTProveedor, LBLValidarProveedor)
    End Sub

    Private Sub FProductoEntrante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGVProductoEntrante.ClearSelection()
        mostrarDGVProductoEntrante()
        
        cargarCMBProveedor()

        nAction = 1

        CMBProveedor.Enabled = True
        'BTNSolicitudes.Enabled = True
        TXTBuscar.Enabled = False
        BTNEliminar.Enabled = False
        BTNModificar.Enabled = False
        'BTNAgregar.Enabled = False
        BTNGuardar.Enabled = True
        BTNCancelar.Enabled = True
        TXTProveedor.Focus()
        DGVProductoEntrante.Enabled = True
        DGVProductoEntrante.ClearSelection()

        'BTNAgregar_Click(sender, e)
    End Sub

    Private Sub DGVProductoEntrante_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVProductoEntrante.CellClick
        'BTNModificar.Enabled = True
        'BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True
    End Sub

    'Private Sub BTNSolicitudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    FSolicitudProductos.ShowDialog()

    '    CMBProveedor.Enabled = True
    'End Sub
End Class