<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPermisos))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.chlPermisos = New System.Windows.Forms.CheckedListBox()
        Me.tbcPermisos = New System.Windows.Forms.TabControl()
        Me.tbpGenerales = New System.Windows.Forms.TabPage()
        Me.btnCopiar = New System.Windows.Forms.Button()
        Me.cmbCopiarUsuarios = New System.Windows.Forms.ComboBox()
        Me.lblCopiarPermisos = New System.Windows.Forms.Label()
        Me.tbcPermisos.SuspendLayout()
        Me.tbpGenerales.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(14, 27)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(55, 13)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario:"
        '
        'cmbUsuario
        '
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(16, 14)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(183, 21)
        Me.cmbUsuario.TabIndex = 1
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(205, 12)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(87, 23)
        Me.btnSeleccionar.TabIndex = 2
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(298, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(87, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'chlPermisos
        '
        Me.chlPermisos.FormattingEnabled = True
        Me.chlPermisos.Location = New System.Drawing.Point(16, 43)
        Me.chlPermisos.Name = "chlPermisos"
        Me.chlPermisos.Size = New System.Drawing.Size(409, 292)
        Me.chlPermisos.TabIndex = 4
        '
        'tbcPermisos
        '
        Me.tbcPermisos.Controls.Add(Me.tbpGenerales)
        Me.tbcPermisos.Location = New System.Drawing.Point(12, 12)
        Me.tbcPermisos.Name = "tbcPermisos"
        Me.tbcPermisos.SelectedIndex = 0
        Me.tbcPermisos.Size = New System.Drawing.Size(448, 402)
        Me.tbcPermisos.TabIndex = 5
        '
        'tbpGenerales
        '
        Me.tbpGenerales.Controls.Add(Me.btnCopiar)
        Me.tbpGenerales.Controls.Add(Me.cmbCopiarUsuarios)
        Me.tbpGenerales.Controls.Add(Me.lblCopiarPermisos)
        Me.tbpGenerales.Controls.Add(Me.chlPermisos)
        Me.tbpGenerales.Controls.Add(Me.cmbUsuario)
        Me.tbpGenerales.Controls.Add(Me.btnGuardar)
        Me.tbpGenerales.Controls.Add(Me.btnSeleccionar)
        Me.tbpGenerales.Location = New System.Drawing.Point(4, 22)
        Me.tbpGenerales.Name = "tbpGenerales"
        Me.tbpGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGenerales.Size = New System.Drawing.Size(440, 376)
        Me.tbpGenerales.TabIndex = 0
        Me.tbpGenerales.Text = "Generales"
        Me.tbpGenerales.UseVisualStyleBackColor = True
        '
        'btnCopiar
        '
        Me.btnCopiar.Enabled = False
        Me.btnCopiar.Location = New System.Drawing.Point(298, 346)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(75, 23)
        Me.btnCopiar.TabIndex = 7
        Me.btnCopiar.Text = "Copiar"
        Me.btnCopiar.UseVisualStyleBackColor = True
        '
        'cmbCopiarUsuarios
        '
        Me.cmbCopiarUsuarios.Enabled = False
        Me.cmbCopiarUsuarios.FormattingEnabled = True
        Me.cmbCopiarUsuarios.Location = New System.Drawing.Point(131, 346)
        Me.cmbCopiarUsuarios.Name = "cmbCopiarUsuarios"
        Me.cmbCopiarUsuarios.Size = New System.Drawing.Size(161, 21)
        Me.cmbCopiarUsuarios.TabIndex = 6
        '
        'lblCopiarPermisos
        '
        Me.lblCopiarPermisos.Location = New System.Drawing.Point(13, 340)
        Me.lblCopiarPermisos.Name = "lblCopiarPermisos"
        Me.lblCopiarPermisos.Size = New System.Drawing.Size(113, 27)
        Me.lblCopiarPermisos.TabIndex = 5
        Me.lblCopiarPermisos.Text = "Copiar permisos del usuario:"
        '
        'frmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(462, 426)
        Me.Controls.Add(Me.tbcPermisos)
        Me.Controls.Add(Me.lblUsuario)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPermisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permisos de usuario"
        Me.tbcPermisos.ResumeLayout(False)
        Me.tbpGenerales.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents cmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents chlPermisos As System.Windows.Forms.CheckedListBox
    Friend WithEvents tbcPermisos As TabControl
    Friend WithEvents tbpGenerales As TabPage
    Friend WithEvents btnCopiar As Button
    Friend WithEvents cmbCopiarUsuarios As ComboBox
    Friend WithEvents lblCopiarPermisos As Label
End Class
