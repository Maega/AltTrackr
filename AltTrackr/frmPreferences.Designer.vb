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
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cmbFiat = New System.Windows.Forms.ComboBox()
        Me.cmbCoin = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkShowInTaskbar
        '
        Me.chkShowInTaskbar.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowInTaskbar.Location = New System.Drawing.Point(153, 93)
        Me.chkShowInTaskbar.Name = "chkShowInTaskbar"
        Me.chkShowInTaskbar.Size = New System.Drawing.Size(180, 24)
        Me.chkShowInTaskbar.TabIndex = 0
        Me.chkShowInTaskbar.Text = "Show In Taskbar"
        Me.chkShowInTaskbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkShowInTaskbar.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.Location = New System.Drawing.Point(153, 153)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(180, 24)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'cmbFiat
        '
        Me.cmbFiat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiat.FormattingEnabled = True
        Me.cmbFiat.Location = New System.Drawing.Point(153, 228)
        Me.cmbFiat.Name = "cmbFiat"
        Me.cmbFiat.Size = New System.Drawing.Size(180, 21)
        Me.cmbFiat.TabIndex = 4
        '
        'cmbCoin
        '
        Me.cmbCoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCoin.FormattingEnabled = True
        Me.cmbCoin.Location = New System.Drawing.Point(153, 272)
        Me.cmbCoin.Name = "cmbCoin"
        Me.cmbCoin.Size = New System.Drawing.Size(180, 21)
        Me.cmbCoin.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(457, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save && Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 397)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbCoin)
        Me.Controls.Add(Me.cmbFiat)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.chkShowInTaskbar)
        Me.Name = "frmPreferences"
        Me.Text = "frmPreferences"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkShowInTaskbar As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents cmbFiat As ComboBox
    Friend WithEvents cmbCoin As ComboBox
    Friend WithEvents Button1 As Button
End Class
