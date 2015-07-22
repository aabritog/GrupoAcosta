Imports GrupoAcosta.CGenerica

Public Class FCliente

    Dim objCGenerica As CGenerica = New CGenerica

    Dim bsDGVClienteFilter As New BindingSource

    Public nAction As Integer

    Private Sub cargarCMBProvincia()

        Dim sCadenaSQL As String = "select nid, s_provincia from provincia order by s_provincia"
        Dim dtCMBProvincia As New DataTable
        Dim bsCMBProvincia As New BindingSource

        dtCMBProvincia.Clear()
        bsCMBProvincia.Clear()
        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtCMBProvincia, bsCMBProvincia)

        With CMBProvincia
            .DataSource = bsCMBProvincia
            .DisplayMember = "s_provincia"
            .ValueMember = "nid"
        End With
    End Sub

    Private Sub cargarCMBMunicipio(ByVal nid_municipio As Integer)

        Dim sCadenaSQL As String = "select nid, s_municipio from municipio where nid_provincia=" & nid_municipio & " order by s_municipio"

        Dim dtCMBMunicipio As New DataTable
        Dim bsCMBMunicipio As New BindingSource

        dtCMBMunicipio.Clear()
        bsCMBMunicipio.Clear()
        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtCMBMunicipio, bsCMBMunicipio)

        With CMBMunicipio
            .DataSource = bsCMBMunicipio
            .DisplayMember = "s_municipio"
            .ValueMember = "nid"
        End With
    End Sub

    Private Sub mostrarDGVCliente()

        Dim sCadenaSQL As String = "select d.nid, d.s_cliente, d.nid_municipio, c.s_municipio, d.nid nid_provincia, a.s_provincia, s_rif, s_direccion from cliente d inner join municipio c on d.nid_municipio = c.nid inner join provincia a on a.nid= c.nid_provincia order by d.s_cliente"

        'Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

        Dim dtDGVCliente As New DataTable
        Dim bsDGVCliente As New BindingSource
        Dim BCDGVCliente As New DataGridViewButtonColumn()

        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVCliente, bsDGVCliente)
        bsDGVClienteFilter = bsDGVCliente

        With DGVCliente
            .Columns.Clear()
            .RowHeadersVisible = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            .DataSource = bsDGVCliente
            .ClearSelection()

        End With

        With DGVCliente.Columns("nid")
            .Visible = False
            .HeaderText = "NID"
            .Width = "90"
            .DisplayIndex = "0"

        End With
        With DGVCliente.Columns("s_cliente")
            '.Visible = True
            .HeaderText = "Cliente"
            .Width = "180"
            .DisplayIndex = "1"

        End With

        With DGVCliente.Columns("s_provincia")
            .HeaderText = "Provincia"
            .Width = "180"
            .DisplayIndex = "2"
            .Selected = False

        End With

        With DGVCliente.Columns("nid_municipio")
            .Visible = False
            .HeaderText = "ID Municipio"
            .Width = "180"
            .DisplayIndex = "3"

        End With

        With DGVCliente.Columns("s_municipio")
            '.Visible = True
            .HeaderText = "Municipio"
            .Width = "180"
            .DisplayIndex = "4"

        End With

        With DGVCliente.Columns("s_rif")
            '.Visible = True
            .HeaderText = "Rif"
            .Width = "180"
            .DisplayIndex = "5"
            .ReadOnly = True

        End With

        With DGVCliente.Columns("s_direccion")
            '.Visible = True
            .HeaderText = "Direccion"
            .Width = "180"
            .DisplayIndex = "6"
            .ReadOnly = True

        End With

        With DGVCliente.Columns("nid_provincia")
            .Visible = False
            .HeaderText = "ID Provincia"
            .Width = "180"
            .DisplayIndex = "7"
            .Selected = False

        End With

        With BCDGVCliente
            .Name = "telefono"
            .Text = "Ver >>"
            .HeaderText = "Teléfono"
            .UseColumnTextForButtonValue = True
            .ReadOnly = False

        End With

        DGVCliente.Columns.Add(BCDGVCliente)

    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click


        nAction = 1

        cargarCMBProvincia()

        TXTCliente.Enabled = True
        TXTRif.Enabled = True
        TXTDireccion.Enabled = True
        CMBProvincia.Enabled = True
        TXTBuscar.Enabled = False
        BTNEliminar.Enabled = False
        BTNModificar.Enabled = False
        BTNAgregar.Enabled = False
        BTNGuardar.Enabled = True
        BTNAgregarTelefono.Enabled = True
        BTNCancelar.Enabled = True

        TXTCliente.Focus()

        DGVCliente.Enabled = False
        DGVCliente.ClearSelection()

    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        Dim sSQLAddtelefono_cliente As String
        Dim sId_cliente As String
        Dim nId_cliente As Integer
        Dim sExisteClienteDescripcion As String
        Dim sSQLVerificarExisteClienteDescripcion As String

        If Len(TXTCliente.Text) = 0 Then
            MsgBox("Rellene el campo Cliente", MsgBoxStyle.Information)
            TXTCliente.Focus()
            Exit Sub
        End If

        If Len(TXTProvincia.Text) = 0 Then
            MsgBox("Seleccione la provincia", MsgBoxStyle.Information)
            CMBProvincia.Focus()
            Exit Sub
        End If

        If Len(TXTMunicipio.Text) = 0 Then
            MsgBox("Rellene el campo municipio", MsgBoxStyle.Information)
            TXTMunicipio.Focus()
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

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then

            sExisteClienteDescripcion = ""
            'Antes de agregar un cliente se verifica que no exista un cliente con la misma dexcripcion (descripcion).
            '.................................................................................................................................
            sSQLVerificarExisteClienteDescripcion = "SELECT s_cliente FROM cliente WHERE s_cliente='" & TXTCliente.Text & " '"
            objCGenerica.accederBD(sSQLVerificarExisteClienteDescripcion, sExisteClienteDescripcion)

            If sExisteClienteDescripcion <> "" Then
                MsgBox("Ya existe un cliente con la misma descripcion, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            Dim SQLGuardar As String = ""
            SQLGuardar = "insert into cliente (s_cliente, nid_municipio, s_rif, s_direccion) values ('" & TXTCliente.Text & "', " & TXTMunicipio.Text & ", '" & TXTRif.Text & "', '" & TXTDireccion.Text & "') returning nid"
            sId_cliente = ""

            objCGenerica.accederBD(SQLGuardar, sId_cliente)

            'Se recupera el nid de la persona que se acaba de agregar.
            nId_cliente = CInt(Trim(sId_cliente))

            'Se verifica si el objeto tiene elementos (Si se agrego algun telefono).
            If LVTelefono.Items.Count > 0 Then
                For Each Item As ListViewItem In LVTelefono.Items
                    'Si existen elementos (telefonos) se cargan a la tabla telefono_persona.
                    sSQLAddtelefono_cliente = "insert into telefono (nid_cliente, s_telefono) values (" & nId_cliente & ",'" & Item.Text & "')"
                    objCGenerica.accederBD(sSQLAddtelefono_cliente)
                Next
            End If

            mostrarDGVCliente()

            BTNCancelar_Click(sender, e)

            nAction = 3

            MsgBox("Se ha agregado el cliente exitosamente.", MsgBoxStyle.Information)

            'Si la acción es modificar (modificar registr existente).

        ElseIf nAction = 2 Then

            sExisteClienteDescripcion = ""
            'Antes de agregar un cliente se verifica que no exista un cliente con la misma dexcripcion (descripcion).
            '.................................................................................................................................
            sSQLVerificarExisteClienteDescripcion = "SELECT s_cliente FROM cliente WHERE s_cliente='" & TXTCliente.Text & " 'EXCEPT SELECT nid FROM cliente WHERE s_cliente='" & DGVCliente.CurrentRow.Cells("s_cliente").Value & "' "
            objCGenerica.accederBD(sSQLVerificarExisteClienteDescripcion, sExisteClienteDescripcion)

            If sExisteClienteDescripcion <> "" Then
                MsgBox("Ya existe un cliente con la misma descripcion, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            Dim SQLActualizar As String = ""
            SQLActualizar = "UPDATE cliente SET s_cliente='" & TXTCliente.Text & "', nid_municipio= " & TXTMunicipio.Text & " , s_rif = '" & TXTRif.Text & "', s_direccion= '" & TXTDireccion.Text & "' WHERE nid=" & DGVCliente.CurrentRow.Cells("nid").Value & ""

            objCGenerica.accederBD(SQLActualizar)
            mostrarDGVCliente()
            BTNCancelar_Click(sender, e)

            nAction = 3

            MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos
        TXTCliente.Enabled = False
        TXTRif.Enabled = False
        TXTDireccion.Enabled = False
        CMBMunicipio.Enabled = False
        CMBProvincia.Enabled = False
        TXTBuscar.Enabled = True
        BTNAgregar.Enabled = True
        BTNModificar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNGuardar.Enabled = False
        DGVCliente.Enabled = True

        'Se limpia contenido de los objetos
        TXTCliente.Clear()
        TXTProvincia.Clear()
        TXTMunicipio.Clear()
        TXTBuscar.Clear()

        DGVCliente.Enabled = True
        'Se limpia la seleccion del DataGridView
        DGVCliente.ClearSelection()
        TXTRif.Clear()
        TXTDireccion.Clear()
        LVTelefono.Items.Clear()

        CMBProvincia.DataSource = Nothing
        CMBMunicipio.DataSource = Nothing

        nAction = 0

    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNModificar.Click

        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos
        TXTCliente.Enabled = True
        TXTRif.Enabled = True
        TXTDireccion.Enabled = True
        CMBProvincia.Enabled = True
        CMBMunicipio.Enabled = True
        TXTBuscar.Enabled = False
        BTNAgregar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = True
        BTNModificar.Enabled = False
        BTNGuardar.Enabled = True
        cargarCMBProvincia()
        'Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        TXTCliente.Text = Trim(DGVCliente.CurrentRow.Cells("s_cliente").Value)
        'TXTClave.Text = Trim(DGVUsuario.CurrentRow.Cells("s_clave").Value)
        TXTProvincia.Text = Trim(DGVCliente.CurrentRow.Cells("nid_provincia").Value)
        CMBProvincia.SelectedValue = Trim(DGVCliente.CurrentRow.Cells("nid_provincia").Value)
        cargarCMBMunicipio(Trim(DGVCliente.CurrentRow.Cells("nid_provincia").Value))
        TXTMunicipio.Text = Trim(DGVCliente.CurrentRow.Cells("nid_municipio").Value)
        CMBMunicipio.SelectedValue = Trim(DGVCliente.CurrentRow.Cells("nid_municipio").Value)
        TXTRif.Text = Trim(DGVCliente.CurrentRow.Cells("s_rif").Value)
        TXTDireccion.Text = Trim(DGVCliente.CurrentRow.Cells("s_direccion").Value)

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        'Se declara el elemento eliminar para registros 
        If MsgBox("¿Esta seguro de querer eliminar a este cliente?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQLEliminarCliente As String = ""
            SQLEliminarCliente = "DELETE FROM cliente WHERE nid=" & DGVCliente.CurrentRow.Cells("nid").Value & ""
            objCGenerica.accederBD(SQLEliminarCliente)
            mostrarDGVCliente()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado el cliente", MsgBoxStyle.Information)
        Else
            DGVCliente.ClearSelection()
        End If

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        bsDGVClienteFilter.Filter = "s_cliente like '%" & TXTBuscar.Text & "%' "

        If Len(TXTBuscar.Text) = 0 Then
            DGVCliente.ClearSelection()
        Else
            BTNCancelar.Enabled = True
        End If

    End Sub

    Private Sub TXTDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCliente.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTCliente, LBLValidarCliente)
    End Sub

    Private Sub TXTDescripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCliente.KeyPress

        objCGenerica.SoloLetra(e)
    End Sub

    Private Sub CMBMunicipio_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBMunicipio.SelectionChangeCommitted
        TXTMunicipio.Text = CMBMunicipio.SelectedValue
    End Sub

    Private Sub TXTMunicipio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTMunicipio.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTMunicipio, LBLValidarMunicipio)
    End Sub

    Private Sub FCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarDGVCliente()
        DGVCliente.ClearSelection()
        nAction = 3
    End Sub

    Private Sub DGVCliente_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCliente.CellClick
        BTNModificar.Enabled = True
        BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True
    End Sub

    Private Sub TXTRif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTRif.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTRif, LBLValidarRif)
    End Sub

    Private Sub TXTDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDireccion.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTDireccion, LBLValidarDireccion)
    End Sub

    Private Sub BTNAgregarTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregarTelefono.Click
        FTelefonoCliente.ShowDialog()
    End Sub


    Private Sub DGVCliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCliente.CellContentClick
        If DGVCliente.CurrentRow.Cells("telefono").Selected = True Then
            FTelefonoCliente.ShowDialog()
        End If
    End Sub

    Private Sub CMBProvincia_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBProvincia.SelectionChangeCommitted
        'El TextBox toma el valor seleccionado del ComboBox
        TXTMunicipio.Clear()
        TXTProvincia.Clear()
        CMBMunicipio.DataSource = Nothing
        cargarCMBMunicipio(CMBProvincia.SelectedValue)
        CMBMunicipio.Enabled = True
        TXTProvincia.Text = CMBProvincia.SelectedValue
    End Sub

    Private Sub TXTProvincia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTProvincia.TextChanged
        If Len(TXTProvincia.Text) = 0 Then
            LBLValidarProvincia.Visible = True
        Else
            LBLValidarProvincia.Visible = False
        End If
    End Sub
End Class