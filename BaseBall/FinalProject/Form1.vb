'Name:Virinche marwadi
'Project:Average Score calculation
Public Class Form1
    Dim average As Double
    Dim marks(2) As Double
    Dim preset As Integer
    Dim formclosing1 As DialogResult
    Dim scorefile As String = "Scoresfile.txt"
    Dim filewriter As IO.StreamWriter

    Private Sub ScoreTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ScoreTextBox1.KeyPress
        If (Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 56) AndAlso Asc(e.KeyChar) = 45 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ScoreTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ScoreTextBox2.KeyPress
        If (Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 56) AndAlso Asc(e.KeyChar) = 45 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ScoreTextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ScoreTextBox3.KeyPress
        If (Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 56) AndAlso Asc(e.KeyChar) = 457 Then
            e.Handled = True
        End If
    End Sub


    Public Class averagetotal
        Public Function averagesum(ByVal marks1 As Double, ByVal marks2 As Double, ByVal marks3 As Double)
            averagesum = (marks1 + marks2 + marks3) / 3
            Return averagesum
        End Function
    End Class
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim object1 As New averagetotal

        Double.TryParse(ScoreTextBox1.Text, marks(0))
        Double.TryParse(ScoreTextBox2.Text, marks(1))
        Double.TryParse(ScoreTextBox3.Text, marks(2))


        If marks(0) > 0 Or marks(0) <= 100 Then
            marks(0) = marks(0)
        Else

            MsgBox(" Enter value between 1 to 100")

        End If
        If marks(1) > 0 Or marks(1) <= 100 Then
            marks(0) = marks(0)
        Else
            MsgBox("Enter value between 1 to 100")

        End If
        If marks(2) > 0 Or marks(2) <= 100 Then
            marks(2) = marks(2)
        Else
            MsgBox("Enter value between 1 to 100")

        End If

        average = object1.averagesum(marks(0), marks(1), marks(2))
        AverageLabel.Text = average.ToString("N2")
        If average < 100 AndAlso average > 90 Then
            preset = 5
        End If
        If average < 90 AndAlso average > 80 Then
            preset = 4
        End If
        If average < 80 AndAlso average > 70 Then
            preset = 3
        End If
        If average < 70 AndAlso average > 60 Then
            preset = 2
        End If
        If average < 60 AndAlso average > 50 Then
            preset = 1
        End If
        ScoreTextBox1.Focus()
        ScoreTextBox1.SelectAll()
        ComboBox1.Text = preset



    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        formclosing1 = MessageBox.Show("Are you sure you want to close the application", "Closing",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If formclosing1 = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True

        End If
    End Sub

    Private Sub Score1TextBox_TextChanged(sender As Object, e As EventArgs) Handles ScoreTextBox1.TextChanged

        ScoreTextBox2.Text = String.Empty
        ScoreTextBox3.Text = String.Empty
        AverageLabel.Text = String.Empty
    End Sub

    Private Sub TextButton_Click(sender As Object, e As EventArgs) Handles TextFileButton.Click
        If IO.File.Exists(scorefile) Then
            filewriter = IO.File.AppendText(scorefile)

            filewriter.WriteLine("TestScore1" & marks(0))
            filewriter.WriteLine("TestScore2" & marks(1))
            filewriter.WriteLine("TestScore3" & marks(2))
            filewriter.WriteLine("Average Score" & average)
            filewriter.WriteLine(average)

            filewriter.Close()
            MsgBox("Your Scores into Text File")
        End If
    End Sub



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
