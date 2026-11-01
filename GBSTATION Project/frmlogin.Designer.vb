<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblTitle = New Label()
        lblusername = New Label()
        txtusername = New TextBox()
        lblpassword = New Label()
        txtPassword = New TextBox()
        btnlogin = New Button()
        btnexit = New Button()
        lblstatus = New Label()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(122, 36)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(434, 36)
        lblTitle.TabIndex = 0
        lblTitle.Text = "GBStation Stationery Supplies"
        ' 
        ' lblusername
        ' 
        lblusername.AutoSize = True
        lblusername.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblusername.Location = New Point(29, 110)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(149, 32)
        lblusername.TabIndex = 1
        lblusername.Text = "Username :"
        ' 
        ' txtusername
        ' 
        txtusername.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtusername.Location = New Point(236, 110)
        txtusername.Multiline = True
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(381, 46)
        txtusername.TabIndex = 1
        ToolTip1.SetToolTip(txtusername, "Enter your username")
        ' 
        ' lblpassword
        ' 
        lblpassword.AutoSize = True
        lblpassword.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblpassword.Location = New Point(29, 205)
        lblpassword.Name = "lblpassword"
        lblpassword.Size = New Size(145, 32)
        lblpassword.TabIndex = 3
        lblpassword.Text = "Password :"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(236, 205)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(381, 46)
        txtPassword.TabIndex = 2
        ToolTip1.SetToolTip(txtPassword, "Enter your password")
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.IndianRed
        btnlogin.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.ForeColor = Color.LightGreen
        btnlogin.Location = New Point(162, 297)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(172, 71)
        btnlogin.TabIndex = 3
        btnlogin.Text = "LogIn"
        ToolTip1.SetToolTip(btnlogin, "Click to Log In")
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.Orange
        btnexit.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnexit.ForeColor = Color.Black
        btnexit.Location = New Point(546, 303)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(172, 59)
        btnexit.TabIndex = 4
        btnexit.Text = "Exit"
        ToolTip1.SetToolTip(btnexit, "Close the application")
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' lblstatus
        ' 
        lblstatus.BackColor = Color.PaleTurquoise
        lblstatus.Font = New Font("Times New Roman", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblstatus.ForeColor = Color.DarkRed
        lblstatus.Location = New Point(224, 389)
        lblstatus.Name = "lblstatus"
        lblstatus.Size = New Size(393, 40)
        lblstatus.TabIndex = 7
        lblstatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmlogin
        ' 
        AcceptButton = btnlogin
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        CancelButton = btnexit
        ClientSize = New Size(800, 450)
        Controls.Add(lblstatus)
        Controls.Add(btnexit)
        Controls.Add(btnlogin)
        Controls.Add(txtPassword)
        Controls.Add(lblpassword)
        Controls.Add(txtusername)
        Controls.Add(lblusername)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "frmlogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GBStation-Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents lblstatus As Label
    Friend WithEvents ToolTip1 As ToolTip

End Class
