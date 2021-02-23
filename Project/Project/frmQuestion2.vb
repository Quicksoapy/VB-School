Public Class frmQuestion2
    Private Sub btnBacktostart_Click(sender As Object, e As EventArgs) Handles btnBacktostart.Click
        Me.Hide()
        frmStartform.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        frmStartform.incorrect += 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        frmStartform.incorrect += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmQuestion3.Show()

    End Sub
End Class