Imports Microsoft.Data.SqlClient

Public Class frmProducts

    Private Sub LoadProducts()
        Try
            Dim dt As New DataTable()
            Dim sql As String = "SELECT ProductID, ProductName, Category, Price, Quantity FROM Products WHERE 1=1"

            Dim search As String = txtSearch.Text.Trim()
            Dim cat As String = ""
            If cboCategory.SelectedIndex > 0 Then cat = cboCategory.SelectedItem.ToString()

            If search <> "" Then sql &= " AND ProductName LIKE @search"
            If cat <> "" Then sql &= " AND Category = @cat"

            Using con As SqlConnection = GetConnection()
                Using da As New SqlDataAdapter(sql, con)
                    If search <> "" Then da.SelectCommand.Parameters.AddWithValue("@search", "%" & search & "%")
                    If cat <> "" Then da.SelectCommand.Parameters.AddWithValue("@cat", cat)
                    da.Fill(dt)
                End Using
            End Using

            dgvProducts.DataSource = dt
            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = dt.Rows.Count & " product(s) found."

        Catch ex As SqlException
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Database error. Could not load products."
            MessageBox.Show("Could not connect to the database." & vbCrLf &
                        "Check that SQL Server LocalDB is running.",
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Unexpected error."
            MessageBox.Show("Something went wrong: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCategory.Items.Clear()
        cboCategory.Items.AddRange(New String() {"All", "Writing", "Paper", "Office", "Art", "Other"})
        cboCategory.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dlg As New dlgAddProduct()
        If dlg.ShowDialog() <> DialogResult.OK Then Return

        Try
            Using con As SqlConnection = GetConnection()
                con.Open()
                Dim sql As String = "INSERT INTO Products (ProductName, Category, Price, Quantity) VALUES (@name, @cat, @price, @qty)"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@name", dlg.NewName)
                    cmd.Parameters.AddWithValue("@cat", dlg.NewCategory)
                    cmd.Parameters.AddWithValue("@price", dlg.NewPrice)
                    cmd.Parameters.AddWithValue("@qty", dlg.NewQuantity)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadProducts()
            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = "Product added."

        Catch ex As SqlException
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Could not add the product."
            MessageBox.Show("Database error. The product was not saved.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvProducts.CurrentRow Is Nothing Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Select a product to delete."
            Return
        End If

        Dim id As Integer = CInt(dgvProducts.CurrentRow.Cells("ProductID").Value)
        Dim name As String = dgvProducts.CurrentRow.Cells("ProductName").Value.ToString()

        Dim answer As DialogResult = MessageBox.Show("Delete '" & name & "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If answer = DialogResult.No Then Return

        Try
            Using con As SqlConnection = GetConnection()
                con.Open()
                Using cmd As New SqlCommand("DELETE FROM Products WHERE ProductID = @id", con)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadProducts()
            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = "Product deleted."

        Catch ex As SqlException
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Could not delete the product."
            MessageBox.Show("Database error. The product was not deleted.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvProducts.CurrentRow Is Nothing Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Select a product to update."
            Return
        End If

        Try
            Dim row As DataGridViewRow = dgvProducts.CurrentRow
            Dim id As Integer = CInt(row.Cells("ProductID").Value)

            Dim dlg As New dlgAddProduct()
            dlg.LoadForEdit(row.Cells("ProductName").Value.ToString(),
                        row.Cells("Category").Value.ToString(),
                        CDec(row.Cells("Price").Value),
                        CInt(row.Cells("Quantity").Value))

            If dlg.ShowDialog() <> DialogResult.OK Then Return

            Using con As SqlConnection = GetConnection()
                con.Open()
                Dim sql As String = "UPDATE Products SET ProductName=@name, Category=@cat, Price=@price, Quantity=@qty WHERE ProductID=@id"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@name", dlg.NewName)
                    cmd.Parameters.AddWithValue("@cat", dlg.NewCategory)
                    cmd.Parameters.AddWithValue("@price", dlg.NewPrice)
                    cmd.Parameters.AddWithValue("@qty", dlg.NewQuantity)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadProducts()
            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = "Product updated."

        Catch ex As SqlException
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Could not update the product."
            MessageBox.Show("Database error. The product was not updated.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As InvalidCastException
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("A value in the selected row is in the wrong format.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadProducts()
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        LoadProducts()
    End Sub

    Private Sub btnLoadFile_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Open Product List"
        ofd.Filter = "Text files (*.txt;*.csv)|*.txt;*.csv|All files (*.*)|*.*"

        If ofd.ShowDialog() <> DialogResult.OK Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Load cancelled."
            Return
        End If

        Try
            Dim lines As String() = System.IO.File.ReadAllLines(ofd.FileName)
            Dim added As Integer = 0

            Using con As SqlConnection = GetConnection()
                con.Open()
                For Each line As String In lines
                    If line.Trim() = "" Then Continue For

                    Dim parts As String() = line.Split(","c)
                    If parts.Length < 4 Then Continue For

                    Dim price As Decimal
                    Dim qty As Integer
                    If Not Decimal.TryParse(parts(2).Trim(), price) Then Continue For
                    If Not Integer.TryParse(parts(3).Trim(), qty) Then Continue For

                    Dim sql As String = "INSERT INTO Products (ProductName, Category, Price, Quantity) VALUES (@name, @cat, @price, @qty)"
                    Using cmd As New SqlCommand(sql, con)
                        cmd.Parameters.AddWithValue("@name", parts(0).Trim())
                        cmd.Parameters.AddWithValue("@cat", parts(1).Trim())
                        cmd.Parameters.AddWithValue("@price", price)
                        cmd.Parameters.AddWithValue("@qty", qty)
                        cmd.ExecuteNonQuery()
                    End Using
                    added += 1
                Next
            End Using

            LoadProducts()
            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = added & " product(s) loaded from file."

        Catch ex As System.IO.IOException
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("The file could not be read. Close it in other programs and try again.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As SqlException
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("Database error. Products were not saved.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ctxCut_Click(sender As Object, e As EventArgs) Handles ctxCut.Click
        If txtSearch.SelectedText = "" Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Select some text to cut."
            Return
        End If
        Clipboard.SetText(txtSearch.SelectedText)
        txtSearch.SelectedText = ""
        lblStatus.ForeColor = Color.DarkGreen
        lblStatus.Text = "Cut!"
    End Sub

    Private Sub ctxCopy_Click(sender As Object, e As EventArgs) Handles ctxCopy.Click
        If txtSearch.SelectedText = "" Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Select some text to copy."
            Return
        End If
        Clipboard.SetText(txtSearch.SelectedText)
        lblStatus.ForeColor = Color.DarkGreen
        lblStatus.Text = "Copied!"
    End Sub

    Private Sub ctxPaste_Click(sender As Object, e As EventArgs) Handles ctxPaste.Click
        If Clipboard.ContainsText() AndAlso Clipboard.GetText().Trim() <> "" Then
            txtSearch.SelectedText = Clipboard.GetText().Trim()
            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = "Pasted!"
        Else
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Nothing to paste."
        End If
    End Sub

    Private Sub ctxClear_Click(sender As Object, e As EventArgs) Handles ctxClear.Click
        txtSearch.Clear()
    End Sub

    Private Sub btnCopyRow_Click(sender As Object, e As EventArgs) Handles btnCopyRow.Click
        If dgvProducts.CurrentRow Is Nothing Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Select a product to copy."
            Return
        End If

        Dim r As DataGridViewRow = dgvProducts.CurrentRow
        Dim text As String = r.Cells("ProductName").Value.ToString() & ", " &
                             r.Cells("Category").Value.ToString() & ", " &
                             CDec(r.Cells("Price").Value).ToString("N2") & ", " &
                             r.Cells("Quantity").Value.ToString()

        If text.Trim() = "" Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Nothing to copy."
            Return
        End If

        Clipboard.SetText(text)
        lblStatus.ForeColor = Color.DarkGreen
        lblStatus.Text = "Copied!"
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            txtSearch.Clear()
            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = "Search cleared."
        End If
    End Sub

    Private Sub btnDelete_MouseHover(sender As Object, e As EventArgs) Handles btnDelete.MouseHover
        lblStatus.ForeColor = Color.DarkRed
        lblStatus.Text = "Warning: this permanently deletes the selected product."
    End Sub

    Private Sub btnDelete_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        lblStatus.Text = ""
    End Sub
End Class