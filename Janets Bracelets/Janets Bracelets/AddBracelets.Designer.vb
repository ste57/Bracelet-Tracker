<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBracelets
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim DoPLabel As System.Windows.Forms.Label
        Dim NameOnBraceletLabel As System.Windows.Forms.Label
        Dim ColourLabel1 As System.Windows.Forms.Label
        Dim SizeLabel1 As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.BraceletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BraceletsDataSet = New WindowsApplication1.BraceletsDataSet()
        Me.NameOnBraceletTextBox = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BraceletTableAdapter = New WindowsApplication1.BraceletsDataSetTableAdapters.BraceletTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.BraceletsDataSetTableAdapters.TableAdapterManager()
        Me.eBaylbl = New System.Windows.Forms.TextBox()
        Me.ColourTextBox = New System.Windows.Forms.TextBox()
        Me.SizeTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.DoPTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CustomerIDLabel = New System.Windows.Forms.Label()
        DoPLabel = New System.Windows.Forms.Label()
        NameOnBraceletLabel = New System.Windows.Forms.Label()
        ColourLabel1 = New System.Windows.Forms.Label()
        SizeLabel1 = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        CType(Me.BraceletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BraceletsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(43, 60)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(68, 13)
        CustomerIDLabel.TabIndex = 5
        CustomerIDLabel.Text = "Customer ID:"
        '
        'DoPLabel
        '
        DoPLabel.AutoSize = True
        DoPLabel.Location = New System.Drawing.Point(18, 89)
        DoPLabel.Name = "DoPLabel"
        DoPLabel.Size = New System.Drawing.Size(93, 13)
        DoPLabel.TabIndex = 7
        DoPLabel.Text = "Date of Purchase:"
        '
        'NameOnBraceletLabel
        '
        NameOnBraceletLabel.AutoSize = True
        NameOnBraceletLabel.Location = New System.Drawing.Point(14, 166)
        NameOnBraceletLabel.Name = "NameOnBraceletLabel"
        NameOnBraceletLabel.Size = New System.Drawing.Size(97, 13)
        NameOnBraceletLabel.TabIndex = 13
        NameOnBraceletLabel.Text = "Name On Bracelet:"
        '
        'ColourLabel1
        '
        ColourLabel1.AutoSize = True
        ColourLabel1.Location = New System.Drawing.Point(71, 112)
        ColourLabel1.Name = "ColourLabel1"
        ColourLabel1.Size = New System.Drawing.Size(40, 13)
        ColourLabel1.TabIndex = 19
        ColourLabel1.Text = "Colour:"
        '
        'SizeLabel1
        '
        SizeLabel1.AutoSize = True
        SizeLabel1.Location = New System.Drawing.Point(81, 138)
        SizeLabel1.Name = "SizeLabel1"
        SizeLabel1.Size = New System.Drawing.Size(30, 13)
        SizeLabel1.TabIndex = 20
        SizeLabel1.Text = "Size:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(32, 192)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(79, 13)
        CostLabel.TabIndex = 21
        CostLabel.Text = "Amount Paid: £"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add Bracelets For Customer"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BraceletBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Enabled = False
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(117, 57)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(65, 20)
        Me.CustomerIDTextBox.TabIndex = 6
        Me.CustomerIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'NameOnBraceletTextBox
        '
        Me.NameOnBraceletTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BraceletBindingSource, "NameOnBracelet", True))
        Me.NameOnBraceletTextBox.Location = New System.Drawing.Point(117, 163)
        Me.NameOnBraceletTextBox.Name = "NameOnBraceletTextBox"
        Me.NameOnBraceletTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameOnBraceletTextBox.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 239)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 32)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add Another"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(117, 239)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(96, 32)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(219, 239)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 32)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BraceletTableAdapter
        '
        Me.BraceletTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BraceletTableAdapter = Me.BraceletTableAdapter
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.BraceletsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'eBaylbl
        '
        Me.eBaylbl.Enabled = False
        Me.eBaylbl.Location = New System.Drawing.Point(188, 57)
        Me.eBaylbl.Name = "eBaylbl"
        Me.eBaylbl.Size = New System.Drawing.Size(129, 20)
        Me.eBaylbl.TabIndex = 19
        Me.eBaylbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColourTextBox
        '
        Me.ColourTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BraceletBindingSource, "Colour", True))
        Me.ColourTextBox.Location = New System.Drawing.Point(117, 109)
        Me.ColourTextBox.Name = "ColourTextBox"
        Me.ColourTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ColourTextBox.TabIndex = 2
        '
        'SizeTextBox
        '
        Me.SizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BraceletBindingSource, "Size", True))
        Me.SizeTextBox.Location = New System.Drawing.Point(117, 135)
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SizeTextBox.TabIndex = 3
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BraceletBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(117, 189)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CostTextBox.TabIndex = 5
        '
        'DoPTextBox
        '
        Me.DoPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BraceletBindingSource, "DoP", True))
        Me.DoPTextBox.Location = New System.Drawing.Point(117, 83)
        Me.DoPTextBox.Name = "DoPTextBox"
        Me.DoPTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DoPTextBox.TabIndex = 25
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(117, 82)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AddBracelets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(339, 283)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DoPTextBox)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(SizeLabel1)
        Me.Controls.Add(Me.SizeTextBox)
        Me.Controls.Add(ColourLabel1)
        Me.Controls.Add(Me.ColourTextBox)
        Me.Controls.Add(Me.eBaylbl)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(DoPLabel)
        Me.Controls.Add(NameOnBraceletLabel)
        Me.Controls.Add(Me.NameOnBraceletTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "AddBracelets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bracelets"
        CType(Me.BraceletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BraceletsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BraceletsDataSet As WindowsApplication1.BraceletsDataSet
    Friend WithEvents BraceletBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BraceletTableAdapter As WindowsApplication1.BraceletsDataSetTableAdapters.BraceletTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.BraceletsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameOnBraceletTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents eBaylbl As System.Windows.Forms.TextBox
    Friend WithEvents ColourTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DoPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
