
Imports System.IO
Imports System.Text.RegularExpressions

Public Class GettingValues
    Public Function GetValue() As ArrayList
        Dim directory As String = My.Application.Info.DirectoryPath
        Dim output As String = Regex.Split(directory, "\Debug")(0)
        Dim arr As New ArrayList()
        Dim infile As System.IO.StreamReader


        If System.IO.File.Exists(output + "Values.txt") = True Then
            infile = New System.IO.StreamReader(output + "Values.txt")
            Do While infile.Peek() <> -1
                arr.Add(infile.ReadLine())
            Loop
            infile.Close()
        Else
            MsgBox("File Not Found")
        End If
        Return arr

    End Function


End Class


