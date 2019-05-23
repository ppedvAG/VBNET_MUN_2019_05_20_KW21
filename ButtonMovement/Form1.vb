Public Class Form1
    Private _btnLeftStart As Integer
    Public Property BtnLeftStart() As Integer
        Get
            Return _btnLeftStart
        End Get
        Set(ByVal value As Integer)
            _btnLeftStart = value
        End Set
    End Property

    Private _btnRightStart As Integer
    Public Property BtnRightStart() As Integer
        Get
            Return _btnRightStart
        End Get
        Set(ByVal value As Integer)
            _btnRightStart = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        BtnLeftStart = BtnLeft.Left
        BtnRightStart = BtnRight.Left

    End Sub

    Private Sub BtnLeft_Click(sender As Object, e As EventArgs) Handles BtnLeft.Click, BtnStart.Click
        BtnLeft.Left += 10
    End Sub

    Private Sub BtnRight_Click(sender As Object, e As EventArgs) Handles BtnRight.Click, BtnStart.Click
        BtnRight.Left -= 10
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If BtnLeft.Right > BtnRight.Left Then
            If MessageBox.Show("Die Buttons berühren sich!" + vbNewLine + "Zurücksetzen?", "Berührung!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = DialogResult.Yes Then
                BtnLeft.Left = BtnLeftStart
                BtnRight.Left = BtnRightStart
            End If
        End If
    End Sub
End Class
