Public Class frmDocumentos


    Private Sub frmDocumentos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SetBounds(Me.Left, Me.Top, mdiPrincipal.Size.Width, mdiPrincipal.Size.Height - 30)
        frm_actual = Me.Name
        CargarConfFormGrid(grdDocumentos)
        CargarPeriodoVista(frm_actual, txt_actual)
    End Sub

    Private Sub frmDocumentos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        GuardarConfFormGrid(grdDocumentos)
    End Sub

    Private Sub frmDocumentos_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grdDocumentos.SetBounds(grdDocumentos.Left, grdDocumentos.Top, Me.Size.Width - 20, Me.Size.Height - 120)
    End Sub
End Class