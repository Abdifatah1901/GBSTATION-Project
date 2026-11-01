Public Class frmSales
    Private Const TAX_RATE As Decimal = 0.16D
    Private itemNames As New List(Of String)
    Private itemTotals As New List(Of Decimal)
    Private Function CalculateTotal(price As Decimal, qty As Integer, discountPct As Decimal) As Decimal
        Dim subtotal As Decimal = price * qty
        Dim discount As Decimal = subtotal * discountPct / 100
        Dim taxable As Decimal = subtotal - discount
        Dim tax As Decimal = taxable * TAX_RATE
        Return taxable + tax
    End Function
    Private Sub ClearForm()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtDiscount.Clear()
        lblSubtotal.Text = "Subtotal: 0.00"
        lblDiscountAmt.Text = "Discount: 0.00"
        lblTax.Text = "Tax: 0.00"
        lblTotal.Text = "Total: 0.00"
        lblStatus.Text = ""
        txtPrice.Focus()
    End Sub
    Private Sub RefreshBill()
        lstItems.Items.Clear()
        Dim grand As Decimal = 0

        For i As Integer = 0 To itemNames.Count - 1
            lstItems.Items.Add((i + 1) & ". " & itemNames(i) & "  -  " & itemTotals(i).ToString("N2"))
            grand += itemTotals(i)
        Next

        lblGrandTotal.Text = "Grand Total: " & grand.ToString("N2")
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()

    End Sub
    Private Function AveragePerItem(total As Decimal, qty As Integer) As Decimal
        Return total / qty
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim price As Decimal = Decimal.Parse(txtPrice.Text.Trim())
            Dim qty As Integer = Integer.Parse(txtQuantity.Text.Trim())

            If txtDiscount.Text.Trim() = "" Then txtDiscount.Text = "0"
            Dim discountPct As Decimal = Decimal.Parse(txtDiscount.Text.Trim())

            If price <= 0 Then
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "Enter a valid price."
                Return
            End If
            If qty < 0 Then
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "Quantity cannot be negative."
                Return
            End If
            If discountPct < 0 OrElse discountPct > 100 Then
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "Discount must be 0 to 100."
                Return
            End If

            Dim subtotal As Decimal = price * qty
            Dim discount As Decimal = subtotal * discountPct / 100
            Dim tax As Decimal = (subtotal - discount) * TAX_RATE
            Dim total As Decimal = CalculateTotal(price, qty, discountPct)

            lblSubtotal.Text = "Subtotal: " & subtotal.ToString("N2")
            lblDiscountAmt.Text = "Discount: " & discount.ToString("N2")
            lblTax.Text = "Tax: " & tax.ToString("N2")
            lblTotal.Text = "Total: " & total.ToString("N2")

            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = "Average per item: " & AveragePerItem(total, qty).ToString("N2")

        Catch ex As FormatException
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Please enter numbers only."
        Catch ex As OverflowException
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "That number is too large."
        Catch ex As DivideByZeroException
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Quantity cannot be zero."
        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Unexpected error: " & ex.Message
        Finally
            txtPrice.Focus()
        End Try
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim name As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtProduct.Text.Trim().ToLower())
        If name = "" Then
            lblStatus.Text = "Enter a product name."
            txtProduct.Focus()
            Return
        End If

        btnCalculate.PerformClick()
        If lblStatus.ForeColor = Color.Red Then Return

        If Integer.Parse(txtQuantity.Text) <= 0 Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Quantity must be at least 1."
            Return
        End If

        Dim lineTotal As Decimal = CalculateTotal(Decimal.Parse(txtPrice.Text), Integer.Parse(txtQuantity.Text), Decimal.Parse(txtDiscount.Text))

        itemNames.Add(name & " x" & txtQuantity.Text)
        itemTotals.Add(lineTotal)
        RefreshBill()

        txtProduct.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtDiscount.Clear()
        txtProduct.Focus()
    End Sub

    Private Sub btnNewSale_Click(sender As Object, e As EventArgs) Handles btnNewSale.Click
        If itemNames.Count > 0 Then
            Dim answer As DialogResult = MessageBox.Show("Clear the current bill?", "New Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = DialogResult.No Then Return
        End If

        itemNames.Clear()
        itemTotals.Clear()
        RefreshBill()
        ClearForm()
        txtProduct.Clear()
        txtProduct.Focus()
    End Sub

    Private Sub btnSaveReceipt_Click(sender As Object, e As EventArgs) Handles btnSaveReceipt.Click
        If itemNames.Count = 0 Then
            lblStatus.Text = "Add at least one item before saving."
            Return
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Title = "Save Receipt"
        sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        sfd.FileName = "Receipt_" & DateTime.Now.ToString("yyyyMMdd_HHmm") & ".txt"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim lines As New List(Of String)
            lines.Add("GBStation Stationery Supplies")
            lines.Add("Date: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
            lines.Add("--------------------------------")

            For i As Integer = 0 To itemNames.Count - 1
                lines.Add(itemNames(i) & "  -  " & itemTotals(i).ToString("N2"))
            Next

            lines.Add("--------------------------------")
            lines.Add(lblGrandTotal.Text)
            lines.Add("Thank you for shopping with us!")

            System.IO.File.WriteAllLines(sfd.FileName, lines)
            lblStatus.Text = "Receipt saved."
        Else
            lblStatus.Text = "Save cancelled."
        End If
    End Sub
End Class