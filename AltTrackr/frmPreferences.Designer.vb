<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferences
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
        Me.chkShowInTaskbar = New System.Windows.Forms.CheckBox()
        Me.cmbFiat = New System.Windows.Forms.ComboBox()
        Me.cmbCoin = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.trkOpacity = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.numInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.trkOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkShowInTaskbar
        '
        Me.chkShowInTaskbar.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowInTaskbar.Location = New System.Drawing.Point(224, 169)
        Me.chkShowInTaskbar.Name = "chkShowInTaskbar"
        Me.chkShowInTaskbar.Size = New System.Drawing.Size(180, 24)
        Me.chkShowInTaskbar.TabIndex = 0
        Me.chkShowInTaskbar.Text = "Show In Taskbar"
        Me.chkShowInTaskbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkShowInTaskbar.UseVisualStyleBackColor = True
        '
        'cmbFiat
        '
        Me.cmbFiat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiat.FormattingEnabled = True
        Me.cmbFiat.Location = New System.Drawing.Point(38, 39)
        Me.cmbFiat.Name = "cmbFiat"
        Me.cmbFiat.Size = New System.Drawing.Size(180, 21)
        Me.cmbFiat.TabIndex = 4
        '
        'cmbCoin
        '
        Me.cmbCoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCoin.FormattingEnabled = True
        Me.cmbCoin.Location = New System.Drawing.Point(224, 39)
        Me.cmbCoin.Name = "cmbCoin"
        Me.cmbCoin.Size = New System.Drawing.Size(180, 21)
        Me.cmbCoin.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save && Apply Changes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fiat Currency"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cryptocurrency"
        '
        'trkOpacity
        '
        Me.trkOpacity.Location = New System.Drawing.Point(38, 103)
        Me.trkOpacity.Minimum = 1
        Me.trkOpacity.Name = "trkOpacity"
        Me.trkOpacity.Size = New System.Drawing.Size(366, 45)
        Me.trkOpacity.TabIndex = 9
        Me.trkOpacity.Value = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Opacity"
        '
        'numWidth
        '
        Me.numWidth.Location = New System.Drawing.Point(117, 172)
        Me.numWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numWidth.Minimum = New Decimal(New Integer() {350, 0, 0, 0})
        Me.numWidth.Name = "numWidth"
        Me.numWidth.Size = New System.Drawing.Size(69, 20)
        Me.numWidth.TabIndex = 11
        Me.numWidth.Value = New Decimal(New Integer() {350, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Widget Width"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(205, 169)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 25)
        Me.Panel1.TabIndex = 13
        '
        'numInterval
        '
        Me.numInterval.Location = New System.Drawing.Point(227, 227)
        Me.numInterval.Maximum = New Decimal(New Integer() {500000, 0, 0, 0})
        Me.numInterval.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numInterval.Name = "numInterval"
        Me.numInterval.Size = New System.Drawing.Size(124, 20)
        Me.numInterval.TabIndex = 14
        Me.numInterval.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Update Interval (seconds)"
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 310)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numInterval)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numWidth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.trkOpacity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbCoin)
        Me.Controls.Add(Me.cmbFiat)
        Me.Controls.Add(Me.chkShowInTaskbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPreferences"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Preferences"
        Me.TopMost = True
        CType(Me.trkOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkShowInTaskbar As CheckBox
    Friend WithEvents cmbFiat As ComboBox
    Friend WithEvents cmbCoin As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents trkOpacity As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents numWidth As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents numInterval As NumericUpDown
    Friend WithEvents Label5 As Label
End Class
