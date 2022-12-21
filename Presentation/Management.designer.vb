<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management
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
        Me.BUpdate = New System.Windows.Forms.Button()
        Me.BInsert = New System.Windows.Forms.Button()
        Me.BDelete = New System.Windows.Forms.Button()
        Me.BView = New System.Windows.Forms.Button()
        Me.BLoad = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.minButton = New System.Windows.Forms.Button()
        Me.optionBox = New System.Windows.Forms.ComboBox()
        Me.managementTable1 = New System.Windows.Forms.ListBox()
        Me.labelManagement1 = New System.Windows.Forms.Label()
        Me.labelManagement2 = New System.Windows.Forms.Label()
        Me.labelManagement3 = New System.Windows.Forms.Label()
        Me.labelManagement4 = New System.Windows.Forms.Label()
        Me.textAtManagement1 = New System.Windows.Forms.TextBox()
        Me.textAtManagement2 = New System.Windows.Forms.TextBox()
        Me.textAtManagement3 = New System.Windows.Forms.TextBox()
        Me.textAtManagement4 = New System.Windows.Forms.TextBox()
        Me.labelTable1 = New System.Windows.Forms.Label()
        Me.labelManagement5 = New System.Windows.Forms.Label()
        Me.textAtManagement5 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BUpdate
        '
        Me.BUpdate.BackColor = System.Drawing.Color.Tomato
        Me.BUpdate.Enabled = False
        Me.BUpdate.Location = New System.Drawing.Point(250, 484)
        Me.BUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BUpdate.Name = "BUpdate"
        Me.BUpdate.Size = New System.Drawing.Size(116, 66)
        Me.BUpdate.TabIndex = 13
        Me.BUpdate.Text = "Update"
        Me.BUpdate.UseVisualStyleBackColor = False
        '
        'BInsert
        '
        Me.BInsert.BackColor = System.Drawing.Color.Tomato
        Me.BInsert.Enabled = False
        Me.BInsert.Location = New System.Drawing.Point(446, 484)
        Me.BInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.BInsert.Name = "BInsert"
        Me.BInsert.Size = New System.Drawing.Size(116, 66)
        Me.BInsert.TabIndex = 14
        Me.BInsert.Text = "Insert"
        Me.BInsert.UseVisualStyleBackColor = False
        '
        'BDelete
        '
        Me.BDelete.BackColor = System.Drawing.Color.Tomato
        Me.BDelete.Enabled = False
        Me.BDelete.Location = New System.Drawing.Point(647, 484)
        Me.BDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(116, 66)
        Me.BDelete.TabIndex = 15
        Me.BDelete.Text = "Delete"
        Me.BDelete.UseVisualStyleBackColor = False
        '
        'BView
        '
        Me.BView.BackColor = System.Drawing.Color.Tomato
        Me.BView.Location = New System.Drawing.Point(51, 484)
        Me.BView.Margin = New System.Windows.Forms.Padding(4)
        Me.BView.Name = "BView"
        Me.BView.Size = New System.Drawing.Size(116, 66)
        Me.BView.TabIndex = 22
        Me.BView.Text = "View"
        Me.BView.UseVisualStyleBackColor = False
        '
        'BLoad
        '
        Me.BLoad.BackColor = System.Drawing.Color.Tomato
        Me.BLoad.Location = New System.Drawing.Point(48, 419)
        Me.BLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.BLoad.Name = "BLoad"
        Me.BLoad.Size = New System.Drawing.Size(715, 35)
        Me.BLoad.TabIndex = 1
        Me.BLoad.Text = "Load"
        Me.BLoad.UseVisualStyleBackColor = False
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Tomato
        Me.closeButton.Location = New System.Drawing.Point(763, 13)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(45, 39)
        Me.closeButton.TabIndex = 25
        Me.closeButton.Text = "x"
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'minButton
        '
        Me.minButton.BackColor = System.Drawing.Color.Tomato
        Me.minButton.Location = New System.Drawing.Point(710, 13)
        Me.minButton.Margin = New System.Windows.Forms.Padding(4)
        Me.minButton.Name = "minButton"
        Me.minButton.Size = New System.Drawing.Size(45, 39)
        Me.minButton.TabIndex = 24
        Me.minButton.Text = "-"
        Me.minButton.UseVisualStyleBackColor = False
        '
        'optionBox
        '
        Me.optionBox.FormattingEnabled = True
        Me.optionBox.Items.AddRange(New Object() {"Users", "Songs", "Albums", "Artists"})
        Me.optionBox.Location = New System.Drawing.Point(48, 39)
        Me.optionBox.Margin = New System.Windows.Forms.Padding(4)
        Me.optionBox.Name = "optionBox"
        Me.optionBox.Size = New System.Drawing.Size(256, 24)
        Me.optionBox.TabIndex = 0
        Me.optionBox.Text = "Option"
        '
        'managementTable1
        '
        Me.managementTable1.AccessibleName = ""
        Me.managementTable1.FormattingEnabled = True
        Me.managementTable1.ItemHeight = 16
        Me.managementTable1.Location = New System.Drawing.Point(48, 132)
        Me.managementTable1.Margin = New System.Windows.Forms.Padding(4)
        Me.managementTable1.Name = "managementTable1"
        Me.managementTable1.Size = New System.Drawing.Size(106, 260)
        Me.managementTable1.TabIndex = 17
        '
        'labelManagement1
        '
        Me.labelManagement1.AutoSize = True
        Me.labelManagement1.Location = New System.Drawing.Point(416, 138)
        Me.labelManagement1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelManagement1.Name = "labelManagement1"
        Me.labelManagement1.Size = New System.Drawing.Size(69, 17)
        Me.labelManagement1.TabIndex = 2
        Me.labelManagement1.Text = "Attribute1"
        Me.labelManagement1.Visible = False
        '
        'labelManagement2
        '
        Me.labelManagement2.AutoSize = True
        Me.labelManagement2.Location = New System.Drawing.Point(416, 202)
        Me.labelManagement2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelManagement2.Name = "labelManagement2"
        Me.labelManagement2.Size = New System.Drawing.Size(69, 17)
        Me.labelManagement2.TabIndex = 3
        Me.labelManagement2.Text = "Attribute2"
        Me.labelManagement2.Visible = False
        '
        'labelManagement3
        '
        Me.labelManagement3.AutoSize = True
        Me.labelManagement3.Location = New System.Drawing.Point(416, 260)
        Me.labelManagement3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelManagement3.Name = "labelManagement3"
        Me.labelManagement3.Size = New System.Drawing.Size(69, 17)
        Me.labelManagement3.TabIndex = 4
        Me.labelManagement3.Text = "Attribute3"
        Me.labelManagement3.Visible = False
        '
        'labelManagement4
        '
        Me.labelManagement4.AutoSize = True
        Me.labelManagement4.Location = New System.Drawing.Point(416, 322)
        Me.labelManagement4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelManagement4.Name = "labelManagement4"
        Me.labelManagement4.Size = New System.Drawing.Size(69, 17)
        Me.labelManagement4.TabIndex = 18
        Me.labelManagement4.Text = "Attribute4"
        Me.labelManagement4.Visible = False
        '
        'textAtManagement1
        '
        Me.textAtManagement1.Location = New System.Drawing.Point(539, 135)
        Me.textAtManagement1.Margin = New System.Windows.Forms.Padding(4)
        Me.textAtManagement1.Name = "textAtManagement1"
        Me.textAtManagement1.Size = New System.Drawing.Size(224, 22)
        Me.textAtManagement1.TabIndex = 10
        Me.textAtManagement1.Text = "-"
        Me.textAtManagement1.Visible = False
        '
        'textAtManagement2
        '
        Me.textAtManagement2.Location = New System.Drawing.Point(539, 199)
        Me.textAtManagement2.Margin = New System.Windows.Forms.Padding(4)
        Me.textAtManagement2.Name = "textAtManagement2"
        Me.textAtManagement2.Size = New System.Drawing.Size(224, 22)
        Me.textAtManagement2.TabIndex = 11
        Me.textAtManagement2.Text = "-"
        Me.textAtManagement2.Visible = False
        '
        'textAtManagement3
        '
        Me.textAtManagement3.Location = New System.Drawing.Point(539, 257)
        Me.textAtManagement3.Margin = New System.Windows.Forms.Padding(4)
        Me.textAtManagement3.Name = "textAtManagement3"
        Me.textAtManagement3.Size = New System.Drawing.Size(224, 22)
        Me.textAtManagement3.TabIndex = 12
        Me.textAtManagement3.Text = "-"
        Me.textAtManagement3.Visible = False
        '
        'textAtManagement4
        '
        Me.textAtManagement4.Location = New System.Drawing.Point(539, 319)
        Me.textAtManagement4.Margin = New System.Windows.Forms.Padding(4)
        Me.textAtManagement4.Name = "textAtManagement4"
        Me.textAtManagement4.Size = New System.Drawing.Size(224, 22)
        Me.textAtManagement4.TabIndex = 19
        Me.textAtManagement4.Text = "-"
        Me.textAtManagement4.Visible = False
        '
        'labelTable1
        '
        Me.labelTable1.AutoSize = True
        Me.labelTable1.Location = New System.Drawing.Point(47, 94)
        Me.labelTable1.Name = "labelTable1"
        Me.labelTable1.Size = New System.Drawing.Size(82, 17)
        Me.labelTable1.TabIndex = 26
        Me.labelTable1.Text = "labelTable1"
        Me.labelTable1.Visible = False
        '
        'labelManagement5
        '
        Me.labelManagement5.AutoSize = True
        Me.labelManagement5.Location = New System.Drawing.Point(416, 373)
        Me.labelManagement5.Name = "labelManagement5"
        Me.labelManagement5.Size = New System.Drawing.Size(69, 17)
        Me.labelManagement5.TabIndex = 29
        Me.labelManagement5.Text = "Attribute5"
        Me.labelManagement5.Visible = False
        '
        'textAtManagement5
        '
        Me.textAtManagement5.Location = New System.Drawing.Point(539, 370)
        Me.textAtManagement5.Name = "textAtManagement5"
        Me.textAtManagement5.Size = New System.Drawing.Size(224, 22)
        Me.textAtManagement5.TabIndex = 30
        Me.textAtManagement5.Text = "-"
        Me.textAtManagement5.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(152, 132)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(197, 260)
        Me.ListBox1.TabIndex = 31
        '
        'Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(821, 572)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.textAtManagement5)
        Me.Controls.Add(Me.labelManagement5)
        Me.Controls.Add(Me.labelTable1)
        Me.Controls.Add(Me.BDelete)
        Me.Controls.Add(Me.BInsert)
        Me.Controls.Add(Me.BUpdate)
        Me.Controls.Add(Me.BView)
        Me.Controls.Add(Me.BLoad)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.minButton)
        Me.Controls.Add(Me.optionBox)
        Me.Controls.Add(Me.managementTable1)
        Me.Controls.Add(Me.labelManagement1)
        Me.Controls.Add(Me.labelManagement2)
        Me.Controls.Add(Me.labelManagement3)
        Me.Controls.Add(Me.labelManagement4)
        Me.Controls.Add(Me.textAtManagement1)
        Me.Controls.Add(Me.textAtManagement2)
        Me.Controls.Add(Me.textAtManagement3)
        Me.Controls.Add(Me.textAtManagement4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Management"
        Me.Text = "Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BUpdate As Button
    Friend WithEvents BInsert As Button
    Friend WithEvents BDelete As Button
    Friend WithEvents BView As Button
    Friend WithEvents BLoad As Button
    Friend WithEvents minButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents optionBox As ComboBox
    Friend WithEvents managementTable1 As ListBox
    Friend WithEvents labelManagement1 As Label
    Friend WithEvents labelManagement2 As Label
    Friend WithEvents labelManagement3 As Label
    Friend WithEvents labelManagement4 As Label
    Friend WithEvents textAtManagement1 As TextBox
    Friend WithEvents textAtManagement2 As TextBox
    Friend WithEvents textAtManagement3 As TextBox
    Friend WithEvents textAtManagement4 As TextBox
    Friend WithEvents labelTable1 As Label
    Friend WithEvents labelManagement5 As Label
    Friend WithEvents textAtManagement5 As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
