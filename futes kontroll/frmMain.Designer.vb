<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.lblBaud = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.btnDisconn = New System.Windows.Forms.Button()
        Me.btnConn = New System.Windows.Forms.Button()
        Me.tbReceived = New System.Windows.Forms.TextBox()
        Me.tbSend = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(47, 12)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(170, 21)
        Me.cmbBaud.TabIndex = 0
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(47, 39)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(170, 21)
        Me.cmbPort.TabIndex = 1
        '
        'lblBaud
        '
        Me.lblBaud.AutoSize = True
        Me.lblBaud.Location = New System.Drawing.Point(6, 15)
        Me.lblBaud.Name = "lblBaud"
        Me.lblBaud.Size = New System.Drawing.Size(35, 13)
        Me.lblBaud.TabIndex = 2
        Me.lblBaud.Text = "Baud:"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(6, 42)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 3
        Me.lblPort.Text = "Port:"
        '
        'btnDisconn
        '
        Me.btnDisconn.Location = New System.Drawing.Point(223, 10)
        Me.btnDisconn.Name = "btnDisconn"
        Me.btnDisconn.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconn.TabIndex = 4
        Me.btnDisconn.Text = "Disconnect"
        Me.btnDisconn.UseVisualStyleBackColor = True
        '
        'btnConn
        '
        Me.btnConn.Location = New System.Drawing.Point(223, 37)
        Me.btnConn.Name = "btnConn"
        Me.btnConn.Size = New System.Drawing.Size(75, 23)
        Me.btnConn.TabIndex = 5
        Me.btnConn.Text = "Connect"
        Me.btnConn.UseVisualStyleBackColor = True
        '
        'tbReceived
        '
        Me.tbReceived.Location = New System.Drawing.Point(9, 66)
        Me.tbReceived.Multiline = True
        Me.tbReceived.Name = "tbReceived"
        Me.tbReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbReceived.Size = New System.Drawing.Size(289, 160)
        Me.tbReceived.TabIndex = 6
        '
        'tbSend
        '
        Me.tbSend.Location = New System.Drawing.Point(9, 235)
        Me.tbSend.Name = "tbSend"
        Me.tbSend.Size = New System.Drawing.Size(208, 20)
        Me.tbSend.TabIndex = 7
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(223, 233)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 8
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 267)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.tbSend)
        Me.Controls.Add(Me.tbReceived)
        Me.Controls.Add(Me.btnConn)
        Me.Controls.Add(Me.btnDisconn)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblBaud)
        Me.Controls.Add(Me.cmbPort)
        Me.Controls.Add(Me.cmbBaud)
        Me.Name = "frmMain"
        Me.Text = "Fűtés Kontroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents lblBaud As System.Windows.Forms.Label
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents btnDisconn As System.Windows.Forms.Button
    Friend WithEvents btnConn As System.Windows.Forms.Button
    Friend WithEvents tbReceived As System.Windows.Forms.TextBox
    Friend WithEvents tbSend As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button

End Class
