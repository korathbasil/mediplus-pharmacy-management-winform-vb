Public Class Pharmacist
    Public NameOfCompany As String
    Public CompanyRegNo As String
    Public CompanyGSTNo As String

    Dim Homepage As PharmacistHome
    Dim SalesPage As PharmacistSales
    Private Sub Pharmacist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CompanyModule.GetCompanyData()
        NameOfCompany = CompanyModule.CompanyName
        CompanyRegNo = CompanyModule.CompanyRegNo
        CompanyGSTNo = CompanyModule.CompanyGSTNo
        LoadHomePage()
    End Sub

    Public Sub LoadHomePage()
        Homepage = New PharmacistHome

        PharmacistBodyPanel.Controls.Clear()
        PharmacistBodyPanel.Controls.Add(Homepage)
    End Sub

    Public Sub LoadSalesPage()
        SalesPage = New PharmacistSales

        PharmacistBodyPanel.Controls.Clear()
        PharmacistBodyPanel.Controls.Add(SalesPage)
    End Sub
End Class