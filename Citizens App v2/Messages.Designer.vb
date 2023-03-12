<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Messages
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Messages))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New ns1.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Close = New ns1.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.RichTextbox1 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New ns1.BunifuImageButton()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.btn_Close)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(-3, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1274, 47)
        Me.Panel1.TabIndex = 0
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.btn_Close, BunifuAnimatorNS.DecorationType.None)
        Me.btn_Close.ErrorImage = CType(resources.GetObject("btn_Close.ErrorImage"), System.Drawing.Image)
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.ImageActive = Nothing
        Me.btn_Close.InitialImage = CType(resources.GetObject("btn_Close.InitialImage"), System.Drawing.Image)
        Me.btn_Close.Location = New System.Drawing.Point(1236, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(35, 34)
        Me.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Close.TabIndex = 13
        Me.btn_Close.TabStop = False
        Me.btn_Close.Zoom = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Type Message here:"
        '
        'TextBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox1.Location = New System.Drawing.Point(551, 223)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(346, 26)
        Me.TextBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Location = New System.Drawing.Point(553, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Choose Recipients here:"
        '
        'Button4
        '
        Me.BunifuTransition1.SetDecoration(Me.Button4, BunifuAnimatorNS.DecorationType.None)
        Me.Button4.Location = New System.Drawing.Point(1174, 617)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 58)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Send to All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.BunifuTransition1.SetDecoration(Me.Button5, BunifuAnimatorNS.DecorationType.None)
        Me.Button5.Location = New System.Drawing.Point(1029, 617)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 58)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Send To Recipients"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.CheckedListBox1, BunifuAnimatorNS.DecorationType.None)
        Me.CheckedListBox1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(551, 252)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(346, 344)
        Me.CheckedListBox1.TabIndex = 12
        '
        'StatusStrip1
        '
        Me.BunifuTransition1.SetDecoration(Me.StatusStrip1, BunifuAnimatorNS.DecorationType.None)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 678)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1270, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Location = New System.Drawing.Point(903, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Recipients:"
        '
        'Button1
        '
        Me.BunifuTransition1.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Button1.Location = New System.Drawing.Point(551, 602)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 35)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Add to Recipients"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.BunifuTransition1.SetDecoration(Me.ListView1, BunifuAnimatorNS.DecorationType.None)
        Me.ListView1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(907, 265)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(351, 346)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button2
        '
        Me.BunifuTransition1.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.Button2.Location = New System.Drawing.Point(725, 602)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 35)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Clear Recipients"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.BunifuTransition1.SetDecoration(Me.GroupBox1, BunifuAnimatorNS.DecorationType.None)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(551, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 145)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SMS Module Setting"
        '
        'Button6
        '
        Me.BunifuTransition1.SetDecoration(Me.Button6, BunifuAnimatorNS.DecorationType.None)
        Me.Button6.Location = New System.Drawing.Point(146, 94)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(119, 35)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Refresh Port"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.BunifuTransition1.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.Button3.Location = New System.Drawing.Point(28, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 35)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Check Port"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Location = New System.Drawing.Point(308, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sending Status"
        '
        'ProgressBar1
        '
        Me.BunifuTransition1.SetDecoration(Me.ProgressBar1, BunifuAnimatorNS.DecorationType.None)
        Me.ProgressBar1.Location = New System.Drawing.Point(311, 57)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(373, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'ComboBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.ComboBox1, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(136, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.ComboBox1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Location = New System.Drawing.Point(26, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Module Port:"
        '
        'TextBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox2, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(146, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 25)
        Me.TextBox2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Location = New System.Drawing.Point(25, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Module Status:"
        '
        'RichTextbox1
        '
        Me.BunifuTransition1.SetDecoration(Me.RichTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.RichTextbox1.Location = New System.Drawing.Point(16, 79)
        Me.RichTextbox1.Multiline = True
        Me.RichTextbox1.Name = "RichTextbox1"
        Me.RichTextbox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RichTextbox1.Size = New System.Drawing.Size(518, 596)
        Me.RichTextbox1.TabIndex = 20
        '
        'Button7
        '
        Me.BunifuTransition1.SetDecoration(Me.Button7, BunifuAnimatorNS.DecorationType.None)
        Me.Button7.Location = New System.Drawing.Point(907, 617)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(116, 58)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "Send Via Email"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(890, 348)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(378, 316)
        Me.Panel2.TabIndex = 22
        Me.Panel2.Visible = False
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.ErrorImage = CType(resources.GetObject("BunifuImageButton1.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.InitialImage = CType(resources.GetObject("BunifuImageButton1.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(340, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 34)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 14
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation2
        '
        'TextBox3
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox3, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox3.Location = New System.Drawing.Point(16, 182)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(346, 26)
        Me.TextBox3.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Location = New System.Drawing.Point(12, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Subject:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Location = New System.Drawing.Point(13, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Email Password:"
        '
        'TextBox4
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox4, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox4.Location = New System.Drawing.Point(17, 121)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox4.Size = New System.Drawing.Size(346, 26)
        Me.TextBox4.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Location = New System.Drawing.Point(13, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Your Email:"
        '
        'TextBox5
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox5, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox5.Location = New System.Drawing.Point(17, 60)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(346, 26)
        Me.TextBox5.TabIndex = 20
        '
        'Button10
        '
        Me.BunifuTransition1.SetDecoration(Me.Button10, BunifuAnimatorNS.DecorationType.None)
        Me.Button10.Location = New System.Drawing.Point(235, 231)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(128, 58)
        Me.Button10.TabIndex = 25
        Me.Button10.Text = "Send To Recipients"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Messages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1270, 700)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.RichTextbox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Messages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Messages"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents BunifuDragControl1 As ns1.BunifuDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Close As ns1.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button3 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextbox1 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
