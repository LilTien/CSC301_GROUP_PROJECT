Imports System.Data.OleDb

Public Class standardSeat
    Private rows As Integer
    Private columns As Integer
    Private seatCost As Integer
    Private seatButtons As New List(Of Button)
    Private rowNames As String() = {"A", "B", "C", "D"}
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alif\Documents\GroupProject.accdb;Persist Security Info=False;"
    Public roomID As Integer = Reserve.intRoomID ' Example room_id, adjust as necessary
    Private reservedSeats As New List(Of String) ' To store reserved seats
    Public totalCost As Decimal = 0
    Public time As Integer = Reserve.intTime
    Public theaterID As Integer = Reserve.intTheater
    Public itemID As String = roomID.ToString & theaterID.ToString & time.ToString()
    Private currentDate As DateTime = DateTime.Now
    Public receiptID As String = "01" & itemID & currentDate.Year.ToString() & currentDate.Month.ToString() & currentDate.Day.ToString() & currentDate.Hour.ToString() & currentDate.Minute.ToString() & currentDate.Second.ToString()
    Public selectedSeats As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties
        Me.Text = "Cinema Seat Booking"
        Me.Size = New Size(1920, 1080)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Load reserved seats from the database
        LoadReservedSeats()

        ' Create seat sections
        If roomID <= 4 And roomID > 0 Then
            rows = 4
            columns = 8
            seatCost = 20
            CreateSeatSection(370, 250, 1, 0, 60, 40)
        ElseIf roomID = 5 Then
            rows = 3
            columns = 6
            seatCost = 55
            CreateSeatSection(300, 250, 3, 0, 60, 40)
            CreateSeatSection(700, 250, 3, 2, 60, 40)
            CreateSeatSection(1100, 250, 3, 4, 60, 40)
        ElseIf roomID = 6 Then
            rows = 2
            columns = 3
            seatCost = 175
            CreateSeatSection(300, 250, 3, 0, 60, 100)
            CreateSeatSection(700, 250, 3, 1, 60, 100)
            CreateSeatSection(1100, 250, 3, 2, 60, 100)
        End If


        ' Initialize total cost label
        Dim lblTotal As New Label With {
            .Name = "lblTotal",
            .Text = $"RM{totalCost}",
            .Location = New Point(1700, 50),
            .Font = New Font("Arial", 16, FontStyle.Bold)
        }
        Me.Controls.Add(lblTotal)
    End Sub
    Public Sub LoadReservedSeats()
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT SEAT_NUM FROM SEAT WHERE ROOM_ID = @ROOM_ID AND RESERVE = True AND THEATER_ID = @THEATER_ID AND TIME = @TIME", conn)
                cmd.Parameters.AddWithValue("@ROOM_ID", roomID)
                cmd.Parameters.AddWithValue("@THEATER_ID", theaterID)
                cmd.Parameters.AddWithValue("@TIME", time)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    reservedSeats.Add(reader("SEAT_NUM").ToString())
                End While
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading reserved seats: " & ex.Message)
        End Try
    End Sub
    Private Sub CreateSeatSection(left As Integer, top As Integer, colTot As Integer, setSeat As Integer, btnHeight As Integer, btnPadding As Integer)
        Dim buttonWidth As Integer = 60
        Dim buttonHeight As Integer = btnHeight
        Dim padding As Integer = btnPadding

        For row As Integer = 0 To rows - 1
            For col As Integer = 0 To columns \ colTot - 1
                Dim seatButton As New Button()
                seatButton.Width = buttonWidth
                seatButton.Height = buttonHeight
                seatButton.Left = left + col * (buttonWidth + padding)
                seatButton.Top = top + row * (buttonHeight + padding)
                seatButton.Text = $"{rowNames(row)}{col + 1 + setSeat}"
                seatButton.BackColor = Color.Aqua

                If reservedSeats.Contains(seatButton.Text) Then
                    seatButton.BackColor = Color.Gray
                    seatButton.Enabled = False
                Else
                    seatButton.Tag = False ' False means not selected
                    AddHandler seatButton.Click, AddressOf SeatButton_Click
                End If
                ' Add the button to the form and the list
                Me.Controls.Add(seatButton)
                seatButtons.Add(seatButton)
            Next
        Next
    End Sub
    Private Sub SeatButton_Click(sender As Object, e As EventArgs)
        Dim seatButton As Button = CType(sender, Button)
        Dim isSelected As Boolean = CType(seatButton.Tag, Boolean)

        If isSelected Then
            seatButton.BackColor = Color.Aqua
            seatButton.Tag = False
            totalCost -= SeatCost
        Else
            seatButton.BackColor = Color.LightGreen
            seatButton.Tag = True
            totalCost += SeatCost
        End If
        updateCostLabel()
    End Sub
    Private Sub updateCostLabel()
        Dim lblTotal As Label = CType(Me.Controls("lblTotal"), Label)
        lblTotal.Text = $"RM{totalCost}"
    End Sub

    Public Sub SaveSeatsToDatabase()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            For Each seat As String In selectedSeats
                Try
                    Dim command As String = "UPDATE SEAT SET RESERVE = @RESERVE WHERE SEAT_NUM = @SEAT_NUM AND TIME = @TIME AND ROOM_ID = @ROOM_ID AND THEATER_ID = @THEATER_ID"
                    Dim cmd As New OleDbCommand(command, conn)
                    cmd.Parameters.AddWithValue("@RESERVE", True)
                    cmd.Parameters.AddWithValue("@SEAT_NUM", seat)
                    cmd.Parameters.AddWithValue("@TIME", time)
                    cmd.Parameters.AddWithValue("@ROOM_ID", roomID)
                    cmd.Parameters.AddWithValue("@THEATER_ID", theaterID)
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show($"Error updating seat {seat}: {ex.Message}")
                End Try
            Next
            conn.Close()
        End Using
    End Sub

    Private Sub btnNext_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click


        ' Iterate through the buttons to find selected seats
        For Each seatButton As Button In seatButtons
            If CType(seatButton.Tag, Boolean) = True Then
                selectedSeats.Add(seatButton.Text)
            End If
        Next

        ' Save the selected seats to the database
        If selectedSeats.Count > 0 Then
            SaveSeatsToDatabase()
            AddToSalesLine()
            Fnb.Show()
            Me.Close()
        Else
            MessageBox.Show("No seats selected")
        End If
    End Sub
    Private Sub AddToSalesLine()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            For Each seat As String In selectedSeats
                Try
                    Dim command As String = "INSERT INTO SALES_LINE (RECEIPT_ID, ITEM, PRICE, ITEM_ID, SUCCESS) VALUES (@RECEIPT_ID, @ITEM, @PRICE, @ITEM_ID, False)"
                    Dim cmd As New OleDbCommand(command, conn)
                    cmd.Parameters.AddWithValue("@RECEIPT_ID", receiptID)
                    cmd.Parameters.AddWithValue("@ITEM", seat)
                    cmd.Parameters.AddWithValue("@PRICE", seatCost)
                    cmd.Parameters.AddWithValue("@ITEM_ID", itemID)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error updating insert item in cart: " & ex.Message)
                End Try
            Next
            conn.Close()
        End Using

    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Reserve.Show()
        Me.Close()
    End Sub
End Class
