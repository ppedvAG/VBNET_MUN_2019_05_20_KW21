Imports Fahrzeugpark

Module Module1

    Sub Main()

#Region "Modul/Lab 04: Objektorientierte Programmierung"

        ''Deklaration der Fahrzeugvariablen und Initialisierung der Fahrzeugobjekte
        'Dim fz1 As Fahrzeug = New Fahrzeug("BMW", 270, 25000)
        'Dim fz2 As Fahrzeug = New Fahrzeug("Mercedes", 260, 28000)

        ''Ausgabe der Name-Property von fz1 (über deren Getter)
        'Console.WriteLine(fz1.Name)

        ''Ausführen einer Methode von fz1
        'fz1.Beschleunige(80)

        ''Ausgabe der AktGeschwindigkeit-Properties
        'Console.WriteLine(fz1.AktGeschwindigkeit)
        'Console.WriteLine(fz2.AktGeschwindigkeit)

        ''Ausführen von Methoden von fz1
        'fz1.StarteMotor()
        'fz1.Beschleunige(300)

        ''Ausgabe der BeschreibeMich()-Methoden
        'Console.WriteLine(fz1.BeschreibeMich())
        'Console.WriteLine(fz2.BeschreibeMich())

#End Region

#Region "Modul05/Lab05: Vererbung"
        '        'Deklaration und Initialisierung der spezifischen Fahrzeuge sowie Aufruf der BeschreibeMich()-Methoden
        '        Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        '        Console.WriteLine(pkw1.BeschreibeMich())

        '        Dim flugzeug1 As Flugzeug = New Flugzeug("Boing", 800, 3500000, 9999)
        '        Console.WriteLine(flugzeug1.BeschreibeMich())

        '        Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)
        '        Console.WriteLine(schiff1.BeschreibeMich())

        '        'Aufruf der abstarkten Methoden Hupen()
        '        pkw1.Hupen()
        '        schiff1.Hupen()
        '        flugzeug1.Hupen()

        '        'Ausgabe des Shared Members der Fahrzeug-Klasse
        '        Console.WriteLine("Produzierte Fahrzeuge: " + Fahrzeug.AnzahlFahrzeuge.ToString())
#End Region

#Region "Modul06: Interfaces und Polymorphismus"
        'Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        'Dim flugzeug1 As Flugzeug = New Flugzeug("Boing", 800, 3500000, 9999)

        'Dim fz1 As Fahrzeug = pkw1
        'Dim bewegbaresObjekt As IBewegbar = pkw1

        'RadAb(pkw1)
        'RadAb(flugzeug1)

        'BaueUnfall(pkw1)
        'BaueUnfall(flugzeug1)
#End Region

#Region "Lab06: IBeladbar"
        'Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        'Dim flugzeug1 As Flugzeug = New Flugzeug("Boing", 800, 3500000, 9999)
        'Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)

        'BeladeFahrzeug(schiff1, schiff1)
        'Console.WriteLine()

        'BeladeFahrzeug(pkw1, flugzeug1)
        'Console.WriteLine()

        'BeladeFahrzeug(pkw1, schiff1)
        'Console.WriteLine()

        'BeladeFahrzeug(schiff1, flugzeug1)
        'Console.WriteLine()

        'Console.WriteLine(schiff1.BeschreibeMich())
        'Console.WriteLine()

        'schiff1.Entlade()
        'Console.WriteLine()

        'schiff1.Entlade()
#End Region

#Region "Modul07: Generische Listen"
        'Dim stringListe As List(Of String) = New List(Of String)()

        'stringListe.Add("München")
        'stringListe.Add("Berlin")
        'stringListe.Add("Hamburg")

        'Console.WriteLine(stringListe.Count)

        'Console.WriteLine(stringListe(1))

        'For Each item In stringListe
        '    Console.WriteLine(item)
        'Next

        'Dim fahrzeugliste As List(Of Fahrzeug) = New List(Of Fahrzeug)()

        'Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        'fahrzeugliste.Add(pkw1)
        'fahrzeugliste.Add(New Flugzeug("Boing", 800, 3500000, 9999))
        'fahrzeugliste.Add(New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf))

        'For index = 0 To fahrzeugliste.Count - 1
        '    Console.WriteLine(fahrzeugliste(index).Name)
        'Next

        'Dim dict As Dictionary(Of String, Fahrzeug) = New Dictionary(Of String, Fahrzeug)()

        'dict.Add("fahren", New PKW("BMW", 270, 27000, 5))
        'dict.Add("schwimmen", New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf))
        'dict.Add("fliegen", New Flugzeug("Boing", 800, 3500000, 9999))

        'Console.WriteLine(dict("schwimmen").Name)

        'For Each item In dict

        '    Console.WriteLine(item.Key + ": " + item.Value.Name)
        'Next
