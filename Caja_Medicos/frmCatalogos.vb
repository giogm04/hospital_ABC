Public Class frmCatalogos


    Private Sub frmCatalogos_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        GuardarConfFormGrid(grdCatalogos1)
    End Sub

    Private Sub frmCatalogos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SetBounds(Me.Left, Me.Top, mdiPrincipalold.Size.Width, mdiPrincipalold.Size.Height - 50)
        CargarConfFormGrid(grdCatalogos1)
    End Sub

    Private Sub frmCatalogos_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        grdCatalogos1.SetBounds(grdCatalogos1.Left, grdCatalogos1.Top, Me.Size.Width - 20, Me.Size.Height - 120)
    End Sub
End Class