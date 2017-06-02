Public Class frmPreferences
    Private Sub frmPreferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFiat.Items.AddRange(Form1.fiats)
        cmbFiat.Text = My.Settings.tickerFiat
        cmbCoin.Items.AddRange(Form1.coins)
        cmbCoin.Text = My.Settings.tickerCoin
        chkShowInTaskbar.Checked = My.Settings.appTaskbarIcon
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.tickerFiat = cmbFiat.Text
        My.Settings.tickerCoin = cmbCoin.Text
        If chkShowInTaskbar.Checked Then
            My.Settings.appTaskbarIcon = True
            Form1.ShowInTaskbar = True
        Else
            My.Settings.appTaskbarIcon = False
            Form1.ShowInTaskbar = False
        End If
        My.Settings.Save()
        Form1.webView.LoadUrl(Form1.widgetURL + My.Settings.tickerCoin + "/" + My.Settings.tickerFiat)
        Me.Close()
    End Sub
End Class