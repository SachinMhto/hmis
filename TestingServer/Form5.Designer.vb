<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        Panel2 = New Panel()
        Panel4 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox8 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Panel3 = New Panel()
        Label5 = New Label()
        Label9 = New Label()
        Panel5 = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label10 = New Label()
        Label11 = New Label()
        ComboBox1 = New ComboBox()
        TextBox9 = New TextBox()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        Button5 = New Button()
        ComPeriodId = New ComboBox()
        Button4 = New Button()
        ComDataSetId = New ComboBox()
        Button3 = New Button()
        TxtOrgUnitId = New TextBox()
        Label69 = New Label()
        Label70 = New Label()
        Label71 = New Label()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel5.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Location = New Point(225, 227)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(330, 260)
        Panel1.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 1, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 1)
        TableLayoutPanel1.Controls.Add(Label4, 0, 2)
        TableLayoutPanel1.Controls.Add(TextBox6, 1, 1)
        TableLayoutPanel1.Controls.Add(TextBox7, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(330, 260)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.PeachPuff
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(5, 1)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 85)
        Label1.TabIndex = 0
        Label1.Text = "Referrals"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.PeachPuff
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(169, 1)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 85)
        Label2.TabIndex = 1
        Label2.Text = "Referral In"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(5, 87)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 85)
        Label3.TabIndex = 2
        Label3.Text = "Female"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(5, 173)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 86)
        Label4.TabIndex = 3
        Label4.Text = "Male"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.None
        TextBox6.Location = New Point(210, 114)
        TextBox6.Margin = New Padding(4, 5, 4, 5)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(73, 31)
        TextBox6.TabIndex = 4
        ' 
        ' TextBox7
        ' 
        TextBox7.Anchor = AnchorStyles.None
        TextBox7.Location = New Point(210, 200)
        TextBox7.Margin = New Padding(4, 5, 4, 5)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(73, 31)
        TextBox7.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(556, 227)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(416, 259)
        Panel2.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(TableLayoutPanel2)
        Panel4.Location = New Point(0, 48)
        Panel4.Margin = New Padding(4, 5, 4, 5)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(413, 205)
        Panel4.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel2.Controls.Add(Label6, 0, 0)
        TableLayoutPanel2.Controls.Add(Label7, 1, 0)
        TableLayoutPanel2.Controls.Add(Label8, 2, 0)
        TableLayoutPanel2.Controls.Add(TextBox8, 0, 2)
        TableLayoutPanel2.Controls.Add(TextBox3, 2, 1)
        TableLayoutPanel2.Controls.Add(TextBox4, 1, 1)
        TableLayoutPanel2.Controls.Add(TextBox5, 0, 1)
        TableLayoutPanel2.Controls.Add(TextBox2, 1, 2)
        TableLayoutPanel2.Controls.Add(TextBox1, 2, 2)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 27.4509811F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 39.705883F))
        TableLayoutPanel2.Size = New Size(413, 205)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.PeachPuff
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(5, 1)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 66)
        Label6.TabIndex = 0
        Label6.Text = "Outpatient"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.PeachPuff
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(142, 1)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 66)
        Label7.TabIndex = 1
        Label7.Text = "In-patient"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.PeachPuff
        Label8.Dock = DockStyle.Fill
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(279, 1)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 66)
        Label8.TabIndex = 2
        Label8.Text = "Emergency"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox8
        ' 
        TextBox8.Anchor = AnchorStyles.None
        TextBox8.Location = New Point(32, 148)
        TextBox8.Margin = New Padding(4, 5, 4, 5)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(73, 31)
        TextBox8.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.None
        TextBox3.Location = New Point(307, 79)
        TextBox3.Margin = New Padding(4, 5, 4, 5)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(73, 31)
        TextBox3.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.None
        TextBox4.Location = New Point(169, 79)
        TextBox4.Margin = New Padding(4, 5, 4, 5)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(73, 31)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.None
        TextBox5.Location = New Point(32, 79)
        TextBox5.Margin = New Padding(4, 5, 4, 5)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(73, 31)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.Location = New Point(169, 148)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(73, 31)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Location = New Point(307, 148)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(73, 31)
        TextBox1.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(-1, 2)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(413, 40)
        Panel3.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.PeachPuff
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(0, 0)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(411, 38)
        Label5.TabIndex = 0
        Label5.Text = "Referred Out"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Silver
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(980, 227)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(283, 170)
        Label9.TabIndex = 2
        Label9.Text = "Minimum Service Standard (MSS)"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(TableLayoutPanel3)
        Panel5.Location = New Point(1262, 227)
        Panel5.Margin = New Padding(4, 5, 4, 5)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(285, 170)
        Panel5.TabIndex = 3
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel3.Controls.Add(Label10, 0, 0)
        TableLayoutPanel3.Controls.Add(Label11, 1, 0)
        TableLayoutPanel3.Controls.Add(ComboBox1, 0, 1)
        TableLayoutPanel3.Controls.Add(TextBox9, 1, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(283, 168)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.Silver
        Label10.Dock = DockStyle.Fill
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label10.Location = New Point(5, 1)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(188, 82)
        Label10.TabIndex = 0
        Label10.Text = "Implementation    1-First               2-Second"
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.Silver
        Label11.Dock = DockStyle.Fill
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label11.Location = New Point(202, 1)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(76, 82)
        Label11.TabIndex = 1
        Label11.Text = "Score"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Left
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(15, 109)
        ComboBox1.Margin = New Padding(14, 5, 4, 5)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(135, 33)
        ComboBox1.TabIndex = 2
        ' 
        ' TextBox9
        ' 
        TextBox9.Anchor = AnchorStyles.None
        TextBox9.Location = New Point(203, 110)
        TextBox9.Margin = New Padding(4, 5, 4, 5)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(73, 31)
        TextBox9.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightGreen
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(ComPeriodId)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(ComDataSetId)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(TxtOrgUnitId)
        GroupBox1.Controls.Add(Label69)
        GroupBox1.Controls.Add(Label70)
        GroupBox1.Controls.Add(Label71)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(1630, 217)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(680, 148)
        Button2.Margin = New Padding(4, 5, 4, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 38)
        Button2.TabIndex = 9
        Button2.Text = "Next Year"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(530, 148)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 38)
        Button1.TabIndex = 8
        Button1.Text = "Prev Year"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.SeaShell
        Button5.Location = New Point(1086, 142)
        Button5.Margin = New Padding(4, 5, 4, 5)
        Button5.Name = "Button5"
        Button5.Size = New Size(149, 38)
        Button5.TabIndex = 4
        Button5.Text = "Print Bank Form"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' ComPeriodId
        ' 
        ComPeriodId.FormattingEnabled = True
        ComPeriodId.Items.AddRange(New Object() {"[ Select Period ]", "Jestha 2081", "Baisakh 2081"})
        ComPeriodId.Location = New Point(223, 143)
        ComPeriodId.Margin = New Padding(4, 5, 4, 5)
        ComPeriodId.Name = "ComPeriodId"
        ComPeriodId.Size = New Size(263, 33)
        ComPeriodId.TabIndex = 7
        ComPeriodId.Text = "[ Select Period ]"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.SeaShell
        Button4.Location = New Point(1086, 93)
        Button4.Margin = New Padding(4, 5, 4, 5)
        Button4.Name = "Button4"
        Button4.Size = New Size(149, 38)
        Button4.TabIndex = 3
        Button4.Text = "Print Form"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' ComDataSetId
        ' 
        ComDataSetId.FormattingEnabled = True
        ComDataSetId.Items.AddRange(New Object() {"[ Select Data Set ]", "01-2 Hospital Summary Dataset(NEW)"})
        ComDataSetId.Location = New Point(223, 95)
        ComDataSetId.Margin = New Padding(4, 5, 4, 5)
        ComDataSetId.Name = "ComDataSetId"
        ComDataSetId.Size = New Size(597, 33)
        ComDataSetId.TabIndex = 5
        ComDataSetId.Text = "[ Select Data Set ]"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.SeaShell
        Button3.Location = New Point(1086, 47)
        Button3.Margin = New Padding(4, 5, 4, 5)
        Button3.Name = "Button3"
        Button3.Size = New Size(149, 38)
        Button3.TabIndex = 2
        Button3.Text = "Run Validation"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TxtOrgUnitId
        ' 
        TxtOrgUnitId.Location = New Point(223, 47)
        TxtOrgUnitId.Margin = New Padding(4, 5, 4, 5)
        TxtOrgUnitId.Name = "TxtOrgUnitId"
        TxtOrgUnitId.Size = New Size(597, 31)
        TxtOrgUnitId.TabIndex = 3
        ' 
        ' Label69
        ' 
        Label69.AutoSize = True
        Label69.Location = New Point(21, 152)
        Label69.Margin = New Padding(4, 0, 4, 0)
        Label69.Name = "Label69"
        Label69.Size = New Size(62, 25)
        Label69.TabIndex = 2
        Label69.Text = "Period"
        ' 
        ' Label70
        ' 
        Label70.AutoSize = True
        Label70.Location = New Point(21, 104)
        Label70.Margin = New Padding(4, 0, 4, 0)
        Label70.Name = "Label70"
        Label70.Size = New Size(79, 25)
        Label70.TabIndex = 1
        Label70.Text = "Data Set"
        ' 
        ' Label71
        ' 
        Label71.AutoSize = True
        Label71.Location = New Point(21, 51)
        Label71.Margin = New Padding(4, 0, 4, 0)
        Label71.Name = "Label71"
        Label71.Size = New Size(151, 25)
        Label71.TabIndex = 0
        Label71.Text = "Organization Unit"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1630, 750)
        Controls.Add(GroupBox1)
        Controls.Add(Panel5)
        Controls.Add(Label9)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form5"
        Text = "Form5"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ComPeriodId As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ComDataSetId As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TxtOrgUnitId As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
End Class
