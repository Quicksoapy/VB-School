Public Class frmQuestion7
    Private Sub btnFields_Click(sender As Object, e As EventArgs) Handles btnAnswer2.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        frmStartform.incorrect += 1
    End Sub

    Private Sub btnSectors_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        frmStartform.incorrect += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnswer3.Click
        Me.Hide()
        frmQuestion8.Show()

    End Sub

    Private Sub btnBacktostart_Click(sender As Object, e As EventArgs) Handles btnBacktostart.Click
        Me.Hide()
        frmStartform.Show()
    End Sub
End Class