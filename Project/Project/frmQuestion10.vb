Public Class frmQuestion10

    Private Sub btnBacktostart_Click(sender As Object, e As EventArgs) Handles btnBacktostart.Click
        Me.Hide()
        frmStartform.Show()

    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Me.Hide()
        frmStartform.Show()
        MessageBox.Show("You have clicked the wrong answer " & frmStartform.incorrect & " times", "congratulations, you're done", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnAnswer2_Click(sender As Object, e As EventArgs) Handles btnAnswer2.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        frmStartform.incorrect += 1
    End Sub

    Private Sub btnAnswer3_Click(sender As Object, e As EventArgs) Handles btnAnswer3.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        frmStartform.incorrect += 1
    End Sub
End Class