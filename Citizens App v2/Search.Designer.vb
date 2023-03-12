<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.itemsNumber = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.BunifuDragControl1 = New ns1.BunifuDragControl(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mstatus = New System.Windows.Forms.CheckBox()
        Me.cbmstatus = New System.Windows.Forms.ComboBox()
        Me.purok = New System.Windows.Forms.CheckBox()
        Me.gender = New System.Windows.Forms.CheckBox()
        Me.age = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbPurok = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.ageTo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ageFrom = New System.Windows.Forms.TextBox()
        Me.BunifuImageButton1 = New ns1.BunifuImageButton()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BunifuTransition1.SetDecoration(Me.StatusStrip1, BunifuAnimatorNS.DecorationType.None)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemsNumber})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 663)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1207, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'itemsNumber
        '
        Me.itemsNumber.Name = "itemsNumber"
        Me.itemsNumber.Size = New System.Drawing.Size(45, 17)
        Me.itemsNumber.Text = "0 items"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 52)
        Me.Panel1.TabIndex = 1
        '
        'searchBox
        '
        Me.BunifuTransition1.SetDecoration(Me.searchBox, BunifuAnimatorNS.DecorationType.None)
        Me.searchBox.Location = New System.Drawing.Point(7, 55)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(521, 26)
        Me.searchBox.TabIndex = 2
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuTransition1.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.DataGridView1.Location = New System.Drawing.Point(7, 89)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1197, 565)
        Me.DataGridView1.TabIndex = 6
        '
        'btnFilter
        '
        Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransition1.SetDecoration(Me.btnFilter, BunifuAnimatorNS.DecorationType.None)
        Me.btnFilter.Location = New System.Drawing.Point(1122, 54)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(82, 33)
        Me.btnFilter.TabIndex = 7
        Me.btnFilter.Text = "Filters..."
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Controls.Add(Me.mstatus)
        Me.Panel2.Controls.Add(Me.cbmstatus)
        Me.Panel2.Controls.Add(Me.purok)
        Me.Panel2.Controls.Add(Me.gender)
        Me.Panel2.Controls.Add(Me.age)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.cbPurok)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cbGender)
        Me.Panel2.Controls.Add(Me.ageTo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ageFrom)
        Me.Panel2.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(892, 49)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(317, 363)
        Me.Panel2.TabIndex = 8
        Me.Panel2.Visible = False
        '
        'mstatus
        '
        Me.mstatus.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.mstatus, BunifuAnimatorNS.DecorationType.None)
        Me.mstatus.Location = New System.Drawing.Point(13, 242)
        Me.mstatus.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.mstatus.Name = "mstatus"
        Me.mstatus.Size = New System.Drawing.Size(145, 24)
        Me.mstatus.TabIndex = 28
        Me.mstatus.Text = "Marital Status:"
        Me.mstatus.UseVisualStyleBackColor = True
        '
        'cbmstatus
        '
        Me.BunifuTransition1.SetDecoration(Me.cbmstatus, BunifuAnimatorNS.DecorationType.None)
        Me.cbmstatus.FormattingEnabled = True
        Me.cbmstatus.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Divorced"})
        Me.cbmstatus.Location = New System.Drawing.Point(163, 237)
        Me.cbmstatus.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbmstatus.Name = "cbmstatus"
        Me.cbmstatus.Size = New System.Drawing.Size(111, 28)
        Me.cbmstatus.TabIndex = 27
        '
        'purok
        '
        Me.purok.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.purok, BunifuAnimatorNS.DecorationType.None)
        Me.purok.Location = New System.Drawing.Point(13, 189)
        Me.purok.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.purok.Name = "purok"
        Me.purok.Size = New System.Drawing.Size(79, 24)
        Me.purok.TabIndex = 26
        Me.purok.Text = "Purok:"
        Me.purok.UseVisualStyleBackColor = True
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.gender, BunifuAnimatorNS.DecorationType.None)
        Me.gender.Location = New System.Drawing.Point(13, 138)
        Me.gender.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(93, 24)
        Me.gender.TabIndex = 25
        Me.gender.Text = "Gender:"
        Me.gender.UseVisualStyleBackColor = True
        '
        'age
        '
        Me.age.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.age, BunifuAnimatorNS.DecorationType.None)
        Me.age.Location = New System.Drawing.Point(13, 89)
        Me.age.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(65, 24)
        Me.age.TabIndex = 24
        Me.age.Text = "Age:"
        Me.age.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransition1.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.Button2.Location = New System.Drawing.Point(27, 282)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 65)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransition1.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Button1.Location = New System.Drawing.Point(163, 282)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 65)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbPurok
        '
        Me.BunifuTransition1.SetDecoration(Me.cbPurok, BunifuAnimatorNS.DecorationType.None)
        Me.cbPurok.FormattingEnabled = True
        Me.cbPurok.Items.AddRange(New Object() {"Casantolan North", "Casantolan South", "Mabarit", "Riverside East", "Riverside West", "Cabatuan", "Puongan"})
        Me.cbPurok.Location = New System.Drawing.Point(98, 186)
        Me.cbPurok.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbPurok.Name = "cbPurok"
        Me.cbPurok.Size = New System.Drawing.Size(147, 28)
        Me.cbPurok.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Filter by:"
        '
        'cbGender
        '
        Me.BunifuTransition1.SetDecoration(Me.cbGender, BunifuAnimatorNS.DecorationType.None)
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(112, 137)
        Me.cbGender.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(91, 28)
        Me.cbGender.TabIndex = 18
        '
        'ageTo
        '
        Me.BunifuTransition1.SetDecoration(Me.ageTo, BunifuAnimatorNS.DecorationType.None)
        Me.ageTo.Location = New System.Drawing.Point(155, 88)
        Me.ageTo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ageTo.Name = "ageTo"
        Me.ageTo.Size = New System.Drawing.Size(41, 26)
        Me.ageTo.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Location = New System.Drawing.Point(123, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "to"
        '
        'ageFrom
        '
        Me.BunifuTransition1.SetDecoration(Me.ageFrom, BunifuAnimatorNS.DecorationType.None)
        Me.ageFrom.Location = New System.Drawing.Point(80, 88)
        Me.ageFrom.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ageFrom.Name = "ageFrom"
        Me.ageFrom.Size = New System.Drawing.Size(41, 26)
        Me.ageFrom.TabIndex = 13
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
        Me.BunifuImageButton1.Location = New System.Drawing.Point(278, 5)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(37, 46)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 12
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1207, 685)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents searchBox As TextBox
    Friend WithEvents itemsNumber As ToolStripStatusLabel
    Friend WithEvents BunifuDragControl1 As ns1.BunifuDragControl
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnFilter As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents cbPurok As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents ageTo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ageFrom As TextBox
    Friend WithEvents purok As CheckBox
    Friend WithEvents gender As CheckBox
    Friend WithEvents age As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents mstatus As CheckBox
    Friend WithEvents cbmstatus As ComboBox
End Class
