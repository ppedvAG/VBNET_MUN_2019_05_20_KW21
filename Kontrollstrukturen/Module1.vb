Module Module1

    'KONTROLLSTRUKTUREN regeln den Ablauf des Programms unter Bezug auf bestimmte, durch boolsche Werte oder logische
    ''Operationen dargestellte Zustände des Programms
    Sub Main()

        'Deklaration und Initialisierung von Bool-Variablen
        Dim a As Integer = 5
        Dim b As Integer = 10

        'Ein IF-Block teilt den Programmablauf in mehrere Pfade, abhängig von einer oder mehrerer Bedingungen. Das Programm
        ''wird jeweils den ersten Block ausführen, bei welchem es auf eine wahre Bedingung trifft.
        If a < b Then
            'Dies wird ausgeführt, wenn die Bedingung des IF-Blocks wahr ist.
            Console.WriteLine("a ist kleiner als b")
        ElseIf a > b Then
            'Ein If-Block kann beliebig viele ELSEIF-Blöcke beinhalten, welche weitere Bedingungen prüfen. Diese werden
            ''jedoch nur geprüft, wenn alle vorherigen Bedingungen false sind.
            Console.WriteLine("a ist größer als b")
        Else
            'Der optionale ELSE-Block wird ausgeführt, wenn keine der vorherigen Bedingungen wahr sind.
            Console.WriteLine("a ist gleich b")
        End If

        'Eine WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein
        ''unwahr, wird die Schleife übersprungen
        While a < b
            Console.WriteLine("Schleife")
            a += 1

            'Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und zwingt das Programm die Bedingung erneut
            ''zu prüfen. Ist die Bedingug nicht wahr, wird kein neuer Durchlauf gestartet.
            Continue While
        End While

        'Auch eine DO-WHILE-Schleife wird solange wiederholt, bis die Bedingung unwahr ist. Allerdings findet die Bedingungs-
        ''prüfung erst am Ende eines Schleifendurchlaufs statt. D.h. die Scheife läuft mindestens einmal durch.
        Do
            Console.WriteLine("Schleife wiederholen? (Y/N)")

            If Console.ReadKey(True).Key = ConsoleKey.N Then
                'Der EXIT-Befehl beendet eine Schleife sofort und zwingt das Programm unterhalb der Schleife weiter zu machen.
                Exit Do
            End If

        Loop While True

        'Eine FOR-Schleife besitzt eine Laufindexvariable, welche bei jedem Durchlauf manipuliert wird. Durch die Initialisierung
        ''dieser und der Angabe eines maximalen Werts, kann man festlegen, wie oft die Schleife durchläuft
        For index = 1 To 10
            Console.WriteLine($"{index}. Durchlauf")
        Next

        'Mittels des optionalen STEP-Befehls kann man selbst die Manipulation der Indexvariablen bestimmen
        For index = 10 To 1 Step -2
            Console.WriteLine($"Durchlauf Nr. {index}")
            index += 1
        Next

        'Ein ARRAY ist eine Sammlung von Werten eines bestimmten Datentyps. Ein Zugriff auf die einzelnen Werte erfolgt über
        ''einen Null-basierten Index. Die Größe eines Arrays muss bei Deklaration festgelegt werden.
        Dim Städte As String() = New String() {"München", "Berlin", "Köln"}

        Console.WriteLine(Städte.Length)

        'Manipulation und Ausgabe des Wertes an der zweiten(!) Position
        Städte(1) = "Hamburg"
        Console.WriteLine(Städte(1))

        'Mittels des REDIM-Befehls kann man die Größe (d.h. Kapazität) des Arrays manipulieren. In die Klammern schreibt man
        ''die neue Größe des Arrays. Mit dem PRESERVE-Stichwort behält das Array alle bisherigen Werte
        ReDim Preserve Städte(3)
        Städte(3) = "Berlin"

        'Iteration einer For-Schleife über ein Array
        For index = 0 To Städte.Count - 1
            Console.WriteLine(Städte(index))
        Next

        'Eine FOREACH-Schleife kann über eine Collection wie z.B. ein Array laufen und spricht dabei jedes Element genau
        ''einmal an
        For Each stadt In Städte
            Console.WriteLine(stadt)
        Next

        'Mittels der Contains()-Methode kann eine Collection auf einen Inhalt hin überprüft werden
        Console.WriteLine(Städte.Contains("Köln"))

        Console.WriteLine("Ende des Programms")
        Console.ReadKey()
    End Sub

End Module
