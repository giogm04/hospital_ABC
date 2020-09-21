<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCatalogos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalogos))
        Me.grdCatalogos1 = New System.Windows.Forms.DataGridView()
        Me.colColumna0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColumna1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColumna2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColumna3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColumna4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlsCatalogos1 = New System.Windows.Forms.ToolStrip()
        Me.tsbBoton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbBoton2 = New System.Windows.Forms.ToolStripButton()
        Me.tssSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbBoton3 = New System.Windows.Forms.ToolStripButton()
        Me.tsbBoton4 = New System.Windows.Forms.ToolStripButton()
        Me.tstCatalogos = New System.Windows.Forms.StatusStrip()
        CType(Me.grdCatalogos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsCatalogos1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdCatalogos1
        '
        Me.grdCatalogos1.AllowUserToAddRows = False
        Me.grdCatalogos1.AllowUserToDeleteRows = False
        Me.grdCatalogos1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdCatalogos1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCatalogos1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCatalogos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCatalogos1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colColumna0, Me.colColumna1, Me.colColumna2, Me.colColumna3, Me.colColumna4})
        Me.grdCatalogos1.Location = New System.Drawing.Point(0, 41)
        Me.grdCatalogos1.Name = "grdCatalogos1"
        Me.grdCatalogos1.ReadOnly = True
        Me.grdCatalogos1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grdCatalogos1.RowHeadersVisible = False
        Me.grdCatalogos1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCatalogos1.Size = New System.Drawing.Size(751, 305)
        Me.grdCatalogos1.TabIndex = 0
        Me.grdCatalogos1.Tag = "102"
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
        'tlsCatalogos1
        '
        Me.tlsCatalogos1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.tlsCatalogos1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBoton1, Me.tsbBoton2, Me.tssSeparador1, Me.tsbBoton3, Me.tsbBoton4})
        Me.tlsCatalogos1.Location = New System.Drawing.Point(0, 0)
        Me.tlsCatalogos1.Name = "tlsCatalogos1"
        Me.tlsCatalogos1.Size = New System.Drawing.Size(751, 25)
        Me.tlsCatalogos1.TabIndex = 1
        Me.tlsCatalogos1.Text = "Catalogos1"
        '
        'tsbBoton1
        '
        Me.tsbBoton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton1.Name = "tsbBoton1"
        Me.tsbBoton1.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton1.Tag = "101"
        Me.tsbBoton1.Text = "Boton1"
        Me.tsbBoton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbBoton2
        '
        Me.tsbBoton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton2.Name = "tsbBoton2"
        Me.tsbBoton2.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton2.Tag = "102"
        Me.tsbBoton2.Text = "Boton2"
        Me.tsbBoton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tssSeparador1
        '
        Me.tssSeparador1.Name = "tssSeparador1"
        Me.tssSeparador1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbBoton3
        '
        Me.tsbBoton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton3.Name = "tsbBoton3"
        Me.tsbBoton3.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton3.Text = "Boton3"
        Me.tsbBoton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbBoton4
        '
        Me.tsbBoton4.Enabled = False
        Me.tsbBoton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBoton4.Name = "tsbBoton4"
        Me.tsbBoton4.Size = New System.Drawing.Size(51, 22)
        Me.tsbBoton4.Text = "Boton4"
        Me.tsbBoton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tstCatalogos
        '
        Me.tstCatalogos.Location = New System.Drawing.Point(0, 348)
        Me.tstCatalogos.Name = "tstCatalogos"
        Me.tstCatalogos.Size = New System.Drawing.Size(751, 22)
        Me.tstCatalogos.TabIndex = 2
        Me.tstCatalogos.Text = "StatusStrip1"
        '
        'frmCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 370)
        Me.Controls.Add(Me.tstCatalogos)
        Me.Controls.Add(Me.tlsCatalogos1)
        Me.Controls.Add(Me.grdCatalogos1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCatalogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Catalogos1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdCatalogos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsCatalogos1.ResumeLayout(False)
        Me.tlsCatalogos1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdCatalogos1 As System.Windows.Forms.DataGridView
    Friend WithEvents tlsCatalogos1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBoton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBoton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador1 As ToolStripSeparator
    Friend WithEvents tsbBoton3 As ToolStripButton
    Friend WithEvents tsbBoton4 As ToolStripButton
    Friend WithEvents colColumna0 As DataGridViewTextBoxColumn
    Friend WithEvents colColumna1 As DataGridViewTextBoxColumn
    Friend WithEvents colColumna2 As DataGridViewTextBoxColumn
    Friend WithEvents colColumna3 As DataGridViewTextBoxColumn
    Friend WithEvents colColumna4 As DataGridViewTextBoxColumn
    Friend WithEvents tstCatalogos As StatusStrip
End Class
