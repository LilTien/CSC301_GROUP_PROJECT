Imports System.Data.OleDb

Public Class starffFormvb

    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alif\Documents\GroupProject.accdb;Persist Security Info=False;"
    Private roomID As Integer = 1
    Private reservedSeats As New List(Of String)
    Private Sub starffFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClearRoom.Click
        Dim int_Ok As Boolean = True
        Dim roomID As Integer
        Dim theaterID As Integer
        Dim time As Integer
        Dim strRoomID As String = InputBox("Enter Room number: ")
        int_Ok = Integer.TryParse(strRoomID, roomID)
        If int_Ok Then
            Dim int_theater_Ok As Boolean = True
            Dim strTheaterID As String = InputBox("Enter theater number: ")
            int_theater_Ok = Integer.TryParse(strTheaterID, theaterID)
            If int_theater_Ok Then
                Dim int_time_ok As Boolean = True
                Dim strTime As String = InputBox("Enter time: ")
                int_time_ok = Integer.TryParse(strTime, time)
                If int_time_ok Then
                    ClearExpiredReservations(roomID, theaterID, time)
                End If
            End If
        End If
    End Sub
    Private Sub LoadReservedSeats()
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT SEAT_NUMBER FROM SEAT_TIME WHERE ROOM_ID = @ROOM_ID AND RESERVE = True", conn)
                cmd.Parameters.AddWithValue("@ROOM_ID", roomID)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    reservedSeats.Add(reader("SEAT_NUMBER").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading reserved seats: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearExpiredReservations(roomID As Integer, ByVal theaterID As Integer, ByVal time As Integer)
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Try
                Dim command As String = "UPDATE SEAT SET RESERVE = False WHERE ROOM_ID = @ROOM_ID AND THEATER_ID = @THEATER_ID AND TIME = @TIME"
                Dim cmd As New OleDbCommand(command, conn)
                cmd.Parameters.AddWithValue("@ROOM_ID", roomID)
                cmd.Parameters.AddWithValue("@THEATER_ID", theaterID)
                cmd.Parameters.AddWithValue("@TIME", time)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show($"Error clearing reservations: {ex.Message}")
            End Try
            conn.Close()
        End Using
    End Sub

    Private Sub btnLockRoom_Click(sender As Object, e As EventArgs) Handles btnLockRoom.Click
        Dim int_Ok As Boolean = True
        Dim int_theater_Ok As Boolean = True
        Dim int_time_ok As Boolean = True
        Dim roomID As Integer
        Dim theaterID As Integer
        Dim time As Integer

        Dim strRoomID As String = InputBox("Enter Room number: ")
        int_Ok = Integer.TryParse(strRoomID, roomID)
        If int_Ok Then
            Dim strTheaterID As String = InputBox("Enter theater number: ")
            int_theater_Ok = Integer.TryParse(strTheaterID, theaterID)
            Dim strTime As String = InputBox("Enter time: ")
            int_time_ok = Integer.TryParse(strTime, time)
            If int_time_ok Then
                Using conn As New OleDbConnection(connectionString)
                    conn.Open()
                    Try
                        Dim command As String = "UPDATE SEAT SET RESERVE = True WHERE ROOM_ID = @ROOM_ID AND THEATER_ID = @THEATER_ID AND TIME = @TIME"
                        Dim cmd As New OleDbCommand(command, conn)
                        cmd.Parameters.AddWithValue("@ROOM_ID", roomID)
                        cmd.Parameters.AddWithValue("@THEATER_ID", theaterID)
                        cmd.Parameters.AddWithValue("@TIME", time)
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show($"Error clearing reservations: {ex.Message}")
                    End Try
                End Using
            End If
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuHome.Click
        Me.Close()
    End Sub
End Class