<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class searchMapShow
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
        Me.zl3 = New System.Windows.Forms.PictureBox()
        Me.zl4 = New System.Windows.Forms.PictureBox()
        Me.zl2 = New System.Windows.Forms.PictureBox()
        Me.zl1 = New System.Windows.Forms.PictureBox()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.zl5 = New System.Windows.Forms.PictureBox()
        Me.backBut = New System.Windows.Forms.Button()
        CType(Me.zl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'zl3
        '
        Me.zl3.Location = New System.Drawing.Point(15, 282)
        Me.zl3.Name = "zl3"
        Me.zl3.Size = New System.Drawing.Size(401, 264)
        Me.zl3.TabIndex = 3
        Me.zl3.TabStop = False
        '
        'zl4
        '
        Me.zl4.Location = New System.Drawing.Point(422, 282)
        Me.zl4.Name = "zl4"
        Me.zl4.Size = New System.Drawing.Size(401, 264)
        Me.zl4.TabIndex = 4
        Me.zl4.TabStop = False
        '
        'zl2
        '
        Me.zl2.Location = New System.Drawing.Point(422, 12)
        Me.zl2.Name = "zl2"
        Me.zl2.Size = New System.Drawing.Size(401, 264)
        Me.zl2.TabIndex = 5
        Me.zl2.TabStop = False
        '
        'zl1
        '
        Me.zl1.Location = New System.Drawing.Point(15, 12)
        Me.zl1.Name = "zl1"
        Me.zl1.Size = New System.Drawing.Size(401, 264)
        Me.zl1.TabIndex = 6
        Me.zl1.TabStop = False
        '
        'statusLabel
        '
        Me.statusLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Location = New System.Drawing.Point(12, 554)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(0, 13)
        Me.statusLabel.TabIndex = 7
        '
        'zl5
        '
        Me.zl5.Location = New System.Drawing.Point(12, 12)
        Me.zl5.Name = "zl5"
        Me.zl5.Size = New System.Drawing.Size(811, 555)
        Me.zl5.TabIndex = 8
        Me.zl5.TabStop = False
        Me.zl5.Visible = False
        '
        'backBut
        '
        Me.backBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.backBut.Location = New System.Drawing.Point(12, 592)
        Me.backBut.Name = "backBut"
        Me.backBut.Size = New System.Drawing.Size(75, 23)
        Me.backBut.TabIndex = 9
        Me.backBut.Text = "Back"
        Me.backBut.UseVisualStyleBackColor = True
        '
        'searchMapShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 627)
        Me.Controls.Add(Me.backBut)
        Me.Controls.Add(Me.zl5)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.zl1)
        Me.Controls.Add(Me.zl2)
        Me.Controls.Add(Me.zl4)
        Me.Controls.Add(Me.zl3)
        Me.MaximizeBox = False
        Me.Name = "searchMapShow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Map"
        CType(Me.zl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents zl3 As PictureBox
    Friend WithEvents zl4 As PictureBox
    Friend WithEvents zl2 As PictureBox
    Friend WithEvents zl1 As PictureBox
    Friend WithEvents statusLabel As Label
    Friend WithEvents zl5 As PictureBox
    Friend WithEvents backBut As Button
End Class
