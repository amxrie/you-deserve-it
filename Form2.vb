Public Class ProductivityRewardsForm

    Private Sub ProudButton_Click(sender As Object, e As EventArgs) Handles ProudButton.Click
        Me.Close()
    End Sub

    Private Sub ProductivityRewardsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PointsLabel.Text = Form1.PointsInteger.ToString()
        TasksLabel.Text = Form1.TasksInteger.ToString()

        If Form1.PointsInteger <= 0 Then
            RewardsLabel.Text = "You have " & Form1.PointsInteger &
                " productivity points today. That's okay!" & Environment.NewLine &
                "Work on your distractions and slay the day tomorrow~"
        ElseIf Form1.PointsInteger > 0 And Form1.PointsInteger < 10 Then
            RewardsLabel.Text = "You have " & Form1.PointsInteger &
                " productivity points today. Congratulations!" & Environment.NewLine &
                "You deserve a rest and " & Form1.PointsInteger & " ice creams! ><"
        ElseIf Form1.PointsInteger >= 10 Then
            RewardsLabel.Text = "You have " & Form1.PointsInteger &
                " productivity points today. GOOD JOB!" & Environment.NewLine &
                "You did great! Go buy your favorite food and enjoy <3"
        End If
    End Sub



End Class