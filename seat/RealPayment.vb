Imports System.Data.OleDb

Public Class RealPayment
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alif\Documents\GroupProject.accdb;Persist Security Info=False;"
    Private receiptID As String = Fnb.receiptID
    Const voucherID As String = "VOUCHER"
    Private totalPrice As Decimal
    Private voucherValid As Boolean
    Private memberName As String = "NA"
    Private memberID As Integer = 0
    Private time As Integer = Fnb.time
    Private theaterID As Integer = Fnb.theaterID
    Private roomID As Integer = Fnb.roomID
    Private selectedSeat As List(Of String) = Fnb.selectedSeat

    Private Sub RealPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Payment"
        Me.Size = New Size(1920, 1080)
        Me.StartPosition = FormStartPosition.CenterScreen
        totalPrice = calcTotal()
        lblTotals.Text = $"Total: {totalPrice.ToString("c2")}"
        LoadDataIntoListBox()
    End Sub

    Private Sub updateCostLabel()
        lblTotals.Text = $"TOTAL: {totalPrice.ToString("c2")}"
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim checkedPaymentType As Boolean = False
        Dim strPaymentType As String = String.Empty

        If radCard.Checked Then
            strPaymentType = "Card"
            checkedPaymentType = True
        ElseIf radCash.Checked Then
            strPaymentType = "Cash"
            checkedPaymentType = True
        ElseIf radEwallet.Checked Then
            strPaymentType = "E-Wallet"
            checkedPaymentType = True
        End If

        If checkedPaymentType Then
            saveSales(strPaymentType)
            approveSalesLine()
            MessageBox.Show("Thank you for coming, Please come again!")
            HomePage.Show()
            Me.Close()
        Else
            MessageBox.Show("Please choose a payment type")
        End If
    End Sub

    Private Sub approveSalesLine()
        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim command As String = "UPDATE SALES_LINE SET SUCCESS = True WHERE RECEIPT_ID = @RECEIPT_ID"
                Using cmd As New OleDbCommand(command, conn)
                    cmd.Parameters.AddWithValue("@RECEIPT_ID", receiptID)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error approving sales line: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Sub saveSales(ByVal strPaymentType As String)
        Dim currentDate As Date = Today
        Dim strDate As String = currentDate.ToString("dd/MM/yy")
        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New OleDbCommand("INSERT INTO SALES (RECEIPT_ID, TOTAL, MEMBER_NAME, DATE_PURCHASE, MEMBER_ID, PAYMENT) VALUES (@RECEIPT_ID, @TOTAL, @MEMBER_NAME, @DATE_PURCHASE, @MEMBER_ID, @PAYMENT)", conn)
                cmd.Parameters.AddWithValue("@RECEIPT_ID", receiptID)
                cmd.Parameters.AddWithValue("@TOTAL", totalPrice)
                cmd.Parameters.AddWithValue("@MEMBER_NAME", memberName)
                cmd.Parameters.AddWithValue("@DATE_PURCHASE", currentDate)
                cmd.Parameters.AddWithValue("@MEMBER_ID", memberID)
                cmd.Parameters.AddWithValue("@PAYMENT", strPaymentType)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error saving sales: " & ex.Message)
            End Try
            conn.Close()
        End Using
    End Sub

    Private Function calcTotal() As Decimal
        Dim decTotal As Decimal = 0
        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT PRICE FROM SALES_LINE WHERE RECEIPT_ID = @RECEIPT_ID", conn)
                cmd.Parameters.AddWithValue("@RECEIPT_ID", receiptID)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim price As Decimal
                        If Decimal.TryParse(reader("PRICE").ToString(), price) Then
                            decTotal += price
                        End If
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error calculating total: " & ex.Message)
            End Try
        End Using
        Return decTotal
    End Function

    Private Function checkMembership(ByVal memberCode As Integer) As Boolean
        Dim found As Boolean = False
        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT * FROM MEMBERSHIP WHERE ID = @MEMBER_CODE", conn)
                cmd.Parameters.AddWithValue("@MEMBER_CODE", memberCode)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        memberID = reader("ID")
                        memberName = reader("MEMBER_NAME").ToString()
                        found = True
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking membership: " & ex.Message)
            End Try
        End Using
        Return found
    End Function

    Private Sub LoadDataIntoListBox()
        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT * FROM SALES_LINE WHERE RECEIPT_ID = @RECEIPT_ID", conn)
                cmd.Parameters.AddWithValue("@RECEIPT_ID", receiptID)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    lstItem.Items.Clear() ' Clear existing items
                    While reader.Read()
                        lstItem.Items.Add($"{reader("ITEM")} RM{reader("PRICE")}.00")
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data into list: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function checkVoucher(ByVal voucher As String) As Boolean
        Return txtVoucher.Text = voucher
    End Function

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim memberIDCode As Integer
        voucherValid = checkVoucher(voucherID)
        Dim boolValid As Boolean = False
        Dim membership As Boolean
        If Integer.TryParse(txtMemberCode.Text, memberIDCode) Then
            membership = checkMembership(memberIDCode)
            Dim memberDiscount = calcTotal() * 0.1
            If membership Then
                lblMemberDiscount.Text = "Member discount:" & memberDiscount.ToString("c2")
                totalPrice -= memberDiscount
                boolValid = True
            End If
            updateCostLabel()
        End If
        If voucherValid Then
            lblVoucherDiscount.Text = "Voucher discount: " & (10).ToString("c2")
            totalPrice -= 10.0
            updateCostLabel()
            boolValid = True
        End If
        If boolValid Then
            If membership Then
                btnEnter.Enabled = False
            End If
        End If
    End Sub

    Private Sub deleteSalesLine()
        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New OleDbCommand("DELETE FROM SALES_LINE WHERE RECEIPT_ID = @RECEIPT_ID", conn)
                cmd.Parameters.AddWithValue("@RECEIPT_ID", receiptID)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Record deleted successfully.")
                Else
                    MessageBox.Show("No record found")
                End If
            Catch ex As Exception
                MessageBox.Show("Error deleting sales line: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub cancelReserve()
        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                For Each seat As String In selectedSeat
                    Dim command As String = "UPDATE SEAT SET RESERVE = False WHERE SEAT_NUM = @SEAT_NUM AND TIME = @TIME AND ROOM_ID = @ROOM_ID AND THEATER_ID = @THEATER_ID"
                    Using cmd As New OleDbCommand(command, conn)
                        cmd.Parameters.AddWithValue("@SEAT_NUM", seat)
                        cmd.Parameters.AddWithValue("@TIME", time)
                        cmd.Parameters.AddWithValue("@ROOM_ID", roomID)
                        cmd.Parameters.AddWithValue("@THEATER_ID", theaterID)
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            Catch ex As Exception
                MessageBox.Show($"Error updating seat reservation: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        deleteSalesLine()
        cancelReserve()
        HomePage.Show()
        Me.Close()
    End Sub
End Class
