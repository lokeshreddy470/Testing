<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ScoreTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ScoreTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.ScoreTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.TextFileButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AverageLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ScoreTextBox1
        '
        Me.ScoreTextBox1.Location = New System.Drawing.Point(140, 43)
        Me.ScoreTextBox1.Name = "ScoreTextBox1"
        Me.ScoreTextBox1.Size = New System.Drawing.Size(100, 28)
        Me.ScoreTextBox1.TabIndex = 0
        Me.ScoreTextBox1.Text = ""
        '
        'ScoreTextBox3
        '
        Me.ScoreTextBox3.Location = New System.Drawing.Point(140, 160)
        Me.ScoreTextBox3.Name = "ScoreTextBox3"
        Me.ScoreTextBox3.Size = New System.Drawing.Size(100, 30)
        Me.ScoreTextBox3.TabIndex = 2
        Me.ScoreTextBox3.Text = ""
        '
        'ScoreTextBox2
        '
        Me.ScoreTextBox2.Location = New System.Drawing.Point(140, 90)
        Me.ScoreTextBox2.Name = "ScoreTextBox2"
        Me.ScoreTextBox2.Size = New System.Drawing.Size(100, 33)
        Me.ScoreTextBox2.TabIndex = 1
        Me.ScoreTextBox2.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TestScore1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "TestScore2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TestScore3"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(140, 262)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(331, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Average Score"
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(48, 332)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(88, 38)
        Me.CalcButton.TabIndex = 4
        Me.CalcButton.Text = "Cal&culate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'TextFileButton
        '
        Me.TextFileButton.Location = New System.Drawing.Point(230, 338)
        Me.TextFileButton.Name = "TextFileButton"
        Me.TextFileButton.Size = New System.Drawing.Size(88, 32)
        Me.TextFileButton.TabIndex = 10
        Me.TextFileButton.Text = "&Text File"
        Me.TextFileButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(430, 339)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(79, 32)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AverageLabel
        '
        Me.AverageLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AverageLabel.Location = New System.Drawing.Point(446, 61)
        Me.AverageLabel.Name = "AverageLabel"
        Me.AverageLabel.Size = New System.Drawing.Size(91, 30)
        Me.AverageLabel.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(137, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Preset Value"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 395)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AverageLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TextFileButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ScoreTextBox2)
        Me.Controls.Add(Me.ScoreTextBox3)
        Me.Controls.Add(Me.ScoreTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ScoreTextBox1 As RichTextBox
    Friend WithEvents ScoreTextBox3 As RichTextBox
    Friend WithEvents ScoreTextBox2 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CalcButton As Button
    Friend WithEvents TextFileButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents AverageLabel As Label
    Friend WithEvents Label5 As Label
End Class
