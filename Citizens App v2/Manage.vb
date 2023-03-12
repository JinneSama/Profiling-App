Public Class Manage
    Public datatable As DataTable

    Public saveStatus As String
    Private Sub Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh()
    End Sub

    Public Sub refresh()
        DataGridView1.ReadOnly = True
        datatable = SQLConnection.executeQuery("select username , account_type from admin")
        DataGridView1.DataSource = datatable

        ToolStripStatusLabel1.Text = datatable.Rows.Count & " items"
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dt As DataTable
        dt = SQLConnection.executeQuery("select * from admin")

        TextBox1.Text = dt.Rows.Item(e.RowIndex).Item(0).ToString()
        ComboBox1.Text = dt.Rows.Item(e.RowIndex).Item(2).ToString()
        TextBox2.Text = dt.Rows.Item(e.RowIndex).Item(1).ToString()

    End Sub

    Public Sub btnStatus(ByVal status As Boolean, ByVal btn As String)
        Add.Enabled = status
        Edit.Enabled = status

        If btn = "Add" Then
            Delete.Enabled = status
        Else
            Delete.Enabled = Not status
        End If

        Cancel.Enabled = Not status
        Save.Enabled = Not status
    End Sub

    Public Sub fieldStatus(ByVal status As Boolean, ByVal clear As Boolean)
        TextBox1.Enabled = status
        TextBox2.Enabled = status
        ComboBox1.Enabled = status
        If clear Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        btnStatus(False, "Add")
        fieldStatus(True, True)
        saveStatus = "Add"
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        btnStatus(False, "Edit")
        fieldStatus(True, False)
        saveStatus = "Edit"
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        btnStatus(True, "Edit")
        fieldStatus(False, True)
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If MessageBox.Show("Are you sure you want to Delete this Entry?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Dim query As String = "delete from admin where username = '" & TextBox1.Text & "'"
            SQLConnection.executeCommand(query)
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim query As String
        If saveStatus = "Add" Then
            query = "insert into admin (username , password , account_type) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "')"
        Else
            query = "update admin set username = '" & TextBox1.Text & "' , password = '" & TextBox2.Text & "', account_type = '" & ComboBox1.Text & "' where username = '" & TextBox1.Text & "'"
        End If
        SQLConnection.executeCommand(query)
        MsgBox("Success!")
        refresh()
        btnStatus(True, "Edit")
        fieldStatus(False, True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nquery As String = "update admin set status = '0' where username = '" & TextBox1.Text & "'"
        SQLConnection.executeCommand(nquery)

        MsgBox("User Released!")
    End Sub

End Class