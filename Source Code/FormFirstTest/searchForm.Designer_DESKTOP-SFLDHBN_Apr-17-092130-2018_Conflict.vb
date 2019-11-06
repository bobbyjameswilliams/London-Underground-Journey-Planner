<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchForm
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
        Me.mMenuBut = New System.Windows.Forms.Button()
        Me.linesorStations = New System.Windows.Forms.GroupBox()
        Me.stationsRad = New System.Windows.Forms.RadioButton()
        Me.linesRad = New System.Windows.Forms.RadioButton()
        Me.journeySelection = New System.Windows.Forms.GroupBox()
        Me.journeyBut = New System.Windows.Forms.Button()
        Me.startRad = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.stationsResultTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.linesorStations.SuspendLayout()
        Me.journeySelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'mMenuBut
        '
        Me.mMenuBut.Location = New System.Drawing.Point(1, 179)
        Me.mMenuBut.Name = "mMenuBut"
        Me.mMenuBut.Size = New System.Drawing.Size(158, 75)
        Me.mMenuBut.TabIndex = 0
        Me.mMenuBut.Text = "Main Menu"
        Me.mMenuBut.UseVisualStyleBackColor = True
        '
        'linesorStations
        '
        Me.linesorStations.Controls.Add(Me.stationsRad)
        Me.linesorStations.Controls.Add(Me.linesRad)
        Me.linesorStations.Location = New System.Drawing.Point(12, 51)
        Me.linesorStations.Name = "linesorStations"
        Me.linesorStations.Size = New System.Drawing.Size(167, 113)
        Me.linesorStations.TabIndex = 1
        Me.linesorStations.TabStop = False
        '
        'stationsRad
        '
        Me.stationsRad.AutoSize = True
        Me.stationsRad.Location = New System.Drawing.Point(6, 61)
        Me.stationsRad.Name = "stationsRad"
        Me.stationsRad.Size = New System.Drawing.Size(156, 36)
        Me.stationsRad.TabIndex = 0
        Me.stationsRad.TabStop = True
        Me.stationsRad.Text = "Stations"
        Me.stationsRad.UseVisualStyleBackColor = True
        '
        'linesRad
        '
        Me.linesRad.AutoSize = True
        Me.linesRad.Location = New System.Drawing.Point(6, 19)
        Me.linesRad.Name = "linesRad"
        Me.linesRad.Size = New System.Drawing.Size(121, 36)
        Me.linesRad.TabIndex = 1
        Me.linesRad.TabStop = True
        Me.linesRad.Text = "Lines"
        Me.linesRad.UseVisualStyleBackColor = True
        '
        'journeySelection
        '
        Me.journeySelection.Controls.Add(Me.journeyBut)
        Me.journeySelection.Controls.Add(Me.startRad)
        Me.journeySelection.Controls.Add(Me.RadioButton2)
        Me.journeySelection.Location = New System.Drawing.Point(228, 244)
        Me.journeySelection.Name = "journeySelection"
        Me.journeySelection.Size = New System.Drawing.Size(578, 100)
        Me.journeySelection.TabIndex = 2
        Me.journeySelection.TabStop = False
        '
        'journeyBut
        '
        Me.journeyBut.Location = New System.Drawing.Point(335, 16)
        Me.journeyBut.Name = "journeyBut"
        Me.journeyBut.Size = New System.Drawing.Size(236, 78)
        Me.journeyBut.TabIndex = 2
        Me.journeyBut.Text = "Plan Journey"
        Me.journeyBut.UseVisualStyleBackColor = True
        '
        'startRad
        '
        Me.startRad.AutoSize = True
        Me.startRad.Location = New System.Drawing.Point(208, 37)
        Me.startRad.Name = "startRad"
        Me.startRad.Size = New System.Drawing.Size(112, 36)
        Me.startRad.TabIndex = 0
        Me.startRad.TabStop = True
        Me.startRad.Text = "Start"
        Me.startRad.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 37)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(196, 36)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Destination"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 72)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(444, 38)
        Me.TextBox1.TabIndex = 4
        '
        'stationsResultTable
        '
        Me.stationsResultTable.ColumnCount = 6
        Me.stationsResultTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.stationsResultTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.stationsResultTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.stationsResultTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.stationsResultTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.stationsResultTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.stationsResultTable.Location = New System.Drawing.Point(228, 91)
        Me.stationsResultTable.Name = "stationsResultTable"
        Me.stationsResultTable.RowCount = 1
        Me.stationsResultTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.stationsResultTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.stationsResultTable.Size = New System.Drawing.Size(573, 57)
        Me.stationsResultTable.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(468, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 52)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(228, 154)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(573, 57)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'searchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1510, 366)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.stationsResultTable)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mMenuBut)
        Me.Controls.Add(Me.linesorStations)
        Me.Controls.Add(Me.journeySelection)
        Me.Name = "searchForm"
        Me.Text = "searchForm"
        Me.linesorStations.ResumeLayout(False)
        Me.linesorStations.PerformLayout()
        Me.journeySelection.ResumeLayout(False)
        Me.journeySelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mMenuBut As Button
    Friend WithEvents linesorStations As GroupBox
    Friend WithEvents stationsRad As RadioButton
    Friend WithEvents linesRad As RadioButton
    Friend WithEvents journeySelection As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents startRad As RadioButton
    Friend WithEvents journeyBut As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents stationsResultTable As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
