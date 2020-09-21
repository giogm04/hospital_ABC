Public Class frmNuevaConexion

    Private Sub frmNuevaConexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipoConexion.Items.Add("Local")
        cmbTipoConexion.Items.Add("Remota")
        cmbTipoConexion.SelectedIndex = 0

        If nueva_con = False Then
            LlenarFormNuevaConexion(frmConexion.cmbConexion.Text)
            txtNombre.Enabled = False
        End If

        If nueva_con = True Then
            txtNombre.Text = "Local"
            btnEliminar.Visible = False
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If nueva_con = True Then

            If ExisteConexion(txtNombre.Text) = True Then
                MsgBox("La conexión " & txtNombre.Text & " ya existe")
                Exit Sub
            End If

            If GuardarConexionNueva(cmbTipoConexion.Text, txtNombre.Text, txtServidor.Text, txtCarpetaDatos.Text) = False Then
                MsgBox("Faltan datos")
            End If

        End If

        If nueva_con = False Then

            If GuardarConexionExistente(cmbTipoConexion.Text, txtNombre.Text, txtServidor.Text, txtCarpetaDatos.Text) = False Then
                MsgBox("Faltan datos")
            End If

        End If

        frmConexion.cmbConexion.Items.Clear()
        CargarComboConexion()
        Me.Dispose()
    End Sub


    Private Sub cmbTipoConexion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoConexion.SelectedIndexChanged
        txtNombre.Text = cmbTipoConexion.Text

        If cmbTipoConexion.Text = "Local" Then
            txtServidor.Enabled = False
        Else
            txtServidor.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Call BorrarConexion(txtNombre.Text)
        Me.Dispose()
    End Sub
End Class