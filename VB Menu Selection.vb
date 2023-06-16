Imports System

Module Program
    Sub Main()

        'Delcaring Variables
        Dim PlayGame As String = 1
        Dim Instructions As String = 2
        Dim Quit As String = 3
        Dim answer, answer2 As String
        'Asking user to choose between 3 numbers
        Console.WriteLine("Choose between:" & ", " & PlayGame & ", " & Instructions & ", " & Quit)
        'Assigning the variable
        answer = Console.ReadLine
        'Looping until the value is met
        Do
            Console.WriteLine("Choose:" & ", " & PlayGame & ", " & Instructions & ", " & Quit)
            answer2 = Console.ReadLine
            'Asking the program to loop when the answer is greater than 4
        Loop While answer2 >= 4
        Console.WriteLine("Valid Input")
        Console.ReadLine()


    End Sub
End Module
