<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAddProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAddProduct))
        lblName = New Label()
        cboCategory = New ComboBox()
        lblCategory = New Label()
        lblPrice = New Label()
        txtPrice = New TextBox()
        txtName = New TextBox()
        txtQuantity = New TextBox()
        lblQuantity = New Label()
        lblStatus = New Label()
        btnOk = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(28, 9)
        lblName.Name = "lblName"
        lblName.Size = New Size(188, 32)
        lblName.TabIndex = 2
        lblName.Text = "Product Name:"
        ' 
        ' cboCategory
        ' 
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategory.FormattingEnabled = True
        cboCategory.Items.AddRange(New Object() {"Writing", "Paper", "Office", "Art", "Other"})
        cboCategory.Location = New Point(183, 87)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(233, 33)
        cboCategory.TabIndex = 4
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblCategory.Location = New Point(28, 88)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(127, 32)
        lblCategory.TabIndex = 5
        lblCategory.Text = "Category:"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPrice.Location = New Point(28, 173)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(83, 32)
        lblPrice.TabIndex = 6
        lblPrice.Text = "Price:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPrice.Location = New Point(183, 173)
        txtPrice.Multiline = True
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(233, 36)
        txtPrice.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(241, 12)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(256, 36)
        txtName.TabIndex = 8
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtQuantity.Location = New Point(183, 252)
        txtQuantity.Multiline = True
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(233, 36)
        txtQuantity.TabIndex = 9
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblQuantity.Location = New Point(28, 256)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(123, 32)
        lblQuantity.TabIndex = 10
        lblQuantity.Text = "Quantity:"
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Segoe UI Symbol", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.Firebrick
        lblStatus.Location = New Point(28, 360)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(440, 32)
        lblStatus.TabIndex = 11
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnOk
        ' 
        btnOk.BackColor = SystemColors.ActiveCaption
        btnOk.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOk.Location = New Point(514, 173)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(115, 65)
        btnOk.TabIndex = 12
        btnOk.Text = "OK"
        btnOk.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.RosyBrown
        btnCancel.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(514, 291)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(115, 65)
        btnCancel.TabIndex = 13
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' dlgAddProduct
        ' 
        AcceptButton = btnOk
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = btnCancel
        ClientSize = New Size(800, 450)
        Controls.Add(btnCancel)
        Controls.Add(btnOk)
        Controls.Add(lblStatus)
        Controls.Add(lblQuantity)
        Controls.Add(txtQuantity)
        Controls.Add(txtName)
        Controls.Add(txtPrice)
        Controls.Add(lblPrice)
        Controls.Add(lblCategory)
        Controls.Add(cboCategory)
        Controls.Add(lblName)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgAddProduct"
        StartPosition = FormStartPosition.CenterParent
        Text = "Add Product"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
End Class
