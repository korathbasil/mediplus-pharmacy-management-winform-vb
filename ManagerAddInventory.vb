Public Class ManagerAddInventory
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ManagerPage.LoadInventoryPage()
    End Sub

    Private Sub ManagerAddInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedicineModule.LoadMedicinesData()
        MedicineOptions.Items.Clear()

        For Each Medicine As MedicineStockModel In MedicineModule.MedicineInventory
            MedicineOptions.Items.Add(Medicine.Name)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (MedicineOptions.SelectedIndex < 0) Then
            MessageBox.Show("No medicine selected")
        Else
            MedicineModule.LoadMedicinesData()

            Dim SelectedMedicine = MedicineModule.Medicines.ElementAt(MedicineOptions.SelectedIndex)

            MedicineModule.AddStock(SelectedMedicine.Id, StockInput.Value)

        End If
    End Sub
End Class
