Imports System.IO
Public Class frm1
    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        Dim choise As Byte
        choise = MsgBox("Are you sure you want to quit?", 32 + 4)
        If choise = 6 Then Me.Close()
    End Sub

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        If Val(txt1.Text) <= 0 Then
            MsgBox("Incorrect time input")
            txt1.Text = ""
        Else
            Timer1.Start()
            lbl2.Text = txt1.Text
            cmd2.Show()
            cmd4.Show()
            cmd3.Enabled = True
            cmd1.Enabled = False
        End If
    End Sub
    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        txt1.Text = ""
        lbl2.Text = "00"
        lbl3.Text = "00"
        Timer1.Dispose()
        cmd2.Hide()
        cmd4.Hide()
        lbl2.BackColor = Color.Transparent
        lbl3.BackColor = Color.Transparent
        lbl3.ForeColor = Color.Black
        lbl2.ForeColor = Color.Black
        txt1.ForeColor = Color.Black
        txt1.BackColor = Color.White
        lbl4.ForeColor = Color.Black
        lbl4.BackColor = Color.Transparent
        cmd1.Enabled = True
        cmd3.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Equals(Val(txt1.Text))
        Timer1.Interval = 1000
        If lbl3.Text = 0 Then
            lbl2.Text = lbl2.Text - 1
            lbl3.Text = 60
        End If
        If lbl3.Text > 0 Then
            lbl3.Text -= 1
        End If
        If lbl3.Text = 10 And lbl2.Text = 0 Then
            My.Computer.Audio.Play(My.Resources.beep2, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.beep2, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.beep2, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.beep2, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.beep2, AudioPlayMode.Background)
            MsgBox("Компютърът ще се изключи след 10 секунди!")
            lbl2.BackColor = Color.Red
            lbl3.BackColor = Color.Red
            lbl3.ForeColor = Color.Blue
            lbl2.ForeColor = Color.Blue
            txt1.ForeColor = Color.Red
            txt1.BackColor = Color.Blue
            lbl4.ForeColor = Color.Blue
            lbl4.BackColor = Color.Red
        End If
        If lbl3.Text = 59 And lbl2.Text = 0 Then
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            MsgBox("Компютърът ще се изключи след 1 минута!")
        End If
        If lbl3.Text = 0 And lbl2.Text = 0 Then
            txt1.Text = "System is shutting"
            My.Computer.Audio.Play(My.Resources.beep3, AudioPlayMode.Background)
            Me.Enabled = False
            Shell("shutdown -s")
        End If
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged
        Timer1.Stop()
        lbl2.Text = "00"
        lbl3.Text = "00"
        cmd2.Hide()
        cmd4.Hide()
        cmd1.Enabled = True
        cmd3.Enabled = False
        lbl2.BackColor = Color.Transparent
        lbl3.BackColor = Color.Transparent
        lbl3.ForeColor = Color.Black
        lbl2.ForeColor = Color.Black
        txt1.ForeColor = Color.Black
        txt1.BackColor = Color.White
        lbl4.ForeColor = Color.Black
        lbl4.BackColor = Color.Transparent
    End Sub

    Private Sub txt1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress

        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        Timer1.Enabled = True
    End Sub

    Private Sub frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time = My.Settings.time1
        Dim FileName As String
        Dim FilePath As Object
        Dim RegistryKey As Object

        FileName = "WindowsKiller.exe"
        FilePath = Path.GetFullPath(FileName)
        RegistryKey = CreateObject("WScript.Shell")

        RegistryKey.RegWrite("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run\WindowsKiller", FilePath)
    End Sub

    Private Sub frm1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Settings.time1 = time
    End Sub

    Private Sub txth_TextChanged(sender As Object, e As EventArgs) Handles txth.TextChanged

    End Sub

    Private Sub txtm_TextChanged(sender As Object, e As EventArgs) Handles txtm.TextChanged

    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        txtshut.Text = txth.Text + ":" + txtm.Text
        h = txth.Text
        m = txtm.Text
        time = h + ":" + m
        Timer2.Start()
    End Sub

    Private Sub frm2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Settings.time1 = time

    End Sub

    Private Sub frm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time = My.Settings.time1
        txtshut.Text = time
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        If time = DateTime.Now.ToShortTimeString() Then
            Shell("shutdown -s")
            Timer2.Stop()
        End If
    End Sub

    Private Sub frm1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                NotifyIcon1.Visible = True
                NotifyIcon1.ShowBalloonTip(1, "WindowsKiller", "Running Minimized", ToolTipIcon.Info)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class