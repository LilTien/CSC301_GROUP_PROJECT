Public Class HomePage
    Public intMovieChoosen As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMembership.Click
        Membership.Show()
        Me.Hide()

    End Sub

    Private Sub picFuriosa_Click(sender As Object, e As EventArgs) Handles picFuriosa.Click
        intMovieChoosen = 4
        Reserve.Show()
        Me.Hide()
    End Sub

    Private Sub picInsideOut_Click(sender As Object, e As EventArgs) Handles picInsideOut.Click
        intMovieChoosen = 3
        Reserve.Show()
        Me.Hide()
    End Sub

    Private Sub picBadBoys_Click(sender As Object, e As EventArgs) Handles picBadBoys.Click
        intMovieChoosen = 2
        Reserve.Show()
        Me.Hide()
    End Sub

    Private Sub pctCinderella_Click(sender As Object, e As EventArgs) Handles pctCinderella.Click
        intMovieChoosen = 1
        Reserve.Show()
        Me.Hide()
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.Sleep(1000)
    End Sub

    Const staffPassword As Integer = 12345678
    Private Sub StaffPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuHomeStaff.Click
        Dim strInsertPassword As String = InputBox("Enter password : ")
        Dim intStaffPassword As Integer
        If Integer.TryParse(strInsertPassword, intStaffPassword) Then
            If intStaffPassword = staffPassword Then
                starffFormvb.Show()
            Else
                MessageBox.Show("Wrong Password !!!")
            End If
        End If


    End Sub

    Private Sub menuAboutus_Click(sender As Object, e As EventArgs) Handles menuAboutus.Click
        Aboutus.Show()
    End Sub
End Class