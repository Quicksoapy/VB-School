Public Class frmQuestion9
    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        frmStartform.incorrect += 1

    End Sub

    Private Sub btnAnswer2_Click(sender As Object, e As EventArgs) Handles btnAnswer2.Click
        Me.Hide()
        frmQuestion10.Show()
    End Sub

    Private Sub btnAnswer3_Click(sender As Object, e As EventArgs) Handles btnAnswer3.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        frmStartform.incorrect += 1
    End Sub

    Private Sub btnBacktostart_Click(sender As Object, e As EventArgs) Handles btnBacktostart.Click
        Me.Hide()
        frmStartform.Show()

    End Sub
End Class