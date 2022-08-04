Public Class PharmacistHome
    Private Sub PharmacistHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SaleModule.GetSalesReport()
        SalesCountLabel.Text = SaleModule.TodaySalesCount
        TotalSale.Text = SaleModule.TodaySalesTotal

        UserNameLabel.Text = Form1.LoggedInUserName
        CompanyNameLabel.Text = Form1.PharmacistPage.NameOfCompany
        CompanyRegNoLabel.Text = Form1.PharmacistPage.CompanyRegNo
        CompanyGSTNoLabel.Text = Form1.PharmacistPage.CompanyGSTNo
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.PharmacistPage.LoadSalesPage()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.LoggedInUserName = ""
        Form1.LoadPharmacistLoginPage()
    End Sub
End Class
