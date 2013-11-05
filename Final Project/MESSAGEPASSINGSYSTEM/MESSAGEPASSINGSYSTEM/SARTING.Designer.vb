<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SARTING
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SARTING))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASFACULTYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASSTUDENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.LOGINToolStripMenuItem, Me.ABOUTUSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(87, 28)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ASFACULTYToolStripMenuItem, Me.ASSTUDENTToolStripMenuItem})
        Me.LOGINToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(90, 28)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'ABOUTUSToolStripMenuItem
        '
        Me.ABOUTUSToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABOUTUSToolStripMenuItem.Name = "ABOUTUSToolStripMenuItem"
        Me.ABOUTUSToolStripMenuItem.Size = New System.Drawing.Size(128, 28)
        Me.ABOUTUSToolStripMenuItem.Text = "ABOUT US"
        '
        'ASFACULTYToolStripMenuItem
        '
        Me.ASFACULTYToolStripMenuItem.Name = "ASFACULTYToolStripMenuItem"
        Me.ASFACULTYToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.ASFACULTYToolStripMenuItem.Text = "AS FACULTY"
        '
        'ASSTUDENTToolStripMenuItem
        '
        Me.ASSTUDENTToolStripMenuItem.Name = "ASSTUDENTToolStripMenuItem"
        Me.ASSTUDENTToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.ASSTUDENTToolStripMenuItem.Text = "AS STUDENT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(443, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(496, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 49)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(294, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(536, 49)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MESSAGE PASSING SYSTEM"
        '
        'SARTING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 1002)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SARTING"
        Me.Text = "SARTING"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASFACULTYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASSTUDENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
