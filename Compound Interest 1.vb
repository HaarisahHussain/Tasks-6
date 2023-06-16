Imports System

Module Program
    Sub Main(args As String())

        'Delcaring Variables and assigning constants
        Dim startingBalance, desiredBalance, newBal As Integer
        Dim years As Integer = 0
        Dim interestRat As Decimal = 0.04
        Dim calc1, calc2 As Decimal



        'Asking user for the input and assigning a value in the variable
        Console.WriteLine("Please input your starting balance")
        startingBalance = Console.ReadLine
        Console.WriteLine("Please enter desired balance")
        desiredBalance = Console.ReadLine
        'calc1 to find the current balance which is then stored in newBal
        calc1 = startingBalance + (1 * interestRat)
        newBal = calc1


        'Iteration loop which constantly keeps storing the new value and readding the values together
        Do
            calc2 = newBal + (newBal * interestRat)
            newBal = calc2
            years = years + 1
            Console.WriteLine("year " & years & " New Balance: " & newBal)


        Loop While newBal <= desiredBalance
        Console.ReadLine()
    End Sub
End Module
