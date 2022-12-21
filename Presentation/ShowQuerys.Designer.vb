<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShowQuerys
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstQuerys = New System.Windows.Forms.ListBox()
        Me.BArtistsNumberPlaybacks = New System.Windows.Forms.Button()
        Me.BSongsNumberPlaybacks = New System.Windows.Forms.Button()
        Me.BArtistMostListened = New System.Windows.Forms.Button()
        Me.BTimeUsingApplication = New System.Windows.Forms.Button()
        Me.BPlaybacksFavArtist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.Location = New System.Drawing.Point(942, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(897, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lstQuerys
        '
        Me.lstQuerys.FormattingEnabled = True
        Me.lstQuerys.IntegralHeight = False
        Me.lstQuerys.ItemHeight = 16
        Me.lstQuerys.Location = New System.Drawing.Point(12, 47)
        Me.lstQuerys.Name = "lstQuerys"
        Me.lstQuerys.Size = New System.Drawing.Size(221, 359)
        Me.lstQuerys.TabIndex = 16
        '
        'BArtistsNumberPlaybacks
        '
        Me.BArtistsNumberPlaybacks.BackColor = System.Drawing.Color.Tomato
        Me.BArtistsNumberPlaybacks.Location = New System.Drawing.Point(411, 81)
        Me.BArtistsNumberPlaybacks.Name = "BArtistsNumberPlaybacks"
        Me.BArtistsNumberPlaybacks.Size = New System.Drawing.Size(138, 46)
        Me.BArtistsNumberPlaybacks.TabIndex = 17
        Me.BArtistsNumberPlaybacks.Text = "Artists Number Playbacks"
        Me.BArtistsNumberPlaybacks.UseVisualStyleBackColor = False
        '
        'BSongsNumberPlaybacks
        '
        Me.BSongsNumberPlaybacks.BackColor = System.Drawing.Color.Tomato
        Me.BSongsNumberPlaybacks.Location = New System.Drawing.Point(411, 198)
        Me.BSongsNumberPlaybacks.Name = "BSongsNumberPlaybacks"
        Me.BSongsNumberPlaybacks.Size = New System.Drawing.Size(138, 46)
        Me.BSongsNumberPlaybacks.TabIndex = 18
        Me.BSongsNumberPlaybacks.Text = "Songs Number Playbacks"
        Me.BSongsNumberPlaybacks.UseVisualStyleBackColor = False
        '
        'BArtistMostListened
        '
        Me.BArtistMostListened.BackColor = System.Drawing.Color.Tomato
        Me.BArtistMostListened.Location = New System.Drawing.Point(411, 250)
        Me.BArtistMostListened.Name = "BArtistMostListened"
        Me.BArtistMostListened.Size = New System.Drawing.Size(138, 46)
        Me.BArtistMostListened.TabIndex = 19
        Me.BArtistMostListened.Text = "Artist Most Listened"
        Me.BArtistMostListened.UseVisualStyleBackColor = False
        '
        'BTimeUsingApplication
        '
        Me.BTimeUsingApplication.BackColor = System.Drawing.Color.Tomato
        Me.BTimeUsingApplication.Location = New System.Drawing.Point(411, 302)
        Me.BTimeUsingApplication.Name = "BTimeUsingApplication"
        Me.BTimeUsingApplication.Size = New System.Drawing.Size(138, 46)
        Me.BTimeUsingApplication.TabIndex = 20
        Me.BTimeUsingApplication.Text = "Time Using Application"
        Me.BTimeUsingApplication.UseVisualStyleBackColor = False
        '
        'BPlaybacksFavArtist
        '
        Me.BPlaybacksFavArtist.BackColor = System.Drawing.Color.Tomato
        Me.BPlaybacksFavArtist.Location = New System.Drawing.Point(411, 354)
        Me.BPlaybacksFavArtist.Name = "BPlaybacksFavArtist"
        Me.BPlaybacksFavArtist.Size = New System.Drawing.Size(138, 46)
        Me.BPlaybacksFavArtist.TabIndex = 21
        Me.BPlaybacksFavArtist.Text = "Playbacks Fav Artist"
        Me.BPlaybacksFavArtist.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(408, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Select an option"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(687, 250)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 23
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(687, 274)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 24
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(239, 47)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(132, 356)
        Me.ListBox1.TabIndex = 25
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Tomato
        Me.Button3.Location = New System.Drawing.Point(411, 133)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 59)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Artist Number Playbacks By Country"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(594, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Initial Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(594, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Final Date"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(687, 151)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 22)
        Me.TextBox1.TabIndex = 29
        Me.TextBox1.Text = "Country"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "-"
        '
        'ShowQuerys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(992, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BPlaybacksFavArtist)
        Me.Controls.Add(Me.BTimeUsingApplication)
        Me.Controls.Add(Me.BArtistMostListened)
        Me.Controls.Add(Me.BSongsNumberPlaybacks)
        Me.Controls.Add(Me.BArtistsNumberPlaybacks)
        Me.Controls.Add(Me.lstQuerys)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "ShowQuerys"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lstQuerys As ListBox
    Friend WithEvents BArtistsNumberPlaybacks As Button
    Friend WithEvents BSongsNumberPlaybacks As Button
    Friend WithEvents BArtistMostListened As Button
    Friend WithEvents BTimeUsingApplication As Button
    Friend WithEvents BPlaybacksFavArtist As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
