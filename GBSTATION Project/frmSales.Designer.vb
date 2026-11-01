<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        lblPrice = New Label()
        lblQuantity = New Label()
        lblDiscount = New Label()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        txtDiscount = New TextBox()
        btnCalculate = New Button()
        btnClear = New Button()
        lblStatus = New Label()
        lblSubtotal = New Label()
        lblDiscountAmt = New Label()
        lblTax = New Label()
        lblTotal = New Label()
        btnClose = New Button()
        ToolTip1 = New ToolTip(components)
        btnAddItem = New Button()
        btnNewSale = New Button()
        btnSaveReceipt = New Button()
        lblProduct = New Label()
        txtProduct = New TextBox()
        lstItems = New ListBox()
        lblGrandTotal = New Label()
        SuspendLayout()
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPrice.Location = New Point(4, 100)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(141, 32)
        lblPrice.TabIndex = 1
        lblPrice.Text = "Unit Price:"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblQuantity.Location = New Point(4, 183)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(123, 32)
        lblQuantity.TabIndex = 2
        lblQuantity.Text = "Quantity:"
        ' 
        ' lblDiscount
        ' 
        lblDiscount.AutoSize = True
        lblDiscount.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblDiscount.Location = New Point(4, 283)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(155, 32)
        lblDiscount.TabIndex = 3
        lblDiscount.Text = "Discount %:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPrice.Location = New Point(164, 97)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(182, 35)
        txtPrice.TabIndex = 4
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtQuantity.Location = New Point(164, 185)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(182, 35)
        txtQuantity.TabIndex = 5
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDiscount.Location = New Point(194, 280)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(182, 35)
        txtDiscount.TabIndex = 6
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.PaleGoldenrod
        btnCalculate.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculate.ForeColor = Color.DarkSlateGray
        btnCalculate.Location = New Point(4, 356)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(133, 50)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        ToolTip1.SetToolTip(btnCalculate, "Click to Calculate")
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Silver
        btnClear.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.Maroon
        btnClear.Location = New Point(173, 356)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(133, 50)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        ToolTip1.SetToolTip(btnClear, "Click to Clear")
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Segoe UI Symbol", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.Firebrick
        lblStatus.Location = New Point(338, 653)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(354, 32)
        lblStatus.TabIndex = 11
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Times New Roman", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtotal.Location = New Point(604, 36)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(173, 33)
        lblSubtotal.TabIndex = 12
        lblSubtotal.Text = "Subtotal: 0.00"
        ' 
        ' lblDiscountAmt
        ' 
        lblDiscountAmt.AutoSize = True
        lblDiscountAmt.Font = New Font("Times New Roman", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDiscountAmt.Location = New Point(604, 124)
        lblDiscountAmt.Name = "lblDiscountAmt"
        lblDiscountAmt.Size = New Size(180, 33)
        lblDiscountAmt.TabIndex = 13
        lblDiscountAmt.Text = "Discount: 0.00"
        ' 
        ' lblTax
        ' 
        lblTax.AutoSize = True
        lblTax.Font = New Font("Times New Roman", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTax.Location = New Point(604, 216)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(140, 33)
        lblTax.TabIndex = 14
        lblTax.Text = "Tax:    0.00"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Times New Roman", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(613, 356)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(192, 36)
        lblTotal.TabIndex = 15
        lblTotal.Text = "Total:     0.00"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Navy
        btnClose.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(693, 633)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(133, 56)
        btnClose.TabIndex = 16
        btnClose.Text = "Close"
        ToolTip1.SetToolTip(btnClose, "Click to exit the Page")
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnAddItem
        ' 
        btnAddItem.BackColor = Color.PaleGreen
        btnAddItem.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddItem.ForeColor = Color.DarkSlateGray
        btnAddItem.Location = New Point(346, 356)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(154, 61)
        btnAddItem.TabIndex = 19
        btnAddItem.Text = "Add to Bill"
        ToolTip1.SetToolTip(btnAddItem, "Click to Add Bills")
        btnAddItem.UseVisualStyleBackColor = False
        ' 
        ' btnNewSale
        ' 
        btnNewSale.BackColor = Color.IndianRed
        btnNewSale.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNewSale.ForeColor = Color.Gold
        btnNewSale.Location = New Point(663, 438)
        btnNewSale.Name = "btnNewSale"
        btnNewSale.Size = New Size(133, 50)
        btnNewSale.TabIndex = 22
        btnNewSale.Text = "New Sale"
        ToolTip1.SetToolTip(btnNewSale, "Click to Start New Sale")
        btnNewSale.UseVisualStyleBackColor = False
        ' 
        ' btnSaveReceipt
        ' 
        btnSaveReceipt.BackColor = Color.OliveDrab
        btnSaveReceipt.Font = New Font("Times New Roman", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveReceipt.ForeColor = Color.Honeydew
        btnSaveReceipt.Location = New Point(651, 509)
        btnSaveReceipt.Name = "btnSaveReceipt"
        btnSaveReceipt.Size = New Size(154, 61)
        btnSaveReceipt.TabIndex = 23
        btnSaveReceipt.Text = "Save Receipt"
        ToolTip1.SetToolTip(btnSaveReceipt, "Click to Save The Bill Receipt")
        btnSaveReceipt.UseVisualStyleBackColor = False
        ' 
        ' lblProduct
        ' 
        lblProduct.AutoSize = True
        lblProduct.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblProduct.Location = New Point(4, 36)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New Size(114, 32)
        lblProduct.TabIndex = 17
        lblProduct.Text = "Product:"
        ' 
        ' txtProduct
        ' 
        txtProduct.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtProduct.Location = New Point(164, 33)
        txtProduct.Name = "txtProduct"
        txtProduct.Size = New Size(182, 35)
        txtProduct.TabIndex = 18
        ' 
        ' lstItems
        ' 
        lstItems.FormattingEnabled = True
        lstItems.Location = New Point(12, 427)
        lstItems.Name = "lstItems"
        lstItems.Size = New Size(554, 179)
        lstItems.TabIndex = 20
        ' 
        ' lblGrandTotal
        ' 
        lblGrandTotal.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGrandTotal.Location = New Point(12, 643)
        lblGrandTotal.Name = "lblGrandTotal"
        lblGrandTotal.Size = New Size(320, 38)
        lblGrandTotal.TabIndex = 21
        lblGrandTotal.Text = "Grand Total: 0.00"
        ' 
        ' frmSales
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = btnClose
        ClientSize = New Size(878, 694)
        Controls.Add(btnSaveReceipt)
        Controls.Add(btnNewSale)
        Controls.Add(lblGrandTotal)
        Controls.Add(lstItems)
        Controls.Add(btnAddItem)
        Controls.Add(txtProduct)
        Controls.Add(lblProduct)
        Controls.Add(btnClose)
        Controls.Add(lblTotal)
        Controls.Add(lblTax)
        Controls.Add(lblDiscountAmt)
        Controls.Add(lblSubtotal)
        Controls.Add(lblStatus)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(txtDiscount)
        Controls.Add(txtQuantity)
        Controls.Add(txtPrice)
        Controls.Add(lblDiscount)
        Controls.Add(lblQuantity)
        Controls.Add(lblPrice)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "frmSales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GBStation-Sales"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblDiscountAmt As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblProduct As Label
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents lstItems As ListBox
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents btnNewSale As Button
    Friend WithEvents btnSaveReceipt As Button
End Class
