<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCitizens
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditCitizens))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New ns1.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Close = New ns1.BunifuImageButton()
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.birthDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.middleName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cpNum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.suffix = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.job = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.maritalStatus = New System.Windows.Forms.ComboBox()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.weight = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.height = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.bloodType = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PBpanel = New System.Windows.Forms.Panel()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PboxImg = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pBoxSignature = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.purok = New System.Windows.Forms.ComboBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.RiskCB = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.philHealthCB = New System.Windows.Forms.CheckBox()
        Me.phIDtb = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.phIDCategory = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PBpanel.SuspendLayout()
        CType(Me.PboxImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.btn_Close)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1037, 44)
        Me.Panel1.TabIndex = 2
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.btn_Close.ErrorImage = CType(resources.GetObject("btn_Close.ErrorImage"), System.Drawing.Image)
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.ImageActive = Nothing
        Me.btn_Close.InitialImage = CType(resources.GetObject("btn_Close.InitialImage"), System.Drawing.Image)
        Me.btn_Close.Location = New System.Drawing.Point(999, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(35, 34)
        Me.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Close.TabIndex = 11
        Me.btn_Close.TabStop = False
        Me.btn_Close.Zoom = 10
        '
        'firstName
        '
        Me.firstName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName.Location = New System.Drawing.Point(27, 138)
        Me.firstName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(309, 26)
        Me.firstName.TabIndex = 0
        '
        'birthDate
        '
        Me.birthDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthDate.Location = New System.Drawing.Point(27, 332)
        Me.birthDate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.birthDate.Name = "birthDate"
        Me.birthDate.Size = New System.Drawing.Size(309, 26)
        Me.birthDate.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(32, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(32, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Middle Name:"
        '
        'middleName
        '
        Me.middleName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middleName.Location = New System.Drawing.Point(27, 197)
        Me.middleName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.middleName.Name = "middleName"
        Me.middleName.Size = New System.Drawing.Size(309, 26)
        Me.middleName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(32, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Last Name:"
        '
        'lastName
        '
        Me.lastName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastName.Location = New System.Drawing.Point(27, 262)
        Me.lastName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(241, 26)
        Me.lastName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(32, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "BirthDate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(32, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 19)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Purok:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(366, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "CP#:"
        '
        'cpNum
        '
        Me.cpNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpNum.Location = New System.Drawing.Point(361, 138)
        Me.cpNum.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cpNum.Name = "cpNum"
        Me.cpNum.Size = New System.Drawing.Size(309, 26)
        Me.cpNum.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(366, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Email:"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(361, 197)
        Me.email.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(309, 26)
        Me.email.TabIndex = 4
        '
        'suffix
        '
        Me.suffix.FormattingEnabled = True
        Me.suffix.Items.AddRange(New Object() {"Jr.", "Sr."})
        Me.suffix.Location = New System.Drawing.Point(276, 261)
        Me.suffix.Name = "suffix"
        Me.suffix.Size = New System.Drawing.Size(60, 27)
        Me.suffix.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(272, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 19)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Suffix:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(927, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 55)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(927, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 55)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "EDIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Enabled = False
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(927, 473)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 55)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Enabled = False
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(927, 627)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 84)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "SAVE"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(366, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Job/Work:"
        '
        'job
        '
        Me.job.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.job.Location = New System.Drawing.Point(361, 262)
        Me.job.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.job.Name = "job"
        Me.job.Size = New System.Drawing.Size(309, 26)
        Me.job.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(366, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 19)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Marital Status:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(522, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 19)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Gender:"
        '
        'maritalStatus
        '
        Me.maritalStatus.FormattingEnabled = True
        Me.maritalStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Divorced"})
        Me.maritalStatus.Location = New System.Drawing.Point(361, 331)
        Me.maritalStatus.Name = "maritalStatus"
        Me.maritalStatus.Size = New System.Drawing.Size(159, 27)
        Me.maritalStatus.TabIndex = 7
        '
        'gender
        '
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.gender.Location = New System.Drawing.Point(526, 331)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(144, 27)
        Me.gender.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(32, 450)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 19)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Weight:"
        '
        'weight
        '
        Me.weight.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weight.Location = New System.Drawing.Point(27, 473)
        Me.weight.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.weight.Name = "weight"
        Me.weight.Size = New System.Drawing.Size(118, 26)
        Me.weight.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(192, 450)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 19)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Height:"
        '
        'height
        '
        Me.height.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.height.Location = New System.Drawing.Point(196, 473)
        Me.height.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.height.Name = "height"
        Me.height.Size = New System.Drawing.Size(107, 26)
        Me.height.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(311, 476)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 19)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Inches"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(153, 476)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 19)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "kg"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(382, 450)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 19)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Blood Type:"
        '
        'bloodType
        '
        Me.bloodType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bloodType.Location = New System.Drawing.Point(386, 473)
        Me.bloodType.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.bloodType.Name = "bloodType"
        Me.bloodType.Size = New System.Drawing.Size(107, 26)
        Me.bloodType.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(25, 580)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 19)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Signature:"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Enabled = False
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(594, 671)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 40)
        Me.Button6.TabIndex = 57
        Me.Button6.Text = "CLEAR"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PBpanel
        '
        Me.PBpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PBpanel.Controls.Add(Me.Button11)
        Me.PBpanel.Controls.Add(Me.Button1)
        Me.PBpanel.Controls.Add(Me.PboxImg)
        Me.PBpanel.Location = New System.Drawing.Point(809, 107)
        Me.PBpanel.Name = "PBpanel"
        Me.PBpanel.Size = New System.Drawing.Size(216, 237)
        Me.PBpanel.TabIndex = 58
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.BackgroundImage = Global.Citizens_App_v2.My.Resources.Resources.camera_100px
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Enabled = False
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(168, 196)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(45, 38)
        Me.Button11.TabIndex = 75
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Enabled = False
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(3, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 38)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PboxImg
        '
        Me.PboxImg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PboxImg.BackColor = System.Drawing.Color.White
        Me.PboxImg.Image = Global.Citizens_App_v2.My.Resources.Resources.people_80px
        Me.PboxImg.Location = New System.Drawing.Point(9, 16)
        Me.PboxImg.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PboxImg.Name = "PboxImg"
        Me.PboxImg.Size = New System.Drawing.Size(199, 204)
        Me.PboxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxImg.TabIndex = 14
        Me.PboxImg.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(703, 656)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 55)
        Me.Button7.TabIndex = 59
        Me.Button7.Text = "BACK"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(807, 656)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(98, 55)
        Me.Button8.TabIndex = 60
        Me.Button8.Text = "NEXT"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 714)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1037, 22)
        Me.StatusStrip1.TabIndex = 61
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pBoxSignature
        '
        Me.pBoxSignature.BackColor = System.Drawing.Color.White
        Me.pBoxSignature.Location = New System.Drawing.Point(23, 602)
        Me.pBoxSignature.Name = "pBoxSignature"
        Me.pBoxSignature.Size = New System.Drawing.Size(565, 109)
        Me.pBoxSignature.TabIndex = 55
        Me.pBoxSignature.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(536, 450)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 19)
        Me.Label18.TabIndex = 63
        Me.Label18.Text = "Age:"
        '
        'age
        '
        Me.age.Enabled = False
        Me.age.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.Location = New System.Drawing.Point(540, 473)
        Me.age.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(107, 26)
        Me.age.TabIndex = 13
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(823, 473)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(98, 55)
        Me.Button9.TabIndex = 64
        Me.Button9.Text = "CANCEL"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'purok
        '
        Me.purok.FormattingEnabled = True
        Me.purok.Items.AddRange(New Object() {"Casantolan North", "Casantolan South", "Mabarit", "Cabatuan", "Riverside East", "Riverside West", "Puongan"})
        Me.purok.Location = New System.Drawing.Point(27, 399)
        Me.purok.Name = "purok"
        Me.purok.Size = New System.Drawing.Size(180, 27)
        Me.purok.TabIndex = 9
        '
        'address
        '
        Me.address.Enabled = False
        Me.address.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(215, 399)
        Me.address.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(455, 26)
        Me.address.TabIndex = 66
        Me.address.Text = "Mabasa , Dupax del Norte , Nueva Vizcaya"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(27, 51)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(199, 55)
        Me.Button10.TabIndex = 67
        Me.Button10.Text = "Show Household"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'RiskCB
        '
        Me.RiskCB.Enabled = False
        Me.RiskCB.FormattingEnabled = True
        Me.RiskCB.Location = New System.Drawing.Point(27, 542)
        Me.RiskCB.Name = "RiskCB"
        Me.RiskCB.Size = New System.Drawing.Size(309, 27)
        Me.RiskCB.TabIndex = 68
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(32, 520)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(182, 19)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Age/Health Risk Group"
        '
        'philHealthCB
        '
        Me.philHealthCB.AutoSize = True
        Me.philHealthCB.Enabled = False
        Me.philHealthCB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.philHealthCB.Location = New System.Drawing.Point(361, 505)
        Me.philHealthCB.Name = "philHealthCB"
        Me.philHealthCB.Size = New System.Drawing.Size(181, 23)
        Me.philHealthCB.TabIndex = 70
        Me.philHealthCB.Text = "PhilHealth Member?"
        Me.philHealthCB.UseVisualStyleBackColor = True
        '
        'phIDtb
        '
        Me.phIDtb.Enabled = False
        Me.phIDtb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phIDtb.Location = New System.Drawing.Point(361, 553)
        Me.phIDtb.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.phIDtb.Name = "phIDtb"
        Me.phIDtb.Size = New System.Drawing.Size(197, 26)
        Me.phIDtb.TabIndex = 71
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(360, 530)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 19)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "ID No." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(567, 530)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 19)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "Category"
        '
        'phIDCategory
        '
        Me.phIDCategory.Enabled = False
        Me.phIDCategory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phIDCategory.Location = New System.Drawing.Point(568, 553)
        Me.phIDCategory.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.phIDCategory.Name = "phIDCategory"
        Me.phIDCategory.Size = New System.Drawing.Size(102, 26)
        Me.phIDCategory.TabIndex = 73
        '
        'EditCitizens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1037, 736)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.phIDCategory)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.phIDtb)
        Me.Controls.Add(Me.philHealthCB)
        Me.Controls.Add(Me.RiskCB)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.purok)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.PBpanel)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.pBoxSignature)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.bloodType)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.height)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.weight)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.maritalStatus)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.job)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.suffix)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cpNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.middleName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.birthDate)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "EditCitizens"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditCitizens"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PBpanel.ResumeLayout(False)
        CType(Me.PboxImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents BunifuDragControl1 As ns1.BunifuDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PboxImg As PictureBox
    Friend WithEvents firstName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents bloodType As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents height As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents weight As TextBox
    Friend WithEvents gender As ComboBox
    Friend WithEvents maritalStatus As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents job As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents suffix As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cpNum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents middleName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents birthDate As DateTimePicker
    Friend WithEvents pBoxSignature As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents PBpanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btn_Close As ns1.BunifuImageButton
    Friend WithEvents Label18 As Label
    Friend WithEvents age As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button9 As Button
    Friend WithEvents address As TextBox
    Friend WithEvents purok As ComboBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents phIDCategory As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents phIDtb As TextBox
    Friend WithEvents philHealthCB As CheckBox
    Friend WithEvents RiskCB As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Button11 As Button
End Class
