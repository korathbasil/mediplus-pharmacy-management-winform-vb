Public Class AddCompany
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form1.LoadAddManagerPage()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name = NameInput.Text
        Dim RegNum = RegNumInput.Text
        Dim GSTNum = GSTNumInput.Text
        Dim Addr1 = Addr1Input.Text
        Dim Addr2 = Addr2Input.Text
        Dim PIN = PINInput.Text

        CompanyModule.AddCompany(Name, RegNum, GSTNum, Addr1, Addr2, PIN)
    End Sub
End Class