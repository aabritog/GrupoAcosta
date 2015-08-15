Imports GrupoAcosta.CGenerica

Public Class FIngreso

    'Se declara variable de tipo clase para el manejo de funciones genericas
    Dim objCGenerica As CGenerica = New CGenerica

    'Friend nId_persona As Integer = 0
    Friend sId_persona As String = ""
    'Friend id_usuario As Integer = 0
    Friend aliasUser As String = ""
    Friend nombrePersona As String = ""
    Friend apellidoPersona As String = ""
    Friend id_rol As Integer = 0
    Friend nombre_rol As String = ""

    Friend nId_usuario As Integer
    Friend nId_persona As Integer
    Friend nId_cargo As Integer
    Friend nId_rol As Integer
    Friend s_Seudonimo As String
    Friend s_Rol As String
    Friend s_Nombre As String

    'Friend s_Clave As String
    'Friend s_Dni As String
    'Friend d_fecha_nacimiento As Date
    'Friend s_Correo As String
    'Friend s_Sexo As String
    'Friend s_Nacionalidad As String

    Dim s_Campo1 As String = ""
    Dim s_Campo2 As String = ""
    Dim s_Campo3 As String = ""
    Dim s_Campo4 As String = ""
    Dim s_Campo5 As String = ""
    Dim s_Campo6 As String = ""
    Dim s_Campo7 As String = ""
    Dim s_Campo8 As String = ""

    Dim nlogin_errado As Integer = 0
    Dim m_campos_obligatorios As String = "Debe rellenar los campos obligatorios"             'Para los campos obligatorios *.
    Dim DatosDataTableCBAlias As New DataTable
    Dim DatosBindingSourceCBAlias As New BindingSource
    Dim RespaldarRestaurar As String = ""

    Private Sub cargarCMBAlias()

        Dim sCadenaSQL As String = "SELECT nid, s_seudonimo FROM usuario WHERE s_activo='1' ORDER BY s_seudonimo"
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


    Friend Sub BTNAccesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAcceder.Click

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

        sSQLAccesarSistema = "SELECT nid_persona, nid, s_seudonimo FROM usuario WHERE nid =" & CBAlias.SelectedValue & " AND s_clave = '" & TBClave.Text & "'"
        sAccederSistema = ""

        If nlogin_errado <= 1 Then

            objCGenerica.accederBD(sSQLAccesarSistema, sId_persona)

            If sId_persona <> "" Then
                nId_persona = CInt(sId_persona)
            End If

            'Si no coinciden las credenciales ingresadas con ningun usuario de la tabla
            If sId_persona = "" Then
                'TBAlias.Clear()
                TBClave.Clear()
                TBAlias.Focus()
                nlogin_errado = nlogin_errado + 1
                MsgBox("Alias o clave errada, verifique. Intentos restantes: " & 3 - nlogin_errado & "")
            Else
                'ME TRAIGO TODOS LOS DATOS PARA CARGAR LA BARRA DE ESTADO DE LA FPRINCIPAL
                sSQLDatosPersona = "SELECT nid, nid_persona, nid_rol, s_seudonimo, s_rol, s_nombre, '' as sCampo7, '' as sCampo8 FROM v_usuario_persona_rol WHERE nid_persona=" & nId_persona & ""

                objCGenerica.recuperarCamposBD(sSQLDatosPersona, s_Campo1, s_Campo2, s_Campo3, s_Campo4, s_Campo5, s_Campo6)

                nId_usuario = CInt(s_Campo1)
                nId_persona = CInt(s_Campo2)
                nId_rol = CInt(s_Campo3)
                s_Seudonimo = s_Campo4
                s_Rol = s_Campo5
                s_Nombre = s_Campo6

                FPrincipal.ShowDialog()

            End If

        Else
            MsgBox("A excedido el numero de intentos, saliendo...", MsgBoxStyle.Information)
            End
        End If

    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click
        Me.Dispose()
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