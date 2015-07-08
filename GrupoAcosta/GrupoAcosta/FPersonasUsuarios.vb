Public Class FPersonasUsuarios

    Dim DatosDataTableDGVPersonasUsuarios As New DataTable
    Dim DatosBindingSourceDGVPersonasUsuarios As New BindingSource


    Private Sub BTNSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSeleccionar.Click
        'FUsuarios.TBValidarIdPersona.Text = DGVPersonasNoUsuarios.CurrentRow.Cells("id").Value
        FUsuario.TXTPersonasNoUsuarios.Text = DGVPersonasNoUsuarios.CurrentRow.Cells("nid").Value
        FUsuario.LBLNinguno.Text = DGVPersonasNoUsuarios.CurrentRow.Cells("s_nombre").Value
        Me.Close()
    End Sub

    Private Sub mostrarDGVPersonasUsuarios()

        Dim CadenaSQL As String = ""

        CadenaSQL = "select p.nid, p.s_nombre1 ||' '|| p.s_apellido1 ||' '|| p.s_apellido2 s_nombre, p.s_dni from persona p where p.nid not in (select nid_persona from usuario) and p.s_activo = '1'"
        DatosDataTableDGVPersonasUsuarios.Clear()

        Using conexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)

            Using DatosDataAdapter As New Odbc.OdbcDataAdapter(CadenaSQL, conexion)
                DatosDataAdapter.Fill(DatosDataTableDGVPersonasUsuarios)
                DatosBindingSourceDGVPersonasUsuarios.DataSource = DatosDataTableDGVPersonasUsuarios
            End Using

            '
            With DGVPersonasNoUsuarios
                .RowHeadersVisible = False
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .DataSource = DatosBindingSourceDGVPersonasUsuarios
                .ClearSelection()

            End With
            With DGVPersonasNoUsuarios.Columns("nid")
                .Visible = False
                .HeaderText = "NID"
                .Width = "90"
                .DisplayIndex = "0"

            End With
            With DGVPersonasNoUsuarios.Columns("s_nombre")
                '.Visible = True
                .HeaderText = "Nombre"
                .Width = "240"
                .DisplayIndex = "1"

            End With

            With DGVPersonasNoUsuarios.Columns("s_dni")
                '.Visible = True
                .HeaderText = "DNI"
                .Width = "90"
                .DisplayIndex = "2"
            End With
        End Using

    End Sub

    Private Sub FPersonasUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DGVPersonasNoUsuarios.ClearSelection()

        mostrarDGVPersonasUsuarios()

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click

        'Se habilitan/deshabilitan los objetos
        DGVPersonasNoUsuarios.Enabled = True

        'Se limpia la seleccion del DataGridView
        DGVPersonasNoUsuarios.ClearSelection()

        Me.Dispose()

    End Sub

    Private Sub TXTBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTBuscar.TextChanged

        DatosBindingSourceDGVPersonasUsuarios.Filter = "s_nombre like '%" & TXTBuscar.Text & "%' OR s_dni like '%" & TXTBuscar.Text & "%'"

    End Sub

End Class