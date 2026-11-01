Public Class frmlogin
    Private attempts As Integer = 0
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim user As String = txtusername.Text.Trim()
        Dim pass As String = txtPassword.Text

        If user = "" Or pass = "" Then
            lblstatus.Text = "Please enter username and password."
            Return
        End If

        If user = "admin" And pass = "1234" Then
            Dim dash As New frmDashboard()
            dash.lblWelcome.Text = "Welcome, " & user
            dash.Show()
            Me.Close()
        Else
            attempts += 1
            lblstatus.Text = "Wrong login. Attempt " & attempts & " of 3."
            txtPassword.Clear()
            txtPassword.Focus()
            If attempts >= 3 Then
                MessageBox.Show("Too many failed attempts. Closing.")
                Me.Close()
            End If
        End If
    End Sub
End Class
