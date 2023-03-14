<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblInternetSpeedSurv = New System.Windows.Forms.Label()
        Me.btnInternetSpeed = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAverageInt = New System.Windows.Forms.Label()
        Me.lstInternetSpeed = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblInternetSpeedSurv
        '
        Me.lblInternetSpeedSurv.AutoSize = True
        Me.lblInternetSpeedSurv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternetSpeedSurv.Location = New System.Drawing.Point(384, 57)
        Me.lblInternetSpeedSurv.Name = "lblInternetSpeedSurv"
        Me.lblInternetSpeedSurv.Size = New System.Drawing.Size(299, 25)
        Me.lblInternetSpeedSurv.TabIndex = 0
        Me.lblInternetSpeedSurv.Text = "Internet Speed Test Survey"
        '
        'btnInternetSpeed
        '
        Me.btnInternetSpeed.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnInternetSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInternetSpeed.ForeColor = System.Drawing.Color.Olive
        Me.btnInternetSpeed.Location = New System.Drawing.Point(434, 116)
        Me.btnInternetSpeed.Name = "btnInternetSpeed"
        Me.btnInternetSpeed.Size = New System.Drawing.Size(183, 53)
        Me.btnInternetSpeed.TabIndex = 1
        Me.btnInternetSpeed.Text = "Enter Internet Speed"
        Me.btnInternetSpeed.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(571, 366)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 27)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblAverageInt
        '
        Me.lblAverageInt.AutoSize = True
        Me.lblAverageInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageInt.Location = New System.Drawing.Point(429, 416)
        Me.lblAverageInt.Name = "lblAverageInt"
        Me.lblAverageInt.Size = New System.Drawing.Size(267, 25)
        Me.lblAverageInt.TabIndex = 3
        Me.lblAverageInt.Text = "Average Internet Speed:"
        '
        'lstInternetSpeed
        '
        Me.lstInternetSpeed.FormattingEnabled = True
        Me.lstInternetSpeed.Location = New System.Drawing.Point(657, 144)
        Me.lstInternetSpeed.Name = "lstInternetSpeed"
        Me.lstInternetSpeed.Size = New System.Drawing.Size(120, 199)
        Me.lstInternetSpeed.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Internet_Speed_Test_Survey.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstInternetSpeed)
        Me.Controls.Add(Me.lblAverageInt)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnInternetSpeed)
        Me.Controls.Add(Me.lblInternetSpeedSurv)
        Me.Name = "Form1"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInternetSpeedSurv As Label
    Friend WithEvents btnInternetSpeed As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAverageInt As Label
    Friend WithEvents lstInternetSpeed As ListBox
End Class
