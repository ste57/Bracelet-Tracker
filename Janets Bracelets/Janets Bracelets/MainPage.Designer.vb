<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BraceletDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BraceletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BraceletsDataSet = New WindowsApplication1.BraceletsDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblProfit = New System.Windows.Forms.Label()
        Me.lblTotalEarned = New System.Windows.Forms.Label()
        Me.lblBraceletsSold = New System.Windows.Forms.Label()
        Me.lblPostage = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnMarkComplete = New System.Windows.Forms.Button()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltax = New System.Windows.Forms.TextBox()
        Me.OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbldeductions = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OrderTableAdapter = New WindowsApplication1.BraceletsDataSetTableAdapters.OrderTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.BraceletsDataSetTableAdapters.TableAdapterManager()
        Me.BraceletTableAdapter = New WindowsApplication1.BraceletsDataSetTableAdapters.BraceletTableAdapter()
        CType(Me.BraceletDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BraceletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BraceletsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(225, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Janet's Bracelet Tracker"
        '
        'BraceletDataGridView
        '
        Me.BraceletDataGridView.AllowUserToAddRows = False
        Me.BraceletDataGridView.AllowUserToDeleteRows = False
        Me.BraceletDataGridView.AutoGenerateColumns = False
        Me.BraceletDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BraceletDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn4})
        Me.BraceletDataGridView.DataSource = Me.BraceletBindingSource
        Me.BraceletDataGridView.Location = New System.Drawing.Point(12, 255)
        Me.BraceletDataGridView.Name = "BraceletDataGridView"
        Me.BraceletDataGridView.ReadOnly = True
        Me.BraceletDataGridView.Size = New System.Drawing.Size(614, 178)
        Me.BraceletDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NameOnBracelet"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Name On Bracelet"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Colour"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Colour"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Size"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cost"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DoP"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date of Purchase"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 140
        '
        'BraceletBindingSource
        '
        Me.BraceletBindingSource.DataMember = "Bracelet"
        Me.BraceletBindingSource.DataSource = Me.BraceletsDataSet
        '
        'BraceletsDataSet
        '
        Me.BraceletsDataSet.DataSetName = "BraceletsDataSet"
        Me.BraceletsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Amount Earned:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Spent On Postage:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Bracelets Sold:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(235, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Profit (After tax):"
        '
        'lblProfit
        '
        Me.lblProfit.AutoSize = True
        Me.lblProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfit.ForeColor = System.Drawing.Color.Green
        Me.lblProfit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblProfit.Location = New System.Drawing.Point(233, 38)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(41, 29)
        Me.lblProfit.TabIndex = 7
        Me.lblProfit.Text = "£0"
        '
        'lblTotalEarned
        '
        Me.lblTotalEarned.AutoSize = True
        Me.lblTotalEarned.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEarned.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalEarned.Location = New System.Drawing.Point(142, 16)
        Me.lblTotalEarned.Name = "lblTotalEarned"
        Me.lblTotalEarned.Size = New System.Drawing.Size(23, 15)
        Me.lblTotalEarned.TabIndex = 8
        Me.lblTotalEarned.Text = "£0"
        '
        'lblBraceletsSold
        '
        Me.lblBraceletsSold.AutoSize = True
        Me.lblBraceletsSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBraceletsSold.ForeColor = System.Drawing.Color.Gray
        Me.lblBraceletsSold.Location = New System.Drawing.Point(108, 62)
        Me.lblBraceletsSold.Name = "lblBraceletsSold"
        Me.lblBraceletsSold.Size = New System.Drawing.Size(15, 15)
        Me.lblBraceletsSold.TabIndex = 9
        Me.lblBraceletsSold.Text = "0"
        '
        'lblPostage
        '
        Me.lblPostage.AutoSize = True
        Me.lblPostage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostage.ForeColor = System.Drawing.Color.IndianRed
        Me.lblPostage.Location = New System.Drawing.Point(157, 38)
        Me.lblPostage.Name = "lblPostage"
        Me.lblPostage.Size = New System.Drawing.Size(23, 15)
        Me.lblPostage.TabIndex = 10
        Me.lblPostage.Text = "£0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOrders)
        Me.GroupBox1.Controls.Add(Me.btnMarkComplete)
        Me.GroupBox1.Controls.Add(Me.btnAddOrder)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 80)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manage Orders"
        '
        'btnOrders
        '
        Me.btnOrders.Location = New System.Drawing.Point(270, 19)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(126, 50)
        Me.btnOrders.TabIndex = 12
        Me.btnOrders.Text = "View Order Records"
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnMarkComplete
        '
        Me.btnMarkComplete.Location = New System.Drawing.Point(6, 19)
        Me.btnMarkComplete.Name = "btnMarkComplete"
        Me.btnMarkComplete.Size = New System.Drawing.Size(126, 50)
        Me.btnMarkComplete.TabIndex = 1
        Me.btnMarkComplete.Text = "Mark As Complete"
        Me.btnMarkComplete.UseVisualStyleBackColor = True
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Location = New System.Drawing.Point(138, 19)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(126, 50)
        Me.btnAddOrder.TabIndex = 0
        Me.btnAddOrder.Text = "Add An Order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblProfit)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblPostage)
        Me.GroupBox2.Controls.Add(Me.lblBraceletsSold)
        Me.GroupBox2.Controls.Add(Me.lblTotalEarned)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 84)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Statistics"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(439, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Total Tax:                       %"
        '
        'lbltax
        '
        Me.lbltax.Location = New System.Drawing.Point(494, 54)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(57, 20)
        Me.lbltax.TabIndex = 16
        '
        'OrderDataGridView
        '
        Me.OrderDataGridView.AllowUserToAddRows = False
        Me.OrderDataGridView.AllowUserToDeleteRows = False
        Me.OrderDataGridView.AutoGenerateColumns = False
        Me.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        Me.OrderDataGridView.DataSource = Me.OrderBindingSource
        Me.OrderDataGridView.Location = New System.Drawing.Point(12, 54)
        Me.OrderDataGridView.MultiSelect = False
        Me.OrderDataGridView.Name = "OrderDataGridView"
        Me.OrderDataGridView.ReadOnly = True
        Me.OrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrderDataGridView.Size = New System.Drawing.Size(205, 195)
        Me.OrderDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EbayID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "eBay Username"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 162
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.BraceletsDataSet
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(226, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Total deductions: £"
        '
        'lbldeductions
        '
        Me.lbldeductions.Location = New System.Drawing.Point(330, 54)
        Me.lbldeductions.Name = "lbldeductions"
        Me.lbldeductions.Size = New System.Drawing.Size(72, 20)
        Me.lbldeductions.TabIndex = 17
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(535, 9)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(91, 27)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BraceletTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Me.OrderTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.BraceletsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BraceletTableAdapter
        '
        Me.BraceletTableAdapter.ClearBeforeFill = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(646, 453)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbldeductions)
        Me.Controls.Add(Me.OrderDataGridView)
        Me.Controls.Add(Me.lbltax)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BraceletDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tracker"
        Me.TransparencyKey = System.Drawing.Color.FloralWhite
        CType(Me.BraceletDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BraceletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BraceletsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BraceletsDataSet As WindowsApplication1.BraceletsDataSet
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTableAdapter As WindowsApplication1.BraceletsDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.BraceletsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BraceletBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BraceletTableAdapter As WindowsApplication1.BraceletsDataSetTableAdapters.BraceletTableAdapter
    Friend WithEvents BraceletDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblProfit As System.Windows.Forms.Label
    Friend WithEvents lblTotalEarned As System.Windows.Forms.Label
    Friend WithEvents lblBraceletsSold As System.Windows.Forms.Label
    Friend WithEvents lblPostage As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOrders As System.Windows.Forms.Button
    Friend WithEvents btnMarkComplete As System.Windows.Forms.Button
    Friend WithEvents btnAddOrder As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbltax As System.Windows.Forms.TextBox
    Friend WithEvents OrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbldeductions As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
