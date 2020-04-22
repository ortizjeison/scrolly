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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scrolly))
        Me.Importar = New System.Windows.Forms.Button()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.Descargar = New System.Windows.Forms.Button()
        Me.ComboEtapa = New System.Windows.Forms.ComboBox()
        Me.Llenar = New System.Windows.Forms.Button()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        Me.Simular = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Importar
        '
        Me.Importar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Importar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Importar.Location = New System.Drawing.Point(263, 93)
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
        Me.dg1.Location = New System.Drawing.Point(62, 139)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(559, 251)
        Me.dg1.TabIndex = 1
        '
        'Descargar
        '
        Me.Descargar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Descargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descargar.Location = New System.Drawing.Point(180, 93)
        Me.Descargar.Name = "Descargar"
        Me.Descargar.Size = New System.Drawing.Size(79, 40)
        Me.Descargar.TabIndex = 2
        Me.Descargar.Text = "&Descargar"
        Me.Descargar.UseVisualStyleBackColor = True
        '
        'ComboEtapa
        '
        Me.ComboEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboEtapa.FormattingEnabled = True
        Me.ComboEtapa.Items.AddRange(New Object() {"Etapa 1", "Etapa 2", "Etapa 3", "Etapa 4", "Etapa 5", "Etapa 6", "Etapa 7", "Etapa 8", "Etapa 9", "Etapa 10", "Etapa 11", "Etapa 12", "Etapa 13", "Etapa 14"})
        Me.ComboEtapa.Location = New System.Drawing.Point(62, 99)
        Me.ComboEtapa.Name = "ComboEtapa"
        Me.ComboEtapa.Size = New System.Drawing.Size(112, 33)
        Me.ComboEtapa.TabIndex = 5
        '
        'Llenar
        '
        Me.Llenar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Llenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llenar.Location = New System.Drawing.Point(342, 93)
        Me.Llenar.Name = "Llenar"
        Me.Llenar.Size = New System.Drawing.Size(58, 40)
        Me.Llenar.TabIndex = 6
        Me.Llenar.Text = "&Leer"
        Me.Llenar.UseVisualStyleBackColor = True
        '
        'dg2
        '
        Me.dg2.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg2.Location = New System.Drawing.Point(12, 418)
        Me.dg2.Name = "dg2"
        Me.dg2.Size = New System.Drawing.Size(660, 251)
        Me.dg2.TabIndex = 7
        '
        'Simular
        '
        Me.Simular.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Simular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Simular.Location = New System.Drawing.Point(405, 93)
        Me.Simular.Name = "Simular"
        Me.Simular.Size = New System.Drawing.Size(65, 40)
        Me.Simular.TabIndex = 8
        Me.Simular.Text = "&Simular"
        Me.Simular.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(476, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "I&mprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(544, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "S&alir / Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Etapa Actual"
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(180, 2)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(338, 90)
        Me.Logo.TabIndex = 12
        Me.Logo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 393)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 26)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Resultados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(317, 674)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "getscrolly.cf"
        '
        'Scrolly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(685, 692)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Simular)
        Me.Controls.Add(Me.dg2)
        Me.Controls.Add(Me.Llenar)
        Me.Controls.Add(Me.ComboEtapa)
        Me.Controls.Add(Me.Descargar)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Importar)
        Me.Name = "Scrolly"
        Me.Text = "Scrolly - A great simulator"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Importar As System.Windows.Forms.Button
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents Descargar As System.Windows.Forms.Button
    Friend WithEvents ComboEtapa As System.Windows.Forms.ComboBox
    Friend WithEvents Llenar As System.Windows.Forms.Button
    Friend WithEvents dg2 As System.Windows.Forms.DataGridView
    Friend WithEvents Simular As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
