'Read a Text File
Imports System.IO
Imports System.Text

Module Module1

    Sub Main()
        getInforProject()
        skillMemberProject()
    End Sub

    Sub getInforProject()
        Dim objStreamReader As StreamReader
        Dim objStreamWriter As StreamWriter
        Dim strLine As String

        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader("D:\SHAHO_TRAINING.ini")

        'Read the first line of text.
        strLine = objStreamReader.ReadLine

        'Open the file.
        objStreamWriter = New StreamWriter("D:\output.txt", True, _
           Encoding.Unicode)

        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing

            'Write the line to the output.txt file.
            objStreamWriter.WriteLine(strLine)

            'Read the next line.
            strLine = objStreamReader.ReadLine
        Loop

        'Close the file.
        objStreamReader.Close()

        objStreamWriter.Close()

        Console.ReadLine()
    End Sub

    Sub skillMemberProject()
        Dim objStreamWriter As StreamWriter

        'Open the file.
        objStreamWriter = New StreamWriter("D:\output.txt", True, _
           Encoding.Unicode)

        Dim employerName As String = Nothing
        Dim employerPoint As Integer = Nothing
        Dim again As Boolean = True

        While True

            Console.WriteLine("Enter employer name:")
            employerName = Console.ReadLine()
            objStreamWriter.Write(employerName)

            Console.WriteLine("Enter employer point:")
            employerPoint = Console.ReadLine()
            If employerPoint >= 8.5 Then
                objStreamWriter.WriteLine("A")
            ElseIf employerPoint < 8.5 And employerPoint >= 7.0 Then
                objStreamWriter.WriteLine("B")
            ElseIf employerPoint < 7 And employerPoint >= 5.5 Then
                objStreamWriter.WriteLine("C")
            ElseIf employerPoint < 5 Then
                objStreamWriter.WriteLine("D")
            End If

            'process to quit the loop for example enter 'quit'
            Console.WriteLine("Press 'quit' to end/ Anykey to next input!")
            If Console.ReadLine() = "quit" Then
                again = False
            End If

            If again = False Then Exit While

        End While

        'Close the file.
        objStreamWriter.Close()
    End Sub
End Module