Imports System.IO

Public Class Form1

    'Click-Methode (Aufrufen durch btnSave-Button) zum Speichern von Strings
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        'Deklaration des StreamWriters außerhalb des Try-Blocks
        Dim writer As StreamWriter = Nothing

        'Start des Try-Blocks
        Try
            'Deklaration und Initialisierung des Speichern-Dialogfensters
            Dim saveDialog As SaveFileDialog = New SaveFileDialog()

            'Setzen der Properties des Dialogfensters
            saveDialog.FileName = "textdatei.txt"
            saveDialog.InitialDirectory = "C:\"
            saveDialog.Filter = "Textdatei|*.txt|MeineDateiEndung|*.mde|Alle Dateien|*.*"

            'Anzeigen des Dialogfensters und Abfrage der Benutzerwahl
            If saveDialog.ShowDialog() = DialogResult.OK Then

                'Initialisierung des StreamWriters im Try-Block mit Übergabe des gewählten Speicherorts
                writer = New StreamWriter(saveDialog.FileName)

                'Abspeichern der Strings in der gewählten Datei
                writer.WriteLine("Dieser Satz wird gleich abgespeichert")
                writer.WriteLine(TbxInput.Text)

                'Ausgabe einer Erfolgsmeldung
                MessageBox.Show("Speichern erfolgreich")

            End If

        Catch ex As Exception

            'Ausgabe einer Misserfolgsmeldung
            MessageBox.Show("Speichern fehlgeschlagen")

        Finally

            'Schließen der Verbindung im Finally-Block, damit andere Programme Zugriff auf die Datei haben
            If Not IsNothing(writer) Then
                writer.Close()
            End If

        End Try


    End Sub

    'vgl. auch btnSave_Click()
    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click

        Dim reader As StreamReader = Nothing

        Try

            reader = New StreamReader("textdatei.txt")

            While Not reader.EndOfStream

                TbxInput.Text += reader.ReadLine() + vbNewLine

            End While

            MessageBox.Show("Laden erfolgreich")

        Catch ex As Exception
            MessageBox.Show("Laden fehlgeschlagen")

        Finally

            ' ? <- Nullprüfung der Variable reader (wenn Null, dann wird die Methode nicht aufgerufen)
            reader?.Close()

        End Try

    End Sub

End Class
