<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducts))
        lblSearch = New Label()
        txtSearch = New TextBox()
        ctxSearch = New ContextMenuStrip(components)
        ctxCut = New ToolStripMenuItem()
        ctxCopy = New ToolStripMenuItem()
        ctxPaste = New ToolStripMenuItem()
        ctxClear = New ToolStripMenuItem()
        lblCategory = New Label()
        cboCategory = New ComboBox()
        dgvProducts = New DataGridView()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnLoadFile = New Button()
        btnClose = New Button()
        lblStatus = New Label()
        ToolTip1 = New ToolTip(components)
        btnCopyRow = New Button()
        ctxSearch.SuspendLayout()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSearch.Location = New Point(12, 32)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(110, 32)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Search :"
        ' 
        ' txtSearch
        ' 
        txtSearch.ContextMenuStrip = ctxSearch
        txtSearch.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(128, 32)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(216, 36)
        txtSearch.TabIndex = 1
        ToolTip1.SetToolTip(txtSearch, "Search for Products")
        ' 
        ' ctxSearch
        ' 
        ctxSearch.ImageScalingSize = New Size(24, 24)
        ctxSearch.Items.AddRange(New ToolStripItem() {ctxCut, ctxCopy, ctxPaste, ctxClear})
        ctxSearch.Name = "ctxSearch"
        ctxSearch.Size = New Size(127, 132)
        ' 
        ' ctxCut
        ' 
        ctxCut.Name = "ctxCut"
        ctxCut.Size = New Size(126, 32)
        ctxCut.Text = "Cut"
        ' 
        ' ctxCopy
        ' 
        ctxCopy.Name = "ctxCopy"
        ctxCopy.Size = New Size(126, 32)
        ctxCopy.Text = "Copy"
        ' 
        ' ctxPaste
        ' 
        ctxPaste.Name = "ctxPaste"
        ctxPaste.Size = New Size(126, 32)
        ctxPaste.Text = "Paste"
        ' 
        ' ctxClear
        ' 
        ctxClear.Name = "ctxClear"
        ctxClear.Size = New Size(126, 32)
        ctxClear.Text = "Clear"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Times New Roman", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblCategory.Location = New Point(367, 36)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(134, 32)
        lblCategory.TabIndex = 2
        lblCategory.Text = "Category :"
        ' 
        ' cboCategory
        ' 
        cboCategory.FormattingEnabled = True
        cboCategory.Location = New Point(507, 39)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(233, 33)
        cboCategory.TabIndex = 3
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AllowUserToAddRows = False
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(12, 92)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.ReadOnly = True
        dgvProducts.RowHeadersWidth = 62
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(744, 225)
        dgvProducts.TabIndex = 4
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ActiveCaption
        btnAdd.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(12, 332)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(115, 65)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add "
        ToolTip1.SetToolTip(btnAdd, "Click to Add Products")
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.AntiqueWhite
        btnUpdate.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(152, 332)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(115, 65)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        ToolTip1.SetToolTip(btnUpdate, "Click to Update Product List")
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.IndianRed
        btnDelete.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(291, 332)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(115, 65)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        ToolTip1.SetToolTip(btnDelete, "Click to remove Product")
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnLoadFile
        ' 
        btnLoadFile.BackColor = SystemColors.Menu
        btnLoadFile.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLoadFile.Location = New Point(427, 332)
        btnLoadFile.Name = "btnLoadFile"
        btnLoadFile.Size = New Size(115, 65)
        btnLoadFile.TabIndex = 8
        btnLoadFile.Text = "Load "
        ToolTip1.SetToolTip(btnLoadFile, "Click to load from file")
        btnLoadFile.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Goldenrod
        btnClose.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(641, 355)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(115, 65)
        btnClose.TabIndex = 9
        btnClose.Text = "Close"
        ToolTip1.SetToolTip(btnClose, "Click to exit application")
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Segoe UI Symbol", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.Firebrick
        lblStatus.Location = New Point(152, 497)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(440, 32)
        lblStatus.TabIndex = 10
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnCopyRow
        ' 
        btnCopyRow.BackColor = Color.Tan
        btnCopyRow.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCopyRow.Location = New Point(12, 416)
        btnCopyRow.Name = "btnCopyRow"
        btnCopyRow.Size = New Size(126, 65)
        btnCopyRow.TabIndex = 11
        btnCopyRow.Text = "Copy Row"
        ToolTip1.SetToolTip(btnCopyRow, "Copy the Selected Product to the Clipboard")
        btnCopyRow.UseVisualStyleBackColor = False
        ' 
        ' frmProducts
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = btnClose
        ClientSize = New Size(800, 538)
        Controls.Add(btnCopyRow)
        Controls.Add(lblStatus)
        Controls.Add(btnClose)
        Controls.Add(btnLoadFile)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(dgvProducts)
        Controls.Add(cboCategory)
        Controls.Add(lblCategory)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        DoubleBuffered = True
        Name = "frmProducts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GBStation-Products"
        ctxSearch.ResumeLayout(False)
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLoadFile As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ctxSearch As ContextMenuStrip
    Friend WithEvents ctxCut As ToolStripMenuItem
    Friend WithEvents ctxCopy As ToolStripMenuItem
    Friend WithEvents ctxPaste As ToolStripMenuItem
    Friend WithEvents ctxClear As ToolStripMenuItem
    Friend WithEvents btnCopyRow As Button
End Class
