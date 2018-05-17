Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Reflection
Imports Atalasoft.Twain
Imports System.Collections.Generic

Namespace AcquisitionDemo
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1 : Inherits System.Windows.Forms.Form
        Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents panel1 As System.Windows.Forms.Panel
        Private WithEvents cboFrameSize As System.Windows.Forms.ComboBox
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents chkKeepInterfaceOpen As System.Windows.Forms.CheckBox
        Private WithEvents chkModalAcquire As System.Windows.Forms.CheckBox
        Private WithEvents chkHideProgress As System.Windows.Forms.CheckBox
        Private WithEvents chkHideInterface As System.Windows.Forms.CheckBox
        Private WithEvents cboResolution As System.Windows.Forms.ComboBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents cboBitDepth As System.Windows.Forms.ComboBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents cboPixelType As System.Windows.Forms.ComboBox
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents cboTransferMethod As System.Windows.Forms.ComboBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents cboDevice As System.Windows.Forms.ComboBox
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents tabImages As System.Windows.Forms.TabControl
        Private WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents toolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents capabilityInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents toolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents acquireFromParametersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents saveAcquireParametersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents acquireCustomInterfaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents acquireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents menuMain As System.Windows.Forms.MenuStrip
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Private _keepUIOpen As Boolean = False
        Private _infoDialog As InfoDialog = Nothing
        Private _fileDialogFilter As String = ""
        Private acquisition As Atalasoft.Twain.Acquisition
        Private device As Device = Nothing
        Private _scanCount As Integer
        Private _updatingValues As Boolean

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.device IsNot Nothing Then
                    Me.device.Close()
                End If
                If Me.acquisition IsNot Nothing Then
                    Me.acquisition.Dispose()
                End If

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.menuMain = New System.Windows.Forms.MenuStrip
            Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.acquireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.acquireCustomInterfaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
            Me.saveAcquireParametersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.acquireFromParametersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
            Me.capabilityInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
            Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.panel1 = New System.Windows.Forms.Panel
            Me.cboFrameSize = New System.Windows.Forms.ComboBox
            Me.label6 = New System.Windows.Forms.Label
            Me.chkKeepInterfaceOpen = New System.Windows.Forms.CheckBox
            Me.chkModalAcquire = New System.Windows.Forms.CheckBox
            Me.chkHideProgress = New System.Windows.Forms.CheckBox
            Me.chkHideInterface = New System.Windows.Forms.CheckBox
            Me.cboResolution = New System.Windows.Forms.ComboBox
            Me.label5 = New System.Windows.Forms.Label
            Me.cboBitDepth = New System.Windows.Forms.ComboBox
            Me.label4 = New System.Windows.Forms.Label
            Me.cboPixelType = New System.Windows.Forms.ComboBox
            Me.label3 = New System.Windows.Forms.Label
            Me.cboTransferMethod = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.cboDevice = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.tabImages = New System.Windows.Forms.TabControl
            Me.menuMain.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'menuMain
            '
            Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.helpToolStripMenuItem})
            Me.menuMain.Location = New System.Drawing.Point(0, 0)
            Me.menuMain.Name = "menuMain"
            Me.menuMain.Size = New System.Drawing.Size(690, 24)
            Me.menuMain.TabIndex = 3
            Me.menuMain.Text = "menuStrip1"
            '
            'fileToolStripMenuItem
            '
            Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.acquireToolStripMenuItem, Me.acquireCustomInterfaceToolStripMenuItem, Me.toolStripMenuItem1, Me.saveAcquireParametersToolStripMenuItem, Me.acquireFromParametersToolStripMenuItem, Me.toolStripMenuItem2, Me.capabilityInformationToolStripMenuItem, Me.toolStripMenuItem3, Me.exitToolStripMenuItem})
            Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
            Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
            Me.fileToolStripMenuItem.Text = "&File"
            '
            'acquireToolStripMenuItem
            '
            Me.acquireToolStripMenuItem.Name = "acquireToolStripMenuItem"
            Me.acquireToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
            Me.acquireToolStripMenuItem.Text = "&Acquire"
            '
            'acquireCustomInterfaceToolStripMenuItem
            '
            Me.acquireCustomInterfaceToolStripMenuItem.Name = "acquireCustomInterfaceToolStripMenuItem"
            Me.acquireCustomInterfaceToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
            Me.acquireCustomInterfaceToolStripMenuItem.Text = "Acquire (Custom Interface)"
            '
            'toolStripMenuItem1
            '
            Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
            Me.toolStripMenuItem1.Size = New System.Drawing.Size(213, 6)
            '
            'saveAcquireParametersToolStripMenuItem
            '
            Me.saveAcquireParametersToolStripMenuItem.Name = "saveAcquireParametersToolStripMenuItem"
            Me.saveAcquireParametersToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
            Me.saveAcquireParametersToolStripMenuItem.Text = "Save Acquire Parameters"
            '
            'acquireFromParametersToolStripMenuItem
            '
            Me.acquireFromParametersToolStripMenuItem.Name = "acquireFromParametersToolStripMenuItem"
            Me.acquireFromParametersToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
            Me.acquireFromParametersToolStripMenuItem.Text = "Acquire From Parameters"
            '
            'toolStripMenuItem2
            '
            Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
            Me.toolStripMenuItem2.Size = New System.Drawing.Size(213, 6)
            '
            'capabilityInformationToolStripMenuItem
            '
            Me.capabilityInformationToolStripMenuItem.Name = "capabilityInformationToolStripMenuItem"
            Me.capabilityInformationToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
            Me.capabilityInformationToolStripMenuItem.Text = "Capability Information..."
            '
            'toolStripMenuItem3
            '
            Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
            Me.toolStripMenuItem3.Size = New System.Drawing.Size(213, 6)
            '
            'exitToolStripMenuItem
            '
            Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
            Me.exitToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
            Me.exitToolStripMenuItem.Text = "E&xit"
            '
            'helpToolStripMenuItem
            '
            Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem})
            Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
            Me.helpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
            Me.helpToolStripMenuItem.Text = "&Help"
            '
            'aboutToolStripMenuItem
            '
            Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
            Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
            Me.aboutToolStripMenuItem.Text = "&About..."
            '
            'panel1
            '
            Me.panel1.AutoScroll = True
            Me.panel1.Controls.Add(Me.cboFrameSize)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.chkKeepInterfaceOpen)
            Me.panel1.Controls.Add(Me.chkModalAcquire)
            Me.panel1.Controls.Add(Me.chkHideProgress)
            Me.panel1.Controls.Add(Me.chkHideInterface)
            Me.panel1.Controls.Add(Me.cboResolution)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.cboBitDepth)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.cboPixelType)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.cboTransferMethod)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.cboDevice)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel1.Location = New System.Drawing.Point(0, 24)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(174, 431)
            Me.panel1.TabIndex = 4
            '
            'cboFrameSize
            '
            Me.cboFrameSize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboFrameSize.FormattingEnabled = True
            Me.cboFrameSize.Location = New System.Drawing.Point(15, 292)
            Me.cboFrameSize.Name = "cboFrameSize"
            Me.cboFrameSize.Size = New System.Drawing.Size(142, 21)
            Me.cboFrameSize.TabIndex = 18
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(12, 276)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(62, 13)
            Me.label6.TabIndex = 17
            Me.label6.Text = "Frame Size:"
            '
            'chkKeepInterfaceOpen
            '
            Me.chkKeepInterfaceOpen.AutoSize = True
            Me.chkKeepInterfaceOpen.Location = New System.Drawing.Point(15, 402)
            Me.chkKeepInterfaceOpen.Name = "chkKeepInterfaceOpen"
            Me.chkKeepInterfaceOpen.Size = New System.Drawing.Size(125, 17)
            Me.chkKeepInterfaceOpen.TabIndex = 16
            Me.chkKeepInterfaceOpen.Text = "Keep Interface Open"
            Me.chkKeepInterfaceOpen.UseVisualStyleBackColor = True
            '
            'chkModalAcquire
            '
            Me.chkModalAcquire.AutoSize = True
            Me.chkModalAcquire.Location = New System.Drawing.Point(15, 379)
            Me.chkModalAcquire.Name = "chkModalAcquire"
            Me.chkModalAcquire.Size = New System.Drawing.Size(94, 17)
            Me.chkModalAcquire.TabIndex = 15
            Me.chkModalAcquire.Text = "Modal Acquire"
            Me.chkModalAcquire.UseVisualStyleBackColor = True
            '
            'chkHideProgress
            '
            Me.chkHideProgress.AutoSize = True
            Me.chkHideProgress.Location = New System.Drawing.Point(15, 356)
            Me.chkHideProgress.Name = "chkHideProgress"
            Me.chkHideProgress.Size = New System.Drawing.Size(125, 17)
            Me.chkHideProgress.TabIndex = 14
            Me.chkHideProgress.Text = "Hide Progress Dialog"
            Me.chkHideProgress.UseVisualStyleBackColor = True
            '
            'chkHideInterface
            '
            Me.chkHideInterface.AutoSize = True
            Me.chkHideInterface.Location = New System.Drawing.Point(15, 333)
            Me.chkHideInterface.Name = "chkHideInterface"
            Me.chkHideInterface.Size = New System.Drawing.Size(130, 17)
            Me.chkHideInterface.TabIndex = 13
            Me.chkHideInterface.Text = "Hide Device Interface"
            Me.chkHideInterface.UseVisualStyleBackColor = True
            '
            'cboResolution
            '
            Me.cboResolution.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboResolution.FormattingEnabled = True
            Me.cboResolution.Location = New System.Drawing.Point(15, 241)
            Me.cboResolution.Name = "cboResolution"
            Me.cboResolution.Size = New System.Drawing.Size(142, 21)
            Me.cboResolution.TabIndex = 12
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(12, 225)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(60, 13)
            Me.label5.TabIndex = 11
            Me.label5.Text = "Resolution:"
            '
            'cboBitDepth
            '
            Me.cboBitDepth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboBitDepth.FormattingEnabled = True
            Me.cboBitDepth.Location = New System.Drawing.Point(15, 186)
            Me.cboBitDepth.Name = "cboBitDepth"
            Me.cboBitDepth.Size = New System.Drawing.Size(142, 21)
            Me.cboBitDepth.TabIndex = 10
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(12, 170)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(54, 13)
            Me.label4.TabIndex = 9
            Me.label4.Text = "Bit Depth:"
            '
            'cboPixelType
            '
            Me.cboPixelType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboPixelType.FormattingEnabled = True
            Me.cboPixelType.Location = New System.Drawing.Point(15, 131)
            Me.cboPixelType.Name = "cboPixelType"
            Me.cboPixelType.Size = New System.Drawing.Size(142, 21)
            Me.cboPixelType.TabIndex = 8
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(12, 115)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(59, 13)
            Me.label3.TabIndex = 7
            Me.label3.Text = "Pixel Type:"
            '
            'cboTransferMethod
            '
            Me.cboTransferMethod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboTransferMethod.FormattingEnabled = True
            Me.cboTransferMethod.Location = New System.Drawing.Point(15, 79)
            Me.cboTransferMethod.Name = "cboTransferMethod"
            Me.cboTransferMethod.Size = New System.Drawing.Size(142, 21)
            Me.cboTransferMethod.TabIndex = 6
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(12, 63)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(88, 13)
            Me.label2.TabIndex = 5
            Me.label2.Text = "Transfer Method:"
            '
            'cboDevice
            '
            Me.cboDevice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDevice.FormattingEnabled = True
            Me.cboDevice.Items.AddRange(New Object() {"Select Source..."})
            Me.cboDevice.Location = New System.Drawing.Point(15, 29)
            Me.cboDevice.Name = "cboDevice"
            Me.cboDevice.Size = New System.Drawing.Size(142, 21)
            Me.cboDevice.TabIndex = 4
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(12, 13)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(44, 13)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Device:"
            '
            'tabImages
            '
            Me.tabImages.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabImages.Location = New System.Drawing.Point(174, 24)
            Me.tabImages.Name = "tabImages"
            Me.tabImages.SelectedIndex = 0
            Me.tabImages.Size = New System.Drawing.Size(516, 431)
            Me.tabImages.TabIndex = 5
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(690, 455)
            Me.Controls.Add(Me.tabImages)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.menuMain)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.Text = "Acquisition Demo"
            Me.menuMain.ResumeLayout(False)
            Me.menuMain.PerformLayout()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Try
                Application.Run(New Form1())
            Catch ex As Exception
                MessageBox.Show(ex.Message & Constants.vbCrLf & Constants.vbCrLf & "Stack Trace:" & Constants.vbCrLf & ex.StackTrace, "Exception")
            End Try
        End Sub


        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.acquisition = New Acquisition()

            AddHandler acquisition.AsynchronousException, AddressOf acquisition_AsynchronousException
            AddHandler acquisition.AcquireCanceled, AddressOf acquisition_AcquireCanceled
            AddHandler acquisition.AcquireFinished, AddressOf acquisition_AcquireFinished
            AddHandler acquisition.DeviceEvent, AddressOf acquisition_DeviceEvent
            AddHandler acquisition.FileTransfer, AddressOf acquisition_FileTransfer
            AddHandler acquisition.ImageAcquired, AddressOf acquisition_ImageAcquired

            ShowInfoDialog("Loading devices...")
            LoadDeviceNames()
            HideInfoDialog()
        End Sub

        Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If Me.device IsNot Nothing AndAlso Me.device.State > TwainState.Loaded Then
                Me.device.Close()
            End If

            Me.acquisition.Dispose()
        End Sub

