<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BSelect = New System.Windows.Forms.Button()
        Me.BConnect = New System.Windows.Forms.Button()
        Me.BManagement = New System.Windows.Forms.Button()
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.BChangeUser = New System.Windows.Forms.Button()
        Me.LoginText = New System.Windows.Forms.TextBox()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BMyMuisc = New System.Windows.Forms.Button()
        Me.BFavourites = New System.Windows.Forms.Button()
        Me.BPlay = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BPlayBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BQuerys = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BSelect
        '
        Me.BSelect.BackColor = System.Drawing.Color.Tomato
        Me.BSelect.Location = New System.Drawing.Point(52, 256)
        Me.BSelect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BSelect.Name = "BSelect"
        Me.BSelect.Size = New System.Drawing.Size(125, 52)
        Me.BSelect.TabIndex = 0
        Me.BSelect.Text = "Select"
        Me.BSelect.UseVisualStyleBackColor = False
        '
        'BConnect
        '
        Me.BConnect.BackColor = System.Drawing.Color.Tomato
        Me.BConnect.Enabled = False
        Me.BConnect.Location = New System.Drawing.Point(221, 256)
        Me.BConnect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BConnect.Name = "BConnect"
        Me.BConnect.Size = New System.Drawing.Size(140, 52)
        Me.BConnect.TabIndex = 1
        Me.BConnect.Text = "Connect"
        Me.BConnect.UseVisualStyleBackColor = False
        '
        'BManagement
        '
        Me.BManagement.BackColor = System.Drawing.Color.Tomato
        Me.BManagement.Enabled = False
        Me.BManagement.Location = New System.Drawing.Point(471, 55)
        Me.BManagement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BManagement.Name = "BManagement"
        Me.BManagement.Size = New System.Drawing.Size(165, 41)
        Me.BManagement.TabIndex = 2
        Me.BManagement.Text = "Management"
        Me.BManagement.UseVisualStyleBackColor = False
        '
        'ofdPath
        '
        Me.ofdPath.FileName = "ofdPath"
        '
        'BChangeUser
        '
        Me.BChangeUser.BackColor = System.Drawing.Color.Tomato
        Me.BChangeUser.Enabled = False
        Me.BChangeUser.Location = New System.Drawing.Point(471, 302)
        Me.BChangeUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BChangeUser.Name = "BChangeUser"
        Me.BChangeUser.Size = New System.Drawing.Size(165, 30)
        Me.BChangeUser.TabIndex = 3
        Me.BChangeUser.Text = "Change User"
        Me.BChangeUser.UseVisualStyleBackColor = False
        '
        'LoginText
        '
        Me.LoginText.Enabled = False
        Me.LoginText.Location = New System.Drawing.Point(89, 147)
        Me.LoginText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LoginText.Name = "LoginText"
        Me.LoginText.Size = New System.Drawing.Size(225, 22)
        Me.LoginText.TabIndex = 4
        '
        'BLogin
        '
        Me.BLogin.BackColor = System.Drawing.Color.Tomato
        Me.BLogin.Enabled = False
        Me.BLogin.Location = New System.Drawing.Point(159, 187)
        Me.BLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(76, 32)
        Me.BLogin.TabIndex = 5
        Me.BLogin.Text = "Login"
        Me.BLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Email"
        '
        'BMyMuisc
        '
        Me.BMyMuisc.BackColor = System.Drawing.Color.Tomato
        Me.BMyMuisc.Enabled = False
        Me.BMyMuisc.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BMyMuisc.Location = New System.Drawing.Point(471, 100)
        Me.BMyMuisc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BMyMuisc.Name = "BMyMuisc"
        Me.BMyMuisc.Size = New System.Drawing.Size(165, 32)
        Me.BMyMuisc.TabIndex = 7
        Me.BMyMuisc.Text = "MyMusic"
        Me.BMyMuisc.UseVisualStyleBackColor = False
        '
        'BFavourites
        '
        Me.BFavourites.BackColor = System.Drawing.Color.Tomato
        Me.BFavourites.Enabled = False
        Me.BFavourites.Location = New System.Drawing.Point(471, 136)
        Me.BFavourites.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BFavourites.Name = "BFavourites"
        Me.BFavourites.Size = New System.Drawing.Size(165, 33)
        Me.BFavourites.TabIndex = 8
        Me.BFavourites.Text = "Favourites"
        Me.BFavourites.UseVisualStyleBackColor = False
        '
        'BPlay
        '
        Me.BPlay.BackColor = System.Drawing.Color.Tomato
        Me.BPlay.Enabled = False
        Me.BPlay.Location = New System.Drawing.Point(471, 170)
        Me.BPlay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BPlay.Name = "BPlay"
        Me.BPlay.Size = New System.Drawing.Size(165, 32)
        Me.BPlay.TabIndex = 9
        Me.BPlay.Text = "Play"
        Me.BPlay.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.Location = New System.Drawing.Point(652, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 29)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(607, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 29)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BPlayBack
        '
        Me.BPlayBack.BackColor = System.Drawing.Color.Tomato
        Me.BPlayBack.Enabled = False
        Me.BPlayBack.Location = New System.Drawing.Point(471, 206)
        Me.BPlayBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BPlayBack.Name = "BPlayBack"
        Me.BPlayBack.Size = New System.Drawing.Size(165, 32)
        Me.BPlayBack.TabIndex = 12
        Me.BPlayBack.Text = "PlayBack"
        Me.BPlayBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Matura MT Script Capitals", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 79)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Songify"
        '
        'BQuerys
        '
        Me.BQuerys.BackColor = System.Drawing.Color.Tomato
        Me.BQuerys.Enabled = False
        Me.BQuerys.Location = New System.Drawing.Point(471, 243)
        Me.BQuerys.Name = "BQuerys"
        Me.BQuerys.Size = New System.Drawing.Size(165, 32)
        Me.BQuerys.TabIndex = 14
        Me.BQuerys.Text = "Querys"
        Me.BQuerys.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(715, 374)
        Me.Controls.Add(Me.BQuerys)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BPlayBack)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BPlay)
        Me.Controls.Add(Me.BFavourites)
        Me.Controls.Add(Me.BMyMuisc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(Me.LoginText)
        Me.Controls.Add(Me.BChangeUser)
        Me.Controls.Add(Me.BManagement)
        Me.Controls.Add(Me.BConnect)
        Me.Controls.Add(Me.BSelect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BSelect As Button
    Friend WithEvents BConnect As Button
    Friend WithEvents BManagement As Button
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents BChangeUser As Button
    Friend WithEvents LoginText As TextBox
    Friend WithEvents BLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BMyMuisc As Button
    Friend WithEvents BFavourites As Button
    Friend WithEvents BPlay As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BPlayBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BQuerys As Button
End Class
