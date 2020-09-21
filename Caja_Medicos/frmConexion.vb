Public Class frmConexion

    Private Sub frmConexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Path_archivo_ini = App_Path() & "config.ini"

        LlenarComboConexion()

        If txtContrasena.Text = "" Or txtUsuario.Text = "" Then
            btnAceptar.Enabled = False
        Else
            btnAceptar.Enabled = True
        End If

        CargarUltimoUsuarioConexion()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        End
    End Sub

    Private Sub txtContrasena_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged
        If txtContrasena.Text = "" Or txtUsuario.Text = "" Then
            btnAceptar.Enabled = False
        Else
            btnAceptar.Enabled = True
        End If
    End Sub

    Private Sub cmsConexion_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsConexion.Opening
        With Me

            If .cmbConexion.Items.Count() = 0 Then
                .mnuAbrirConexión.Enabled = False
                .mnuNuevaConexion.Enabled = True
            Else
                .mnuAbrirConexión.Enabled = True
                .mnuNuevaConexion.Enabled = True
            End If

        End With

    End Sub

    Private Sub mnuAbrirConexión_Click(sender As Object, e As EventArgs) Handles mnuAbrirConexión.Click
        nueva_con = False

frmNuevaConexion.ShowDialog()
    End Sub

    Private Sub mnuNuevaConexion_Click(sender As Object, e As EventArgs) Handles mnuNuevaConexion.Click
        nueva_con = True
        frmNuevaConexion.ShowDialog()
    End Sub

    Private Sub cmbConexion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConexion.SelectedIndexChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        USUARIO_CON = txtUsuario.Text

        If cmbConexion.Text = "" Then
            MsgBox("No existen conexiones")
            Exit Sub
        End If

        CargarDatosConexion(cmbConexion.Text)

        If ConectarConfig(TIPO_CON, SERVIDOR_CON, txtUsuario.Text, txtContrasena.Text, CARPETA_CON) = True Then

            If HayConexionConfig = True Then

                If txtUsuario.Text = "SYSDBA" Or txtUsuario.Text = "sysdba" Then

                    If RevisaNodo999() = True Then

                        If ComparaContraseñaSYSDBA(txtContrasena.Text) = True Then
                            Call GuardarUltimoUsuarioConexion()
                            USUARIO_ACTUAL = txtUsuario.Text
                            frmEmpresas.Show()
                        Else
                            Call ActualizaNodo999(txtContrasena.Text)
                            Call GuardarUltimoUsuarioConexion()
                            frmEmpresas.Show()
                        End If

                    Else
                        CrearNodo999(txtContrasena.Text)
                        Call GuardarUltimoUsuarioConexion()
                        USUARIO_ACTUAL = txtUsuario.Text
                        frmEmpresas.Show()
                    End If
            Else
                Call GuardarUltimoUsuarioConexion()
                USUARIO_ACTUAL = txtUsuario.Text
                frmEmpresas.Show()
            End If
                
            Else
                MsgBox("El nombre de usuario o la contraseña no son válidos para el servidor de la " _
                & "conexión " & cmbConexion.Text & "." & vbCrLf & "Escriba los datos correctamente o " _
                & "consulte al Administrador del sistema")
            End If

        End If

    End Sub

    Private Sub frmConexion_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        End
    End Sub
End Class
