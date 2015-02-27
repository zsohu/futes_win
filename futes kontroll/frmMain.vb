Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports

Public Class frmMain
    Dim myPorts As Array  'COM Ports detected on the system will be stored here
    Public WithEvents port As New SerialPort
    Delegate Sub ReceivedTextInvoker(ByVal Text As String) 'Added to prevent threading errors during receiveing of data

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPorts = IO.Ports.SerialPort.GetPortNames() 'Get all com ports available
        cmbBaud.Items.Add(9600)     'Populate the cmbBaud Combo box to common baud rates used
        cmbBaud.Items.Add(19200)
        cmbBaud.Items.Add(38400)
        cmbBaud.Items.Add(57600)
        cmbBaud.Items.Add(115200)

        For i = 0 To UBound(myPorts)
            cmbPort.Items.Add(myPorts(i))
        Next
        cmbPort.Text = cmbPort.Items.Item(0)    'Set cmbPort text to the first COM port detected
        cmbBaud.Text = cmbBaud.Items.Item(0)    'Set cmbBaud text to the first Baud rate on the list

        btnDisconn.Enabled = False           'Initially Disconnect Button is Disabled
        btnSend.Enabled = False
    End Sub

    Private Sub btnConn_Click(sender As Object, e As EventArgs) Handles btnConn.Click
        port.PortName = cmbPort.Text
        port.BaudRate = Convert.ToInt16(cmbBaud.Text)
        port.DataBits = 8
        port.Parity = Parity.None
        port.StopBits = StopBits.One

        Try
            port.Open()
            btnConn.Enabled = False
            btnDisconn.Enabled = True
            btnSend.Enabled = True
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btnDisconn_Click(sender As Object, e As EventArgs) Handles btnDisconn.Click
        Try
            port.Close()
            btnConn.Enabled = True
            btnDisconn.Enabled = False
            btnSend.Enabled = False
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub port_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles port.DataReceived
        ReceivedText(port.ReadExisting())
    End Sub

    Private Sub ReceivedText(ByVal text As String)
        'compares the ID of the creating Thread to the ID of the calling Thread
        If Me.tbReceived.InvokeRequired Then
            Me.tbReceived.Invoke(New ReceivedTextInvoker(AddressOf ReceivedText), text)
        Else
            Me.tbReceived.Text &= text
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            port.Write(tbSend.Text + vbCrLf)
            tbSend.Text = ""
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class
