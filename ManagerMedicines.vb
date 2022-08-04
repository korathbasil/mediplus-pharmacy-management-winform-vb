Public Class ManagerMedicines
    Private Sub ManagerMedicines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedicineModule.LoadMedicinesData()
        Dim CurrentItem = 0
        For Each Medicine As MedicineModel In MedicineModule.Medicines
            MedicineDetailsListView.Items.Add(Medicine.Id)
            MedicineDetailsListView.Items(CurrentItem).SubItems.Add(Medicine.Name)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Medicine As MedicineModel In MedicineModule.Medicines
            MedicineDetailsListView.Items(CurrentItem).SubItems.Add(Medicine.Formula)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Medicine As MedicineModel In MedicineModule.Medicines
            MedicineDetailsListView.Items(CurrentItem).SubItems.Add(Medicine.Company)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Medicine As MedicineModel In MedicineModule.Medicines
            MedicineDetailsListView.Items(CurrentItem).SubItems.Add(Medicine.Price)
            CurrentItem += 1
        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ManagerPage.LoadAddMedicinePage()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.ManagerPage.LoadHomePage()
    End Sub
End Class
