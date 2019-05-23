'Eine KLASSE ist ein Programmteil, welches die Struktur von bestimmten Objekten definiert. Alle Objekte, welche von dieser
''Klasse abgeleitet werden, besitzen die selben Methoden und Eigenschaften, welche aber unterschiedlich befüllt werden können
''und unabhängig von anderen gleichartigen Objekten agieren.
'Wenn eine Klassensignatur das Stichwort MUSTINHERIT beinhaltet, gilt die Klasse als abstarkt. D.h. von dieser Klasse dürfen
''keine Objekte mehr erzeugt werden. Sie ist nur noch Vorlage für Kindklassen.
Public MustInherit Class Fahrzeug

#Region "Shared Member"
    'SHARED Variablen und Methoden gelten unabhängig von Instanzen für die ganze Klasse.  
    Public Shared AnzahlFahrzeuge As Integer = 0

    Public Shared Function ZeigeAnzahlFahrzeuge() As String
        Return "Es wurden " + Fahrzeug.AnzahlFahrzeuge.ToString() + " Fahrzeuge produziert."
    End Function
#End Region

#Region "Felder und Properties"
    'FELDER sind die Variablen, welche jedes Objekt dieser Klasse besitzt und welche individuell befüllt werden können.
    'PROPERTIES sind jeweils einem Feld zugeordnet und definieren über die Getter und Setter den Lese- und Schreibzugriff
    ''auf das jeweilige Feld.
    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _maxGeschwindigkeit As Integer
    Public Property MaxGeschwindigkeit() As Integer
        Get
            Return _maxGeschwindigkeit
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                _maxGeschwindigkeit = 0
            Else
                _maxGeschwindigkeit = value
            End If
        End Set
    End Property

    Private _aktGeschwindigkeit As Integer
    Public Property AktGeschwindigkeit() As Integer
        Get
            Return _aktGeschwindigkeit
        End Get
        Set(ByVal value As Integer)
            _aktGeschwindigkeit = value
        End Set
    End Property

    Private _preis As Double
    Public Property Preis() As Double
        Get
            Return _preis
        End Get
        Set(ByVal value As Double)
            _preis = value
        End Set
    End Property

    Private _zustand As Boolean 'true = Motor läuft
    Public Property Zustand() As Boolean
        Get
            Return _zustand
        End Get
        Set(ByVal value As Boolean)
            _zustand = value
        End Set
    End Property

#End Region

#Region "Konstruktor und Destruktor"
    'Ein KONSTRUKTOR wird vom Programm aufgerufen, wenn eine neue Instanz (ein neues Objekt) dieser Klasse erstellt werden
    ''soll. Dabei wird der Startzustand der Objekte definiert.
    Public Sub New(name As String, maxG As Integer, preis As Double)
        'Individuelle Belegung von Felder über die Übergabeparameter
        _name = name
        _maxGeschwindigkeit = maxG
        _preis = preis
        'Fixe Belegung von Felder, die immer den gleichen Startwert
        _aktGeschwindigkeit = 0
        _zustand = False

        Fahrzeug.AnzahlFahrzeuge += 1
    End Sub

    'Der Destruktor wird von der GarbageCollection aufgerufen, wenn das entsprechende Objekt durch keine Variable mehr referenziert wird, und 
    ''löscht dieses aus dem Speicher. Der Destruktor muss nicht manuell definiert werden, kann aber in der Klasse mit weiternen Aktionen, welche 
    ''über die Zerstörung des Objekts hinausgehen befüllt werden (wie hier mit einer Konsolen-Ausgabe)

    Protected Overrides Sub Finalize()
        Console.WriteLine($"{Name} wurde zerstört")
    End Sub
#End Region

#Region "Methoden"
    'Methoden einer Klasse (welche nicht als Shared markiert sind) gelten jeweils für ein Objekt der Klasse. Jedes Objekt
    ''besitzt alle definierten Methoden, welche bei Aufruf (über den Variablenbezeichner des Objekts) ausgeführt werden
    ''und dieses spezielle Objekt manipulieren.
    Public Sub StarteMotor()
        Zustand = True
    End Sub

    Public Sub StoppeMotor()
        Zustand = False
    End Sub

    Public Sub Beschleunige(a As Integer)
        If Zustand Then
            If AktGeschwindigkeit + a > MaxGeschwindigkeit Then
                AktGeschwindigkeit = MaxGeschwindigkeit
            ElseIf AktGeschwindigkeit + a < 0 Then
                AktGeschwindigkeit = 0
            Else
                AktGeschwindigkeit += a
            End If
        End If
    End Sub

    'Als OVERRIDABLE markierte Methoden erlauben erbenden Klassen diese zu überschreiben, so dass bei Methodenaufruf die Methode
    ''der Kindklasse ausgeführt wird
    Public Overridable Function BeschreibeMich() As String
        Return $"{Name} fährt mit {AktGeschwindigkeit} von {MaxGeschwindigkeit} km/h und kostet {Preis} Euro."
    End Function

    'Abstarkte Methoden (markiert mit dem MUSTOVERRIDE-Stichwort) besitzen nur eine Signatur. Die Implementierung des Körpers
    ''erfolgt individuell in den Kindklassen, welche dazu gewungen werden. Abstrakte Methoden dürfen nur in eine abstrakten
    ''Klasse geschrieben werden
    Public MustOverride Sub Hupen()
#End Region

End Class
