<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerAddMedicine
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
        Me.PriceInput = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CompanyInput = New System.Windows.Forms.TextBox()
        Me.FormulaInput = New System.Windows.Forms.TextBox()
        Me.NameInput = New System.Windows.Forms.TextBox()
        Me.AddMedicineButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PriceInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PriceInput)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CompanyInput)
        Me.Panel1.Controls.Add(Me.FormulaInput)
        Me.Panel1.Controls.Add(Me.NameInput)
        Me.Panel1.Controls.Add(Me.AddMedicineButton)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'PriceInput
        '
        Me.PriceInput.Location = New System.Drawing.Point(324, 250)
        Me.PriceInput.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.PriceInput.Name = "PriceInput"
        Me.PriceInput.Size = New System.Drawing.Size(230, 23)
        Me.PriceInput.TabIndex = 23
        Me.PriceInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(231, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Price"
        '
        'CompanyInput
        '
        Me.CompanyInput.Location = New System.Drawing.Point(324, 198)
        Me.CompanyInput.Name = "CompanyInput"
        Me.CompanyInput.Size = New System.Drawing.Size(230, 23)
        Me.CompanyInput.TabIndex = 21
        '
        'FormulaInput
        '
        Me.FormulaInput.Location = New System.Drawing.Point(324, 150)
        Me.FormulaInput.Name = "FormulaInput"
        Me.FormulaInput.Size = New System.Drawing.Size(230, 23)
        Me.FormulaInput.TabIndex = 20
        '
        'NameInput
        '
        Me.NameInput.Location = New System.Drawing.Point(324, 100)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(230, 23)
        Me.NameInput.TabIndex = 19
        '
        'AddMedicineButton
        '
        Me.AddMedicineButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddMedicineButton.Location = New System.Drawing.Point(416, 304)
        Me.AddMedicineButton.Name = "AddMedicineButton"
        Me.AddMedicineButton.Size = New System.Drawing.Size(138, 35)
        Me.AddMedicineButton.TabIndex = 18
        Me.AddMedicineButton.Text = "Add Mdicine"
        Me.AddMedicineButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(231, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Company"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(231, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Formula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(231, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(114, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Management Panel - Add Medicine"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(17, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Go Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ManagerAddMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ManagerAddMedicine"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PriceInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PriceInput As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents CompanyInput As TextBox
    Friend WithEvents FormulaInput As TextBox
    Friend WithEvents NameInput As TextBox
    Friend WithEvents AddMedicineButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
