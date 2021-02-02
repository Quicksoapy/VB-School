Public Class frmStartform
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmQuestion1.Show()
        Me.Hide()


    End Sub
End Class
