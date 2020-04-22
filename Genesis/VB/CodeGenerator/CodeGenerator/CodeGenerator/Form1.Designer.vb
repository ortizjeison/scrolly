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
        Me.D_Tiempo = New System.Windows.Forms.Button()
        Me.Print = New System.Windows.Forms.TextBox()
        Me.A_Tiempo = New System.Windows.Forms.Button()
        Me.D_Distancia = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'D_Tiempo
        '
        Me.D_Tiempo.Location = New System.Drawing.Point(12, 12)
        Me.D_Tiempo.Name = "D_Tiempo"
        Me.D_Tiempo.Size = New System.Drawing.Size(127, 23)
        Me.D_Tiempo.TabIndex = 0
        Me.D_Tiempo.Text = "Descargar Tiempo"
        Me.D_Tiempo.UseVisualStyleBackColor = True
        '
        'Print
        '
        Me.Print.Location = New System.Drawing.Point(12, 41)
        Me.Print.Multiline = True
        Me.Print.Name = "Print"
        Me.Print.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Print.Size = New System.Drawing.Size(813, 345)
        Me.Print.TabIndex = 1
        '
        'A_Tiempo
        '
        Me.A_Tiempo.Location = New System.Drawing.Point(158, 12)
        Me.A_Tiempo.Name = "A_Tiempo"
        Me.A_Tiempo.Size = New System.Drawing.Size(127, 23)
        Me.A_Tiempo.TabIndex = 2
        Me.A_Tiempo.Text = "Asignar Tiempo"
        Me.A_Tiempo.UseVisualStyleBackColor = True
        '
        'D_Distancia
        '
        Me.D_Distancia.Location = New System.Drawing.Point(309, 12)
        Me.D_Distancia.Name = "D_Distancia"
        Me.D_Distancia.Size = New System.Drawing.Size(127, 23)
        Me.D_Distancia.TabIndex = 3
        Me.D_Distancia.Text = "Descargar Distanacia"
        Me.D_Distancia.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 426)
        Me.Controls.Add(Me.D_Distancia)
        Me.Controls.Add(Me.A_Tiempo)
        Me.Controls.Add(Me.Print)
        Me.Controls.Add(Me.D_Tiempo)
        Me.Name = "Form1"
        Me.Text = "CodeGenerator - Scrolly"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents D_Tiempo As System.Windows.Forms.Button
    Friend WithEvents Print As System.Windows.Forms.TextBox
    Friend WithEvents A_Tiempo As System.Windows.Forms.Button
    Friend WithEvents D_Distancia As System.Windows.Forms.Button

End Class
