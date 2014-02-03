Public Class AddOrder

    Private Sub AddOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

    Private Sub AddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BraceletsDataSet.Order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.BraceletsDataSet.Order)

        If OrderBindingSource.Count = 0 Then

            Me.OrderBindingSource.AddNew()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        If Not OrderBindingSource.Count = 0 Then

            Me.OrderBindingSource.RemoveCurrent()
            Me.OrderBindingSource.AddNew()

        End If

        MainPage.Show()
        Me.Hide()
    End Sub

    Private Sub AddOrder_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Me.OrderTableAdapter.Fill(Me.BraceletsDataSet.Order)

        If OrderBindingSource.Count = 0 Then

            Me.OrderBindingSource.AddNew()

        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Me.Validate()
            Me.OrderBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BraceletsDataSet)

            AddBracelets.Show()

            AddBracelets.CustomerIDTextBox.Text = BraceletsDataSet.Tables("Order").Rows((Me.OrderBindingSource.Count - 1))("OrderID")
            AddBracelets.eBaylbl.Text = EbayIDTextBox.Text

            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message) 'error message is reported to user
        End Try
    End Sub
End Class