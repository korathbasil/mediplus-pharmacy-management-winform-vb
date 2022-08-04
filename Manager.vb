Public Class Manager
    Public NameOfCompany As String
    Public CompanyRegNo As String
    Public CompanyGSTNo As String

    Dim HomePage As ManagerHome

    Dim MedicinesPage As ManagerMedicines
    Dim AddMedicinePage As ManagerAddMedicine

    Dim InventoryPage As ManagerInventory
    Dim AddInventoryPage As ManagerAddInventory

    Dim UsersPage As ManagerUsers
    Dim AddUserPage As ManagerAddUser
    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CompanyModule.GetCompanyData()
        NameOfCompany = CompanyModule.CompanyName
        CompanyRegNo = CompanyModule.CompanyRegNo
        CompanyGSTNo = CompanyModule.CompanyGSTNo

        LoadHomePage()
    End Sub

    Public Sub LoadHomePage()
        HomePage = New ManagerHome

        ManagerBodyPanel.Controls.Clear()
        ManagerBodyPanel.Controls.Add(HomePage)
    End Sub

    Public Sub LoadMedicinesPage()
        MedicinesPage = New ManagerMedicines

        ManagerBodyPanel.Controls.Clear()
        ManagerBodyPanel.Controls.Add(MedicinesPage)
    End Sub

    Public Sub LoadAddMedicinePage()
        AddMedicinePage = New ManagerAddMedicine

        ManagerBodyPanel.Controls.Clear()
        ManagerBodyPanel.Controls.Add(AddMedicinePage)
    End Sub

    Public Sub LoadInventoryPage()
        InventoryPage = New ManagerInventory

        ManagerBodyPanel.Controls.Clear()
        ManagerBodyPanel.Controls.Add(InventoryPage)
    End Sub

    Public Sub LoadAddInventoryPage()
        AddInventoryPage = New ManagerAddInventory

        ManagerBodyPanel.Controls.Clear()
        ManagerBodyPanel.Controls.Add(AddInventoryPage)
    End Sub

    Public Sub LoadUsersPage()
        UsersPage = New ManagerUsers

        ManagerBodyPanel.Controls.Clear()
        ManagerBodyPanel.Controls.Add(UsersPage)
    End Sub

    Public Sub LoadAddUserPage()
        AddUserPage = New ManagerAddUser

        ManagerBodyPanel.Controls.Clear()
        ManagerBodyPanel.Controls.Add(AddUserPage)
    End Sub
End Class