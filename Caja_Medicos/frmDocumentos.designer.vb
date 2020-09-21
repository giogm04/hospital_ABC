<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDocumentos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocumentos))
        Me.grdDocumentos = New System.Windows.Forms.DataGridView()
        Me.colColumna0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColumna1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColumna2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColumna3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColumna4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColumna5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlsDocumentos = New System.Windows.Forms.ToolStrip()
        Me.tsbBoton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbBoton2 = New System.Windows.Forms.ToolStripButton()
        Me.tsssSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbBoton3 = New System.Windows.Forms.ToolStripButton()
        Me.txtTexto1 = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbBoton4 = New System.Windows.Forms.ToolStripButton()
        Me.tsbBoton5 = New System.Windows.Forms.ToolStripButton()
        Me.stsDocumentos = New System.Windows.Forms.StatusStrip()
        CType(Me.grdDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsDocumentos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDocumentos
        '
        Me.grdDocumentos.AllowUserToAddRows = False
        Me.grdDocumentos.AllowUserToDeleteRows = False
        Me.grdDocumentos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDocumentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colColumna0, Me.colColumna1, Me.colColumna2, Me.colColumna3, Me.colColumna4, Me.colColumna5})
        Me.grdDocumentos.Location = New System.Drawing.Point(0, 41)
        Me.grdDocumentos.Name = "grdDocumentos"
        Me.grdDocumentos.ReadOnly = True
        Me.grdDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grdDocumentos.RowHeadersVisible = False
        Me.grdDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDocumentos.Size = New System.Drawing.Size(751, 304)
        Me.grdDocumentos.TabIndex = 0
        '
        'colColumna0
        '
        Me.colColumna0.HeaderText = "Columna0"
        Me.colColumna0.Name = "colColumna0"
        Me.colColumna0.ReadOnly = True
        Me.colColumna0.Visible = False
        '
        'colColumna1
        '
        Me.colColumna1.HeaderText = "Columna1"
        Me.colColumna1.Name = "colColumna1"
        Me.colColumna1.ReadOnly = True
        '
        'colColumna2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colColumna2.DefaultCellStyle = DataGridViewCellStyle2
        Me.colColumna2.HeaderText = "Columna2"
        Me.colColumna2.Name = "colColumna2"
        Me.colColumna2.ReadOnly = True
        '
        'colColumna3
        '
        Me.colColumna3.HeaderText = "Columna3"
        Me.colColumna3.Name = "colColumna3"
        Me.colColumna3.ReadOnly = True
        '
        'colColumna4
        '
        Me.colColumna4.HeaderText = "Columna4"
        Me.colColumna4.Name = "colColumna4"
        Me.colColumna4.ReadOnly = True
        '
        'colColumna5
        '
        Me.colColumna5.HeaderText = "Columna5"
        Me.colColumna5.Name = "colColumna5"
        Me.colColumna5.ReadOnly = True
        '
        'tlsDocumentos
        '
        Me.tlsDocumentos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.tlsDocumentos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBoton1, Me.tsbBoton2, Me.tsssSeparador1, Me.tsbBoton3, Me.txtTexto1, Me.tsbBoton4, Me.tsbBoton5})
        Me.tlsDocumentos.Location = New System.Drawing.Point(0, 0)
        Me.tlsDocumentos.Name = "tlsDocumentos"
        Me.tlsDocumentos.Size = New System.Drawing.Size(751, 25)
        Me.tlsDocumentos.TabIndex = 1
        Me.tlsDocumentos.Text = "ToolStrip1"
        '
        'tsbBoton1
        '
        Me.tsbBoton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton1.Name = "tsbBoton1"
        Me.tsbBoton1.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton1.Tag = "1401"
        Me.tsbBoton1.Text = "Boton1"
        Me.tsbBoton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbBoton2
        '
        Me.tsbBoton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton2.Name = "tsbBoton2"
        Me.tsbBoton2.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton2.Tag = "1402"
        Me.tsbBoton2.Text = "Boton2"
        Me.tsbBoton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsssSeparador1
        '
        Me.tsssSeparador1.Name = "tsssSeparador1"
        Me.tsssSeparador1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbBoton3
        '
        Me.tsbBoton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton3.Name = "tsbBoton3"
        Me.tsbBoton3.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton3.Text = "Boton3"
        Me.tsbBoton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbBoton3.ToolTipText = "Periodo de la vista"
        '
        'txtTexto1
        '
        Me.txtTexto1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtTexto1.Name = "txtTexto1"
        Me.txtTexto1.ReadOnly = True
        Me.txtTexto1.Size = New System.Drawing.Size(350, 25)
        Me.txtTexto1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tsbBoton4
        '
        Me.tsbBoton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton4.Name = "tsbBoton4"
        Me.tsbBoton4.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton4.Text = "Boton4"
        Me.tsbBoton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbBoton5
        '
        Me.tsbBoton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton5.Name = "tsbBoton5"
        Me.tsbBoton5.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton5.Text = "Boton5"
        Me.tsbBoton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'stsDocumentos
        '
        Me.stsDocumentos.Location = New System.Drawing.Point(0, 348)
        Me.stsDocumentos.Name = "stsDocumentos"
        Me.stsDocumentos.Size = New System.Drawing.Size(751, 22)
        Me.stsDocumentos.TabIndex = 2
        Me.stsDocumentos.Text = "StatusStrip1"
        '
        'frmDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 370)
        Me.Controls.Add(Me.stsDocumentos)
        Me.Controls.Add(Me.tlsDocumentos)
        Me.Controls.Add(Me.grdDocumentos)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Documentos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsDocumentos.ResumeLayout(False)
        Me.tlsDocumentos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents tlsDocumentos As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBoton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBoton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsssSeparador1 As ToolStripSeparator
    Friend WithEvents tsbBoton3 As ToolStripButton
    Friend WithEvents txtTexto1 As ToolStripTextBox
    Friend WithEvents tsbBoton4 As ToolStripButton
    Friend WithEvents tsbBoton5 As ToolStripButton
    Friend WithEvents colColumna0 As DataGridViewTextBoxColumn
    Friend WithEvents colColumna1 As DataGridViewTextBoxColumn
    Friend WithEvents colColumna2 As DataGridViewTextBoxColumn
    Friend WithEvents colColumna3 As DataGridViewTextBoxColumn
    Friend WithEvents colColumna4 As DataGridViewTextBoxColumn
    Friend WithEvents colColumna5 As DataGridViewTextBoxColumn
    Friend WithEvents stsDocumentos As StatusStrip
End Class
