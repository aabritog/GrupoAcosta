Imports GrupoAcosta.CGenerica

Public Class FProveedores

    Dim objCGenerica As CGenerica = New CGenerica

    Dim bsDGVProveedoresFilter As New BindingSource

    Public nAction As Integer

    Private Sub mostrarDGVProveedores()

        Dim sCadenaSQL As String = "select d.nid, d.s_descripcion, d.s_descripcioncorta, s_rif, s_direccion from proveedores d where d.s_activo = '1' order by s_descripcion"

        Dim dtDGVProveedores As New DataTable
        Dim bsDGVProveedores As New BindingSource
        Dim BCDGVProveedores As New DataGridViewButtonColumn()

        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVProveedores, bsDGVProveedores)
        bsDGVProveedoresFilter = bsDGVProveedores

        With DGVProveedores
            .Columns.Clear()
            .RowHeadersVisible = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            .DataSource = bsDGVProveedores
            .ClearSelection()

        End With

        With DGVProveedores.Columns("nid")
            .Visible = False
            .HeaderText = "NID"
            .Width = "90"
            .DisplayIndex = "0"
            .ReadOnly = True

        End With
        With DGVProveedores.Columns("s_descripcion")
            '.Visible = True
            .HeaderText = "Descripcion"
            .Width = "180"
            .DisplayIndex = "1"
            .ReadOnly = True

        End With
        With DGVProveedores.Columns("s_descripcioncorta")
            '.Visible = True
            .HeaderText = "Descripcion Corta"
            .Width = "180"
            .DisplayIndex = "2"
            .ReadOnly = True

        End With

        With DGVProveedores.Columns("s_rif")
            '.Visible = True
            .HeaderText = "Rif"
            .Width = "180"
            .DisplayIndex = "3"
            .ReadOnly = True

        End With

        With DGVProveedores.Columns("s_direccion")
            '.Visible = True
            .HeaderText = "Direccion"
            .Width = "180"
            .DisplayIndex = "4"
            .ReadOnly = True

        End With

        With BCDGVProveedores
            .Name = "telefono"
            .Text = "Ver >>"
            .HeaderText = "Teléfono"
            .UseColumnTextForButtonValue = True
            .ReadOnly = False

        End With

        'With DGVProveedores.Columns("d_fecha")
        '    '.Visible = True
        '    .HeaderText = "Fecha"
        '    .Width = "180"
        '    .DisplayIndex = "3"

        'End With

        DGVProveedores.Columns.Add(BCDGVProveedores)
        'DGVProveedores.CurrentRow.Cells("telefono").Selected = True

    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click

        nAction = 1

        TXTDescripcion.Enabled = True
        TXTDescripcionCorta.Enabled = True
        TXTRif.Enabled = True
        TXTDireccion.Enabled = True
        'DTPFecha.Enabled = True
        TXTBuscar.Enabled = False
        BTNEliminar.Enabled = False
        BTNModificar.Enabled = False
        BTNAgregar.Enabled = False
        BTNGuardar.Enabled = True
        BTNCancelar.Enabled = True
        BTNAgregarTelefono.Enabled = True
        TXTDescripcion.Focus()
        DGVProveedores.Enabled = False
        DGVProveedores.ClearSelection()

    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        Dim sSQLAddtelefono_proveedores As String
        Dim sId_proveedor As String
        Dim nId_proveedor As Integer
        Dim sExisteProveedorDescripcion As String
        Dim sSQLVerificarExisteProveedorDescripcion As String

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

        If Len(TXTRif.Text) = 0 Then
            MsgBox("Rellene el campo Rif", MsgBoxStyle.Information)
            TXTRif.Focus()
            Exit Sub
        End If

        If Len(TXTDireccion.Text) = 0 Then
            MsgBox("Rellene el campo Descripción direccion", MsgBoxStyle.Information)
            TXTDireccion.Focus()
            Exit Sub
        End If

        'If Len(TXTFecha.Text) = 0 Then
        '    MsgBox("Rellene el campo fecha", MsgBoxStyle.Information)
        '    TXTFecha.Focus()
        '    Exit Sub
        'End If

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then

            sExisteProveedorDescripcion = ""
            'Antes de agregar un proveedor se verifica que no exista un proveedor con la misma descripcion (descripcion).
            '.................................................................................................................................
            sSQLVerificarExisteProveedorDescripcion = "SELECT s_descripcion FROM proveedores WHERE s_descripcion ='" & TXTDescripcion.Text & " '"
            objCGenerica.accederBD(sSQLVerificarExisteProveedorDescripcion, sExisteProveedorDescripcion)

            If sExisteProveedorDescripcion <> "" Then
                MsgBox("Ya existe un proveedor con la misma descripcion, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            Dim SQLGuardar As String = ""
            SQLGuardar = "insert into proveedores (s_descripcion, s_descripcioncorta, d_fecha, s_activo, s_rif, s_direccion) values ('" & TXTDescripcion.Text & "', '" & TXTDescripcionCorta.Text & "', '" & Date.Today.ToString("yyyy-MM-dd") & "', '1', '" & TXTRif.Text & "', '" & TXTDireccion.Text & "') returning nid"
            sId_proveedor = ""

            objCGenerica.accederBD(SQLGuardar, sId_proveedor)

            'Se recupera el nid de la persona que se acaba de agregar.
            nId_proveedor = CInt(Trim(sId_proveedor))

            'Se verifica si el objeto tiene elementos (Si se agrego algun telefono).
            If LVTelefono.Items.Count > 0 Then
                For Each Item As ListViewItem In LVTelefono.Items
                    'Si existen elementos (telefonos) se cargan a la tabla telefono_persona.
                    sSQLAddtelefono_proveedores = "insert into telefono_proveedor (nid_proveedor, stelefono) values (" & nId_proveedor & ",'" & Item.Text & "')"
                    objCGenerica.accederBD(sSQLAddtelefono_proveedores)
                Next
            End If

            mostrarDGVProveedores()

            BTNCancelar_Click(sender, e)

            nAction = 3

            MsgBox("Se ha agregado el proveedor exitosamente.", MsgBoxStyle.Information)

            'Si la acción es modificar (modificar registr existente).

        ElseIf nAction = 2 Then

            Dim SQLActualizar As String = ""
            SQLActualizar = "UPDATE proveedores SET s_descripcion='" & TXTDescripcion.Text & "',s_descripcioncorta='" & TXTDescripcionCorta.Text & "', d_fecha= '" & Date.Today.ToString("yyyy-MM-dd") & "', s_rif = '" & TXTRif.Text & "', s_direccion = '" & TXTDescripcion.Text & "' WHERE nid=" & DGVProveedores.CurrentRow.Cells("nid").Value & ""

            objCGenerica.accederBD(SQLActualizar)
            mostrarDGVProveedores()
            BTNCancelar_Click(sender, e)

            nAction = 3

            MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

        End If

    End Sub

    'Private Sub DTPFecha_CloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    'El TextBox toma el valor seleccionado del DataTimePicker
    '    TXTFecha.Text = DTPFecha.Value.Date

    'End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos
        TXTDescripcion.Enabled = False
        TXTDescripcionCorta.Enabled = False
        TXTRif.Enabled = False
        TXTDireccion.Enabled = False
        TXTDescripcion.Enabled = False
        TXTBuscar.Enabled = True
        'DTPFecha.Enabled = False
        BTNAgregar.Enabled = True
        BTNModificar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNGuardar.Enabled = False
        DGVProveedores.Enabled = True

        'Se limpia contenido de los objetos
        TXTDescripcion.Clear()
        TXTDescripcionCorta.Clear()
        TXTBuscar.Clear()
        TXTRif.Clear()
        TXTDireccion.Clear()
        LVTelefono.Items.Clear()
        'TXTFecha.Clear()

        DGVProveedores.Enabled = True
        'Se limpia la seleccion del DataGridView
        DGVProveedores.ClearSelection()

        'DTPFecha.Value = "01-01-1940"
        nAction = 0

    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNModificar.Click

        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos
        TXTDescripcion.Enabled = True
        TXTDescripcionCorta.Enabled = True
        TXTRif.Enabled = True
        TXTDireccion.Enabled = True
        'DTPFecha.Enabled = True
        TXTBuscar.Enabled = False
        BTNAgregar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = True
        BTNModificar.Enabled = False
        BTNGuardar.Enabled = True
        'Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        TXTDescripcion.Text = Trim(DGVProveedores.CurrentRow.Cells("s_descripcion").Value)
        'TXTClave.Text = Trim(DGVUsuario.CurrentRow.Cells("s_clave").Value)
        TXTDescripcionCorta.Text = Trim(DGVProveedores.CurrentRow.Cells("s_descripcioncorta").Value)
        TXTRif.Text = Trim(DGVProveedores.CurrentRow.Cells("s_rif").Value)
        TXTDireccion.Text = Trim(DGVProveedores.CurrentRow.Cells("s_direccion").Value)
        'TXTFecha.Text = Trim(DGVProveedores.CurrentRow.Cells("d_fecha").Value)
    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        'Se declara el elemento eliminar para registros 
        If MsgBox("¿Esta seguro de querer eliminar a este proveedor?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQLEliminarProveedores As String = ""
            SQLEliminarProveedores = "DELETE FROM proveedores WHERE nid=" & DGVProveedores.CurrentRow.Cells("nid").Value & ""
            objCGenerica.accederBD(SQLEliminarProveedores)
            mostrarDGVProveedores()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado el proveedor", MsgBoxStyle.Information)
        Else
            DGVProveedores.ClearSelection()
        End If

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        bsDGVProveedoresFilter.Filter = "s_descripcion like '%" & TXTBuscar.Text & "%' "

        If Len(TXTBuscar.Text) = 0 Then
            DGVProveedores.ClearSelection()
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


    Private Sub FProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarDGVProveedores()
        DGVProveedores.ClearSelection()
        nAction = 3
    End Sub

    Private Sub DGVProveedores_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVProveedores.CellClick

        BTNModificar.Enabled = True
        BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True
        BTNAgregar.Enabled = False

    End Sub

    Private Sub TXTDescripcionCorta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTDescripcionCorta.KeyPress
        objCGenerica.SoloLetra(e)
    End Sub

    Private Sub TXTRif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTRif.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTRif, LBLValidarRif)
    End Sub

    Private Sub TXTDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDireccion.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTDireccion, LBLValidarDireccion)
    End Sub

    Private Sub BTNAgregarTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregarTelefono.Click
        FTelefonoProveedores.ShowDialog()
    End Sub

    Private Sub DGVProveedores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVProveedores.CellContentClick
        If DGVProveedores.CurrentRow.Cells("telefono").Selected = True Then
            FTelefonoProveedores.ShowDialog()
        End If
    End Sub

    Private Sub TXTDescripcionCorta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDescripcionCorta.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTDescripcionCorta, LBLValidarDescripcioncorta)
    End Sub


    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class