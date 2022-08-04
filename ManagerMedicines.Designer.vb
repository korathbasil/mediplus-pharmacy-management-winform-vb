<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerMedicines
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MedicineDetailsListView = New System.Windows.Forms.ListView()
        Me.IdColumn = New System.Windows.Forms.ColumnHeader()
        Me.NameColumn = New System.Windows.Forms.ColumnHeader()
        Me.FormulaColumn = New System.Windows.Forms.ColumnHeader()
        Me.CompanyColumn = New System.Windows.Forms.ColumnHeader()
        Me.PriceColumn = New System.Windows.Forms.ColumnHeader()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.MedicineDetailsListView)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 450)
        Me.Panel2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(13, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Go Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MedicineDetailsListView
        '
        Me.MedicineDetailsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdColumn, Me.NameColumn, Me.FormulaColumn, Me.CompanyColumn, Me.PriceColumn})
        Me.MedicineDetailsListView.Location = New System.Drawing.Point(11, 52)
        Me.MedicineDetailsListView.Name = "MedicineDetailsListView"
        Me.MedicineDetailsListView.Size = New System.Drawing.Size(776, 388)
        Me.MedicineDetailsListView.TabIndex = 5
        Me.MedicineDetailsListView.UseCompatibleStateImageBehavior = False
        Me.MedicineDetailsListView.View = System.Windows.Forms.View.Details
        '
        'IdColumn
        '
        Me.IdColumn.Text = "Id"
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 200
        '
        'FormulaColumn
        '
        Me.FormulaColumn.Text = "Formula"
        Me.FormulaColumn.Width = 100
        '
        'CompanyColumn
        '
        Me.CompanyColumn.Text = "Company"
        Me.CompanyColumn.Width = 150
        '
        'PriceColumn
        '
        Me.PriceColumn.Text = "Price"
        Me.PriceColumn.Width = 62
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(667, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add Medicine"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(94, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Management Panel - Medicines"
        '
        'ManagerMedicines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ManagerMedicines"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents MedicineDetailsListView As ListView
    Friend WithEvents IdColumn As ColumnHeader
    Friend WithEvents NameColumn As ColumnHeader
    Friend WithEvents FormulaColumn As ColumnHeader
    Friend WithEvents CompanyColumn As ColumnHeader
    Friend WithEvents PriceColumn As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
