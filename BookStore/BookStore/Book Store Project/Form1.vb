'NAME:Lokeswara reddy goluguri
'Project:Book Shop Solution
'Date: 5/13/2016

Public Class Form1
    'Declaring Varibles
    Public text1 As String
    Dim selected As String
    'Text File
    Dim value As String = "Values.txt"
    Dim infile As IO.StreamReader
    Dim value1 As String
    Dim price1 As Integer
    Dim entered As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reading Text file from Text File
        If IO.File.Exists(value) Then
            infile = IO.File.OpenText(value)
            Do Until infile.Peek = -1
                text1 = infile.ReadLine.ToString().Split(":")(0)
                ItemsListBox.Items.Add(text1)
            Loop
            infile.Close()
        Else
            MsgBox("Text file not found ")
        End If
    End Sub
    Private Sub EnterPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterPasswordToolStripMenuItem.Click
        'Password Combination
        Dim password As String
        password = InputBox("Enter the password")
        If password = "" Then
            searchButton.Enabled = False
            CheckoutButton.Enabled = False
            CartButton.Enabled = False
        ElseIf password.Length <> 6 Then
            searchButton.Enabled = False
            CheckoutButton.Enabled = False
            CartButton.Enabled = False
        Else
            value1 = password.ToString()
        End If

        If value1.ToUpper() Like "[a-dA-D][0-9][0-9][m-tM-T][0-9][a-zA-Z]" Then
            searchButton.Enabled = True
            CheckoutButton.Enabled = True
            CartButton.Enabled = True
        Else
            MsgBox("Please enter a valid password")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'For Closing a appliaction
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        'Getting input from Text box
        entered = SearchTextBox.Text.ToLower()
        'Decelarting variables
        Dim i As Integer
        Dim j As Integer
        Dim array(,) As String = {{"pens", "4"}, {"pencils", "2"}, {"note books", "9"}, {"eraser", "2"},
                                  {"stickers", "1"}, {"novels", "10"}, {"story books", "25"}, {"kids books", "5"}}
        'For Loop Condition
        For i = 0 To 7
            For j = 0 To 1
                If entered = array(i, j) Then
                    price1 = array(i, (j + 1))
                    Exit For
                End If
            Next
        Next
        'Displaying output
        PriceLabel.Text = price1.ToString("C2")
    End Sub
    Private Sub CartButton_Click(sender As Object, e As EventArgs) Handles CartButton.Click
        Dim textfile As String = "Lists.txt"
        Dim outfile As IO.StreamWriter

        selected = ItemsListBox.SelectedItem
        CheckOutListBox.Items.Add(selected)
        'For Writing data to text file
        If IO.File.Exists(textfile) Then

            outfile = IO.File.AppendText(textfile)
            outfile.WriteLine(selected)
            outfile.Close()
        End If

    End Sub
    Public Function GettingValue(Item As String) As Int64
        Dim arr As New ArrayList()
        Dim Value As Int64
        Dim getitemvalues As GettingValues = New GettingValues()
        arr = getitemvalues.GetValue
        For i = 0 To arr.Count - 1
            If (arr(i).ToString().ToLower().Contains(Item.ToLower())) Then
                'Condition to print only value
                Value = arr(i).ToString().Split(":")(1).Split("$")(0)
                Return Value
            Else
                Value = 0
            End If
        Next
        Return Value
    End Function
    Private Sub CheckoutButton_Click(sender As Object, e As EventArgs) Handles CheckoutButton.Click
        Dim Value As Int64
        Value = 0
        'looping condition
        For i = 0 To CheckOutListBox.Items.Count - 1
            Value += GettingValue(CheckOutListBox.Items(i))
        Next

        If (Value <> 0) Then
            PriceLabel.Text = ""
            TotalLabel.Text = Value.ToString() + "$"
        Else
            TotalLabel.Text = ""
            MessageBox.Show("add some items to Cart")
        End If
    End Sub
End Class
