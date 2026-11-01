Public Class frmSplash
    Private Sub tmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        prgLoad.Value += 1
        lblPercentage.Text = prgLoad.Value & "%"

        If prgLoad.Value <= 10 Then
            lblMessage.Text = "Initializing System, Please Wait..."
        ElseIf prgLoad.Value <= 30 Then
            lblMessage.Text = "System Loading..."
        ElseIf prgLoad.Value <= 50 Then
            lblMessage.Text = "Integrating Database..."
        ElseIf prgLoad.Value <= 70 Then
            lblMessage.Text = "Loading all components..."
        ElseIf prgLoad.Value <= 80 Then
            lblMessage.Text = "Hold on..."
        Else
            lblMessage.Text = "Welcome to GBStation..."
        End If

        If prgLoad.Value >= 100 Then
            tmrLoad.Stop()
            frmlogin.Show()
            Me.Close()
        End If
    End Sub
End Class