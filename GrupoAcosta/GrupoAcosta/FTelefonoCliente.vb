Public Class FTelefonoCliente
    'Se declara variable de tipo clase para el manejo de funciones genericas
    Dim objCGenerica As CGenerica = New CGenerica


    'Función que permite cargar el DataGridView que muestra la información de las personas.
    Private Sub cargarDGVTelefono()

        Dim sCadenaSQL As String = "select t.nid, t.nid_cliente, t.s_telefono from telefono t inner join cliente p on t.nid_cliente = p.nid where t.nid_cliente = " & FCliente.DGVCliente.CurrentRow.Cells("nid").Value & ""

        Dim dtDGVTelefono As New DataTable
        Dim bsDGVTelefono As New BindingSource
        Dim BCDGVTelefono As New DataGridViewButtonColumn()

        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtDGVTelefono, bsDGVTelefono)


        With DGVTelefono
            .Columns.Clear()
            .RowHeadersVisible = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            .DataSource = bsDGVTelefono
            .ClearSelection()

        End With

        With DGVTelefono.Columns("nid")
            .Visible = False
            .HeaderText = "NID"
            .Width = "90"
            .DisplayIndex = "0"


        End With
        With DGVTelefono.Columns("s_telefono")
            '.Visible = True
            .HeaderText = "Teléfonos registrados"
            .Width = "237"
            .DisplayIndex = "1"

        End With

        With DGVTelefono.Columns("nid_cliente")
            .Visible = False
            .HeaderText = "Id Cliente"
            .Width = "180"
            .DisplayIndex = "2"

        End With
    End Sub

    Private Sub TXTTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTTelefono.TextChanged
        objCGenerica.valCampoObligatorio(Me.TXTTelefono, LBValidarTelefono)
        DGVTelefono.ClearSelection()
    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click

        Dim sSQLAddtelefono_cliente As String

        If FCliente.nAction = 1 Then

            If Len(TXTTelefono.Text) = 0 Then
                MsgBox("Ingrese el teléfono.", MsgBoxStyle.Information)
                TXTTelefono.Focus()
                Exit Sub
            ElseIf Len(TXTTelefono.Text) < 11 Then
                MsgBox("El formato del telefono es de 11 numeros, verifique.", MsgBoxStyle.Information)
                TXTTelefono.Focus()
                Exit Sub
            End If

            FCliente.LVTelefono.Items.Add(TXTTelefono.Text)
            Me.Dispose()

        ElseIf FCliente.nAction = 3 Then

            If Len(TXTTelefono.Text) = 0 Then
                MsgBox("Ingrese el teléfono.", MsgBoxStyle.Information)
                TXTTelefono.Focus()
                Exit Sub
            ElseIf Len(TXTTelefono.Text) < 11 Then
                MsgBox("El formato del telefono es de 11 numeros, verifique.", MsgBoxStyle.Information)
                TXTTelefono.Focus()
                Exit Sub
            End If

            sSQLAddtelefono_cliente = "insert into telefono (nid_cliente, s_telefono) values (" & FCliente.DGVCliente.CurrentRow.Cells("nid").Value & ",'" & TXTTelefono.Text & "')"
            objCGenerica.accederBD(sSQLAddtelefono_cliente)
            cargarDGVTelefono()
            TXTTelefono.Clear()
            MsgBox("Se agrego el teléfono exitosamente", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub DGVTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGVTelefono.KeyPress

        Dim sSQLEliminarTelefono = "delete from telefono where nid=" & DGVTelefono.CurrentRow.Cells("nid").Value & ""

        If e.KeyChar = StrConv(ChrW(Keys.D), VbStrConv.Lowercase) Then
            objCGenerica.accederBD(sSQLEliminarTelefono)
            MsgBox("Teléfono eliminado exitosamente.", MsgBoxStyle.Information)
            cargarDGVTelefono()
        End If

    End Sub

    Private Sub TXTTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTTelefono.KeyPress
        objCGenerica.SoloNumero(e)
    End Sub

    Private Sub TXTTelefono_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTTelefono.Enter
        DGVTelefono.ClearSelection()
    End Sub

    Private Sub FTelefonoProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TXTTelefono.Focus()
        If FCliente.nAction = 1 Then
            Me.Size = New Size(431, 194)
            GroupBox2.Size = New Size(280, 100)
        ElseIf FCliente.nAction = 3 Then
            DGVTelefono.Visible = True
            cargarDGVTelefono()
        End If
    End Sub

End Class