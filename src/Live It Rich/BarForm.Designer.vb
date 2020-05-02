<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarForm
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
        Me.PanelBackground = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.PanelListOfBooking = New System.Windows.Forms.Panel
        Me.Button3 = New System.Windows.Forms.Button
        Me.PanelListOfSelection = New System.Windows.Forms.Panel
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonAdd = New System.Windows.Forms.Button
        Me.PanelMenuAction = New System.Windows.Forms.Panel
        Me.GroupBoxSearchFilter = New System.Windows.Forms.GroupBox
        Me.TextBoxPlayer_Surname = New System.Windows.Forms.TextBox
        Me.TextBoxPlayer_Name = New System.Windows.Forms.TextBox
        Me.LabelSurname = New System.Windows.Forms.Label
        Me.LabelName = New System.Windows.Forms.Label
        Me.ButtonBar_Select = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PanelBackground.SuspendLayout()
        Me.PanelListOfBooking.SuspendLayout()
        Me.PanelListOfSelection.SuspendLayout()
        Me.GroupBoxSearchFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBackground
        '
        Me.PanelBackground.AutoScroll = True
        Me.PanelBackground.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelBackground.Controls.Add(Me.Label2)
        Me.PanelBackground.Controls.Add(Me.Label1)
        Me.PanelBackground.Controls.Add(Me.GroupBoxSearchFilter)
        Me.PanelBackground.Controls.Add(Me.Label15)
        Me.PanelBackground.Controls.Add(Me.PanelListOfBooking)
        Me.PanelBackground.Controls.Add(Me.PanelListOfSelection)
        Me.PanelBackground.Controls.Add(Me.ButtonDelete)
        Me.PanelBackground.Controls.Add(Me.ButtonAdd)
        Me.PanelBackground.Controls.Add(Me.PanelMenuAction)
        Me.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBackground.Location = New System.Drawing.Point(0, 0)
        Me.PanelBackground.Name = "PanelBackground"
        Me.PanelBackground.Size = New System.Drawing.Size(807, 532)
        Me.PanelBackground.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Script MT Bold", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(54, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(165, 37)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "List of guest"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelListOfBooking
        '
        Me.PanelListOfBooking.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelListOfBooking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelListOfBooking.Controls.Add(Me.ButtonBar_Select)
        Me.PanelListOfBooking.Location = New System.Drawing.Point(21, 168)
        Me.PanelListOfBooking.Name = "PanelListOfBooking"
        Me.PanelListOfBooking.Size = New System.Drawing.Size(227, 315)
        Me.PanelListOfBooking.TabIndex = 27
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(31, 346)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 27)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Add to bill"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PanelListOfSelection
        '
        Me.PanelListOfSelection.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelListOfSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelListOfSelection.Controls.Add(Me.Button3)
        Me.PanelListOfSelection.Location = New System.Drawing.Point(604, 91)
        Me.PanelListOfSelection.Name = "PanelListOfSelection"
        Me.PanelListOfSelection.Size = New System.Drawing.Size(177, 392)
        Me.PanelListOfSelection.TabIndex = 25
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonDelete.Location = New System.Drawing.Point(552, 271)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(34, 23)
        Me.ButtonDelete.TabIndex = 24
        Me.ButtonDelete.Text = "<<"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonAdd.Location = New System.Drawing.Point(552, 242)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(34, 23)
        Me.ButtonAdd.TabIndex = 23
        Me.ButtonAdd.Text = ">>"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'PanelMenuAction
        '
        Me.PanelMenuAction.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelMenuAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMenuAction.Location = New System.Drawing.Point(287, 91)
        Me.PanelMenuAction.Name = "PanelMenuAction"
        Me.PanelMenuAction.Size = New System.Drawing.Size(253, 392)
        Me.PanelMenuAction.TabIndex = 22
        '
        'GroupBoxSearchFilter
        '
        Me.GroupBoxSearchFilter.Controls.Add(Me.TextBoxPlayer_Surname)
        Me.GroupBoxSearchFilter.Controls.Add(Me.TextBoxPlayer_Name)
        Me.GroupBoxSearchFilter.Controls.Add(Me.LabelSurname)
        Me.GroupBoxSearchFilter.Controls.Add(Me.LabelName)
        Me.GroupBoxSearchFilter.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSearchFilter.Location = New System.Drawing.Point(30, 91)
        Me.GroupBoxSearchFilter.Name = "GroupBoxSearchFilter"
        Me.GroupBoxSearchFilter.Size = New System.Drawing.Size(208, 71)
        Me.GroupBoxSearchFilter.TabIndex = 33
        Me.GroupBoxSearchFilter.TabStop = False
        Me.GroupBoxSearchFilter.Text = "Search filter"
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
        'ButtonBar_Select
        '
        Me.ButtonBar_Select.Enabled = False
        Me.ButtonBar_Select.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonBar_Select.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonBar_Select.Location = New System.Drawing.Point(48, 269)
        Me.ButtonBar_Select.Name = "ButtonBar_Select"
        Me.ButtonBar_Select.Size = New System.Drawing.Size(115, 27)
        Me.ButtonBar_Select.TabIndex = 35
        Me.ButtonBar_Select.Text = "Select"
        Me.ButtonBar_Select.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(312, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 37)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "List of beverage"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(611, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 37)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Bill's guest"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 532)
        Me.Controls.Add(Me.PanelBackground)
        Me.Name = "BarForm"
        Me.Text = "Bar"
        Me.PanelBackground.ResumeLayout(False)
        Me.PanelBackground.PerformLayout()
        Me.PanelListOfBooking.ResumeLayout(False)
        Me.PanelListOfSelection.ResumeLayout(False)
        Me.GroupBoxSearchFilter.ResumeLayout(False)
        Me.GroupBoxSearchFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBackground As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PanelListOfBooking As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PanelListOfSelection As System.Windows.Forms.Panel
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents PanelMenuAction As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxSearchFilter As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPlayer_Surname As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPlayer_Name As System.Windows.Forms.TextBox
    Friend WithEvents LabelSurname As System.Windows.Forms.Label
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents ButtonBar_Select As System.Windows.Forms.Button
End Class
