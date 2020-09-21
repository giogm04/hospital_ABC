<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogo1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalogo1))
        Me.txtCatalogoId = New System.Windows.Forms.TextBox()
        Me.tlsCatalogo1 = New System.Windows.Forms.ToolStrip()
        Me.tsbBoton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbBoton2 = New System.Windows.Forms.ToolStripButton()
        Me.tsbBoton3 = New System.Windows.Forms.ToolStripButton()
        Me.grbPlanta = New System.Windows.Forms.GroupBox()
        Me.cmbCampo3 = New System.Windows.Forms.ComboBox()
        Me.lblCampo3 = New System.Windows.Forms.Label()
        Me.txtCampo4 = New System.Windows.Forms.TextBox()
        Me.lblCampo4 = New System.Windows.Forms.Label()
        Me.txtCampo2 = New System.Windows.Forms.TextBox()
        Me.lblCampo2 = New System.Windows.Forms.Label()
        Me.txtCampo1 = New System.Windows.Forms.TextBox()
        Me.lblCampo1 = New System.Windows.Forms.Label()
        Me.tlsCatalogo1.SuspendLayout()
        Me.grbPlanta.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCatalogoId
        '
        Me.txtCatalogoId.Location = New System.Drawing.Point(220, 12)
        Me.txtCatalogoId.Multiline = True
        Me.txtCatalogoId.Name = "txtCatalogoId"
        Me.txtCatalogoId.Size = New System.Drawing.Size(71, 20)
        Me.txtCatalogoId.TabIndex = 9
        Me.txtCatalogoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCatalogoId.Visible = False
        '
        'tlsCatalogo1
        '
        Me.tlsCatalogo1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.tlsCatalogo1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBoton1, Me.tsbBoton2, Me.tsbBoton3})
        Me.tlsCatalogo1.Location = New System.Drawing.Point(0, 0)
        Me.tlsCatalogo1.Name = "tlsCatalogo1"
        Me.tlsCatalogo1.Size = New System.Drawing.Size(358, 25)
        Me.tlsCatalogo1.TabIndex = 7
        Me.tlsCatalogo1.Text = "ToolStrip1"
        '
        'tsbBoton1
        '
        Me.tsbBoton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton1.Name = "tsbBoton1"
        Me.tsbBoton1.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton1.Tag = "103"
        Me.tsbBoton1.Text = "Boton1"
        Me.tsbBoton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbBoton2
        '
        Me.tsbBoton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton2.Name = "tsbBoton2"
        Me.tsbBoton2.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton2.Text = "Boton2"
        Me.tsbBoton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbBoton3
        '
        Me.tsbBoton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton3.Name = "tsbBoton3"
        Me.tsbBoton3.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton3.Tag = "104"
        Me.tsbBoton3.Text = "Boton3"
        Me.tsbBoton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'grbPlanta
        '
        Me.grbPlanta.Controls.Add(Me.cmbCampo3)
        Me.grbPlanta.Controls.Add(Me.lblCampo3)
        Me.grbPlanta.Controls.Add(Me.txtCampo4)
        Me.grbPlanta.Controls.Add(Me.lblCampo4)
        Me.grbPlanta.Controls.Add(Me.txtCampo2)
        Me.grbPlanta.Controls.Add(Me.lblCampo2)
        Me.grbPlanta.Controls.Add(Me.txtCampo1)
        Me.grbPlanta.Controls.Add(Me.lblCampo1)
        Me.grbPlanta.Location = New System.Drawing.Point(12, 39)
        Me.grbPlanta.Name = "grbPlanta"
        Me.grbPlanta.Size = New System.Drawing.Size(334, 152)
        Me.grbPlanta.TabIndex = 8
        Me.grbPlanta.TabStop = False
        '
        'cmbCampo3
        '
        Me.cmbCampo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCampo3.FormattingEnabled = True
        Me.cmbCampo3.Location = New System.Drawing.Point(109, 74)
        Me.cmbCampo3.Name = "cmbCampo3"
        Me.cmbCampo3.Size = New System.Drawing.Size(213, 21)
        Me.cmbCampo3.TabIndex = 2
        '
        'lblCampo3
        '
        Me.lblCampo3.AutoSize = True
        Me.lblCampo3.Location = New System.Drawing.Point(7, 85)
        Me.lblCampo3.Name = "lblCampo3"
        Me.lblCampo3.Size = New System.Drawing.Size(55, 13)
        Me.lblCampo3.TabIndex = 12
        Me.lblCampo3.Text = "Campo3"
        '
        'txtCampo4
        '
        Me.txtCampo4.Location = New System.Drawing.Point(109, 102)
        Me.txtCampo4.Multiline = True
        Me.txtCampo4.Name = "txtCampo4"
        Me.txtCampo4.Size = New System.Drawing.Size(210, 44)
        Me.txtCampo4.TabIndex = 3
        '
        'lblCampo4
        '
        Me.lblCampo4.AutoSize = True
        Me.lblCampo4.Location = New System.Drawing.Point(7, 110)
        Me.lblCampo4.Name = "lblCampo4"
        Me.lblCampo4.Size = New System.Drawing.Size(55, 13)
        Me.lblCampo4.TabIndex = 10
        Me.lblCampo4.Text = "Campo4"
        '
        'txtCampo2
        '
        Me.txtCampo2.Location = New System.Drawing.Point(109, 47)
        Me.txtCampo2.Name = "txtCampo2"
        Me.txtCampo2.Size = New System.Drawing.Size(213, 21)
        Me.txtCampo2.TabIndex = 1
        '
        'lblCampo2
        '
        Me.lblCampo2.AutoSize = True
        Me.lblCampo2.Location = New System.Drawing.Point(7, 55)
        Me.lblCampo2.Name = "lblCampo2"
        Me.lblCampo2.Size = New System.Drawing.Size(55, 13)
        Me.lblCampo2.TabIndex = 8
        Me.lblCampo2.Text = "Campo2"
        '
        'txtCampo1
        '
        Me.txtCampo1.Location = New System.Drawing.Point(109, 20)
        Me.txtCampo1.Name = "txtCampo1"
        Me.txtCampo1.Size = New System.Drawing.Size(90, 21)
        Me.txtCampo1.TabIndex = 0
        '
        'lblCampo1
        '
        Me.lblCampo1.AutoSize = True
        Me.lblCampo1.Location = New System.Drawing.Point(7, 28)
        Me.lblCampo1.Name = "lblCampo1"
        Me.lblCampo1.Size = New System.Drawing.Size(55, 13)
        Me.lblCampo1.TabIndex = 0
        Me.lblCampo1.Text = "Campo1"
        '
        'frmCatalogo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(358, 203)
        Me.Controls.Add(Me.txtCatalogoId)
        Me.Controls.Add(Me.tlsCatalogo1)
        Me.Controls.Add(Me.grbPlanta)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCatalogo1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Catalogo1"
        Me.tlsCatalogo1.ResumeLayout(False)
        Me.tlsCatalogo1.PerformLayout()
        Me.grbPlanta.ResumeLayout(False)
        Me.grbPlanta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCatalogoId As TextBox
    Friend WithEvents tlsCatalogo1 As ToolStrip
    Friend WithEvents tsbBoton1 As ToolStripButton
    Friend WithEvents tsbBoton2 As ToolStripButton
    Friend WithEvents tsbBoton3 As ToolStripButton
    Friend WithEvents grbPlanta As GroupBox
    Friend WithEvents txtCampo1 As TextBox
    Friend WithEvents lblCampo1 As Label
    Friend WithEvents txtCampo4 As TextBox
    Friend WithEvents lblCampo4 As Label
    Friend WithEvents txtCampo2 As TextBox
    Friend WithEvents lblCampo2 As Label
    Friend WithEvents cmbCampo3 As ComboBox
    Friend WithEvents lblCampo3 As Label
End Class
