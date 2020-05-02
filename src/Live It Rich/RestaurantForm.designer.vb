<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestaurantForm
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
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.GrillCardPage = New System.Windows.Forms.TabPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button23 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.HauteCuisineCardPage = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.WineCard = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DishPage = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.DataGridView4 = New System.Windows.Forms.DataGridView
        Me.OrderPage = New System.Windows.Forms.TabPage
        Me.ReservationSpaPanel = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TimeShow = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button22 = New System.Windows.Forms.Button
        Me.DataGridView5 = New System.Windows.Forms.DataGridView
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.TabControl1.SuspendLayout()
        Me.GrillCardPage.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.HauteCuisineCardPage.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WineCard.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DishPage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrderPage.SuspendLayout()
        Me.ReservationSpaPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.GrillCardPage)
        Me.TabControl1.Controls.Add(Me.HauteCuisineCardPage)
        Me.TabControl1.Controls.Add(Me.WineCard)
        Me.TabControl1.Controls.Add(Me.DishPage)
        Me.TabControl1.Controls.Add(Me.OrderPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(807, 532)
        Me.TabControl1.TabIndex = 0
        '
        'GrillCardPage
        '
        Me.GrillCardPage.BackColor = System.Drawing.Color.Gainsboro
        Me.GrillCardPage.Controls.Add(Me.Panel4)
        Me.GrillCardPage.Location = New System.Drawing.Point(4, 22)
        Me.GrillCardPage.Name = "GrillCardPage"
        Me.GrillCardPage.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.GrillCardPage.Size = New System.Drawing.Size(799, 506)
        Me.GrillCardPage.TabIndex = 0
        Me.GrillCardPage.Text = "Grill Card"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.GroupBox7)
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Controls.Add(Me.GroupBox6)
        Me.Panel4.Controls.Add(Me.GroupBox5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Script MT Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(793, 500)
        Me.Panel4.TabIndex = 1
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ComboBox1)
        Me.GroupBox7.Location = New System.Drawing.Point(67, 425)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 52)
        Me.GroupBox7.TabIndex = 19
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Type Grill Menu"
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(3, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(194, 26)
        Me.ComboBox1.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(67, 159)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 54)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Type Card"
        '
        'ComboBox6
        '
        Me.ComboBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(3, 22)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(194, 26)
        Me.ComboBox6.TabIndex = 4
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button6)
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Button5)
        Me.GroupBox6.Location = New System.Drawing.Point(67, 227)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 179)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Grill Menu Action"
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button6.Location = New System.Drawing.Point(3, 124)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(194, 51)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Remove Grill Menu"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(3, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 51)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Modification Grill Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(3, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(194, 51)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Add Grill Menu"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button23)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Location = New System.Drawing.Point(64, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(206, 130)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Grill Card Action"
        '
        'Button23
        '
        Me.Button23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button23.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button23.Location = New System.Drawing.Point(3, 73)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(200, 51)
        Me.Button23.TabIndex = 2
        Me.Button23.Text = "Remove Dish on Card"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(3, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Dish on Card"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HauteCuisineCardPage
        '
        Me.HauteCuisineCardPage.BackColor = System.Drawing.Color.Gainsboro
        Me.HauteCuisineCardPage.Controls.Add(Me.Panel3)
        Me.HauteCuisineCardPage.Location = New System.Drawing.Point(4, 22)
        Me.HauteCuisineCardPage.Name = "HauteCuisineCardPage"
        Me.HauteCuisineCardPage.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.HauteCuisineCardPage.Size = New System.Drawing.Size(799, 506)
        Me.HauteCuisineCardPage.TabIndex = 1
        Me.HauteCuisineCardPage.Text = "Haute Cuisine Card"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox10)
        Me.Panel3.Controls.Add(Me.DataGridView3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(793, 500)
        Me.Panel3.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(67, 425)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 42)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type Haute Cuisine Menu"
        '
        'ComboBox2
        '
        Me.ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(3, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Button7)
        Me.GroupBox10.Controls.Add(Me.Button8)
        Me.GroupBox10.Controls.Add(Me.Button9)
        Me.GroupBox10.Location = New System.Drawing.Point(67, 227)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(200, 172)
        Me.GroupBox10.TabIndex = 17
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Haute Cuisine Menu Action"
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.Location = New System.Drawing.Point(3, 118)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(194, 51)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Remove Haute Cuisine Menu"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.Location = New System.Drawing.Point(3, 67)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(194, 51)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Modification Haute Cuisine Menu"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.Location = New System.Drawing.Point(3, 16)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(194, 51)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "Add Haute Cuisine Menu"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView3.Location = New System.Drawing.Point(386, 0)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView3.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(407, 500)
        Me.DataGridView3.TabIndex = 5
        '
        'WineCard
        '
        Me.WineCard.BackColor = System.Drawing.Color.Gainsboro
        Me.WineCard.Controls.Add(Me.Panel2)
        Me.WineCard.Location = New System.Drawing.Point(4, 24)
        Me.WineCard.Name = "WineCard"
        Me.WineCard.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.WineCard.Size = New System.Drawing.Size(799, 504)
        Me.WineCard.TabIndex = 2
        Me.WineCard.Text = "Wine Card"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.GroupBox8)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 498)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button3)
        Me.GroupBox8.Controls.Add(Me.Button4)
        Me.GroupBox8.Location = New System.Drawing.Point(64, 13)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(206, 122)
        Me.GroupBox8.TabIndex = 17
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Wine Action"
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.Location = New System.Drawing.Point(3, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 51)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Remove Wine on Card"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.Location = New System.Drawing.Point(3, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 51)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Add Wine on Card"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.Location = New System.Drawing.Point(399, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(394, 498)
        Me.DataGridView1.TabIndex = 5
        '
        'DishPage
        '
        Me.DishPage.BackColor = System.Drawing.Color.Gainsboro
        Me.DishPage.Controls.Add(Me.Panel1)
        Me.DishPage.Location = New System.Drawing.Point(4, 22)
        Me.DishPage.Name = "DishPage"
        Me.DishPage.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.DishPage.Size = New System.Drawing.Size(799, 506)
        Me.DishPage.TabIndex = 3
        Me.DishPage.Text = "Dish"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.GroupBox12)
        Me.Panel1.Controls.Add(Me.DataGridView4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(793, 500)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Button16)
        Me.GroupBox12.Controls.Add(Me.Button12)
        Me.GroupBox12.Controls.Add(Me.Button13)
        Me.GroupBox12.Location = New System.Drawing.Point(64, 13)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(206, 173)
        Me.GroupBox12.TabIndex = 17
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Dish Action"
        '
        'Button16
        '
        Me.Button16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button16.Location = New System.Drawing.Point(3, 118)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(200, 51)
        Me.Button16.TabIndex = 3
        Me.Button16.Text = "Delete Dish"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button12.Location = New System.Drawing.Point(3, 67)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(200, 51)
        Me.Button12.TabIndex = 2
        Me.Button12.Text = "Modification Dish"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button13.Location = New System.Drawing.Point(3, 16)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(200, 51)
        Me.Button13.TabIndex = 1
        Me.Button13.Text = "New Dish"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView4.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView4.Location = New System.Drawing.Point(399, 0)
        Me.DataGridView4.MultiSelect = False
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView4.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(394, 500)
        Me.DataGridView4.TabIndex = 5
        '
        'OrderPage
        '
        Me.OrderPage.BackColor = System.Drawing.Color.Gainsboro
        Me.OrderPage.Controls.Add(Me.ReservationSpaPanel)
        Me.OrderPage.Location = New System.Drawing.Point(4, 24)
        Me.OrderPage.Name = "OrderPage"
        Me.OrderPage.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.OrderPage.Size = New System.Drawing.Size(799, 504)
        Me.OrderPage.TabIndex = 4
        Me.OrderPage.Text = "Order"
        '
        'ReservationSpaPanel
        '
        Me.ReservationSpaPanel.AutoScroll = True
        Me.ReservationSpaPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.ReservationSpaPanel.Controls.Add(Me.GroupBox1)
        Me.ReservationSpaPanel.Controls.Add(Me.GroupBox3)
        Me.ReservationSpaPanel.Controls.Add(Me.DataGridView5)
        Me.ReservationSpaPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReservationSpaPanel.Location = New System.Drawing.Point(3, 3)
        Me.ReservationSpaPanel.Name = "ReservationSpaPanel"
        Me.ReservationSpaPanel.Size = New System.Drawing.Size(793, 498)
        Me.ReservationSpaPanel.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TimeShow)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 53)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time"
        '
        'TimeShow
        '
        Me.TimeShow.AutoSize = True
        Me.TimeShow.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeShow.Location = New System.Drawing.Point(36, 14)
        Me.TimeShow.Name = "TimeShow"
        Me.TimeShow.Size = New System.Drawing.Size(150, 36)
        Me.TimeShow.TabIndex = 18
        Me.TimeShow.Text = "Time Show"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button22)
        Me.GroupBox3.Location = New System.Drawing.Point(64, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 70)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Action"
        '
        'Button22
        '
        Me.Button22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button22.Location = New System.Drawing.Point(3, 16)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(200, 51)
        Me.Button22.TabIndex = 1
        Me.Button22.Text = "Served"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView5.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView5.Location = New System.Drawing.Point(375, 0)
        Me.DataGridView5.MultiSelect = False
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView5.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView5.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView5.Size = New System.Drawing.Size(418, 498)
        Me.DataGridView5.TabIndex = 5
        '
        'Button14
        '
        Me.Button14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button14.Location = New System.Drawing.Point(3, 67)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(200, 51)
        Me.Button14.TabIndex = 2
        Me.Button14.Text = "Remove Dish on Card"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button15.Location = New System.Drawing.Point(3, 16)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(200, 51)
        Me.Button15.TabIndex = 1
        Me.Button15.Text = "Add Dish on Card"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.Controls.Add(Me.DataGridView2)
        Me.Panel5.Location = New System.Drawing.Point(357, 35)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(397, 371)
        Me.Panel5.TabIndex = 20
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(397, 371)
        Me.DataGridView2.TabIndex = 0
        '
        'RestaurantForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 532)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "RestaurantForm"
        Me.Text = "Restaurant"
        Me.TabControl1.ResumeLayout(False)
        Me.GrillCardPage.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.HauteCuisineCardPage.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WineCard.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DishPage.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrderPage.ResumeLayout(False)
        Me.ReservationSpaPanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GrillCardPage As System.Windows.Forms.TabPage
    Friend WithEvents HauteCuisineCardPage As System.Windows.Forms.TabPage
    Friend WithEvents WineCard As System.Windows.Forms.TabPage
    Friend WithEvents DishPage As System.Windows.Forms.TabPage
    Friend WithEvents OrderPage As System.Windows.Forms.TabPage
    Friend WithEvents ReservationSpaPanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TimeShow As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
