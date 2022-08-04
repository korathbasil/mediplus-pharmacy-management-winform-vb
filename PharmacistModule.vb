Imports MySql.Data.MySqlClient

Module PharmacistModule
    Sub PharmacistLogin(Username As String, Password As String)
        Dim Sql = "select name, username, password, is_manager from users where username=@Username and is_manager=false"
        Try
            Form1.DbConnection.Open()
            Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
            Cmd.Parameters.AddWithValue("@Username", Username)

            Dim Reader = Cmd.ExecuteReader
            If Reader.Read() = True Then
                If Reader("password") = Password Then
                    Form1.LoggedInUserName = Reader("Name")
                    Form1.DbConnection.Close()

                    Form1.LoadPharmacistPage()
                Else
                    MessageBox.Show("Incorrect password")
                End If
            Else
                MessageBox.Show("Invalid username")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub
End Module