#End Region

#Region "Zufällige Fahrzeuglisten"
        'Initialisierung der Listen und des Zufallszahlengenerators
        Dim generator As Random = New Random()
        Dim fzQueue As Queue(Of Fahrzeug) = New Queue(Of Fahrzeug)()
        Dim fzStack As Stack(Of Fahrzeug) = New Stack(Of Fahrzeug)()
        Dim fzDict As Dictionary(Of Fahrzeug, Fahrzeug) = New Dictionary(Of Fahrzeug, Fahrzeug)()

        'Initialisierung einer Variablen zur Angabe der Durchläufe
        Dim anzahlFahrzeuge As Integer = 100000

        'Zufällige "Befüllung" der Listen mittels des Zufallszahlengenerators und SelectCase
        For index = 1 To anzahlFahrzeuge
            Select Case generator.Next(1, 4)
                Case 1
                    fzStack.Push(New PKW($"BMW_S{index}", 270, 29000, 5))
                    fzQueue.Enqueue(New PKW($"BMW_Q{index}", 270, 29000, 5))
                Case 2
                    fzStack.Push(New Schiff($"Titanic_S{index}", 50, 3000000, Schiff.Schiffstreibstoff.Dampf))
                    fzQueue.Enqueue(New Schiff($"Titanic_Q{index}", 50, 3000000, Schiff.Schiffstreibstoff.Dampf))
                Case 3
                    fzStack.Push(New Flugzeug($"Boing_S{index}", 800, 2900000, 9900))
                    fzQueue.Enqueue(New Flugzeug($"Boing_Q{index}", 800, 2900000, 9900))
            End Select
        Next

        'Versuch, die QueueFz's mit den StackFz's zu beladen
        For index = 1 To anzahlFahrzeuge
            'Prüfung auf das Interface (ob beladen werden kann)
            If TypeOf fzQueue.Peek() Is IBeladbar Then
                'wenn ja, dann Cast ins Interface 
                Dim beladbaresFz As IBeladbar = DirectCast(fzQueue.Peek(), IBeladbar)
                'und Aufruf der Belade()-Funktion (mittels Peek(), da die Fz's noch benötigt werden)
                beladbaresFz.Belade(fzStack.Peek())
                'Hinzufügen der Fz's zum Dictionary (mittels Dequeue()/Pop(), damit beim nächsten Durchlauf andere Fz's oben sind)
                fzDict.Add(fzQueue.Dequeue(), fzStack.Pop())
            Else
                'wenn nein, dann werden die Fz's vor dem nächsten Durchlauf rausgeschmissen
                fzQueue.Dequeue()
                fzStack.Pop()
            End If
        Next

        'Ausgabe des Dictionaries
        For Each item In fzDict
            Console.WriteLine($"{item.Key.Name} hat {item.Value.Name} geladen.")
        Next
#End Region

        Console.ReadKey()
    End Sub

#Region "Modul06-Methoden"
    Sub RadAb(bewegbaresO As IBewegbar)
        bewegbaresO.RäderAnzahl -= 1
    End Sub

    Sub BaueUnfall(fz As Fahrzeug)
        Console.WriteLine($"{fz.Name} ist gechrasht")

        If fz.GetType() = GetType(PKW) Then
            Dim pkw1 As PKW = DirectCast(fz, PKW)
            pkw1.AnzahlTüren -= 1
            Console.WriteLine("Das Auto hat eine Tür verloren")
        End If

    End Sub
#End Region

#Region "Lab06-Methode"
    Public Sub BeladeFahrzeug(fz1 As Fahrzeug, fz2 As Fahrzeug)
        'Überprüfung, ob die fz's das Interface implementiert haben (dh. ob sie eine Ladung aufnehmen können)
        If TypeOf fz1 Is IBeladbar Then
            'Wenn ja, dann Cast in temporäre IBeladbar-Variable
            Dim beladbaresO As IBeladbar = DirectCast(fz1, IBeladbar)
            'und Aufruf der Belade()-Funktion mit Übergabe des anderen Fahrzeugs
            beladbaresO.Belade(fz2)
        ElseIf TypeOf fz2 Is IBeladbar Then
            'Alternative Schreibweise ohne temporäre Variable
            DirectCast(fz2, IBeladbar).Belade(fz1)
        Else
            Console.WriteLine("Kein Fahrzeug hat einen Laderaum, der beladen werden konnte.")
        End If
    End Sub
#End Region



End Module
