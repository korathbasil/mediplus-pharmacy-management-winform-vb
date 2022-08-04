Public Class ManagerUsers
    Private Sub ManagerUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserModule.LoadUserData()
        Dim CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            UsersListView.Items.Add(User.Id)
            UsersListView.Items(CurrentItem).SubItems.Add(User.Name)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            UsersListView.Items(CurrentItem).SubItems.Add(User.Username)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            If User.IsManager Then
                UsersListView.Items(CurrentItem).SubItems.Add("Manager")
            Else
                UsersListView.Items(CurrentItem).SubItems.Add("Pharmacist")
            End If
            CurrentItem += 1
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.ManagerPage.LoadHomePage()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ManagerPage.LoadAddUserPage()
    End Sub
End Class
