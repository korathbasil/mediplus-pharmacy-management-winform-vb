Imports MySql.Data.MySqlClient

Module CompanyModule
    Public IsCompanyAdded = False

    Public CompanyName As String
    Public CompanyRegNo As String
    Public CompanyGSTNo As String
    Public Sub CheckCompanyAdded()
        Dim Cmd = New MySqlCommand("select * from company", Form1.DbConnection)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()

            If Reader.HasRows() Then
                IsCompanyAdded = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Sub AddCompany(Name As String, RegNum As String, GSTNum As String, Addr1 As String, Addr2 As String, PIN As String)
        Dim Sql = "insert into company (name, reg_number, gst_number, addr1, addr2, pin) values(@Name, @RegNum, @GSTNum, @Addr1, @Addr2, @PIN)"
        Try
            Form1.DbConnection.Open()
            Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)

            Cmd.Parameters.AddWithValue("@Name", Name)
            Cmd.Parameters.AddWithValue("@RegNum", RegNum)
            Cmd.Parameters.AddWithValue("@GSTNum", GSTNum)
            Cmd.Parameters.AddWithValue("@Addr1", Addr1)
            Cmd.Parameters.AddWithValue("@Addr2", Addr2)
            Cmd.Parameters.AddWithValue("@PIN", PIN)

            Cmd.ExecuteNonQuery()
            Form1.DbConnection.Close()

            ' Navigate to add manager page
            Form1.LoadAddManagerPage()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Sub GetCompanyData()
        Dim Cmd = New MySqlCommand("select * from company", Form1.DbConnection)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()

            If Reader.HasRows() Then
                While Reader.Read()
                    CompanyName = Reader("name")
                    CompanyRegNo = Reader("reg_number")
                    CompanyGSTNo = Reader("gst_number")
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub
End Module
