'vgl Schiff
Imports Fahrzeugpark

Public Class PKW
    Inherits Fahrzeug
    Implements IBewegbar

    Private _anzahlTüren As Integer
    Public Property AnzahlTüren() As Integer
        Get
            Return _anzahlTüren
        End Get
        Set(ByVal value As Integer)
            _anzahlTüren = value
        End Set
    End Property

    Private _räderAnzahl As Integer
    Public Property RäderAnzahl As Integer Implements IBewegbar.RäderAnzahl
        Get
            Return _räderAnzahl
        End Get
        Set(value As Integer)
            _räderAnzahl = value
        End Set
    End Property

    Public Sub New(name As String, maxG As Integer, preis As Double, anzTüren As Integer)

        MyBase.New(name, maxG, preis)
        _anzahlTüren = anzTüren
        _räderAnzahl = 4

    End Sub

    'Überschreibende Methode (Benötigt eine gleichnamige, mit OVERRIDABLE markierte Methode in der Mutterklasse)
    Public Overrides Function BeschreibeMich() As String
        Return "Der PKW " + MyBase.BeschreibeMich() + $" Er hat {AnzahlTüren} Türen."
    End Function

    'Implementierung der abstrakten Methode der Fahrzeug-Klasse
    Public Overrides Sub Hupen()
        Console.WriteLine("Hup Hup")
    End Sub

    Public Sub Bewegen() Implements IBewegbar.Bewegen
        Console.WriteLine("Brumm Brumm")
    End Sub
End Class
