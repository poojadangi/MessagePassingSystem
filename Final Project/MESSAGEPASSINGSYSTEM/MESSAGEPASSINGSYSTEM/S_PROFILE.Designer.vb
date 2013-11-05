<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_PROFILE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S_PROFILE))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MYPROFILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INBOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MYPROFILEToolStripMenuItem, Me.INBOXToolStripMenuItem, Me.ABOUTUSToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(926, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MYPROFILEToolStripMenuItem
        '
        Me.MYPROFILEToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MYPROFILEToolStripMenuItem.Name = "MYPROFILEToolStripMenuItem"
        Me.MYPROFILEToolStripMenuItem.Size = New System.Drawing.Size(155, 28)
        Me.MYPROFILEToolStripMenuItem.Text = "MY PROFILE"
        '
        'INBOXToolStripMenuItem
        '
        Me.INBOXToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INBOXToolStripMenuItem.Name = "INBOXToolStripMenuItem"
        Me.INBOXToolStripMenuItem.Size = New System.Drawing.Size(90, 28)
        Me.INBOXToolStripMenuItem.Text = "INBOX"
        '
        'ABOUTUSToolStripMenuItem
        '
        Me.ABOUTUSToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABOUTUSToolStripMenuItem.Name = "ABOUTUSToolStripMenuItem"
        Me.ABOUTUSToolStripMenuItem.Size = New System.Drawing.Size(128, 28)
        Me.ABOUTUSToolStripMenuItem.Text = "ABOUT US"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(117, 28)
        Me.LOGOUTToolStripMenuItem.Text = "LOG OUT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME STUDENT"
        '
        'S_PROFILE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(926, 616)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "S_PROFILE"
        Me.Text = "S_PROFILE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MYPROFILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INBOXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
