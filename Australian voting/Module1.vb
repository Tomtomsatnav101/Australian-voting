Imports System
Module Module1

    Class ballot

        Public voterslot As Integer
        Public contents(1000, 1000) As Integer


        Public Function assignvotes(a As Integer, b As Integer) ' a is voter number, b is the slot on the ballot
            For i As Integer = 1 To b
                Console.WriteLine("Who is your " + i.ToString + " choice?")
                'Console.WriteLine(a.ToString + " is a and " + i.ToString)
                contents(a, i) = Console.ReadLine()
            Next
        End Function

        Public Function countvotes()
            For i As Integer = 1 To voterno
                Dim current As Integer = contents(i, 1)
                total(current) += 1

            Next

        End Function

        Public Function largest()
            Dim totalcurrent As Integer
            For i As Integer = 1 To voterno
                totalcurrent += total(i)
            Next
            For i As Integer = 1 To voterno
                If total(i) / totalcurrent >= 0.5 Then
                    bigiftrue = True
                    largest = i
                    If total(i) < smallest Then
                        smallest = total(i)
                        wastedvote = i
                    End If
                End If

            Next


        End Function



    End Class



    Dim voterno As Integer
    Dim counter As Integer = 0
    Dim total() As Integer
    Dim largest As Integer
    Dim round As Integer
    Dim bigiftrue As Boolean
    Dim smallest As Integer
    Dim wastedvote As Integer

    Sub Main()
        Console.WriteLine("How many applicants are there?")
        Dim voters As ballot
        voters = New ballot()

        voters.voterslot = Console.ReadLine()
        Dim candidate(voters.voterslot) As String
        Dim total(voters.voterslot)


        For i As Integer = 1 To voters.voterslot
            Console.WriteLine("Who is candidate number " + i.ToString + "?")
            candidate(i) = Console.ReadLine
        Next

        Console.Clear()

        Console.WriteLine("How many voters are there?")
        voterno = Console.ReadLine()



        For i As Integer = 1 To voterno
            voters.assignvotes(i, voters.voterslot)    ' i is voter number, counter is the slot on the ballot
            Console.Clear()
        Next

        Do While bigiftrue = False
            voters.largest()
            If bigiftrue = True Then

            Else
                For i As Integer = 1 To voterno
                    voters.contents(wastedvote, i) = voters.contents(wastedvote, i + 1)

                Next
            End If
        Loop
        Console.WriteLine("We have a winner")




        Console.ReadLine()
    End Sub




End Module
