Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Payment
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alif\Documents\GroupProject.accdb;Persist Security Info=False;"
    Private receiptID As String = standardSeat.receiptID

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim strPaymentType, strName, strPhoneNo, strMemberCode, strVoucherCode As String
        strMemberCode = txtMemberCode.ToString
        strVoucherCode = txtVoucher.ToString

        Dim membership As Boolean = checkMembership(strMemberCode)
        PaymentType(strPaymentType)


    End Sub

    Private Function calcTotal() As Decimal
        Dim decTotal As Decimal = 0
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT PRICE FROM SALES_LINE WHERE RECEIPT_ID = @RECEIPT_ID", conn)
                cmd.Parameters.AddWithValue("@RECEIPT_ID", receiptID)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim price As Decimal
                    If Decimal.TryParse(reader("PRICE").ToString(), price) Then
                        decTotal += price
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error calculate total: " & ex.Message)
        End Try
        Return decTotal
    End Function

    Private Function checkMembership(ByVal memberCode As String) As Boolean
        Dim found As Boolean = False
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT ID FROM MEMBERSHIP ", conn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    If memberCode = reader("EMAIL").ToString() Then
                        found = True
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading membership: " & ex.Message)
        End Try
        Return found
    End Function


    Private Function PaymentType(ByRef strPaymentType)
        If radCard.Checked Then
            strPaymentType = "Card"
        ElseIf radCash.Checked Then
            strPaymentType = "Cash"
        ElseIf radEwallet.Checked Then
            strPaymentType = "E-Wallet"
        End If
    End Function

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Payment"
        Me.Size = New Size(1920, 1080)
        Me.StartPosition = FormStartPosition.CenterScreen
        Dim lblTotal As New Label With {
            .Name = "lblTotal",
            .Text = $"Total: {receiptID}",
            .Location = New Point(1700, 50),
            .Font = New Font("Arial", 16, FontStyle.Bold)
        }
        Me.Controls.Add(lblTotal)
    End Sub
End Class