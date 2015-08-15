Public Class FPrivilegios
    Dim DatosDataTableDGVPrivilegios As New DataTable
    Dim DatosBindingSourceDGVPrivilegios As New BindingSource

    Dim DatosDataTableCBRol As New DataTable
    Dim DatosBindingSourceCBRol As New BindingSource

    Private Sub FPrivilegios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarDGVPrivilegios()
        cargarCBRol()
    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click
        Me.Dispose()
    End Sub

   

    Private Sub cargarDGVPrivilegios()
        DatosDataTableDGVPrivilegios.Clear()
        DatosBindingSourceDGVPrivilegios.DataSource = Nothing
        DGVPrivilegios.Columns.Clear()
        Dim SQLDGVPrivilegios As String = ""
        SQLDGVPrivilegios = "SELECT nid_rol,nid_privilegios, descripcion_privilegios, b_activo_privilegios FROM v_rol_privilegios WHERE nid_rol=" & FRoles.id_rol & " ORDER BY descripcion_privilegios"
        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)
            Using DatosDataAdapter As New Odbc.OdbcDataAdapter(SQLDGVPrivilegios, conexion)
                DatosDataAdapter.Fill(DatosDataTableDGVPrivilegios)
                DatosBindingSourceDGVPrivilegios.DataSource = DatosDataTableDGVPrivilegios
            End Using

            Dim check As New DataGridViewCheckBoxColumn
            With check
                .Name = "acceso"
                .DataPropertyName = "b_activo_privilegios"
                .FalseValue = "0"
                .TrueValue = "1"
                .HeaderText = "Activo"
                .Width = "60"
            End With

            With DGVPrivilegios
                .DataSource = DatosBindingSourceDGVPrivilegios
                .Columns.Add(check)
                .ClearSelection()
                .MultiSelect = False
                .AllowUserToAddRows = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            End With
            With DGVPrivilegios.Columns("nid_rol")
                .HeaderText = "ID Rol:"
                .ReadOnly = True
                .Width = "65"
                .Visible = False
            End With
            With DGVPrivilegios.Columns("nid_privilegios")
                .HeaderText = "ID Priv"
                .Visible = False
                .ReadOnly = True
                .Width = "60"
            End With
            With DGVPrivilegios.Columns("descripcion_privilegios")
                .HeaderText = "Previlegio"
                .Width = "290"
                .ReadOnly = True
            End With
            With DGVPrivilegios.Columns("b_activo_privilegios")
                .Visible = False
                .ReadOnly = True
                .Width = "60"
            End With
        End Using

    End Sub

    Private Sub cargarCBRol()
        DatosDataTableCBRol.Clear()
        Dim SQLCBRol As String = ""
        SQLCBRol = "SELECT nid, s_descripcion FROM rol"
        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)
            Using DatosDataAdapter As New Odbc.OdbcDataAdapter(SQLCBRol, conexion)
                DatosDataAdapter.Fill(DatosDataTableCBRol)
                DatosBindingSourceCBRol.DataSource = DatosDataTableCBRol
            End Using
            With CBRol
                .DataSource = DatosBindingSourceCBRol
                .DisplayMember = "s_descripcion"
                .ValueMember = "nid"
            End With
            CBRol.SelectedValue = FRoles.id_rol
        End Using
    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click

        Dim i As Integer = 0
        Dim CadenaSQL As String = ""
        While i < DGVPrivilegios.RowCount
            CadenaSQL = "UPDATE rol_privilegios SET b_activo=" & CBool(DGVPrivilegios.Rows(i).Cells("b_activo_privilegios").Value) & " WHERE nid_rol=" & CInt(DGVPrivilegios.Rows(i).Cells("nid_rol").Value) & " AND nid_privilegios=" & CInt(DGVPrivilegios.Rows(i).Cells("nid_privilegios").Value) & ""
            Acceso_BD(CadenaSQL)
            i = 1 + i
        End While
        If FIngreso.nId_rol = FRoles.DGVRoles.CurrentRow.Cells("nid").Value Then
            'FPrincipal.cargarVistaRol()
        End If
        FRoles.BTNEliminar.Enabled = False
        MsgBox("Cambios realizados exitosamente...", MsgBoxStyle.Information)
        Me.Close()
        FRoles.Dispose()

    End Sub


    Public Sub Acceso_BD(ByVal CadenaSQL As String)

        Using Conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString) 'Se declara la conexion haciendo uso del using
            Conexion.Open() 'Se abre la conexion
            Dim Comando As New Odbc.OdbcCommand(CadenaSQL, Conexion) 'Se declara el comando que se va a ejecutar y se conecta
            Dim reader As Odbc.OdbcDataReader = Comando.ExecuteReader() 'Se ejecuta la lectura de los valores encontrados en la consulta
            reader.Close()
            Conexion.Close()
        End Using

    End Sub


    Private Sub FPrivilegios_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'DGVPrivilegios.Columns.Remove("acceso")
        Me.Dispose()
    End Sub

    Private Sub CBRol_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRol.SelectionChangeCommitted
        TBIdrol.Text = CBRol.SelectedValue
        DGVPrivilegios.Columns.Remove("acceso")
        DatosDataTableDGVPrivilegios.Clear()
        DatosDataTableDGVPrivilegios.Clear()
        DatosBindingSourceDGVPrivilegios.DataSource = Nothing
        DGVPrivilegios.Columns.Clear()


        Dim SQLDGVPrivilegios As String = ""
        SQLDGVPrivilegios = "SELECT nid_rol,nid_privilegios, descripcion_privilegios, b_activo_privilegios FROM v_rol_privilegios WHERE id_rol=" & CInt(TBIdrol.Text) & ""

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)
            Using DatosDataAdapter As New Odbc.OdbcDataAdapter(SQLDGVPrivilegios, conexion)
                DatosDataAdapter.Fill(DatosDataTableDGVPrivilegios)
                DatosBindingSourceDGVPrivilegios.DataSource = DatosDataTableDGVPrivilegios
            End Using

            Dim check As New DataGridViewCheckBoxColumn
            With check
                .Name = "acceso"
                .DataPropertyName = "nactivo_privilegio"
                .FalseValue = "0"
                .TrueValue = "1"
                .HeaderText = "Activo"
                .Width = "60"
            End With

            With DGVPrivilegios
                .DataSource = DatosBindingSourceDGVPrivilegios
                .Columns.Add(check)
                .ClearSelection()
                .MultiSelect = False
                .AllowUserToAddRows = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            End With
            With DGVPrivilegios.Columns("nid_rol")
                .HeaderText = "ID Rol:"
                .ReadOnly = True
                .Width = "65"
                .Visible = False
            End With
            With DGVPrivilegios.Columns("nid_privilegios")
                .HeaderText = "ID Priv"
                .Visible = False
                .ReadOnly = True
                .Width = "60"
            End With
            With DGVPrivilegios.Columns("descripcion_privilegios")
                .HeaderText = "Privilegio"
                .Width = "290"
                .ReadOnly = True
            End With
            With DGVPrivilegios.Columns("b_activo_privilegios")
                .Visible = False
                .ReadOnly = True
            End With
        End Using
    End Sub



End Class