Imports System.IO
Imports System.Text.RegularExpressions


Public Class GetItemValues






    Public Function GetItemValue() As ArrayList


        Dim directory As String = My.Application.Info.DirectoryPath
        Dim result As String = Regex.Split(directory, "\Debug")(0)
        Dim arrLines As New ArrayList()
        Dim objReader As System.IO.StreamReader
        Dim iRowCount As Integer = 0
        If System.IO.File.Exists(result + "Allstarcrick.txt") = True Then
            ' read the file's lines into an ArrayList
            objReader = New System.IO.StreamReader(result + "Allstarcrick.txt")
            Do While objReader.Peek() <> -1
                arrLines.Add(objReader.ReadLine())

            Loop
            objReader.Close()
        Else
            Console.WriteLine("'" & result + "Allstarcrick.txt" & "' File does not exist")
        End If

        Return arrLines

    End Function


End Class
