Public Class ManagerAddMedicine
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ManagerPage.LoadMedicinesPage()
    End Sub

    Private Sub AddMedicineButton_Click(sender As Object, e As EventArgs) Handles AddMedicineButton.Click
        Dim Name = NameInput.Text
        Dim Formula = FormulaInput.Text
        Dim Company = CompanyInput.Text
        Dim Price = PriceInput.Value

        If Price <= 0 Then
            MessageBox.Show("Invalid price")
        Else
            MedicineModule.AddNewMedicine(Name, Formula, Company, Price)
        End If
    End Sub
End Class
