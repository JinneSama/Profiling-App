Imports word = Microsoft.Office.Interop.Word
Imports System.Runtime.InteropServices
Public Class Templates

    Public firstname As String
    Public middlename As String
    Public lastname As String

    Dim query As String
    Dim datatable As DataTable
    Dim citizenID As String

    Dim citizenTable As DataTable

    Public Shared username As String

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Search.fromTemplate = True
        Search.Show()
    End Sub

    Public Sub citizenname(ByVal id As String)
        citizenID = id
        refresh()
    End Sub

    Private Sub refresh()

        query = "Select transaction_type , transaction_date from transactions where id = '" & citizenID & "' and transaction_type like '%" & ComboBox1.Text & "%'"
        datatable = SQLConnection.executeQuery(query)

        Dim newQuery As String = "Select * from citizen where citizen_id = '" & citizenID & "'"
        Dim newTable As DataTable = SQLConnection.executeQuery(newQuery)
        If newTable.Rows.Count = 0 Then
            Return
        End If
        TextBox1.Text = newTable.Rows().Item(0).Item(1).ToString() & " " & newTable.Rows().Item(0).Item(2).ToString() & " " & newTable.Rows().Item(0).Item(3).ToString() & " " & newTable.Rows().Item(0).Item(4).ToString()

        DataGridView1.DataSource = datatable
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BRGY_Clearance.Click
        open(sender, e)
    End Sub

    Public Sub saveTransactions(ByVal transactionType As String)
        If TextBox1.Text = "" Then
            MsgBox("Select a person first!")
            Return
        End If
        query = "Insert into transactions (id , transaction_date , transaction_type , user , transaction_desc) values ('" & citizenID & "','" _
            & DateTime.Now.ToString("yyyy-MM-dd") & "','" & transactionType & "','" & Form1.admin_name & "','" & rbDesc.Text & "');"
        SQLConnection.executeCommand(query)
        refresh()
        MsgBox("Transaction Saved!")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Business_Clearance.Click
        open(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        saveTransactions(others.Text)
        rbDesc.Text = ""
        others.Text = ""

    End Sub

    Public Sub replace(ByVal wordtoReplace As String, ByVal wordType As String, ByRef _oword As Object, ByRef _odoc As Object, ByVal path As String)
        Dim theWord As String = ""

        Select Case wordType
            Case "Name"
                theWord = TextBox1.Text
            Case "DateNow (Year)"
                theWord = DateTime.Now.ToString("yyyy")
            Case "DateNow (Month)"
                theWord = DateTime.Now.ToString("MMMM")
            Case "DateNow (Date)"
                theWord = DateTime.Now.Day.ToString()
            Case "DateNow (yyyy-MM-dd)"
                theWord = DateTime.Now.ToString("yyyy-MM-dd")
            Case "BirthDate"
                theWord = citizenTable.Rows().Item(0).Item(5).ToString()
            Case "Marital Status"
                theWord = citizenTable.Rows().Item(0).Item(6).ToString()
            Case "Gender"
                theWord = citizenTable.Rows().Item(0).Item(7).ToString()
            Case "Weight"
                theWord = citizenTable.Rows().Item(0).Item(8).ToString()
            Case "Height"
                theWord = citizenTable.Rows().Item(0).Item(9).ToString()
            Case "Blood Type"
                theWord = citizenTable.Rows().Item(0).Item(10).ToString()
            Case "Age"
                Dim bdate As DateTime = Convert.ToDateTime(citizenTable.Rows().Item(0).Item(5).ToString())
                theWord = Math.Round((DateTime.Now.AddDays(-7) - bdate).TotalDays / 365)
            Case "Address"
                theWord = citizenTable.Rows().Item(0).Item(12).ToString() & ", Mabasa dupax del Norte Nueva Vizcaya"
            Case "CP Number"
                theWord = citizenTable.Rows().Item(0).Item(13).ToString()
            Case "Email"
                theWord = citizenTable.Rows().Item(0).Item(14).ToString()
            Case "Job"
                theWord = citizenTable.Rows().Item(0).Item(15).ToString()
        End Select

        Dim MsDocFilename As String = path
        ReplaceWords(MsDocFilename, wordtoReplace, theWord, False, True, _oword, _odoc)

    End Sub

    Private Sub ReplaceWords(Filename As String, TextToReplace As String, ReplaceWith As String, MatchCase As Boolean, WholeWord As Boolean, ByRef _oword As Object, ByRef _odoc As Object)
        _odoc = _oword.Documents.Open(CObj(Filename))
        _odoc.Content.Find.Execute(FindText:=CObj(TextToReplace), ReplaceWith:=CObj(ReplaceWith), Replace:=word.WdReplace.wdReplaceAll, MatchCase:=CObj(MatchCase), MatchWholeWord:=CObj(WholeWord))
    End Sub

    Public Sub savedoc(ByRef _oword As Object, ByRef _odoc As Object)
        _odoc.Save()
        _odoc.Close()
        _oword.Quit()
        Marshal.ReleaseComObject(_odoc)
        Marshal.ReleaseComObject(_oword)
        _oword = Nothing
        _odoc = Nothing

    End Sub

    Public Sub replaceImage(ByRef _oword As word.Application, img As Image, ByVal path As String)
        _oword.Documents.Open(CObj(path))

        For Each oPicture As Microsoft.Office.Interop.Word.Shape In _oword.ActiveDocument.Shapes
            If oPicture.AlternativeText = "picture" Then
                oPicture.Select()
                _oword.ActiveDocument.Shapes.AddPicture(FileName:=Application.StartupPath & "\img.png", Left:=oPicture.Left, Top:=oPicture.Top, Width:=oPicture.Width, Height:=oPicture.Height, Anchor:=_oword.Selection.Range)
                oPicture.Delete()
                Exit For
            ElseIf oPicture.AlternativeText = "signature" Then
                oPicture.Select()
                _oword.ActiveDocument.Shapes.AddPicture(FileName:=Application.StartupPath & "\sig.png", Left:=oPicture.Left, Top:=oPicture.Top, Width:=oPicture.Width, Height:=oPicture.Height, Anchor:=_oword.Selection.Range)
                oPicture.Delete()
                Exit For
            End If
        Next
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuTransition1.HideSync(Panel3, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BunifuTransition1.ShowSync(Panel3, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim myquery As String = "Select * from transactions where id = '" & citizenID & "'"
        Dim mydatatable As DataTable = SQLConnection.executeQuery(myquery)
        rbDesc2.Text = mydatatable.Rows.Item(e.RowIndex).Item(3).ToString()
        tb1.Text = mydatatable.Rows.Item(e.RowIndex).Item(2).ToString()
        BunifuTransition1.ShowSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        BunifuTransition1.HideSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Public Sub loadPlaceHolders()
        pHolderPanel.Controls.Clear()
        Dim strList As New List(Of String)
        strList.AddRange(System.IO.File.ReadAllLines(Application.StartupPath & "\Templates\Placeholders.txt"))

        For Each str As String In strList
            Dim strArr() As String
            strArr = str.Split("=")
            addBlocks(strArr(0), strArr(1))
        Next
    End Sub

    Public Sub addBlocks(ByVal txtTB As String, ByVal txtCB As String)
        Dim txtBox As New TextBox
        Dim cbBox As New ComboBox
        Dim lbl As New Label

        lbl.Text = ":"
        lbl.Size = New Point(15, 19)

        With txtBox
            .Size = New Point(150, 27)
            .Text = txtTB
        End With

        With cbBox
            .Size = New Point(140, 27)
            .Items.AddRange(System.IO.File.ReadAllLines(Application.StartupPath & "\Templates\Indexes.txt"))
            .Text = txtCB
        End With
        pHolderPanel.Controls.Add(txtBox)
        pHolderPanel.Controls.Add(lbl)
        pHolderPanel.Controls.Add(cbBox)
    End Sub

    Private Sub Templates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chartTable As DataTable = SQLConnection.executeQuery("select distinct transaction_type from transactions")
        For Each items As DataRow In chartTable.Rows
            ComboBox1.Items.Add(items.Item(0).ToString())
        Next

        loadPlaceHolders()
        others.Items.AddRange(System.IO.File.ReadAllLines(Application.StartupPath & "\Transactions.txt"))
        Dim count = 0
        Dim _name As String = ""
        Dim _path As String = ""

        For Each items As String In System.IO.File.ReadAllLines(Application.StartupPath & "\Templates\Templates.txt")
            count += 1
            If count = 3 Then
                AutoGenTemplate.add(_name, _path, items)
                count = 0
            ElseIf count = 2 Then
                _path = items
            ElseIf count = 1 Then
                _name = items
            End If
        Next
        FlowLayoutPanel1.Controls.Add(Panel6)
    End Sub

    Public Sub open(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oWord As New word.Application
        Dim oDoc As word.Document
        Dim fname As String = ""

        For Each ctrl As Control In sender.Parent.Controls
            If TypeOf ctrl Is Label Then
                fname = ctrl.Text
            End If
        Next
        saveTransactions(fname)
        If TextBox1.Text = "" Then
            Return
        End If
        SaveFileDialog1.Filter = "Word Documents|*.docx"
        SaveFileDialog1.ShowDialog()
        Dim newPath As String = SaveFileDialog1.FileName
        System.IO.File.Copy(Application.StartupPath & "\Templates\Files\" & fname & ".docx", newPath, True)

        Dim query As String = "select * from citizen where citizen_id = '" & citizenID & "'"
        citizenTable = SQLConnection.executeQuery(query)

        Try
            Dim nms As New IO.MemoryStream(CType(citizenTable.Rows().Item(0).Item(17), Byte()))
            Dim nreturnImage As Image = Image.FromStream(nms)
            nreturnImage.Save("img.png", System.Drawing.Imaging.ImageFormat.Png)
            replaceImage(oWord, nreturnImage, newPath)
        Catch ex As Exception

        End Try

        Try
            Dim nms As New IO.MemoryStream(CType(citizenTable.Rows().Item(0).Item(16), Byte()))
            Dim nreturnImage As Image = Image.FromStream(nms)
            nreturnImage.Save("sig.png", System.Drawing.Imaging.ImageFormat.Png)
            replaceImage(oWord, nreturnImage, newPath)
        Catch ex As Exception

        End Try


        Dim strList As New List(Of String)
        strList.AddRange(System.IO.File.ReadAllLines(Application.StartupPath & "\Templates\Placeholders.txt"))

        For Each str As String In strList
            Dim strArr() As String
            strArr = str.Split("=")
            replace(strArr(0), strArr(1), oWord, oDoc, newPath)
        Next

        savedoc(oWord, oDoc)
        Process.Start(newPath)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        BunifuTransition1.ShowSync(Panel7, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Please Fill all Required Fields!")
            Return
        End If
        System.IO.File.AppendAllText(Application.StartupPath & "\Templates\Templates.txt", TextBox2.Text & vbCrLf & TextBox3.Text & vbCrLf & TextBox4.Text & vbCrLf)
        AutoGenTemplate.add(TextBox2.Text, TextBox3.Text, TextBox4.Text)
        BunifuTransition1.HideSync(Panel7, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)

        FlowLayoutPanel1.Controls.Add(Panel6)
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuTransition1.HideSync(Panel7, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            TextBox3.Text = Application.StartupPath & "\Templates\Files\" & TextBox2.Text & ".docx"
            System.IO.File.Copy(path, Application.StartupPath & "\Templates\Files\" & TextBox2.Text & ".docx", True)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            TextBox4.Text = Application.StartupPath & "\Templates\Image\" & TextBox2.Text & ".png"
            System.IO.File.Copy(path, Application.StartupPath & "\Templates\Image\" & TextBox2.Text & ".png", True)
        End If
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        BunifuTransition1.ShowSync(Panel8, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        BunifuTransition1.HideSync(Panel8, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim count = 1
        Dim str As String = ""
        For Each items As Control In pHolderPanel.Controls
            If count = 3 Then
                str &= items.Text & vbCrLf
                count = 0
            ElseIf count = 1 Then
                str &= items.Text & "="
            End If
            count += 1
        Next
        System.IO.File.WriteAllText(Application.StartupPath & "\Templates\Placeholders.txt", str)
        pHolderPanel.Enabled = False
        Button2.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        pHolderPanel.Enabled = True
        Button2.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        addBlocks("", "")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        pHolderPanel.Enabled = False
        Button2.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        loadPlaceHolders()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        refresh()
    End Sub
End Class

Public Class AutoGenTemplate
    Public Shared Name As String
    Public Shared Path As String
    Public Shared imgPath As String

    Public Shared Sub add(ByVal _name As String, ByVal _path As String, ByVal _imgPath As String)
        Name = _name
        Path = _path
        imgPath = _imgPath

        generate()
    End Sub

    Private Shared Sub generate()
        Dim newPanel As New Panel
        Dim btn As New Button
        Dim lbl As New Label
        Dim pic As New PictureBox

        btn.Name = Name
        btn.Size = New Point(94, 39)
        btn.Location = New Point(50, 204)
        btn.Text = "Choose"
        btn.BackColor = Color.White
        AddHandler btn.Click, AddressOf Templates.open

        lbl.Location = New Point(68, 15)
        lbl.Size = New Point(162, 19)
        lbl.TextAlign = ContentAlignment.TopLeft
        lbl.Font = New Font("Arial", 12, FontStyle.Bold)
        lbl.Text = Name

        pic.Location = New Point(28, 37)
        pic.Size = New Point(127, 161)
        pic.SizeMode = PictureBoxSizeMode.StretchImage
        pic.ImageLocation = imgPath

        With newPanel
            .Controls.Add(btn)
            .Controls.Add(lbl)
            .Controls.Add(pic)
            .BackColor = Color.Gray
            .Size = New Point(183, 252)
        End With

        Templates.FlowLayoutPanel1.Controls.Add(newPanel)
    End Sub

End Class

