'Name:Venkateswara rao kotta
'Project:Final Project
'Date:5/12/2016
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EnterPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterPasswordToolStripMenuItem.Click



        Dim prompt As String = String.Empty
        Dim title As String = String.Empty
        Dim defaultResponse As String = String.Empty
        Dim ValidPassword As Boolean = False
        Dim answer As Object
        ' Set prompt.
        prompt = "Please enter password"
        ' Set title.
        title = "Getting user input"
        ' Set default value.
        defaultResponse = ""

        ' Display prompt, title, and default value.
        answer = InputBox(prompt, title, defaultResponse)
        If (answer.ToString() = "") Then

            pnlCricket.Visible = False


        ElseIf (answer.ToString().Length <> 6) Then
            pnlCricket.Visible = False
            MessageBox.Show("password should contain 6 charecters")




        Else

            ValidPassword = IsAlphaNum(answer.ToString())

        End If
        If (ValidPassword) Then
            pnlCricket.Visible = True
        Else
            pnlCricket.Visible = False
            MessageBox.Show("Enter a valid password")




        End If

    End Sub

    Public Function IsAlphaNum(ByVal strInputText As String) As Boolean
        Dim IsAlpha As Boolean = False
        If System.Text.RegularExpressions.Regex.IsMatch(strInputText, "^[a-dA-D][0-9][0-9][m-tM-T]+[0-9][a-zA-Z]+$") Then
            IsAlpha = True
        Else
            IsAlpha = False
        End If
        Return IsAlpha
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()

    End Sub
    Public Function GetItemValue(Item As String) As Int64
        Dim arrLines As New ArrayList()
        Dim ItemValue As Int64

        Dim getitemvalues As GetItemValues = New GetItemValues()

        arrLines = getitemvalues.GetItemValue

        For i = 0 To arrLines.Count - 1
            If (arrLines(i).ToString().ToLower().Contains(Item.ToLower())) Then
                ItemValue = arrLines(i).ToString().Split("-")(1).Split("$")(0)

                Return ItemValue

            Else

                ItemValue = 0
            End If
        Next
        Return ItemValue
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim ItemValue As Int64
        If (txtSearchItem.Text <> "") Then
            ItemValue = GetItemValue(txtSearchItem.Text)
            If (ItemValue <> 0) Then
                txtPrice.Text = GetItemValue(txtSearchItem.Text).ToString() + "$"
            Else
                MessageBox.Show("Item UnAvailable")
                txtPrice.Text = ""
            End If


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cartbutton.Click
        For i = 0 To lbItems.SelectedItems.Count - 1

            lbCart.Items.Add(lbItems.SelectedItems(i))

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CheckOutButton.Click
        Dim ItemValue As Int64
        ItemValue = 0
        For i = 0 To lbCart.Items.Count - 1
            ItemValue += GetItemValue(lbCart.Items(i))
        Next
        If (ItemValue <> 0) Then
            txtPrice.Text = ""
            txtSearchItem.Text = ""
            lblTotal.Text = ItemValue.ToString() + "$"
        Else
            lblTotal.Text = ""
            MessageBox.Show("Please Add items to Cart")
        End If
    End Sub
End Class
