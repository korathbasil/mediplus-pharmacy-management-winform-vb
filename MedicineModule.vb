Imports MySql.Data.MySqlClient

Module MedicineModule
    Public MedicineInventory As New List(Of MedicineStockModel)
    Public Medicines As New List(Of MedicineModel)

    Public MedicineStock As Integer

    Public OutOfStockMedicines As New List(Of MedicineModel)


    Public Sub AddNewMedicine(name As String, formula As String, company As String, price As Integer)
        Dim Sql = "insert into medicines (name, formula, company, price, stock) value (@Name, @Formula, @Company, @Price, 0)"
        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Name", name)
        Cmd.Parameters.AddWithValue("@Formula", formula)
        Cmd.Parameters.AddWithValue("@Company", company)
        Cmd.Parameters.AddWithValue("@Price", price)
        Try
            Form1.DbConnection.Open()
            Cmd.ExecuteNonQuery()
            Form1.DbConnection.Close()

            ' Navigate to medicines page
            Form1.ManagerPage.LoadMedicinesPage()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub LoadInventoryData()
        MedicineInventory.Clear()
        Dim Cmd = New MySqlCommand("select * from medicines", Form1.DbConnection)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()

            If Reader.HasRows Then
                While Reader.Read()
                    MedicineInventory.Add(New MedicineStockModel With {
                        .Id = Reader("id"),
                        .Name = Reader("name"),
                        .Stock = Reader("stock")
                    })
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub LoadMedicinesData()
        Medicines.Clear()
        Dim Cmd = New MySqlCommand("select * from medicines", Form1.DbConnection)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()

            If Reader.HasRows Then
                While Reader.Read()
                    Medicines.Add(New MedicineModel With {
                        .Id = Reader("id"),
                        .Name = Reader("name"),
                        .Formula = Reader("formula"),
                        .Company = Reader("company"),
                        .Price = Reader("price")
                    })
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub LoadOutOfStockMedicinesData()
        OutOfStockMedicines.Clear()
        Dim Cmd = New MySqlCommand("select * from medicines  where stock = 0", Form1.DbConnection)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()

            If Reader.HasRows Then
                While Reader.Read()
                    OutOfStockMedicines.Add(New MedicineModel With {
                        .Id = Reader("id"),
                        .Name = Reader("name"),
                        .Formula = Reader("formula"),
                        .Company = Reader("company"),
                        .Price = Reader("price")
                    })
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub GetStockById(Id As Integer)
        Dim Cmd = New MySqlCommand("select (stock) from medicines where id = @Id", Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Id", Id)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()

            Reader.Read()
            MedicineStock = Reader("stock")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub AddStock(MedicineId As Integer, Stock As Integer)
        Dim Cmd = New MySqlCommand("update medicines set stock = (@Stock + stock)  where id = @Id", Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Stock", Stock)
        Cmd.Parameters.AddWithValue("@Id", MedicineId)

        Try
            Form1.DbConnection.Open()
            Cmd.ExecuteNonQuery()
            Form1.DbConnection.Close()

            ' Navigate to Inventory page
            Form1.ManagerPage.LoadInventoryPage()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub AdjustInventory(Id As Integer, Quantity As Integer)
        Dim Cmd = New MySqlCommand("update medicines set stock = (stock - @Quantity) where id = @Id", Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Id", Id)
        Cmd.Parameters.AddWithValue("@Quantity", Quantity)

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
End Module


Class MedicineStockModel
    Public Id As Integer
    Public Name As String
    Public Stock As Integer
End Class

Class MedicineModel
    Public Id As Integer
    Public Name As String
    Public Formula As String
    Public Company As String
    Public Price As Integer
End Class