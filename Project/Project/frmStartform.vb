Public Class frmStartform
    Public incorrect As Integer
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmQuestion1.Show()
        Me.Hide()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblAmount.Click
        If Not incorrect = 0 Then
            lblAmount.Text = "You have made an mistake " & incorrect & " amount of times"
        End If
    End Sub
End Class
