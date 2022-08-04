Imports MySql.Data.MySqlClient

Public Class Form1
    Public DbConnection As MySqlConnection

    Public LoggedInUserName As String

    Dim AddCompanyPage As AddCompany

    Dim AddManagerPage As AddManager
    Dim ManagerLoginPage As ManagerLogin
    Public ManagerPage As Manager

    Dim PharmacistLoginPage As PharmacistLogin
    Public PharmacistPage As Pharmacist

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDbConnection()

        LoadInitailPage()
    End Sub

    Private Sub InitDbConnection()
        Dim ConnectionString = "server=127.0.0.1;uid=root;pwd=admin;database=mediplus"
        DbConnection = New MySqlConnection With {
            .ConnectionString = ConnectionString
        }

        ' Create tables
        DbHelper.CreateTables()
    End Sub

    Private Sub LoadInitailPage()
        CompanyModule.CheckCompanyAdded()
        If CompanyModule.IsCompanyAdded Then
            UserModule.IsUsersExists()
            If UserModule.UserExists Then
                LoadPharmacistLoginPage()
            Else
                LoadAddManagerPage()
            End If
        Else
            LoadAddCompanyPage()
        End If


    End Sub

    Public Sub LoadAddCompanyPage()
        AddCompanyPage = New AddCompany With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppBodyPanel.Controls.Clear()
        AppBodyPanel.Controls.Add(AddCompanyPage)

        AddCompanyPage.Show()
    End Sub

    Public Sub LoadAddManagerPage()
        AddManagerPage = New AddManager With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppBodyPanel.Controls.Clear()
        AppBodyPanel.Controls.Add(AddManagerPage)

        AddManagerPage.Show()
    End Sub

    Public Sub LoadManagerLoginPage()
        ManagerLoginPage = New ManagerLogin With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppBodyPanel.Controls.Clear()
        AppBodyPanel.Controls.Add(ManagerLoginPage)

        ManagerLoginPage.Show()
    End Sub

    Public Sub LoadManagerPage()
        ManagerPage = New Manager With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppBodyPanel.Controls.Clear()
        AppBodyPanel.Controls.Add(ManagerPage)

        ManagerPage.Show()
    End Sub

    Public Sub LoadPharmacistLoginPage()
        PharmacistLoginPage = New PharmacistLogin With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppBodyPanel.Controls.Clear()
        AppBodyPanel.Controls.Add(PharmacistLoginPage)

        PharmacistLoginPage.Show()
    End Sub

    Public Sub LoadPharmacistPage()
        PharmacistPage = New Pharmacist With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppBodyPanel.Controls.Clear()
        AppBodyPanel.Controls.Add(PharmacistPage)

        PharmacistPage.Show()
    End Sub

End Class
