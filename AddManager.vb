Public Class AddManager
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Validation.IsValidName(NameInput.Text)
        If (Validation.IsNameInvalid) Then
            MessageBox.Show("Name cannot conatin numeric characters")
            Exit Sub
        Else
        End If
        Dim Name = NameInput.Text
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text

        ManagerModule.AddManager(Name, Username, Password)
    End Sub
End Class