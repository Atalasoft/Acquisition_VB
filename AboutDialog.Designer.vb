<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutDialog
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
        Me.button1 = New System.Windows.Forms.Button
        Me.lblVersion = New System.Windows.Forms.Label
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel
        Me.label1 = New System.Windows.Forms.Label
        Me.downloadDotImageLinkLabel = New System.Windows.Forms.LinkLabel
        Me.downloadHelpLinkLabel = New System.Windows.Forms.LinkLabel
        Me.demoGalleryLinkLabel = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button1.Location = New System.Drawing.Point(242, 240)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(91, 24)
        Me.button1.TabIndex = 8
        Me.button1.Text = "OK"
        Me.button1.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Location = New System.Drawing.Point(268, 79)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(148, 13)
        Me.lblVersion.TabIndex = 7
        Me.lblVersion.Text = "Version 10.6.1.1"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel1.LinkColor = System.Drawing.Color.White
        Me.linkLabel1.Location = New System.Drawing.Point(205, 161)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(128, 13)
        Me.linkLabel1.TabIndex = 6
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "http://www.atalasoft.com"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(203, 50)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(213, 29)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Atalasoft DotTwain"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'downloadDotImageLinkLabel
        '
        Me.downloadDotImageLinkLabel.AutoSize = True
        Me.downloadDotImageLinkLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.downloadDotImageLinkLabel.Location = New System.Drawing.Point(205, 123)
        Me.downloadDotImageLinkLabel.Name = "downloadDotImageLinkLabel"
        Me.downloadDotImageLinkLabel.Size = New System.Drawing.Size(154, 13)
        Me.downloadDotImageLinkLabel.TabIndex = 9
        Me.downloadDotImageLinkLabel.TabStop = True
        Me.downloadDotImageLinkLabel.Text = "Download the Latest DotImage"
        '
        'downloadHelpLinkLabel
        '
        Me.downloadHelpLinkLabel.AutoSize = True
        Me.downloadHelpLinkLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.downloadHelpLinkLabel.Location = New System.Drawing.Point(205, 148)
        Me.downloadHelpLinkLabel.Name = "downloadHelpLinkLabel"
        Me.downloadHelpLinkLabel.Size = New System.Drawing.Size(168, 13)
        Me.downloadHelpLinkLabel.TabIndex = 10
        Me.downloadHelpLinkLabel.TabStop = True
        Me.downloadHelpLinkLabel.Text = "Download DotImage Help Installer"
        '
        'demoGalleryLinkLabel
        '
        Me.demoGalleryLinkLabel.AutoSize = True
        Me.demoGalleryLinkLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.demoGalleryLinkLabel.Location = New System.Drawing.Point(205, 174)
        Me.demoGalleryLinkLabel.Name = "demoGalleryLinkLabel"
        Me.demoGalleryLinkLabel.Size = New System.Drawing.Size(120, 13)
        Me.demoGalleryLinkLabel.TabIndex = 11
        Me.demoGalleryLinkLabel.TabStop = True
        Me.demoGalleryLinkLabel.Text = "Acquisition Demo Home"
        '
        'AboutDialog
        '
        Me.AcceptButton = Me.button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AcquisitionDemo.My.Resources.Resources.dlgbmp
        Me.CancelButton = Me.button1
        Me.ClientSize = New System.Drawing.Size(423, 276)
        Me.Controls.Add(Me.demoGalleryLinkLabel)
        Me.Controls.Add(Me.downloadHelpLinkLabel)
        Me.Controls.Add(Me.downloadDotImageLinkLabel)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents lblVersion As System.Windows.Forms.Label
    Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents downloadDotImageLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents downloadHelpLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents demoGalleryLinkLabel As System.Windows.Forms.LinkLabel
End Class
