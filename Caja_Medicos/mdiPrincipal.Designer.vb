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
        Me.stsPrincipal = New System.Windows.Forms.StatusStrip()
        Me.stlEmpresa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.stsPrincipal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'stsPrincipal
        '
        Me.stsPrincipal.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.stsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stlEmpresa, Me.stlUsuario})
        Me.stsPrincipal.Location = New System.Drawing.Point(0, 590)
        Me.stsPrincipal.Name = "stsPrincipal"
        Me.stsPrincipal.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.stsPrincipal.Size = New System.Drawing.Size(1185, 22)
        Me.stsPrincipal.TabIndex = 7
        Me.stsPrincipal.Text = "StatusStrip"
        '
        'stlEmpresa
        '
        Me.stlEmpresa.Name = "stlEmpresa"
        Me.stlEmpresa.Size = New System.Drawing.Size(584, 17)
        Me.stlEmpresa.Spring = True
        Me.stlEmpresa.Text = "Empresa"
        '
        'stlUsuario
        '
        Me.stlUsuario.Name = "stlUsuario"
        Me.stlUsuario.Size = New System.Drawing.Size(584, 17)
        Me.stlUsuario.Spring = True
        Me.stlUsuario.Text = "Usuario"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 334)
        Me.Panel1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(0, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1185, 612)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stsPrincipal)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(1185, 612)
        Me.Name = "mdiPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mdiPrincipal"
        Me.stsPrincipal.ResumeLayout(False)
        Me.stsPrincipal.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stlEmpresa As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents stlUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
