Public Class frmPermisos

    Private Sub frmPermisos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCmbCnf(cmbUsuario, "select nombre,usuario_id from usuarios order by nombre")
        LlenarCmbCnf(cmbCopiarUsuarios, "select nombre,usuario_id from usuarios order by nombre")
        LlenarfrmPermisos()

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        CargarPermisosUsuario(cmbUsuario.SelectedItem.id)
        chlPermisos.SelectedIndex = 0
        cmbUsuario.Enabled = False
        btnSeleccionar.Enabled = False
        btnGuardar.Enabled = True
        cmbCopiarUsuarios.Enabled = True
        btnCopiar.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call ActualizaPermisosUsuario(cmbUsuario.SelectedItem.id)
        cmbUsuario.Enabled = True
        btnSeleccionar.Enabled = True
        btnGuardar.Enabled = False
        chlPermisos.Items.Clear()
        Call LlenarfrmPermisos()
        cmbUsuario.SelectedIndex = 0
        chlPermisos.SelectedIndex = 0
        MsgBox("La información se guardó correctamente.", vbInformation)
    End Sub

End Class