Public Class HouseHold

    Public householdID As String

    Dim citizenID As String

    Dim datatable As New DataTable
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        BunifuTransition1.ShowSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        BunifuTransition1.HideSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Enabled = True
        refresh()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        HAddIP.Text = ""
        HAddName.Text = ""
        HAddNHTS.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        GroupBox1.Enabled = False
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim query As String = "Insert into household (household_name , nhts , ip) values ('" & HAddName.Text & "','" & HAddNHTS.Text & "','" & HAddIP.Text & "')"
        SQLConnection.executeCommand(query)
        BunifuTransition1.HideSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
        MsgBox("Household Added!")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        refresh()
    End Sub

    Public Sub refresh()
        Dim query As String = "select citizen_id , first_name , middle_name , last_name , suffix_name from citizen where first_name like '%" & TextBox2.Text & "%' and household_id IS NULL"
        datatable = SQLConnection.executeQuery(query)
        DataGridView1.DataSource = datatable
    End Sub

    Public Sub refreshMembers()
        Dim query As String = "select citizen_id , first_name , middle_name , last_name , suffix_name , household_relation from citizen where household_id = '" & householdID & "'"
        datatable = SQLConnection.executeQuery(query)
        DataGridView2.DataSource = datatable
    End Sub

    Public Sub refreshHH()
        Dim query As String = "select * from household where household_name like '%" & TextBox3.Text & "%'"
        datatable = SQLConnection.executeQuery(query)
        DataGridView3.DataSource = datatable
        Label12.Text = "Total : " & datatable.Rows.Count & " items"
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        citizenID = datatable.Rows.Item(e.RowIndex).Item(0).ToString()
        addName.Text = datatable.Rows().Item(e.RowIndex).Item(1).ToString() & " " & datatable.Rows().Item(e.RowIndex).Item(2).ToString() & " " & datatable.Rows().Item(e.RowIndex).Item(3).ToString() & " " & datatable.Rows().Item(e.RowIndex).Item(4).ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Select a Household first!")
            Return
        End If
        Dim query As String = "update citizen set household_id = '" & householdID & "', household_relation = '" & cbMR.Text & "' where citizen_id = '" & citizenID & "'"
        SQLConnection.executeCommand(query)
        refreshMembers()
        GroupBox1.Enabled = False
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuTransition1.HideSync(Panel3, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        householdID = datatable.Rows().Item(e.RowIndex).Item(0).ToString()
        TextBox1.Text = datatable.Rows().Item(e.RowIndex).Item(1).ToString()
        HTStb.Text = datatable.Rows().Item(e.RowIndex).Item(2).ToString()
        iptb.Text = datatable.Rows().Item(e.RowIndex).Item(3).ToString()


        BunifuTransition1.HideSync(Panel3, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
        refreshMembers()
    End Sub

    Public Sub refreshMembersfrEdit()
        Dim query As String = "select * from household where household_id = '" & householdID & "'"
        datatable = SQLConnection.executeQuery(query)

        TextBox1.Text = datatable.Rows().Item(0).Item(1).ToString()
        HTStb.Text = datatable.Rows().Item(0).Item(2).ToString()
        iptb.Text = datatable.Rows().Item(0).Item(3).ToString()
        refreshMembers()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BunifuTransition1.ShowSync(Panel3, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
        refreshHH()
    End Sub

    Private Sub HouseHold_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        refreshHH()
    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles HTStb.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If MessageBox.Show("Are you sure you want to remove '" & DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(1).Value.ToString() & "' from this Household?", "Remove from Household?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Dim index As String = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(0).Value.ToString()
                Dim query As String = "update citizen set household_ID = NULL , household_relation = NULL where citizen_id = '" & index & "'"
                SQLConnection.executeCommand(query)
                refreshMembers()
                MsgBox("Successfully Removed!")
            End If
        Catch ex As Exception
            MsgBox("Select a Member to Remove first!")
        End Try

    End Sub
End Class