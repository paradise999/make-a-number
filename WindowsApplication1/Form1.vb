Public Class Form1
    Dim Limit1 As Integer
    Dim Limit2 As Integer
    Dim Number As Integer = 0

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Limit1 = 0
        Limit2 = 10
        Label1.Text = Int(Rnd() * (Limit2 + 1))
        Label2.Text = "Я угадал?"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Number = Int(Label1.Text)
        If Number = Limit1 Then
            Label2.Text = "Ты же говорил что больше.
Так нельзя.
Жми снова старт"
        Else
            Limit2 = Number - 1
            Label1.Text = Int(Rnd() * (Limit2 - Limit1 + 1) + Limit1)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Number = Int(Label1.Text)
        If Number = Limit2 Then
            Label2.Text = "Ты же говорил что меньше.
Так нельзя.
Жми снова старт."
        Else
            Limit1 = Number + 1
            Label1.Text = Int(Rnd() * (Limit2 - Limit1 + 1) + Limit1)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "Я выиграл"
    End Sub
End Class
