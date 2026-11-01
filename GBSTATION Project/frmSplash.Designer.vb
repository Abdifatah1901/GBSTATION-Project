<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        lblTitle = New Label()
        prgLoad = New ProgressBar()
        lblMessage = New Label()
        lblPercentage = New Label()
        tmrLoad = New Timer(components)
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Times New Roman", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(254, 63)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(273, 36)
        lblTitle.TabIndex = 0
        lblTitle.Text = "GBStation Supplies"
        ' 
        ' prgLoad
        ' 
        prgLoad.Location = New Point(103, 217)
        prgLoad.Name = "prgLoad"
        prgLoad.Size = New Size(552, 49)
        prgLoad.TabIndex = 1
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.BackColor = SystemColors.ButtonHighlight
        lblMessage.Font = New Font("Segoe UI Symbol", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblMessage.ForeColor = SystemColors.ActiveCaptionText
        lblMessage.Location = New Point(270, 169)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(209, 32)
        lblMessage.TabIndex = 2
        lblMessage.Text = "loading message"
        ' 
        ' lblPercentage
        ' 
        lblPercentage.AutoSize = True
        lblPercentage.BackColor = Color.Transparent
        lblPercentage.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPercentage.ForeColor = Color.White
        lblPercentage.Location = New Point(590, 303)
        lblPercentage.Name = "lblPercentage"
        lblPercentage.Size = New Size(49, 32)
        lblPercentage.TabIndex = 3
        lblPercentage.Text = "0%"
        ' 
        ' tmrLoad
        ' 
        tmrLoad.Enabled = True
        ' 
        ' frmSplash
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 464)
        Controls.Add(lblPercentage)
        Controls.Add(lblMessage)
        Controls.Add(prgLoad)
        Controls.Add(lblTitle)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSplash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GB-Station"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents prgLoad As ProgressBar
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblPercentage As Label
    Friend WithEvents tmrLoad As Timer
End Class
