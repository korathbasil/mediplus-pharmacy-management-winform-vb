Public Class ManagerHome
    Private Sub ManagerHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedicineModule.LoadMedicinesData()
        MedicineCountLabel.Text = MedicineModule.Medicines.Count

        MedicineModule.LoadOutOfStockMedicinesData()
        OutOfStockMedicineCountLabel.Text = MedicineModule.OutOfStockMedicines.Count

        UserModule.LoadUserData()
        UserCountLabel.Text = UserModule.Users.Count

        UserNameLabel.Text = Form1.LoggedInUserName
        CompanyNameLabel.Text = Form1.ManagerPage.NameOfCompany
        CompanyRegNoLabel.Text = Form1.ManagerPage.CompanyRegNo
        CompanyGSTNoLabel.Text = Form1.ManagerPage.CompanyGSTNo
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ManagerPage.LoadMedicinesPage()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.ManagerPage.LoadInventoryPage()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.ManagerPage.LoadUsersPage()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.LoggedInUserName = ""
        Form1.LoadPharmacistLoginPage()
    End Sub
End Class
