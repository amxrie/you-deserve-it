<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductivityRewardsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RewardsLabel = New System.Windows.Forms.Label()
        Me.ProudButton = New System.Windows.Forms.Button()
        Me.TasksLabel = New System.Windows.Forms.Label()
        Me.PointsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(86, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You DeServe It!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tasks Done:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Productivity Points:"
        '
        'RewardsLabel
        '
        Me.RewardsLabel.Location = New System.Drawing.Point(12, 135)
        Me.RewardsLabel.Name = "RewardsLabel"
        Me.RewardsLabel.Size = New System.Drawing.Size(378, 62)
        Me.RewardsLabel.TabIndex = 7
        Me.RewardsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProudButton
        '
        Me.ProudButton.AutoSize = True
        Me.ProudButton.Location = New System.Drawing.Point(141, 209)
        Me.ProudButton.Name = "ProudButton"
        Me.ProudButton.Size = New System.Drawing.Size(121, 25)
        Me.ProudButton.TabIndex = 8
        Me.ProudButton.Text = "I'm proud of myself"
        Me.ProudButton.UseVisualStyleBackColor = True
        '
        'TasksLabel
        '
        Me.TasksLabel.Location = New System.Drawing.Point(202, 74)
        Me.TasksLabel.Name = "TasksLabel"
        Me.TasksLabel.Size = New System.Drawing.Size(114, 23)
        Me.TasksLabel.TabIndex = 9
        Me.TasksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PointsLabel
        '
        Me.PointsLabel.Location = New System.Drawing.Point(202, 99)
        Me.PointsLabel.Name = "PointsLabel"
        Me.PointsLabel.Size = New System.Drawing.Size(114, 23)
        Me.PointsLabel.TabIndex = 10
        Me.PointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProductivityRewardsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 245)
        Me.Controls.Add(Me.PointsLabel)
        Me.Controls.Add(Me.TasksLabel)
        Me.Controls.Add(Me.ProudButton)
        Me.Controls.Add(Me.RewardsLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProductivityRewardsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productivity Rewards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RewardsLabel As Label
    Friend WithEvents ProudButton As Button
    Friend WithEvents TasksLabel As Label
    Friend WithEvents PointsLabel As Label
    Friend WithEvents TextBox1 As TextBox
End Class
