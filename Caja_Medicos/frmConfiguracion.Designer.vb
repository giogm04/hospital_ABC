<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfiguracion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracion))
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tbpGeneral = New System.Windows.Forms.TabPage()
        Me.txtRutaFormas = New System.Windows.Forms.TextBox()
        Me.lblRutaFormas = New System.Windows.Forms.Label()
        Me.txtRutaReportes = New System.Windows.Forms.TextBox()
        Me.lblRutaReportes = New System.Windows.Forms.Label()
        Me.tbcConfiguracion = New System.Windows.Forms.TabControl()
        Me.tbpCorreo = New System.Windows.Forms.TabPage()
        Me.txtRemitente = New System.Windows.Forms.TextBox()
        Me.lblRemitente = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.chkUsarSSL = New System.Windows.Forms.CheckBox()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.lblPuerto = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.lblServidor = New System.Windows.Forms.Label()
        Me.tbpGeneral.SuspendLayout()
        Me.tbcConfiguracion.SuspendLayout()
        Me.tbpCorreo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(176, 362)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(87, 23)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(287, 362)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'tbpGeneral
        '
        Me.tbpGeneral.Controls.Add(Me.txtRutaFormas)
        Me.tbpGeneral.Controls.Add(Me.lblRutaFormas)
        Me.tbpGeneral.Controls.Add(Me.txtRutaReportes)
        Me.tbpGeneral.Controls.Add(Me.lblRutaReportes)
        Me.tbpGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tbpGeneral.Name = "tbpGeneral"
        Me.tbpGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGeneral.Size = New System.Drawing.Size(511, 318)
        Me.tbpGeneral.TabIndex = 0
        Me.tbpGeneral.Text = "General"
        Me.tbpGeneral.UseVisualStyleBackColor = True
        '
        'txtRutaFormas
        '
        Me.txtRutaFormas.Location = New System.Drawing.Point(143, 36)
        Me.txtRutaFormas.Name = "txtRutaFormas"
        Me.txtRutaFormas.Size = New System.Drawing.Size(341, 21)
        Me.txtRutaFormas.TabIndex = 13
        '
        'lblRutaFormas
        '
        Me.lblRutaFormas.AutoSize = True
        Me.lblRutaFormas.Location = New System.Drawing.Point(6, 44)
        Me.lblRutaFormas.Name = "lblRutaFormas"
        Me.lblRutaFormas.Size = New System.Drawing.Size(131, 13)
        Me.lblRutaFormas.TabIndex = 12
        Me.lblRutaFormas.Text = "Ruta de los formatos:"
        '
        'txtRutaReportes
        '
        Me.txtRutaReportes.Location = New System.Drawing.Point(143, 9)
        Me.txtRutaReportes.Name = "txtRutaReportes"
        Me.txtRutaReportes.Size = New System.Drawing.Size(341, 21)
        Me.txtRutaReportes.TabIndex = 11
        '
        'lblRutaReportes
        '
        Me.lblRutaReportes.AutoSize = True
        Me.lblRutaReportes.Location = New System.Drawing.Point(6, 17)
        Me.lblRutaReportes.Name = "lblRutaReportes"
        Me.lblRutaReportes.Size = New System.Drawing.Size(128, 13)
        Me.lblRutaReportes.TabIndex = 10
        Me.lblRutaReportes.Text = "Ruta de los reportes:"
        '
        'tbcConfiguracion
        '
        Me.tbcConfiguracion.Controls.Add(Me.tbpGeneral)
        Me.tbcConfiguracion.Controls.Add(Me.tbpCorreo)
        Me.tbcConfiguracion.Location = New System.Drawing.Point(12, 12)
        Me.tbcConfiguracion.Name = "tbcConfiguracion"
        Me.tbcConfiguracion.SelectedIndex = 0
        Me.tbcConfiguracion.Size = New System.Drawing.Size(519, 344)
        Me.tbcConfiguracion.TabIndex = 8
        '
        'tbpCorreo
        '
        Me.tbpCorreo.Controls.Add(Me.txtRemitente)
        Me.tbpCorreo.Controls.Add(Me.lblRemitente)
        Me.tbpCorreo.Controls.Add(Me.txtMensaje)
        Me.tbpCorreo.Controls.Add(Me.lblMensaje)
        Me.tbpCorreo.Controls.Add(Me.chkUsarSSL)
        Me.tbpCorreo.Controls.Add(Me.txtPuerto)
        Me.tbpCorreo.Controls.Add(Me.lblPuerto)
        Me.tbpCorreo.Controls.Add(Me.txtContraseña)
        Me.tbpCorreo.Controls.Add(Me.lblContraseña)
        Me.tbpCorreo.Controls.Add(Me.txtUsuario)
        Me.tbpCorreo.Controls.Add(Me.lblUsuario)
        Me.tbpCorreo.Controls.Add(Me.txtServidor)
        Me.tbpCorreo.Controls.Add(Me.lblServidor)
        Me.tbpCorreo.Location = New System.Drawing.Point(4, 22)
        Me.tbpCorreo.Name = "tbpCorreo"
        Me.tbpCorreo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCorreo.Size = New System.Drawing.Size(511, 318)
        Me.tbpCorreo.TabIndex = 2
        Me.tbpCorreo.Text = "Correo"
        Me.tbpCorreo.UseVisualStyleBackColor = True
        '
        'txtRemitente
        '
        Me.txtRemitente.Location = New System.Drawing.Point(123, 12)
        Me.txtRemitente.Name = "txtRemitente"
        Me.txtRemitente.Size = New System.Drawing.Size(197, 21)
        Me.txtRemitente.TabIndex = 0
        '
        'lblRemitente
        '
        Me.lblRemitente.AutoSize = True
        Me.lblRemitente.Location = New System.Drawing.Point(7, 20)
        Me.lblRemitente.Name = "lblRemitente"
        Me.lblRemitente.Size = New System.Drawing.Size(70, 13)
        Me.lblRemitente.TabIndex = 13
        Me.lblRemitente.Text = "Remitente:"
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(123, 121)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(324, 53)
        Me.txtMensaje.TabIndex = 6
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(7, 124)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(59, 13)
        Me.lblMensaje.TabIndex = 9
        Me.lblMensaje.Text = "Mensaje:"
        '
        'chkUsarSSL
        '
        Me.chkUsarSSL.AutoSize = True
        Me.chkUsarSSL.Location = New System.Drawing.Point(386, 97)
        Me.chkUsarSSL.Name = "chkUsarSSL"
        Me.chkUsarSSL.Size = New System.Drawing.Size(78, 17)
        Me.chkUsarSSL.TabIndex = 5
        Me.chkUsarSSL.Text = "Usar SSL"
        Me.chkUsarSSL.UseVisualStyleBackColor = True
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(316, 93)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(53, 21)
        Me.txtPuerto.TabIndex = 4
        '
        'lblPuerto
        '
        Me.lblPuerto.AutoSize = True
        Me.lblPuerto.Location = New System.Drawing.Point(261, 101)
        Me.lblPuerto.Name = "lblPuerto"
        Me.lblPuerto.Size = New System.Drawing.Size(49, 13)
        Me.lblPuerto.TabIndex = 6
        Me.lblPuerto.Text = "Puerto:"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(123, 93)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(129, 21)
        Me.txtContraseña.TabIndex = 4
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(7, 101)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(78, 13)
        Me.lblContraseña.TabIndex = 4
        Me.lblContraseña.Text = "Contraseña:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(123, 66)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(197, 21)
        Me.txtUsuario.TabIndex = 2
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(7, 74)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(55, 13)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "Usuario:"
        '
        'txtServidor
        '
        Me.txtServidor.Location = New System.Drawing.Point(123, 39)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(197, 21)
        Me.txtServidor.TabIndex = 1
        '
        'lblServidor
        '
        Me.lblServidor.AutoSize = True
        Me.lblServidor.Location = New System.Drawing.Point(7, 47)
        Me.lblServidor.Name = "lblServidor"
        Me.lblServidor.Size = New System.Drawing.Size(61, 13)
        Me.lblServidor.TabIndex = 0
        Me.lblServidor.Text = "Servidor:"
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 397)
        Me.Controls.Add(Me.tbcConfiguracion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.tbpGeneral.ResumeLayout(False)
        Me.tbpGeneral.PerformLayout()
        Me.tbcConfiguracion.ResumeLayout(False)
        Me.tbpCorreo.ResumeLayout(False)
        Me.tbpCorreo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents tbpGeneral As TabPage
    Friend WithEvents tbcConfiguracion As TabControl
    Friend WithEvents tbpCorreo As TabPage
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents lblMensaje As Label
    Friend WithEvents chkUsarSSL As CheckBox
    Friend WithEvents txtPuerto As TextBox
    Friend WithEvents lblPuerto As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtServidor As TextBox
    Friend WithEvents lblServidor As Label
    Friend WithEvents txtRemitente As TextBox
    Friend WithEvents lblRemitente As Label
    Friend WithEvents txtRutaReportes As TextBox
    Friend WithEvents lblRutaReportes As Label
    Friend WithEvents txtRutaFormas As TextBox
    Friend WithEvents lblRutaFormas As Label
End Class
