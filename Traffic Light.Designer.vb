<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrafficLight
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
        Me.txtGreenLight = New System.Windows.Forms.TextBox()
        Me.txtYellowLight = New System.Windows.Forms.TextBox()
        Me.txtRedLight = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtGreenLight
        '
        Me.txtGreenLight.BackColor = System.Drawing.Color.Gray
        Me.txtGreenLight.Location = New System.Drawing.Point(147, 375)
        Me.txtGreenLight.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGreenLight.Multiline = True
        Me.txtGreenLight.Name = "txtGreenLight"
        Me.txtGreenLight.Size = New System.Drawing.Size(125, 125)
        Me.txtGreenLight.TabIndex = 0
        '
        'txtYellowLight
        '
        Me.txtYellowLight.BackColor = System.Drawing.Color.Gray
        Me.txtYellowLight.Location = New System.Drawing.Point(147, 199)
        Me.txtYellowLight.Margin = New System.Windows.Forms.Padding(2)
        Me.txtYellowLight.Multiline = True
        Me.txtYellowLight.Name = "txtYellowLight"
        Me.txtYellowLight.Size = New System.Drawing.Size(125, 125)
        Me.txtYellowLight.TabIndex = 1
        '
        'txtRedLight
        '
        Me.txtRedLight.BackColor = System.Drawing.Color.Gray
        Me.txtRedLight.Location = New System.Drawing.Point(147, 23)
        Me.txtRedLight.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRedLight.Multiline = True
        Me.txtRedLight.Name = "txtRedLight"
        Me.txtRedLight.Size = New System.Drawing.Size(125, 125)
        Me.txtRedLight.TabIndex = 2
        '
        'frmTrafficLight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 554)
        Me.Controls.Add(Me.txtRedLight)
        Me.Controls.Add(Me.txtYellowLight)
        Me.Controls.Add(Me.txtGreenLight)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTrafficLight"
        Me.Text = "Traffic Light"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGreenLight As TextBox
    Friend WithEvents txtYellowLight As TextBox
    Friend WithEvents txtRedLight As TextBox
End Class
