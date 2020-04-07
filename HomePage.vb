'Pending tasks
' 
'   4. Testing
'
'

Imports MySql.Data.MySqlClient
Public Class HomePage
    Dim ResetDate As Date = DateAndTime.Now()
    Dim Interval1 As Int64
    Dim RecordCount As Int64
    Dim Rowid As Int64
    Private ReadOnly con As New MySqlConnection(Login.strP)
    Private ReadOnly ds As New DataSet()

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        'MsgBox("Are you sure ?", vbQuestion + vbYesNo + vbDefaultButton2, "H Are you sure ?")
        If MsgBox("Are you sure3 ?", vbQuestion + vbYesNo + vbDefaultButton2, "H Are you sure ?") = vbYes Then
            CurrentStartTimeLabel.Text = Format(DateTime.Now(), "dddd, dd MMM yyyy hh:mm:ss tt")
            ResetDate = DateTime.Now()
            InsertDGV()
            LoadDGV()
            ProgressBar1.Value = ProgressBar1.Minimum
            DataGridView1.Columns("StartTS").DefaultCellStyle.Format = "dddd, dd MMM yyyy hh:mm:ss tt"
            RecordCount = DataGridView1.Rows.Count
            If RecordCount >= 2 Then
                Lasttimerdurlabel.Text = Sectodur(DateDiff(DateInterval.Second, ds.Tables("HNBMaster").Rows(1)("StartTS"), ds.Tables("HNBMaster").Rows(0)("StartTS")))
            End If
            nooftrieslabel.Text = RecordCount
            If RecordCount = 0 Then
                ResetButton.Text = "Start Timer"
            Else
                ResetButton.Text = "Reset Timer"
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Interval1 = DateDiff(DateInterval.Second, ResetDate, DateAndTime.Now())
        'MsgBox(Interval1 & " - " & ResetDate & " - " & DateAndTime.Now())
        TimerLabel.Text = Sectodur(Interval1)
        ProgressBar1.Increment(Interval1 / 2678400)
        ProgressBar1Label.Text = ((Interval1 / 2678400) * 100) & " % Complete"
        If con.Ping() = True Then
            DBStatusLabel.Text = "DB Connected"
        Else
            DBStatusLabel.Text = "DB DISConnected"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Startup()
        'DataGridView1.Update()
        LoadDGV()
        InitForm()
    End Sub

    Function InitForm()
        DataGridView1.Columns("StartTS").DefaultCellStyle.Format = "dddd, dd MMM yyyy hh:mm:ss tt"
        RecordCount = DataGridView1.Rows.Count
        'MsgBox(RecordCount)
        nooftrieslabel.Text = RecordCount

        If RecordCount = 0 Then
            Me.Text = "!!!! *** STOP NAIL BITING *** !!!!     |   App Start - " & DateAndTime.Now()
            Lasttimerdurlabel.Text = "Add records"
        Else
            ResetDate = ds.Tables("HNBMaster").Rows(0)("StartTS")
            CurrentStartTimeLabel.Text = Format(ds.Tables("HNBMaster").Rows(0)("StartTS"), "dddd, dd MMM yyyy hh:mm:ss tt")
            Me.Text = "!!!! *** STOP NAIL BITING *** !!!!     |   App Start - " & Format(ds.Tables("HNBMaster").Rows(RecordCount - 1)("StartTS"), "dddd, dd MMM yyyy hh:mm:ss tt")
            Lasttimerdurlabel.Text = Sectodur(DateDiff(DateInterval.Second, ds.Tables("HNBMaster").Rows(1)("StartTS"), ds.Tables("HNBMaster").Rows(0)("StartTS")))
        End If
        If RecordCount = 0 Then
            ResetButton.Text = "Start Timer"
        Else
            ResetButton.Text = "Reset Timer"
        End If
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths
    Function InsertDGV()
#Disable Warning IDE0017 ' Simplify object initialization
        Dim cmd As New MySqlCommand
#Enable Warning IDE0017 ' Simplify object initialization
        cmd.Connection = con
        Rowid = Convert.ToInt64(RecordCount) + 1
        'MsgBox(Rowid)
        cmd.CommandText = "INSERT INTO `HNBMaster` (`Row#`,`StartTS`) values ('" & Rowid & "',date_sub(Now(),interval 7 hour));"
        cmd.ExecuteNonQuery()
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths
    Function LoadDGV()
        DataGridView1.DataSource = Nothing
        Dim Adpt As New MySqlDataAdapter("Select * from `HNBMaster` order by `HNBMaster`.`Row#` DESC;", con)
        ds.Clear()
        Adpt.Fill(ds, "HNBMaster")
        DataGridView1.DataSource = ds.Tables(0)
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths
    Function Sectodur(var1 As Int64) As String
        Return (var1 \ 86400) & " Days " & (var1 \ 3600 Mod 24) & " Hours " & (var1 \ 60 Mod 60) & " Minutes " & (var1 Mod 60) & " Seconds."
    End Function

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
    Function Startup()
        Try
            con.Open()
        Catch ex As Exception
            MsgBox("Can't load" & vbCrLf & ex.Message)
            MsgBox("DB Login Failed, App will close now")
            Application.Exit()
        End Try
        If con.Ping() = True Then
            MsgBox("DB Login Pass")
        Else
            MsgBox("DB Login Failed, App will close now")
            Application.Exit()
        End If
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        LoadDGV()
        InitForm()
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Sub
#Enable Warning BC42105 ' Function doesn't return a value on all code paths
End Class
