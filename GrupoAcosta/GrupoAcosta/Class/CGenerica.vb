﻿Public Class CGenerica

    'Variables globales
    Friend nId_usuario As Integer = 0

    Public DatosDataTableComboBox As New DataTable
    Public DatosBindingSourceComboBox As New BindingSource

    'Public Sub SoloLetras: Esta función permite controlar que TextBox se pueda introducir solo Letras A-Z y a-z.
    Public Sub SoloLetra(ByVal e As System.Windows.Forms.KeyPressEventArgs)

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

    'Public Sub SoloNumeros: Esta función permite controlar que TextBox se puedan introducir solo numeros.
    Public Sub SoloNumero(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    'Función que permite ejecutar intrucciones SQL en la Base de Datos.
    Public Sub accederBD(ByVal sCadenaSQL As String, Optional ByRef sValorRetorno As String = "")

        Try
            Using dsnConexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)
                dsnConexion.Open()
                Dim cComando As New Odbc.OdbcCommand(sCadenaSQL, dsnConexion)
                Dim drReader As Odbc.OdbcDataReader = cComando.ExecuteReader

                If drReader.HasRows Then
                    sValorRetorno = Trim(CStr(drReader(0)))
                Else
                    sValorRetorno = ""
                End If
                drReader.Close()
                dsnConexion.Close()
            End Using

        Catch
            sValorRetorno = ""
            MsgBox("Error al ejecutar la siguiente instrucción SQL: " & sCadenaSQL, MsgBoxStyle.Exclamation)

        End Try

    End Sub

    'Función que permite ejecutar intrucciones SQL en la Base de Datos.
    Public Sub recuperarCamposBD(ByVal sCadenaSQL As String, Optional ByRef sCampo1 As String = "", Optional ByRef sCampo2 As String = "", Optional ByRef sCampo3 As String = "", Optional ByRef sCampo4 As String = "", Optional ByRef sCampo5 As String = "", Optional ByRef sCampo6 As String = "", Optional ByRef sCampo7 As String = "", Optional ByRef sCampo8 As String = "")

        Try
            Using dsnConexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)
                dsnConexion.Open()
                Dim cComando As New Odbc.OdbcCommand(sCadenaSQL, dsnConexion)
                Dim drReader As Odbc.OdbcDataReader = cComando.ExecuteReader

                If drReader.HasRows Then
                    sCampo1 = Trim(CStr(drReader(0)))
                    sCampo2 = Trim(CStr(drReader(1)))
                    sCampo3 = Trim(CStr(drReader(2)))
                    sCampo4 = Trim(CStr(drReader(3)))
                    sCampo5 = Trim(CStr(drReader(4)))
                    sCampo6 = Trim(CStr(drReader(5)))
                    sCampo7 = Trim(CStr(drReader(6)))
                    sCampo8 = Trim(CStr(drReader(7)))
                Else
                    sCampo1 = ""
                    sCampo2 = ""
                    sCampo3 = ""
                    sCampo4 = ""
                    sCampo5 = ""
                    sCampo6 = ""
                    sCampo7 = ""
                    sCampo8 = ""
                End If
                drReader.Close()
                dsnConexion.Close()
            End Using

        Catch
            'sValorRetorno = ""
            MsgBox("Error al ejecutar la siguiente instrucción SQL: " & sCadenaSQL, MsgBoxStyle.Exclamation)

        End Try

    End Sub

    'Funcion que permite cargar un ComboBox a partir de una consulta SQL, un DataTable y un BindingSource.
    Public Sub cargarComboBoxDataGridView(ByVal sCadenaSQL As String, ByRef dtComboBox As DataTable, ByRef bsComboBox As BindingSource)

        Using dsnConexion As New Odbc.OdbcConnection(My.Settings.ConnectionString)
            dsnConexion.Open()
            Using daDatos As New Odbc.OdbcDataAdapter(sCadenaSQL, dsnConexion)
                daDatos.Fill(dtComboBox)
                bsComboBox.DataSource = dtComboBox
            End Using
            dsnConexion.Close()
        End Using

    End Sub

    'Funcion que permite validar aquellos campos que son obligatorios
    Public Sub valCampoObligatorio(ByVal sTextBox As System.Windows.Forms.TextBox, ByVal sLabel As System.Windows.Forms.Label)

        If Len(sTextBox.Text) = 0 Then
            sLabel.Visible = True
        Else
            sLabel.Visible = False
        End If
    End Sub

End Class
