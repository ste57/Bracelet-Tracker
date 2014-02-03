Public Class MainPage

    Private Sub MainPage_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        statistics()

        lbldeductions.Text = My.Settings.Deduction
        lbltax.Text = My.Settings.Tax

        Me.OrderTableAdapter.getNotComplete(Me.BraceletsDataSet.Order)

        Dim customer As Integer = BraceletsDataSet.Tables("Order").Rows(Me.OrderDataGridView.CurrentRow.Index)("OrderID")

        Me.BraceletTableAdapter.ShowBraceletsForCurrentUser(Me.BraceletsDataSet.Bracelet, customer)

        If Not OrderDataGridView.RowCount = 0 Then

            OrderDataGridView.CurrentCell = OrderDataGridView.Rows(My.Settings.SelectedRow).Cells(0)

        End If

    End Sub

    Private Sub MainPage_FormClosing(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()

    End Sub

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        statistics()

        My.Settings.SelectedRow = 0

        lbldeductions.Text = My.Settings.Deduction
        lbltax.Text = My.Settings.Tax

        Me.OrderTableAdapter.getNotComplete(Me.BraceletsDataSet.Order)

        Dim customer As Integer = BraceletsDataSet.Tables("Order").Rows(Me.OrderDataGridView.CurrentRow.Index)("OrderID")

        Me.BraceletTableAdapter.ShowBraceletsForCurrentUser(Me.BraceletsDataSet.Bracelet, customer)

        statistics()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        FirstPage.Show()
        Me.Hide()

    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click

        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click

        Records.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try

            If btnOrders.Enabled = True Then

                If BraceletBindingSource.Count = 0 Then

                    btnOrders.Enabled = False

                End If

            End If

            If btnOrders.Enabled = False Then

                If Not BraceletBindingSource.Count = 0 Then

                    btnOrders.Enabled = True

                End If

            End If

            If btnMarkComplete.Enabled = True And OrderDataGridView.RowCount = 0 Then

                btnMarkComplete.Enabled = False

                Me.BraceletTableAdapter.ShipmentComplete(Me.BraceletsDataSet.Bracelet)

            End If

            If btnMarkComplete.Enabled = False And Not OrderDataGridView.RowCount = 0 Then

                btnMarkComplete.Enabled = True

            End If

            If Not OrderDataGridView.RowCount = 0 Then

                Dim customer As Integer = BraceletsDataSet.Tables("Order").Rows(Me.OrderDataGridView.CurrentRow.Index)("OrderID")

                Dim brace As Integer = BraceletsDataSet.Tables("Bracelet").Rows(Me.BraceletDataGridView.CurrentRow.Index)("CustomerID")

                If Not customer = brace Then

                    My.Settings.SelectedRow = Me.OrderDataGridView.CurrentRow.Index

                    Me.BraceletTableAdapter.ShowBraceletsForCurrentUser(Me.BraceletsDataSet.Bracelet, customer)

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message) 'error message is reported to user
        End Try

    End Sub

    Private Sub btnMarkComplete_Click(sender As Object, e As EventArgs) Handles btnMarkComplete.Click

        Dim customer As Integer = BraceletsDataSet.Tables("Order").Rows(Me.OrderDataGridView.CurrentRow.Index)("OrderID")

        CompleteOrder.Show()
        CompleteOrder.OrderTableAdapter.GetInfoOnUser(CompleteOrder.BraceletsDataSet.Order, customer)
        CompleteOrder.BraceletTableAdapter.ShowBraceletsForCurrentUser(CompleteOrder.BraceletsDataSet.Bracelet, customer)
        Me.Hide()

    End Sub

    Private Function statistics()

        Me.OrderTableAdapter.Fill(Me.BraceletsDataSet.Order)
        Me.BraceletTableAdapter.Fill(Me.BraceletsDataSet.Bracelet)

        Dim postage As Decimal = 0.0
        Dim totalCost As Decimal = 0.0

        lblBraceletsSold.Text = Me.BraceletsDataSet.Bracelet.Rows.Count

        For Each row As DataRow In BraceletsDataSet.Tables("Bracelet").Rows

            If Not row("PostageCost").ToString = vbNullString Then

                Dim postCost As Decimal = row("PostageCost")
                postage += postCost

            End If

            If Not row("Cost").ToString = vbNullString Then

                Dim cost As Decimal = row("Cost")
                totalCost += cost

            End If

        Next row

        If totalCost = 0 Then

            lblTotalEarned.Text = "£" & totalCost

        Else

            lblTotalEarned.Text = "£" & totalCost.ToString("##.##")

        End If

        If postage = 0 Then

            lblPostage.Text = "£" & postage

        Else

            lblPostage.Text = "£" & postage.ToString("##.##")

        End If

        Dim total As Double = (((totalCost - postage) - My.Settings.Deduction))

        total = (total * (1 - (My.Settings.Tax / 100)))

        If total = 0 Then

            lblProfit.Text = "£" & total

        Else

            lblProfit.Text = "£" & total.ToString("##.##")

        End If

        Return vbNull
    End Function

    Private Sub lbldeductions_TextChanged(sender As Object, e As EventArgs) Handles lbldeductions.TextChanged

        Try

            My.Settings.Deduction = lbldeductions.Text

        Catch ex As Exception
            MsgBox(ex.Message) 'error message is reported to user
        End Try


        statistics()

    End Sub

    Private Sub lbltax_TextChanged(sender As Object, e As EventArgs) Handles lbltax.TextChanged

        Try

            My.Settings.Tax = lbltax.Text

        Catch ex As Exception
            MsgBox(ex.Message) 'error message is reported to user
        End Try


        statistics()

    End Sub

End Class