Imports System.IO.Ports
Imports System.Threading
Imports System.IO
Imports System.Net.Mail
Public Class Messages
    Private datatable As DataTable
    Dim sp As New SerialPort
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Messages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        search("")
        With ListView1
            .View = View.Details
            .FullRowSelect = True
            .Columns.Add("Name", 200)
            .Columns.Add("Number", 150)
        End With
        refreshPort()
    End Sub

    Private Sub refreshPort()
        ComboBox1.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
        Next
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        search(TextBox1.Text)
    End Sub

    Public Sub search(ByVal txt As String)
        Dim query As String = "select first_name , middle_name , last_name , cp_number , email from citizen where first_name like '%" & txt & "%' and cp_number != ''"
        datatable = SQLConnection.executeQuery(query)
        CheckedListBox1.Items.Clear()
        For i As Integer = 0 To datatable.Rows.Count - 1
            CheckedListBox1.Items.Add(datatable.Rows.Item(i).Item(0).ToString() & " " & datatable.Rows.Item(i).Item(1).ToString() & " " & datatable.Rows.Item(i).Item(2).ToString(), False)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            Dim checkstate As CheckState = CheckedListBox1.GetItemCheckState(i)
            If (checkstate = CheckState.Checked) Then
                Dim itemsS(3) As String
                itemsS(0) = CheckedListBox1.Items.Item(i)
                itemsS(1) = datatable.Rows.Item(i).Item(3).ToString()
                itemsS(2) = datatable.Rows.Item(i).Item(4).ToString()
                ListView1.Items.Add(New ListViewItem(itemsS))
            End If
        Next
    End Sub

    Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox2.Text = "Not Ready" Or TextBox1.Text = "" Then
            MsgBox("Port not Compatible , Check device and Port!")
            Return
        End If

        ProgressBar1.BackColor = Color.Green
        If ComboBox1.Text = "" Then
            MsgBox("Please select a Port First!")
            Return
        End If
        connectPort()
        Label6.Text = "Send start"

        Dim total As Integer = ListView1.Items.Count
        Dim counter As Integer = 0
        ProgressBar1.Maximum = total
        For Each items As ListViewItem In ListView1.Items
            Dim result As Boolean = Await send(items.SubItems.Item(1).Text)
            If Not result Then
                ProgressBar1.BackColor = Color.Red
                Label6.Text = "Sending Failed " & counter & "/" & total
                Exit For
            End If
            counter += 1
            Label6.Text = "Sending " & counter & "/" & total
            ProgressBar1.Value = counter
        Next
        ListView1.Items.Clear()
        Label6.Text = "Messages Sent! " & counter & "/" & total
        SerialPort1.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
    End Sub

    Private Function connectPort()
        Try
            SerialPort1 = New SerialPort()
            With SerialPort1
                .PortName = ComboBox1.Text
                .BaudRate = 9600
                .Parity = Parity.None
                .StopBits = StopBits.One
                .DataBits = 8
                .Handshake = Handshake.None
                .RtsEnable = True
                .DtrEnable = True
                .NewLine = vbCrLf
                .Open()
            End With
            Return True
        Catch ex As Exception
            MsgBox("The Port Selected does not exist! , Please refresh and select a new Port!")
            Return False
        End Try

    End Function
    Async Function send(ByVal num As String) As Task(Of Boolean)
        SerialPort1.Write("AT" & vbCrLf)
        Await Task.Delay(100)
        SerialPort1.Write("AT+CMGF=1" & vbCrLf)
        Await Task.Delay(100)
        SerialPort1.Write("AT+CMGS=" & Chr(34) & num & Chr(34) & vbCrLf)
        Await Task.Delay(100)
        SerialPort1.Write(RichTextbox1.Text)
        Await Task.Delay(100)
        SerialPort1.Write(Chr(26))
        Await Task.Delay(100)
        SerialPort1.WriteLine("")
        If SerialPort1.ReadExisting.ToString.Contains("ERROR") Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        refreshPort()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If connectPort() Then
            SerialPort1.Write("AT" & vbCrLf)
            Thread.Sleep(200)
            Dim response As Object = SerialPort1.ReadExisting()
            If response.ToString.Contains("OK") Then
                TextBox2.Text = "Ready"
            Else
                TextBox2.Text = "Not Ready"
                MsgBox("Port not Compatible , Check device and Port!")
            End If
            SerialPort1.Close()
        Else
            TextBox2.Text = "Not a Valid Port!"
        End If

    End Sub

    Private Async Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox2.Text = "Not Ready" Or TextBox1.Text = "" Then
            MsgBox("Port not Compatible , Check device and Port!")
            Return
        End If
        If MessageBox.Show("Send to all Citizen?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.Cancel Then
            Return
        End If
        Dim query As String = "select cp_number from citizen where and cp_number != ''"
        Dim Ctable As DataTable = SQLConnection.executeQuery(query)

        ProgressBar1.BackColor = Color.Green
        If ComboBox1.Text = "" Then
            MsgBox("Please select a Port First!")
            Return
        End If
        connectPort()
        Label6.Text = "Send start"

        Dim total As Integer = Ctable.Rows.Count
        Dim counter As Integer = 0
        ProgressBar1.Maximum = total
        For Each items As DataRow In Ctable.Rows
            Dim result As Boolean = Await send(items.Item(0).ToString())
            If Not result Then
                ProgressBar1.BackColor = Color.Red
                Label6.Text = "Sending Failed " & counter & "/" & total
                Exit For
            End If
            counter += 1
            Label6.Text = "Sending " & counter & "/" & total
            ProgressBar1.Value = counter
        Next
        ListView1.Items.Clear()
        Label6.Text = "Messages Sent! " & counter & "/" & total
        SerialPort1.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        BunifuTransition1.ShowSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Async Function SendViaEmail(ByVal email As String, ByVal password As String, ByVal subject As String, ByVal recipientEmail As String) As Task(Of Boolean)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(email, password)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(email)
            e_mail.To.Add(recipientEmail)
            e_mail.Subject = subject
            e_mail.IsBodyHtml = False
            e_mail.Body = RichTextbox1.Text
            Smtp_Server.Send(e_mail)
            Return True
        Catch error_t As Exception
            Return False
        End Try
        Await Task.Delay(1000)
    End Function

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        BunifuTransition1.HideSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Async Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Label6.Text = "Send start"
        Dim recipient As String = ""
        Dim total As Integer = ListView1.Items.Count
        Dim counter As Integer = 0
        ProgressBar1.Maximum = total
        For Each items As ListViewItem In ListView1.Items
            If Not items.SubItems(2).Text = "" Then
                If counter = 0 Then
                    recipient &= items.SubItems(2).Text
                Else
                    recipient &= "," & items.SubItems(2).Text
                End If
            End If
            counter += 1
            Label6.Text = "Sending " & counter & "/" & total
            ProgressBar1.Value = counter
        Next
        ListView1.Items.Clear()
        Label6.Text = "Messages Sent! " & counter & "/" & total
        Await SendViaEmail(TextBox5.Text, TextBox4.Text, TextBox3.Text, recipient)
    End Sub
End Class