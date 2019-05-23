'Eigene Exceptions müssen von der Exception-Klasse erben und können dann manuell mittels des throw-Stichworts
''geworfen werden
Public Class MeineException
    Inherits Exception

    Public Sub New()
        MyBase.New("Dies ist mein Fehler")
    End Sub

End Class

Module Module1

    'Mittels Exception-Handling führt man eine Bearbeitung von Laufzeitfehlern im Programm durch.
    Sub Main()

        'In einen TRY-Block werden die Programmteile geschrieben, welche möglicherweise zur Laufzeit einen Fehler
        ''produzieren (z.B. die Integer.Parse()-Funktion). Kommt es zu einem Fehler wird eine EXCEPTION geworfen,
        ''die Ausführung des Try-Blocks wird abgebrochen und die Exception muss von einem passenden CATCH-Block 
        ''abgefangen werden.
        Try
            Dim zahl As Integer = Integer.Parse(Console.ReadLine())

            'Mittels des THROW-Stichworts können Exceptions manuell geworfen werden
            Throw New MeineException()

            Console.WriteLine("Ende des Try-Blocks")

            'Jedem Try-Block muss mindestens ein Catch-Block folgen, in welchem die geworfenen Fehler abgefangen 
            ''werden. Im Catch-Block kann definiert werden, welche Exceptions abgefangen werden (Signatur) und 
            ''wie sie bearbeitet werden (Körper). Nach der Bearbeitung Nicht abgefangene Exceptions werden an 
            ''den Benutzer durchgereicht und führen zum Programmabbruch.
        Catch ex As FormatException
            Console.WriteLine("Du hättest eine Zahl eingeben müssen. " + ex.Message)

            Throw

        Catch ex As OverflowException
            Console.WriteLine("Deine Zahl war zu groß/klein. " + ex.Message)

        Catch ex As Exception
            Console.WriteLine("Ein unbekannter Fehler ist aufgetreten. " + ex.Message)

            'Der optionale FINALLY-Block wird, egal ob es zu einem Fehler kam oder nicht, immer ausgeführt
        Finally
            Console.WriteLine("Wird immer angezeigt")

        End Try

        Console.WriteLine("Ende des Programms")
        Console.ReadKey()

    End Sub

End Module
