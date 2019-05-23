Imports System.IO
Imports Fahrzeugpark
Imports Newtonsoft.Json

Public Class Form1

    'List-Property zum Abspeichern der Fahrzeuge
    Private _fahrzeugliste As List(Of Fahrzeug)
    Public Property Fahrzeugliste() As List(Of Fahrzeug)
        Get
            Return _fahrzeugliste
        End Get
        Set(ByVal value As List(Of Fahrzeug))
            _fahrzeugliste = value
        End Set
    End Property

    'Konstruktor der Form-Klasse
    Public Sub New()

        ' This call is required by the designer.
        ''Diese Methode muss immer als Erstes im Konstruktor ausgeführt werden (rendert die im Designer gesetzten Elemente)
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Initialisierung der List-Variablen
        Fahrzeugliste = New List(Of Fahrzeug)()

    End Sub


    'Methode zum Hinzufügen eines Fahrzeugs in die Liste
    Private Sub ErstelleFz()
        Fahrzeugliste.Add(New PKW("BMW", 270, 29000, 5))
        Fahrzeugliste.Add(New Flugzeug("Boing", 900, 3000000, 9999))
    End Sub

    'Methode zum Anzeigen der Fahrzeuge in der GUI
    Private Sub ZeigeFz()

        LbxFahrzeuge.Items.Clear()

        For Each fz In Fahrzeugliste
            LbxFahrzeuge.Items.Add(fz.Name)
        Next

    End Sub

    'Methode zum Löschen der Fahrzeuge
    Private Sub LöscheFz()

        If Not IsNothing(LbxFahrzeuge.SelectedItem) Then

            Fahrzeugliste.RemoveAt(LbxFahrzeuge.SelectedIndex)

        End If

    End Sub

    'Methode zum Speichern der Fahrzeug-Liste
    ''vgl auch Modul10.1_SpeichernUndLaden.btnSave_Click()
    Private Sub SpeichereFz()

        Dim writer As StreamWriter = Nothing

        Try
            writer = New StreamWriter("fahrzeuge.txt")

            'Erstellen der Settings (damit der Objekt-Typ gespeichert wird)
            Dim setting As JsonSerializerSettings = New JsonSerializerSettings()
            setting.TypeNameHandling = TypeNameHandling.Objects

            'Schleife zum Durchlaufen der FahrzeugListe
            For Each fz In Fahrzeugliste

                'Umwandlung (Serialisierung) der Fahrzeuge in Strings unter Berücksichtigung der settings
                Dim fzAlsString As String = JsonConvert.SerializeObject(fz, setting)
                'Abspeichern der Strings in der gewählten Datei
                writer.WriteLine(fzAlsString)

            Next

            MessageBox.Show("Speichern erfolgreich")
        Catch ex As Exception
            MessageBox.Show("Speichern fehlgeschlagen")
        Finally
            writer?.Close()
        End Try

    End Sub

    'Methode zum Laden der Fahrzeuge
    ''vgl. auch SpeichereFz()
    Private Sub LadeFz()

        Dim reader As StreamReader = Nothing

        Try
            reader = New StreamReader("fahrzeuge.txt")

            Dim setting As JsonSerializerSettings = New JsonSerializerSettings()
            setting.TypeNameHandling = TypeNameHandling.Objects

            Fahrzeugliste.Clear()

            While Not reader.EndOfStream

                Dim geladenesFzAlsString As String = reader.ReadLine()

                Dim geladenesFahrzeug As Fahrzeug = JsonConvert.DeserializeObject(Of Fahrzeug)(geladenesFzAlsString, setting)

                Fahrzeugliste.Add(geladenesFahrzeug)

            End While

            MessageBox.Show("Laden erfolgreich")
        Catch ex As Exception
            MessageBox.Show("Laden fehlgeschlagen")
        Finally
            reader?.Close()
        End Try

    End Sub

    'Click()-Methoden der Buttons
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ErstelleFz()
        ZeigeFz()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        LöscheFz()
        ZeigeFz()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SpeichereFz()
    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        LadeFz()
        ZeigeFz()
    End Sub
End Class
