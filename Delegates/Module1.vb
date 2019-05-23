Module Module1

    'Delegates sind Dateintypen, deren Variablen Refernezen auf Methoden aufnehmen könenn. Bei Aufruf der
    ''Variablen werden dann die Methoden ausgeführt. Jeder Delegatetyp kann die Methoden aufnehmen, welche
    ''seiner Signatur entsprechen

    'Defnition eines Delegate-Datentypen
    Public Delegate Function MeinDelegate(a As Integer, b As Integer) As Integer

    Sub Main()

        'Deklaration einer Delegatevariablen
        'Mittels des ADDRESSOF-Stichworts können Methoden den Delegate-Variablen zugeordnet werden 
        Dim delegateVariable As MeinDelegate = AddressOf Addiere

        'Ausführung der Methode in der Variablen
        Console.WriteLine(delegateVariable(12, 45))

        'Deklaration und Initialisierung einer weiteren Delegate-Variablen
        Dim delegateVariable2 As MeinDelegate = AddressOf Subtrahiere
        Console.WriteLine(delegateVariable2(12, 45))

        'Kombination der beiden vorherigen Variablen in einer Neuen
        Dim delegateVariable3 As MeinDelegate = MulticastDelegate.Combine(delegateVariable, delegateVariable2)
        'Ausführung der mehrfachbelegten Variablen -> beide Methoden werden nacheinander ausgeführt
        ''Beachte, dass nur der Rückgabewert der zuletzt ausgeführten Methode zurückgegeben wird
        Console.WriteLine(delegateVariable3(12, 45))

        'Deklaration eines Funcs (generischer Delegate) und Initialisierung mit einer Methode
        Dim meinFunc As Func(Of Integer, Integer, Integer) = AddressOf Addiere

        'Ausführung des Funcs
        Console.WriteLine(meinFunc(78, 89))

        'Erstellung einer Bsp-Liste und Befüllung mit Strings
        Dim städteListe As List(Of String) = New List(Of String)()
        städteListe.Add("München")
        städteListe.Add("Köln")
        städteListe.Add("Berlin")
        städteListe.Add("Hamburg")

        'Deklaration einer String-Variablen
        Dim gefundeneStadt As String

        'Verschiedene Ausführungen der Befüllung der Find()-Funktion einer Liste:
        ''Übergabe einer Methode
        gefundeneStadt = städteListe.Find(AddressOf SucheStadtMitB)

        ''Übergabe einer anonymen Methode <- Methode, welche keinen Bezeichner hat und nur ein einem Delegate existiert
        gefundeneStadt = städteListe.Find(Function(stadt As String) As Boolean
                                              Return stadt.StartsWith("B")
                                          End Function)

        ''Übergabe der anonymen Methode in Lambda-Schreibweise
        gefundeneStadt = städteListe.Find(Function(stadt) stadt.StartsWith("B"))

        Console.WriteLine(gefundeneStadt)

        Console.ReadKey()
    End Sub

    Public Function SucheStadtMitB(stadt As String) As Boolean
        Return stadt.StartsWith("B")
    End Function

    Public Function Addiere(a As Integer, b As Integer) As Integer
        Console.WriteLine("Addition")
        Return a + b
    End Function

    Public Function Subtrahiere(a As Integer, b As Integer) As Integer
        Console.WriteLine("Subtraktion")
        Return a - b
    End Function

End Module
