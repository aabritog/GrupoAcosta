Imports GrupoAcosta.CGenerica

Public Class FUsuario
    Dim objCGenerica As CGenerica = New CGenerica
    Dim DatosDataTableDGVUsuario As New DataTable
    Dim DatosBindingSourceDGVUsuario As New BindingSource
    Dim DatosDataTableCMBRol As New DataTable
    Dim DatosBindingSourceCMBRol As New BindingSource
    Public pusuario As Integer
    Public nAction As Integer


    Private Sub accederBD(ByVal CadenaSQL As String, Optional ByRef valorRetorno As Boolean = False)
        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)
            conexion.Open()
            Dim comando As New Odbc.OdbcCommand(CadenaSQL, conexion)
            Dim reader As Odbc.OdbcDataReader = comando.ExecuteReader

            If reader.HasRows Then
                valorRetorno = True
            End If

            reader.Close()
            conexion.Close()
        End Using
    End Sub

    Private Sub cargarCMBRol()
        Dim CadenaSQL As String = ""
        CadenaSQL = "select nid, s_descripcion from rol order by s_descripcion"
        DatosDataTableCMBRol.Clear()
        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)
            Using DatosDataAdapter As New Odbc.OdbcDataAdapter(CadenaSQL, conexion)
                DatosDataAdapter.Fill(DatosDataTableCMBRol)
                DatosBindingSourceCMBRol.DataSource = DatosDataTableCMBRol
            End Using
            With CMBRol
                .DataSource = DatosBindingSourceCMBRol

                .DisplayMember = "s_descripcion"
                .ValueMember = "nid"
            End With
        End Using
    End Sub

    Private Sub mostrarDGVUsuario()

        Dim CadenaSQL As String = ""

        'CadenaSQL = "select p.nid, p.s_nombre1, p.s_nombre2, p.s_apellido1, p.s_apellido2, p.s_dni, p.d_fecha_nacimiento, p.s_correo, p.s_sexo, p.nid_cargo, c.s_descripcion s_cargo, d.nid nid_departamento, d.s_descripcion s_departamento from persona p inner join cargo c on p.nid_cargo = c.nid inner join departamento d on d.nid = c.nid_departamento order by p.s_nombre1, p.s_nombre2, p.s_apellido1, p.s_apellido2"
        'CadenaSQL = "select u.nid, u.nid_persona, u.s_clave, u.nid_rol, u.s_seudonimo, u.s_activo, r.s_descripcion s_rol, p.s_nombre1 s_nombre, p.s_apellido1 s_apellido from usuario u inner join rol r on u.nid_rol = r.nid inner join persona p on u.nid_persona = p.nid"
        CadenaSQL = "select u.nid, u.nid_persona, u.s_clave, u.nid_rol, u.s_seudonimo, r.s_descripcion s_rol, p.s_nombre1 || ' ' || p.s_apellido1 s_nombre from usuario u inner join rol r on u.nid_rol = r.nid inner join persona p on u.nid_persona = p.nid and u.s_activo='1'"

        DatosDataTableDGVUsuario.Clear()

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Using DatosDataAdapter As New Odbc.OdbcDataAdapter(CadenaSQL, conexion)
                DatosDataAdapter.Fill(DatosDataTableDGVUsuario)
                DatosBindingSourceDGVUsuario.DataSource = DatosDataTableDGVUsuario
            End Using

            '
            With DGVUsuario
                .RowHeadersVisible = False
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = DatosBindingSourceDGVUsuario
                .ClearSelection()

            End With
            With DGVUsuario.Columns("nid")
                .Visible = False
                .HeaderText = "NID"
                .Width = "90"
                .DisplayIndex = "0"

            End With
            With DGVUsuario.Columns("nid_persona")
                .Visible = False
                .HeaderText = "Nid Persona"
                .Width = "180"
                .DisplayIndex = "1"

            End With
            With DGVUsuario.Columns("s_clave")
                .Visible = False
                .HeaderText = "Clave"
                .Width = "180"
                .DisplayIndex = "2"

            End With
            With DGVUsuario.Columns("nid_rol")
                .Visible = False
                .HeaderText = "ID Rol"
                .Width = "180"
                .DisplayIndex = "3"

            End With
            With DGVUsuario.Columns("s_seudonimo")
                ' .Visible = True
                .HeaderText = "Seudonimo"
                .Width = "180"
                .DisplayIndex = "4"

            End With

            With DGVUsuario.Columns("s_rol")
                .Visible = True
                .HeaderText = "Rol"
                .Width = "180"
                .DisplayIndex = "5"
            End With

            With DGVUsuario.Columns("s_nombre")
                .Visible = True
                .HeaderText = "Nombre"
                .Width = "160"
                .DisplayIndex = "6"
            End With


        End Using

    End Sub


    Private Sub FUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DGVUsuario.ClearSelection()
        mostrarDGVUsuario()
        TXTBuscar.Enabled = True
    End Sub


    Private Sub BTNNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNuevo.Click
        nAction = 1
        cargarCMBRol()

        BTNPersona.Enabled = True

        TXTSeudonimo.Enabled = True
        TXTClave.Enabled = True
        TXTConfirmarClave.Enabled = True

        If TXTClave.Text = TXTConfirmarClave.Text Then

            TXTBuscar.Enabled = False

            CMBRol.Enabled = True

            BTNEliminar.Enabled = False
            BTNModificar.Enabled = False
            BTNNuevo.Enabled = False
            BTNGuardar.Enabled = True
            BTNCancelar.Enabled = True
            TXTSeudonimo.Focus()

            DGVUsuario.ClearSelection()

        Else

            MsgBox("Las claves no coinciden", MsgBoxStyle.Information)

            'se limpian los registros

            TXTSeudonimo.Clear()
            TXTClave.Clear()
            TXTConfirmarClave.Clear()

            CMBRol.Enabled = False

        End If

    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        Dim sExisteUsuarioSeudonimo As String
        Dim sSQLVerificarExisteUsuarioSeudonimo As String
        Dim sExisteUsuarioRol As String
        Dim sSQLVerificarExisteUsuarioRol As String

        If Len(TXTSeudonimo.Text) = 0 Then
            MsgBox("Rellene el campo Seudonimo", MsgBoxStyle.Information)
            TXTSeudonimo.Focus()
            Exit Sub
        End If

        If Len(TXTClave.Text) = 0 Then
            MsgBox("Rellene el campo Clave", MsgBoxStyle.Information)
            TXTClave.Focus()
            Exit Sub
        End If

        If Len(TXTConfirmarClave.Text) = 0 Then
            MsgBox("Rellene el campo Confirmar Clave", MsgBoxStyle.Information)
            TXTConfirmarClave.Focus()
            Exit Sub
        End If

        If Len(TXTRol.Text) = 0 Then
            MsgBox("Rellene el campo Rol", MsgBoxStyle.Information)
            TXTRol.Focus()
            Exit Sub
        End If

        'Si la acción es insertar (crear un nuevo registro).
        If nAction = 1 Then

            sExisteUsuarioSeudonimo = ""
            'Antes de agregar al usuario se verifica que no exista un usuario con el mismo seudonimo (seudonimo).
            '.................................................................................................................................
            sSQLVerificarExisteUsuarioSeudonimo = "SELECT s_seudonimo FROM usuario WHERE s_seudonimo='" & TXTSeudonimo.Text & " '"
            objCGenerica.accederBD(sSQLVerificarExisteUsuarioSeudonimo, sExisteUsuarioSeudonimo)

            If sExisteUsuarioSeudonimo <> "" Then
                MsgBox("Ya existe un usuario con el mismo seudonimo, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            sExisteUsuarioRol = ""
            'Antes de agregar al usuario se verifica que no exista un usurio con el mismo rol (rol).
            '.................................................................................................................................
            sSQLVerificarExisteUsuarioRol = "SELECT nid_rol FROM usuario WHERE nid_rol='" & TXTRol.Text & " '"
            objCGenerica.accederBD(sSQLVerificarExisteUsuarioRol, sExisteUsuarioRol)

            If sExisteUsuarioSeudonimo <> "" Then
                MsgBox("Ya existe un usuario con el mismo rol, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            Dim SQLGuardar As String = ""
            SQLGuardar = "insert into usuario (s_seudonimo, s_clave, nid_rol, s_activo, nid_persona) values ('" & TXTSeudonimo.Text & "', '" & TXTClave.Text & "', " & TXTRol.Text & ", '1', " & TXTPersonasNoUsuarios.Text & ")"
            'MD5('" & TBClave1.Text & "')
            accederBD(SQLGuardar)

            mostrarDGVUsuario()

            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se ha agregado la persona exitosamente.", MsgBoxStyle.Information)

            'Si la acción es modificar (modificar registr existente).

        ElseIf nAction = 2 Then

            sExisteUsuarioSeudonimo = ""
            'Rutina utilizada para verificar que en caso de que se vaya a modificar el seudonimo, dicho seudonimo no le pertenezca a otro usuario registrado en sistema.
            '.................................................................................................................................
            sSQLVerificarExisteUsuarioSeudonimo = "SELECT s_seudonimo FROM usuario WHERE s_seudonimo='" & TXTSeudonimo.Text & "' EXCEPT SELECT s_seudonimo FROM usuario WHERE s_seudonimo='" & DGVUsuario.CurrentRow.Cells("s_seudonimo").Value & "' "
            objCGenerica.accederBD(sSQLVerificarExisteUsuarioSeudonimo, sExisteUsuarioSeudonimo)

            If sExisteUsuarioSeudonimo <> "" Then
                MsgBox("Ya existe un usuario con el mismo seudonimo, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            '.................................................................................................................................

            sExisteUsuarioRol = ""
            'Rutina utilizada para verificar que en caso de que se vaya a modificar el rol, dicho rol no le pertenezca a otro usuario registrado en sistema.
            '.................................................................................................................................
            'sSQLVerificarExisteUsuarioRol = "SELECT nid_rol FROM usuario WHERE nid_rol='" & TXTRol.Text & "' EXCEPT SELECT nid FROM usuario WHERE nid_rol='" & DGVUsuario.CurrentRow.Cells("nid_rol").Value & "' "
            'objCGenerica.accederBD(sSQLVerificarExisteUsuarioRol, sExisteUsuarioRol)

            'If sExisteUsuarioRol <> "" Then
            '    MsgBox("Ya existe un usuario con el mismo rol, verifique.", MsgBoxStyle.Exclamation, "Advertencia")
            '    Exit Sub
            'End If
            '.................................................................................................................................
            Dim SQLActualizar As String = ""
            SQLActualizar = "UPDATE usuario SET s_seudonimo='" & TXTSeudonimo.Text & "',s_clave='" & TXTClave.Text & "', nid_rol= " & TXTRol.Text & " WHERE nid=" & DGVUsuario.CurrentRow.Cells("nid").Value & ""

            accederBD(SQLActualizar)
            mostrarDGVUsuario()
            BTNCancelar_Click(sender, e)

            nAction = 0

            MsgBox("Se han guardado los cambios exitosamente.", MsgBoxStyle.Information)

        End If

    End Sub


    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos
        TXTSeudonimo.Enabled = False
        TXTClave.Enabled = False
        TXTConfirmarClave.Enabled = False
        TXTRol.Enabled = False
        TXTBuscar.Enabled = True
        CMBRol.Enabled = False
        DGVUsuario.Enabled = True
        BTNNuevo.Enabled = True
        BTNModificar.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = False
        BTNGuardar.Enabled = False
        BTNPersona.Enabled = False

        'Se limpia la seleccion del DataGridView
        DGVUsuario.ClearSelection()

        'Se limpia contenido de los objetos
        TXTSeudonimo.Clear()
        TXTClave.Clear()
        TXTConfirmarClave.Clear()
        TXTRol.Clear()

        DatosBindingSourceCMBRol.DataSource = Nothing

        nAction = 0

    End Sub

    Private Sub CMBRol_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBRol.SelectionChangeCommitted

        TXTRol.Text = CMBRol.SelectedValue

    End Sub

    Private Sub BTNModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNModificar.Click

        'La variable nAction = 2 porque se va a realizar el proceso de modificación
        nAction = 2

        'Se habilitan/deshabilitan los objetos
        TXTSeudonimo.Enabled = True
        TXTClave.Enabled = True
        TXTConfirmarClave.Enabled = True
        TXTBuscar.Enabled = False

        CMBRol.Enabled = True

        DGVUsuario.Enabled = False
        BTNNuevo.Enabled = False
        BTNEliminar.Enabled = False
        BTNCancelar.Enabled = True
        BTNModificar.Enabled = False
        BTNGuardar.Enabled = True

        cargarCMBRol()

        'Los objetos se cargan con la informacion del registro seleccionado del DataGridView
        TXTSeudonimo.Text = Trim(DGVUsuario.CurrentRow.Cells("s_seudonimo").Value)
        'TXTClave.Text = Trim(DGVUsuario.CurrentRow.Cells("s_clave").Value)
        CMBRol.SelectedValue = Trim(DGVUsuario.CurrentRow.Cells("nid_rol").Value)
        TXTRol.Text = Trim(DGVUsuario.CurrentRow.Cells("nid_rol").Value)

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click

        Me.Dispose()

    End Sub

    Private Sub SoloNumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Rutina utilizada para validar que en el TBCi se puedan introducir solo numeros.

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub SoloLetras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Rutina utilizada para validar que en el TBNombres se puedan introducir solo Letras A-Z y a-z.
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click

        'Se declara el elemento eliminar para registros 
        If MsgBox("¿Esta seguro de querer eliminar a este usuario?. No se podran recuperar los datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQLEliminarPersona As String = ""
            SQLEliminarPersona = "DELETE FROM usuario WHERE nid=" & DGVUsuario.CurrentRow.Cells("nid").Value & ""
            accederBD(SQLEliminarPersona)
            mostrarDGVUsuario()
            BTNCancelar_Click(sender, e)
            MsgBox("Se ha eliminado el usuario", MsgBoxStyle.Information)
        Else
            DGVUsuario.ClearSelection()
        End If

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        DatosBindingSourceDGVUsuario.Filter = "s_seudonimo like '%" & TXTBuscar.Text & "%'  OR s_nombre like '%" & TXTBuscar.Text & "%' "

    End Sub

    Private Sub BTNPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNPersona.Click

        FPersonasUsuarios.ShowDialog()


    End Sub


    Private Sub TXTSeudonimo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTSeudonimo.TextChanged

        If Len(TXTSeudonimo.Text) = 0 Then
            LBLValidarSeudonimo.Visible = True
        Else
            LBLValidarSeudonimo.Visible = False
        End If

    End Sub

    Private Sub TXTClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTClave.TextChanged

        If Len(TXTClave.Text) = 0 Then
            LBLValidarClave.Visible = True
        Else
            LBLValidarClave.Visible = False
        End If

    End Sub

    Private Sub TXTConfirmarClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTConfirmarClave.TextChanged

        If Len(TXTConfirmarClave.Text) = 0 Then
            LBLValidarConfirmarClave.Visible = True
        Else
            LBLValidarConfirmarClave.Visible = False
        End If

    End Sub

    Private Sub TXTRol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTRol.TextChanged

        If Len(TXTRol.Text) = 0 Then
            LBLValidarRol.Visible = True
        Else
            LBLValidarRol.Visible = False
        End If

    End Sub



    Private Sub DGVUsuario_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVUsuario.CellClick

        BTNModificar.Enabled = True
        BTNEliminar.Enabled = True
        BTNCancelar.Enabled = True
        TXTBuscar.Enabled = True

    End Sub

    Private Sub TXTSeudonimo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTSeudonimo.KeyPress

        SoloLetras(e)

    End Sub

    Private Sub TXTClave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTClave.KeyPress

        SoloNumeros(e)

    End Sub


    Private Sub TXTConfirmarClave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTConfirmarClave.KeyPress

        SoloNumeros(e)

    End Sub

End Class
