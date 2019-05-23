Module Module1

    Sub Main()

        'Variablendeklaration
        Dim eingabeInt As Integer
        Dim eingabeDou As Double

        'Initialisierung der Variablen durch Benutzereingabe (Eingabe -> Parsen -> Speichern in Variable)
        Console.Write("Gib eine Integer-Zahl ein: ")
        eingabeInt = Integer.Parse(Console.ReadLine())
        Console.Write("Gib eine Double-Zahl ein: ")
        eingabeDou = Double.Parse(Console.ReadLine())

        'Ausgabe der Additionen
        Console.WriteLine($"{vbNewLine}Ergebnis als Integer: {eingabeInt + CInt(eingabeDou)}")  'Ausgabe als Integer erfordert Umwandlung des Doublewerts
        Console.WriteLine($"Ergebnis als Double: {CDbl(eingabeInt) + eingabeDou}")              'Ausgabe als Double erfolgt implizit, da sich ein Doublewert in der Addition befindet

        'Berechnung und Ausgabe der Division mittels Hilfsvariablen
        Dim min = Math.Min(eingabeInt, eingabeDou)
        Dim max = Math.Max(eingabeInt, eingabeDou)
        Dim quotient = max / min
        Console.WriteLine($"{max} / {min} = {quotient}")

        'Brechnung und Ausgabe der Division ohne Hilfsvariablen
        Console.WriteLine($"{Math.Max(eingabeInt, eingabeDou)} / {Math.Min(eingabeInt, eingabeDou)} = {Math.Max(eingabeInt, eingabeDou) / Math.Min(eingabeInt, eingabeDou)}")

        'Programmpause
        Console.ReadKey()

    End Sub

End Module
