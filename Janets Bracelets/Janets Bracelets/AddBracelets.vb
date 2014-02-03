Public Class AddBracelets

    Private Sub BraceletBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BraceletBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BraceletsDataSet)

    End Sub

    Private Sub AddBracelets_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        DateTimePicker1.Value = Date.Today

        CustomerIDTextBox.Text = BraceletsDataSet.Tables("Order").Rows((AddOrder.OrderBindingSource.Count - 1))("OrderID")

    End Sub

    Private Sub AddBracelets_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

    Private Sub AddBracelets_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'BraceletsDataSet.Bracelet' table. You can move, or remove it, as needed.
        Me.BraceletTableAdapter.Fill(Me.BraceletsDataSet.Bracelet)

        If BraceletBindingSource.Count = 0 Then

            BraceletBindingSource.AddNew()

        End If

        CustomerIDTextBox.Text = BraceletsDataSet.Tables("Order").Rows((AddOrder.OrderBindingSource.Count - 1))("OrderID")

        DateTimePicker1.Value = Date.Today

    End Sub

    Private Sub AddBracelets_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Me.BraceletTableAdapter.Fill(Me.BraceletsDataSet.Bracelet)

        If BraceletBindingSource.Count = 0 Then

            BraceletBindingSource.AddNew()

        End If

        CustomerIDTextBox.Text = BraceletsDataSet.Tables("Order").Rows((AddOrder.OrderBindingSource.Count - 1))("OrderID")

        DateTimePicker1.Value = Date.Today

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        If Not BraceletBindingSource.Count = 0 Then

            BraceletBindingSource.RemoveCurrent()
            BraceletBindingSource.AddNew()

        End If

        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            Dim custNo As String = CustomerIDTextBox.Text

            Me.Validate()
            Me.BraceletBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BraceletsDataSet)
            Me.BraceletBindingSource.AddNew()

            'DoPDateTimePicker.Value = Date.Today

            CustomerIDTextBox.Text = custNo

        Catch ex As Exception
            MsgBox(ex.Message) 'error message is reported to user
        End Try

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        Try
            If Not ColourTextBox.Text = "" Then

                Me.Validate()
                Me.BraceletBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BraceletsDataSet)
                Me.BraceletBindingSource.AddNew()

            End If

            MainPage.Show()
            Me.Hide()

            AddOrder.OrderBindingSource.AddNew()

        Catch ex As Exception
            MsgBox(ex.Message) 'error message is reported to user
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        DoPTextBox.Text = DateTimePicker1.Value

    End Sub

End Class