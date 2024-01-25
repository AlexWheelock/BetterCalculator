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
        Dim AnswerInt As Integer
        Dim AnswerStr As String
        Dim sign As String
        Dim Boolean1 As Boolean
        Dim Boolean2 As Boolean
        Dim Boolean3 As Boolean

        Do

            userNumber1 = 0
            userNumber2 = 0
            AnswerInt = 0
            AnswerStr = ""
            sign = ""
            Boolean1 = False
            Boolean2 = False
            Boolean3 = False

            Console.WriteLine("Please Enter Two Numbers. Enter " & Chr(34) & "Q" & Chr(34) & " at any time to quit")

            Do

                userInput1 = Console.ReadLine() 'takes user input
                Try
                    userNumber1 = CInt(userInput1)
                    Console.WriteLine($"You entered " & Chr(34) & userNumber1 & Chr(34))
                    Boolean1 = True
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

            Loop Until Boolean1 = True

            Do
                'prompts the user to define Number2 variable
                Console.WriteLine("Please Enter Another Number.")
                userInput2 = Console.ReadLine() 'takes userInput2

                Try
                    userNumber2 = CInt(userInput2)
                    Console.WriteLine($"You entered " & Chr(34) & userNumber2 & Chr(34))
                    Boolean2 = True
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

            Loop Until Boolean2 = True

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
                    AnswerInt = userNumber1 + userNumber2
                    sign = "+"
                    Boolean3 = True
                    AnswerStr = CStr(AnswerInt)
                ElseIf Operation = 2 Then
                    AnswerInt = userNumber1 - userNumber2
                    sign = "-"
                    Boolean3 = True
                    AnswerStr = CStr(AnswerInt)
                ElseIf Operation = 3 Then
                    AnswerInt = userNumber1 * userNumber2
                    sign = "*"
                    Boolean3 = True
                    AnswerStr = CStr(AnswerInt)
                ElseIf Operation = 4 Then
                    Try
                        AnswerInt = userNumber1 \ userNumber2
                        sign = "/"
                        Boolean3 = True
                        AnswerStr = CStr(AnswerInt)
                    Catch
                        AnswerStr = "Inifity"
                        sign = "/"
                        Boolean3 = True
                    End Try
                End If

                Console.WriteLine("You entered " & Chr(34) & userInput3 & Chr(34))

            Loop Until Boolean3 = True

            Console.WriteLine((userInput1) & " " & CStr(sign) & " " & CStr(userInput2) & " = " & CStr(AnswerStr))
        Loop
    End Sub

End Module
