<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConexion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConexion))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblConexion = New System.Windows.Forms.Label()
        Me.cmbConexion = New System.Windows.Forms.ComboBox()
        Me.cmsConexion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAbrirConexión = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNuevaConexion = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cmsConexion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(3, 32)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(55, 13)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(3, 85)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(73, 13)
        Me.lblContraseña.TabIndex = 3
        Me.lblContraseña.Text = "Contaseña:"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(80, 78)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(165, 21)
        Me.txtContrasena.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(80, 25)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(165, 21)
        Me.txtUsuario.TabIndex = 0
        '
        'lblConexion
        '
        Me.lblConexion.AutoSize = True
        Me.lblConexion.Location = New System.Drawing.Point(3, 58)
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(66, 13)
        Me.lblConexion.TabIndex = 6
        Me.lblConexion.Text = "Conexión:"
        '
        'cmbConexion
        '
        Me.cmbConexion.ContextMenuStrip = Me.cmsConexion
        Me.cmbConexion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConexion.FormattingEnabled = True
        Me.cmbConexion.Location = New System.Drawing.Point(80, 51)
        Me.cmbConexion.Name = "cmbConexion"
        Me.cmbConexion.Size = New System.Drawing.Size(165, 21)
        Me.cmbConexion.TabIndex = 1
        '
        'cmsConexion
        '
        Me.cmsConexion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbrirConexión, Me.mnuNuevaConexion})
        Me.cmsConexion.Name = "cmsConexion"
        Me.cmsConexion.Size = New System.Drawing.Size(163, 48)
        '
        'mnuAbrirConexión
        '
        Me.mnuAbrirConexión.Enabled = False
        Me.mnuAbrirConexión.Name = "mnuAbrirConexión"
        Me.mnuAbrirConexión.Size = New System.Drawing.Size(162, 22)
        Me.mnuAbrirConexión.Text = "Abrir conexión"
        '
        'mnuNuevaConexion
        '
        Me.mnuNuevaConexion.Name = "mnuNuevaConexion"
        Me.mnuNuevaConexion.Size = New System.Drawing.Size(162, 22)
        Me.mnuNuevaConexion.Text = "Nueva Conexión"
        '
        'btnAceptar
        '
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(251, 23)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(87, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(251, 75)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmConexion
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(346, 110)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cmbConexion)
        Me.Controls.Add(Me.lblConexion)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConexion"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido"
        Me.cmsConexion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblConexion As System.Windows.Forms.Label
    Friend WithEvents cmbConexion As System.Windows.Forms.ComboBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cmsConexion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAbrirConexión As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNuevaConexion As System.Windows.Forms.ToolStripMenuItem

End Class
