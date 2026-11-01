<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAddCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAddCustomer))
        lblName = New Label()
        txtName = New TextBox()
        lblPhone = New Label()
        txtPhone = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblStatus = New Label()
        btnOk = New Button()
        btnCancel = New Button()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(22, 42)
        lblName.Name = "lblName"
        lblName.Size = New Size(208, 32)
        lblName.TabIndex = 2
        lblName.Text = "Customer Name:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(247, 42)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(256, 36)
        txtName.TabIndex = 9
        ToolTip1.SetToolTip(txtName, "Write Customer name")
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic)
        lblPhone.Location = New Point(22, 130)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(96, 32)
        lblPhone.TabIndex = 4
        lblPhone.Text = "Phone:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhone.Location = New Point(247, 126)
        txtPhone.Multiline = True
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(256, 36)
        txtPhone.TabIndex = 11
        ToolTip1.SetToolTip(txtPhone, "Write the Phone Number")
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(22, 219)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(100, 32)
        lblEmail.TabIndex = 12
        lblEmail.Text = "Email :"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(247, 215)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(256, 36)
        txtEmail.TabIndex = 13
        ToolTip1.SetToolTip(txtEmail, "Enter the Email")
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Segoe UI Symbol", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.Firebrick
        lblStatus.Location = New Point(12, 392)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(440, 32)
        lblStatus.TabIndex = 14
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnOk
        ' 
        btnOk.BackColor = SystemColors.ActiveCaption
        btnOk.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOk.Location = New Point(171, 289)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(115, 65)
        btnOk.TabIndex = 15
        btnOk.Text = "OK"
        ToolTip1.SetToolTip(btnOk, "Click to Add Customer")
        btnOk.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.RosyBrown
        btnCancel.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(409, 289)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(115, 65)
        btnCancel.TabIndex = 16
        btnCancel.Text = "Cancel"
        ToolTip1.SetToolTip(btnCancel, "Click to leave the Page")
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' dlgAddCustomer
        ' 
        AcceptButton = btnOk
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        CancelButton = btnCancel
        ClientSize = New Size(778, 444)
        Controls.Add(btnCancel)
        Controls.Add(btnOk)
        Controls.Add(lblStatus)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Controls.Add(lblPhone)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgAddCustomer"
        StartPosition = FormStartPosition.CenterParent
        Text = "Add Customer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
