Public Class frmSettings

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load the sound file names into the listbox
        Dim AllowedExtension As String = ".mp3 .wav"
        Dim strRes() As String

        For Each file As String In IO.Directory.GetFiles("sounds", "*.*")
            If AllowedExtension.Contains(IO.Path.GetExtension(file).ToLower) Then

                ' split out the folder name for the listbox
                strRes = file.ToString.Split("\")
                ' Add to listbox
                ListBox1.Items.Add(strRes(1))

            End If
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Save my settings

        If RadioButton1.Checked Then ' Alarm Sound

            ' Copy everything to a list in the alClock object
            Dim AllowedExtension As String = ".mp3 .wav"
            Dim alarmList As New List(Of String)

            For Each file As String In IO.Directory.GetFiles("sounds", "*.*")
                If AllowedExtension.Contains(IO.Path.GetExtension(file).ToLower) Then
                    ' Copy everything to a list in the alClock object
                    alarmList.Add(Application.StartupPath + "\" + file)
                End If
            Next
            Form1.alClock.alarmContent(ListBox1.SelectedIndex) = alarmList

            ' Clear Speech to compare 
            Form1.alClock.alarmContent = ""

        Else ' Speech

            Form1.alClock.alarmContent = TextBox1.Text

        End If

        ' Alarm Time Set
        Form1.alClock.alarmDateTime = DateTimePicker1.Value

        Me.Hide()

    End Sub
End Class