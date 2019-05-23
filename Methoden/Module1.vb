Module Module1

    Sub Main()

        AddiereUndGibAus(45, 89)

        Dim Summe = Addiere(2, 3, 12)
        Console.WriteLine(Summe)

        Summe = Addiere(15, 1)
        Console.WriteLine(Summe)

        Summe = BildeSumme(1, 78, 3, 43, 5, 78, 1045)
        Console.WriteLine(Summe)

        Console.ReadKey()

    End Sub

    'Methoden sind Programmteile, von denen jeder eine sehr spezielle und kleinteilige Aufgabe ausführt.
    ''Es wird unterschieden zwischen Prozeduren, welche keinen Rückgabewert besitzen und mit dem Stichwort
    ''SUB gekennzeichnet sind...
    Public Sub AddiereUndGibAus(a As Integer, b As Integer)
        Console.WriteLine(a + b)
    End Sub

    '...und Funktionen, die einen Rückgabewert besitzen und mit dem Stichwort FUNCTION markiert werden.
    ''Jede Methode besteht aus einem Kopf (einer Signatur) in welchem der Zugriff und die Methodenart
    ''definiert werden, ein Bezeichner für die Methode bestimmt wird und Übergabeparameter (und Rückgabe-
    ''wert bei Funktionen) definiert werden... 
    Public Function Addiere(a As Integer, b As Integer) As Integer
        '...und einem Körper, in welchem die Programmlogik hinterlegt wird.
        ''Mittels des RETURN-Befehls wird in Funktionen der Rückgabewert an den Aufrufer gesand und die
        ''Ausführung der Methode unterbrochen
        Return a + b
    End Function

    'Methoden, welche den gleichen Bezeichner haben aber unterschiedliche Übergabeparameter heißen 'ÜBERLADENE
    ''Methoden'. Eine Eindeutigkeit wird durch die verschiedenen Übergabeparameter erzielt. 
    Public Function Addiere(a As Double, b As Double, Optional c As Double = 0) As Double
        'Mit dem OPTIONAL-Stichwort kann man Default-Werte für die Übergabeparameter definieren. Diese werden
        ''bei Nicht-Angabe der Parameter während des Methodenaufrufs eingesetzt.
        Return a + b + c
    End Function

    'Mittels des PARAMARRAY-Stichwort können beliebig viele Parameter eines Datentyps übergeben werden, welche 
    ''Methodenintern als Array interpretiert werden
    Public Function BildeSumme(ParamArray summanden() As Integer) As Integer
        Dim summe As Integer = 0
        For Each summand In summanden
            summe += summand
        Next
        Return summe
    End Function
End Module
