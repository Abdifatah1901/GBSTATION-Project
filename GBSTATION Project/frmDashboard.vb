Public Class frmDashboard
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New frmlogin()
        login.Show()
        Me.Close()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show("GBStation Stationery Supplies System" & vbCrLf & "Version 1.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Dim f As New frmProducts()
        f.ShowDialog()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Dim f As New frmCustomers
        f.ShowDialog()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Dim f As New frmSales
        f.ShowDialog()
    End Sub

    Private Sub mnuFont_Click(sender As Object, e As EventArgs) Handles mnuFont.Click
        Dim fd As New FontDialog()
        fd.Font = lblWelcome.Font

        If fd.ShowDialog() = DialogResult.OK Then
            lblWelcome.Font = fd.Font
            btnProducts.Font = fd.Font
            btnCustomers.Font = fd.Font
            btnSales.Font = fd.Font
            btnLogout.Font = fd.Font
        End If
    End Sub

    Private Sub mnuColor_Click(sender As Object, e As EventArgs) Handles mnuColor.Click
        Dim cd As New ColorDialog()

        If cd.ShowDialog() = DialogResult.OK Then
            pnlMain.BackColor = cd.Color
        End If
    End Sub
End Class