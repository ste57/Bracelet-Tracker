<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompleteOrder
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
        Dim EbayIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim PostageCostLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EbayIDTextBox = New System.Windows.Forms.TextBox()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BraceletsDataSet = New WindowsApplication1.BraceletsDataSet()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.BraceletDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BraceletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnShipped = New System.Windows.Forms.Button()
        Me.PostageCostTextBox = New System.Windows.Forms.TextBox()
        Me.OrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CompletedTextBox = New System.Windows.Forms.TextBox()
        Me.OrderTableAdapter = New WindowsApplication1.BraceletsDataSetTableAdapters.OrderTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.BraceletsDataSetTableAdapters.TableAdapterManager()
        Me.BraceletTableAdapter = New WindowsApplication1.BraceletsDataSetTableAdapters.BraceletTableAdapter()
        EbayIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        PostageCostLabel = New System.Windows.Forms.Label()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BraceletsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BraceletDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BraceletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EbayIDLabel
        '
        EbayIDLabel.AutoSize = True
        EbayIDLabel.Location = New System.Drawing.Point(12, 55)
        EbayIDLabel.Name = "EbayIDLabel"
        EbayIDLabel.Size = New System.Drawing.Size(48, 13)
        EbayIDLabel.TabIndex = 4
        EbayIDLabel.Text = "Ebay ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(22, 81)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 107)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(225, 55)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(38, 13)
        NotesLabel.TabIndex = 7
        NotesLabel.Text = "Notes:"
        '
        'PostageCostLabel
        '
        PostageCostLabel.AutoSize = True
        PostageCostLabel.Location = New System.Drawing.Point(447, 215)
        PostageCostLabel.Name = "PostageCostLabel"
        PostageCostLabel.Size = New System.Drawing.Size(110, 13)
        PostageCostLabel.TabIndex = 14
        PostageCostLabel.Text = "Enter Postage Cost: £"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mark As Complete"
        '
        'EbayIDTextBox
        '
        Me.EbayIDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EbayIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "EbayID", True))
        Me.EbayIDTextBox.Location = New System.Drawing.Point(66, 52)
        Me.EbayIDTextBox.Name = "EbayIDTextBox"
        Me.EbayIDTextBox.ReadOnly = True
        Me.EbayIDTextBox.Size = New System.Drawing.Size(153, 20)
        Me.EbayIDTextBox.TabIndex = 5
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.BraceletsDataSet
        '
        'BraceletsDataSet
        '
        Me.BraceletsDataSet.DataSetName = "BraceletsDataSet"
        Me.BraceletsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(66, 78)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(153, 20)
        Me.NameTextBox.TabIndex = 6
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(66, 104)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.Size = New System.Drawing.Size(153, 122)
        Me.AddressTextBox.TabIndex = 7
        '
        'NotesTextBox
        '
        Me.NotesTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(269, 52)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.ReadOnly = True
        Me.NotesTextBox.Size = New System.Drawing.Size(175, 174)
        Me.NotesTextBox.TabIndex = 8
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(428, 268)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(117, 39)
        Me.btnDone.TabIndex = 13
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'BraceletDataGridView
        '
        Me.BraceletDataGridView.AllowUserToAddRows = False
        Me.BraceletDataGridView.AllowUserToDeleteRows = False
        Me.BraceletDataGridView.AutoGenerateColumns = False
        Me.BraceletDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BraceletDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8})
        Me.BraceletDataGridView.DataSource = Me.BraceletBindingSource
        Me.BraceletDataGridView.Location = New System.Drawing.Point(450, 52)
        Me.BraceletDataGridView.Name = "BraceletDataGridView"
        Me.BraceletDataGridView.ReadOnly = True
        Me.BraceletDataGridView.Size = New System.Drawing.Size(444, 152)
        Me.BraceletDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NameOnBracelet"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NameOnBracelet"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Colour"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Colour"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Size"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PostageCost"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PostageCost"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'BraceletBindingSource
        '
        Me.BraceletBindingSource.DataMember = "Bracelet"
        Me.BraceletBindingSource.DataSource = Me.BraceletsDataSet
        '
        'btnShipped
        '
        Me.btnShipped.Location = New System.Drawing.Point(744, 210)
        Me.btnShipped.Name = "btnShipped"
        Me.btnShipped.Size = New System.Drawing.Size(150, 23)
        Me.btnShipped.TabIndex = 14
        Me.btnShipped.Text = "Mark orders as shipped"
        Me.btnShipped.UseVisualStyleBackColor = True
        '
        'PostageCostTextBox
        '
        Me.PostageCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BraceletBindingSource, "PostageCost", True))
        Me.PostageCostTextBox.Location = New System.Drawing.Point(557, 210)
        Me.PostageCostTextBox.Name = "PostageCostTextBox"
        Me.PostageCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PostageCostTextBox.TabIndex = 15
        '
        'OrderIDTextBox
        '
        Me.OrderIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "OrderID", True))
        Me.OrderIDTextBox.Location = New System.Drawing.Point(66, 52)
        Me.OrderIDTextBox.Name = "OrderIDTextBox"
        Me.OrderIDTextBox.ReadOnly = True
        Me.OrderIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OrderIDTextBox.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(663, 210)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CompletedTextBox
        '
        Me.CompletedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Completed", True))
        Me.CompletedTextBox.Location = New System.Drawing.Point(119, 52)
        Me.CompletedTextBox.Name = "CompletedTextBox"
        Me.CompletedTextBox.ReadOnly = True
        Me.CompletedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CompletedTextBox.TabIndex = 18
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
        'CompleteOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(922, 319)
        Me.Controls.Add(Me.EbayIDTextBox)
        Me.Controls.Add(Me.CompletedTextBox)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(PostageCostLabel)
        Me.Controls.Add(Me.PostageCostTextBox)
        Me.Controls.Add(Me.btnShipped)
        Me.Controls.Add(Me.BraceletDataGridView)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(EbayIDLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OrderIDTextBox)
        Me.Name = "CompleteOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mark As Complete"
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BraceletsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BraceletDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BraceletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BraceletsDataSet As WindowsApplication1.BraceletsDataSet
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTableAdapter As WindowsApplication1.BraceletsDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.BraceletsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EbayIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents BraceletBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BraceletTableAdapter As WindowsApplication1.BraceletsDataSetTableAdapters.BraceletTableAdapter
    Friend WithEvents BraceletDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnShipped As System.Windows.Forms.Button
    Friend WithEvents PostageCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrderIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CompletedTextBox As System.Windows.Forms.TextBox
End Class
