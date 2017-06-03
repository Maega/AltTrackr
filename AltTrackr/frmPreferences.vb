Public Class frmPreferences
    Private Sub frmPreferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFiat.Items.AddRange(Form1.fiats)
        cmbFiat.Text = My.Settings.tickerFiat
        cmbCoin.Items.AddRange(Form1.coins)
        cmbCoin.Text = My.Settings.tickerCoin
        chkShowInTaskbar.Checked = My.Settings.appTaskbarIcon
        numWidth.Value = My.Settings.appWidth
        trkOpacity.Value = My.Settings.appOpacity * 10
        numInterval.Value = My.Settings.tickerInterval / 1000
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.tickerInterval = numInterval.Value * 1000
        My.Settings.tickerFiat = cmbFiat.Text
        My.Settings.tickerCoin = cmbCoin.Text
        If chkShowInTaskbar.Checked Then
            My.Settings.appTaskbarIcon = True
            Form1.ShowInTaskbar = True
        Else
            My.Settings.appTaskbarIcon = False
            Form1.ShowInTaskbar = False
        End If
        My.Settings.appOpacity = trkOpacity.Value / 10
        If numWidth.Value <= 1000 And numWidth.Value >= 350 Then My.Settings.appWidth = numWidth.Value
        My.Settings.Save()
        Form1.webView.LoadUrl(Form1.widgetURL + My.Settings.tickerCoin + "/" + My.Settings.tickerFiat)
        Form1.tmrRefresh.Interval = numInterval.Value * 1000
        Me.Close()
    End Sub

    Private Sub trkOpacity_Scroll(sender As Object, e As EventArgs) Handles trkOpacity.Scroll
        Form1.Opacity = trkOpacity.Value / 10
        CheckForPreview()
    End Sub

    Private Sub numWidth_ValueChanged(sender As Object, e As EventArgs) Handles numWidth.ValueChanged
        Form1.Width = numWidth.Value
        CheckForPreview()
    End Sub

    Private Sub frmPreferences_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Width = My.Settings.appWidth
        Form1.Opacity = My.Settings.appOpacity
    End Sub

    Private Sub CheckForPreview()
        If Form1.Opacity = My.Settings.appOpacity And Form1.Width = My.Settings.appWidth Then
            Me.Text = "Preferences"
        Else
            Me.Text = "Preferences (Previewing Changes)"
        End If
    End Sub
End Class