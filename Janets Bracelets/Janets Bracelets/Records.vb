Imports ClosedXML.Excel

Public Class Records

    Private Sub Records_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

    Private Sub Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FullDataTableAdapter.Fill(Me.BraceletsDataSet.FullData)

        Me.OrderTableAdapter.Fill(Me.BraceletsDataSet.Order)

        Dim customer As Integer = BraceletsDataSet.Tables("Order").Rows(Me.OrderDataGridView.CurrentRow.Index)("OrderID")

        Me.BraceletTableAdapter.ShowBraceletsForCurrentUser(Me.BraceletsDataSet.Bracelet, customer)

        Dim aggregate As New BindingSource


    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        Try
            Me.Validate()
            Me.OrderBindingSource.EndEdit()
            Me.BraceletBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BraceletsDataSet)

        Catch ex As Exception
            MsgBox(ex.Message) 'error message is reported to user
        End Try


        MainPage.Show()
        Me.Hide()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            Me.Validate()
            Me.OrderBindingSource.EndEdit()
            Me.BraceletBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BraceletsDataSet)

        Catch ex As Exception
            MsgBox(ex.Message) 'error message is reported to user
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim customer As Integer = 0
        Dim brace As Integer = 0

        If Not OrderBindingSource.Count = 0 Then
            customer = BraceletsDataSet.Tables("Order").Rows(Me.OrderDataGridView.CurrentRow.Index)("OrderID")
        End If

        If Not BraceletBindingSource.Count = 0 Then
            brace = BraceletsDataSet.Tables("Bracelet").Rows(Me.BraceletDataGridView.CurrentRow.Index)("CustomerID")
        End If

        If Not customer = brace Then

            Me.BraceletTableAdapter.ShowBraceletsForCurrentUser(Me.BraceletsDataSet.Bracelet, customer)

        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Try

            Dim Response As String
            Response = MsgBox("Are you sure that you want to delete this record?", vbYesNo)

            If Response = vbYes Then

                If BraceletDataGridView.Rows.Count = 0 Then

                    Me.OrderBindingSource.RemoveCurrent()
                    Me.TableAdapterManager.UpdateAll(Me.BraceletsDataSet)

                Else

                    Me.BraceletBindingSource.RemoveCurrent()
                    Me.TableAdapterManager.UpdateAll(Me.BraceletsDataSet)

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message) 'error message is reported to user
        End Try

    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click

        Try
            Dim filename As String = "C:\Bracelet Tracker Backups\" & "Backup" & "-" & Today.Day & "-" & Today.Month & "-" & Today.Year & ".xlsx"

            Dim wb As XLWorkbook = New XLWorkbook
            Dim ws = wb.Worksheets.Add(Me.BraceletsDataSet.FullData)
            ws.Tables.First().Theme = XLTableTheme.TableStyleLight10
            ws.Tables.First().ShowAutoFilter = False
            ws.Tables.First().ShowRowStripes = False

            wb.SaveAs(filename)
            MsgBox("Backup successfully stored in location:" & vbNewLine & filename)

        Catch ex As Exception
            MsgBox(ex.Message) 'error message is reported to user
        End Try

    End Sub

End Class