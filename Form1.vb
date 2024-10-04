Public Class Form1
    Const PRIORITY1_Integer As Integer = 3
    Const PRIORITY2_Integer As Integer = 2
    Const PRIORITY3_Integer As Integer = 1
    Const PRIORITY4_Integer As Integer = -1

    Friend PointsInteger, TasksInteger As Integer

    Private Sub AddTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTaskToolStripMenuItem.Click
        If Priority1RadioButton.Checked Then
            PointsInteger += PRIORITY1_Integer
        ElseIf Priority2RadioButton.Checked Then
            PointsInteger += PRIORITY2_Integer
        ElseIf Priority3RadioButton.Checked Then
            PointsInteger += PRIORITY3_Integer
        ElseIf Priority4RadioButton.Checked Then
            PointsInteger += PRIORITY4_Integer
        End If
        TasksInteger += 1
        TaskTextBox.Clear()
        Priority1RadioButton.Focus()
    End Sub

    Private Sub RewardsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RewardsToolStripMenuItem.Click
        ProductivityRewardsForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RemoveTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTaskToolStripMenuItem.Click
        If Priority1RadioButton.Checked Then
            PointsInteger -= PRIORITY1_Integer
        ElseIf Priority2RadioButton.Checked Then
            PointsInteger -= PRIORITY2_Integer
        ElseIf Priority3RadioButton.Checked Then
            PointsInteger -= PRIORITY3_Integer
        ElseIf Priority4RadioButton.Checked Then
            PointsInteger -= PRIORITY4_Integer
        End If
        TasksInteger -= 1
        TaskTextBox.Clear()
        Priority1RadioButton.Focus()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim MessageString As String

        MessageString = "Program: Productivity Corner" & Environment.NewLine &
            "Programmer: amxrie"

        MessageBox.Show(MessageString, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PointsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PointsToolStripMenuItem.Click
        Dim MessageString As String

        MessageString = "Current Productive Points: " & PointsInteger

        MessageBox.Show(MessageString, "Productive Points",
            MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub
End Class
