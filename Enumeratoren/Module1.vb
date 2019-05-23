Module Module1

    'ENUMERATOREN sind Datentypen, deren Variablen ausschließlich bestimmte vordefinierte Werte annehmen können.
    ''Enumeratoren müssen außerhalb von Methoden definiert werden
    Enum Wochentag
        Montag = 1
        Dienstag
        Mittwoch
        Donnerstag
        Freitag
        Samstag
        Sonntag
    End Enum

    Sub Main()

        'Deklaration und Initialisierung einer Enumerator-Variablen
        Dim heute As Wochentag = Wochentag.Montag
        Console.WriteLine($"{heute}")

        'Durchlauf über die möglichen Zustande
        Console.WriteLine("Welcher Wochentag ist heute?")
        For index = 1 To 7
            Console.WriteLine($"{index}: {DirectCast(index, Wochentag)}")
        Next

        'Abfrage eines Enumerator-Zustandes vom Benutzer und Umwandlung von String -> Int -> Enumarator
        heute = Integer.Parse(Console.ReadLine())

        Console.WriteLine($"Heute ist also {heute}.")

        'SELECTs sind verkürzte If-Blöcke, mit denen genau eine Variable auf ihren Zustand hin überprüft wird.
        ''Jeder Zustand, bei dem etwas passieren soll, wird als CASE definiert, in welchem dann der spezifische Programm-
        ''verlauf definiert wird. Wenn die Variable einen nicht näher definierten Zustand annimmt, wird der ELSE-CASE
        ''ausgeführt
        Select Case heute
            Case Wochentag.Montag
                Console.WriteLine("Schönen Start in die Woche")
            Case Wochentag.Mittwoch
                Console.WriteLine("Hälfte geschafft")
            Case Wochentag.Freitag
                Console.WriteLine("Schönes Wochenende")
            Case Else
                Console.WriteLine("Schönen Tag")
        End Select

        Console.ReadKey()

    End Sub

End Module
