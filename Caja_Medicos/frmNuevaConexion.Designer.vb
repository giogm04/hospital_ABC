<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaConexion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaConexion))
        Me.lblTipoConexion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblServidor = New System.Windows.Forms.Label()
        Me.lblProtocolo = New System.Windows.Forms.Label()
        Me.lblCarpetaDatos = New System.Windows.Forms.Label()
        Me.cmbTipoConexion = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.txtProtocolo = New System.Windows.Forms.TextBox()
        Me.txtCarpetaDatos = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTipoConexion
        '
        Me.lblTipoConexion.AutoSize = True
        Me.lblTipoConexion.Location = New System.Drawing.Point(14, 17)
        Me.lblTipoConexion.Name = "lblTipoConexion"
        Me.lblTipoConexion.Size = New System.Drawing.Size(109, 13)
        Me.lblTipoConexion.TabIndex = 0
        Me.lblTipoConexion.Text = "Tipo de conexión:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(14, 44)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'lblServidor
        '
        Me.lblServidor.AutoSize = True
        Me.lblServidor.Location = New System.Drawing.Point(14, 71)
        Me.lblServidor.Name = "lblServidor"
        Me.lblServidor.Size = New System.Drawing.Size(61, 13)
        Me.lblServidor.TabIndex = 2
        Me.lblServidor.Text = "Servidor:"
        '
        'lblProtocolo
        '
        Me.lblProtocolo.AutoSize = True
        Me.lblProtocolo.Location = New System.Drawing.Point(14, 98)
        Me.lblProtocolo.Name = "lblProtocolo"
        Me.lblProtocolo.Size = New System.Drawing.Size(65, 13)
        Me.lblProtocolo.TabIndex = 3
        Me.lblProtocolo.Text = "Protocolo:"
        '
        'lblCarpetaDatos
        '
        Me.lblCarpetaDatos.AutoSize = True
        Me.lblCarpetaDatos.Location = New System.Drawing.Point(14, 125)
        Me.lblCarpetaDatos.Name = "lblCarpetaDatos"
        Me.lblCarpetaDatos.Size = New System.Drawing.Size(111, 13)
        Me.lblCarpetaDatos.TabIndex = 4
        Me.lblCarpetaDatos.Text = "Carpeta de datos:"
        '
        'cmbTipoConexion
        '
        Me.cmbTipoConexion.FormattingEnabled = True
        Me.cmbTipoConexion.Location = New System.Drawing.Point(132, 9)
        Me.cmbTipoConexion.Name = "cmbTipoConexion"
        Me.cmbTipoConexion.Size = New System.Drawing.Size(254, 21)
        Me.cmbTipoConexion.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(133, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(251, 21)
        Me.txtNombre.TabIndex = 6
        '
        'txtServidor
        '
        Me.txtServidor.Enabled = False
        Me.txtServidor.Location = New System.Drawing.Point(134, 64)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(250, 21)
        Me.txtServidor.TabIndex = 7
        '
        'txtProtocolo
        '
        Me.txtProtocolo.Enabled = False
        Me.txtProtocolo.Location = New System.Drawing.Point(135, 91)
        Me.txtProtocolo.Name = "txtProtocolo"
        Me.txtProtocolo.Size = New System.Drawing.Size(250, 21)
        Me.txtProtocolo.TabIndex = 8
        Me.txtProtocolo.Text = "TCP/IP"
        '
        'txtCarpetaDatos
        '
        Me.txtCarpetaDatos.Location = New System.Drawing.Point(135, 118)
        Me.txtCarpetaDatos.Name = "txtCarpetaDatos"
        Me.txtCarpetaDatos.Size = New System.Drawing.Size(250, 21)
        Me.txtCarpetaDatos.TabIndex = 9
        '
        'btnAceptar
        '
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(405, 9)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(105, 21)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(405, 37)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 21)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnEliminar.Location = New System.Drawing.Point(405, 67)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(105, 21)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar ..."
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmNuevaConexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(520, 157)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCarpetaDatos)
        Me.Controls.Add(Me.txtProtocolo)
        Me.Controls.Add(Me.txtServidor)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cmbTipoConexion)
        Me.Controls.Add(Me.lblCarpetaDatos)
        Me.Controls.Add(Me.lblProtocolo)
        Me.Controls.Add(Me.lblServidor)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTipoConexion)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevaConexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abrir conexión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipoConexion As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblServidor As System.Windows.Forms.Label
    Friend WithEvents lblProtocolo As System.Windows.Forms.Label
    Friend WithEvents lblCarpetaDatos As System.Windows.Forms.Label
    Friend WithEvents cmbTipoConexion As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtServidor As System.Windows.Forms.TextBox
    Friend WithEvents txtProtocolo As System.Windows.Forms.TextBox
    Friend WithEvents txtCarpetaDatos As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
