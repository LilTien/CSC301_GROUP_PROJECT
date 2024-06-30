<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealPayment
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblVoucherDiscount = New System.Windows.Forms.Label()
        Me.lblMemberDiscount = New System.Windows.Forms.Label()
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radCard = New System.Windows.Forms.RadioButton()
        Me.radEwallet = New System.Windows.Forms.RadioButton()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtVoucher = New System.Windows.Forms.TextBox()
        Me.txtMemberCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox3.Controls.Add(Me.lblVoucherDiscount)
        Me.GroupBox3.Controls.Add(Me.lblMemberDiscount)
        Me.GroupBox3.Controls.Add(Me.lblTotals)
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.lstItem)
        Me.GroupBox3.Controls.Add(Me.btnPay)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(77, 658)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1755, 314)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'lblVoucherDiscount
        '
        Me.lblVoucherDiscount.AutoSize = True
        Me.lblVoucherDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoucherDiscount.ForeColor = System.Drawing.Color.White
        Me.lblVoucherDiscount.Location = New System.Drawing.Point(1070, 179)
        Me.lblVoucherDiscount.Name = "lblVoucherDiscount"
        Me.lblVoucherDiscount.Size = New System.Drawing.Size(167, 25)
        Me.lblVoucherDiscount.TabIndex = 6
        Me.lblVoucherDiscount.Text = "Voucher Discount"
        '
        'lblMemberDiscount
        '
        Me.lblMemberDiscount.AutoSize = True
        Me.lblMemberDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberDiscount.ForeColor = System.Drawing.Color.White
        Me.lblMemberDiscount.Location = New System.Drawing.Point(1077, 222)
        Me.lblMemberDiscount.Name = "lblMemberDiscount"
        Me.lblMemberDiscount.Size = New System.Drawing.Size(168, 25)
        Me.lblMemberDiscount.TabIndex = 5
        Me.lblMemberDiscount.Text = "Member discount:"
        '
        'lblTotals
        '
        Me.lblTotals.AutoSize = True
        Me.lblTotals.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotals.ForeColor = System.Drawing.Color.White
        Me.lblTotals.Location = New System.Drawing.Point(1162, 263)
        Me.lblTotals.Name = "lblTotals"
        Me.lblTotals.Size = New System.Drawing.Size(93, 32)
        Me.lblTotals.TabIndex = 4
        Me.lblTotals.Text = "Total: "
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1567, 214)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(139, 37)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lstItem
        '
        Me.lstItem.BackColor = System.Drawing.Color.Gray
        Me.lstItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.ItemHeight = 29
        Me.lstItem.Location = New System.Drawing.Point(34, 61)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(1015, 207)
        Me.lstItem.TabIndex = 2
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(1567, 261)
        Me.btnPay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(139, 37)
        Me.btnPay.TabIndex = 1
        Me.btnPay.Text = "PAY"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(25, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "YOUR ITEM"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.radCard)
        Me.GroupBox2.Controls.Add(Me.radEwallet)
        Me.GroupBox2.Controls.Add(Me.radCash)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(1422, 79)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(409, 565)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'radCard
        '
        Me.radCard.AutoSize = True
        Me.radCard.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radCard.Location = New System.Drawing.Point(29, 142)
        Me.radCard.Margin = New System.Windows.Forms.Padding(4)
        Me.radCard.Name = "radCard"
        Me.radCard.Size = New System.Drawing.Size(81, 25)
        Me.radCard.TabIndex = 1
        Me.radCard.TabStop = True
        Me.radCard.Text = "CARD"
        Me.radCard.UseVisualStyleBackColor = True
        '
        'radEwallet
        '
        Me.radEwallet.AutoSize = True
        Me.radEwallet.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEwallet.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radEwallet.Location = New System.Drawing.Point(29, 102)
        Me.radEwallet.Margin = New System.Windows.Forms.Padding(4)
        Me.radEwallet.Name = "radEwallet"
        Me.radEwallet.Size = New System.Drawing.Size(109, 25)
        Me.radEwallet.TabIndex = 1
        Me.radEwallet.TabStop = True
        Me.radEwallet.Text = "E-WALLET"
        Me.radEwallet.UseVisualStyleBackColor = True
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCash.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radCash.Location = New System.Drawing.Point(29, 63)
        Me.radCash.Margin = New System.Windows.Forms.Padding(4)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(78, 25)
        Me.radCash.TabIndex = 1
        Me.radCash.TabStop = True
        Me.radCash.Text = "CASH"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(8, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "PAYMENT TYPE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.btnEnter)
        Me.GroupBox1.Controls.Add(Me.txtVoucher)
        Me.GroupBox1.Controls.Add(Me.txtMemberCode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Location = New System.Drawing.Point(79, 66)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1305, 582)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAYMENT"
        '
        'txtVoucher
        '
        Me.txtVoucher.BackColor = System.Drawing.Color.DarkGray
        Me.txtVoucher.Location = New System.Drawing.Point(208, 161)
        Me.txtVoucher.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(497, 37)
        Me.txtVoucher.TabIndex = 1
        '
        'txtMemberCode
        '
        Me.txtMemberCode.BackColor = System.Drawing.Color.DarkGray
        Me.txtMemberCode.Location = New System.Drawing.Point(192, 70)
        Me.txtMemberCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMemberCode.Name = "txtMemberCode"
        Me.txtMemberCode.Size = New System.Drawing.Size(511, 37)
        Me.txtMemberCode.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 170)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "VOUCHER CODE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(48, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "MEMBER CODE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(24, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Detail"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(1115, 509)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(139, 37)
        Me.btnEnter.TabIndex = 7
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'RealPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RealPayment"
        Me.Text = "RealPayment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lstItem As ListBox
    Friend WithEvents btnPay As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radCard As RadioButton
    Friend WithEvents radEwallet As RadioButton
    Friend WithEvents radCash As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtVoucher As TextBox
    Friend WithEvents txtMemberCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotals As Label
    Friend WithEvents lblVoucherDiscount As Label
    Friend WithEvents lblMemberDiscount As Label
    Friend WithEvents btnEnter As Button
End Class
