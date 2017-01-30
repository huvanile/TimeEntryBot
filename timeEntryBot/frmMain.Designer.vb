<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnScheduled = New System.Windows.Forms.Button()
        Me.btnNow = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.btnDeleteClient = New System.Windows.Forms.Button()
        Me.btn_SaveClient = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbSavedCodeList = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAssgn = New System.Windows.Forms.TextBox()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUserMessages = New System.Windows.Forms.Label()
        Me.dgvWeek = New System.Windows.Forms.DataGridView()
        Me.EngagementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignmentCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursPerDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDay1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDay2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDay3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDay4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDay5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDay6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDay7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout
        CType(Me.dgvWeek,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EngagementBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 509)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(260, 46)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Note:  This bot must be open in order for it to fill in your time on Sunday night"& _ 
    ".  Use it on an always-on computer (not your laptop)."
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Never be Delinquent Again"
        '
        'btnScheduled
        '
        Me.btnScheduled.Location = New System.Drawing.Point(12, 469)
        Me.btnScheduled.Name = "btnScheduled"
        Me.btnScheduled.Size = New System.Drawing.Size(260, 34)
        Me.btnScheduled.TabIndex = 7
        Me.btnScheduled.Text = "Populate time site on Sundays @ 6pm"
        Me.btnScheduled.UseVisualStyleBackColor = true
        '
        'btnNow
        '
        Me.btnNow.Location = New System.Drawing.Point(12, 429)
        Me.btnNow.Name = "btnNow"
        Me.btnNow.Size = New System.Drawing.Size(260, 34)
        Me.btnNow.TabIndex = 6
        Me.btnNow.Text = "Populate time site right now"
        Me.btnNow.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.btnDeleteClient)
        Me.GroupBox1.Controls.Add(Me.btn_SaveClient)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbSavedCodeList)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtURL)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtHours)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAssgn)
        Me.GroupBox1.Controls.Add(Me.txtClient)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 330)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Settings"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Location Code"
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtLocation.Location = New System.Drawing.Point(183, 266)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(60, 21)
        Me.txtLocation.TabIndex = 19
        '
        'btnDeleteClient
        '
        Me.btnDeleteClient.Location = New System.Drawing.Point(141, 294)
        Me.btnDeleteClient.Name = "btnDeleteClient"
        Me.btnDeleteClient.Size = New System.Drawing.Size(102, 23)
        Me.btnDeleteClient.TabIndex = 17
        Me.btnDeleteClient.Text = "Delete Client"
        Me.btnDeleteClient.UseVisualStyleBackColor = true
        '
        'btn_SaveClient
        '
        Me.btn_SaveClient.Location = New System.Drawing.Point(20, 294)
        Me.btn_SaveClient.Name = "btn_SaveClient"
        Me.btn_SaveClient.Size = New System.Drawing.Size(102, 23)
        Me.btn_SaveClient.TabIndex = 16
        Me.btn_SaveClient.Text = "Save Client"
        Me.btn_SaveClient.UseVisualStyleBackColor = true
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Code Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtName.Location = New System.Drawing.Point(120, 157)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 21)
        Me.txtName.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Saved Client Codes"
        '
        'cmbSavedCodeList
        '
        Me.cmbSavedCodeList.FormattingEnabled = true
        Me.cmbSavedCodeList.Location = New System.Drawing.Point(20, 128)
        Me.cmbSavedCodeList.Name = "cmbSavedCodeList"
        Me.cmbSavedCodeList.Size = New System.Drawing.Size(221, 23)
        Me.cmbSavedCodeList.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Time Site URL"
        '
        'txtURL
        '
        Me.txtURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtURL.Location = New System.Drawing.Point(120, 25)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(121, 21)
        Me.txtURL.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Number of Hours per Day"
        '
        'txtHours
        '
        Me.txtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtHours.Location = New System.Drawing.Point(181, 237)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(60, 21)
        Me.txtHours.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Assgn Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Client Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'txtAssgn
        '
        Me.txtAssgn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtAssgn.Location = New System.Drawing.Point(120, 210)
        Me.txtAssgn.Name = "txtAssgn"
        Me.txtAssgn.Size = New System.Drawing.Size(121, 21)
        Me.txtAssgn.TabIndex = 3
        '
        'txtClient
        '
        Me.txtClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtClient.Location = New System.Drawing.Point(120, 184)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(121, 21)
        Me.txtClient.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtPass.Location = New System.Drawing.Point(120, 78)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(121, 21)
        Me.txtPass.TabIndex = 1
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtUser.Location = New System.Drawing.Point(120, 52)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(121, 21)
        Me.txtUser.TabIndex = 0
        '
        'lblUserMessages
        '
        Me.lblUserMessages.AutoSize = true
        Me.lblUserMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblUserMessages.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblUserMessages.Location = New System.Drawing.Point(30, 381)
        Me.lblUserMessages.Name = "lblUserMessages"
        Me.lblUserMessages.Size = New System.Drawing.Size(103, 15)
        Me.lblUserMessages.TabIndex = 19
        Me.lblUserMessages.Text = "lblUserMessages"
        '
        'dgvWeek
        '
        Me.dgvWeek.AllowUserToAddRows = false
        Me.dgvWeek.AllowUserToDeleteRows = false
        Me.dgvWeek.AutoGenerateColumns = false
        Me.dgvWeek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWeek.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.ClientCodeDataGridViewTextBoxColumn, Me.AssignmentCodeDataGridViewTextBoxColumn, Me.HoursPerDayDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.colDay1, Me.colDay2, Me.colDay3, Me.colDay4, Me.colDay5, Me.colDay6, Me.colDay7})
        Me.dgvWeek.DataSource = Me.EngagementBindingSource
        Me.dgvWeek.Location = New System.Drawing.Point(290, 58)
        Me.dgvWeek.Name = "dgvWeek"
        Me.dgvWeek.ReadOnly = true
        Me.dgvWeek.Size = New System.Drawing.Size(593, 177)
        Me.dgvWeek.TabIndex = 20
        '
        'EngagementBindingSource
        '
        Me.EngagementBindingSource.DataSource = GetType(timeEntryBot.Models.Engagement)
        '
        'colName
        '
        Me.colName.Frozen = true
        Me.colName.HeaderText = "Client Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = true
        Me.colName.Width = 200
        '
        'ClientCodeDataGridViewTextBoxColumn
        '
        Me.ClientCodeDataGridViewTextBoxColumn.DataPropertyName = "ClientCode"
        Me.ClientCodeDataGridViewTextBoxColumn.HeaderText = "ClientCode"
        Me.ClientCodeDataGridViewTextBoxColumn.Name = "ClientCodeDataGridViewTextBoxColumn"
        Me.ClientCodeDataGridViewTextBoxColumn.ReadOnly = true
        Me.ClientCodeDataGridViewTextBoxColumn.Visible = false
        '
        'AssignmentCodeDataGridViewTextBoxColumn
        '
        Me.AssignmentCodeDataGridViewTextBoxColumn.DataPropertyName = "AssignmentCode"
        Me.AssignmentCodeDataGridViewTextBoxColumn.HeaderText = "AssignmentCode"
        Me.AssignmentCodeDataGridViewTextBoxColumn.Name = "AssignmentCodeDataGridViewTextBoxColumn"
        Me.AssignmentCodeDataGridViewTextBoxColumn.ReadOnly = true
        Me.AssignmentCodeDataGridViewTextBoxColumn.Visible = false
        '
        'HoursPerDayDataGridViewTextBoxColumn
        '
        Me.HoursPerDayDataGridViewTextBoxColumn.DataPropertyName = "HoursPerDay"
        Me.HoursPerDayDataGridViewTextBoxColumn.HeaderText = "HoursPerDay"
        Me.HoursPerDayDataGridViewTextBoxColumn.Name = "HoursPerDayDataGridViewTextBoxColumn"
        Me.HoursPerDayDataGridViewTextBoxColumn.ReadOnly = true
        Me.HoursPerDayDataGridViewTextBoxColumn.Visible = false
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.ReadOnly = true
        Me.LocationDataGridViewTextBoxColumn.Visible = false
        '
        'colDay1
        '
        Me.colDay1.HeaderText = "SUN"
        Me.colDay1.Name = "colDay1"
        Me.colDay1.ReadOnly = true
        Me.colDay1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDay1.ToolTipText = "Enter the hours worked on Sunday"
        Me.colDay1.Width = 50
        '
        'colDay2
        '
        Me.colDay2.HeaderText = "MON"
        Me.colDay2.Name = "colDay2"
        Me.colDay2.ReadOnly = true
        Me.colDay2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDay2.ToolTipText = "Enter the hours worked on Monday"
        Me.colDay2.Width = 50
        '
        'colDay3
        '
        Me.colDay3.HeaderText = "TUE"
        Me.colDay3.Name = "colDay3"
        Me.colDay3.ReadOnly = true
        Me.colDay3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDay3.ToolTipText = "Enter the hours worked on Tuesday"
        Me.colDay3.Width = 50
        '
        'colDay4
        '
        Me.colDay4.HeaderText = "WED"
        Me.colDay4.Name = "colDay4"
        Me.colDay4.ReadOnly = true
        Me.colDay4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDay4.ToolTipText = "Enter the hours worked on Wednesday"
        Me.colDay4.Width = 50
        '
        'colDay5
        '
        Me.colDay5.HeaderText = "THU"
        Me.colDay5.Name = "colDay5"
        Me.colDay5.ReadOnly = true
        Me.colDay5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDay5.ToolTipText = "Enter the hours worked on Thursday"
        Me.colDay5.Width = 50
        '
        'colDay6
        '
        Me.colDay6.HeaderText = "FRI"
        Me.colDay6.Name = "colDay6"
        Me.colDay6.ReadOnly = true
        Me.colDay6.ToolTipText = "Enter the hours worked on Friday"
        Me.colDay6.Width = 50
        '
        'colDay7
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        Me.colDay7.DefaultCellStyle = DataGridViewCellStyle1
        Me.colDay7.HeaderText = "SAT"
        Me.colDay7.Name = "colDay7"
        Me.colDay7.ReadOnly = true
        Me.colDay7.ToolTipText = "Enter the hours worked on Saturday"
        Me.colDay7.Width = 50
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 566)
        Me.Controls.Add(Me.dgvWeek)
        Me.Controls.Add(Me.lblUserMessages)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnScheduled)
        Me.Controls.Add(Me.btnNow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmMain"
        Me.Text = "TimeEntryBot"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.dgvWeek,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EngagementBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnScheduled As Button
    Friend WithEvents btnNow As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtURL As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAssgn As TextBox
    Friend WithEvents txtClient As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbSavedCodeList As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btn_SaveClient As Button
    Friend WithEvents btnDeleteClient As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblUserMessages As Label
    Friend WithEvents dgvWeek As DataGridView
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents ClientCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssignmentCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursPerDayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colDay1 As DataGridViewTextBoxColumn
    Friend WithEvents colDay2 As DataGridViewTextBoxColumn
    Friend WithEvents colDay3 As DataGridViewTextBoxColumn
    Friend WithEvents colDay4 As DataGridViewTextBoxColumn
    Friend WithEvents colDay5 As DataGridViewTextBoxColumn
    Friend WithEvents colDay6 As DataGridViewTextBoxColumn
    Friend WithEvents colDay7 As DataGridViewTextBoxColumn
    Friend WithEvents EngagementBindingSource As BindingSource
End Class
