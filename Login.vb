
Public Class Login
    Public strP As String
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        strP = "server=" & Trim(ServerTB.Text.ToString) & ";user id=" & Trim(UsernameTB.Text.ToString) & ";password=" & Trim(PwdTB.Text.ToString) & ";persistsecurityinfo=True;database=" & Trim(DBNameTB.Text.ToString)
        'MsgBox(strPTest)
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Login2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class