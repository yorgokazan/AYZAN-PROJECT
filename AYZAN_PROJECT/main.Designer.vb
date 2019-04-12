<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RENTALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STYLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CATEGORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COLORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BRANDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RENTALToolStripMenuItem, Me.CLIENTSToolStripMenuItem, Me.CARSToolStripMenuItem, Me.STYLEToolStripMenuItem, Me.CATEGORYToolStripMenuItem, Me.MODELToolStripMenuItem, Me.COLORToolStripMenuItem, Me.BRANDToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1077, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RENTALToolStripMenuItem
        '
        Me.RENTALToolStripMenuItem.Name = "RENTALToolStripMenuItem"
        Me.RENTALToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.RENTALToolStripMenuItem.Text = "RENTAL"
        '
        'CLIENTSToolStripMenuItem
        '
        Me.CLIENTSToolStripMenuItem.Name = "CLIENTSToolStripMenuItem"
        Me.CLIENTSToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CLIENTSToolStripMenuItem.Text = "CLIENTS"
        '
        'CARSToolStripMenuItem
        '
        Me.CARSToolStripMenuItem.Name = "CARSToolStripMenuItem"
        Me.CARSToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.CARSToolStripMenuItem.Text = "CARS"
        '
        'STYLEToolStripMenuItem
        '
        Me.STYLEToolStripMenuItem.Name = "STYLEToolStripMenuItem"
        Me.STYLEToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.STYLEToolStripMenuItem.Text = "STYLE"
        '
        'CATEGORYToolStripMenuItem
        '
        Me.CATEGORYToolStripMenuItem.Name = "CATEGORYToolStripMenuItem"
        Me.CATEGORYToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.CATEGORYToolStripMenuItem.Text = "CATEGORY"
        '
        'MODELToolStripMenuItem
        '
        Me.MODELToolStripMenuItem.Name = "MODELToolStripMenuItem"
        Me.MODELToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.MODELToolStripMenuItem.Text = "MODEL"
        '
        'COLORToolStripMenuItem
        '
        Me.COLORToolStripMenuItem.Name = "COLORToolStripMenuItem"
        Me.COLORToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.COLORToolStripMenuItem.Text = "COLOR"
        '
        'BRANDToolStripMenuItem
        '
        Me.BRANDToolStripMenuItem.Name = "BRANDToolStripMenuItem"
        Me.BRANDToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.BRANDToolStripMenuItem.Text = "BRAND"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.AYZAN_PROJECT.My.Resources.Resources._46256c04_3de5_434f_a6c9_cc25937ead38
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1077, 529)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RENTALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLIENTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CARSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STYLEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CATEGORYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODELToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COLORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BRANDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
End Class
