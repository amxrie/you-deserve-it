<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PointsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RewardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Priority4RadioButton = New System.Windows.Forms.RadioButton()
        Me.Priority2RadioButton = New System.Windows.Forms.RadioButton()
        Me.Priority3RadioButton = New System.Windows.Forms.RadioButton()
        Me.Priority1RadioButton = New System.Windows.Forms.RadioButton()
        Me.TaskLabel = New System.Windows.Forms.Label()
        Me.TaskTextBox = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(467, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(438, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PointsToolStripMenuItem, Me.RewardsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PointsToolStripMenuItem
        '
        Me.PointsToolStripMenuItem.Name = "PointsToolStripMenuItem"
        Me.PointsToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.PointsToolStripMenuItem.Text = "&Points"
        '
        'RewardsToolStripMenuItem
        '
        Me.RewardsToolStripMenuItem.Name = "RewardsToolStripMenuItem"
        Me.RewardsToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.RewardsToolStripMenuItem.Text = "&Rewards"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTaskToolStripMenuItem, Me.RemoveTaskToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddTaskToolStripMenuItem
        '
        Me.AddTaskToolStripMenuItem.Name = "AddTaskToolStripMenuItem"
        Me.AddTaskToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AddTaskToolStripMenuItem.Text = "&Add Task"
        '
        'RemoveTaskToolStripMenuItem
        '
        Me.RemoveTaskToolStripMenuItem.Name = "RemoveTaskToolStripMenuItem"
        Me.RemoveTaskToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RemoveTaskToolStripMenuItem.Text = "&Remove Task"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Priority4RadioButton)
        Me.GroupBox1.Controls.Add(Me.Priority2RadioButton)
        Me.GroupBox1.Controls.Add(Me.Priority3RadioButton)
        Me.GroupBox1.Controls.Add(Me.Priority1RadioButton)
        Me.GroupBox1.Controls.Add(Me.TaskLabel)
        Me.GroupBox1.Controls.Add(Me.TaskTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 208)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(-25, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(438, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "PRIORITY LEVEL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Priority4RadioButton
        '
        Me.Priority4RadioButton.AutoSize = True
        Me.Priority4RadioButton.Location = New System.Drawing.Point(100, 170)
        Me.Priority4RadioButton.Name = "Priority4RadioButton"
        Me.Priority4RadioButton.Size = New System.Drawing.Size(186, 19)
        Me.Priority4RadioButton.TabIndex = 8
        Me.Priority4RadioButton.TabStop = True
        Me.Priority4RadioButton.Text = "Not Important and Not Urgent"
        Me.Priority4RadioButton.UseVisualStyleBackColor = True
        '
        'Priority2RadioButton
        '
        Me.Priority2RadioButton.AutoSize = True
        Me.Priority2RadioButton.Location = New System.Drawing.Point(100, 120)
        Me.Priority2RadioButton.Name = "Priority2RadioButton"
        Me.Priority2RadioButton.Size = New System.Drawing.Size(163, 19)
        Me.Priority2RadioButton.TabIndex = 6
        Me.Priority2RadioButton.TabStop = True
        Me.Priority2RadioButton.Text = "Important and Not Urgent"
        Me.Priority2RadioButton.UseVisualStyleBackColor = True
        '
        'Priority3RadioButton
        '
        Me.Priority3RadioButton.AutoSize = True
        Me.Priority3RadioButton.Location = New System.Drawing.Point(100, 145)
        Me.Priority3RadioButton.Name = "Priority3RadioButton"
        Me.Priority3RadioButton.Size = New System.Drawing.Size(163, 19)
        Me.Priority3RadioButton.TabIndex = 7
        Me.Priority3RadioButton.TabStop = True
        Me.Priority3RadioButton.Text = "Not Important and Urgent"
        Me.Priority3RadioButton.UseVisualStyleBackColor = True
        '
        'Priority1RadioButton
        '
        Me.Priority1RadioButton.AutoSize = True
        Me.Priority1RadioButton.Location = New System.Drawing.Point(100, 95)
        Me.Priority1RadioButton.Name = "Priority1RadioButton"
        Me.Priority1RadioButton.Size = New System.Drawing.Size(140, 19)
        Me.Priority1RadioButton.TabIndex = 5
        Me.Priority1RadioButton.TabStop = True
        Me.Priority1RadioButton.Text = "Important and Urgent"
        Me.Priority1RadioButton.UseVisualStyleBackColor = True
        '
        'TaskLabel
        '
        Me.TaskLabel.AutoSize = True
        Me.TaskLabel.Location = New System.Drawing.Point(24, 31)
        Me.TaskLabel.Name = "TaskLabel"
        Me.TaskLabel.Size = New System.Drawing.Size(29, 15)
        Me.TaskLabel.TabIndex = 1
        Me.TaskLabel.Text = "&Task"
        '
        'TaskTextBox
        '
        Me.TaskTextBox.Location = New System.Drawing.Point(83, 28)
        Me.TaskTextBox.Name = "TaskTextBox"
        Me.TaskTextBox.Size = New System.Drawing.Size(265, 23)
        Me.TaskTextBox.TabIndex = 0
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 374)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You DeServe It~"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TaskLabel As Label
    Friend WithEvents TaskTextBox As TextBox
    Friend WithEvents Priority4RadioButton As RadioButton
    Friend WithEvents Priority2RadioButton As RadioButton
    Friend WithEvents Priority3RadioButton As RadioButton
    Friend WithEvents Priority1RadioButton As RadioButton
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PointsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RewardsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
