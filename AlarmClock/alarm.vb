' Speech controls
Imports System.Speech.Synthesis
' Timer Controls
Imports System.Windows.Forms.Timer

Public Class alarm
    ' Class to hold all the Alarm Clock information

    Private _alarmCurrDateTime As Date ' Holds the date at which the alarm rings
    Private _alarmDateTime As Date = _alarmCurrDateTime ' By the time anyone enables the alarm, the time will be different.
    Private _alarmEnabled As Boolean = False
    Private _alarmContentStr As String = ""
    Private _alarmContent As List(Of String)
    Private _alarmListPointer As Integer
    Private _displayAlarm As Boolean = False
    Private _soundingSpeechAlarm As Boolean = False
    Private _shouldBeSoundingSpeechAlarm As Boolean = False
    Private _alarmActive As Boolean = False
    ' Timer to run clock and alarm
    Private WithEvents clsTimer As New System.Windows.Forms.Timer
    ' Setup Speech object
    Dim speech As New SpeechSynthesizer()

    Sub New()
        ' Create Timer to run the clock
        'clsTimer = New System.Windows.Forms.Timer
        clsTimer.Interval = 1000
        'AddHandler clsTimer.Elapsed, AddressOf timerTick

        ' Handle the stopping of speech
        AddHandler speech.SpeakCompleted, AddressOf speechCompleted ' This event handler is refusing to fire!! It works fine in its own project. But not in here ???

        clsTimer.Enabled = True

        ' Set default alarm to sound and which sound
        Me.setDefaultAlarm()


    End Sub
    Public Property displayAlarm As Boolean
        Get
            Return _displayAlarm
        End Get
        Set(value As Boolean)
            _displayAlarm = value
        End Set
    End Property
    Public Property alarmDateTime() As Date
        Get
            Return _alarmDateTime
        End Get
        Set(value As Date)
            _alarmDateTime = value
        End Set

    End Property

    Public Property currDateTime() As Date
        Get
            Return _alarmCurrDateTime
        End Get
        Set(value As Date)
            _alarmCurrDateTime = value
        End Set
    End Property

    Public Property alarmEnabled As Boolean
        Get
            Return _alarmEnabled
        End Get
        Set(value As Boolean)
            _alarmEnabled = value

            If value = False Then
                ' Turn off any ringing alarms
                'MsgBox("Silence the alarm")
                Me.stopAlarm()
            End If
        End Set
    End Property

    Private Sub timerTick() Handles clsTimer.Tick
        Dim tmpDate As DateTime = DateTime.Now

        ' update the clock display every second
        _alarmCurrDateTime = tmpDate
        updateClock()

        ' Check if the alarm needs to ring/go off
        If _alarmEnabled = True Then

            If (_alarmCurrDateTime.ToString("G") = _alarmDateTime.ToString("G") And _soundingSpeechAlarm = False) Or (_soundingSpeechAlarm = False And _shouldBeSoundingSpeechAlarm = True) Then

                ' Activate ring!
                'MsgBox("Alarm")
                If _alarmContentStr = "" Then
                    Me.triggerAlarmSound()
                Else
                    Me.triggerAlarmSpeech()
                End If

            End If
        End If
    End Sub
    ' Pass a string containing text to use Text to Speech
    Public Overloads Property alarmContent As String

        Get
            Return _alarmContentStr
        End Get
        Set(value As String)
            _alarmContentStr = value
        End Set

    End Property
    ' Pass a list containing .wav filenames to use them as alarms
    Public Overloads Property alarmContent(ByVal whichAlarm As Integer) As List(Of String)

        Get
            Return _alarmContent
        End Get
        Set(value As List(Of String))
            _alarmContent = value
            _alarmListPointer = whichAlarm

            ' Remove the Text for compare
            _alarmContentStr = ""

        End Set

    End Property

    Private Sub triggerAlarmSound()
        Dim filename As String = _alarmContent.Item(_alarmListPointer)

        ' Play sound !
        My.Computer.Audio.Play(filename, AudioPlayMode.BackgroundLoop)
    End Sub

    ' Only fires once and then ?hangs?
    Private Sub triggerAlarmSpeech()

        ' Set notice that we are active
        _soundingSpeechAlarm = True
        _shouldBeSoundingSpeechAlarm = True

        speech.Dispose()
        speech = New SpeechSynthesizer
        speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult)

        'speech.SpeakAsync(_alarmContentStr) ' Enable if the speechCompleted event sub ever starts working

        speech.Speak(_alarmContentStr) ' Until speech event is working
        My.Application.DoEvents() ' Until speech event is working

        _soundingSpeechAlarm = False
        _shouldBeSoundingSpeechAlarm = True

    End Sub

    ' This sub never fires for some baff reason. A test projet worked ok.
    Private Sub speechCompleted(sender As Object, e As SpeakCompletedEventArgs)

        MsgBox("test1")
        _soundingSpeechAlarm = False
        _shouldBeSoundingSpeechAlarm = True

    End Sub

    Public Sub stopAlarm()

        ' Stop sounds
        My.Computer.Audio.Stop()

        ' Stop Speech
        _shouldBeSoundingSpeechAlarm = False ' stop yelling!
        _soundingSpeechAlarm = False

        speech.Dispose()

    End Sub
    Public Sub setDefaultAlarm()

        Dim alList As New List(Of String)
        Dim file() As String
        file = IO.Directory.GetFiles(Application.StartupPath + "\sounds\", "Loud_Alarm_Clock_Buzzer.wav") ' Use this one for the annoying sound in the menu.

        alList.Add(file(0))

        Me.alarmContent(0) = alList

    End Sub

    Private Sub updateClock()
        Dim hrs As String
        Dim mins As String
        Dim secs As String

        Dim hours() As Char
        Dim minutes() As Char
        Dim seconds() As Char

        Dim hr1 As String
        Dim hr2 As String
        Dim mm1 As String
        Dim mm2 As String
        Dim ss1 As String
        Dim ss2 As String

        Dim currTime As DateTime = Date.Now

        ' display the normal clock or the set Alarm time.
        If _displayAlarm = False Then
            hrs = currTime.Hour.ToString()
            mins = currTime.Minute.ToString()
            secs = currTime.Second.ToString()
        Else
            hrs = _alarmDateTime.Hour.ToString()
            mins = _alarmDateTime.Minute.ToString()
            secs = _alarmDateTime.Second.ToString()
        End If

        hours = hrs.ToCharArray()
        minutes = mins.ToCharArray()
        seconds = secs.ToCharArray()

        If hours.Length > 1 Then
            hr1 = hours(0)
            hr2 = hours(1)
        Else
            hr1 = "0"
            hr2 = hours(0)
        End If

        If minutes.Length > 1 Then
            mm1 = minutes(0)
            mm2 = minutes(1)
        Else
            mm1 = "0"
            mm2 = minutes(0)
        End If

        If seconds.Length > 1 Then
            ss1 = seconds(0)
            ss2 = seconds(1)
        Else
            ss1 = "0"
            ss2 = seconds(0)
        End If

        Form1.Led1.SetNumber(Convert.ToInt32(hr1))
        Form1.Led2.SetNumber(Convert.ToInt32(hr2))
        Form1.Led3.SetNumber(Convert.ToInt32(mm1))
        Form1.Led4.SetNumber(Convert.ToInt32(mm2))
        Form1.Led5.SetNumber(Convert.ToInt32(ss1))
        Form1.Led6.SetNumber(Convert.ToInt32(ss2))
    End Sub


End Class
