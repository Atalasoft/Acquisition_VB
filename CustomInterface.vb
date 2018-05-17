Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Globalization
Imports Atalasoft.Twain

Namespace AcquisitionDemo
    ''' <summary>
    ''' Summary description for Barcode.
    ''' </summary>
    Public Class CustomInterface : Inherits System.Windows.Forms.Form
        Private _device As Atalasoft.Twain.Device

        Private groupBarcode As System.Windows.Forms.GroupBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents cboPixelType As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private WithEvents cboResolution As System.Windows.Forms.ComboBox
        Private label3 As System.Windows.Forms.Label
        Private WithEvents numPages As System.Windows.Forms.NumericUpDown
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label4 As System.Windows.Forms.Label
        Private WithEvents cboBrightness As System.Windows.Forms.ComboBox
        Private label5 As System.Windows.Forms.Label
        Private WithEvents cboContrast As System.Windows.Forms.ComboBox
        Private WithEvents chkAutoBorder As System.Windows.Forms.CheckBox
        Private WithEvents chkAutoDeskew As System.Windows.Forms.CheckBox
        Private WithEvents chkAutoRotate As System.Windows.Forms.CheckBox
        Private WithEvents chkBarcodeEnabled As System.Windows.Forms.CheckBox
        Private label6 As System.Windows.Forms.Label
        Private WithEvents numBarcodeRetries As System.Windows.Forms.NumericUpDown
        Private label7 As System.Windows.Forms.Label
        Private WithEvents numBarcodeSearch As System.Windows.Forms.NumericUpDown
        Private label8 As System.Windows.Forms.Label
        Private WithEvents cboBarcodeSearchMode As System.Windows.Forms.ComboBox
        Private label9 As System.Windows.Forms.Label
        Private label10 As System.Windows.Forms.Label
        Private listBarcodeSearch As System.Windows.Forms.CheckedListBox
        Private WithEvents btnScan As System.Windows.Forms.Button
        Private btnCancel As System.Windows.Forms.Button
        Private WithEvents numTimeout As System.Windows.Forms.NumericUpDown
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New(ByVal device As Device)
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            Me._device = device
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.groupBarcode = New System.Windows.Forms.GroupBox()
            Me.listBarcodeSearch = New System.Windows.Forms.CheckedListBox()
            Me.label10 = New System.Windows.Forms.Label()
            Me.numTimeout = New System.Windows.Forms.NumericUpDown()
            Me.label9 = New System.Windows.Forms.Label()
            Me.cboBarcodeSearchMode = New System.Windows.Forms.ComboBox()
            Me.label8 = New System.Windows.Forms.Label()
            Me.numBarcodeSearch = New System.Windows.Forms.NumericUpDown()
            Me.label7 = New System.Windows.Forms.Label()
            Me.numBarcodeRetries = New System.Windows.Forms.NumericUpDown()
            Me.label6 = New System.Windows.Forms.Label()
            Me.chkBarcodeEnabled = New System.Windows.Forms.CheckBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.cboPixelType = New System.Windows.Forms.ComboBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.cboResolution = New System.Windows.Forms.ComboBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.numPages = New System.Windows.Forms.NumericUpDown()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.chkAutoRotate = New System.Windows.Forms.CheckBox()
            Me.chkAutoDeskew = New System.Windows.Forms.CheckBox()
            Me.chkAutoBorder = New System.Windows.Forms.CheckBox()
            Me.cboContrast = New System.Windows.Forms.ComboBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.cboBrightness = New System.Windows.Forms.ComboBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.btnScan = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.groupBarcode.SuspendLayout()
            CType(Me.numTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numBarcodeSearch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numBarcodeRetries, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numPages, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' groupBarcode
            ' 
            Me.groupBarcode.Controls.Add(Me.listBarcodeSearch)
            Me.groupBarcode.Controls.Add(Me.label10)
            Me.groupBarcode.Controls.Add(Me.numTimeout)
            Me.groupBarcode.Controls.Add(Me.label9)
            Me.groupBarcode.Controls.Add(Me.cboBarcodeSearchMode)
            Me.groupBarcode.Controls.Add(Me.label8)
            Me.groupBarcode.Controls.Add(Me.numBarcodeSearch)
            Me.groupBarcode.Controls.Add(Me.label7)
            Me.groupBarcode.Controls.Add(Me.numBarcodeRetries)
            Me.groupBarcode.Controls.Add(Me.label6)
            Me.groupBarcode.Controls.Add(Me.chkBarcodeEnabled)
            Me.groupBarcode.Location = New System.Drawing.Point(250, 18)
            Me.groupBarcode.Name = "groupBarcode"
            Me.groupBarcode.Size = New System.Drawing.Size(271, 302)
            Me.groupBarcode.TabIndex = 7
            Me.groupBarcode.TabStop = False
            Me.groupBarcode.Text = "Barcode"
            ' 
            ' listBarcodeSearch
            ' 
            Me.listBarcodeSearch.Location = New System.Drawing.Point(17, 191)
            Me.listBarcodeSearch.Name = "listBarcodeSearch"
            Me.listBarcodeSearch.Size = New System.Drawing.Size(233, 94)
            Me.listBarcodeSearch.TabIndex = 10
            ' 
            ' label10
            ' 
            Me.label10.Location = New System.Drawing.Point(17, 173)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(97, 19)
            Me.label10.TabIndex = 9
            Me.label10.Text = "Search Priorities:"
            ' 
            ' numTimeout
            ' 
            Me.numTimeout.Location = New System.Drawing.Point(154, 144)
            Me.numTimeout.Name = "numTimeout"
            Me.numTimeout.Size = New System.Drawing.Size(76, 20)
            Me.numTimeout.TabIndex = 8
            '			Me.numTimeout.ValueChanged += New System.EventHandler(Me.numTimeout_ValueChanged);
            ' 
            ' label9
            ' 
            Me.label9.Location = New System.Drawing.Point(17, 144)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(54, 20)
            Me.label9.TabIndex = 7
            Me.label9.Text = "Timeout:"
            ' 
            ' cboBarcodeSearchMode
            ' 
            Me.cboBarcodeSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBarcodeSearchMode.Location = New System.Drawing.Point(154, 114)
            Me.cboBarcodeSearchMode.Name = "cboBarcodeSearchMode"
            Me.cboBarcodeSearchMode.Size = New System.Drawing.Size(99, 21)
            Me.cboBarcodeSearchMode.TabIndex = 6
            '			Me.cboBarcodeSearchMode.SelectedIndexChanged += New System.EventHandler(Me.cboBarcodeSearchMode_SelectedIndexChanged);
            ' 
            ' label8
            ' 
            Me.label8.Location = New System.Drawing.Point(17, 114)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(82, 21)
            Me.label8.TabIndex = 5
            Me.label8.Text = "Search Mode:"
            ' 
            ' numBarcodeSearch
            ' 
            Me.numBarcodeSearch.Location = New System.Drawing.Point(154, 85)
            Me.numBarcodeSearch.Name = "numBarcodeSearch"
            Me.numBarcodeSearch.Size = New System.Drawing.Size(46, 20)
            Me.numBarcodeSearch.TabIndex = 4
            '			Me.numBarcodeSearch.ValueChanged += New System.EventHandler(Me.numBarcodeSearch_ValueChanged);
            ' 
            ' label7
            ' 
            Me.label7.Location = New System.Drawing.Point(17, 85)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(145, 20)
            Me.label7.TabIndex = 3
            Me.label7.Text = "Maximum Search Priorities:"
            ' 
            ' numBarcodeRetries
            ' 
            Me.numBarcodeRetries.Location = New System.Drawing.Point(154, 56)
            Me.numBarcodeRetries.Name = "numBarcodeRetries"
            Me.numBarcodeRetries.Size = New System.Drawing.Size(46, 20)
            Me.numBarcodeRetries.TabIndex = 2
            '			Me.numBarcodeRetries.ValueChanged += New System.EventHandler(Me.numBarcodeRetries_ValueChanged);
            ' 
            ' label6
            ' 
            Me.label6.Location = New System.Drawing.Point(17, 56)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(101, 20)
            Me.label6.TabIndex = 1
            Me.label6.Text = "Maximum Retries:"
            ' 
            ' chkBarcodeEnabled
            ' 
            Me.chkBarcodeEnabled.Location = New System.Drawing.Point(17, 30)
            Me.chkBarcodeEnabled.Name = "chkBarcodeEnabled"
            Me.chkBarcodeEnabled.Size = New System.Drawing.Size(75, 17)
            Me.chkBarcodeEnabled.TabIndex = 0
            Me.chkBarcodeEnabled.Text = "Enabled"
            '			Me.chkBarcodeEnabled.CheckedChanged += New System.EventHandler(Me.chkBarcodeEnabled_CheckedChanged);
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(19, 23)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(66, 17)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Pixel Type:"
            ' 
            ' cboPixelType
            ' 
            Me.cboPixelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboPixelType.Location = New System.Drawing.Point(106, 20)
            Me.cboPixelType.Name = "cboPixelType"
            Me.cboPixelType.Size = New System.Drawing.Size(115, 21)
            Me.cboPixelType.TabIndex = 1
            '			Me.cboPixelType.SelectedIndexChanged += New System.EventHandler(Me.cboPixelType_SelectedIndexChanged);
            ' 
            ' label2
            ' 
            Me.label2.Location = New System.Drawing.Point(19, 58)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(68, 18)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Resolution:"
            ' 
            ' cboResolution
            ' 
            Me.cboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboResolution.Location = New System.Drawing.Point(106, 56)
            Me.cboResolution.Name = "cboResolution"
            Me.cboResolution.Size = New System.Drawing.Size(115, 21)
            Me.cboResolution.TabIndex = 3
            '			Me.cboResolution.SelectedIndexChanged += New System.EventHandler(Me.cboResolution_SelectedIndexChanged);
            ' 
            ' label3
            ' 
            Me.label3.Location = New System.Drawing.Point(19, 94)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(136, 19)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Number of pages to scan::"
            ' 
            ' numPages
            ' 
            Me.numPages.Location = New System.Drawing.Point(174, 91)
            Me.numPages.Minimum = New System.Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.numPages.Name = "numPages"
            Me.numPages.Size = New System.Drawing.Size(45, 20)
            Me.numPages.TabIndex = 5
            Me.numPages.Value = New System.Decimal(New Integer() {1, 0, 0, -2147483648})
            '			Me.numPages.ValueChanged += New System.EventHandler(Me.numPages_ValueChanged);
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.chkAutoRotate)
            Me.groupBox1.Controls.Add(Me.chkAutoDeskew)
            Me.groupBox1.Controls.Add(Me.chkAutoBorder)
            Me.groupBox1.Controls.Add(Me.cboContrast)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.cboBrightness)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Location = New System.Drawing.Point(19, 136)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(211, 184)
            Me.groupBox1.TabIndex = 6
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Image Processing"
            ' 
            ' chkAutoRotate
            ' 
            Me.chkAutoRotate.Location = New System.Drawing.Point(24, 149)
            Me.chkAutoRotate.Name = "chkAutoRotate"
            Me.chkAutoRotate.Size = New System.Drawing.Size(130, 17)
            Me.chkAutoRotate.TabIndex = 6
            Me.chkAutoRotate.Text = "Automatic Rotation"
            '			Me.chkAutoRotate.CheckedChanged += New System.EventHandler(Me.chkAutoRotate_CheckedChanged);
            ' 
            ' chkAutoDeskew
            ' 
            Me.chkAutoDeskew.Location = New System.Drawing.Point(24, 117)
            Me.chkAutoDeskew.Name = "chkAutoDeskew"
            Me.chkAutoDeskew.Size = New System.Drawing.Size(132, 22)
            Me.chkAutoDeskew.TabIndex = 5
            Me.chkAutoDeskew.Text = "Automatic Deskew"
            '			Me.chkAutoDeskew.CheckedChanged += New System.EventHandler(Me.chkAutoDeskew_CheckedChanged);
            ' 
            ' chkAutoBorder
            ' 
            Me.chkAutoBorder.Location = New System.Drawing.Point(24, 90)
            Me.chkAutoBorder.Name = "chkAutoBorder"
            Me.chkAutoBorder.Size = New System.Drawing.Size(162, 17)
            Me.chkAutoBorder.TabIndex = 4
            Me.chkAutoBorder.Text = "Automatic Border Detection"
            '			Me.chkAutoBorder.CheckedChanged += New System.EventHandler(Me.chkAutoBorder_CheckedChanged);
            ' 
            ' cboContrast
            ' 
            Me.cboContrast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboContrast.Location = New System.Drawing.Point(94, 58)
            Me.cboContrast.Name = "cboContrast"
            Me.cboContrast.Size = New System.Drawing.Size(80, 21)
            Me.cboContrast.TabIndex = 3
            '			Me.cboContrast.SelectedIndexChanged += New System.EventHandler(Me.cboContrast_SelectedIndexChanged);
            ' 
            ' label5
            ' 
            Me.label5.Location = New System.Drawing.Point(24, 64)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(59, 16)
            Me.label5.TabIndex = 2
            Me.label5.Text = "Contrast:"
            ' 
            ' cboBrightness
            ' 
            Me.cboBrightness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBrightness.Location = New System.Drawing.Point(94, 32)
            Me.cboBrightness.Name = "cboBrightness"
            Me.cboBrightness.Size = New System.Drawing.Size(80, 21)
            Me.cboBrightness.TabIndex = 1
            '			Me.cboBrightness.SelectedIndexChanged += New System.EventHandler(Me.cboBrightness_SelectedIndexChanged);
            ' 
            ' label4
            ' 
            Me.label4.Location = New System.Drawing.Point(24, 33)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(64, 21)
            Me.label4.TabIndex = 0
            Me.label4.Text = "Brightness:"
            ' 
            ' btnScan
            ' 
            Me.btnScan.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnScan.Location = New System.Drawing.Point(90, 334)
            Me.btnScan.Name = "btnScan"
            Me.btnScan.Size = New System.Drawing.Size(99, 28)
            Me.btnScan.TabIndex = 8
            Me.btnScan.Text = "&Scan"
            '			Me.btnScan.Click += New System.EventHandler(Me.btnScan_Click);
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(352, 334)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(99, 28)
            Me.btnCancel.TabIndex = 9
            Me.btnCancel.Text = "&Cancel"
            ' 
            ' CustomInterface
            ' 
            Me.AcceptButton = Me.btnScan
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(541, 379)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnScan)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.numPages)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.cboResolution)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.cboPixelType)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.groupBarcode)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "CustomInterface"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Scan Settings"
            '			Me.Load += New System.EventHandler(Me.CustomInterface_Load);
            Me.groupBarcode.ResumeLayout(False)
            CType(Me.numTimeout, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numBarcodeSearch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numBarcodeRetries, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numPages, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        Private Sub CustomInterface_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' Setup the controls for this specific device.
            If Me._device Is Nothing Then
                MessageBox.Show("The device object has not been set.")
                Return
            End If

            If Me._device.State <> TwainState.SourceOpen Then
                MessageBox.Show("This dialog can only be used when the device state is SourceOpen.")
                Return
            End If

            If Me._device.QueryCapability(DeviceCapability.ICAP_PIXELTYPE, True) Then
                Dim pt As ImagePixelType() = Me._device.GetSupportedPixelTypes()
                For Each p As ImagePixelType In pt
                    Me.cboPixelType.Items.Add(p.ToString())
                Next p

                Me.cboPixelType.SelectedItem = Me._device.PixelType.ToString()
            Else
                Me.cboPixelType.Enabled = False
            End If

            If Me._device.QueryCapability(DeviceCapability.ICAP_XRESOLUTION, True) Then
                Dim res As TwainResolution() = Me._device.GetSupportedResolutions()
                For Each r As TwainResolution In res
                    Me.cboResolution.Items.Add(r.X.ToString(CultureInfo.InvariantCulture))
                Next r
                Me.cboResolution.SelectedItem = Me._device.Resolution.X.ToString(CultureInfo.InvariantCulture)
            Else
                Me.cboResolution.Enabled = False
            End If

            ' Every Twain driver must support this property.
            Me.numPages.Value = Me._device.TransferCount

            If Me._device.QueryCapability(DeviceCapability.ICAP_BRIGHTNESS, True) Then
                Dim vals As Single() = Me._device.GetSupportedBrightnessValues()
                For Each v As Single In vals
                    Me.cboBrightness.Items.Add(v.ToString(CultureInfo.InvariantCulture))
                Next v

                Me.cboBrightness.SelectedItem = Me._device.Brightness.ToString(CultureInfo.InvariantCulture)
            Else
                Me.cboBrightness.Enabled = False
            End If


            If Me._device.QueryCapability(DeviceCapability.ICAP_CONTRAST, True) Then
                Dim vals As Single() = Me._device.GetSupportedContrastValues()
                For Each v As Single In vals
                    Me.cboContrast.Items.Add(v.ToString(CultureInfo.InvariantCulture))
                Next v

                Me.cboContrast.SelectedItem = Me._device.Contrast.ToString(CultureInfo.InvariantCulture)
            Else
                Me.cboContrast.Enabled = False
            End If

            Me.chkAutoBorder.Enabled = Me._device.QueryCapability(DeviceCapability.ICAP_AUTOMATICBORDERDETECTION, True)
            Me.chkAutoDeskew.Enabled = Me._device.QueryCapability(DeviceCapability.ICAP_AUTOMATICDESKEW, True)
            Me.chkAutoRotate.Enabled = Me._device.QueryCapability(DeviceCapability.ICAP_AUTOMATICROTATE, True)

            ' If the device does not support ICAP_BARCODEDETECTIONENABLED, then it's not barcode enabled.
            If Me._device.QueryCapability(DeviceCapability.ICAP_BARCODEDETECTIONENABLED, True) Then
                ' Barcode has to be enabled to access the properties.
                Me._device.BarCode.DetectionEnabled = True
                If Me._device.BarCode.DetectionEnabled = False Then
                    Return
                End If

                Me.numBarcodeRetries.Enabled = Me._device.QueryCapability(DeviceCapability.ICAP_BARCODEMAXRETRIES, True)
                Me.numBarcodeSearch.Enabled = Me._device.QueryCapability(DeviceCapability.ICAP_BARCODEMAXSEARCHPRIORITIES, True)

                If Me._device.QueryCapability(DeviceCapability.ICAP_BARCODESEARCHMODE, True) Then
                    Dim modes As BarCodeSearchMode() = Me._device.BarCode.GetSearchModes()
                    For Each m As BarCodeSearchMode In modes
                        Me.cboBarcodeSearchMode.Items.Add(m.ToString())
                    Next m

                    Me.cboBarcodeSearchMode.SelectedItem = Me._device.BarCode.SearchMode.ToString()
                Else
                    Me.cboBarcodeSearchMode.Enabled = False
                End If

                If Me._device.QueryCapability(DeviceCapability.ICAP_BARCODESEARCHPRIORITIES, True) Then
                    Dim pris As BarCodeType() = Me._device.BarCode.GetSearchPriorities()
                    For Each bt As BarCodeType In pris
                        Me.listBarcodeSearch.Items.Add(bt.ToString())
                    Next bt
                Else
                    Me.listBarcodeSearch.Enabled = False
                End If
            Else
                Me.groupBarcode.Enabled = False
            End If
        End Sub

        Private Sub cboPixelType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPixelType.SelectedIndexChanged
            If Me._device Is Nothing Then Exit Sub
            Me._device.PixelType = CType(System.Enum.Parse(GetType(ImagePixelType), Me.cboPixelType.Text), ImagePixelType)
        End Sub

        Private Sub cboResolution_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboResolution.SelectedIndexChanged
            If Me._device Is Nothing Then Exit Sub
            Me._device.Resolution = New TwainResolution(Single.Parse(Me.cboResolution.Text), Single.Parse(Me.cboResolution.Text), UnitType.Inches)
        End Sub

        Private Sub numPages_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numPages.ValueChanged
            If Me._device Is Nothing Then Exit Sub

            ' A value of zero isn't truely supported.
            If Me.numPages.Value = 0 Then
                Me._device.TransferCount = -1
            Else
                Me._device.TransferCount = Convert.ToInt32(Me.numPages.Value)
            End If
        End Sub

        Private Sub cboBrightness_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBrightness.SelectedIndexChanged
            If Me._device Is Nothing Then Exit Sub
            Me._device.Brightness = Single.Parse(Me.cboBrightness.Text)
        End Sub

        Private Sub cboContrast_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboContrast.SelectedIndexChanged
            If Me._device Is Nothing Then Exit Sub
            Me._device.Contrast = Single.Parse(Me.cboContrast.Text)
        End Sub

        Private Sub chkAutoBorder_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAutoBorder.CheckedChanged
            If Me._device Is Nothing Then Exit Sub
            Me._device.AutomaticBorderDetection = Me.chkAutoBorder.Checked
        End Sub

        Private Sub chkAutoDeskew_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAutoDeskew.CheckedChanged
            If Me._device Is Nothing Then Exit Sub
            Me._device.AutomaticDeskew = Me.chkAutoDeskew.Checked
        End Sub

        Private Sub chkAutoRotate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAutoRotate.CheckedChanged
            If Me._device Is Nothing Then Exit Sub
            Me._device.AutomaticRotate = Me.chkAutoRotate.Checked
        End Sub

        Private Sub chkBarcodeEnabled_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBarcodeEnabled.CheckedChanged
            If Me._device Is Nothing Then Exit Sub
            Me._device.BarCode.DetectionEnabled = Me.chkBarcodeEnabled.Checked
        End Sub

        Private Sub numBarcodeRetries_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numBarcodeRetries.ValueChanged
            If Me._device Is Nothing Then Exit Sub
            If (Not Me.chkBarcodeEnabled.Checked) Then
                MessageBox.Show("Please enable barcode detection before setting any barcode properties.", "Information")
                Return
            End If

            Me._device.BarCode.MaximumRetries = Convert.ToInt32(Me.numBarcodeRetries.Value)
        End Sub

        Private Sub numBarcodeSearch_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numBarcodeSearch.ValueChanged
            If Me._device Is Nothing Then Exit Sub
            If (Not Me.chkBarcodeEnabled.Checked) Then
                MessageBox.Show("Please enable barcode detection before setting any barcode properties.", "Information")
                Return
            End If

            Me._device.BarCode.MaximumSearchPriorities = Convert.ToInt32(Me.numBarcodeSearch.Value)
        End Sub

        Private Sub cboBarcodeSearchMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBarcodeSearchMode.SelectedIndexChanged
            If Me._device Is Nothing Then Exit Sub
            If (Not Me.chkBarcodeEnabled.Checked) Then
                MessageBox.Show("Please enable barcode detection before setting any barcode properties.", "Information")
                Return
            End If

            Me._device.BarCode.SearchMode = CType(System.Enum.Parse(GetType(BarCodeSearchMode), Me.cboBarcodeSearchMode.Text), BarCodeSearchMode)
        End Sub

        Private Sub numTimeout_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numTimeout.ValueChanged
            If Me._device Is Nothing Then Exit Sub
            If (Not Me.chkBarcodeEnabled.Checked) Then
                MessageBox.Show("Please enable barcode detection before setting any barcode properties.", "Information")
                Return
            End If

            Me._device.BarCode.Timeout = Convert.ToInt32(Me.numTimeout.Value)
        End Sub

        Private Sub btnScan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnScan.Click
        End Sub

    End Class
End Namespace
