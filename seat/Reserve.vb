Imports System.Security
Imports System.Security.Policy

Public Class Reserve
    Const strFirstImage As String = "C:\Users\Alif\Pictures\csc301 image\CinderellaCurse1.jpg"
    Const strSecondImage As String = "C:\Users\Alif\Pictures\Screenshots\Screenshot 2024-06-25 115724.png"
    Const strThirdImage As String = "C:\Users\Alif\Pictures\Screenshots\Screenshot 2024-06-24 231236.png"
    Const strForthImage As String = "C:\Users\Alif\Pictures\csc301 image\furiosa.png"

    Public intTheater As Integer
    Public intRoomID As Integer
    Public intTime As Integer

    Private intMovieChoosen As Integer = HomePage.intMovieChoosen
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Dim checkedAll As Boolean = True

        If radOneUtama.Checked Then
            intTheater = 1
        ElseIf radKLCC.Checked Then
            intTheater = 2
        Else
            checkedAll = False
        End If

        If radStandard.Checked Then
            intRoomID = intMovieChoosen
        ElseIf radPremiere.Checked Then
            intRoomID = 5
        ElseIf radBeanie.Checked Then
            intRoomID = 6
        Else
            checkedAll = False
        End If

        If rad10AM.Checked Then
            intTime = 10
        ElseIf rad12PM.Checked Then
            intTime = 12
        ElseIf rad2PM.Checked Then
            intTime = 14
        Else
            checkedAll = False
        End If

        If Not checkedAll Then
            MessageBox.Show("Do not leave the form blank!!!")
        Else
            standardSeat.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageLoad()
    End Sub
    Private Sub imageLoad()
        If intMovieChoosen = 1 Then
            PictureBox1.Image = Image.FromFile(strFirstImage)
            lblMovieName.Text = "Cinderella Curse"
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf intMovieChoosen = 2 Then
            PictureBox1.Image = Image.FromFile(strSecondImage)
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            lblMovieName.Text = ""
        ElseIf intMovieChoosen = 3 Then
            PictureBox1.Image = Image.FromFile(strThirdImage)
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            lblMovieName.Text = ""
        ElseIf intMovieChoosen = 4 Then
            PictureBox1.Image = Image.FromFile(strForthImage)
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            lblMovieName.Text = ""
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HomePage.Show()
        Me.Close()
    End Sub

    Private Sub radOneUtama_CheckedChanged(sender As Object, e As EventArgs) Handles radOneUtama.CheckedChanged
        If intMovieChoosen = 2 Then
            radPremiere.Visible = True
        ElseIf intMovieChoosen = 4 Then
            radBeanie.Visible = True
        Else
            radBeanie.Visible = False
            radPremiere.Visible = False
        End If
    End Sub

    Private Sub radKLCC_CheckedChanged(sender As Object, e As EventArgs) Handles radKLCC.CheckedChanged
        If intMovieChoosen = 1 Then
            radPremiere.Visible = True
        ElseIf intMovieChoosen = 3 Then
            radBeanie.Visible = True
        Else
            radBeanie.Visible = False
            radPremiere.Visible = False
        End If
    End Sub


End Class
