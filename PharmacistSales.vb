Imports System.Drawing.Printing

Public Class PharmacistSales
    Dim ItemsInBill As New List(Of BillItem)
    Dim Total As Integer

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim PaperHeight = 150

    Private Sub PharmacistSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMedicineDataIntoComboBox()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.PharmacistPage.LoadHomePage()
    End Sub

    Private Sub AddToBillButton_Click(sender As Object, e As EventArgs) Handles AddToBillButton.Click
        If (QuantityInput.Value <= 0) Then
            MessageBox.Show("Invalid quantity")
        ElseIf (MedicineSelector.SelectedIndex < 0) Then
            MessageBox.Show("Please select a medicine")
        Else
            Dim NewItem = New BillItem With {
                .Id = MedicineModule.Medicines.ElementAt(MedicineSelector.SelectedIndex).Id,
                .Name = MedicineModule.Medicines.ElementAt(MedicineSelector.SelectedIndex).Name,
                .Price = MedicineModule.Medicines.ElementAt(MedicineSelector.SelectedIndex).Price,
                .Quantity = QuantityInput.Value,
                .Amount = MedicineModule.Medicines.ElementAt(MedicineSelector.SelectedIndex).Price * QuantityInput.Value
            }

            Dim AlreadyExists = False
            Dim Index As Integer
            For Each Item As BillItem In ItemsInBill
                If (Item.Id = NewItem.Id) Then
                    AlreadyExists = True
                    Index = ItemsInBill.IndexOf(Item)
                End If
            Next

            If (AlreadyExists) Then

                Dim Quantity = ItemsInBill.ElementAt(Index).Quantity + QuantityInput.Value
                MedicineModule.GetStockById(NewItem.Id)
                If (MedicineModule.MedicineStock < Quantity) Then
                    MessageBox.Show("Only " + MedicineModule.MedicineStock.ToString() + " available")
                Else
                    ItemsInBill.ElementAt(Index).Quantity = Quantity
                    ItemsInBill.ElementAt(Index).Amount = ItemsInBill.ElementAt(Index).Amount + QuantityInput.Value * ItemsInBill.ElementAt(Index).Price
                End If
            Else
                MedicineModule.GetStockById(NewItem.Id)
                If (MedicineModule.MedicineStock < NewItem.Quantity) Then
                    MessageBox.Show("Only " + MedicineModule.MedicineStock.ToString() + " available")
                Else
                    ItemsInBill.Add(NewItem)
                End If
            End If
            RenderListInGridView()
            ResetForm()
        End If
    End Sub

    Private Sub CheckoutBill()

        If (ItemsInBill.Count < 1) Then
            MessageBox.Show("Empty Bill")
        Else
            For Each Item As BillItem In ItemsInBill
                MedicineModule.AdjustInventory(Item.Id, Item.Quantity)
            Next

            SaleModule.CheckoutSale(Total)
            PrintBill()
            ResetForm()
            BillView.Rows.Clear()
            Total = 0
            ItemsInBill.Clear()
            TotalAmountLabel.Text = 0
        End If
    End Sub

    Private Sub LoadMedicineDataIntoComboBox()
        MedicineModule.LoadMedicinesData()

        For Each Medicine As MedicineModel In MedicineModule.Medicines
            MedicineSelector.Items.Add(Medicine.Name)
        Next
    End Sub

    Private Sub RenderListInGridView()
        BillView.Rows.Clear()
        Total = 0
        For Each Item As BillItem In ItemsInBill
            BillView.Rows.Add(Item.Name, Item.Price, Item.Quantity, Item.Amount)

            Total = Total + Item.Amount
        Next

        TotalAmountLabel.Text = Total
    End Sub

    Private Sub ResetForm()
        MedicineSelector.SelectedIndex = -1
        QuantityInput.Value = 1
    End Sub

    Private Sub CheckoutButton_Click(sender As Object, e As EventArgs) Handles CheckoutButton.Click
        CheckoutBill()
    End Sub

    Private Sub ResetBillButtton_Click(sender As Object, e As EventArgs) Handles ResetBillButtton.Click
        ResetForm()
        BillView.Rows.Clear()
        Total = 0
        ItemsInBill.Clear()
        TotalAmountLabel.Text = 0
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim PageSetup As New PageSettings With {
        .PaperSize = New PaperSize("Custom", 250, PaperHeight)
        }

        PD.DefaultPageSettings = PageSetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim FNormal As New Font("Calibri", 10, FontStyle.Regular)
        Dim FSmall As New Font("Calibri", 8, FontStyle.Regular)
        Dim FBold As New Font("Calibri", 10, FontStyle.Bold)
        Dim FBoldBig As New Font("Comic Sans MS", 12, FontStyle.Bold)

        Dim LeftMargin = PD.DefaultPageSettings.Margins.Left
        Dim CenterMargin = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim RightMargin = PD.DefaultPageSettings.PaperSize.Width

        Dim RightAlign = New StringFormat With {
            .Alignment = StringAlignment.Far
        }
        Dim CenterAlign = New StringFormat With {
            .Alignment = StringAlignment.Center
        }

        Dim LeftAlign = New StringFormat With {
            .Alignment = StringAlignment.Near
        }

        Dim LineBraek = "----------------------------------------------------------------"

        ' Writing string

        e.Graphics.DrawString("Mediplus", FBoldBig, Brushes.Black, CenterMargin, 10, CenterAlign)
        e.Graphics.DrawString(Form1.PharmacistPage.NameOfCompany + ", GST :" + Form1.PharmacistPage.CompanyGSTNo, FNormal, Brushes.Black, CenterMargin, 27, CenterAlign)
        e.Graphics.DrawString(Date.Now().ToString("dd-MM-yy | HH:mm"), FSmall, Brushes.Black, 10, 40, LeftAlign)
        e.Graphics.DrawString(LineBraek, FSmall, Brushes.Black, 10, 50, LeftAlign)
        e.Graphics.DrawString("#", FSmall, Brushes.Black, 20, 57, CenterAlign)
        e.Graphics.DrawString("Item", FSmall, Brushes.Black, 35, 57, LeftAlign)
        e.Graphics.DrawString("Price", FSmall, Brushes.Black, RightMargin - 100, 57, CenterAlign)
        e.Graphics.DrawString("Qty", FSmall, Brushes.Black, RightMargin - 70, 57, CenterAlign)
        e.Graphics.DrawString("Amount", FSmall, Brushes.Black, RightMargin - 35, 57, CenterAlign)
        e.Graphics.DrawString(LineBraek, FSmall, Brushes.Black, 10, 64, LeftAlign)

        Dim BaseLine = 63
        Dim ItemCount = 1
        For Each Item As BillItem In ItemsInBill
            e.Graphics.DrawString(ItemCount, FNormal, Brushes.Black, 20, BaseLine + 12, CenterAlign)
            e.Graphics.DrawString(Item.Name, FNormal, Brushes.Black, 35, BaseLine + 12, LeftAlign)
            e.Graphics.DrawString(Item.Price, FNormal, Brushes.Black, RightMargin - 100, BaseLine + 12, CenterAlign)
            e.Graphics.DrawString(Item.Quantity, FNormal, Brushes.Black, RightMargin - 70, BaseLine + 12, CenterAlign)
            e.Graphics.DrawString(Item.Quantity, FNormal, Brushes.Black, RightMargin - 20, BaseLine + 12, RightAlign)

            BaseLine += 12
            ItemCount += 1
        Next

        BaseLine += 11
        e.Graphics.DrawString(LineBraek, FSmall, Brushes.Black, 10, BaseLine, LeftAlign)

        e.Graphics.DrawString("Total (Rs.) :", FBold, Brushes.Black, RightMargin - 50, BaseLine + 10, RightAlign)
        e.Graphics.DrawString(Total, FBold, Brushes.Black, RightMargin - 20, BaseLine + 10, RightAlign)

        e.Graphics.DrawString("Thank you, have a nice day", FSmall, Brushes.Black, CenterMargin, BaseLine + 30, CenterAlign)

    End Sub

    Private Sub CalculatePaperHeight()
        Dim Height = 63
        For Each Item As BillItem In ItemsInBill
            Height += 12
        Next

        Height += 70

        PaperHeight = Height
    End Sub

    Private Sub PrintBill()
        CalculatePaperHeight()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub
End Class

Class BillItem
    Public Id As Integer
    Public Name As String
    Public Price As Integer
    Public Quantity As Integer
    Public Amount As Integer
End Class