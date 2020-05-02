<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GolfForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControlCareMenu = New System.Windows.Forms.TabControl
        Me.TabPageGuestBooking = New System.Windows.Forms.TabPage
        Me.PanelBackground = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PanelGuestBooking_ListOfBooking = New System.Windows.Forms.Panel
        Me.TabPagePlayer = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.ButtonPlayer_AddScore = New System.Windows.Forms.Button
        Me.ButtonPlayer_ModificationOfPlayer = New System.Windows.Forms.Button
        Me.ButtonPlayer_NewPlayer = New System.Windows.Forms.Button
        Me.PanelPlayerScore = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBoxSearchFilter = New System.Windows.Forms.GroupBox
        Me.ButtonAllPlayer = New System.Windows.Forms.Button
        Me.TextBoxPlayer_Surname = New System.Windows.Forms.TextBox
        Me.TextBoxPlayer_Name = New System.Windows.Forms.TextBox
        Me.LabelSurname = New System.Windows.Forms.Label
        Me.LabelName = New System.Windows.Forms.Label
        Me.PanelListOfPlayers = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TabControlCareMenu.SuspendLayout()
        Me.TabPageGuestBooking.SuspendLayout()
        Me.PanelBackground.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPagePlayer.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.PanelPlayerScore.SuspendLayout()
        Me.GroupBoxSearchFilter.SuspendLayout()
        Me.PanelListOfPlayers.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlCareMenu
        '
        Me.TabControlCareMenu.Controls.Add(Me.TabPageGuestBooking)
        Me.TabControlCareMenu.Controls.Add(Me.TabPagePlayer)
        Me.TabControlCareMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlCareMenu.Location = New System.Drawing.Point(0, 0)
        Me.TabControlCareMenu.Name = "TabControlCareMenu"
        Me.TabControlCareMenu.SelectedIndex = 0
        Me.TabControlCareMenu.Size = New System.Drawing.Size(813, 524)
        Me.TabControlCareMenu.TabIndex = 1
        '
        'TabPageGuestBooking
        '
        Me.TabPageGuestBooking.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPageGuestBooking.Controls.Add(Me.PanelBackground)
        Me.TabPageGuestBooking.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGuestBooking.Name = "TabPageGuestBooking"
        Me.TabPageGuestBooking.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGuestBooking.Size = New System.Drawing.Size(805, 498)
        Me.TabPageGuestBooking.TabIndex = 0
        Me.TabPageGuestBooking.Text = "Guest booking"
        Me.TabPageGuestBooking.UseVisualStyleBackColor = True
        '
        'PanelBackground
        '
        Me.PanelBackground.AutoScroll = True
        Me.PanelBackground.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelBackground.Controls.Add(Me.GroupBox1)
        Me.PanelBackground.Controls.Add(Me.Label2)
        Me.PanelBackground.Controls.Add(Me.PanelGuestBooking_ListOfBooking)
        Me.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBackground.Location = New System.Drawing.Point(3, 3)
        Me.PanelBackground.Name = "PanelBackground"
        Me.PanelBackground.Size = New System.Drawing.Size(799, 492)
        Me.PanelBackground.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(365, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 262)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search filter"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(11, 89)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 31
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(126, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 27)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 50)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(109, 27)
        Me.TextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(135, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(17, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(87, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 37)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "List of booking"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelGuestBooking_ListOfBooking
        '
        Me.PanelGuestBooking_ListOfBooking.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelGuestBooking_ListOfBooking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelGuestBooking_ListOfBooking.Location = New System.Drawing.Point(53, 68)
        Me.PanelGuestBooking_ListOfBooking.Name = "PanelGuestBooking_ListOfBooking"
        Me.PanelGuestBooking_ListOfBooking.Size = New System.Drawing.Size(254, 403)
        Me.PanelGuestBooking_ListOfBooking.TabIndex = 27
        '
        'TabPagePlayer
        '
        Me.TabPagePlayer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPagePlayer.Controls.Add(Me.Label1)
        Me.TabPagePlayer.Controls.Add(Me.Label36)
        Me.TabPagePlayer.Controls.Add(Me.GroupBox11)
        Me.TabPagePlayer.Controls.Add(Me.PanelPlayerScore)
        Me.TabPagePlayer.Controls.Add(Me.GroupBoxSearchFilter)
        Me.TabPagePlayer.Controls.Add(Me.PanelListOfPlayers)
        Me.TabPagePlayer.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePlayer.Name = "TabPagePlayer"
        Me.TabPagePlayer.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePlayer.Size = New System.Drawing.Size(805, 498)
        Me.TabPagePlayer.TabIndex = 1
        Me.TabPagePlayer.Text = "Players"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(564, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 37)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Player's score"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Script MT Bold", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label36.Location = New System.Drawing.Point(288, 21)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(185, 37)
        Me.Label36.TabIndex = 34
        Me.Label36.Text = "List of player"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox11.Controls.Add(Me.ButtonPlayer_AddScore)
        Me.GroupBox11.Controls.Add(Me.ButtonPlayer_ModificationOfPlayer)
        Me.GroupBox11.Controls.Add(Me.ButtonPlayer_NewPlayer)
        Me.GroupBox11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox11.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox11.Location = New System.Drawing.Point(24, 190)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(208, 153)
        Me.GroupBox11.TabIndex = 32
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Menu"
        '
        'ButtonPlayer_AddScore
        '
        Me.ButtonPlayer_AddScore.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlayer_AddScore.Location = New System.Drawing.Point(6, 105)
        Me.ButtonPlayer_AddScore.Name = "ButtonPlayer_AddScore"
        Me.ButtonPlayer_AddScore.Size = New System.Drawing.Size(196, 36)
        Me.ButtonPlayer_AddScore.TabIndex = 3
        Me.ButtonPlayer_AddScore.Text = "Add Score"
        Me.ButtonPlayer_AddScore.UseVisualStyleBackColor = True
        '
        'ButtonPlayer_ModificationOfPlayer
        '
        Me.ButtonPlayer_ModificationOfPlayer.Enabled = False
        Me.ButtonPlayer_ModificationOfPlayer.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlayer_ModificationOfPlayer.Location = New System.Drawing.Point(6, 63)
        Me.ButtonPlayer_ModificationOfPlayer.Name = "ButtonPlayer_ModificationOfPlayer"
        Me.ButtonPlayer_ModificationOfPlayer.Size = New System.Drawing.Size(196, 36)
        Me.ButtonPlayer_ModificationOfPlayer.TabIndex = 2
        Me.ButtonPlayer_ModificationOfPlayer.Text = "Modification Of Player"
        Me.ButtonPlayer_ModificationOfPlayer.UseVisualStyleBackColor = True
        '
        'ButtonPlayer_NewPlayer
        '
        Me.ButtonPlayer_NewPlayer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonPlayer_NewPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonPlayer_NewPlayer.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlayer_NewPlayer.Location = New System.Drawing.Point(6, 19)
        Me.ButtonPlayer_NewPlayer.Name = "ButtonPlayer_NewPlayer"
        Me.ButtonPlayer_NewPlayer.Size = New System.Drawing.Size(196, 39)
        Me.ButtonPlayer_NewPlayer.TabIndex = 0
        Me.ButtonPlayer_NewPlayer.Text = "New Player"
        Me.ButtonPlayer_NewPlayer.UseVisualStyleBackColor = True
        '
        'PanelPlayerScore
        '
        Me.PanelPlayerScore.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelPlayerScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelPlayerScore.Controls.Add(Me.Label6)
        Me.PanelPlayerScore.Controls.Add(Me.Label5)
        Me.PanelPlayerScore.Location = New System.Drawing.Point(528, 61)
        Me.PanelPlayerScore.Name = "PanelPlayerScore"
        Me.PanelPlayerScore.Size = New System.Drawing.Size(255, 415)
        Me.PanelPlayerScore.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(161, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 22)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Score"
        '
        'GroupBoxSearchFilter
        '
        Me.GroupBoxSearchFilter.Controls.Add(Me.ButtonAllPlayer)
        Me.GroupBoxSearchFilter.Controls.Add(Me.TextBoxPlayer_Surname)
        Me.GroupBoxSearchFilter.Controls.Add(Me.TextBoxPlayer_Name)
        Me.GroupBoxSearchFilter.Controls.Add(Me.LabelSurname)
        Me.GroupBoxSearchFilter.Controls.Add(Me.LabelName)
        Me.GroupBoxSearchFilter.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSearchFilter.Location = New System.Drawing.Point(24, 52)
        Me.GroupBoxSearchFilter.Name = "GroupBoxSearchFilter"
        Me.GroupBoxSearchFilter.Size = New System.Drawing.Size(208, 106)
        Me.GroupBoxSearchFilter.TabIndex = 32
        Me.GroupBoxSearchFilter.TabStop = False
        Me.GroupBoxSearchFilter.Text = "Search filter"
        '
        'ButtonAllPlayer
        '
        Me.ButtonAllPlayer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonAllPlayer.Location = New System.Drawing.Point(11, 70)
        Me.ButtonAllPlayer.Name = "ButtonAllPlayer"
        Me.ButtonAllPlayer.Size = New System.Drawing.Size(191, 28)
        Me.ButtonAllPlayer.TabIndex = 30
        Me.ButtonAllPlayer.Text = "View All Player"
        Me.ButtonAllPlayer.UseVisualStyleBackColor = True
        '
        'TextBoxPlayer_Surname
        '
        Me.TextBoxPlayer_Surname.Location = New System.Drawing.Point(109, 37)
        Me.TextBoxPlayer_Surname.Name = "TextBoxPlayer_Surname"
        Me.TextBoxPlayer_Surname.Size = New System.Drawing.Size(93, 27)
        Me.TextBoxPlayer_Surname.TabIndex = 3
        '
        'TextBoxPlayer_Name
        '
        Me.TextBoxPlayer_Name.Location = New System.Drawing.Point(10, 37)
        Me.TextBoxPlayer_Name.Name = "TextBoxPlayer_Name"
        Me.TextBoxPlayer_Name.Size = New System.Drawing.Size(90, 27)
        Me.TextBoxPlayer_Name.TabIndex = 2
        '
        'LabelSurname
        '
        Me.LabelSurname.AutoSize = True
        Me.LabelSurname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LabelSurname.Location = New System.Drawing.Point(106, 20)
        Me.LabelSurname.Name = "LabelSurname"
        Me.LabelSurname.Size = New System.Drawing.Size(66, 19)
        Me.LabelSurname.TabIndex = 1
        Me.LabelSurname.Text = "Surname"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LabelName.Location = New System.Drawing.Point(7, 20)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(49, 19)
        Me.LabelName.TabIndex = 0
        Me.LabelName.Text = "Name"
        '
        'PanelListOfPlayers
        '
        Me.PanelListOfPlayers.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelListOfPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelListOfPlayers.Controls.Add(Me.DataGridView1)
        Me.PanelListOfPlayers.Controls.Add(Me.Label8)
        Me.PanelListOfPlayers.Controls.Add(Me.Label7)
        Me.PanelListOfPlayers.Location = New System.Drawing.Point(254, 61)
        Me.PanelListOfPlayers.Name = "PanelListOfPlayers"
        Me.PanelListOfPlayers.Size = New System.Drawing.Size(255, 415)
        Me.PanelListOfPlayers.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(143, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 22)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(255, 349)
        Me.DataGridView1.TabIndex = 3
        '
        'GolfForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 524)
        Me.Controls.Add(Me.TabControlCareMenu)
        Me.Name = "GolfForm"
        Me.Text = "Golf"
        Me.TabControlCareMenu.ResumeLayout(False)
        Me.TabPageGuestBooking.ResumeLayout(False)
        Me.PanelBackground.ResumeLayout(False)
        Me.PanelBackground.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPagePlayer.ResumeLayout(False)
        Me.TabPagePlayer.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.PanelPlayerScore.ResumeLayout(False)
        Me.PanelPlayerScore.PerformLayout()
        Me.GroupBoxSearchFilter.ResumeLayout(False)
        Me.GroupBoxSearchFilter.PerformLayout()
        Me.PanelListOfPlayers.ResumeLayout(False)
        Me.PanelListOfPlayers.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlCareMenu As System.Windows.Forms.TabControl
    Friend WithEvents TabPageGuestBooking As System.Windows.Forms.TabPage
    Friend WithEvents PanelBackground As System.Windows.Forms.Panel
    Friend WithEvents PanelGuestBooking_ListOfBooking As System.Windows.Forms.Panel
    Friend WithEvents TabPagePlayer As System.Windows.Forms.TabPage
    Friend WithEvents GroupBoxSearchFilter As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonAllPlayer As System.Windows.Forms.Button
    Friend WithEvents TextBoxPlayer_Surname As System.Windows.Forms.TextBox
    Friend WithEvents LabelSurname As System.Windows.Forms.Label
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents PanelListOfPlayers As System.Windows.Forms.Panel
    Friend WithEvents PanelPlayerScore As System.Windows.Forms.Panel
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonPlayer_AddScore As System.Windows.Forms.Button
    Friend WithEvents ButtonPlayer_ModificationOfPlayer As System.Windows.Forms.Button
    Friend WithEvents ButtonPlayer_NewPlayer As System.Windows.Forms.Button
    Friend WithEvents TextBoxPlayer_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
