<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Golf_NewPlayer
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
        Me.GroupBoxNewPlayer = New System.Windows.Forms.GroupBox
        Me.ButtonNewPlayer_CreatePlayer = New System.Windows.Forms.Button
        Me.TextBoxNewPlayer_Surname = New System.Windows.Forms.TextBox
        Me.TextBoxNewPlayer_Name = New System.Windows.Forms.TextBox
        Me.LabelName = New System.Windows.Forms.Label
        Me.LabelSurname = New System.Windows.Forms.Label
        Me.PanelGolf_NewPlayer.SuspendLayout()
        Me.GroupBoxNewPlayer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelGolf_NewPlayer
        '
        Me.PanelGolf_NewPlayer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelGolf_NewPlayer.Controls.Add(Me.GroupBoxNewPlayer)
        Me.PanelGolf_NewPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGolf_NewPlayer.Location = New System.Drawing.Point(0, 0)
        Me.PanelGolf_NewPlayer.Name = "PanelGolf_NewPlayer"
        Me.PanelGolf_NewPlayer.Size = New System.Drawing.Size(190, 242)
        Me.PanelGolf_NewPlayer.TabIndex = 0
        '
        'GroupBoxNewPlayer
        '
        Me.GroupBoxNewPlayer.Controls.Add(Me.ButtonNewPlayer_CreatePlayer)
        Me.GroupBoxNewPlayer.Controls.Add(Me.TextBoxNewPlayer_Surname)
        Me.GroupBoxNewPlayer.Controls.Add(Me.TextBoxNewPlayer_Name)
        Me.GroupBoxNewPlayer.Controls.Add(Me.LabelName)
        Me.GroupBoxNewPlayer.Controls.Add(Me.LabelSurname)
        Me.GroupBoxNewPlayer.Font = New System.Drawing.Font("Script MT Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxNewPlayer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBoxNewPlayer.Location = New System.Drawing.Point(24, 22)
        Me.GroupBoxNewPlayer.Name = "GroupBoxNewPlayer"
        Me.GroupBoxNewPlayer.Size = New System.Drawing.Size(140, 208)
        Me.GroupBoxNewPlayer.TabIndex = 3
        Me.GroupBoxNewPlayer.TabStop = False
        Me.GroupBoxNewPlayer.Text = "New Player"
        '
        'ButtonNewPlayer_CreatePlayer
        '
        Me.ButtonNewPlayer_CreatePlayer.Enabled = False
        Me.ButtonNewPlayer_CreatePlayer.Location = New System.Drawing.Point(16, 147)
        Me.ButtonNewPlayer_CreatePlayer.Name = "ButtonNewPlayer_CreatePlayer"
        Me.ButtonNewPlayer_CreatePlayer.Size = New System.Drawing.Size(100, 29)
        Me.ButtonNewPlayer_CreatePlayer.TabIndex = 5
        Me.ButtonNewPlayer_CreatePlayer.Text = "Create Player"
        Me.ButtonNewPlayer_CreatePlayer.UseVisualStyleBackColor = True
        '
        'TextBoxNewPlayer_Surname
        '
        Me.TextBoxNewPlayer_Surname.Location = New System.Drawing.Point(16, 99)
        Me.TextBoxNewPlayer_Surname.Name = "TextBoxNewPlayer_Surname"
        Me.TextBoxNewPlayer_Surname.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxNewPlayer_Surname.TabIndex = 4
        '
        'TextBoxNewPlayer_Name
        '
        Me.TextBoxNewPlayer_Name.Location = New System.Drawing.Point(16, 49)
        Me.TextBoxNewPlayer_Name.Name = "TextBoxNewPlayer_Name"
        Me.TextBoxNewPlayer_Name.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxNewPlayer_Name.TabIndex = 3
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(22, 28)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(45, 18)
        Me.LabelName.TabIndex = 0
        Me.LabelName.Text = "Name"
        '
        'LabelSurname
        '
        Me.LabelSurname.AutoSize = True
        Me.LabelSurname.Location = New System.Drawing.Point(22, 78)
        Me.LabelSurname.Name = "LabelSurname"
        Me.LabelSurname.Size = New System.Drawing.Size(60, 18)
        Me.LabelSurname.TabIndex = 2
        Me.LabelSurname.Text = "Surname"
        '
        'Golf_NewPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(190, 242)
        Me.Controls.Add(Me.PanelGolf_NewPlayer)
        Me.Name = "Golf_NewPlayer"
        Me.Text = "New Player"
        Me.PanelGolf_NewPlayer.ResumeLayout(False)
        Me.GroupBoxNewPlayer.ResumeLayout(False)
        Me.GroupBoxNewPlayer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelGolf_NewPlayer As System.Windows.Forms.Panel
    Friend WithEvents GroupBoxNewPlayer As System.Windows.Forms.GroupBox
    Friend WithEvents LabelSurname As System.Windows.Forms.Label
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents TextBoxNewPlayer_Surname As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNewPlayer_Name As System.Windows.Forms.TextBox
    Friend WithEvents ButtonNewPlayer_CreatePlayer As System.Windows.Forms.Button
End Class
