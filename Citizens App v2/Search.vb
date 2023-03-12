Public Class Search

    Public Shared fromTemplate As Boolean = False
    Dim datatable As DataTable
    Dim query As String

    Dim filters As String
    Private Sub btn_Close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        searchItems()
    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchItems()
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
    End Sub

    Public Sub searchItems()
        query = "Select citizen_id , first_name , middle_name , last_name , suffix_name , birthDate , marital_status , gender , weight , height , blood_type , DATE_FORMAT(FROM_DAYS(DATEDIFF(CURRENT_DATE, birthDate)),'%y') AS age , address , cp_number ,job from citizen where Concat(first_name , ' ' , middle_name , ' ' , last_name , ' ' , suffix_name) like '%" & searchBox.Text & "%'" & filters

        datatable = SQLConnection.executeQuery(query)
        DataGridView1.DataSource = datatable

        itemsNumber.Text = "Total: " & datatable.Rows.Count & " items"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then
            Return
        End If

        If fromTemplate Then
            Templates.citizenname(datatable.Rows.Item(e.RowIndex).Item(0).ToString())
            Me.Close()
        Else
            EditCitizens.citizenname(datatable.Rows.Item(e.RowIndex).Item(0).ToString())
            EditCitizens.Show()
            Me.Close()
        End If
        fromTemplate = False
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        BunifuTransition1.ShowSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        BunifuTransition1.HideSync(Panel2, False, BunifuAnimatorNS.Animation.ScaleAndHorizSlide)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        updateFilter()
        searchItems()

    End Sub

    Private Sub updateFilter()
        filters = ""
        If age.Checked Then
            Dim dNow = DateTime.Now.AddYears((Convert.ToInt32(ageFrom.Text)) * -1).ToString("yyy-MM-dd")
            Dim dPast = DateTime.Now.AddYears((Convert.ToInt32(ageTo.Text)) * -1).ToString("yyy-MM-dd")

            filters &= " and DATE(birthDate) between '" & dPast & "' and '" & dNow & "'"
        End If

        If gender.Checked Then
            filters &= " and gender = '" & cbGender.Text & "'"
        End If

        If purok.Checked Then
            filters &= " and address = '" & cbPurok.Text & "'"
        End If

        If mstatus.Checked Then
            filters &= " and marital_status = '" & cbmstatus.Text & "'"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        age.Checked = False
        gender.Checked = False
        purok.Checked = False
        mstatus.Checked = False

        ageFrom.Text = ""
        ageTo.Text = ""
        cbGender.Text = ""
        cbPurok.Text = ""
        cbmstatus.Text = ""

        filters = ""

        searchItems()
    End Sub

End Class