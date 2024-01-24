'Alex Wheelock
'RCET 0265
'Spring 2024
'Better Calculator
'https://github.com/AlexWheelock/Simple-Calculator.git

Option Explicit On
Option Strict On

Module BetterCalculator

    Sub Main()
        'Creates Variables for User input
        Dim userInput1 As String
        Dim userNumber1 As Integer
        Dim userInput2 As String
        Dim userNumber2 As Integer
        Dim userInput3 As String
        Dim Operation As Integer
        Dim Answer As Integer
        Dim sign As String
        Dim Bool As Boolean

        Do

            userNumber1 = 0
            userNumber2 = 0
            Answer = 0
            sign = ""

            Console.WriteLine("Please Enter Two Numbers. Enter " & Chr(34) & "Q" & Chr(34) & " at any time to quit")

            Do

                userInput1 = Console.ReadLine() 'takes user input
                Try
                    userNumber1 = CInt(userInput1)
                    Console.WriteLine($"You entered " & Chr(34) & userNumber1 & Chr(34))
                Catch ex As Exception
                    If userInput1 = "q" Then
                        Console.WriteLine("Have a nice day!" & vbNewLine _
                                  & "Press enter to close this window")
                        Console.Read()
                        Exit Sub
                    Else
                        Console.WriteLine("You entered " & Chr(34) & CStr(userInput1) & Chr(34) & ". Please enter a whole number.")
                    End If
                End Try

            Loop Until userNumber1 <> 0

            Do
                'prompts the user to define Number2 variable
                Console.WriteLine("Please Enter Another Number.")
                userInput2 = Console.ReadLine() 'takes userInput2

                Try
                    userNumber2 = CInt(userInput2)
                    Console.WriteLine($"You entered " & Chr(34) & userNumber2 & Chr(34))
                Catch ex As Exception
                    If userInput2 = "q" Then
                        Console.WriteLine("Have a nice day!" & vbNewLine _
                                  & "Press enter to close this window.")
                        Console.Read()
                        Exit Sub
                    Else
                        Console.WriteLine("You entered " & Chr(34) & CStr(userInput2) & Chr(34) & ". Please enter a whole number.")
                    End If
                End Try

            Loop Until userNumber2 <> 0

            Do

                Console.WriteLine("Choose one of the following options:" & vbNewLine _
                              & "1. Add" & vbNewLine _
                              & "2. Subtract" & vbNewLine _
                              & "3. Multiply" & vbNewLine _
                              & "4. Divide")

                userInput3 = Console.ReadLine() 'takes user input

                Try
                    Operation = CInt(userInput3)
                Catch ex As Exception
                    If userInput3 = "q" Then
                        Console.WriteLine("Have a nice day!" & vbNewLine _
                                  & "Press enter to close this window.")
                        Console.Read()
                        Exit Sub
                    End If
                End Try

                If userInput3 = "q" Then
                    Console.WriteLine("Have a nice day!" & vbNewLine _
                              & "Press enter to close this window.")
                    Console.Read()
                    Exit Sub

                ElseIf Operation = 1 Then
                    Answer = userNumber1 + userNumber2
                    sign = "+"
                    Bool = True
                ElseIf Operation = 2 Then
                    Answer = userNumber1 - userNumber2
                    sign = "-"
                    Bool = True
                ElseIf Operation = 3 Then
                    Answer = userNumber1 * userNumber2
                    sign = "*"
                    Bool = True
                ElseIf Operation = 4 Then
                    Answer = userNumber1 \ userNumber2
                    sign = "/"
                    Bool = True
                End If

                Console.WriteLine("You entered " & Chr(34) & userInput3 & Chr(34))

            Loop Until Bool = True

            Console.WriteLine((userInput1) & " " & CStr(sign) & " " & CStr(userInput2) & " = " & CStr(Answer))
        Loop
    End Sub

End Module
