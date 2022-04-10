Public Class login

    Public Structure User
        Public username As String
        Public group As String
        Public balance As Integer
    End Structure
    Dim root As User
    Dim userx As User
    Dim usery As User

    Public Property usersync As String
    Public Property groupsync As String

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        root.username = "root"
        root.group = "root"
        root.balance = 1000000000
        userx.username = "Carvin"
        userx.group = "Carvin"
        userx.balance = 69000

        usery.username = "okana"
        usery.group = "okana-keren"
        usery.balance = 12243299
        ' Dim usersync, groupsync As New Form1
        If TextBox2.Text = root.username And TextBox1.Text = root.group Then
            Form1.ShowDialog()

        End If
        usersync = TextBox2.Text
        groupsync = TextBox1.Text
    End Sub

End Class