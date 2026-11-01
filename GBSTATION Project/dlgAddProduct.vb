Public Class dlgAddProduct

    <System.ComponentModel.Browsable(False)>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property NewName As String

    <System.ComponentModel.Browsable(False)>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property NewCategory As String

    <System.ComponentModel.Browsable(False)>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property NewPrice As Decimal

    <System.ComponentModel.Browsable(False)>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property NewQuantity As Integer

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim p As Decimal
        Dim q As Integer

        If txtName.Text.Trim() = "" Then
            lblStatus.Text = "Enter a product name."
            txtName.Focus()
            Return
        End If
        If cboCategory.SelectedIndex = -1 Then
            lblStatus.Text = "Choose a category."
            cboCategory.Focus()
            Return
        End If
        If Not Decimal.TryParse(txtPrice.Text, p) OrElse p <= 0 Then
            lblStatus.Text = "Enter a valid price."
            txtPrice.Focus()
            Return
        End If
        If Not Integer.TryParse(txtQuantity.Text, q) OrElse q < 0 Then
            lblStatus.Text = "Enter a valid quantity."
            txtQuantity.Focus()
            Return
        End If

        NewName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text.Trim().ToLower())
        NewCategory = cboCategory.SelectedItem.ToString()
        NewPrice = p
        NewQuantity = q
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub dlgAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub LoadForEdit(name As String, category As String, price As Decimal, qty As Integer)
        Me.Text = "Update Product"
        txtName.Text = name
        cboCategory.SelectedItem = category
        txtPrice.Text = price.ToString()
        txtQuantity.Text = qty.ToString()
    End Sub
End Class