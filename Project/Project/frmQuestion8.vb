Public Class frmQuestion8
    Private Sub btnFields_Click(sender As Object, e As EventArgs) Handles btnAnswer2.Click
        Me.Hide()
        frmQuestion9.Show()

    End Sub

    Private Sub btnSectors_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnswer3.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub

    Private Sub btnBacktostart_Click(sender As Object, e As EventArgs) Handles btnBacktostart.Click
        Me.Hide()
        frmStartform.Show()
    End Sub
End Class