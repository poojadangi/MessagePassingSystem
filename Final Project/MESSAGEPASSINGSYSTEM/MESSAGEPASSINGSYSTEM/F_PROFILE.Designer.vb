<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_PROFILE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_PROFILE))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MYPROFILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SENDMESSAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MYPROFILEToolStripMenuItem, Me.SENDMESSAGEToolStripMenuItem, Me.ABOUTUSToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(840, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MYPROFILEToolStripMenuItem
        '
        Me.MYPROFILEToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MYPROFILEToolStripMenuItem.Name = "MYPROFILEToolStripMenuItem"
        Me.MYPROFILEToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.MYPROFILEToolStripMenuItem.Text = "MY PROFILE"
        '
        'SENDMESSAGEToolStripMenuItem
        '
        Me.SENDMESSAGEToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SENDMESSAGEToolStripMenuItem.Name = "SENDMESSAGEToolStripMenuItem"
        Me.SENDMESSAGEToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.SENDMESSAGEToolStripMenuItem.Text = "SEND MESSAGE"
        '
        'ABOUTUSToolStripMenuItem
        '
        Me.ABOUTUSToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABOUTUSToolStripMenuItem.Name = "ABOUTUSToolStripMenuItem"
        Me.ABOUTUSToolStripMenuItem.Size = New System.Drawing.Size(118, 26)
        Me.ABOUTUSToolStripMenuItem.Text = "ABOUT US"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.LOGOUTToolStripMenuItem.Text = "LOG OUT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(366, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME FACULTY"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 233)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECT FIELDS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SELECT DEPARTMENT"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(178, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SELECT COURSE"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(178, 88)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SELECT SEMESTER"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(178, 130)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox3.TabIndex = 5
        '
        'F_PROFILE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 593)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "F_PROFILE"
        Me.Text = "F_PROFILE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MYPROFILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SENDMESSAGEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
