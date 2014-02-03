Public Class CompleteOrder

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        MainPage.Show()
        Me.Hide()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            Me.Validate()
            Me.BraceletBindingSource.EndEdit()
            Me.BraceletTableAdapter.Update(Me.BraceletsDataSet.Bracelet)
            Me.BraceletTableAdapter.ShowBraceletsForCurrentUser(Me.BraceletsDataSet.Bracelet, OrderIDTextBox.Text)

        Catch ex As Exception
            MsgBox(ex.Message) 'error message is reported to user
        End Try

    End Sub

    Private Sub btnShipped_Click(sender As Object, e As EventArgs) Handles btnShipped.Click

        Dim Response As String
        Response = MsgBox("Please make sure that you have entered the relevant postage information before proceeding. Do you want to continue?", vbYesNo)

        If Response = vbYes Then

            Try
                Me.Validate()
                CompletedTextBox.Text = "Y"
                Me.OrderBindingSource.EndEdit()
                Me.BraceletBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BraceletsDataSet)

                MainPage.Show()
                Me.Hide()

            Catch ex As Exception
                MsgBox(ex.Message) 'error message is reported to user
            End Try
        End If

    End Sub

    Private Sub CompleteOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

    Private Sub CompleteOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class