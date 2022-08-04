Public Class ManagerLogin
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text

        ManagerModule.LoginManager(Username, Password)
    End Sub

    Private Sub GoToPharmacistLoginButton_Click(sender As Object, e As EventArgs) Handles GoToPharmacistLoginButton.Click
        Form1.LoadPharmacistLoginPage()
    End Sub
End Class