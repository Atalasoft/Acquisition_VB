Public Class AboutDialog

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.Load("Atalasoft.DotTwain")
        Me.lblVersion.Text = "Version: " & asm.GetName().Version.ToString()
    End Sub


    Private Sub linkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        System.Diagnostics.Process.Start("www.atalasoft.com")
    End Sub

    Private Sub downloadHelpLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles downloadHelpLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("www.atalasoft.com/support/dotimage/help/install")
    End Sub

    Private Sub demoGalleryLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles demoGalleryLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("www.atalasoft.com/Support/Sample-Applications")
    End Sub

    Private Sub downloadDotImageLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles downloadDotImageLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("www.atalasoft.com/products/download/dotimage")
    End Sub
End Class