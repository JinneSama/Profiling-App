Imports MySql.Data

Public Class Login
    Private datatable As DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "select * from admin where username = '" & nameTB.Text & "' and password = '" & passTB.Text & "'"
        datatable = SQLConnection.executeQuery(query)

        If datatable.Rows.Count = 0 Then
            MsgBox("Username and/or password is incorrect")
        Else
            If datatable.Rows.Item(0).ItemArray(3).ToString() = "1" Then
                If Not datatable.Rows.Item(0).ItemArray(2).ToString() = "admin" Then
                    MsgBox("Username Already Logged in to Another PC")
                Else
                    nameTB.Text = ""
                    passTB.Text = ""
                    Form1.admin_status = datatable.Rows.Item(0).ItemArray(2).ToString()
                    Form1.admin_name = datatable.Rows.Item(0).ItemArray(0).ToString()
                    Form1.refreshLoad()
                    Form1.Show()

                    Dim nquery As String = "update admin set status = '1' where username = '" & datatable.Rows.Item(0).ItemArray(0).ToString() & "'"
                    SQLConnection.executeCommand(nquery)
                    Me.Hide()
                End If
            Else
                nameTB.Text = ""
                    passTB.Text = ""
                    Form1.admin_status = datatable.Rows.Item(0).ItemArray(2).ToString()
                    Form1.admin_name = datatable.Rows.Item(0).ItemArray(0).ToString()
                    Form1.refreshLoad()
                Form1.Show()

                Dim nquery As String = "update admin set status = '1' where username = '" & datatable.Rows.Item(0).ItemArray(0).ToString() & "'"
                SQLConnection.executeCommand(nquery)
                Me.Hide()
                End If
            End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLConnection.connectToDatabase()
    End Sub
End Class