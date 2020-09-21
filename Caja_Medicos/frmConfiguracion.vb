Public Class frmConfiguracion

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Grabar_ini(Path_archivo_ini, APpLICATION, "ruta_reportes", txtRutaReportes.Text)
        Grabar_ini(Path_archivo_ini, APpLICATION, "ruta_formas", txtRutaFormas.Text)
        Me.Dispose()
    End Sub

    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reg As New Registry()

        txtRutaReportes.Text = Leer_ini(Path_archivo_ini, APpLICATION, "ruta_reportes", "")
        txtRutaFormas.Text = Leer_ini(Path_archivo_ini, APpLICATION, "ruta_formas", "")



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub frmConfiguracion_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

End Class