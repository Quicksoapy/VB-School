Public Class frmQuestion6
    Private Sub btnSectors_Click(sender As Object, e As EventArgs) Handles btnSectors.Click
        frmQuestion7.Show()
        Me.Hide()
    End Sub

    Private Sub btnFields_Click(sender As Object, e As EventArgs) Handles btnFields.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        frmStartform.incorrect += 1
    End Sub

    Private Sub btnBacktostart_Click(sender As Object, e As EventArgs) Handles btnBacktostart.Click
        Me.Hide()
        frmStartform.Show()
    End Sub
End Class