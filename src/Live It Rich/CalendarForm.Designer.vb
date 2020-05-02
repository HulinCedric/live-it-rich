<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalendarForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Room = New System.Windows.Forms.TabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Restaurant = New System.Windows.Forms.TabPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Spa = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Golf = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Conference = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.ComboBox7 = New System.Windows.Forms.ComboBox
        Me.AxCalendar6 = New AxMSACAL.AxCalendar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.AxCalendar4 = New AxMSACAL.AxCalendar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.AxCalendar1 = New AxMSACAL.AxCalendar
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.AxCalendar2 = New AxMSACAL.AxCalendar
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ComboBox8 = New System.Windows.Forms.ComboBox
        Me.AxCalendar3 = New AxMSACAL.AxCalendar
        Me.TabControl1.SuspendLayout()
        Me.Room.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Restaurant.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Spa.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Golf.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Conference.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.AxCalendar6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AxCalendar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AxCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.AxCalendar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.AxCalendar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Room)
        Me.TabControl1.Controls.Add(Me.Restaurant)
        Me.TabControl1.Controls.Add(Me.Spa)
        Me.TabControl1.Controls.Add(Me.Golf)
        Me.TabControl1.Controls.Add(Me.Conference)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 566)
        Me.TabControl1.TabIndex = 0
        '
        'Room
        '
        Me.Room.BackColor = System.Drawing.Color.Gainsboro
        Me.Room.Controls.Add(Me.Panel5)
        Me.Room.Location = New System.Drawing.Point(4, 22)
        Me.Room.Name = "Room"
        Me.Room.Padding = New System.Windows.Forms.Padding(3)
        Me.Room.Size = New System.Drawing.Size(784, 540)
        Me.Room.TabIndex = 0
        Me.Room.Text = "Room"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.AxCalendar6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(778, 534)
        Me.Panel5.TabIndex = 1
        '
        'Restaurant
        '
        Me.Restaurant.BackColor = System.Drawing.Color.Gainsboro
        Me.Restaurant.Controls.Add(Me.Panel4)
        Me.Restaurant.Location = New System.Drawing.Point(4, 22)
        Me.Restaurant.Name = "Restaurant"
        Me.Restaurant.Padding = New System.Windows.Forms.Padding(3)
        Me.Restaurant.Size = New System.Drawing.Size(784, 540)
        Me.Restaurant.TabIndex = 1
        Me.Restaurant.Text = "Restaurant"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.AxCalendar4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(778, 534)
        Me.Panel4.TabIndex = 1
        '
        'Spa
        '
        Me.Spa.BackColor = System.Drawing.Color.Gainsboro
        Me.Spa.Controls.Add(Me.Panel3)
        Me.Spa.Location = New System.Drawing.Point(4, 22)
        Me.Spa.Name = "Spa"
        Me.Spa.Padding = New System.Windows.Forms.Padding(3)
        Me.Spa.Size = New System.Drawing.Size(784, 540)
        Me.Spa.TabIndex = 2
        Me.Spa.Text = "Spa"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.AxCalendar1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(778, 534)
        Me.Panel3.TabIndex = 1
        '
        'Golf
        '
        Me.Golf.BackColor = System.Drawing.Color.Gainsboro
        Me.Golf.Controls.Add(Me.Panel2)
        Me.Golf.Location = New System.Drawing.Point(4, 22)
        Me.Golf.Name = "Golf"
        Me.Golf.Padding = New System.Windows.Forms.Padding(3)
        Me.Golf.Size = New System.Drawing.Size(784, 540)
        Me.Golf.TabIndex = 3
        Me.Golf.Text = "Golf"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.AxCalendar2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 534)
        Me.Panel2.TabIndex = 1
        '
        'Conference
        '
        Me.Conference.BackColor = System.Drawing.Color.Gainsboro
        Me.Conference.Controls.Add(Me.Panel1)
        Me.Conference.Location = New System.Drawing.Point(4, 22)
        Me.Conference.Name = "Conference"
        Me.Conference.Padding = New System.Windows.Forms.Padding(3)
        Me.Conference.Size = New System.Drawing.Size(784, 540)
        Me.Conference.TabIndex = 4
        Me.Conference.Text = "Conference"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.AxCalendar3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 534)
        Me.Panel1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(3, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(211, 21)
        Me.ComboBox2.TabIndex = 0
        '
        'ComboBox4
        '
        Me.ComboBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(3, 16)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(211, 21)
        Me.ComboBox4.TabIndex = 0
        '
        'ComboBox7
        '
        Me.ComboBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(3, 16)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(211, 21)
        Me.ComboBox7.TabIndex = 0
        '
        'AxCalendar6
        '
        Me.AxCalendar6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxCalendar6.Enabled = True
        Me.AxCalendar6.Location = New System.Drawing.Point(0, 0)
        Me.AxCalendar6.Name = "AxCalendar6"
        Me.AxCalendar6.OcxState = CType(resources.GetObject("AxCalendar6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCalendar6.Size = New System.Drawing.Size(778, 534)
        Me.AxCalendar6.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 40)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guest"
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(3, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(211, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 40)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Guest"
        '
        'ComboBox3
        '
        Me.ComboBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(3, 16)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(211, 21)
        Me.ComboBox3.TabIndex = 0
        '
        'AxCalendar4
        '
        Me.AxCalendar4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxCalendar4.Enabled = True
        Me.AxCalendar4.Location = New System.Drawing.Point(0, 0)
        Me.AxCalendar4.Name = "AxCalendar4"
        Me.AxCalendar4.OcxState = CType(resources.GetObject("AxCalendar4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCalendar4.Size = New System.Drawing.Size(778, 534)
        Me.AxCalendar4.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox5)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(217, 40)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Guest"
        '
        'ComboBox5
        '
        Me.ComboBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(3, 16)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(211, 21)
        Me.ComboBox5.TabIndex = 0
        '
        'AxCalendar1
        '
        Me.AxCalendar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxCalendar1.Enabled = True
        Me.AxCalendar1.Location = New System.Drawing.Point(0, 0)
        Me.AxCalendar1.Name = "AxCalendar1"
        Me.AxCalendar1.OcxState = CType(resources.GetObject("AxCalendar1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCalendar1.Size = New System.Drawing.Size(778, 534)
        Me.AxCalendar1.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(217, 40)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Guest"
        '
        'ComboBox6
        '
        Me.ComboBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(3, 16)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(211, 21)
        Me.ComboBox6.TabIndex = 0
        '
        'AxCalendar2
        '
        Me.AxCalendar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxCalendar2.Enabled = True
        Me.AxCalendar2.Location = New System.Drawing.Point(0, 0)
        Me.AxCalendar2.Name = "AxCalendar2"
        Me.AxCalendar2.OcxState = CType(resources.GetObject("AxCalendar2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCalendar2.Size = New System.Drawing.Size(778, 534)
        Me.AxCalendar2.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ComboBox8)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(217, 40)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Guest"
        '
        'ComboBox8
        '
        Me.ComboBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(3, 16)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(211, 21)
        Me.ComboBox8.TabIndex = 0
        '
        'AxCalendar3
        '
        Me.AxCalendar3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxCalendar3.Enabled = True
        Me.AxCalendar3.Location = New System.Drawing.Point(0, 0)
        Me.AxCalendar3.Name = "AxCalendar3"
        Me.AxCalendar3.OcxState = CType(resources.GetObject("AxCalendar3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCalendar3.Size = New System.Drawing.Size(778, 534)
        Me.AxCalendar3.TabIndex = 5
        '
        'CalendarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CalendarForm"
        Me.Text = "Calendar"
        Me.TabControl1.ResumeLayout(False)
        Me.Room.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Restaurant.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Spa.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Golf.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Conference.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.AxCalendar6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.AxCalendar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.AxCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.AxCalendar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.AxCalendar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Room As System.Windows.Forms.TabPage
    Friend WithEvents Restaurant As System.Windows.Forms.TabPage
    Friend WithEvents Spa As System.Windows.Forms.TabPage
    Friend WithEvents Golf As System.Windows.Forms.TabPage
    Friend WithEvents Conference As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents AxCalendar6 As AxMSACAL.AxCalendar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents AxCalendar4 As AxMSACAL.AxCalendar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents AxCalendar1 As AxMSACAL.AxCalendar
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents AxCalendar2 As AxMSACAL.AxCalendar
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents AxCalendar3 As AxMSACAL.AxCalendar
End Class
