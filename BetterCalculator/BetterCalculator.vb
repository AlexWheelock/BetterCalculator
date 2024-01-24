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

        Do

            userNumber1 = vbNull
            userNumber2 = vbNull
            Answer = vbNull
            sign = ""

            Console.WriteLine("Please Enter Two Numbers. Enter " & Chr(34) & "Q" & Chr(34) & " at any time to quit")

            Do
                Console.ReadLine()
                userInput1 = Console.ReadLine() 'takes user input
                Try
                    userNumber1 = CInt(userInput1)
                    Console.WriteLine($"You entered {userNumber1}")
                Catch ex As Exception
                    If userInput1 = "q" Then
                        Console.WriteLine("Have a nice day" & vbNewLine _
                                  & "Press enter to close this window")
                        Console.Read()
                        Exit Sub
                    Else
                        Console.WriteLine("You entered" & Chr(34) & CStr(userInput1) & Chr(34) & ", please enter a whole number")
                    End If
                End Try

            Loop Until userNumber1 <> vbNull

            Do
                'prompts the user to define Number2 variable
                Console.WriteLine("Please Enter Another Number.")
                userInput2 = Console.ReadLine() 'takes userInput2

                Try
                    userNumber2 = CInt(userInput2)
                    Console.WriteLine($"You entered {userNumber2}")
                Catch ex As Exception
                    If userInput1 = "q" Then
                        Console.WriteLine("Have a nice day" & vbNewLine _
                                  & "Press enter to close this window")
                        Console.Read()
                        Exit Sub
                    Else
                        Console.WriteLine("You entered" & Chr(34) & CStr(userInput2) & Chr(34) & ", please enter a whole number")
                    End If
                End Try

            Loop Until userNumber2 <> vbNull

            Do

                Console.WriteLine("Choose one of the following options:" & vbNewLine _
                              & "1. Add" & vbNewLine _
                              & "2. Subtract" & vbNewLine _
                              & "3. Multiply" & vbNewLine _
                              & "4. Divide")

                userInput3 = Console.ReadLine() 'takes user input

                Try
                    Operation = CInt(userInput3)
                    Console.WriteLine($"You entered {Operation}")
                Catch ex As Exception
                    If userInput3 = "q" Then
                        Console.WriteLine("Have a nice day" & vbNewLine _
                                  & "Press enter to close this window")
                        Console.Read()
                        Exit Sub

                    ElseIf Operation = 1 Then
                        Answer = userNumber1 + userNumber2
                        sign = "+"

                    ElseIf Operation = 2 Then
                        Answer = userNumber1 - userNumber2
                        sign = "-"

                    ElseIf Operation = 3 Then
                        Answer = userNumber1 * userNumber2
                        sign = "*"

                    ElseIf Operation = 4 Then
                        Answer = userNumber1 \ userNumber2
                        sign = "/"

                    Else Console.WriteLine("You Entered " & Chr(34) & CStr(Operation) & Chr(34) & ", please enter a valid input.")

                    End If
                End Try
            Loop Until Operation = 1 - 4

            Console.WriteLine((userInput1) & " " & CStr(sign) & " " & CStr(userInput2) & " = " & CStr(Answer) & vbNewLine _
                          & "The Answer is " & Answer & ".")
        Loop
    End Sub

End Module
