Public Class FirstPage

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        MainPage.Show()
        Me.Hide()


    End Sub


    Private Sub FirstPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class