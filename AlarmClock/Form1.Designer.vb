<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlarmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlarmOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add5SecsAndEnableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlarmTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnoyingBeepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeedyAlarmProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clockRadio = New System.Windows.Forms.RadioButton()
        Me.alarmRadio = New System.Windows.Forms.RadioButton()
        Me.enableAlarmChk = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Led1 = New LEDdisplay.LED()
        Me.Led2 = New LEDdisplay.LED()
        Me.Led3 = New LEDdisplay.LED()
        Me.Led4 = New LEDdisplay.LED()
        Me.Led5 = New LEDdisplay.LED()
        Me.Led6 = New LEDdisplay.LED()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AlarmToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(702, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlarmToolStripMenuItem1})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AlarmToolStripMenuItem1
        '
        Me.AlarmToolStripMenuItem1.Name = "AlarmToolStripMenuItem1"
        Me.AlarmToolStripMenuItem1.Size = New System.Drawing.Size(106, 22)
        Me.AlarmToolStripMenuItem1.Text = "Alarm"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AlarmToolStripMenuItem
        '
        Me.AlarmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlarmOnToolStripMenuItem, Me.Add5SecsAndEnableToolStripMenuItem, Me.AlarmTypesToolStripMenuItem})
        Me.AlarmToolStripMenuItem.Name = "AlarmToolStripMenuItem"
        Me.AlarmToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AlarmToolStripMenuItem.Text = "Alarm"
        '
        'AlarmOnToolStripMenuItem
        '
        Me.AlarmOnToolStripMenuItem.Name = "AlarmOnToolStripMenuItem"
        Me.AlarmOnToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AlarmOnToolStripMenuItem.Text = "Enable"
        '
        'Add5SecsAndEnableToolStripMenuItem
        '
        Me.Add5SecsAndEnableToolStripMenuItem.Name = "Add5SecsAndEnableToolStripMenuItem"
        Me.Add5SecsAndEnableToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.Add5SecsAndEnableToolStripMenuItem.Text = "Set 5 secs and Enable"
        '
        'AlarmTypesToolStripMenuItem
        '
        Me.AlarmTypesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnnoyingBeepToolStripMenuItem, Me.TextMessageToolStripMenuItem})
        Me.AlarmTypesToolStripMenuItem.Name = "AlarmTypesToolStripMenuItem"
        Me.AlarmTypesToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AlarmTypesToolStripMenuItem.Text = "Alarm types"
        '
        'AnnoyingBeepToolStripMenuItem
        '
        Me.AnnoyingBeepToolStripMenuItem.Name = "AnnoyingBeepToolStripMenuItem"
        Me.AnnoyingBeepToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AnnoyingBeepToolStripMenuItem.Text = "Annoying Beep"
        '
        'TextMessageToolStripMenuItem
        '
        Me.TextMessageToolStripMenuItem.Name = "TextMessageToolStripMenuItem"
        Me.TextMessageToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.TextMessageToolStripMenuItem.Text = "Spoken Message"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeedyAlarmProgramToolStripMenuItem})
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutUsToolStripMenuItem.Text = "About"
        '
        'LeedyAlarmProgramToolStripMenuItem
        '
        Me.LeedyAlarmProgramToolStripMenuItem.Name = "LeedyAlarmProgramToolStripMenuItem"
        Me.LeedyAlarmProgramToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.LeedyAlarmProgramToolStripMenuItem.Text = "Leedy Alarm Program"
        '
        'clockRadio
        '
        Me.clockRadio.AutoSize = True
        Me.clockRadio.Checked = True
        Me.clockRadio.Location = New System.Drawing.Point(114, 201)
        Me.clockRadio.Name = "clockRadio"
        Me.clockRadio.Size = New System.Drawing.Size(52, 17)
        Me.clockRadio.TabIndex = 2
        Me.clockRadio.TabStop = True
        Me.clockRadio.Text = "Clock"
        Me.clockRadio.UseVisualStyleBackColor = True
        '
        'alarmRadio
        '
        Me.alarmRadio.AutoSize = True
        Me.alarmRadio.Location = New System.Drawing.Point(172, 201)
        Me.alarmRadio.Name = "alarmRadio"
        Me.alarmRadio.Size = New System.Drawing.Size(51, 17)
        Me.alarmRadio.TabIndex = 3
        Me.alarmRadio.Text = "Alarm"
        Me.alarmRadio.UseVisualStyleBackColor = True
        '
        'enableAlarmChk
        '
        Me.enableAlarmChk.AutoSize = True
        Me.enableAlarmChk.Location = New System.Drawing.Point(500, 202)
        Me.enableAlarmChk.Name = "enableAlarmChk"
        Me.enableAlarmChk.Size = New System.Drawing.Size(88, 17)
        Me.enableAlarmChk.TabIndex = 4
        Me.enableAlarmChk.Text = "Enable Alarm"
        Me.enableAlarmChk.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Led1
        '
        Me.Led1.Location = New System.Drawing.Point(3, 0)
        Me.Led1.Name = "Led1"
        Me.Led1.Size = New System.Drawing.Size(96, 151)
        Me.Led1.TabIndex = 5
        '
        'Led2
        '
        Me.Led2.Location = New System.Drawing.Point(105, 0)
        Me.Led2.Name = "Led2"
        Me.Led2.Size = New System.Drawing.Size(96, 151)
        Me.Led2.TabIndex = 6
        '
        'Led3
        '
        Me.Led3.Location = New System.Drawing.Point(243, 0)
        Me.Led3.Name = "Led3"
        Me.Led3.Size = New System.Drawing.Size(96, 151)
        Me.Led3.TabIndex = 7
        '
        'Led4
        '
        Me.Led4.Location = New System.Drawing.Point(345, 0)
        Me.Led4.Name = "Led4"
        Me.Led4.Size = New System.Drawing.Size(96, 151)
        Me.Led4.TabIndex = 8
        '
        'Led5
        '
        Me.Led5.Location = New System.Drawing.Point(483, 0)
        Me.Led5.Name = "Led5"
        Me.Led5.Size = New System.Drawing.Size(96, 151)
        Me.Led5.TabIndex = 9
        '
        'Led6
        '
        Me.Led6.Location = New System.Drawing.Point(585, 0)
        Me.Led6.Name = "Led6"
        Me.Led6.Size = New System.Drawing.Size(96, 151)
        Me.Led6.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Led6)
        Me.Panel1.Controls.Add(Me.Led1)
        Me.Panel1.Controls.Add(Me.Led5)
        Me.Panel1.Controls.Add(Me.Led2)
        Me.Panel1.Controls.Add(Me.Led4)
        Me.Panel1.Controls.Add(Me.Led3)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 151)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(12, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(678, 151)
        Me.Panel2.TabIndex = 12
        Me.Panel2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(702, 236)
        Me.Controls.Add(Me.enableAlarmChk)
        Me.Controls.Add(Me.alarmRadio)
        Me.Controls.Add(Me.clockRadio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leedy Clock"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlarmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlarmOnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Add5SecsAndEnableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlarmTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnnoyingBeepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlarmToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clockRadio As System.Windows.Forms.RadioButton
    Friend WithEvents alarmRadio As System.Windows.Forms.RadioButton
    Friend WithEvents enableAlarmChk As System.Windows.Forms.CheckBox
    Friend WithEvents LeedyAlarmProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Led1 As LEDdisplay.LED
    Friend WithEvents Led2 As LEDdisplay.LED
    Friend WithEvents Led3 As LEDdisplay.LED
    Friend WithEvents Led4 As LEDdisplay.LED
    Friend WithEvents Led5 As LEDdisplay.LED
    Friend WithEvents Led6 As LEDdisplay.LED
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
