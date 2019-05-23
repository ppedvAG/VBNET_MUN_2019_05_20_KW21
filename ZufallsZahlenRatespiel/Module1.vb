Module Module1

    Sub Main()

        Dim generator As Random = New Random()

        Dim eingabe As Integer

        Dim zufälligeZahl As Integer = generator.Next(1, 6)

        Do

            Console.Write("Bitte gib eine Zahl zwischen 1 und 5 ein: ")

            eingabe = Integer.Parse(Console.ReadLine())

            If eingabe = zufälligeZahl Then
                Console.WriteLine("Treffer!")

            ElseIf eingabe < zufälligeZahl Then
                Console.WriteLine("Deine Zahl ist zu klein")

            Else
                Console.WriteLine("Deine Zahl ist zu groß")

            End If

        Loop While zufälligeZahl <> eingabe

        Console.ReadKey()

    End Sub

End Module
