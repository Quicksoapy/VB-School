Public Class frmQuestion3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmStartform.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtAnswer.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtAnswer.Text = "726" Then
            Me.Hide()
            frmQuestion4.Show()
        Else MessageBox.Show("The answer you've chosen is incorrect, or it is not a number", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
End Class