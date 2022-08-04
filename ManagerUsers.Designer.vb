<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerUsers
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UsersListView = New System.Windows.Forms.ListView()
        Me.IdColumn = New System.Windows.Forms.ColumnHeader()
        Me.NameColumn = New System.Windows.Forms.ColumnHeader()
        Me.UsernameColumn = New System.Windows.Forms.ColumnHeader()
        Me.UserTypeColumn = New System.Windows.Forms.ColumnHeader()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.UsersListView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 450)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(111, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Management Panel - Users"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(667, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(13, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Go Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UsersListView
        '
        Me.UsersListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdColumn, Me.NameColumn, Me.UsernameColumn, Me.UserTypeColumn})
        Me.UsersListView.Location = New System.Drawing.Point(13, 56)
        Me.UsersListView.Name = "UsersListView"
        Me.UsersListView.Size = New System.Drawing.Size(774, 381)
        Me.UsersListView.TabIndex = 1
        Me.UsersListView.UseCompatibleStateImageBehavior = False
        Me.UsersListView.View = System.Windows.Forms.View.Details
        '
        'IdColumn
        '
        Me.IdColumn.Text = "Id"
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NameColumn.Width = 200
        '
        'UsernameColumn
        '
        Me.UsernameColumn.Text = "Username"
        Me.UsernameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UsernameColumn.Width = 180
        '
        'UserTypeColumn
        '
        Me.UserTypeColumn.Text = "User Type"
        Me.UserTypeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UserTypeColumn.Width = 140
        '
        'ManagerUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ManagerUsers"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UsersListView As ListView
    Friend WithEvents IdColumn As ColumnHeader
    Friend WithEvents NameColumn As ColumnHeader
    Friend WithEvents UsernameColumn As ColumnHeader
    Friend WithEvents UserTypeColumn As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