#Region "Acquisition Events"

        Private Sub acquisition_AcquireCanceled(ByVal sender As Object, ByVal e As System.EventArgs)
            ' If we are keeping the interface open between scans,
            ' the user will have to click 'Cancel' to close it.
            If Me._keepUIOpen Then
                Me.device.Disable()
            End If

            Me.device.Close()
            EnableDisableMenus(True)
        End Sub

        Private Sub acquisition_AcquireFinished(ByVal sender As Object, ByVal e As System.EventArgs)
            ' This is the only event where you should call the Close method.
            ' AcquireFinished fires after all images have been acquired.
            ' Note that you can call Close anytime if you need to cancel
            ' any pending transfers and do a quick shutdown of your application.
            If Me._keepUIOpen = False Then
                Me.device.Close()
                EnableDisableMenus(True)
            End If
        End Sub

        Private Sub acquisition_ImageAcquired(ByVal sender As Object, ByVal e As Atalasoft.Twain.AcquireEventArgs)
            _scanCount += 1

            ' Add a new tab for the image.
            Dim tab As New TabPage()
            tab.AutoScroll = True
            Dim pic As New PictureBox()
            tab.Controls.Add(pic)
            Me.tabImages.TabPages.Add(tab)

            If e.Image IsNot Nothing Then
                tab.Text = "Scan " & _scanCount.ToString()
                pic.Image = e.Image
            ElseIf e.FileName IsNot Nothing AndAlso File.Exists(e.FileName) Then
                tab.Text = Path.GetFileName(e.FileName)

                Using fs As FileStream = New FileStream(e.FileName, FileMode.Open, FileAccess.Read, FileShare.Read)
                    pic.Image = New Bitmap(fs)
                End Using
            End If

            pic.Width = pic.Image.Width
            pic.Height = pic.Image.Height
        End Sub

        Private Sub acquisition_FileTransfer(ByVal sender As Object, ByVal e As Atalasoft.Twain.FileTransferEventArgs)
            ' This will fire before a file transfer takes place to
            ' allow you to set the filename and format of this image.
            ' Once the file is acquired and saved, the ImageAcquired
            ' event fires with the filename of the image just saved.
            Dim dlg As New SaveFileDialog()
            dlg.Filter = Me._fileDialogFilter
            If dlg.ShowDialog(Me) = DialogResult.OK Then
                ' Delete the existing file.
                Try
                    If File.Exists(dlg.FileName) Then
                        File.Delete(dlg.FileName)
                    End If
                Catch ex As Exception
                    MessageBox.Show("There was an error trying to delete the file.\r\n\r\n" + ex.Message, "Delete File Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    e.CancelPending = True
                    Return
                End Try

                e.FileName = dlg.FileName
                Dim filters() As String = dlg.Filter.Split("|"c)
                Select Case filters((dlg.FilterIndex - 1) * 2)
                    Case "TIFF (*.tif)"
                        e.FileFormat = SourceImageFormat.Tiff
                    Case "JPEG (*.jpg)"
                        e.FileFormat = SourceImageFormat.Jfif
                    Case "PNG (*.png)"
                        e.FileFormat = SourceImageFormat.Png
                    Case "Multipage TIFF (*.tif)"
                        e.FileFormat = SourceImageFormat.TiffMulti
                    Case "XBM (*.xbm)"
                        e.FileFormat = SourceImageFormat.Xbm
                    Case "PDF (*.pdf)"
                        e.FileFormat = SourceImageFormat.Pdf
                    Case "JPEG 2000 (*.jp2)"
                        e.FileFormat = SourceImageFormat.Jpeg2000
                    Case Else
                        e.FileFormat = SourceImageFormat.Bmp
                End Select
            Else
                e.CancelPending = True
            End If

            dlg.Dispose()
        End Sub


        Private Sub acquisition_DeviceEvent(ByVal sender As Object, ByVal e As Atalasoft.Twain.DeviceEventArgs)
            ' One of the many device events has fired.
            ' You will only receive the events you have set using
            ' the Device.DeviceEvents property.
            If e.Event = DeviceEventFlags.PaperJam Then
                MessageBox.Show(Me, "Paper jam!!!")
            Else
                MessageBox.Show(Me, "Device Event:  " & e.Event.ToString())
            End If
        End Sub

        Private Sub acquisition_AsynchronousException(ByVal sender As Object, ByVal e As Atalasoft.Twain.AsynchronousExceptionEventArgs)
            ' Make sure you close the connection when there is an error during a scan.
            Me.device.Close()
            MessageBox.Show(Me, e.Exception.Message, "Asynchronous Exception")
        End Sub
#End Region

#Region "Private Methods"

        Private _disabledControls As List(Of ComboBox) = New List(Of ComboBox)()
        Private Sub EnableDisableMenus(ByVal enabled As Boolean)
            Me.fileToolStripMenuItem.Enabled = enabled

            Me.cboDevice.Enabled = enabled
            Me.cboTransferMethod.Enabled = enabled

            ' We do this so controls that are disabled 
            If enabled Then
                Dim len As Integer = _disabledControls.Count
                For i As Integer = 0 To len - 1
                    Dim box As ComboBox = _disabledControls(i)
                    box.Enabled = True
                Next i
            Else
                If Me.cboPixelType.Enabled Then
                    Me.cboPixelType.Enabled = False
                    _disabledControls.Add(Me.cboPixelType)
                End If

                If Me.cboBitDepth.Enabled Then
                    Me.cboBitDepth.Enabled = False
                    _disabledControls.Add(Me.cboBitDepth)
                End If

                If Me.cboResolution.Enabled Then
                    Me.cboResolution.Enabled = False
                    _disabledControls.Add(Me.cboResolution)
                End If

                If Me.cboFrameSize.Enabled Then
                    Me.cboFrameSize.Enabled = False
                    _disabledControls.Add(Me.cboFrameSize)
                End If
            End If
        End Sub

        Private Sub ClearTabs()
            ' Calling TabPages.Clear will not release the memory
            ' used by the images, so we have to dispose them manually.
            For Each page As TabPage In Me.tabImages.TabPages
                Dim pic As PictureBox = TryCast(page.Controls(0), PictureBox)
                If pic IsNot Nothing Then
                    page.Controls.Remove(pic)
                    If pic.Image IsNot Nothing Then
                        pic.Image.Dispose()
                    End If
                    pic.Dispose()
                End If
            Next page

            Me.tabImages.TabPages.Clear()
        End Sub

        Private Sub ShowInfoDialog(ByVal message As String)
            Me._infoDialog = New InfoDialog("Loading devices...")
            Dim rc As Rectangle = Screen.PrimaryScreen.WorkingArea
            Me._infoDialog.Show()
            Application.DoEvents()
        End Sub

        Private Sub HideInfoDialog()
            Me._infoDialog.Close()
            Me._infoDialog.Dispose()
            Me._infoDialog = Nothing
        End Sub

        Private Sub LoadDeviceNames()
            ' Never assume that a system has any acquisition devices.
            If (Not Me.acquisition.SystemHasTwain) OrElse Me.acquisition.Devices.Count = 0 Then
                Return
            End If

            Dim defaultDevice As String = Me.acquisition.Devices.Default.Identity.ProductName

            ' Add a menu item for each device.
            For Each dev As Device In Me.acquisition.Devices
                Me.cboDevice.Items.Add(dev.Identity.ProductName)
            Next dev

            Dim index As Integer = Me.cboDevice.Items.IndexOf(defaultDevice)
            If index > -1 Then
                Me.cboDevice.SelectedIndex = index
            End If
        End Sub

        Private Sub FillDeviceInformation()
            If Me.device Is Nothing Then
                Return
            End If

            Me.Cursor = Cursors.WaitCursor
            If Me.device.TryOpen() Then
                Try
                    _updatingValues = True
                    UpdateTransferMethodValues()
                    UpdatePixelTypeValues()
                    UpdateBitDepthValues()
                    UpdateResolutionValues()
                    UpdateFrameSizeValues()
                Finally
                    _updatingValues = False
                    Me.device.Close()
                End Try
            End If
            Me.Cursor = Cursors.Default
        End Sub

        Private Sub UpdateTransferMethodValues()
            Me.cboTransferMethod.Items.Clear()
            If Me.device.QueryCapability(DeviceCapability.ICAP_XFERMECH, True) Then
                Me.cboTransferMethod.Enabled = True

                Dim methods() As TwainTransferMethod = Me.device.GetSupportedTransferMethods()
                For Each method As TwainTransferMethod In methods
                    Me.cboTransferMethod.Items.Add(method)
                Next method

                Dim index As Integer = Me.cboTransferMethod.Items.IndexOf(Me.device.TransferMethod)
                If index > -1 Then
                    Me.cboTransferMethod.SelectedIndex = index
                End If
            Else
                Me.cboTransferMethod.Enabled = False
            End If
        End Sub

        Private Sub UpdatePixelTypeValues()
            Me.cboPixelType.Items.Clear()
            If Me.device.QueryCapability(DeviceCapability.ICAP_PIXELTYPE, True) Then
                Me.cboPixelType.Enabled = True

                Dim pixelTypes() As ImagePixelType = Me.device.GetSupportedPixelTypes()
                For Each pt As ImagePixelType In pixelTypes
                    Me.cboPixelType.Items.Add(pt)
                Next pt

                Dim index As Integer = Me.cboPixelType.Items.IndexOf(Me.device.PixelType)
                If index > -1 Then
                    Me.cboPixelType.SelectedIndex = index
                End If
            Else
                Me.cboPixelType.Enabled = False
            End If
        End Sub

        Private Sub UpdateBitDepthValues()
            Me.cboBitDepth.Items.Clear()
            If Me.device.QueryCapability(DeviceCapability.ICAP_BITDEPTH, True) Then
                Me.cboBitDepth.Enabled = True

                Dim bitDepths() As Integer = Me.device.GetSupportedBitDepths()
                For Each bd As Integer In bitDepths
                    Me.cboBitDepth.Items.Add(bd)
                Next bd

                Dim index As Integer = Me.cboBitDepth.Items.IndexOf(Me.device.BitDepth)
                If index > -1 Then
                    Me.cboBitDepth.SelectedIndex = index
                End If
            Else
                Me.cboBitDepth.Enabled = False
            End If
        End Sub

        Private Sub UpdateResolutionValues()
            Me.cboResolution.Items.Clear()
            If Me.device.QueryCapability(DeviceCapability.ICAP_XRESOLUTION, True) Then
                Me.cboResolution.Enabled = True

                Dim resolutions() As TwainResolution = Me.device.GetSupportedResolutions()
                For Each res As TwainResolution In resolutions
                    Me.cboResolution.Items.Add(res.X.ToString() & ", " & res.Y.ToString())
                Next res

                Dim resolution As TwainResolution = Me.device.Resolution
                Dim index As Integer = Me.cboResolution.Items.IndexOf(resolution.X.ToString() & ", " & resolution.Y.ToString())
                If index > -1 Then
                    Me.cboResolution.SelectedIndex = index
                End If
            Else
                Me.cboResolution.Enabled = False
            End If
        End Sub

        Private Sub UpdateFrameSizeValues()
            Me.cboFrameSize.Items.Clear()
            If Me.device.QueryCapability(DeviceCapability.ICAP_SUPPORTEDSIZES, True) Then
                Me.cboFrameSize.Enabled = True

                Dim frameSizes() As StaticFrameSizeType = Me.device.GetSupportedFrameSizes()
                For Each fs As StaticFrameSizeType In frameSizes
                    Me.cboFrameSize.Items.Add(fs)
                Next fs

                Dim index As Integer = Me.cboFrameSize.Items.IndexOf(Me.device.FrameSize)
                If index > -1 Then
                    Me.cboFrameSize.SelectedIndex = index
                End If
            Else
                Me.cboFrameSize.Enabled = False
            End If
        End Sub

        Private Sub SetResolutionValue()
            If Me.cboResolution.Enabled = False Then
                Return
            End If

            Dim val() As String = Me.cboResolution.Text.Split(","c)
            Dim x, y As Single
            If Single.TryParse(val(0).Trim(), x) AndAlso Single.TryParse(val(1).Trim(), y) Then
                Me.device.Resolution = New TwainResolution(x, y)
            End If
        End Sub
#End Region

#Region "Menu Events"

        Private Sub acquireToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles acquireToolStripMenuItem.Click
            ' Perform a normal acquire.
            ClearTabs()

            If Me.device Is Nothing Then
                Me.device = Me.acquisition.Devices.Default
            End If

            If Me.device.TryOpen() Then
                If Me.cboTransferMethod.Enabled AndAlso Me.cboTransferMethod.SelectedIndex <> -1 Then
                    Me.device.TransferMethod = CType(Me.cboTransferMethod.SelectedItem, TwainTransferMethod)
                End If
                If Me.cboPixelType.Enabled AndAlso Me.cboPixelType.SelectedIndex <> -1 Then
                    Me.device.PixelType = CType(Me.cboPixelType.SelectedItem, ImagePixelType)
                End If
                If Me.cboBitDepth.Enabled AndAlso Me.cboBitDepth.SelectedIndex <> -1 Then
                    Me.device.BitDepth = CInt(Fix(Me.cboBitDepth.SelectedItem))
                End If

                SetResolutionValue()

                If Me.cboFrameSize.Enabled AndAlso Me.cboFrameSize.SelectedIndex <> -1 Then
                    Me.device.FrameSize = CType(Me.cboFrameSize.SelectedItem, StaticFrameSizeType)
                End If

                Me.device.HideInterface = Me.chkHideInterface.Checked
                Me.device.ModalAcquire = Me.chkModalAcquire.Checked
                Me.device.DisplayProgressIndicator = Not Me.chkHideProgress.Checked

                EnableDisableMenus(False)

                ' If the transfer method is FILE, get a list of supported file types.
                Dim tm As TwainTransferMethod = Me.device.TransferMethod
                If tm = TwainTransferMethod.TWSX_FILE OrElse tm = TwainTransferMethod.TWSX_FILE2 Then
                    _fileDialogFilter = ""
                    Dim sb As New System.Text.StringBuilder()

                    Dim formats() As SourceImageFormat = Me.device.GetSupportedImageFormats()
                    For Each format As SourceImageFormat In formats
                        Select Case format
                            Case SourceImageFormat.Bmp
                                sb.Append("Bitmap (*.bmp)|*.bmp|")
                            Case SourceImageFormat.Jfif
                                sb.Append("JPEG (*.jpg)|*.jpg|")
                            Case SourceImageFormat.Jpeg2000
                                sb.Append("JPEG 2000 (*.jp2)|*.jp2|")
                            Case SourceImageFormat.Pdf
                                sb.Append("PDF (*.pdf)|*.pdf|")
                            Case SourceImageFormat.Png
                                sb.Append("PNG (*.png)|*.png|")
                            Case SourceImageFormat.Tiff
                                sb.Append("TIFF (*.tif)|*.tif|")
                            Case SourceImageFormat.TiffMulti
                                sb.Append("Multipage TIFF (*.tif)|*.tif|")
                            Case SourceImageFormat.Xbm
                                sb.Append("XBM (*.xbm)|*.xbm|")
                        End Select
                    Next format

                    _fileDialogFilter = sb.ToString(0, sb.Length - 1)
                End If

                ' If you want to keep the interface open between scans, 
                ' use Enable instead of Acquire and call Disable in AcquireCanceled.
                If Me._keepUIOpen Then
                    Me.device.Enable()
                Else
                    Me.device.Acquire()
                End If
            Else
                MessageBox.Show("We were unable to open a connection to the device.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Private Sub acquireCustomInterfaceToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles acquireCustomInterfaceToolStripMenuItem.Click
            ClearTabs()

            ' Use our custom interface instead of the driver interface.
            ' Note that the driver always has the option to show its own interface
            ' even when asked to hide it.

            If Me.device Is Nothing Then
                Me.device = Me.acquisition.Devices.Default
            End If

            Dim ci As CustomInterface = Nothing

            Try
                If Me.device.TryOpen() Then
                    Me.device.HideInterface = True
                    Me.device.DisplayProgressIndicator = False

                    ci = New CustomInterface(Me.device)
                    If ci.ShowDialog(Me) = DialogResult.OK Then
                        EnableDisableMenus(False)
                        Me.device.Acquire()
                    Else
                        Me.device.Close()
                    End If
                Else
                    MessageBox.Show("We were unable to open a connection to the device.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message)
                Me.device.Close()
            Finally
                If ci IsNot Nothing Then
                    ci.Dispose()
                End If
            End Try
        End Sub

        Private Sub saveAcquireParametersToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveAcquireParametersToolStripMenuItem.Click
            ' This will show the scanner interface without scanning to
            ' allow users to select the settings they want to use in
            ' a future scan.  It will then save those settings to file.

            If Me.device Is Nothing Then
                Return
            End If

            If Me.device.TryOpen() Then
                Try
                    If Me.device.EnableInterfaceOnly Then
                        If Me.device.ShowUserInterface() Then
                            Using dlg As New SaveFileDialog()
                                Dim customData As Boolean = Me.device.QueryCapability(DeviceCapability.CAP_CUSTOMDSDATA, False)

                                dlg.Filter = "Twain Parameters|*." & (If(customData, "ini", "xml"))
                                If dlg.ShowDialog(Me) = DialogResult.OK Then
                                    Using fs As New FileStream(dlg.FileName, FileMode.Create, FileAccess.Write, FileShare.None)
                                        ' CAP_CUSTOMDSDATA is read only, so make sure to pass 'false' for 'canSet'.
                                        If customData Then
                                            Me.device.SaveParameters(fs)
                                        Else
                                            Me.device.SaveXmlParameters(fs)
                                        End If
                                    End Using
                                End If
                            End Using
                        End If
                    Else
                        MessageBox.Show("The device does not support this feature.", "Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Finally
                    Me.device.Close()
                End Try
            Else
                MessageBox.Show("We were unable to connect to the device.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Private Sub acquireFromParametersToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles acquireFromParametersToolStripMenuItem.Click
            ' This will load a previously saved setting file and hide
            ' the scanner interface when scanning.

            If Me.device.TryOpen() Then
                Try
                    Using dlg As New OpenFileDialog()
                        Dim customData As Boolean = Me.device.QueryCapability(DeviceCapability.CAP_CUSTOMDSDATA, False)

                        dlg.Filter = "Twain Parameters|*." & (If(customData, "ini", "xml"))
                        If dlg.ShowDialog(Me) = DialogResult.OK Then
                            Using fs As New FileStream(dlg.FileName, FileMode.Open, FileAccess.Read, FileShare.Read)
                                If customData Then
                                    Me.device.LoadParameters(fs)
                                Else
                                    Me.device.LoadXmlParameters(fs)
                                End If
                            End Using

                            EnableDisableMenus(False)

                            Me.device.HideInterface = True
                            Me.device.DisplayProgressIndicator = False
                            Me.device.Acquire()
                        End If
                    End Using
                Catch ex As Exception
                    Me.device.Close()
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

        Private Sub capabilityInformationToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles capabilityInformationToolStripMenuItem.Click
            If Me.device Is Nothing Then
                Return
            End If

            If Me.device.TryOpen() Then
                Try
                    Dim info As New DeviceCapabilityInformation(Me.device)
                    info.ShowDialog(Me)
                    info.Dispose()
                Finally
                    Me.device.Close()
                End Try
            End If
        End Sub

        Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
            Me.Close()
        End Sub

        Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
            Dim dlg As New AboutDialog()
            dlg.ShowDialog(Me)
            dlg.Dispose()
        End Sub
#End Region

#Region "ComboBox Events"

        Private Sub cboDevice_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboDevice.SelectedIndexChanged
            If Me.cboDevice.Text = "Select Source..." Then
                ' Display the select source dialog.
                ' If the user cancels the dialog the return value is the default device.
                Dim dev As Device = Me.acquisition.ShowSelectSource()
                If dev Is Nothing Then
                    Return
                End If

                Me.device = dev
            Else
                Me.device = Me.acquisition.Devices.GetDevice(Me.cboDevice.Text)
            End If

            FillDeviceInformation()
        End Sub

        Private Sub cboTransferMethod_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTransferMethod.SelectedIndexChanged
            If _updatingValues Then
                Return
            End If

            Me.Cursor = Cursors.WaitCursor
            If Me.device.TryOpen() Then
                Try
                    Me.device.TransferMethod = CType(Me.cboTransferMethod.SelectedItem, TwainTransferMethod)

                    _updatingValues = True
                    UpdatePixelTypeValues()
                    UpdateBitDepthValues()
                Finally
                    _updatingValues = False
                    Me.device.Close()
                End Try
            End If
            Me.Cursor = Cursors.Default
        End Sub

        Private Sub cboPixelType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboPixelType.SelectedIndexChanged
            If _updatingValues Then
                Return
            End If

            Me.Cursor = Cursors.WaitCursor
            If Me.device.TryOpen() Then
                Try
                    Me.device.PixelType = CType(Me.cboPixelType.SelectedItem, ImagePixelType)

                    _updatingValues = True
                    UpdateBitDepthValues()
                Finally
                    _updatingValues = False
                    Me.device.Close()
                End Try
            End If
            Me.Cursor = Cursors.Default
        End Sub

#End Region

        ' You can't have both Keep Interface Open and Hide Interface enabled.
        Private Sub chkKeepInterfaceOpen_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkKeepInterfaceOpen.CheckedChanged
            Me._keepUIOpen = Me.chkKeepInterfaceOpen.Checked
            If _keepUIOpen Then
                Me.chkHideInterface.Checked = False
            End If
            Me.chkHideInterface.Enabled = Not _keepUIOpen
        End Sub

        Private Sub chkHideInterface_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkHideInterface.CheckedChanged
            Dim disable As Boolean = Not Me.chkHideInterface.Checked
            If disable Then
                Me.chkKeepInterfaceOpen.Checked = False
            End If
            Me.chkKeepInterfaceOpen.Enabled = disable
        End Sub
    End Class
End Namespace
