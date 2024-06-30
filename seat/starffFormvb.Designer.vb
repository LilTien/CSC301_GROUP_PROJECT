<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class starffFormvb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClearRoom = New System.Windows.Forms.Button()
        Me.btnLockRoom = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClearRoom
        '
        Me.btnClearRoom.BackColor = System.Drawing.Color.IndianRed
        Me.btnClearRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearRoom.Location = New System.Drawing.Point(727, 227)
        Me.btnClearRoom.Name = "btnClearRoom"
        Me.btnClearRoom.Size = New System.Drawing.Size(448, 78)
        Me.btnClearRoom.TabIndex = 0
        Me.btnClearRoom.Text = "Clear Room"
        Me.btnClearRoom.UseVisualStyleBackColor = False
        '
        'btnLockRoom
        '
        Me.btnLockRoom.BackColor = System.Drawing.Color.RosyBrown
        Me.btnLockRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLockRoom.Location = New System.Drawing.Point(727, 364)
        Me.btnLockRoom.Name = "btnLockRoom"
        Me.btnLockRoom.Size = New System.Drawing.Size(448, 78)
        Me.btnLockRoom.TabIndex = 2
        Me.btnLockRoom.Text = "Lock Room"
        Me.btnLockRoom.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHome})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1902, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuHome
        '
        Me.menuHome.Name = "menuHome"
        Me.menuHome.Size = New System.Drawing.Size(64, 24)
        Me.menuHome.Text = "Home"
        '
        'starffFormvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.btnLockRoom)
        Me.Controls.Add(Me.btnClearRoom)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "starffFormvb"
        Me.Text = "starffFormvb"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClearRoom As Button
    Friend WithEvents btnLockRoom As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuHome As ToolStripMenuItem
End Class
