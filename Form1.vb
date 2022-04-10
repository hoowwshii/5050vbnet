Public Class Form1
    Dim univ As Integer

    ' Public Property usersync As String
    ' Public Property groupsync As String
    Dim loops As Integer
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
        Dim balance, bet As Integer
        balance = 10000000
        bet = TextBox2.Text
        Dim rng As System.Random = New System.Random()
        Dim number As Integer
        number = rng.Next(0, 2)

        If balance < bet Then
            MessageBox.Show("Maaf kamu miskin")
        End If
        If number = univ Then
            TextBox1.Text = "Damn, menang"
            loops = 0
        End If
        If number = univ Then
            TextBox1.Text = "lol kalah"
            loops = 1
        End If
        bet = TextBox2.Text
        While loops = 0
            balance = balance + (bet * 2%)
        End While
        While loops = 1
            balance = balance - bet
        End While

        MessageBox.Show(balance)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.ReadOnly = True

    End Sub

    Public Sub Label2_Click(sender As Object, e As EventArgs)
        '  Dim name, group As New login
        '  name.usersync = Label2.Text
        'Label2.Text = name.usersync & "@" & group.groupsync
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
