'MODULE sind grundlegende Programmeinheiten, von welchen sich keine Instanzen erstellen lassen. Sie beinhalten nur ausführbaren Code
''der einer bestimmten Aufgabe zugeordnet ist.
Module Module1

    'Die Main()-Methode ist der Einstiegspunkt in jedes .NET-Programm. Hier startet das Programm.
    Sub Main()

        'Deklaration und Initialisierung einer String-Variablen
        Dim meinString As String = "Hallo Welt"

        'Ausgabe der String-Variablen in der Konsole
        Console.WriteLine(meinString)
        'Ausgabe eines String-Literals in der Konsole
        Console.WriteLine("Mein Name ist Klaas")

        'Deklaration und Initialisierung weiterer Variablen
        Dim Alter As Integer = 30
        Dim Name As String = "Klaas"

        'String-Formatierungen
        ''"traditionelle" Verknüpfung durch +-Operatoren (Nicht-Strings müssen explizit umgewandelt werden
        Console.WriteLine("Mein Name ist " + Name + " und ich bin " + Alter.ToString() + " Jahre alt.")
        ''Indexschreibweise -> Null-basierte Indizes werden durch angegebene Variablen ausgetauscht
        Console.WriteLine("Mein Name ist {0} und ich bin {1} Jahre alt.", Name, Alter)
        ''$-Schreibweise -> Variablen werden direkt im String plaziert
        Console.WriteLine($"Mein Name ist {Name} und ich bin {Alter} Jahre alt.")

        'Formatierung durch Konstanten
        Dim bspString As String = "Dies ist eine" + vbNewLine + $"neue Zeile und dies ein {vbTab} Tabulator."
        ''vbNewLine -> erzwingt Zeilenumbruch
        ''vbTab -> erzwingt horizontalen Tabulator
        Console.WriteLine(bspString)

        'Speichern einer Benutzereingabe (String) in einer Variablen
        Dim inputString As String = Console.ReadLine()
        Console.WriteLine("Du hast eingegeben: " + inputString)

        Console.Write("Bitte gib eine ganze Zahl ein: ")
        'Parsen des Strings in einen Integer
        Dim eingabeZahl As Integer = Integer.Parse(Console.ReadLine())
        Console.WriteLine($"Das Doppelte deiner Zahl ist: {eingabeZahl * 2}")

        'Programmpause
        Console.ReadKey()

    End Sub

End Module
