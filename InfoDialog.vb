Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace AcquisitionDemo
    ''' <summary>
    ''' Summary description for InfoDialog.
    ''' </summary>
    Public Class InfoDialog : Inherits System.Windows.Forms.Form
        Private WithEvents lblInfo As System.Windows.Forms.Label
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New(ByVal message As String)
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            Me.lblInfo.Text = message
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
            Me.lblInfo = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            ' 
            ' lblInfo
            ' 
            Me.lblInfo.Location = New System.Drawing.Point(11, 7)
            Me.lblInfo.Name = "lblInfo"
            Me.lblInfo.Size = New System.Drawing.Size(270, 94)
            Me.lblInfo.TabIndex = 0
            Me.lblInfo.Text = "Working... Please wait."
            Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '			Me.lblInfo.TextChanged += New System.EventHandler(Me.lblInfo_TextChanged);
            ' 
            ' InfoDialog
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(292, 109)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblInfo)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "InfoDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.TopMost = True
            Me.ResumeLayout(False)

        End Sub
#End Region

        Private Sub lblInfo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblInfo.TextChanged
            Me.Refresh()
            Application.DoEvents()
        End Sub
    End Class
End Namespace
