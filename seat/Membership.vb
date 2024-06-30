Imports System.Data.OleDb

Public Class Membership
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alif\Documents\GroupProject.accdb;Persist Security Info=False;"
    Private dblMembershipCost As Double = 20.0

    Dim currentDate As Date = Today
    Dim strDate As String = currentDate.ToString("dd/MM/yy")

    Private registedEmail As New List(Of String)

    Private Sub SaveDataToDatabase(name As String, phoneNumber As String, email As String)
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO MEMBERSHIP (MEMBER_NAME, PHONE_NUM, EMAIL,JOIN_DATE) VALUES (@MEMBER_ID, @PHONE_NUMBER, @EMAIL, @JOIN_DATE)", conn)
            cmd.Parameters.AddWithValue("@MEMBER_NAME", name)
            cmd.Parameters.AddWithValue("@PHONE_NUMBER", phoneNumber)
            cmd.Parameters.AddWithValue("@EMAIL", email)
            cmd.Parameters.AddWithValue("@JOIN_DATE", strDate)

            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HomePage.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckMembership()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim custName As String = txtName.Text
        Dim strCustEmail As String = txtEmail.Text
        Dim strPhoneNumber As String = txtPhoneNumber.Text


        If registedEmail.Contains(strCustEmail.ToUpper) Then
            MessageBox.Show("Email already have bajunid")
        Else
            SaveDataToDatabase(custName, strPhoneNumber, strCustEmail)
            MessageBox.Show("You have become a member !!!")
        End If

    End Sub

    Private Sub CheckMembership()
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT EMAIL FROM MEMBERSHIP ", conn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    registedEmail.Add(reader("EMAIL").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading membership: " & ex.Message)
        End Try
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
