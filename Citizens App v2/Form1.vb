Imports System.IO
Imports System.Net
Imports Microsoft.Win32
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Public Shared admin_status As String
    Public Shared admin_name As String

    Private datatable As DataTable
    Dim dumpQuery As String
    Private pboxes As New List(Of PictureBox)
    Private llabel As New List(Of LinkLabel)


    Public Sub refreshLoad()
        MenuStrip1.BackColor = Color.Teal

        lbl_Username.Text = "Account: " & admin_name
        lbl_Position.Text = "Status: " & admin_status
        lbl_Date.Text = Date.Now.ToString("yyyy/MM/dd")

        If admin_status = "admin" Then
            Button6.Enabled = True
        Else
            Button6.Enabled = False
        End If
        refresh()

    End Sub

    Public Sub refresh()
        Dim query As String = "select citizen.citizen_id , citizen.first_name , citizen.middle_name , citizen.last_name , transactions.transaction_type , transactions.transaction_date , transactions.user from citizen,transactions where citizen.citizen_id = transactions.id;
"
        datatable = SQLConnection.executeQuery(query)
        DataGridView1.DataSource = datatable
        itemCount.Text = "Total : " & datatable.Rows.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditCitizens.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Search.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Templates.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Messages.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Manage.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not MessageBox.Show("Logout and Exit?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim query As String = "update admin set status = '0' where username = '" & admin_name & "'"
        SQLConnection.executeCommand(query)
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MessageBox.Show("Logout?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Dim query As String = "update admin set status = '0' where username = '" & admin_name & "'"
            SQLConnection.executeCommand(query)

            Login.Show()
            My.Application.OpenForms.Cast(Of Form)() _
              .Except({Login}) _
              .ToList() _
              .ForEach(Sub(form) form.Hide())
        End If
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        BunifuTransition1.ShowSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub btn_Close_Click_1(sender As Object, e As EventArgs) Handles btn_Close.Click
        BunifuTransition1.HideSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        refresh()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        HouseHold.Show()
    End Sub

    Private Sub DumpDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DumpDatabaseToolStripMenuItem.Click
        Dim query As String = "select * from citizen"
        datatable = SQLConnection.executeQuery(query)
        TextBox1.Text = datatable.Rows.Count
        query = "select * from household"
        datatable = SQLConnection.executeQuery(query)
        TextBox2.Text = datatable.Rows.Count
        BunifuTransition1.ShowSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub populateChart()
        Dim chartquery As String
        Dim chartTable As DataTable

        Dim pastDate As Date = DateTime.Now
        Dim newDate As Date
        Dim transactions As New List(Of String)

        Dim query As String = "SELECT SUM(IF(age < 10,1,0)) as '0-9', " &
    "SUM(IF(age BETWEEN 10 and 19,1,0)) as '10 - 19'," &
    "SUM(IF(age BETWEEN 20 and 29,1,0)) as '20 - 29'," &
    "SUM(IF(age BETWEEN 30 and 39,1,0)) as '30 - 39'," &
    "SUM(IF(age BETWEEN 40 and 49,1,0)) as '40 - 49'," &
    "SUM(IF(age BETWEEN 50 and 59,1,0)) as '50 - 59'," &
    "SUM(IF(age BETWEEN 60 and 69,1,0)) as '60 - 69'," &
    "SUM(IF(age >= 70,1,0)) as '70+'" &
    "from (select year(now()) - year(birthDate) - (date_format(now(), '%m%d') < date_format(birthDate, '%m%d')) as age from citizen) a"

        chartTable = SQLConnection.executeQuery(query)

        Label17.Text = chartTable.Rows.Item(0).Item(0).ToString()
        Label18.Text = chartTable.Rows.Item(0).Item(1).ToString()
        Label19.Text = chartTable.Rows.Item(0).Item(2).ToString()
        Label20.Text = chartTable.Rows.Item(0).Item(3).ToString()
        Label21.Text = chartTable.Rows.Item(0).Item(4).ToString()
        Label22.Text = chartTable.Rows.Item(0).Item(5).ToString()
        Label23.Text = chartTable.Rows.Item(0).Item(6).ToString()
        Label24.Text = chartTable.Rows.Item(0).Item(7).ToString()

        chartTable = SQLConnection.executeQuery("select distinct transaction_type from transactions")
        For Each item As DataRow In chartTable.Rows
            transactions.Add(item.Item(0).ToString())
        Next

        For Each items As String In transactions
            Chart1.Series.Add(items)
        Next

        For i As Integer = 0 To 5
            newDate = DateTime.Now.AddMonths(i * -1)
            For Each items As String In transactions
                chartquery = "Select transaction_Date from transactions where DATE(transaction_Date) between '" & newDate.ToString("yyy-MM-dd") & "' and '" & pastDate.ToString("yyy-MM-dd") & "' and transaction_type = '" & items & "'"
                chartTable = SQLConnection.executeQuery(chartquery)

                Dim count As Integer = chartTable.Rows.Count
                Chart1.Series(items).Points.AddXY(newDate.ToString("MMMM"), count)
            Next
            pastDate = newDate
        Next

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        SaveFileDialog1.ShowDialog()
        Dim path As String = SaveFileDialog1.FileName & ".xlsx"

        dumpQuery = "Select first_name , middle_name , last_name " & entries() & "from citizen"
        saveExcel(path)

    End Sub

    Public Function entries() As String
        Dim filters As String
        If addressCB.Checked Then
            filters &= ", address "
        End If

        If AgeCB.Checked Then
            filters &= ", DATE_FORMAT(FROM_DAYS(DATEDIFF(CURRENT_DATE, birthDate)),'%y') AS age "
        End If

        If cpnumCB.Checked Then
            filters &= ", cp_number "
        End If

        If jobCB.Checked Then
            filters &= ", job "
        End If

        If MSCB.Checked Then
            filters &= ", marital_status"
        End If

        If genderCB.Checked Then
            filters &= ", gender "
        End If

        If emailCB.Checked Then
            filters &= ", email "
        End If

        If weightCB.Checked Then
            filters &= ", weight "
        End If

        If heightCB.Checked Then
            filters &= ", height "
        End If

        If BTCB.Checked Then
            filters &= ", blood_type "
        End If

        Return filters
    End Function

    Private Sub saveExcel(ByVal path As String)
        Dim i, j As Integer

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        Dim excelTable As DataTable = SQLConnection.executeQuery(dumpQuery)

        For i = 0 To excelTable.Rows.Count - 1
            For j = 0 To excelTable.Columns.Count - 1
                xlWorkSheet.Cells(i + 1, j + 1) =
                excelTable.Rows().Item(i).Item(j)
            Next
        Next

        xlWorkSheet.SaveAs(path)
        xlWorkBook.Close()
        xlApp.Quit()

        MsgBox("Saved to " & path)

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("Made by : Junnie C Silao" & vbCrLf & "for Brgy Mabasa")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetWebBrowserFeatures(6)
        mapRefresh()
        populateChart()
        GetNews()
        refreshWeather()
    End Sub

    Public Async Sub mapRefresh()
        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.Navigate("https://www.google.com/maps/place/Mabasa,+Dupax+Del+Norte,+Nueva+Vizcaya/@16.3240406,121.1430961,4929m/data=!3m1!1e3!4m5!3m4!1s0x339059688df16e97:0xf4380d6096c404ea!8m2!3d16.3295506!4d121.1424001")
        Await Task.Delay(15000)

        For Each Element As HtmlElement In WebBrowser1.Document.GetElementsByTagName("button")
            If Element.GetAttribute("vet").Contains("16735") Then
                Element.InvokeMember("click")
                Exit For
            End If
        Next
    End Sub

    Private Sub refreshWeather()
        Dim wBrowser As New WebBrowser
        wBrowser.ScriptErrorsSuppressed = True
        wBrowser.Navigate("https://www.google.com/search?q=mabasa+%2C+dupax+del+norte+%2C+Nueva+Vizcaya+weather&oq=mabasa+%2C+dupax+del+norte+%2C+Nueva+Vizcaya+weather&aqs=chrome..69i57.4495j0j4&sourceid=chrome&ie=UTF-8")
        AddHandler wBrowser.DocumentCompleted, AddressOf WeatherLoadComplete
    End Sub

    Public Sub WeatherLoadComplete(sender As Object, e As EventArgs)
        Try
            lblTemperature.Text = sender.Document.GetElementById("wob_tm").GetAttribute("innerText") & "°"
            lblStatus.Text = sender.Document.GetElementById("wob_dc").GetAttribute("innerText")
            Dim url As String = sender.Document.GetElementById("wob_tci").GetAttribute("src")

            Dim tClient As WebClient = New WebClient
            Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(url)))
            PictureBox1.Image = tImage
        Catch ex As Exception
            lblTemperature.Text = "NO"
            lblStatus.Text = "INTERNET"
        End Try

        lblStatus.Left = Me.Panel6.Width / 2 - lblStatus.Left / 2

    End Sub

    Private Sub GetNews()
        Dim browser As New WebBrowser
        browser.ScriptErrorsSuppressed = True
        browser.Navigate("https://www.google.com/search?q=neuva+vizcaya+news&biw=1920&bih=969&tbm=nws&sxsrf=ALeKk01l6Pg6IPQnqZxt9GP0bbhWmJWM7A%3A1627621041637&ei=sYYDYcmxJouzmAW9goLIAQ&oq=neuva+vizcaya+news&gs_l=psy-ab.3..0i13k1j0i13i30k1l2j0i13i5i30k1l3j0i8i13i30k1l2.10639.13884.0.14120.14.14.0.0.0.0.228.1569.0j7j2.9.0....0...1c.1.64.psy-ab..7.6.1032...0i7i30k1j0i13i10k1.0.pgbC28jPbSs")
        AddHandler browser.DocumentCompleted, AddressOf NewsDocComplete
    End Sub

    Public Sub NewsDocComplete(sender As Object, e As EventArgs)
        Dim name As String = ""
        Dim desc As String = ""
        Dim weeks As String = ""
        Dim imgUrls As New List(Of String)
        Dim urls As New List(Of String)

        For Each items As HtmlElement In sender.Document.GetElementsByTagName("img")
            If items.GetAttribute("ClassName").Contains("rISBZc M4dUYb") Then
                If items.GetAttribute("src").ToString().Count > 1400 Then
                    imgUrls.Add(items.GetAttribute("src").ToString())
                    'MsgBox(items.GetAttribute("src").ToString().Count)
                End If
            End If
        Next


        For Each items As HtmlElement In sender.Document.GetElementsByTagName("a")
            If items.GetAttribute("data-ved").ToString().Count > 10 Then
                If Not (items.GetAttribute("href").Contains("google") Or items.GetAttribute("href").ToString().Count < 1) Then
                    urls.Add(items.GetAttribute("href").ToString())
                    'MsgBox(items.GetAttribute("src").ToString().Count)
                End If
            End If
        Next

        For Each items As HtmlElement In sender.Document.GetElementsByTagName("div")

            If items.GetAttribute("ClassName").Contains("JheGif") Then
                name = items.GetAttribute("InnerText").ToString()
            End If

            If items.GetAttribute("ClassName") = "Y3v8qd" Then
                desc = items.GetAttribute("InnerText") & vbCrLf
            End If

            If items.GetAttribute("ClassName") = "wxp1Sb" Then
                weeks = items.GetAttribute("InnerText") & vbCrLf
                GenerateNews(name, desc, weeks, "")
            End If

        Next
        Dim count As Integer = 0
        For Each items As PictureBox In pboxes
            Dim newUrl As String = imgUrls.Item(count).Remove(0, 23)
            Try
                items.Image = convertbytetoimage(Convert.FromBase64String(newUrl))
            Catch ex As Exception
                items.Image = Nothing
            End Try

            llabel.Item(count).Tag = urls.Item(count)
            ' MsgBox(imgUrls.Item(count))
            count += 1
        Next
    End Sub
    Private Function convertbytetoimage(ByVal BA As Byte())
        Dim converter As ImageConverter = New ImageConverter()
        Return CType(converter.ConvertFrom(BA), Image)
    End Function
    Private Sub clickLabel(sender As Object, e As EventArgs)
        Process.Start(sender.tag.ToString())
    End Sub

    Private Sub GenerateNews(ByVal name As String, ByVal desc As String, ByVal weeks As String, ByVal imgUrl As String)
        Dim lbl As New Label
        Dim weelLbl As New Label
        Dim Llbl As New LinkLabel
        Dim pnl As New Panel
        Dim pbox As New PictureBox


        pbox.Location = New Point(419, 9)
        pbox.Size = New Point(143, 140)
        pboxes.Add(pbox)


        Llbl.Location = New Point(13, 10)
        Llbl.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        Llbl.ForeColor = Color.Black
        Llbl.Text = name
        Llbl.Size = New Point(390, 48)
        AddHandler Llbl.LinkClicked, AddressOf clickLabel
        llabel.Add(Llbl)


        weelLbl.Location = New Point(12, 152)
        weelLbl.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
        weelLbl.ForeColor = Color.Black
        weelLbl.Text = weeks
        weelLbl.Size = New Point(380, 13)

        lbl.Location = New Point(15, 59)
        lbl.Size = New Point(381, 80)
        lbl.ForeColor = Color.Black
        lbl.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
        lbl.Text = desc

        With pnl
            .Size = New Point(584, 169)
            .BackColor = Color.White
            .Controls.Add(Llbl)
            .Controls.Add(lbl)
            .Controls.Add(weelLbl)
            .Controls.Add(pbox)
        End With

        FlowLayoutPanel1.Controls.Add(pnl)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        BunifuTransition1.HideSync(Panel3, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub DumpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DumpToolStripMenuItem.Click
        BunifuTransition1.ShowSync(Panel3, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub



    Private Shared Sub SetWebBrowserFeatures(ByVal ieVersion As Integer)
        If System.ComponentModel.LicenseManager.UsageMode <> System.ComponentModel.LicenseUsageMode.Runtime Then Return
        'Get the program and name
        Dim appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)
        'Get the value of the browser's mode
        Dim ieMode As UInt32 = GeoEmulationModee(ieVersion)
        Dim featureControlRegKey = "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\"
        'Set the browser to run the app (appName) in what mode (ieMode)
        Registry.SetValue(featureControlRegKey & "FEATURE_BROWSER_EMULATION", appName, ieMode, RegistryValueKind.DWord)
        'enable the features which are "On" for the full Internet Explorer browser
        Registry.SetValue(featureControlRegKey & "FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION", appName, 1, RegistryValueKind.DWord)
    End Sub

    'get version
    Private Shared Function GetBrowserVersion() As Integer
        Dim browserVersion As Integer = 0

        Using ieKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer", RegistryKeyPermissionCheck.ReadSubTree, System.Security.AccessControl.RegistryRights.QueryValues)
            Dim version = ieKey.GetValue("svcVersion")

            If version Is Nothing Then
                version = ieKey.GetValue("Version")
                If version Is Nothing Then Throw New ApplicationException("Microsoft Internet Explorer is required!")
            End If

            Integer.TryParse(version.ToString().Split("."c)(0), browserVersion)
        End Using

        If browserVersion < 7 Then
            Throw New ApplicationException("Not Support!")
        End If

        Return browserVersion
    End Function

    Private Shared Function GeoEmulationModee(ByVal browserVersion As Integer) As UInt32
        Dim mode As UInt32 = 11000

        Select Case browserVersion
            Case 7
                mode = 7000
            Case 8
                mode = 8000
            Case 9
                mode = 9000
            Case 10
                mode = 10000
            Case 11
                mode = 11000
        End Select

        Return mode
    End Function

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        refreshWeather()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Other_Datas.Show()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuTransition2.HideSync(Panel23, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub MapOthersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapOthersToolStripMenuItem.Click
        BunifuTransition2.ShowSync(Panel23, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub
End Class


