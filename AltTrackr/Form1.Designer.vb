<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.webControl = New EO.WinForm.WebControl()
        Me.webView = New EO.WebBrowser.WebView()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'webControl
        '
        Me.webControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webControl.BackColor = System.Drawing.Color.White
        Me.webControl.Location = New System.Drawing.Point(0, 0)
        Me.webControl.Name = "webControl"
        Me.webControl.Size = New System.Drawing.Size(852, 126)
        Me.webControl.TabIndex = 0
        Me.webControl.Text = "AltTrackr"
        Me.webControl.WebView = Me.webView
        '
        'webView
        '
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Enabled = True
        Me.tmrRefresh.Interval = 60000
        '
        'lblLoading
        '
        Me.lblLoading.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.lblLoading.Location = New System.Drawing.Point(12, 9)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(251, 37)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "AltTrackr is Loading..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(852, 126)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.webControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents webControl As EO.WinForm.WebControl
    Friend WithEvents webView As EO.WebBrowser.WebView
    Friend WithEvents tmrRefresh As Timer
    Friend WithEvents lblLoading As Label
End Class
