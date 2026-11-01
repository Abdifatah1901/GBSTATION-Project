Public Class dlgAddCustomer

    <System.ComponentModel.Browsable(False)>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property NewName As String

    <System.ComponentModel.Browsable(False)>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property NewPhone As String

    <System.ComponentModel.Browsable(False)>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property NewEmail As String

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim nm As String = txtName.Text.Trim()
        Dim ph As String = txtPhone.Text.Trim()
        Dim em As String = txtEmail.Text.Trim()

        If nm = "" Then
            lblStatus.Text = "Enter the customer name."
            txtName.Focus()
            Return
        End If

        Dim digits As String = ph.TrimStart("+"c)
        If ph = "" OrElse digits.Length < 9 OrElse digits.Length > 13 OrElse Not digits.All(AddressOf Char.IsDigit) Then
            lblStatus.Text = "Enter a valid phone number (digits only)."
            txtPhone.Focus()
            Return
        End If

        If em <> "" AndAlso (Not em.Contains("@") OrElse Not em.Contains(".")) Then
            lblStatus.Text = "Enter a valid email or leave it empty."
            txtEmail.Focus()
            Return
        End If

        NewName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nm.ToLower())
        NewPhone = ph
        NewEmail = em.ToLower()
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Public Sub LoadForEdit(nm As String, ph As String, em As String)
        Me.Text = "Update Customer"
        txtName.Text = nm
        txtPhone.Text = ph
        txtEmail.Text = em
    End Sub

End Class