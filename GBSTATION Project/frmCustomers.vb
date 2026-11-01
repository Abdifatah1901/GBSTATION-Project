Imports Microsoft.Data.SqlClient

Public Class frmCustomers

    Private Sub LoadCustomers()
        Try
            Dim dt As New DataTable()
            Dim sql As String = "SELECT CustomerID, CustomerName, Phone, Email FROM Customers"
            Dim search As String = txtSearch.Text.Trim()

            If search <> "" Then sql &= " WHERE CustomerName LIKE @s OR Phone LIKE @s"

            Using con As SqlConnection = GetConnection()
                Using da As New SqlDataAdapter(sql, con)
                    If search <> "" Then da.SelectCommand.Parameters.AddWithValue("@s", "%" & search & "%")
                    da.Fill(dt)
                End Using
            End Using

            dgvCustomers.DataSource = dt
            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = dt.Rows.Count & " customer(s) found."

        Catch ex As SqlException
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Database error. Could not load customers."
            MessageBox.Show("Could not connect to the database." & vbCrLf &
                        "Check that SQL Server LocalDB is running.",
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("Something went wrong: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadCustomers()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dlg As New dlgAddCustomer()
        If dlg.ShowDialog() <> DialogResult.OK Then Return

        Try
            Using con As SqlConnection = GetConnection()
                con.Open()
                Dim sql As String = "INSERT INTO Customers (CustomerName, Phone, Email) VALUES (@n, @p, @e)"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@n", dlg.NewName)
                    cmd.Parameters.AddWithValue("@p", dlg.NewPhone)
                    cmd.Parameters.AddWithValue("@e", dlg.NewEmail)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadCustomers()
            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = "Customer added."

        Catch ex As SqlException
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Could not add the customer."
            MessageBox.Show("Database error. The customer was not saved.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvCustomers.CurrentRow Is Nothing Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Select a customer to update."
            Return
        End If

        Try
            Dim row As DataGridViewRow = dgvCustomers.CurrentRow
            Dim id As Integer = CInt(row.Cells("CustomerID").Value)

            Dim dlg As New dlgAddCustomer()
            dlg.LoadForEdit(row.Cells("CustomerName").Value.ToString(),
                        row.Cells("Phone").Value.ToString(),
                        row.Cells("Email").Value.ToString())

            If dlg.ShowDialog() <> DialogResult.OK Then Return

            Using con As SqlConnection = GetConnection()
                con.Open()
                Dim sql As String = "UPDATE Customers SET CustomerName=@n, Phone=@p, Email=@e WHERE CustomerID=@id"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@n", dlg.NewName)
                    cmd.Parameters.AddWithValue("@p", dlg.NewPhone)
                    cmd.Parameters.AddWithValue("@e", dlg.NewEmail)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadCustomers()
            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = "Customer updated."

        Catch ex As SqlException
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Could not update the customer."
            MessageBox.Show("Database error. The customer was not updated.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCustomers.CurrentRow Is Nothing Then
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Select a customer to delete."
            Return
        End If

        Dim id As Integer = CInt(dgvCustomers.CurrentRow.Cells("CustomerID").Value)
        Dim nm As String = dgvCustomers.CurrentRow.Cells("CustomerName").Value.ToString()

        Dim answer As DialogResult = MessageBox.Show("Delete '" & nm & "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If answer = DialogResult.No Then Return

        Try
            Using con As SqlConnection = GetConnection()
                con.Open()
                Using cmd As New SqlCommand("DELETE FROM Customers WHERE CustomerID = @id", con)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadCustomers()
            lblStatus.ForeColor = Color.DarkGreen
            lblStatus.Text = "Customer deleted."

        Catch ex As SqlException
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Could not delete the customer."
            MessageBox.Show("Database error. The customer was not deleted.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class