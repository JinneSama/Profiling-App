Public Class Other_Datas
    Private dataContent As New List(Of GenerateData)
    Private datas As New List(Of DatasBtn)

    Private DataName As String = ""
    Private type As String = ""

    Private saveQuery As String = ""
    Private rowToSave As New List(Of DataGridViewRow)

    Private strArr() As String

    Private Sub saveRows()
        Dim values As String = ""
        Dim valueToSave As String = ""

        For Each items As DataGridViewRow In rowToSave
            For x As Integer = 2 To strArr.Length + 1
                If x = strArr.Length + 1 Then
                    valueToSave &= strArr(x - 2) & "='" & items.Cells.Item(x).Value.ToString() & "'"
                Else
                    valueToSave &= strArr(x - 2) & "='" & items.Cells.Item(x).Value.ToString() & "',"
                End If
            Next
            valueToSave = "Update " & DataName & " set " & valueToSave & " where id = '" & items.Cells.Item(0).Value.ToString() & "'"

            SQLConnection.executeCommand(valueToSave)
            valueToSave = ""
        Next

        rowToSave.Clear()
        refresh()
        MsgBox("Data Saved!")
    End Sub

    Private Sub refresh()
        If DataName = "" Then
            Return
        End If
        Dim ColumnsList As New List(Of String)
        Dim dt As DataTable = SQLConnection.executeQuery("Select columnNames from OtherDatas where name = '" & DataName & "'")


        strArr = dt.Rows.Item(0).Item(0).ToString().Split(",")
        Dim query As String = "select b.id , Concat(a.first_name , ' ' , a.middle_name , ' ' , a.last_name , ' ', a.suffix_name) as name , "
        For Each items As String In strArr
            If strArr.Last Is items Then
                query &= "b." & items & " "
            Else
                query &= "b." & items & ","
            End If
        Next

        query &= "from citizen as a ," & DataName & " as b where a.citizen_id = b.id and a.first_name like '%" & SearchBox.Text & "%'"
        DataGridView1.DataSource = SQLConnection.executeQuery(query)
    End Sub

    Public Sub loadDatas(sender As Object, e As EventArgs)
        Label4.Text = "Data Name: " & sender.DataName

        Dim ColumnsList As New List(Of String)
        Dim dt As DataTable = SQLConnection.executeQuery("Select columnNames from OtherDatas where name = '" & sender.DataName & "'")

        strArr = dt.Rows.Item(0).Item(0).ToString().Split(",")
        Dim query As String = "select b.id , Concat(a.first_name , ' ' , a.middle_name , ' ' , a.last_name , ' ', a.suffix_name) as name , "
        For Each items As String In strArr
            If strArr.Last Is items Then
                query &= "b." & items & " "
            Else
                query &= "b." & items & ","
            End If
        Next

        query &= "from citizen as a ," & sender.DataName & " as b where a.citizen_id = b.id"

        saveQuery = query
        DataGridView1.DataSource = SQLConnection.executeQuery(query)
        DataName = sender.DataName

        If sender.type = "Additive" Then
            StaticType.Enabled = False
            AdditiveType.Enabled = True
        ElseIf sender.type = "Static" Then
            StaticType.Enabled = True
            AdditiveType.Enabled = False
        End If

        BunifuTransition1.HideSync(Panel3, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub loadDataPlaceholders()
        FlowLayoutPanel2.Controls.Clear()
        Dim strList As New List(Of DataRow)
        Dim query As String = "select * from OtherDatas"
        Dim dtable As DataTable = SQLConnection.executeQuery(query)

        For Each str As DataRow In dtable.Rows
            Dim btn As New DatasBtn(str.Item(0), str.Item(1))
            datas.Add(btn)
            FlowLayoutPanel2.Controls.Add(btn)
        Next
    End Sub
    Private Sub Other_Datas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataPlaceholders()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        BunifuTransition1.HideSync(Panel1, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub AddDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDataToolStripMenuItem.Click
        BunifuTransition1.ShowSync(Panel1, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim g As New GenerateData
        dataContent.Add(g)
        FlowLayoutPanel1.Controls.Add(g)
        FlowLayoutPanel1.Controls.Add(Button2)
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuTransition1.HideSync(Panel3, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub ShowAllDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllDataToolStripMenuItem.Click
        BunifuTransition1.ShowSync(Panel3, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Create Data '" & TextBox1.Text & "'?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.Cancel Then
            Return
        End If
        Dim _name As String = TextBox1.Text
        Dim _type As String = ComboBox1.Text

        Dim datas As String = ""

        Dim query As String = "Create Table " & TextBox1.Text & "(id int(6) zerofill ,"
        For Each items As GenerateData In dataContent
            If dataContent.Last() Is items Then
                datas &= items.tb.Text
                query &= items.tb.Text & " Varchar(100) )"
            Else
                datas &= items.tb.Text & ","
                query &= items.tb.Text & " Varchar(100) ,"
            End If
        Next
        SQLConnection.executeCommand("Insert into OtherDatas (name , type , columnNames) values ('" & _name & "','" & _type & "','" & datas & "')")
        SQLConnection.executeCommand(query)

        If _type = "Static" Then
            Dim idsQuery As String = "select citizen_id from citizen"
            Dim datatable As DataTable = SQLConnection.executeQuery(idsQuery)
            Dim count As Integer = 0
            For Each items As DataRow In datatable.Rows
                Dim newQuery As String = "Insert into " & _name & " (id) values ('" & items.Item(0).ToString() & "')"
                SQLConnection.executeCommand(newQuery)
                count += 1
                striplbl1.Text = "Copying to " & _name & ": " & count & "/" & datatable.Rows.Count
            Next
        End If

        loadDataPlaceholders()
        BunifuTransition1.HideSync(Panel1, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
        MsgBox("Done!")
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        refresh()
    End Sub


    Private Sub StaticSave_Click(sender As Object, e As EventArgs) Handles StaticSave.Click
        saveRows()
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        rowToSave.Add(DataGridView1.Rows.Item(e.RowIndex))
    End Sub

    Private Sub StaticDelete_Click(sender As Object, e As EventArgs) Handles StaticDelete.Click
        For Each items As DataGridViewRow In DataGridView1.SelectedRows
            SQLConnection.executeCommand("Delete from " & DataName & " where id ='" & items.Cells(0).Value.ToString() & "'")
        Next
        refresh()
        MsgBox("Rows Deleted!")
    End Sub

    Private Sub AdditiveSave_Click(sender As Object, e As EventArgs) Handles AdditiveSave.Click
        saveRows()
    End Sub

    Private Sub AdditiveDelete_Click(sender As Object, e As EventArgs) Handles AdditiveDelete.Click
        For Each items As DataGridViewRow In DataGridView1.SelectedRows
            SQLConnection.executeCommand("Delete from " & DataName & " where id ='" & items.Cells(0).Value.ToString() & "'")
        Next
        refresh()
        MsgBox("Rows Deleted!")
    End Sub

    Private Sub AdditiveInsert_Click(sender As Object, e As EventArgs) Handles AdditiveInsert.Click
        refreshSearch()
        BunifuTransition1.ShowSync(Panel5, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuTransition1.HideSync(Panel5, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        refreshSearch()
    End Sub

    Private Sub refreshSearch()
        Dim query As String = "Select citizen_id , Concat(first_name , ' ' , middle_name , ' ' , last_name , ' ', suffix_name) as name from citizen where first_name like '%" & TextBox3.Text & "%'"
        DataGridView3.DataSource = SQLConnection.executeQuery(query)
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Dim query As String = "Insert into " & DataName & "(id) values ('" & DataGridView3.Rows.Item(e.RowIndex).Cells(0).Value.ToString() & "')"
        SQLConnection.executeCommand(query)
        refresh()
        BunifuTransition1.HideSync(Panel5, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each items As DataGridViewRow In DataGridView3.SelectedRows
            Dim query As String = "Insert into " & DataName & " (id) values ('" & items.Cells(0).Value.ToString() & "')"
            SQLConnection.executeCommand(query)
        Next
        refresh()
    End Sub
End Class

Public Class GenerateData
    Inherits Panel

    Public lbl As New Label
    Public tb As New TextBox
    Public Sub New()
        With lbl
            .Text = "Data Name:"
            .Size = New Point(97, 18)
            .Location = New Point(12, 9)
            .Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        End With

        With tb
            .Text = ""
            .Size = New Point(331, 24)
            .Location = New Point(15, 33)
            .Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        End With

        With Me
            .Controls.Add(lbl)
            .Controls.Add(tb)
            .Size = New Point(361, 79)
            .Location = New Point(115, 33)
            .BackColor = Color.Teal
        End With
    End Sub
End Class

Public Class DatasBtn
    Inherits Button

    Public DataName As String
    Public type As String

    Public Sub New(ByVal _name As String, ByVal _type As String)
        DataName = _name
        type = _type

        With Me
            .Size = New Point(186, 88)
            .Text = _name
            .BackColor = Color.Teal
        End With
        AddHandler Me.Click, AddressOf Other_Datas.loadDatas
    End Sub
End Class
