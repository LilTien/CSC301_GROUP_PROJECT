Imports System.Data.OleDb
Imports System.IO.Ports
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Fnb

    Const popcornPrice As Decimal = 15.0
    Const mineralPrice As Decimal = 3.0
    Const sodaPrice As Decimal = 5.0
    Const nuggetPrice As Decimal = 8.0
    Const hotdogPrice As Decimal = 7.0
    Private fnbReceiptID As String = standardSeat.receiptID
    Private decTotalPrice As Decimal = standardSeat.totalCost
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alif\Documents\GroupProject.accdb;Persist Security Info=False;"
    Public selectedSeat As List(Of String) = standardSeat.selectedSeats
    Public receiptID As String = standardSeat.receiptID
    Public time As Integer = standardSeat.time
    Public roomID As Integer = standardSeat.roomID
    Public theaterID As Integer = standardSeat.theaterID

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        RealPayment.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPrice.Text = "PRICE : RM 0.00"
        lblTotal.Text = $"TOTAL : {decTotalPrice.ToString("c2")}"
        Me.Text = "FNB ORDER"
        Me.Size = New Size(1920, 1080)
        Me.StartPosition = FormStartPosition.CenterScreen


    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim itemName, itemID As String
        Dim decPrice As Decimal
        If radSalt.Checked Then
            decTotalPrice += popcornPrice
            decPrice = popcornPrice
            itemName = "salted popcorn"
            itemID = "spc"
        ElseIf radCaremel.Checked Then
            decTotalPrice += popcornPrice
            decPrice = popcornPrice
            itemName = "caremel popcorn"
            itemID = "cpc"
        ElseIf radMineral.Checked Then
            decTotalPrice += mineralPrice
            decPrice = mineralPrice
            itemName = "mineral"
            itemID = "min"
        ElseIf radSoda.Checked Then
            decTotalPrice += sodaPrice
            decPrice = sodaPrice
            itemName = "soda"
            itemID = "sod"
        ElseIf radNugget.Checked Then
            decTotalPrice += nuggetPrice
            decPrice = nuggetPrice
            itemName = "nugget"
            itemID = "nug"
        ElseIf radHotDog.Checked Then
            decTotalPrice += hotdogPrice
            decPrice = hotdogPrice
            itemName = "hot dog"
            itemID = "htd"
        Else
            itemName = ""
            itemID = ""
        End If

        addItem(decPrice, itemName, itemID)
        updateTotal()
    End Sub
    Private Sub updateTotal()
        lblTotal.Text = $"TOTAL: {decTotalPrice.ToString("c2")}"
    End Sub

    Private Sub addItem(ByVal price As Decimal, ByVal itemName As String, ByVal itemID As String)
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Try
                Dim command As String = "INSERT INTO SALES_LINE (RECEIPT_ID, ITEM, PRICE, ITEM_ID, SUCCESS) VALUES (@RECEIPT_ID, @ITEM, @PRICE, @ITEM_ID, False)"
                Dim cmd As New OleDbCommand(command, conn)
                cmd.Parameters.AddWithValue("@RECEIPT_ID", receiptID)
                cmd.Parameters.AddWithValue("@ITEM", itemName)
                cmd.Parameters.AddWithValue("@PRICE", price)
                cmd.Parameters.AddWithValue("@ITEM_ID", itemID)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error updating insert item in cart: " & ex.Message)
            End Try
            conn.Close()
        End Using
    End Sub

    Private Sub radSalt_CheckedChanged(sender As Object, e As EventArgs) Handles radSalt.CheckedChanged
        lblPrice.Text = $"PRICE: {popcornPrice.ToString("c2")}"
    End Sub

    Private Sub radCaremel_CheckedChanged(sender As Object, e As EventArgs) Handles radCaremel.CheckedChanged
        lblPrice.Text = $"PRICE: {popcornPrice.ToString("c2")}"
    End Sub

    Private Sub radMineral_CheckedChanged(sender As Object, e As EventArgs) Handles radMineral.CheckedChanged
        lblPrice.Text = $"PRICE: {mineralPrice.ToString("c2")}"
    End Sub

    Private Sub radSoda_CheckedChanged(sender As Object, e As EventArgs) Handles radSoda.CheckedChanged
        lblPrice.Text = $"PRICE: {sodaPrice.ToString("c2")}"
    End Sub

    Private Sub radNugget_CheckedChanged(sender As Object, e As EventArgs) Handles radNugget.CheckedChanged
        lblPrice.Text = $"PRICE: {nuggetPrice.ToString("c2")}"
    End Sub

    Private Sub radHotDog_CheckedChanged(sender As Object, e As EventArgs) Handles radHotDog.CheckedChanged
        lblPrice.Text = $"PRICE: {hotdogPrice.ToString("c2")}"
    End Sub
    Private Sub cancelSalesLine()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            For Each seat As String In selectedSeat

                Try
                    Dim command As String = "DELETE FROM SALES_LINE WHERE RECEIPT_ID = @RECEIPT_ID"
                    Dim cmd As New OleDbCommand(command, conn)
                    cmd.Parameters.AddWithValue("@RECEIPT_ID", receiptID)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show($"Error updating seat {seat}: {ex.Message}")
                End Try
            Next
            conn.Close()
        End Using
    End Sub
    Public Sub cancelReserve()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            For Each seat As String In selectedSeat
                MessageBox.Show(time)
                MessageBox.Show(roomID)
                MessageBox.Show(theaterID)
                Try
                    Dim command As String = "UPDATE SEAT SET RESERVE = False WHERE SEAT_NUM = @SEAT_NUM AND TIME = @TIME AND ROOM_ID = @ROOM_ID AND THEATER_ID = @THEATER_ID"
                    Dim cmd As New OleDbCommand(command, conn)
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cancelReserve()
        cancelSalesLine()
        HomePage.Show()
        Me.Close()
    End Sub
End Class
