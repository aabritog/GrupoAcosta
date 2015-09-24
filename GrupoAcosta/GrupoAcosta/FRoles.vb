Public Class FRoles

    'Se declara variable de tipo clase para el manejo de funciones genericas
    Dim objCGenerica As CGenerica = New CGenerica

    Public id_rol As Integer
    Dim msj_camposObligatorios As String = "Debe rellenar los campos obligatorios *"

    Dim DatosDataTableDGVRoles As New DataTable
    Dim DatosBindingSourceDGVRoles As New BindingSource

    'Private Sub cargarPrivFRoles()
    '    Dim CadenaSQL As String = ""
    '    CadenaSQL = "SELECT privilegio,activo FROM v_global WHERE identificador='" & FAcceso.id_user & "'"

    '    Using Conexion As New Odbc.OdbcConnection(My.Settings.CadenaDeConexion) 'Se declara la conexion haciendo uso del using
    '        Conexion.Open() 'Se abre la conexion
    '        Dim Comando As New Odbc.OdbcCommand(CadenaSQL, Conexion) 'Se declara el comando que se va a ejecutar y se conecta
    '        Dim reader As Odbc.OdbcDataReader = Comando.ExecuteReader() 'Se ejecuta la lectura de los valores encontrados en la consulta

    '        Dim NombreObjeto As String

    '        If reader.HasRows Then
    '            While reader.Read
    '                NombreObjeto = Trim(reader("privilegio"))
    '                If BTNCrearRol.Name = NombreObjeto Then
    '                    BTNCrearRol.Enabled = CBool(reader("activo"))
    '                End If
    '                For k = 0 To DGVRoles.Columns.Count
    '                    Dim columna As DataGridViewColumn
    '                    For Each columna In DGVRoles.Columns
    '                        If columna.Name = NombreObjeto Then
    '                            columna.Visible = CBool(reader("activo"))
    '                        End If
    '                    Next
    '                Next

    '            End While
    '        End If
    '        reader.Close()
    '        Conexion.Close()
    '    End Using
    'End Sub


    'Función que permite cargar el DataGridView que muestra la información de las personas.
    Private Sub cargarDGVRoles()

        Dim sCadenaSQL As String = "SELECT nid, s_descripcion FROM rol WHERE b_activo=TRUE ORDER BY s_descripcion ASC"

        Dim dtDGVRoles As New DataTable
        Dim bsDGVRoles As New BindingSource
        Dim BCDGVRoles As New DataGridViewButtonColumn()

        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVRoles, bsDGVRoles)
        'bsDGVPersonaFilter = bsDGVPersona

            Dim botonDGVRoles As New DataGridViewButtonColumn()
        With botonDGVRoles
            .Name = "privilegio"
            .Text = "Definir"
            .UseColumnTextForButtonValue = True
            '.DisplayIndex = 0
        End With
        DGVRoles.Columns.Clear()
        With DGVRoles
            .DataSource = bsDGVRoles
            .Columns.Add(botonDGVRoles)
            .ClearSelection()
            .MultiSelect = False
            .TabStop = False
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            .ReadOnly = True
        End With
        With DGVRoles.Columns("nid")
            .Visible = False
            .HeaderText = "ID"
            .Width = "30"
        End With
        With DGVRoles.Columns("s_descripcion")
            .HeaderText = "Rol:"
            .Width = "175"
            .Selected = False
        End With
        With DGVRoles.Columns("privilegio")
            .Name = "privilegio"
            .Width = "80"
            .HeaderText = "Privilegios"
        End With
    End Sub



    Private Sub cargarDGVRolesr()
        DatosDataTableDGVRoles.Clear()
        DatosBindingSourceDGVRoles.DataSource = Nothing
        DGVRoles.Columns.Clear()
        Dim SQLDGVRoles As String = ""
        SQLDGVRoles = "SELECT nid, s_descripcion FROM rol WHERE b_activo=TRUE ORDER BY s_descripcion ASC"
        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)
            Using DatosDataReader As New Odbc.OdbcDataAdapter(SQLDGVRoles, conexion)
                DatosDataReader.Fill(DatosDataTableDGVRoles)
                DatosBindingSourceDGVRoles.DataSource = DatosDataTableDGVRoles
            End Using

            Dim botonDGVRoles As New DataGridViewButtonColumn()
            With botonDGVRoles
                .Name = "privilegio"
                .Text = "Definir"
                .UseColumnTextForButtonValue = True
                '.DisplayIndex = 0
            End With
            With DGVRoles
                .DataSource = DatosBindingSourceDGVRoles
                .Columns.Add(botonDGVRoles)
                .ClearSelection()
                .MultiSelect = False
                .TabStop = False
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .ReadOnly = True
            End With
            With DGVRoles.Columns("nid")
                .Visible = False
                .HeaderText = "ID"
                .Width = "30"
            End With
            With DGVRoles.Columns("s_descripcion")
                .HeaderText = "Rol:"
                .Width = "175"
                .Selected = False
            End With
            With DGVRoles.Columns("privilegio")
                .Name = "privilegio"
                .Width = "80"
                .HeaderText = "Privilegios"
            End With
        End Using

    End Sub

    Private Sub FUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarDGVRoles()
    End Sub

    Private Sub BTNCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCrearRol.Click

        If Len(Trim(TXTNuevoRol.Text)) = 0 Then
            MsgBox(msj_camposObligatorios, MsgBoxStyle.Information, "Advertencia")
            TXTNuevoRol.Focus()
            Exit Sub
        End If

        Dim SQLCrearRol As String = ""
        Dim SQLCantPrivilegios As String = ""
        Dim SQLArray As String = ""

        'Dim SQLIdRolNuevo As String = ""
        Dim SQLCrearPrivilegios As String = ""
        Dim id_nuevoRol As Integer
        Dim n_priv As Integer

        SQLCrearRol = "INSERT INTO rol (s_descripcion, s_descripcioncorta,b_activo) VALUES ('" & TXTNuevoRol.Text & "','',TRUE) RETURNING nid"
        SQLCantPrivilegios = "SELECT COUNT(nid) FROM privilegios"                            'SQLCantPrivilegios = "SELECT COUNT(DISTINCT(id_privilegio)) FROM rol_privilegio"
        SQLArray = "SELECT nid FROM privilegios ORDER BY nid"

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)
            conexion.Open()
            Dim ComandoCrearRol As New Odbc.OdbcCommand(SQLCrearRol, conexion)
            Dim ComandoCantPrivilegios As New Odbc.OdbcCommand(SQLCantPrivilegios, conexion)
            Dim ComandoArray As New Odbc.OdbcCommand(SQLArray, conexion)

            Dim reader As Odbc.OdbcDataReader = ComandoCrearRol.ExecuteReader()

            If reader.Read() Then
                id_nuevoRol = reader("nid")
            End If
            reader.Close() 'ComandoCrearRol

            reader = ComandoCantPrivilegios.ExecuteReader
            If reader.Read() Then
                n_priv = reader("count")
            End If
            reader.Close() 'ComandoCantPrivilegios

            reader = ComandoArray.ExecuteReader
            Dim tamanoArray As Integer = n_priv - 1
            Dim array(tamanoArray) As Integer
            Dim j As Integer = 0

            While j < n_priv
                While reader.Read
                    array(j) = reader("nid")
                    j = j + 1
                End While
            End While
            reader.Close() 'ComandoArray
            Dim i As Integer = 1
            j = 0
            While i <= n_priv
                SQLCrearPrivilegios = "INSERT INTO rol_privilegios (nid_rol,nid_privilegios,b_activo) VALUES (" & id_nuevoRol & "," & array(j) & ",FALSE)"
                Dim ComandoCrearPrivilegios As New Odbc.OdbcCommand(SQLCrearPrivilegios, conexion)
                reader = ComandoCrearPrivilegios.ExecuteReader
                i = i + 1
                j = j + 1
            End While
            reader.Close()
            conexion.Close()
        End Using
        cargarDGVRoles()
    End Sub

    Private Sub DGVRoles_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVRoles.CellClick
        If DGVRoles.CurrentRow.Cells("nid").Value <> 1 And DGVRoles.CurrentRow.Cells("nid").Value <> 2 And DGVRoles.CurrentRow.Cells("nid").Value <> 3 Then
            BTNEliminar.Enabled = True
            BTNCrearRol.Enabled = False
        Else
            BTNEliminar.Enabled = False
        End If
        If DGVRoles.CurrentRow.Cells("nid").Value = 1 Or DGVRoles.CurrentRow.Cells("nid").Value = 2 Or DGVRoles.CurrentRow.Cells("nid").Value = 3 Then
            BTNEliminar.Enabled = False
        Else
            BTNEliminar.Enabled = True
            BTNCrearRol.Enabled = False
        End If
        If DGVRoles.CurrentRow.Cells("privilegio").Selected = True Then
            id_rol = DGVRoles.CurrentRow.Cells("nid").Value 'Variable que utilizare para hacer la consulta SQL necesaria para mostrar el rol con los privilegios respectivos
            FPrivilegios.ShowDialog()
        End If


    End Sub


    Private Sub TBNuevoRol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTNuevoRol.TextChanged
        If Len(TXTNuevoRol.Text) = 0 Then
            LBValidarNuevoRol.Visible = True
        Else
            LBValidarNuevoRol.Visible = False
        End If
    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click
        Me.Dispose()
    End Sub

    Public Sub AccederBD(ByVal ConsultaSQL As String, Optional ByRef valorRetorno As Boolean = False)
        Dim Conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)
        Conexion.Open()
        Dim Comando As New Odbc.OdbcCommand(ConsultaSQL, Conexion)
        Dim reader As Odbc.OdbcDataReader = Comando.ExecuteReader()
        If reader.HasRows Then
            Dim id_tipo As Integer
            id_tipo = reader(0)
            valorRetorno = True
        End If
        Conexion.Close()
    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        Dim rolAsignado As Boolean = False
        Dim SQLVerificarAsignacion As String 'Esta consulta permitirá verificar si el rol que se desea eliminar del sistema esta asignado a algun usuario del sistema.
        SQLVerificarAsignacion = "SELECT nid_rol FROM v_usuario_persona_rol WHERE nid_rol=" & DGVRoles.CurrentRow.Cells("nid").Value & ""
        AccederBD(SQLVerificarAsignacion, rolAsignado)

        If rolAsignado = True Then
            MsgBox("No se puede eliminar el rol seleccionado ya que existe por lo mínimo un usuario del sistema que tiene asignado el mismo.", MsgBoxStyle.Information)
            BTNEliminar.Enabled = False
            Exit Sub
        Else
            Dim SQLEliminarRol As String = ""
            SQLEliminarRol = "DELETE FROM rol WHERE nid=" & DGVRoles.CurrentRow.Cells("nid").Value & ""
            AccederBD(SQLEliminarRol)
            cargarDGVRoles()
            BTNEliminar.Enabled = False
            MsgBox("Rol eliminado exitosamente...", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub TBNuevoRol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTNuevoRol.KeyPress

        objCGenerica.SoloLetra(e)

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        BTNCrearRol.Enabled = True
        BTNEliminar.Enabled = False
        TXTNuevoRol.Clear()
        DGVRoles.ClearSelection()

    End Sub
End Class