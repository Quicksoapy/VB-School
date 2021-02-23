Public Class frmQuestion4
    Private Sub btnBacktostart_Click(sender As Object, e As EventArgs) Handles btnBacktostart.Click
        Me.Hide()
        frmStartform.Show()

    End Sub

    Private Sub btnDefragmentation_Click(sender As Object, e As EventArgs) Handles btnDefragmentation.Click
        Me.Hide()
        frmQuestion5.Show()
    End Sub

    Private Sub btnFormatting_Click(sender As Object, e As EventArgs) Handles btnFormatting.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        frmStartform.incorrect += 1
    End Sub

    Private Sub btnInterleaving_Click(sender As Object, e As EventArgs) Handles btnInterleaving.Click
        MessageBox.Show("The answer you've chosen is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        frmStartform.incorrect += 1
    End Sub
End Class