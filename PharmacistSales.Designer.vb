<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PharmacistSales
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PharmacistSales))
        Me.BillView = New System.Windows.Forms.DataGridView()
        Me.ItemColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AmountColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResetBillButtton = New System.Windows.Forms.Button()
        Me.TotalAmountLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckoutButton = New System.Windows.Forms.Button()
        Me.AddToBillButton = New System.Windows.Forms.Button()
        Me.QuantityInput = New System.Windows.Forms.NumericUpDown()
        Me.MedicineSelector = New System.Windows.Forms.ComboBox()
        Me.UserModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.BillView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.QuantityInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BillView
        '
        Me.BillView.AllowUserToAddRows = False
        Me.BillView.AllowUserToDeleteRows = False
        Me.BillView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.BillView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemColumn, Me.PriceColumn, Me.QuantityColumn, Me.AmountColumn})
        Me.BillView.Location = New System.Drawing.Point(367, 78)
        Me.BillView.Name = "BillView"
        Me.BillView.ReadOnly = True
        Me.BillView.RowTemplate.Height = 25
        Me.BillView.Size = New System.Drawing.Size(405, 345)
        Me.BillView.TabIndex = 6
        '
        'ItemColumn
        '
        Me.ItemColumn.HeaderText = "Item"
        Me.ItemColumn.Name = "ItemColumn"
        Me.ItemColumn.ReadOnly = True
        '
        'PriceColumn
        '
        Me.PriceColumn.HeaderText = "Price"
        Me.PriceColumn.Name = "PriceColumn"
        Me.PriceColumn.ReadOnly = True
        '
        'QuantityColumn
        '
        Me.QuantityColumn.HeaderText = "Quantity"
        Me.QuantityColumn.Name = "QuantityColumn"
        Me.QuantityColumn.ReadOnly = True
        Me.QuantityColumn.Width = 60
        '
        'AmountColumn
        '
        Me.AmountColumn.HeaderText = "Amount (Rs.)"
        Me.AmountColumn.Name = "AmountColumn"
        Me.AmountColumn.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ResetBillButtton)
        Me.Panel1.Controls.Add(Me.TotalAmountLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BillView)
        Me.Panel1.Controls.Add(Me.CheckoutButton)
        Me.Panel1.Controls.Add(Me.AddToBillButton)
        Me.Panel1.Controls.Add(Me.QuantityInput)
        Me.Panel1.Controls.Add(Me.MedicineSelector)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(16, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Go Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(97, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Sales - Pharmacist Panel"
        '
        'ResetBillButtton
        '
        Me.ResetBillButtton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ResetBillButtton.Location = New System.Drawing.Point(206, 190)
        Me.ResetBillButtton.Name = "ResetBillButtton"
        Me.ResetBillButtton.Size = New System.Drawing.Size(125, 28)
        Me.ResetBillButtton.TabIndex = 9
        Me.ResetBillButtton.Text = "Reset Bill"
        Me.ResetBillButtton.UseVisualStyleBackColor = True
        '
        'TotalAmountLabel
        '
        Me.TotalAmountLabel.AutoSize = True
        Me.TotalAmountLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TotalAmountLabel.Location = New System.Drawing.Point(195, 269)
        Me.TotalAmountLabel.Name = "TotalAmountLabel"
        Me.TotalAmountLabel.Size = New System.Drawing.Size(19, 21)
        Me.TotalAmountLabel.TabIndex = 8
        Me.TotalAmountLabel.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(97, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total (Rs.)  :"
        '
        'CheckoutButton
        '
        Me.CheckoutButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckoutButton.ForeColor = System.Drawing.Color.Green
        Me.CheckoutButton.Location = New System.Drawing.Point(140, 328)
        Me.CheckoutButton.Name = "CheckoutButton"
        Me.CheckoutButton.Size = New System.Drawing.Size(91, 37)
        Me.CheckoutButton.TabIndex = 5
        Me.CheckoutButton.Text = "Checkout"
        Me.CheckoutButton.UseVisualStyleBackColor = True
        '
        'AddToBillButton
        '
        Me.AddToBillButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddToBillButton.Location = New System.Drawing.Point(206, 147)
        Me.AddToBillButton.Name = "AddToBillButton"
        Me.AddToBillButton.Size = New System.Drawing.Size(125, 26)
        Me.AddToBillButton.TabIndex = 4
        Me.AddToBillButton.Text = "Add to Bill"
        Me.AddToBillButton.UseVisualStyleBackColor = True
        '
        'QuantityInput
        '
        Me.QuantityInput.Location = New System.Drawing.Point(29, 147)
        Me.QuantityInput.Name = "QuantityInput"
        Me.QuantityInput.Size = New System.Drawing.Size(159, 23)
        Me.QuantityInput.TabIndex = 3
        Me.QuantityInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MedicineSelector
        '
        Me.MedicineSelector.FormattingEnabled = True
        Me.MedicineSelector.Location = New System.Drawing.Point(29, 96)
        Me.MedicineSelector.Name = "MedicineSelector"
        Me.MedicineSelector.Size = New System.Drawing.Size(302, 23)
        Me.MedicineSelector.TabIndex = 2
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PharmacistSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PharmacistSales"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.BillView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.QuantityInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BillView As DataGridView
    Friend WithEvents ItemColumn As DataGridViewButtonColumn
    Friend WithEvents PriceColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityColumn As DataGridViewButtonColumn
    Friend WithEvents AmountColumn As DataGridViewButtonColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ResetBillButtton As Button
    Friend WithEvents TotalAmountLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckoutButton As Button
    Friend WithEvents AddToBillButton As Button
    Friend WithEvents QuantityInput As NumericUpDown
    Friend WithEvents MedicineSelector As ComboBox
    Friend WithEvents UserModelBindingSource As BindingSource
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
