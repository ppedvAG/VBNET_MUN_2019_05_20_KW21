'vgl Schiff
Public Class Flugzeug
    Inherits Fahrzeug
    Implements IBewegbar

    Private _maxFlughöhe As Integer
    Public Property MaxFlughöhe() As Integer
        Get
            Return _maxFlughöhe
        End Get
        Set(ByVal value As Integer)
            _maxFlughöhe = value
        End Set
    End Property

    Private _räderanzahl As Integer
    Public Property RäderAnzahl As Integer Implements IBewegbar.RäderAnzahl
        Get
            Return _räderanzahl
        End Get
        Set(value As Integer)
            _räderanzahl = value
        End Set
    End Property

    Public Sub New(name As String, preis As Double, maxG As Integer, maxF As Integer)
        MyBase.New(name, preis, maxG)
        _maxFlughöhe = maxF
        _räderanzahl = 12
    End Sub

    Public Overrides Function BeschreibeMich() As String
        Return "Das Flugzeug " + MyBase.BeschreibeMich() + $" Es kann auf {MaxFlughöhe}m aufsteigen."
    End Function

    Public Overrides Sub Hupen()
        Console.WriteLine("Huuuuuuup")
    End Sub

    Public Sub Bewegen() Implements IBewegbar.Bewegen
        Console.WriteLine($"{Name} wurde in Startposition gebracht.")
    End Sub
End Class
