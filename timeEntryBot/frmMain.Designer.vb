<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAssgn = New System.Windows.Forms.TextBox()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.notifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.mainStatus = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.mainStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(216, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(324, 37)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Note:  This bot must be running in order for it to fill in your time on Sunday ni" &
    "ght.  Use it on an always-on computer (not your laptop)."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Stop Being Delinquent"
        '
        'btnScheduled
        '
        Me.btnScheduled.Location = New System.Drawing.Point(277, 242)
        Me.btnScheduled.Name = "btnScheduled"
        Me.btnScheduled.Size = New System.Drawing.Size(260, 36)
        Me.btnScheduled.TabIndex = 2
        Me.btnScheduled.Text = "Populate time site on Sundays @ 6pm"
        Me.btnScheduled.UseVisualStyleBackColor = True
        '
        'btnNow
        '
        Me.btnNow.Location = New System.Drawing.Point(277, 201)
        Me.btnNow.Name = "btnNow"
        Me.btnNow.Size = New System.Drawing.Size(260, 35)
        Me.btnNow.TabIndex = 1
        Me.btnNow.Text = "Populate time site for this whole week right now"
        Me.btnNow.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtHours)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAssgn)
        Me.GroupBox1.Controls.Add(Me.txtClient)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Engagement Settings"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Location Code"
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(185, 180)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(60, 21)
        Me.txtLocation.TabIndex = 8
        '
        'btnDeleteClient
        '
        Me.btnDeleteClient.Location = New System.Drawing.Point(143, 211)
        Me.btnDeleteClient.Name = "btnDeleteClient"
        Me.btnDeleteClient.Size = New System.Drawing.Size(102, 23)
        Me.btnDeleteClient.TabIndex = 10
        Me.btnDeleteClient.Text = "Delete Alias"
        Me.btnDeleteClient.UseVisualStyleBackColor = True
        '
        'btn_SaveClient
        '
        Me.btn_SaveClient.Location = New System.Drawing.Point(22, 211)
        Me.btn_SaveClient.Name = "btn_SaveClient"
        Me.btn_SaveClient.Size = New System.Drawing.Size(102, 23)
        Me.btn_SaveClient.TabIndex = 9
        Me.btn_SaveClient.Text = "Save Alias"
        Me.btn_SaveClient.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Alias Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(124, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 21)
        Me.txtName.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(226, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Saved Engagement Aliases"
        '
        'cmbSavedCodeList
        '
        Me.cmbSavedCodeList.FormattingEnabled = True
        Me.cmbSavedCodeList.Location = New System.Drawing.Point(22, 43)
        Me.cmbSavedCodeList.Name = "cmbSavedCodeList"
        Me.cmbSavedCodeList.Size = New System.Drawing.Size(223, 23)
        Me.cmbSavedCodeList.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Number of Hours per Day"
        '
        'txtHours
        '
        Me.txtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(185, 153)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(60, 21)
        Me.txtHours.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Assgn Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Client Code"
        '
        'txtAssgn
        '
        Me.txtAssgn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssgn.Location = New System.Drawing.Point(124, 126)
        Me.txtAssgn.Name = "txtAssgn"
        Me.txtAssgn.Size = New System.Drawing.Size(121, 21)
        Me.txtAssgn.TabIndex = 6
        '
        'txtClient
        '
        Me.txtClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClient.Location = New System.Drawing.Point(124, 99)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(121, 21)
        Me.txtClient.TabIndex = 5
        '
        'notifyIcon
        '
        Me.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.notifyIcon.BalloonTipText = "TimeBot has been minimized to the system tray"
        Me.notifyIcon.BalloonTipTitle = "TimeBot"
        Me.notifyIcon.Icon = CType(resources.GetObject("notifyIcon.Icon"), System.Drawing.Icon)
        Me.notifyIcon.Text = "TimeBot"
        Me.notifyIcon.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveSettings)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtURL)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtPass)
        Me.GroupBox2.Controls.Add(Me.txtUser)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(276, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 149)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time Site Settings"
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(21, 113)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(223, 23)
        Me.btnSaveSettings.TabIndex = 18
        Me.btnSaveSettings.Text = "Save Time Site Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Time Site URL"
        '
        'txtURL
        '
        Me.txtURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtURL.Location = New System.Drawing.Point(123, 27)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(121, 21)
        Me.txtURL.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Username"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(123, 79)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(121, 21)
        Me.txtPass.TabIndex = 14
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(123, 53)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(121, 21)
        Me.txtUser.TabIndex = 13
        '
        'mainStatus
        '
        Me.mainStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel})
        Me.mainStatus.Location = New System.Drawing.Point(0, 304)
        Me.mainStatus.Name = "mainStatus"
        Me.mainStatus.Size = New System.Drawing.Size(550, 22)
        Me.mainStatus.TabIndex = 21
        Me.mainStatus.Text = "StatusStrip1"
        '
        'statusLabel
        '
        Me.statusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 326)
        Me.Controls.Add(Me.mainStatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnScheduled)
        Me.Controls.Add(Me.btnNow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.Text = "TimeEntryBot"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.mainStatus.ResumeLayout(False)
        Me.mainStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnScheduled As Button
    Friend WithEvents btnNow As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAssgn As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbSavedCodeList As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btn_SaveClient As Button
    Friend WithEvents btnDeleteClient As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLocation As TextBox
    Public WithEvents txtClient As TextBox
    Friend WithEvents notifyIcon As NotifyIcon
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Public WithEvents txtURL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents txtPass As TextBox
    Public WithEvents txtUser As TextBox
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents mainStatus As StatusStrip
    Friend WithEvents statusLabel As ToolStripStatusLabel
End Class
