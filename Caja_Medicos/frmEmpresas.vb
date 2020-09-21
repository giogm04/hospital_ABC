Public Class frmEmpresas
    Private Sub frmEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On Error GoTo err_fn
        If UCase(USUARIO_CON) = "SYSDBA" Then
            LlenarListEmpresas()
        Else
            Call LlenarEmpresasUsuario(USUARIO_CON)
        End If
        Call CargarUltimaEmpresa()
        Exit Sub
err_fn:
        MsgBox("Hubo un error: " & Err.Number & " " & Err.Description, vbExclamation)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        With frmConexion
            EMPRESA_CON = lstEmpresas.Text
            USUARIO_CON = .txtUsuario.Text
            CONTRASEÑA_CON = .txtContrasena.Text
            CONTRASEÑASYSDBA = GetContraseñaSYSDBA()
        End With
        '      If UCase(USUARIO_CON) <> "SYSDBA" Then
        Call ConectarEmpresa(TIPO_CON, SERVIDOR_CON, "SYSDBA", CONTRASEÑASYSDBA, CARPETA_CON, EMPRESA_CON)
        Call GuardarUltimaEmpresa()
        '     Else
        '    Call ConectarEmpresa(TIPO_CON, SERVIDOR_CON, USUARIO_CON, CONTRASEÑA_CON, CARPETA_CON, EMPRESA_CON)
        'Call GuardarUltimaEmpresa()
        'End If
        If HayConexionEmpresa() = True Then
            frmConexion.Dispose()
            mdiPrincipal.Show()
            Me.Dispose()
        Else
            MsgBox("La contraseña de administrador caducó, solicite al administrador actualizarla", vbInformation)
            Me.Dispose()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class