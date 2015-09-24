Public Class FProductoEntrante

    Dim objCGenerica As CGenerica = New CGenerica
    Public nIdSolicitudP As Integer = FSolicitudProductos.nIdSolicitud
    Dim bsDGVProductoEntranteFilter As New BindingSource
    Friend nId_ProductoEntrante As Integer
    Public nAction As Integer
    Public cComparacion As Integer

    Public nIndice As Integer = 0
    Dim nId_estado As Integer
    Dim n_orden_new As Integer

    Dim s_Campo1 As String = ""
    Dim s_Campo2 As String = ""
    Dim s_Campo3 As String = ""
    Dim s_Campo4 As String = ""
    Dim s_Campo5 As String = ""


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

        'Dim sCadenaSQL As String = "select p.s_descripcion, p.n_cantidad_requerida_producto, p.nid_solicitud_producto from v_detalle_solicitud p  where(nid_solicitud = " & nIdSolicitudP & ") order by p.s_descripcion"
        Dim sCadenaSQL As String = "select p.s_descripcion, p.n_cantidad_requerida_producto, p.nid_solicitud_producto, (select coalesce(sum(pe.n_cantidad_entrante),0) from producto_entrante pe where nid_solicitud_producto = p.nid_solicitud_producto) ncantidad_recibida from v_detalle_solicitud p  where(nid_solicitud = " & nIdSolicitudP & ") order by p.s_descripcion"

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

            With DGVProductoEntrante.Columns("s_descripcion")
                '.Visible = False
                .HeaderText = "Producto"
                .Width = "200"
                .DisplayIndex = "0"
                .ReadOnly = True

            End With

            With DGVProductoEntrante.Columns("n_cantidad_requerida_producto")
                '.Visible = True
                .HeaderText = "Cantidad Requerida"
                .Width = "150"
                .DisplayIndex = "1"
                .ReadOnly = True

            End With

            With DGVProductoEntrante.Columns("nid_solicitud_producto")
                .Visible = False
                .HeaderText = "Solicitud Producto"
                .Width = "150"
                .DisplayIndex = "2"
                .ReadOnly = True

            End With

            With CHECKDGVProductoEntrante
                .Name = "select"
                '.DataPropertyName = "activo_privilegio"
                .FalseValue = "0"
                .TrueValue = "1"
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
                .Width = "150"
                .ReadOnly = False

            End With

            With DGVProductoEntrante.Columns("ncantidad_recibida")
                .Visible = True
                .HeaderText = "Cantidad Recibida"
                .Width = "150"
                .DisplayIndex = "3"
                .ReadOnly = True

            End With

            DGVProductoEntrante.Columns.Add(CHECKDGVProductoEntrante)
            DGVProductoEntrante.Columns.Add(TXTDGVProductoEntrante)

        End Using

    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        Dim sSQLDatosSolicitudes As String = ""
        Dim SQLGuardar As String = ""
        Dim nIndice As Integer = 0
        Dim nTexto As String = "0"
        Dim sSQLAux As String = ""
        Dim sCantidad_requerida As String = ""

        If Len(TXTProveedor.Text) = 0 Then
            MsgBox("Rellene el campo Proveedor", MsgBoxStyle.Information)
            TXTProveedor.Focus()
            Exit Sub

        End If

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then

            While nIndice < DGVProductoEntrante.RowCount

                If Len(DGVProductoEntrante.Rows(nIndice).Cells("nCantidad").Value) = 0 Then
                    MsgBox("Especifique la cantidad para todos los productos seleccionados", MsgBoxStyle.Information)

                Else
                    If DGVProductoEntrante.Rows(nIndice).Cells("nCantidad").Value > DGVProductoEntrante.Rows(nIndice).Cells("n_cantidad_requerida_producto").Value Then
                        MsgBox("La cantidad entrante del producto supera la requerida", MsgBoxStyle.Information)

                        Exit Sub

                    End If

                End If

                nIndice = 1 + nIndice

            End While

            nIndice = 0

            While nIndice < DGVProductoEntrante.RowCount

                If DGVProductoEntrante.Rows(nIndice).Cells("select").Value = "1" Then

                    If (DGVProductoEntrante.Rows(nIndice).Cells("n_cantidad_requerida_producto").Value) > (DGVProductoEntrante.Rows(nIndice).Cells("ncantidad_recibida").Value) Then

                        SQLGuardar = "insert into producto_entrante (nid_proveedor, nid_solicitud_producto, n_cantidad_entrante, d_fecha) values (" & TXTProveedor.Text & ", " & DGVProductoEntrante.Rows(nIndice).Cells("nid_solicitud_producto").Value & ", " & DGVProductoEntrante.Rows(nIndice).Cells("nCantidad").Value & ", '" & Date.Today.ToString("yyyy-MM-dd") & "') returning nid"
                        objCGenerica.accederBD(SQLGuardar)

                    Else

                        MsgBox("la cantidad requerida para uno de los productos esta completa", MsgBoxStyle.Information)

                    End If

                End If

                nIndice = 1 + nIndice

            End While

            sSQLDatosSolicitudes = "select (select (max(n_orden) + 1) norden from solicitud_historial WHERE nid_solicitud= " & FSolicitudProductos.nIdSolicitud & "), nid_solicitud, nid_estado, d_fecha,'' as sCampo5,'' as sCampo6,'' as sCampo7,'' as sCampo8 FROM solicitud_historial WHERE nid_solicitud= " & FSolicitudProductos.nIdSolicitud & ""

            objCGenerica.recuperarCamposBD(sSQLDatosSolicitudes, s_Campo1, s_Campo2, s_Campo3) ', s_Campo4, s_Campo5)

            n_orden_new = CInt(s_Campo1)
            nId_estado = CInt(s_Campo3)

            If nId_estado = 1 Then

                SQLGuardar = "UPDATE solicitudes SET nid_estado = 2 where nid = " & FSolicitudProductos.nIdSolicitud & ""
                objCGenerica.accederBD(SQLGuardar)

                SQLGuardar = "insert into solicitud_historial (nid_solicitud, nid_estado, d_fecha, n_orden) VALUES (" & FSolicitudProductos.nIdSolicitud & ", 2,'" & Date.Today.ToString("yyyy-MM-dd") & "', " & n_orden_new & ")"
                objCGenerica.accederBD(SQLGuardar)

                BTNCancelar_Click(sender, e)

                nAction = 0

                MsgBox("los productos entrantes fueron registrados correctamente.", MsgBoxStyle.Information)

            Else

                BTNCancelar_Click(sender, e)

                nAction = 0

                MsgBox("los productos entrantes fueron registrados correctamente.", MsgBoxStyle.Information)

            End If

        End If

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos
        CMBProveedor.Enabled = False
        TXTBuscar.Enabled = True
        'BTNAgregar.Enabled = True
        'BTNModificar.Enabled = False
        'BTNEliminar.Enabled = False
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
        'LBLNinguno.clear()
        Me.Dispose()

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged
        bsDGVProductoEntranteFilter.Filter = "s_descripcion like '%" & TXTBuscar.Text & "%' "

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
        TXTBuscar.Enabled = True
        'BTNEliminar.Enabled = False
        'BTNModificar.Enabled = False
        'BTNAgregar.Enabled = False
        BTNGuardar.Enabled = True
        BTNCancelar.Enabled = True
        BTNFinalizar.Enabled = True
        TXTProveedor.Focus()
        DGVProductoEntrante.Enabled = True
        DGVProductoEntrante.ClearSelection()

    End Sub

    Private Sub DGVProductoEntrante_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVProductoEntrante.CellClick

        BTNCancelar.Enabled = True

    End Sub

    Private Sub BTNFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNFinalizar.Click

        Dim SQLGuardar As String = ""
        Dim nIndice As Integer = 0
        Dim nContar As Integer = 1

        nContar = 1

        While nIndice < DGVProductoEntrante.RowCount

            If (DGVProductoEntrante.Rows(nIndice).Cells("n_cantidad_requerida_producto").Value) <> (DGVProductoEntrante.Rows(nIndice).Cells("ncantidad_recibida").Value) Then

                nContar = 2

            End If

            nIndice = 1 + nIndice

        End While

        If nContar = 1 Then

            SQLGuardar = "UPDATE solicitudes SET nid_estado = 3 where nid = " & FSolicitudProductos.nIdSolicitud & ""
            objCGenerica.accederBD(SQLGuardar)

            SQLGuardar = "insert into solicitud_historial (nid_solicitud, nid_estado, d_fecha, n_orden) VALUES (" & FSolicitudProductos.nIdSolicitud & ", 3,'" & Date.Today.ToString("yyyy-MM-dd") & "', " & n_orden_new & ")"
            objCGenerica.accederBD(SQLGuardar)

            MsgBox("La Solicitud está Completa, ha sido Finalizada", MsgBoxStyle.Information)

        Else

            MsgBox("La cantidad requerida para un producto no está completa, no se puede finalizar la solicitud", MsgBoxStyle.Information)

            Exit Sub

        End If

    End Sub

End Class