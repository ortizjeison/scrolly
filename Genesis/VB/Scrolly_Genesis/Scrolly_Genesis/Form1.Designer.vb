<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn2015 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Progress = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn2015
        '
        Me.btn2015.Location = New System.Drawing.Point(12, 12)
        Me.btn2015.Name = "btn2015"
        Me.btn2015.Size = New System.Drawing.Size(75, 23)
        Me.btn2015.TabIndex = 0
        Me.btn2015.Text = "Start"
        Me.btn2015.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(105, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Stop!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Progress
        '
        Me.Progress.FormattingEnabled = True
        Me.Progress.Location = New System.Drawing.Point(12, 41)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(168, 186)
        Me.Progress.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 238)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn2015)
        Me.Name = "Form1"
        Me.Text = "Scrolly Génesis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn2015 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Progress As System.Windows.Forms.ListBox

End Class
