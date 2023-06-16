Imports System

Module Program
    Sub Main(args As String())

        'This program checks the length of a gamertag entered


        'Delclaring variables & Assigning a value to length
        Dim gamertag As String
        Dim length As Integer = 15
        Dim gamertag_length As Integer
        Dim valid_gamertag As Boolean
        valid_gamertag = True


        'Iteration loop - until the condition of the gamertag being 15 characters is met
        Do
            Console.WriteLine("Enter your gamertag")
            gamertag = Console.ReadLine
            gamertag_length = Len(gamertag)

        Loop While gamertag_length <= length


        If gamertag_length <> length Then
            Console.WriteLine("Must be 15 characters")
        Else
            Console.WriteLine("This is valid")
        End If

        Console.ReadLine()


    End Sub
End Module
