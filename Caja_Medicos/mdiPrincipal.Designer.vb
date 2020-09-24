<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipal))
        Me.mnsPrincipal = New System.Windows.Forms.MenuStrip()
        Me.tsmHerramientas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPermisosModulo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmConfiguracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmUtilerias = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsPrincipal = New System.Windows.Forms.ToolStrip()
        Me.tsbCarpeta1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbElemento1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbCapeta2 = New System.Windows.Forms.ToolStripButton()
        Me.tsbElemento2 = New System.Windows.Forms.ToolStripButton()
        Me.stsPrincipal = New System.Windows.Forms.StatusStrip()
        Me.stlEmpresa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnsPrincipal.SuspendLayout()
        Me.tlsPrincipal.SuspendLayout()
        Me.stsPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsPrincipal
        '
        Me.mnsPrincipal.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.mnsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmHerramientas, Me.tsmUtilerias, Me.mnuReportes})
        Me.mnsPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnsPrincipal.Name = "mnsPrincipal"
        Me.mnsPrincipal.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnsPrincipal.Size = New System.Drawing.Size(1169, 24)
        Me.mnsPrincipal.TabIndex = 5
        Me.mnsPrincipal.Text = "MenuStrip"
        '
        'tsmHerramientas
        '
        Me.tsmHerramientas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmPermisosModulo, Me.tsmConfiguracion})
        Me.tsmHerramientas.Name = "tsmHerramientas"
        Me.tsmHerramientas.Size = New System.Drawing.Size(96, 20)
        Me.tsmHerramientas.Text = "Herramientas"
        '
        'tsmPermisosModulo
        '
        Me.tsmPermisosModulo.Name = "tsmPermisosModulo"
        Me.tsmPermisosModulo.Size = New System.Drawing.Size(193, 22)
        Me.tsmPermisosModulo.Text = "Permisos del módulo"
        '
        'tsmConfiguracion
        '
        Me.tsmConfiguracion.Name = "tsmConfiguracion"
        Me.tsmConfiguracion.Size = New System.Drawing.Size(193, 22)
        Me.tsmConfiguracion.Text = "Configuración"
        '
        'tsmUtilerias
        '
        Me.tsmUtilerias.Name = "tsmUtilerias"
        Me.tsmUtilerias.Size = New System.Drawing.Size(65, 20)
        Me.tsmUtilerias.Tag = "1900"
        Me.tsmUtilerias.Text = "Utilerías"
        '
        'mnuReportes
        '
        Me.mnuReportes.Name = "mnuReportes"
        Me.mnuReportes.Size = New System.Drawing.Size(70, 20)
        Me.mnuReportes.Tag = "1800"
        Me.mnuReportes.Text = "Reportes"
        '
        'tlsPrincipal
        '
        Me.tlsPrincipal.AutoSize = False
        Me.tlsPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tlsPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlsPrincipal.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.tlsPrincipal.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCarpeta1, Me.tsbElemento1, Me.tsbCapeta2, Me.tsbElemento2})
        Me.tlsPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tlsPrincipal.Location = New System.Drawing.Point(0, 24)
        Me.tlsPrincipal.Name = "tlsPrincipal"
        Me.tlsPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tlsPrincipal.Size = New System.Drawing.Size(125, 527)
        Me.tlsPrincipal.Stretch = True
        Me.tlsPrincipal.TabIndex = 6
        Me.tlsPrincipal.Text = "tlsPrincipal"
        '
        'tsbCarpeta1
        '
        Me.tsbCarpeta1.BackColor = System.Drawing.Color.Silver
        Me.tsbCarpeta1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCarpeta1.Image = CType(resources.GetObject("tsbCarpeta1.Image"), System.Drawing.Image)
        Me.tsbCarpeta1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCarpeta1.Name = "tsbCarpeta1"
        Me.tsbCarpeta1.Size = New System.Drawing.Size(123, 17)
        Me.tsbCarpeta1.Tag = "10"
        Me.tsbCarpeta1.Text = "Carpeta1"
        '
        'tsbElemento1
        '
        Me.tsbElemento1.Image = CType(resources.GetObject("tsbElemento1.Image"), System.Drawing.Image)
        Me.tsbElemento1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbElemento1.Name = "tsbElemento1"
        Me.tsbElemento1.Size = New System.Drawing.Size(123, 49)
        Me.tsbElemento1.Tag = "100"
        Me.tsbElemento1.Text = "Elemento1"
        Me.tsbElemento1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbCapeta2
        '
        Me.tsbCapeta2.BackColor = System.Drawing.Color.Silver
        Me.tsbCapeta2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCapeta2.Image = CType(resources.GetObject("tsbCapeta2.Image"), System.Drawing.Image)
        Me.tsbCapeta2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCapeta2.Name = "tsbCapeta2"
        Me.tsbCapeta2.Size = New System.Drawing.Size(123, 17)
        Me.tsbCapeta2.Tag = "30"
        Me.tsbCapeta2.Text = "Capeta2"
        '
        'tsbElemento2
        '
        Me.tsbElemento2.Image = CType(resources.GetObject("tsbElemento2.Image"), System.Drawing.Image)
        Me.tsbElemento2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbElemento2.Name = "tsbElemento2"
        Me.tsbElemento2.Size = New System.Drawing.Size(123, 49)
        Me.tsbElemento2.Tag = "1100"
        Me.tsbElemento2.Text = "Elemento2"
        Me.tsbElemento2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbElemento2.Visible = False
        '
        'stsPrincipal
        '
        Me.stsPrincipal.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.stsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stlEmpresa, Me.stlUsuario})
        Me.stsPrincipal.Location = New System.Drawing.Point(0, 551)
        Me.stsPrincipal.Name = "stsPrincipal"
        Me.stsPrincipal.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.stsPrincipal.Size = New System.Drawing.Size(1169, 22)
        Me.stsPrincipal.TabIndex = 7
        Me.stsPrincipal.Text = "StatusStrip"
        '
        'stlEmpresa
        '
        Me.stlEmpresa.Name = "stlEmpresa"
        Me.stlEmpresa.Size = New System.Drawing.Size(576, 17)
        Me.stlEmpresa.Spring = True
        Me.stlEmpresa.Text = "Empresa"
        '
        'stlUsuario
        '
        Me.stlUsuario.Name = "stlUsuario"
        Me.stlUsuario.Size = New System.Drawing.Size(576, 17)
        Me.stlUsuario.Spring = True
        Me.stlUsuario.Text = "Usuario"
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1169, 573)
        Me.Controls.Add(Me.tlsPrincipal)
        Me.Controls.Add(Me.mnsPrincipal)
        Me.Controls.Add(Me.stsPrincipal)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnsPrincipal
        Me.MinimumSize = New System.Drawing.Size(1185, 612)
        Me.Name = "mdiPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mdiPrincipal"
        Me.mnsPrincipal.ResumeLayout(False)
        Me.mnsPrincipal.PerformLayout()
        Me.tlsPrincipal.ResumeLayout(False)
        Me.tlsPrincipal.PerformLayout()
        Me.stsPrincipal.ResumeLayout(False)
        Me.stsPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stlEmpresa As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents tlsPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents mnsPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmHerramientas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stlUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsmPermisosModulo As ToolStripMenuItem
    Friend WithEvents tsmConfiguracion As ToolStripMenuItem
    Friend WithEvents tsmUtilerias As ToolStripMenuItem
    Friend WithEvents tsbElemento2 As ToolStripButton
    Friend WithEvents tsbCarpeta1 As ToolStripButton
    Friend WithEvents tsbCapeta2 As ToolStripButton
    Friend WithEvents tsbElemento1 As ToolStripButton
    Friend WithEvents mnuReportes As ToolStripMenuItem
End Class
