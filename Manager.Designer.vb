<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ManagerBodyPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'ManagerBodyPanel
        '
        Me.ManagerBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagerBodyPanel.Location = New System.Drawing.Point(0, 0)
        Me.ManagerBodyPanel.Name = "ManagerBodyPanel"
        Me.ManagerBodyPanel.Size = New System.Drawing.Size(800, 450)
        Me.ManagerBodyPanel.TabIndex = 0
        '
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ManagerBodyPanel)
        Me.Name = "Manager"
        Me.Text = "Manager"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManagerBodyPanel As Panel
End Class
