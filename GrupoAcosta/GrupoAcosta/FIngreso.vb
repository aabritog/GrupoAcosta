Imports GrupoAcosta.CGenerica

Public Class FIngreso

    'Se declara variable de tipo clase para el manejo de funciones genericas
    Dim objCGenerica As CGenerica = New CGenerica


    Friend id_persona As Integer = 0
    'Friend id_usuario As Integer = 0
    Friend aliasUser As String = ""
    Friend nombrePersona As String = ""
    Friend apellidoPersona As String = ""
    Friend id_rol As Integer = 0
    Friend nombre_rol As String = ""
    Dim nlogin_errado As Integer = 0
    Dim m_campos_obligatorios As String = "Debe rellenar los campos obligatorios"             'Para los campos obligatorios *.
    Dim DatosDataTableCBAlias As New DataTable
    Dim DatosBindingSourceCBAlias As New BindingSource
    Dim RespaldarRestaurar As String = ""



    Private Sub cargarCMBAlias()

        Dim sCadenaSQL As String = "SELECT s_seudonimo FROM usuario WHERE s_activo='1' ORDER BY s_seudonimo"
        Dim dtCMBAlias As New DataTable
        Dim bsCMBAlias As New BindingSource

        dtCMBAlias.Clear()
        bsCMBAlias.Clear()
        objCGenerica.cargarComboBoxDataGridView(sCadenaSQL, dtCMBAlias, bsCMBAlias)

        With CBAlias
            .DataSource = bsCMBAlias
            .DisplayMember = "s_seudonimo"
            .ValueMember = "nid"
        End With
    End Sub


    Private Sub BTNAccesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAcceder.Click

        Dim sSQLAccesarSistema As String
        Dim sAccederSistema As String
        Dim sSQLDatosPersona As String

        If Len(TBAlias.Text) = 0 Then
            MsgBox(m_campos_obligatorios, MsgBoxStyle.Information)
            TBAlias.Focus()
            Exit Sub
        End If
        If Len(TBClave.Text) = 0 Then
            MsgBox(m_campos_obligatorios, MsgBoxStyle.Information)
            TBClave.Focus()
            Exit Sub
        End If


        sSQLAccesarSistema = "SELECT nid_persona, nid, s_seudonimo FROM usuario WHERE s_seudonimo ='" & TBAlias.Text & "' AND s_clave = MD5('" & TBClave.Text & "')"
        sAccederSistema = ""

        If nlogin_errado <= 1 Then


            objCGenerica.accederBD(sSQLAccesarSistema, sAccederSistema)

            'Si no coinciden las credenciales ingresadas con ningun usuario de la tabla
            If sAccederSistema = "" Then
                'TBAlias.Clear()
                TBClave.Clear()
                TBAlias.Focus()
                nlogin_errado = nlogin_errado + 1
                MsgBox("Alias o clave errada, verifique. Intentos restantes: " & 3 - nlogin_errado & "")
            Else

                'ME TRAIGO TODOS LOS DATOS PARA CARGAR LA BARRA DE ESTADO DE LA FPRINCIPAL
                sSQLDatosPersona = "SELECT nombres,apellidos,id_rol,nombre_rol,alias FROM v_usuario_rol__persona WHERE id_persona=" & id_persona & ""


                '    Dim comando2 As New Odbc.OdbcCommand(SQLPersonas, Conexion)
                '    reader = comando2.ExecuteReader
                '    If reader.HasRows Then
                '        nombrePersona = Trim(reader("nombres"))
                '        apellidoPersona = Trim(reader("apellidos"))
                '        nombre_rol = Trim(reader("nombre_rol"))
                '        aliasUser = Trim(reader("alias"))
                '        id_rol = reader("id_rol")
                '        'FPrincipal.
                '    End If
                '    reader.Close()
                '    Conexion.Close()
                'End Using

            End If


        Else
            MsgBox("A excedido el numero de intentos, saliendo...", MsgBoxStyle.Information)
            End
        End If

    End Sub


    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click
        'FSaliendo.ShowDialog()
        'End
    End Sub



    Private Sub TBAlias_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBAlias.TextChanged
        If Len(TBAlias.Text) = 0 Then
            LBAliasObligatorio.Visible = True
        Else
            LBAliasObligatorio.Visible = False
        End If
    End Sub

    Private Sub TBClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBClave.TextChanged
        If Len(TBClave.Text) = 0 Then
            LBClaveObligatorio.Visible = True
        Else
            LBClaveObligatorio.Visible = False
        End If
    End Sub

    Private Sub FIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarCMBAlias()
    End Sub

    Private Sub CBAlias_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBAlias.SelectionChangeCommitted
        TBAlias.Clear()
        TBAlias.Text = Trim(CBAlias.SelectedValue)
        nlogin_errado = 0
    End Sub
End Class