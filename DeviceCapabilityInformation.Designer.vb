<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeviceCapabilityInformation
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
        Me.label4 = New System.Windows.Forms.Label
        Me.lblGetCurrentContainer = New System.Windows.Forms.Label
        Me.listValues = New System.Windows.Forms.ListBox
        Me.label7 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.lblGetContainer = New System.Windows.Forms.Label
        Me.listOperations = New System.Windows.Forms.CheckedListBox
        Me.label5 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.lblCapType = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.listCapabilities = New System.Windows.Forms.ListBox
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(207, 130)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(109, 13)
        Me.label4.TabIndex = 14
        Me.label4.Text = "Capability Operations:"
        '
        'lblGetCurrentContainer
        '
        Me.lblGetCurrentContainer.AutoSize = True
        Me.lblGetCurrentContainer.Location = New System.Drawing.Point(134, 63)
        Me.lblGetCurrentContainer.Name = "lblGetCurrentContainer"
        Me.lblGetCurrentContainer.Size = New System.Drawing.Size(76, 13)
        Me.lblGetCurrentContainer.TabIndex = 7
        Me.lblGetCurrentContainer.Text = "Not Supported"
        '
        'listValues
        '
        Me.listValues.FormattingEnabled = True
        Me.listValues.IntegralHeight = False
        Me.listValues.Location = New System.Drawing.Point(210, 271)
        Me.listValues.Name = "listValues"
        Me.listValues.Size = New System.Drawing.Size(271, 103)
        Me.listValues.TabIndex = 13
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(207, 255)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(94, 13)
        Me.label7.TabIndex = 12
        Me.label7.Text = "Supported Values:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(16, 63)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(112, 13)
        Me.label6.TabIndex = 6
        Me.label6.Text = "Get Current Container:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(10, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Capabilities:"
        '
        'lblGetContainer
        '
        Me.lblGetContainer.AutoSize = True
        Me.lblGetContainer.Location = New System.Drawing.Point(134, 42)
        Me.lblGetContainer.Name = "lblGetContainer"
        Me.lblGetContainer.Size = New System.Drawing.Size(76, 13)
        Me.lblGetContainer.TabIndex = 5
        Me.lblGetContainer.Text = "Not Supported"
        '
        'listOperations
        '
        Me.listOperations.FormattingEnabled = True
        Me.listOperations.Items.AddRange(New Object() {"TWQC_NONE", "TWQC_GET", "TWQC_SET", "TWQC_GETDEFAULT", "TWQC_GETCURRENT", "TWQC_RESET"})
        Me.listOperations.Location = New System.Drawing.Point(210, 146)
        Me.listOperations.Name = "listOperations"
        Me.listOperations.Size = New System.Drawing.Size(271, 94)
        Me.listOperations.TabIndex = 15
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(16, 42)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(75, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Get Container:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(207, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(110, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Capability Information:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lblGetCurrentContainer)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.lblGetContainer)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.lblCapType)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Location = New System.Drawing.Point(210, 26)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(271, 92)
        Me.groupBox1.TabIndex = 11
        Me.groupBox1.TabStop = False
        '
        'lblCapType
        '
        Me.lblCapType.AutoSize = True
        Me.lblCapType.Location = New System.Drawing.Point(134, 22)
        Me.lblCapType.Name = "lblCapType"
        Me.lblCapType.Size = New System.Drawing.Size(53, 13)
        Me.lblCapType.TabIndex = 2
        Me.lblCapType.Text = "Unknown"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 22)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(34, 13)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Type:"
        '
        'listCapabilities
        '
        Me.listCapabilities.FormattingEnabled = True
        Me.listCapabilities.Location = New System.Drawing.Point(12, 32)
        Me.listCapabilities.Name = "listCapabilities"
        Me.listCapabilities.Size = New System.Drawing.Size(171, 342)
        Me.listCapabilities.Sorted = True
        Me.listCapabilities.TabIndex = 9
        '
        'DeviceCapabilityInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 390)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.listValues)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.listOperations)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.listCapabilities)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeviceCapabilityInformation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Device Capability Information"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents lblGetCurrentContainer As System.Windows.Forms.Label
    Private WithEvents listValues As System.Windows.Forms.ListBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lblGetContainer As System.Windows.Forms.Label
    Private WithEvents listOperations As System.Windows.Forms.CheckedListBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lblCapType As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents listCapabilities As System.Windows.Forms.ListBox
End Class
