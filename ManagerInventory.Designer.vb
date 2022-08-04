<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerInventory
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MedicineInventoryList = New System.Windows.Forms.ListView()
        Me.IdColumn = New System.Windows.Forms.ColumnHeader()
        Me.NameColumn = New System.Windows.Forms.ColumnHeader()
        Me.StockColumn = New System.Windows.Forms.ColumnHeader()
        Me.AddStockButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.MedicineInventoryList)
        Me.Panel1.Controls.Add(Me.AddStockButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(111, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Management Panel - Inventory"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(14, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Go Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MedicineInventoryList
        '
        Me.MedicineInventoryList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdColumn, Me.NameColumn, Me.StockColumn})
        Me.MedicineInventoryList.Location = New System.Drawing.Point(14, 54)
        Me.MedicineInventoryList.Name = "MedicineInventoryList"
        Me.MedicineInventoryList.Size = New System.Drawing.Size(773, 386)
        Me.MedicineInventoryList.TabIndex = 4
        Me.MedicineInventoryList.UseCompatibleStateImageBehavior = False
        Me.MedicineInventoryList.View = System.Windows.Forms.View.Details
        '
        'IdColumn
        '
        Me.IdColumn.Text = "Id"
        '
        'NameColumn
        '
        Me.NameColumn.Text = "name"
        Me.NameColumn.Width = 400
        '
        'StockColumn
        '
        Me.StockColumn.Text = "Stock"
        Me.StockColumn.Width = 116
        '
        'AddStockButton
        '
        Me.AddStockButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddStockButton.Location = New System.Drawing.Point(646, 11)
        Me.AddStockButton.Name = "AddStockButton"
        Me.AddStockButton.Size = New System.Drawing.Size(141, 30)
        Me.AddStockButton.TabIndex = 5
        Me.AddStockButton.Text = "Add Inventory"
        Me.AddStockButton.UseVisualStyleBackColor = True
        '
        'ManagerInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ManagerInventory"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MedicineInventoryList As ListView
    Friend WithEvents IdColumn As ColumnHeader
    Friend WithEvents NameColumn As ColumnHeader
    Friend WithEvents StockColumn As ColumnHeader
    Friend WithEvents AddStockButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
