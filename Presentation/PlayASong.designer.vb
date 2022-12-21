<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlayASong
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstSongsNameSongInfo = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPlayBackNameSongInfo = New System.Windows.Forms.Label()
        Me.BPlay = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Play a song"
        '
        'lstSongsNameSongInfo
        '
        Me.lstSongsNameSongInfo.FormattingEnabled = True
        Me.lstSongsNameSongInfo.ItemHeight = 16
        Me.lstSongsNameSongInfo.Location = New System.Drawing.Point(12, 82)
        Me.lstSongsNameSongInfo.Name = "lstSongsNameSongInfo"
        Me.lstSongsNameSongInfo.Size = New System.Drawing.Size(418, 292)
        Me.lstSongsNameSongInfo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select a song"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(436, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Song: "
        '
        'lblPlayBackNameSongInfo
        '
        Me.lblPlayBackNameSongInfo.AutoSize = True
        Me.lblPlayBackNameSongInfo.Location = New System.Drawing.Point(491, 218)
        Me.lblPlayBackNameSongInfo.Name = "lblPlayBackNameSongInfo"
        Me.lblPlayBackNameSongInfo.Size = New System.Drawing.Size(13, 17)
        Me.lblPlayBackNameSongInfo.TabIndex = 5
        Me.lblPlayBackNameSongInfo.Text = "-"
        '
        'BPlay
        '
        Me.BPlay.BackColor = System.Drawing.Color.Tomato
        Me.BPlay.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BPlay.Location = New System.Drawing.Point(436, 250)
        Me.BPlay.Name = "BPlay"
        Me.BPlay.Size = New System.Drawing.Size(155, 46)
        Me.BPlay.TabIndex = 6
        Me.BPlay.Text = "PLAY!"
        Me.BPlay.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(436, 302)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(352, 35)
        Me.ProgressBar2.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.Location = New System.Drawing.Point(739, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 30)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(694, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PlayASong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(800, 418)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.BPlay)
        Me.Controls.Add(Me.lblPlayBackNameSongInfo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstSongsNameSongInfo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.name = "PlayASong"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstSongsNameSongInfo As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPlayBackNameSongInfo As Label
    Friend WithEvents BPlay As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
