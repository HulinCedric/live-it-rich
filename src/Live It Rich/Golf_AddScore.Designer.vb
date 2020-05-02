<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Golf_AddScore
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
        Me.PanelGolf_NewPlayer = New System.Windows.Forms.Panel
        Me.GroupBoxAddScore = New System.Windows.Forms.GroupBox
        Me.DateTimePickerAddScore = New System.Windows.Forms.DateTimePicker
        Me.TextBoxAddScore_Score = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonAddScore = New System.Windows.Forms.Button
        Me.TextBoxSurname = New System.Windows.Forms.TextBox
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.LabelName = New System.Windows.Forms.Label
        Me.LabelSurname = New System.Windows.Forms.Label
        Me.PanelGolf_NewPlayer.SuspendLayout()
        Me.GroupBoxAddScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelGolf_NewPlayer
        '
        Me.PanelGolf_NewPlayer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelGolf_NewPlayer.Controls.Add(Me.GroupBoxAddScore)
        Me.PanelGolf_NewPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGolf_NewPlayer.Location = New System.Drawing.Point(0, 0)
        Me.PanelGolf_NewPlayer.Name = "PanelGolf_NewPlayer"
        Me.PanelGolf_NewPlayer.Size = New System.Drawing.Size(267, 331)
        Me.PanelGolf_NewPlayer.TabIndex = 1
        '
        'GroupBoxAddScore
        '
        Me.GroupBoxAddScore.Controls.Add(Me.DateTimePickerAddScore)
        Me.GroupBoxAddScore.Controls.Add(Me.TextBoxAddScore_Score)
        Me.GroupBoxAddScore.Controls.Add(Me.Label2)
        Me.GroupBoxAddScore.Controls.Add(Me.Label1)
        Me.GroupBoxAddScore.Controls.Add(Me.ButtonAddScore)
        Me.GroupBoxAddScore.Controls.Add(Me.TextBoxSurname)
        Me.GroupBoxAddScore.Controls.Add(Me.TextBoxName)
        Me.GroupBoxAddScore.Controls.Add(Me.LabelName)
        Me.GroupBoxAddScore.Controls.Add(Me.LabelSurname)
        Me.GroupBoxAddScore.Font = New System.Drawing.Font("Script MT Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxAddScore.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBoxAddScore.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxAddScore.Name = "GroupBoxAddScore"
        Me.GroupBoxAddScore.Size = New System.Drawing.Size(243, 307)
        Me.GroupBoxAddScore.TabIndex = 3
        Me.GroupBoxAddScore.TabStop = False
        Me.GroupBoxAddScore.Text = "Add Score"
        '
        'DateTimePickerAddScore
        '
        Me.DateTimePickerAddScore.Location = New System.Drawing.Point(25, 159)
        Me.DateTimePickerAddScore.Name = "DateTimePickerAddScore"
        Me.DateTimePickerAddScore.Size = New System.Drawing.Size(191, 26)
        Me.DateTimePickerAddScore.TabIndex = 9
        '
        'TextBoxAddScore_Score
        '
        Me.TextBoxAddScore_Score.Location = New System.Drawing.Point(25, 216)
        Me.TextBoxAddScore_Score.Name = "TextBoxAddScore_Score"
        Me.TextBoxAddScore_Score.Size = New System.Drawing.Size(46, 26)
        Me.TextBoxAddScore_Score.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Score"
        '
        'ButtonAddScore
        '
        Me.ButtonAddScore.Enabled = False
        Me.ButtonAddScore.Location = New System.Drawing.Point(73, 258)
        Me.ButtonAddScore.Name = "ButtonAddScore"
        Me.ButtonAddScore.Size = New System.Drawing.Size(100, 29)
        Me.ButtonAddScore.TabIndex = 5
        Me.ButtonAddScore.Text = "Add score"
        Me.ButtonAddScore.UseVisualStyleBackColor = True
        '
        'TextBoxSurname
        '
        Me.TextBoxSurname.Enabled = False
        Me.TextBoxSurname.Location = New System.Drawing.Point(25, 95)
        Me.TextBoxSurname.Name = "TextBoxSurname"
        Me.TextBoxSurname.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxSurname.TabIndex = 4
        '
        'TextBoxName
        '
        Me.TextBoxName.Enabled = False
        Me.TextBoxName.Location = New System.Drawing.Point(25, 49)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxName.TabIndex = 3
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(27, 28)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(45, 18)
        Me.LabelName.TabIndex = 0
        Me.LabelName.Text = "Name"
        '
        'LabelSurname
        '
        Me.LabelSurname.AutoSize = True
        Me.LabelSurname.Location = New System.Drawing.Point(27, 78)
        Me.LabelSurname.Name = "LabelSurname"
        Me.LabelSurname.Size = New System.Drawing.Size(60, 18)
        Me.LabelSurname.TabIndex = 2
        Me.LabelSurname.Text = "Surname"
        '
        'Golf_AddScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 331)
        Me.Controls.Add(Me.PanelGolf_NewPlayer)
        Me.Name = "Golf_AddScore"
        Me.Text = "Add Score"
        Me.PanelGolf_NewPlayer.ResumeLayout(False)
        Me.GroupBoxAddScore.ResumeLayout(False)
        Me.GroupBoxAddScore.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelGolf_NewPlayer As System.Windows.Forms.Panel
    Friend WithEvents GroupBoxAddScore As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonAddScore As System.Windows.Forms.Button
    Friend WithEvents TextBoxSurname As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents LabelSurname As System.Windows.Forms.Label
    Friend WithEvents TextBoxAddScore_Score As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerAddScore As System.Windows.Forms.DateTimePicker
End Class
