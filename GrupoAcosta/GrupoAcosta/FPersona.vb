Imports GrupoAcosta.CGenerica

Public Class FPersona

    'Se declara variable de tipo clase para el manejo de funciones genericas
    Dim objCGenerica As CGenerica = New CGenerica

    'Se declara una variable del tipo BindingSource para filtrar los datos del DGVPersona
    Dim bsDGVPersonaFilter As New BindingSource

    'Declaracion de variables auxiliares
    Public nAction As Integer ' *Insertar: nAction = 1. *Modificar: nAction = 2. *Consultar: nAction = 3.


    'Función que permite cargar el ComboBox Departamento
    Private Sub cargarCMBDepartamento()

        Dim sCadenaSQL As String = "select nid, s_descripcion from departamento where s_activo = '1' order by s_descripcion"
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

    'Función que permite cargar el ComboBox Cargo
    Private Sub cargarCMBCargo(ByVal nid_cargo As Integer)

        Dim sCadenaSQL As String = "select nid, s_descripcion from cargo where nid_departamento=" & nid_cargo & " and s_activo = '1' order by s_descripcion"

        Dim dtCMBCargo As New DataTable
        Dim bsCMBCargo As New BindingSource

        dtCMBCargo.Clear()
        bsCMBCargo.Clear()
        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtCMBCargo, bsCMBCargo)

        With CMBCargo
            .DataSource = bsCMBCargo
            .DisplayMember = "s_descripcion"
            .ValueMember = "nid"
        End With
    End Sub

    'Función que permite cargar el DataGridView que muestra la información de las personas.
    Private Sub cargarDGVPersona()

        Dim sCadenaSQL As String = "select p.nid, p.s_nombre1, p.s_nombre2, p.s_apellido1, p.s_apellido2, p.s_nacionalidad, p.s_dni, p.d_fecha_nacimiento, p.s_correo, p.s_sexo, p.nid_cargo, c.s_descripcion s_cargo, d.nid nid_departamento, d.s_descripcion s_departamento from persona p inner join cargo c on p.nid_cargo = c.nid inner join departamento d on d.nid = c.nid_departamento and p.s_activo = '1' order by p.s_nombre1, p.s_nombre2, p.s_apellido1, p.s_apellido2"

        Dim dtDGVPersona As New DataTable
        Dim bsDGVPersona As New BindingSource
        Dim BCDGVPersona As New DataGridViewButtonColumn()

        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVPersona, bsDGVPersona)
        bsDGVPersonaFilter = bsDGVPersona

        With DGVPersona
            .Columns.Clear()
            .RowHeadersVisible = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            .DataSource = bsDGVPersona
            .ClearSelection()
        End With

        With DGVPersona.Columns("nid")
            .Visible = False
            .HeaderText = "NID"
            .Width = "90"
            .DisplayIndex = "0"
            .Selected = False
        End With

        With DGVPersona.Columns("s_nombre1")
            .HeaderText = "Primer Nombre"
            .Width = "180"
            .DisplayIndex = "1"
            .Selected = False
        End With
        With DGVPersona.Columns("s_nombre2")
            .HeaderText = "Segundo Nombre"
            .Width = "180"
            .DisplayIndex = "2"
            .Selected = False
        End With
        With DGVPersona.Columns("s_apellido1")
            .HeaderText = "Apellido Paterno"
            .Width = "180"
            .DisplayIndex = "3"
            .Selected = False
        End With
        With DGVPersona.Columns("s_apellido2")
            .HeaderText = "Apellido Materno"
            .Width = "180"
            .DisplayIndex = "4"
            .Selected = False
        End With
        With DGVPersona.Columns("s_nacionalidad")
            .Visible = True
            .HeaderText = "Nacionalidad"
            .Width = "90"
            .DisplayIndex = "5"
            .Selected = False
        End With
        With DGVPersona.Columns("s_dni")
            .HeaderText = "DNI"
            .Width = "90"
            .DisplayIndex = "6"
            .Selected = False
        End With
        With DGVPersona.Columns("d_fecha_nacimiento")
            .HeaderText = "Fecha Nacimiento"
            .Width = "160"
            .DisplayIndex = "7"
            .Selected = False
        End With
        With DGVPersona.Columns("s_correo")
            .HeaderText = "Correo"
            .Width = "110"
            .DisplayIndex = "8"
            .Selected = False
        End With
        With DGVPersona.Columns("s_sexo")
            .HeaderText = "Sexo"
            .Width = "90"
            .DisplayIndex = "9"
            .Selected = False
        End With
        With DGVPersona.Columns("s_departamento")
            .HeaderText = "Departamento"
            .Width = "180"
            .DisplayIndex = "10"
            .Selected = False
        End With
        With DGVPersona.Columns("nid_cargo")
            .Visible = False
            .HeaderText = "ID Cargo"
            .Width = "20"
            .DisplayIndex = "11"
            .Selected = False
        End With
        With DGVPersona.Columns("s_cargo")
            .HeaderText = "Cargo"
            .Width = "280"
            .DisplayIndex = "12"
            .Selected = False
        End With
        With DGVPersona.Columns("nid_departamento")
            .Visible = False
            .HeaderText = "ID Departamento"
            .Width = "20"
            .DisplayIndex = "13"
            .Selected = False
        End With
        With BCDGVPersona
            .Name = "telefono"
            .Text = "Ver >>"
            .HeaderText = "Teléfono"
            .UseColumnTextForButtonValue = True
        End With

        DGVPersona.Columns.Add(BCDGVPersona)
        'DGVPersona.CurrentRow.Cells("telefono").Selected = True


    End Sub


    Private Sub FPersona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DGVPersona.ClearSelection()
        cargarDGVPersona()
        nAction = 3
    End Sub


    Private Sub BTNAgregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click
        'La variable nAction = 1 porque se va a realizar el proceso de inserción.
        nAction = 1

        cargarCMBDepartamento()

        TXTNombre1.Enabled = True
        TXTNombre2.Enabled = True
        TXTApellido1.Enabled = True
        TXTApellido2.Enabled = True
        TXTCI.Enabled = True
        TXTCorreo.Enabled = True
        TXTBuscar.Enabled = False
        DTPFecha.Enabled = True
        CMBNacionalidad.Enabled = True
        CMBSexo.Enabled = True
        CMBDepartamento.Enabled = True
        BTNEliminar.Enabled = False
        BTNModificar.Enabled = False
        BTNAgregar.Enabled = False
        BTNGuardar.Enabled = True
        BTNCancelar.Enabled = True
        BTNAgregarTelefono.Enabled = True

        TXTNombre1.Focus()

        DGVPersona.Enabled = False
        DGVPersona.ClearSelection()
    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        Dim sSQLAddtelefono_persona As String
        Dim sId_persona As String
        Dim nId_persona As Integer
        Dim sExistePersonaDni As String
        Dim sSQLVerificarExistencia As String
        Dim sExistePersonaCargo As String
        Dim sSQLVerificarExistenciaPersonaCargo As String
        Dim sSQLGuardar As String
        Dim SQLActualizar As String

        If Len(TXTNombre1.Text) = 0 Then
            MsgBox("Ingrese el primer nombre", MsgBoxStyle.Information)
            TXTNombre1.Focus()
            Exit Sub
        End If

        If Len(TXTApellido1.Text) = 0 Then
            MsgBox("Ingrese el apellido paterno", MsgBoxStyle.Information)
            TXTApellido1.Focus()
            Exit Sub
        End If

        If Len(TXTApellido2.Text) = 0 Then
            MsgBox("Ingrese el apellido materno", MsgBoxStyle.Information)
            TXTApellido2.Focus()
            Exit Sub
        End If

        If Len(TXTNacionalidad.Text) = 0 Then
            MsgBox("Selecciona la nacionalidad", MsgBoxStyle.Information)
            TXTCI.Focus()
            Exit Sub
        End If

        If Len(TXTCI.Text) = 0 Then
            MsgBox("Rellene el campo cédula", MsgBoxStyle.Information)
            TXTCI.Focus()
            Exit Sub
        End If

        If Len(TXTFechaNacimiento.Text) = 0 Then
            MsgBox("Seleccione la fecha de nacimiento", MsgBoxStyle.Information)
            DTPFecha.Focus()
            Exit Sub
        End If

        If Len(TXTSexo.Text) = 0 Then
            MsgBox("Seleccione el sexo", MsgBoxStyle.Information)
            CMBSexo.Focus()
            Exit Sub
        End If

        If Len(TXTDepartamento.Text) = 0 Then
            MsgBox("Seleccione el departamento", MsgBoxStyle.Information)
            CMBCargo.Focus()
            Exit Sub
        End If

        If Len(TXTCargo.Text) = 0 Then
            MsgBox("Seleccione el cargo", MsgBoxStyle.Information)
            CMBCargo.Focus()
            Exit Sub
        End If

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then
            sExistePersonaDni = ""
            'Antes de agregar a la nueva persona se verifica que no exista una persona con el mismo documento nacional de identificación (CI).
            '.................................................................................................................................
            sSQLVerificarExistencia = "SELECT s_dni FROM persona WHERE s_dni='" & TXTCI.Text & "'"
            objCGenerica.accederBD(sSQLVerificarExistencia, sExistePersonaDni)

            If sExistePersonaDni <> "" Then
                MsgBox("Ya existe una persona con la misma cedula de identidad, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            sExistePersonaCargo = ""
            'Antes de agregar a la nueva persona se verifica que no exista una persona con el mismo cargo (cargo).
            '.................................................................................................................................
            sSQLVerificarExistenciaPersonaCargo = "SELECT nid_cargo FROM persona WHERE nid_cargo='" & TXTCargo.Text & "'"
            objCGenerica.accederBD(sSQLVerificarExistenciaPersonaCargo, sExistePersonaCargo)

            If sExistePersonaCargo <> "" Then
                MsgBox("Ya existe una persona con el mismo cargo, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            sSQLGuardar = "insert into persona (s_nombre1, s_nombre2, s_apellido1, s_apellido2, s_dni, d_fecha_nacimiento, s_correo, s_sexo, nid_cargo, s_activo, s_nacionalidad) values ('" & TXTNombre1.Text & "', '" & TXTNombre2.Text & "', '" & TXTApellido1.Text & "','" & TXTApellido2.Text & "', '" & TXTCI.Text & "', '" & TXTFechaNacimiento.Text & "', '" & TXTCorreo.Text & "', '" & TXTSexo.Text & "', " & TXTCargo.Text & ", '1', '" & TXTNacionalidad.Text & "') returning nid"
            sId_persona = ""

            objCGenerica.accederBD(sSQLGuardar, sId_persona)

            'Se recupera el nid de la persona que se acaba de agregar.
            nId_persona = CInt(Trim(sId_persona))

            'Se verifica si el objeto tiene elementos (Si se agrego algun telefono).

            If LVTelefonos.Items.Count > 0 Then
                For Each Item As ListViewItem In LVTelefonos.Items
                    'Si existen elementos (telefonos) se cargan a la tabla telefono_persona.
                    sSQLAddtelefono_persona = "insert into telefono_persona (nid_persona, stelefono) values (" & nId_persona & ",'" & Item.Text & "')"
                    objCGenerica.accederBD(sSQLAddtelefono_persona)
                Next
            End If

            cargarDGVPersona()

            BTNCancelar_Click(sender, e)

            nAction = 3

            MsgBox("Se ha agregado la persona exitosamente.", MsgBoxStyle.Information)

            'Si la acción es modificar (modificar registr existente).

        ElseIf nAction = 2 Then
            sExistePersonaDni = ""

            'Rutina utilizada para verificar que en caso de que se vaya a modificar la CI, dicha CI no le pertenezca a otra persona registrada en sistema.
            '.................................................................................................................................
            sSQLVerificarExistencia = "SELECT nid FROM persona where s_dni = '" & TXTCI.Text & "' EXCEPT SELECT nid FROM persona WHERE s_dni='" & DGVPersona.CurrentRow.Cells("s_dni").Value & "' "

            objCGenerica.accederBD(sSQLVerificarExistencia, sExistePersonaDni)
            If sExistePersonaDni <> "" Then
                MsgBox("Ya existe una persona con la misma cedula de identidad, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            sExistePersonaCargo = ""
            'Antes de agregar a la nueva persona se verifica que no exista una persona con el mismo cargo (cargo).
            '.................................................................................................................................
            sSQLVerificarExistenciaPersonaCargo = "SELECT nid_cargo FROM persona WHERE nid_cargo='" & TXTCargo.Text & "'EXCEPT SELECT nid FROM persona WHERE nid_cargo='" & DGVPersona.CurrentRow.Cells("nid_cargo").Value & "' "
            objCGenerica.accederBD(sSQLVerificarExistenciaPersonaCargo, sExistePersonaCargo)

            If sExistePersonaCargo <> "" Then
                MsgBox("Ya existe una persona con el mismo cargo, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            SQLActualizar = "UPDATE persona SET s_nombre1='" & TXTNombre1.Text & "',s_nombre2='" & TXTNombre2.Text & "',s_apellido1='" & TXTApellido1.Text & "',s_apellido2='" & TXTApellido2.Text & "',s_dni='" & TXTCI.Text & "',d_fecha_nacimiento='" & TXTFechaNacimiento.Text & "',s_correo='" & TXTCorreo.Text & "',s_sexo='" & TXTSexo.Text & "',nid_cargo=" & TXTCargo.Text & " WHERE nid=" & DGVPersona.CurrentRow.Cells("nid").Value & ""

            objCGenerica.accederBD(SQLActualizar)
            cargarDGVPersona()
            BTNCancelar_Click(sender, e)

            nAction = 3

            MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub DTPFecha_CloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPFecha.CloseUp
        'El TextBox toma el valor seleccionado del DataTimePicker
        TXTFechaNacimiento.Text = DTPFecha.Value.Date
    End Sub

    Private Sub CMBCI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBNacionalidad.SelectedIndexChanged
        'El TextBox toma el valor seleccionado del ComboBox
        TXTNacionalidad.Text = CMBNacionalidad.SelectedItem
    End Sub

    Private Sub CMBCargo_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBCargo.SelectionChangeCommitted
        'El TextBox toma el valor seleccionado del ComboBox
        TXTCargo.Text = CMBCargo.SelectedValue
    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNModificar.Click

        Dim sVerificarPersonaUsuario As String
        Dim sPersonaUsuario As String = ""


        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos

        If sPersonaUsuario <> "" Then 'Si la persona es usuario del sistema, no se podran modificar sus datos basicos.
            TXTNombre1.Enabled = True
            TXTNombre2.Enabled = True
            TXTApellido1.Enabled = True
            TXTApellido2.Enabled = True
            TXTNacionalidad.Enabled = True
            TXTCI.Enabled = True
            CMBNacionalidad.Enabled = True
        End If
        TXTCorreo.Enabled = True
        DTPFecha.Enabled = True
        CMBSexo.Enabled = True
        CMBDepartamento.Enabled = True
        CMBCargo.Enabled = True
        DGVPersona.Enabled = False
        BTNAgregar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = True
        BTNModificar.Enabled = False
        TXTBuscar.Enabled = False
        BTNGuardar.Enabled = True

        sVerificarPersonaUsuario = "SELECT nid_persona FROM usuario where nid_persona = " & DGVPersona.CurrentRow.Cells("nid").Value & ""
        objCGenerica.accederBD(sVerificarPersonaUsuario, sPersonaUsuario)

        cargarCMBDepartamento()

        'Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        TXTNombre1.Text = Trim(DGVPersona.CurrentRow.Cells("s_nombre1").Value)
        TXTNombre2.Text = Trim(DGVPersona.CurrentRow.Cells("s_nombre2").Value)
        TXTApellido1.Text = Trim(DGVPersona.CurrentRow.Cells("s_apellido1").Value)
        TXTApellido2.Text = Trim(DGVPersona.CurrentRow.Cells("s_apellido2").Value)
        TXTNacionalidad.Text = Trim(DGVPersona.CurrentRow.Cells("s_nacionalidad").Value)
        TXTCI.Text = Trim(DGVPersona.CurrentRow.Cells("s_dni").Value)
        TXTFechaNacimiento.Text = Trim(DGVPersona.CurrentRow.Cells("d_fecha_nacimiento").Value)
        TXTCorreo.Text = Trim(DGVPersona.CurrentRow.Cells("s_correo").Value)
        TXTSexo.Text = Trim(DGVPersona.CurrentRow.Cells("s_sexo").Value)
        TXTDepartamento.Text = Trim(DGVPersona.CurrentRow.Cells("nid_departamento").Value)
        TXTCargo.Text = Trim(DGVPersona.CurrentRow.Cells("nid_cargo").Value)

        DTPFecha.Text = Trim(DGVPersona.CurrentRow.Cells("d_fecha_nacimiento").Value)

        CMBSexo.SelectedItem = Trim(DGVPersona.CurrentRow.Cells("s_sexo").Value)
        CMBDepartamento.SelectedValue = Trim(DGVPersona.CurrentRow.Cells("nid_departamento").Value)
        cargarCMBCargo(Trim(DGVPersona.CurrentRow.Cells("nid_departamento").Value))
        CMBCargo.SelectedValue = Trim(DGVPersona.CurrentRow.Cells("nid_cargo").Value)
        CMBNacionalidad.SelectedItem = Trim(DGVPersona.CurrentRow.Cells("s_nacionalidad").Value)


    End Sub

    Private Sub CMBSexo_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBSexo.SelectionChangeCommitted
        'El TextBox toma el valor seleccionado del ComboBox
        TXTSexo.Text = CMBSexo.SelectedItem
    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click

        Dim sSQLEliminarPersona As String
        Dim sVerificarPersonaUsuario As String
        Dim sPersonaUsuario As String = ""

        'Antes de proceder a eliminar a la persona seleccionada se verifica si la misma no es usuario del sistema.
        sVerificarPersonaUsuario = "SELECT nid_persona FROM usuario where nid_persona = " & DGVPersona.CurrentRow.Cells("nid").Value & ""
        objCGenerica.accederBD(sVerificarPersonaUsuario, sPersonaUsuario)

        If sPersonaUsuario <> "" Then
            MsgBox("No se puede eliminar la persona seleccionada porque es usuario del sistema.", MsgBoxStyle.Information)
            Exit Sub
        End If

        sSQLEliminarPersona = "DELETE FROM persona WHERE nid=" & DGVPersona.CurrentRow.Cells("nid").Value & ""

        If MsgBox("¿Esta seguro de querer eliminar a esta persona?. No se podran recuperar los datos.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            objCGenerica.accederBD(sSQLEliminarPersona)
            cargarDGVPersona()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado la persona exitosamente.", MsgBoxStyle.Information)
        Else
            DGVPersona.ClearSelection()
        End If

    End Sub

    Private Sub DGVPersona_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPersona.CellClick

        BTNModificar.Enabled = True
        BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos
        TXTNombre1.Enabled = False
        TXTNombre2.Enabled = False
        TXTApellido1.Enabled = False
        TXTApellido2.Enabled = False
        TXTNacionalidad.Enabled = False
        TXTCI.Enabled = False
        TXTCorreo.Enabled = False
        TXTBuscar.Enabled = True
        DTPFecha.Enabled = False
        CMBNacionalidad.Enabled = False
        CMBSexo.Enabled = False
        CMBDepartamento.Enabled = False
        CMBCargo.Enabled = False
        DGVPersona.Enabled = True
        BTNAgregar.Enabled = True
        BTNModificar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNGuardar.Enabled = False
        BTNAgregarTelefono.Enabled = False

        'Se limpia contenido de los objetos
        TXTNombre1.Clear()
        TXTNombre2.Clear()
        TXTApellido1.Clear()
        TXTApellido2.Clear()
        TXTCI.Clear()
        TXTNacionalidad.Clear()
        TXTFechaNacimiento.Clear()
        TXTCorreo.Clear()
        TXTSexo.Clear()
        TXTDepartamento.Clear()
        TXTCargo.Clear()
        TXTBuscar.Clear()
        LVTelefonos.Items.Clear()

        DGVPersona.Enabled = True
        'Se limpia la seleccion del DataGridView
        DGVPersona.ClearSelection()

        CMBDepartamento.DataSource = Nothing
        CMBCargo.DataSource = Nothing
        DTPFecha.Value = "01-01-1940"

        nAction = 3

    End Sub

    Private Sub CMBDepartamento_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBDepartamento.SelectionChangeCommitted
        'El TextBox toma el valor seleccionado del ComboBox
        TXTCargo.Clear()
        TXTDepartamento.Clear()
        CMBCargo.DataSource = Nothing
        cargarCMBCargo(CMBDepartamento.SelectedValue)
        CMBCargo.Enabled = True
        TXTDepartamento.Text = CMBDepartamento.SelectedValue

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        bsDGVPersonaFilter.Filter = "s_nombre1 like '%" & TXTBuscar.Text & "%' OR s_nombre2 like '%" & TXTBuscar.Text & "%' OR s_apellido1 like '%" & TXTBuscar.Text & "%' OR s_apellido2 like '%" & TXTBuscar.Text & "%' OR s_dni like '%" & TXTBuscar.Text & "%'"

        If Len(TXTBuscar.Text) = 0 Then
            DGVPersona.ClearSelection()
        Else
            BTNCancelar.Enabled = True
        End If

    End Sub

    Private Sub TXTNombre1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTNombre1.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTNombre1, LBValidarNombre1)
    End Sub

    Private Sub TXTApellido1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTApellido1.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTApellido1, LBValidarApellido1)
    End Sub

    Private Sub TXTApellido2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTApellido2.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTApellido2, LBValidarApellido2)
    End Sub

    Private Sub TXTCI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCI.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTCI, LBValidarCi)
    End Sub

    Private Sub TXTFechaNacimiento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTFechaNacimiento.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTFechaNacimiento, LBValidarFechaNacimiento)
    End Sub

    Private Sub TXTSexo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTSexo.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTSexo, LBValidarSexo)
    End Sub

    Private Sub TXTDepartamento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDepartamento.TextChanged
        If Len(TXTDepartamento.Text) = 0 Then
            LBValidarDpto.Visible = True
        Else
            LBValidarDpto.Visible = False
        End If
    End Sub

    Private Sub TXTCargo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCargo.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTCargo, LBValidarCargo)
    End Sub

    Private Sub TXTNacionalidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTNacionalidad.TextChanged

        objCGenerica.valCampoObligatorio(Me.TXTNacionalidad, LBValidadNacionalidad)
    End Sub

    Private Sub TXTNombre1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTNombre1.KeyPress
        'Se llama la funcion SoloLetras que esta en la clase CGenerica.
        objCGenerica.SoloLetra(e)
    End Sub

    Private Sub TXTCI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCI.KeyPress
        'Se llama la funcion SoloNumeros que esta en la clase CGenerica.
        objCGenerica.SoloNumero(e)
    End Sub

    Private Sub TXTNombre2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTNombre2.KeyPress
        'Se llama la funcion SoloLetras que esta en la clase CGenerica.
        objCGenerica.SoloLetra(e)
    End Sub

    Private Sub TXTApellido1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTApellido1.KeyPress
        'Se llama la funcion SoloLetras que esta en la clase CGenerica.
        objCGenerica.SoloLetra(e)
    End Sub

    Private Sub TXTApellido2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTApellido2.KeyPress
        'Se llama la funcion SoloLetras que esta en la clase CGenerica.
        objCGenerica.SoloLetra(e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregarTelefono.Click
        FTelefonoPersona.ShowDialog()
    End Sub

    Private Sub DGVPersona_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPersona.CellContentClick

        If DGVPersona.CurrentRow.Cells("telefono").Selected = True Then
            FTelefonoPersona.ShowDialog()
        End If

    End Sub

    Private Sub DTPFecha_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPFecha.Leave
        DTPFecha_CloseUp(sender, e)
    End Sub

    Private Sub BNTReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FReporte.sNombre_reporte = "Visualizar_Persona"
        FReporte.ShowDialog()
    End Sub

    Private Sub BTNSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click
        Me.Dispose()
    End Sub
    
End Class



