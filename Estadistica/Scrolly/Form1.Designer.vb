<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scrolly
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
        Me.Importar = New System.Windows.Forms.Button()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.Llenar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Importar
        '
        Me.Importar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Importar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Importar.Location = New System.Drawing.Point(303, 18)
        Me.Importar.Name = "Importar"
        Me.Importar.Size = New System.Drawing.Size(75, 40)
        Me.Importar.TabIndex = 0
        Me.Importar.Text = "&Importar"
        Me.Importar.UseVisualStyleBackColor = True
        '
        'dg1
        '
        Me.dg1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(8, 69)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(703, 294)
        Me.dg1.TabIndex = 1
        '
        'Llenar
        '
        Me.Llenar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Llenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llenar.Location = New System.Drawing.Point(384, 18)
        Me.Llenar.Name = "Llenar"
        Me.Llenar.Size = New System.Drawing.Size(123, 40)
        Me.Llenar.TabIndex = 6
        Me.Llenar.Text = "Calcular"
        Me.Llenar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(216, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(25, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "año"
        '
        'Scrolly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(723, 395)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Llenar)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Importar)
        Me.Name = "Scrolly"
        Me.Text = "Scrolly - A great simulator"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Importar As System.Windows.Forms.Button
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents Llenar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label

End Class
