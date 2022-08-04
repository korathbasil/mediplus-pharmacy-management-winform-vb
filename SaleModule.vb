Imports MySql.Data.MySqlClient

Module SaleModule
    Public TodaySalesCount As Integer
    Public TodaySalesTotal As Integer
    Public Sub CheckoutSale(total As Integer)
        Dim Cmd = New MySqlCommand("insert into sales (amount) values (@Total)", Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Total", total)

        Try
            Form1.DbConnection.Open()
            Cmd.ExecuteNonQuery()
            Form1.DbConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub GetSalesReport()
        Dim Sql = "select count(id) as SalesCount, coalesce(sum(amount), 0) as TotalSales from sales where date(date) = curdate()"
        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()
            Reader.Read()

            TodaySalesCount = Reader("SalesCount")
            TodaySalesTotal = Reader("TotalSales")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

End Module
