Public Class FProducto

    Dim objCGenerica As CGenerica = New CGenerica

    Dim bsDGVProductoFilter As New BindingSource

    Public nAction As Integer

    Private Sub mostrarDGVProducto()

        Dim sCadenaSQL As String = "select d.nid, d.s_descripcion, d.s_descripcioncorta from producto d where d.s_activo = '1' order by s_descripcion"

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Dim dtDGVProducto As New DataTable
            Dim bsDGVProducto As New BindingSource

            objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVProducto, bsDGVProducto)
            bsDGVProductoFilter = bsDGVProducto

            With DGVProducto
                .RowHeadersVisible = False
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = bsDGVProducto
                .ClearSelection()

            End With

            With DGVProducto.Columns("nid")
                .Visible = False
                .HeaderText = "NID"
                .Width = "90"
                .DisplayIndex = "0"

            End With
            With DGVProducto.Columns("s_descripcion")
                '.Visible = True
                .HeaderText = "Descripcion"
                .Width = "180"
                .DisplayIndex = "1"

            End With
            With DGVProducto.Columns("s_descripcioncorta")
                '.Visible = True
                .HeaderText = "Descripcion Corta"
                .Width = "180"
                .DisplayIndex = "2"

            End With

        End Using

    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click

        nAction = 1

        TXTDescripcion.Enabled = True
        TXTDescripcionCorta.Enabled = True
        TXTBuscar.Enabled = False
        BTNEliminar.Enabled = False
        BTNModificar.Enabled = False
        BTNAgregar.Enabled = False
        BTNGuardar.Enabled = True
        BTNCancelar.Enabled = True
        TXTDescripcion.Focus()
        DGVProducto.Enabled = False
        DGVProducto.ClearSelection()

    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

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

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then

            Dim SQLGuardar As String = ""
            SQLGuardar = "insert into producto (s_descripcion, s_descripcioncorta, d_fecha, s_activo) values ('" & TXTDescripcion.Text & "', '" & TXTDescripcionCorta.Text & "', '" & Date.Today.ToString("yyyy-MM-dd") & "', '1')"

            objCGenerica.accederBD(SQLGuardar)

            mostrarDGVProducto()

            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se ha agregado el producto exitosamente.", MsgBoxStyle.Information)

            'Si la acción es modificar (modificar registr existente).

        ElseIf nAction = 2 Then

            Dim SQLActualizar As String = ""
            SQLActualizar = "UPDATE producto SET s_descripcion='" & TXTDescripcion.Text & "',s_descripcioncorta='" & TXTDescripcionCorta.Text & "', d_fecha= '" & Date.Today.ToString("yyyy-MM-dd") & "' WHERE nid=" & DGVProducto.CurrentRow.Cells("nid").Value & ""

            objCGenerica.accederBD(SQLActualizar)
            mostrarDGVProducto()
            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos
        TXTDescripcion.Enabled = False
        TXTDescripcionCorta.Enabled = False
        TXTBuscar.Enabled = True
        BTNAgregar.Enabled = True
        BTNModificar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNGuardar.Enabled = False
        DGVProducto.Enabled = True

        'Se limpia contenido de los objetos
        TXTDescripcion.Clear()
        TXTDescripcionCorta.Clear()
        TXTBuscar.Clear()

        DGVProducto.Enabled = True
        'Se limpia la seleccion del DataGridView
        DGVProducto.ClearSelection()

        nAction = 0

    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNModificar.Click

        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos
        TXTDescripcion.Enabled = True
        TXTDescripcionCorta.Enabled = True
        TXTBuscar.Enabled = False
        BTNAgregar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = True
        BTNModificar.Enabled = False
        BTNGuardar.Enabled = True
        'Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        TXTDescripcion.Text = Trim(DGVProducto.CurrentRow.Cells("s_descripcion").Value)
        'TXTClave.Text = Trim(DGVUsuario.CurrentRow.Cells("s_clave").Value)
        TXTDescripcionCorta.Text = Trim(DGVProducto.CurrentRow.Cells("s_descripcioncorta").Value)

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        'Se declara el elemento eliminar para registros 
        If MsgBox("¿Esta seguro de querer eliminar a este producto?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQLEliminarProducto As String = ""
            SQLEliminarProducto = "DELETE FROM producto WHERE nid=" & DGVProducto.CurrentRow.Cells("nid").Value & ""
            objCGenerica.accederBD(SQLEliminarProducto)
            mostrarDGVProducto()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado el producto", MsgBoxStyle.Information)
        Else
            DGVProducto.ClearSelection()
        End If

    End Sub

    Private Sub DGVRol_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVProducto.CellClick

        BTNModificar.Enabled = True
        BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        bsDGVProductoFilter.Filter = "s_descripcion like '%" & TXTBuscar.Text & "%' "

        If Len(TXTBuscar.Text) = 0 Then
            DGVProducto.ClearSelection()
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

    Private Sub FProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarDGVProducto()
        DGVProducto.ClearSelection()
    End Sub

    Private Sub TXTDescripcionCorta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDescripcionCorta.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTDescripcionCorta, LBLValidarDescripcioncorta)
    End Sub

    Private Sub TXTDescripcionCorta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTDescripcionCorta.KeyPress
        objCGenerica.SoloLetra(e)
    End Sub

End Class