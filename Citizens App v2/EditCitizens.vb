Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO

Public Class EditCitizens

    Private signatureObject As New Dictionary(Of Integer, List(Of Point))
    Private signaturePen As New Pen(Color.Black, 4)
    Private currentCurvePoints As List(Of Point)
    Private currentCurve As Integer = -1

    Private datatable As DataTable

    Private txtSignatureFileName As String = "Sample"
    Private saveType As String
    Private citizenID As String

    Private citizenIndex As Integer = 0

    Private fromSearch As Boolean = False
    Private isEditing As Boolean = False


    Private Sub pBoxSignature_MouseDown(sender As Object, e As MouseEventArgs) Handles pBoxSignature.MouseDown
        currentCurvePoints = New List(Of Point)
        currentCurve += 1
        signatureObject.Add(currentCurve, currentCurvePoints)
    End Sub

    Private Sub pBoxSignature_MouseMove(sender As Object, e As MouseEventArgs) Handles pBoxSignature.MouseMove
        If e.Button <> MouseButtons.Left OrElse currentCurve < 0 Then Return
        signatureObject(currentCurve).Add(e.Location)
        pBoxSignature.Invalidate()
    End Sub

    Private Sub clearSignature()
        currentCurve = -1
        signatureObject.Clear()
        pBoxSignature.Invalidate()
        pBoxSignature.Image = Nothing
    End Sub

    Private Sub saveSignature()
        Dim signatureFileName = "signature"
        Dim signaturePath As String
        Dim signature As Bitmap
        If String.IsNullOrEmpty(signatureFileName) Then Return
        If currentCurve < 0 OrElse signatureObject(currentCurve).Count = 0 Then Return

        Using imgSignature As Bitmap = New Bitmap(pBoxSignature.Width, pBoxSignature.Height, PixelFormat.Format32bppArgb),
            g As Graphics = Graphics.FromImage(imgSignature)

            DrawSignature(g)
            signaturePath = Path.Combine(Application.StartupPath, $"{signatureFileName}.png")
            imgSignature.Save(signaturePath, ImageFormat.Png)
            signature = imgSignature

            Dim newImage As Image = Image.FromFile(signaturePath)

            Dim picStream As New System.IO.MemoryStream()
            imgSignature.Save(picStream, System.Drawing.Imaging.ImageFormat.Png)
            Dim imgArray() As Byte = picStream.GetBuffer()
            picStream.Close()

            Dim photoQuery As String = "Update citizen Set signature=@photo where citizen_id = '" & citizenID & "'"
            SQLConnection.executePhotoCommand(photoQuery, imgArray)

        End Using

    End Sub

    Private Sub saveImage()
        If PboxImg.Image Is Nothing Then
            Return
        End If
        Dim newImage As Image = PboxImg.Image

        Dim picStream As New System.IO.MemoryStream()
        newImage.Save(picStream, System.Drawing.Imaging.ImageFormat.Png)
        Dim imgArray() As Byte = picStream.GetBuffer()
        picStream.Close()

        Dim photoQuery As String = "Update citizen Set img=@photo where citizen_id = '" & citizenID & "'"
        SQLConnection.executePhotoCommand(photoQuery, imgArray)

    End Sub

    Private Sub pBoxSignature_Paint(sender As Object, e As PaintEventArgs) Handles pBoxSignature.Paint
        If currentCurve < 0 OrElse signatureObject(currentCurve).Count = 0 Then Return
        DrawSignature(e.Graphics)
    End Sub

    Private Sub DrawSignature(g As Graphics)
        g.CompositingMode = CompositingMode.SourceOver
        g.CompositingQuality = CompositingQuality.HighQuality
        g.SmoothingMode = SmoothingMode.AntiAlias

        For Each curve In signatureObject
            If curve.Value.Count < 2 Then Continue For
            Using gPath As New GraphicsPath()
                gPath.AddCurve(curve.Value.ToArray(), 0.5F)
                g.DrawPath(signaturePen, gPath)
            End Using
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        clearSignature()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If fieldsCheck() Then
            If MessageBox.Show("Some Entries are Empty , Press OK if you want the Entries as Blank", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.Cancel Then
                Return
            Else
                firstName.BackColor = Color.White
                middleName.BackColor = Color.White
                lastName.BackColor = Color.White
                suffix.BackColor = Color.White
                cpNum.BackColor = Color.White
                email.BackColor = Color.White
                job.BackColor = Color.White
                maritalStatus.BackColor = Color.White
                gender.BackColor = Color.White
                purok.BackColor = Color.White
                weight.BackColor = Color.White
                height.BackColor = Color.White
                bloodType.BackColor = Color.White
                RiskCB.BackColor = Color.White
                phIDtb.BackColor = Color.White
                phIDCategory.BackColor = Color.White
            End If
        End If

        Dim query As String = ""

        Dim bdate As DateTime = Convert.ToDateTime(birthDate.Text)
        age.Text = Math.Round((DateTime.Now.AddDays(-7) - bdate).TotalDays / 365)
        Dim hasPhilHealth As String = ""
        If philHealthCB.Checked Then
            hasPhilHealth = "1"
        Else
            hasPhilHealth = "0"
        End If

        If saveType = "add" Then
            query = "Insert into citizen (first_name , middle_name , last_name , suffix_name , birthDate , marital_status , gender , weight , height ," _
            & "blood_type , age , address , cp_number , email , job , RiskGroup , PhilHealthMember , PhilHealthID , PhilHealthCategory) values ('" & firstName.Text & "','" & middleName.Text & "','" & lastName.Text & "','" _
            & suffix.Text & "','" & birthDate.Text & "','" & maritalStatus.Text & "','" & gender.Text & "','" & weight.Text & "','" & height.Text & "','" _
            & bloodType.Text & "','" & age.Text & "','" & purok.Text & "','" & cpNum.Text & "','" & email.Text & "','" & job.Text & "','" & RiskCB.Text & "','" & hasPhilHealth & "','" & phIDtb.Text & "','" & phIDCategory.Text & "');"
            SQLConnection.executeCommand(query)
            Dim newQuery As String = "Select * from citizen"
            Dim newDTable As DataTable = SQLConnection.executeQuery(newQuery)
            citizenID = newDTable.Rows.Item(newDTable.Rows.Count - 1).Item(0).ToString()
        ElseIf saveType = "edit" Then
            query = "update citizen set first_name = '" & firstName.Text & "' , middle_name = '" & middleName.Text & "' , last_name = '" & lastName.Text _
                & "', suffix_name = '" & suffix.Text & "', birthDate = '" & birthDate.Text & "' , marital_status = '" & maritalStatus.Text & "', gender = '" & gender.Text _
                & "', weight = '" & weight.Text & "', height = '" & height.Text & "',blood_type = '" & bloodType.Text & "', age = '" & age.Text _
                & "', address = '" & purok.Text & "', cp_number  = '" & cpNum.Text & "', email = '" & email.Text & "', job = '" & job.Text & "' , RiskGroup = '" & RiskCB.Text & "' , PhilHealthMember = '" _
                & hasPhilHealth & "',  PhilHealthID = '" & phIDtb.Text & "', PhilHealthCategory  = '" & phIDCategory.Text & "' where citizen_id = '" & citizenID & "'"
            SQLConnection.executeCommand(query)
        End If

        saveSignature()
        saveImage()

        MsgBox("Success!")

        buttonStatus(True, "Cancel")
        fieldsStatus(False)
        datatable = SQLConnection.executeQuery("Select * from citizen")
        populateFields(citizenIndex)
        isEditing = False
    End Sub


    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        isEditing = True
        saveType = "add"
        fieldsStatus(True)
        buttonStatus(False, "Add")

        firstName.Text = ""
        middleName.Text = ""
        lastName.Text = ""
        suffix.Text = ""
        birthDate.Value = DateTime.Now
        maritalStatus.Text = ""
        gender.Text = ""
        weight.Text = ""
        height.Text = ""
        bloodType.Text = ""
        age.Text = ""
        purok.Text = ""
        cpNum.Text = ""
        email.Text = ""
        job.Text = ""
        RiskCB.Text = ""
        philHealthCB.Checked = False
        phIDtb.Text = ""
        phIDCategory.Text = ""

    End Sub


    Private Sub EditCitizens_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        birthDate.Format = DateTimePickerFormat.Custom
        birthDate.CustomFormat = "yyy-MM-dd"
        fieldsStatus(False)

        If Not fromSearch Then
            datatable = SQLConnection.executeQuery("Select * from citizen")
            populateFields(citizenIndex)
        End If
        RiskCB.Items.AddRange(System.IO.File.ReadAllLines(Application.StartupPath & "\RiskGroup.txt"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PboxImg.ImageLocation = OpenFileDialog1.FileName()
    End Sub

    Public Sub populateFields(ByVal index As Integer)

        If datatable.Rows.Count = 0 Then
            Return
        End If

        citizenID = datatable.Rows().Item(index).Item(0).ToString()
        firstName.Text = datatable.Rows().Item(index).Item(1).ToString()
        middleName.Text = datatable.Rows().Item(index).Item(2).ToString()
        lastName.Text = datatable.Rows().Item(index).Item(3).ToString()
        suffix.Text = datatable.Rows().Item(index).Item(4).ToString()
        birthDate.Value = Convert.ToDateTime(datatable.Rows().Item(index).Item(5).ToString())
        maritalStatus.Text = datatable.Rows().Item(index).Item(6).ToString()
        gender.Text = datatable.Rows().Item(index).Item(7).ToString()
        weight.Text = datatable.Rows().Item(index).Item(8).ToString()
        height.Text = datatable.Rows().Item(index).Item(9).ToString()
        bloodType.Text = datatable.Rows().Item(index).Item(10).ToString()
        purok.Text = datatable.Rows().Item(index).Item(12).ToString()
        cpNum.Text = datatable.Rows().Item(index).Item(13).ToString()
        email.Text = datatable.Rows().Item(index).Item(14).ToString()
        job.Text = datatable.Rows().Item(index).Item(15).ToString()

        RiskCB.Text = datatable.Rows().Item(index).Item(20).ToString()
        If datatable.Rows().Item(index).Item(21).ToString() = "1" Then
            philHealthCB.Checked = True
        Else
            philHealthCB.Checked = False
        End If

        phIDtb.Text = datatable.Rows().Item(index).Item(22).ToString()
        phIDCategory.Text = datatable.Rows().Item(index).Item(23).ToString()

        Dim bdate As DateTime = Convert.ToDateTime(birthDate.Value)
        age.Text = Math.Round((DateTime.Now.AddDays(-7) - bdate).TotalDays / 365)


        Try
            clearSignature()
            pBoxSignature.Image = Nothing
            Dim ms As New IO.MemoryStream(CType(datatable.Rows().Item(index).Item(16), Byte()))
            Dim returnImage As Image = Image.FromStream(ms)
            pBoxSignature.Image = returnImage

        Catch ex As Exception
            clearSignature()
        End Try

        Try
            PboxImg.Image = Nothing
            Dim nms As New IO.MemoryStream(CType(datatable.Rows().Item(index).Item(17), Byte()))
            Dim nreturnImage As Image = Image.FromStream(nms)
            PboxImg.Image = nreturnImage

        Catch ex As Exception
            PboxImg.Image = Nothing
        End Try

    End Sub

    Public Sub buttonStatus(ByVal status As Boolean, ByVal btnName As String)

        If btnName = "Add" Then
            Button2.Enabled = Not status
            Button3.Enabled = Not Button2.Enabled
        ElseIf btnName = "Edit" Then
            Button3.Enabled = Not status
            Button2.Enabled = Not Button2.Enabled
        Else
            Button3.Enabled = status
            Button2.Enabled = status
        End If

        If btnName = "Edit" Or btnName = "Cancel" Then
            Button4.Enabled = Not status
        Else
            Button4.Enabled = status
        End If

        Button5.Enabled = Not status
        Button6.Enabled = Not status
        Button7.Enabled = status
        Button8.Enabled = status
        Button9.Enabled = Not status
        Button1.Enabled = Not status
        Button11.Enabled = Not status

    End Sub

    Public Sub fieldsStatus(ByVal status As Boolean)
        firstName.Enabled = status
        middleName.Enabled = status
        lastName.Enabled = status
        suffix.Enabled = status
        birthDate.Enabled = status
        cpNum.Enabled = status
        email.Enabled = status
        job.Enabled = status
        maritalStatus.Enabled = status
        gender.Enabled = status
        purok.Enabled = status
        weight.Enabled = status
        height.Enabled = status
        bloodType.Enabled = status
        pBoxSignature.Enabled = status
        Button1.Enabled = status
        RiskCB.Enabled = status
        philHealthCB.Enabled = status
        phIDCategory.Enabled = status
        phIDtb.Enabled = status
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to Delete this Entry?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Dim query As String = "delete from citizen where citizen_id = '" & citizenID & "'"
            SQLConnection.executeCommand(query)
            buttonStatus(True, "Cancel")
            populateFields(citizenIndex)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        isEditing = True
        citizenID = datatable.Rows().Item(citizenIndex).Item(0).ToString()
        saveType = "edit"
        fieldsStatus(True)
        buttonStatus(False, "Edit")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        buttonStatus(True, "Cancel")
        fieldsStatus(False)
        populateFields(citizenIndex)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If fromSearch Then
            Dim query As String = "Select * from citizen"
            datatable = SQLConnection.executeQuery(query)
            fromSearch = False
        End If

        citizenIndex += 1
        If citizenIndex > datatable.Rows.Count - 1 Then
            citizenIndex = 0
        End If
        populateFields(citizenIndex)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If fromSearch Then
            Dim query As String = "Select * from citizen"
            datatable = SQLConnection.executeQuery(query)
            fromSearch = False
        End If

        citizenIndex -= 1
        If citizenIndex < 0 Then
            citizenIndex = datatable.Rows.Count - 1
        End If
        populateFields(citizenIndex)
    End Sub

    Public Sub citizenname(ByVal id As String)
        Dim query As String = "Select * from citizen where citizen_id = '" & id & "'"
        datatable = SQLConnection.executeQuery(query)

        populateFields(0)
        fromSearch = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim query As String = "Select household_id from citizen where citizen_id = '" & citizenID & "'"
        Dim datatable2 As DataTable = SQLConnection.executeQuery(query)

        If datatable2.Rows.Count = 0 Then
            Return
        End If

        If datatable2.Rows.Item(0).Item(0).ToString() = "" Then
            MsgBox("This person is not part of any Household!")
        Else
            HouseHold.householdID = datatable2.Rows.Item(0).Item(0).ToString()
            HouseHold.refreshMembersfrEdit()
            HouseHold.Show()
        End If
    End Sub

    Private Function fieldsCheck() As Boolean
        Dim isTBEmpty As Boolean = False
        Dim color As Color = Color.Yellow
        If firstName.Text = "" Then
            firstName.BackColor = color
            isTBEmpty = True
        End If
        If middleName.Text = "" Then
            middleName.BackColor = color
            isTBEmpty = True
        End If
        If lastName.Text = "" Then
            lastName.BackColor = color
            isTBEmpty = True
        End If
        If suffix.Text = "" Then
            suffix.BackColor = color
            isTBEmpty = True
        End If
        If cpNum.Text = "" Then
            cpNum.BackColor = color
            isTBEmpty = True
        End If
        If job.Text = "" Then
            job.BackColor = color
            isTBEmpty = True
        End If
        If email.Text = "" Then
            email.BackColor = color
            isTBEmpty = True
        End If
        If maritalStatus.Text = "" Then
            maritalStatus.BackColor = color
            isTBEmpty = True
        End If
        If gender.Text = "" Then
            gender.BackColor = color
            isTBEmpty = True
        End If
        If weight.Text = "" Then
            weight.BackColor = color
            isTBEmpty = True
        End If
        If height.Text = "" Then
            height.BackColor = color
            isTBEmpty = True
        End If
        If bloodType.Text = "" Then
            bloodType.BackColor = color
            isTBEmpty = True
        End If
        If purok.Text = "" Then
            purok.BackColor = color
            isTBEmpty = True
        End If
        If RiskCB.Text = "" Then
            RiskCB.BackColor = color
            isTBEmpty = True
        End If
        If phIDtb.Text = "" Then
            phIDtb.BackColor = color
            isTBEmpty = True
        End If
        If phIDCategory.Text = "" Then
            phIDCategory.BackColor = color
            isTBEmpty = True
        End If

        Return isTBEmpty
    End Function

    Private Sub FirstName_Click(sender As Object, e As EventArgs) Handles firstName.Click
        firstName.BackColor = Color.White
    End Sub

    Private Sub MiddleName_Click(sender As Object, e As EventArgs) Handles middleName.Click
        middleName.BackColor = Color.White
    End Sub

    Private Sub LastName_Click(sender As Object, e As EventArgs) Handles lastName.Click
        lastName.BackColor = Color.White
    End Sub

    Private Sub Suffix_Click(sender As Object, e As EventArgs) Handles suffix.Click
        suffix.BackColor = Color.White
    End Sub

    Private Sub CpNum_Click(sender As Object, e As EventArgs) Handles cpNum.Click
        cpNum.BackColor = Color.White
    End Sub

    Private Sub Email_Click(sender As Object, e As EventArgs) Handles email.Click
        email.BackColor = Color.White
    End Sub

    Private Sub Job_Click(sender As Object, e As EventArgs) Handles job.Click
        job.BackColor = Color.White
    End Sub

    Private Sub MaritalStatus_Click(sender As Object, e As EventArgs) Handles maritalStatus.Click
        maritalStatus.BackColor = Color.White
    End Sub

    Private Sub Gender_Click(sender As Object, e As EventArgs) Handles gender.Click
        gender.BackColor = Color.White
    End Sub

    Private Sub Purok_Click(sender As Object, e As EventArgs) Handles purok.Click
        purok.BackColor = Color.White
    End Sub

    Private Sub Weight_Click(sender As Object, e As EventArgs) Handles weight.Click
        weight.BackColor = Color.White
    End Sub

    Private Sub Height_Click(sender As Object, e As EventArgs) Handles height.Click
        height.BackColor = Color.White
    End Sub

    Private Sub BloodType_Click(sender As Object, e As EventArgs) Handles bloodType.Click
        bloodType.BackColor = Color.White
    End Sub

    Private Sub PhilHealthCB_CheckedChanged(sender As Object, e As EventArgs) Handles philHealthCB.CheckedChanged
        If isEditing Then
            If philHealthCB.Checked Then
                phIDtb.Enabled = True
                phIDCategory.Enabled = True
            Else
                phIDtb.Enabled = False
                phIDCategory.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Camera.Show()
    End Sub
End Class