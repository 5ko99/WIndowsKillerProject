<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.txth = New System.Windows.Forms.TextBox()
        Me.txtm = New System.Windows.Forms.TextBox()
        Me.lbldot = New System.Windows.Forms.Label()
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.txtshut = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt1.Location = New System.Drawing.Point(205, 9)
        Me.txt1.MaxLength = 3
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(63, 42)
        Me.txt1.TabIndex = 1
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(12, 63)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(75, 20)
        Me.cmd1.TabIndex = 2
        Me.cmd1.Text = "Start timer"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(12, 89)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(75, 20)
        Me.cmd2.TabIndex = 4
        Me.cmd2.Text = "Pause"
        Me.cmd2.UseVisualStyleBackColor = True
        Me.cmd2.Visible = False
        '
        'cmd3
        '
        Me.cmd3.Enabled = False
        Me.cmd3.Location = New System.Drawing.Point(93, 63)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(75, 20)
        Me.cmd3.TabIndex = 3
        Me.cmd3.Text = "Clear timer"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd5.Location = New System.Drawing.Point(205, 89)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(63, 20)
        Me.cmd5.TabIndex = 6
        Me.cmd5.Text = "Exit"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl1.Location = New System.Drawing.Point(5, 9)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(191, 42)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Въведете минутите след които да се изключи вашият компютър:"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl2.Location = New System.Drawing.Point(205, 54)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(38, 32)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "00"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl3.Location = New System.Drawing.Point(231, 54)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(37, 32)
        Me.lbl3.TabIndex = 8
        Me.lbl3.Text = "00"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl4.Location = New System.Drawing.Point(231, 63)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(11, 15)
        Me.lbl4.TabIndex = 9
        Me.lbl4.Text = ":"
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(93, 89)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(75, 20)
        Me.cmd4.TabIndex = 5
        Me.cmd4.Text = "Resume"
        Me.cmd4.UseVisualStyleBackColor = True
        Me.cmd4.Visible = False
        '
        'txth
        '
        Me.txth.Location = New System.Drawing.Point(12, 144)
        Me.txth.MaxLength = 2
        Me.txth.Name = "txth"
        Me.txth.Size = New System.Drawing.Size(24, 20)
        Me.txth.TabIndex = 11
        '
        'txtm
        '
        Me.txtm.Location = New System.Drawing.Point(62, 144)
        Me.txtm.MaxLength = 2
        Me.txtm.Name = "txtm"
        Me.txtm.Size = New System.Drawing.Size(24, 20)
        Me.txtm.TabIndex = 12
        '
        'lbldot
        '
        Me.lbldot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbldot.Location = New System.Drawing.Point(42, 144)
        Me.lbldot.Name = "lbldot"
        Me.lbldot.Size = New System.Drawing.Size(14, 23)
        Me.lbldot.TabIndex = 13
        Me.lbldot.Text = ":"
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(5, 170)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(121, 23)
        Me.cmdadd.TabIndex = 14
        Me.cmdadd.Text = "Add Planed Shutdown"
        Me.cmdadd.UseVisualStyleBackColor = True
        '
        'txtshut
        '
        Me.txtshut.Enabled = False
        Me.txtshut.Location = New System.Drawing.Point(5, 199)
        Me.txtshut.Name = "txtshut"
        Me.txtshut.Size = New System.Drawing.Size(121, 20)
        Me.txtshut.TabIndex = 15
        '
        'Timer2
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "WindowsKiller"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 48)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frm1
        '
        Me.AcceptButton = Me.cmd1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.cmd5
        Me.ClientSize = New System.Drawing.Size(282, 230)
        Me.Controls.Add(Me.txtshut)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.lbldot)
        Me.Controls.Add(Me.txtm)
        Me.Controls.Add(Me.txth)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.cmd5)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WindowsKiller"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents cmd3 As System.Windows.Forms.Button
    Friend WithEvents cmd5 As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents cmd4 As System.Windows.Forms.Button
    Friend WithEvents txth As TextBox
    Friend WithEvents txtm As TextBox
    Friend WithEvents lbldot As Label
    Friend WithEvents cmdadd As Button
    Friend WithEvents txtshut As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
