﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.AppBodyPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'AppBodyPanel
        '
        Me.AppBodyPanel.BackColor = System.Drawing.SystemColors.Control
        Me.AppBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppBodyPanel.Location = New System.Drawing.Point(0, 0)
        Me.AppBodyPanel.Name = "AppBodyPanel"
        Me.AppBodyPanel.Size = New System.Drawing.Size(800, 450)
        Me.AppBodyPanel.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AppBodyPanel)
        Me.Name = "Form1"
        Me.Text = "Mediplus"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AppBodyPanel As Panel
End Class
