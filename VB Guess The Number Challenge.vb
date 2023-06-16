Imports System

Module Program
    Sub Main(args As String())

        'Delcaring Variables
        Dim computerGuess As Integer
        'Randomises a number from 100
        computerGuess = ((100 * Rnd()) + 1)
        Dim userGuess As Integer
        'Assigning a literal value to the variable
        Dim guesses As Integer = -1


        'Iteration loop - so if the user gets the guess wrong, they have to try again.
        Do
            Console.WriteLine("Please enter the guess")
            'Stores the number of guesses from user guess
            guesses = guesses + 1
            Console.WriteLine("Number of guesses are: " & guesses)
            userGuess = Console.ReadLine

        Loop Until computerGuess <= userGuess


        'Nest of  IF statements to output a result if the input isnt valid, also a result for the correct result.
        If userGuess > computerGuess Then
            Console.WriteLine("Too high,try again")

        End If

        If userGuess < computerGuess Then
            Console.WriteLine("Too low, try again")

        ElseIf userGuess = computerGuess Then
            Console.WriteLine("Thats correct!")
        End If

        Console.ReadLine()





























    End Sub
End Module
