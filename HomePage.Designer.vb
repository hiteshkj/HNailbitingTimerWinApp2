<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
    ''' <summary>
    ''' 
    ''' </summary>
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CurrentStartTimeLabel = New System.Windows.Forms.Label()
        Me.Lasttimerdurlabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.StatsGBox = New System.Windows.Forms.GroupBox()
        Me.nooftrieslabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1Label = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DBStatusLabel = New System.Windows.Forms.Label()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.StatsGBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Timer - "
        '
        'TimerLabel
        '
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLabel.Location = New System.Drawing.Point(50, 8)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(0, 19)
        Me.TimerLabel.TabIndex = 1
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(6, 28)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(175, 36)
        Me.ResetButton.TabIndex = 2
        Me.ResetButton.Text = "Reset Timer"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Reset on - "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Last Timer duration - "
        '
        'CurrentStartTimeLabel
        '
        Me.CurrentStartTimeLabel.AutoSize = True
        Me.CurrentStartTimeLabel.ForeColor = System.Drawing.Color.Black
        Me.CurrentStartTimeLabel.Location = New System.Drawing.Point(84, 16)
        Me.CurrentStartTimeLabel.Name = "CurrentStartTimeLabel"
        Me.CurrentStartTimeLabel.Size = New System.Drawing.Size(95, 13)
        Me.CurrentStartTimeLabel.TabIndex = 6
        Me.CurrentStartTimeLabel.Text = "Enter the start time"
        '
        'Lasttimerdurlabel
        '
        Me.Lasttimerdurlabel.AutoSize = True
        Me.Lasttimerdurlabel.ForeColor = System.Drawing.Color.Black
        Me.Lasttimerdurlabel.Location = New System.Drawing.Point(106, 36)
        Me.Lasttimerdurlabel.Name = "Lasttimerdurlabel"
        Me.Lasttimerdurlabel.Size = New System.Drawing.Size(86, 13)
        Me.Lasttimerdurlabel.TabIndex = 8
        Me.Lasttimerdurlabel.Text = "Lasttimerdurlabel"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.No
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 97)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(662, 28)
        Me.ProgressBar1.TabIndex = 9
        '
        'StatsGBox
        '
        Me.StatsGBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatsGBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StatsGBox.Controls.Add(Me.nooftrieslabel)
        Me.StatsGBox.Controls.Add(Me.Label3)
        Me.StatsGBox.Controls.Add(Me.CurrentStartTimeLabel)
        Me.StatsGBox.Controls.Add(Me.Lasttimerdurlabel)
        Me.StatsGBox.Controls.Add(Me.Label2)
        Me.StatsGBox.Controls.Add(Me.Label4)
        Me.StatsGBox.ForeColor = System.Drawing.Color.Black
        Me.StatsGBox.Location = New System.Drawing.Point(363, 6)
        Me.StatsGBox.Name = "StatsGBox"
        Me.StatsGBox.Size = New System.Drawing.Size(305, 85)
        Me.StatsGBox.TabIndex = 10
        Me.StatsGBox.TabStop = False
        Me.StatsGBox.Text = "---------------------------------------- Stats ----------------------------------" &
    "----------"
        '
        'nooftrieslabel
        '
        Me.nooftrieslabel.AutoSize = True
        Me.nooftrieslabel.ForeColor = System.Drawing.Color.Black
        Me.nooftrieslabel.Location = New System.Drawing.Point(96, 59)
        Me.nooftrieslabel.Name = "nooftrieslabel"
        Me.nooftrieslabel.Size = New System.Drawing.Size(69, 13)
        Me.nooftrieslabel.TabIndex = 10
        Me.nooftrieslabel.Text = "nooftrieslabel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total # of tries - "
        '
        'ProgressBar1Label
        '
        Me.ProgressBar1Label.AutoSize = True
        Me.ProgressBar1Label.Location = New System.Drawing.Point(260, 104)
        Me.ProgressBar1Label.Name = "ProgressBar1Label"
        Me.ProgressBar1Label.Size = New System.Drawing.Size(96, 13)
        Me.ProgressBar1Label.TabIndex = 11
        Me.ProgressBar1Label.Text = "ProgressBar1Label"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(662, 113)
        Me.DataGridView1.TabIndex = 12
        '
        'DBStatusLabel
        '
        Me.DBStatusLabel.AutoSize = True
        Me.DBStatusLabel.Location = New System.Drawing.Point(6, 71)
        Me.DBStatusLabel.Name = "DBStatusLabel"
        Me.DBStatusLabel.Size = New System.Drawing.Size(78, 13)
        Me.DBStatusLabel.TabIndex = 13
        Me.DBStatusLabel.Text = "DBStatusLabel"
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(106, 66)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 14
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(674, 261)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.DBStatusLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ProgressBar1Label)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.TimerLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatsGBox)
        Me.Name = "HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.StatsGBox.ResumeLayout(False)
        Me.StatsGBox.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TimerLabel As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CurrentStartTimeLabel As Label
    Friend WithEvents Lasttimerdurlabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents StatsGBox As GroupBox
    Friend WithEvents ProgressBar1Label As Label
    Friend WithEvents nooftrieslabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DBStatusLabel As Label
    Friend WithEvents RefreshButton As Button
End Class
