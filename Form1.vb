Public Class Form1
    Dim univ As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '   Dim rng As System.Random = New System.Random()
        ' Dim number As Integer
        ' //number = rng.Next(0, 2 + 0)
        '//MesageBox.Show(number)

        Label1.Text = "Your Selection = ++"
        univ = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "Your Selection = --"
        univ = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' MessageBox.Show({"Ap ykin? Pilihan sekarang = "} & Label1.Text, MessageBoxButtons.YesNo)

        Dim rng As System.Random = New System.Random()
        Dim number As Integer
        number = rng.Next(0, 2 + 0)
        If number = univ Then
            TextBox1.Text = "Damn, menang"
        End If
        If number <> univ Then
            TextBox1.Text = "lol kalah"
        End If
    End Sub
End Class
