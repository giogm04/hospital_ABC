Imports System.Windows.Forms
Imports System.Xml

Public Class mdiPrincipal


    Private Sub mdiPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub mdiPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarConfForm(Me)
        stlEmpresa.Text = EMPRESA_CON
        stlUsuario.Text = USUARIO_CON
    End Sub



    Private Sub mdiPrincipal_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub




    Private Sub mdiPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        GuardarConfForm(Me)
    End Sub

    Private Sub mdiPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        System.Windows.Forms.Application.Exit()
    End Sub

End Class
