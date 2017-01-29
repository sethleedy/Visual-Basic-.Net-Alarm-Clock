Public Class Form1
    ' Load my Alarm Clock class
    Public alClock As New alarm ' Constructor starts a timer and auto starts form1 clock

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub clockRadio_CheckedChanged(sender As Object, e As EventArgs) Handles clockRadio.CheckedChanged
        alClock.displayAlarm = False
    End Sub

    Private Sub alarmRadio_CheckedChanged(sender As Object, e As EventArgs) Handles alarmRadio.CheckedChanged
        alClock.displayAlarm = True

    End Sub
    Private Sub Add5SecsAndEnableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Add5SecsAndEnableToolStripMenuItem.Click
        Dim tmpDate As DateTime = DateTime.Now

        alClock.alarmDateTime = tmpDate.AddSeconds(5)
        alClock.alarmEnabled = True
        enableAlarmChk.Checked = True

    End Sub
    Private Sub enableAlarmChk_CheckedChanged(sender As Object, e As EventArgs) Handles enableAlarmChk.CheckedChanged

        AlarmOnToolStripMenuItem.Checked = enableAlarmChk.Checked ' Bind the menu and checkbox together before doing an IF on the event
        enableDisableAlarm()

    End Sub

    Private Sub AlarmOnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlarmOnToolStripMenuItem.Click

        ' Toggle Boolean
        AlarmOnToolStripMenuItem.Checked = Not (AlarmOnToolStripMenuItem.Checked)

        ' The following will change the checkmark and fire enableAlarmChk click event. Thus running sub enableDisableAlarm there for both controls
        enableAlarmChk.Checked = AlarmOnToolStripMenuItem.Checked ' Bind the menu and checkbox together before doing an IF on the event

    End Sub
    Private Sub enableDisableAlarm()

        If enableAlarmChk.Checked Then
            alClock.alarmEnabled = enableAlarmChk.Checked
        Else
            alClock.alarmEnabled = False
        End If
    End Sub

    Private Sub AlarmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlarmToolStripMenuItem1.Click
        frmSettings.Show()
    End Sub

    Private Sub AnnoyingBeepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnoyingBeepToolStripMenuItem.Click

        ' Set the default sound as it is the same as the alClock default on startup
        alClock.setDefaultAlarm()

    End Sub

    Private Sub TextMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextMessageToolStripMenuItem.Click

        ' Assign whatever is in the settings form for the speech text
        alClock.alarmContent = frmSettings.TextBox1.Text

    End Sub

    Private Sub LeedyAlarmProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeedyAlarmProgramToolStripMenuItem.Click
        MsgBox("This is a program by Seth Leedy")
    End Sub
End Class
