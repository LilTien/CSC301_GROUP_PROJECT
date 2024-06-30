<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeanieSeat
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
        Me.lblScreen = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblScreen
        '
        Me.lblScreen.BackColor = System.Drawing.Color.Gainsboro
        Me.lblScreen.Font = New System.Drawing.Font("Norwester", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScreen.ForeColor = System.Drawing.Color.White
        Me.lblScreen.Location = New System.Drawing.Point(-29, 15)
        Me.lblScreen.Name = "lblScreen"
        Me.lblScreen.Size = New System.Drawing.Size(2140, 55)
        Me.lblScreen.TabIndex = 3
        Me.lblScreen.Text = "Screen"
        Me.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(62, 907)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(190, 71)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Malgun Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotal.Location = New System.Drawing.Point(1666, 825)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(264, 50)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total: RM 0.00"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1729, 910)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(190, 71)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'BeanieSeat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblScreen)
        Me.Name = "BeanieSeat"
        Me.Text = "BeanieSeat"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScreen As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnNext As Button
End Class
