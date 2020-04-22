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
        Me.descargar = New System.Windows.Forms.Button()
        Me.read = New System.Windows.Forms.Button()
        Me.Listbox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'descargar
        '
        Me.descargar.Location = New System.Drawing.Point(69, 12)
        Me.descargar.Name = "descargar"
        Me.descargar.Size = New System.Drawing.Size(75, 23)
        Me.descargar.TabIndex = 0
        Me.descargar.Text = "Descargar"
        Me.descargar.UseVisualStyleBackColor = True
        '
        'read
        '
        Me.read.Location = New System.Drawing.Point(171, 12)
        Me.read.Name = "read"
        Me.read.Size = New System.Drawing.Size(75, 23)
        Me.read.TabIndex = 2
        Me.read.Text = "Leer"
        Me.read.UseVisualStyleBackColor = True
        '
        'Listbox
        '
        Me.Listbox.FormattingEnabled = True
        Me.Listbox.Location = New System.Drawing.Point(12, 55)
        Me.Listbox.Name = "Listbox"
        Me.Listbox.Size = New System.Drawing.Size(132, 277)
        Me.Listbox.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 346)
        Me.Controls.Add(Me.Listbox)
        Me.Controls.Add(Me.read)
        Me.Controls.Add(Me.descargar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents descargar As System.Windows.Forms.Button
    Friend WithEvents read As System.Windows.Forms.Button
    Friend WithEvents Listbox As System.Windows.Forms.ListBox

End Class
