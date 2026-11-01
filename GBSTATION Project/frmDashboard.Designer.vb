<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        pnlMain = New Panel()
        btnLogout = New Button()
        btnSales = New Button()
        btnCustomers = New Button()
        btnProducts = New Button()
        lblWelcome = New Label()
        ToolTip1 = New ToolTip(components)
        mnuMain = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuNew = New ToolStripMenuItem()
        mnuOpen = New ToolStripMenuItem()
        mnuSave = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        mnuView = New ToolStripMenuItem()
        mnuFont = New ToolStripMenuItem()
        mnuColor = New ToolStripMenuItem()
        mnuHelp = New ToolStripMenuItem()
        mnuAbout = New ToolStripMenuItem()
        pnlMain.SuspendLayout()
        mnuMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = SystemColors.ActiveCaption
        pnlMain.Controls.Add(btnLogout)
        pnlMain.Controls.Add(btnSales)
        pnlMain.Controls.Add(btnCustomers)
        pnlMain.Controls.Add(btnProducts)
        pnlMain.Controls.Add(lblWelcome)
        pnlMain.Location = New Point(163, 76)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(425, 286)
        pnlMain.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Red
        btnLogout.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(212, 203)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(140, 67)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Log Out"
        ToolTip1.SetToolTip(btnLogout, "Click to Logout")
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnSales
        ' 
        btnSales.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSales.Location = New Point(13, 161)
        btnSales.Name = "btnSales"
        btnSales.Size = New Size(112, 49)
        btnSales.TabIndex = 3
        btnSales.Text = "SALES"
        ToolTip1.SetToolTip(btnSales, "Click to View Sales")
        btnSales.UseVisualStyleBackColor = True
        ' 
        ' btnCustomers
        ' 
        btnCustomers.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCustomers.Location = New Point(212, 84)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(174, 50)
        btnCustomers.TabIndex = 2
        btnCustomers.Text = "CUSTOMERS"
        ToolTip1.SetToolTip(btnCustomers, "Click to Open Customer Base")
        btnCustomers.UseVisualStyleBackColor = True
        ' 
        ' btnProducts
        ' 
        btnProducts.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProducts.Location = New Point(13, 90)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(133, 38)
        btnProducts.TabIndex = 1
        btnProducts.Text = "PRODUCTS"
        ToolTip1.SetToolTip(btnProducts, "Open Product Management")
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Times New Roman", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(45, 13)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(280, 32)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome To GBStation"
        ' 
        ' mnuMain
        ' 
        mnuMain.ImageScalingSize = New Size(24, 24)
        mnuMain.Items.AddRange(New ToolStripItem() {mnuFile, mnuView, mnuHelp})
        mnuMain.Location = New Point(0, 0)
        mnuMain.Name = "mnuMain"
        mnuMain.Size = New Size(780, 33)
        mnuMain.TabIndex = 1
        mnuMain.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuNew, mnuOpen, mnuSave, mnuExit})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(54, 29)
        mnuFile.Text = "File"
        ' 
        ' mnuNew
        ' 
        mnuNew.Name = "mnuNew"
        mnuNew.ShortcutKeys = Keys.Control Or Keys.N
        mnuNew.Size = New Size(223, 34)
        mnuNew.Text = "New"
        mnuNew.ToolTipText = "Create a new Record"
        ' 
        ' mnuOpen
        ' 
        mnuOpen.Name = "mnuOpen"
        mnuOpen.ShortcutKeys = Keys.Control Or Keys.O
        mnuOpen.Size = New Size(223, 34)
        mnuOpen.Text = "Open"
        mnuOpen.ToolTipText = "Open a product list file"
        ' 
        ' mnuSave
        ' 
        mnuSave.Name = "mnuSave"
        mnuSave.ShortcutKeys = Keys.Control Or Keys.S
        mnuSave.Size = New Size(223, 34)
        mnuSave.Text = "Save"
        mnuSave.ToolTipText = "Save data to a file"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.ShortcutKeys = Keys.Alt Or Keys.F4
        mnuExit.Size = New Size(223, 34)
        mnuExit.Text = "Exit"
        mnuExit.ToolTipText = "Close the Application"
        ' 
        ' mnuView
        ' 
        mnuView.DropDownItems.AddRange(New ToolStripItem() {mnuFont, mnuColor})
        mnuView.Name = "mnuView"
        mnuView.Size = New Size(65, 29)
        mnuView.Text = "View"
        ' 
        ' mnuFont
        ' 
        mnuFont.Name = "mnuFont"
        mnuFont.ShortcutKeys = Keys.Control Or Keys.F
        mnuFont.Size = New Size(270, 34)
        mnuFont.Text = "Font"
        mnuFont.ToolTipText = "Change the text font"
        ' 
        ' mnuColor
        ' 
        mnuColor.Name = "mnuColor"
        mnuColor.ShortcutKeys = Keys.Control Or Keys.L
        mnuColor.Size = New Size(270, 34)
        mnuColor.Text = "Color"
        mnuColor.ToolTipText = "Change the Background Color"
        ' 
        ' mnuHelp
        ' 
        mnuHelp.DropDownItems.AddRange(New ToolStripItem() {mnuAbout})
        mnuHelp.Name = "mnuHelp"
        mnuHelp.Size = New Size(65, 29)
        mnuHelp.Text = "Help"
        ' 
        ' mnuAbout
        ' 
        mnuAbout.Name = "mnuAbout"
        mnuAbout.ShortcutKeys = Keys.F1
        mnuAbout.Size = New Size(195, 34)
        mnuAbout.Text = "About"
        mnuAbout.ToolTipText = "About this System"
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(780, 444)
        Controls.Add(pnlMain)
        Controls.Add(mnuMain)
        DoubleBuffered = True
        MainMenuStrip = mnuMain
        MaximizeBox = False
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GBStation - Dashboard"
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        mnuMain.ResumeLayout(False)
        mnuMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnCustomers As Button
    Public WithEvents lblWelcome As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents mnuFont As ToolStripMenuItem
    Friend WithEvents mnuColor As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
