Public Class Form1

    'Events, welche von GUI-Elementen unter bestimmten Umständen geworfen werden, sind spezielle Delegates.
    ''Methoden, welche durch diese Events ausgeführt werden sollen, können mittels des HANDLES-Stichworts an
    ''Events gebunden werden
    Private Sub BtnKlickMich_Click(sender As Object, e As EventArgs) Handles BtnKlickMich.Click
        'Veränderung der Hintergrundfarbe des Buttons
        BtnKlickMich.BackColor = Color.DarkGreen
    End Sub

    Private Sub BtnKlickMich_Click2(sender As Object, e As EventArgs) Handles BtnKlickMich.Click, BtnZwei.Click
        'Bewegung des Buttons um 10 Pixel nach rechts
        BtnKlickMich.Left += 10
    End Sub

    Private Sub NeuesFensterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuesFensterToolStripMenuItem.Click
        'Instanziierung eines neuen Form-Objekts (Fenster)
        Dim neuesFenster As Form1 = New Form1()
        'Aufruf des Fensters als Dialogfenster
        neuesFenster.ShowDialog()
        'Aufruf des Fensters als gleichberechtigtes Fenster
        neuesFenster.Show()

    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        'Schließen des aktuellen Fensters (wird das letzte Fenster geschlossen, beendet sich das Programm)
        Close()
        'Sofortiges Beenden des Programms
        Application.Exit()
    End Sub

    'Methode, welche durch den Timer aufgerufen wird
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BtnKlickMich.Top += 30
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled Then
            Timer1.Stop()
        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Eine Messagebox ist ein Standart-Dialogfenster, welches durch die Shared-Methode Show() aufgerufen wird
        ''Diese Methode gibt ein DialogResult wieder, über welches der angeklickte Button überprüft werden kann
        If MessageBox.Show("Geht es dir gut?", "Befindlichkeitsabfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            MessageBox.Show("Aber nicht mehr lange")
        Else
            MessageBox.Show("Passiert jedem mal")
        End If

    End Sub
End Class
