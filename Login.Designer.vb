﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.DBNameTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UsernameTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PwdTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServerTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(304, 289)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(98, 49)
        Me.LoginButton.TabIndex = 5
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'DBNameTB
        '
        Me.DBNameTB.Location = New System.Drawing.Point(181, 229)
        Me.DBNameTB.Name = "DBNameTB"
        Me.DBNameTB.Size = New System.Drawing.Size(551, 20)
        Me.DBNameTB.TabIndex = 4
        Me.DBNameTB.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "DB Name - "
        Me.Label4.UseWaitCursor = True
        '
        'UsernameTB
        '
        Me.UsernameTB.Location = New System.Drawing.Point(181, 148)
        Me.UsernameTB.Name = "UsernameTB"
        Me.UsernameTB.Size = New System.Drawing.Size(551, 20)
        Me.UsernameTB.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Username - "
        '
        'PwdTB
        '
        Me.PwdTB.Location = New System.Drawing.Point(181, 185)
        Me.PwdTB.Name = "PwdTB"
        Me.PwdTB.Size = New System.Drawing.Size(551, 20)
        Me.PwdTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password - "
        '
        'ServerTB
        '
        Me.ServerTB.Location = New System.Drawing.Point(181, 112)
        Me.ServerTB.Name = "ServerTB"
        Me.ServerTB.Size = New System.Drawing.Size(551, 20)
        Me.ServerTB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Server - "
        '
        'Login2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.DBNameTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UsernameTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PwdTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ServerTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login2"
        Me.Text = "Login2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginButton As Button
    Friend WithEvents DBNameTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents UsernameTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PwdTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ServerTB As TextBox
    Friend WithEvents Label1 As Label
End Class
