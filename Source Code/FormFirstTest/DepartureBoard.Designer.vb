<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartureBoard
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.departuresGrid = New System.Windows.Forms.DataGridView()
        Me.timeUntilDeparture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.destinationName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lineTravelledOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.platformName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stationNameDisplay = New System.Windows.Forms.Label()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.loadingLabel = New System.Windows.Forms.Label()
        CType(Me.departuresGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.Location = New System.Drawing.Point(32, 671)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(200, 55)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'departuresGrid
        '
        Me.departuresGrid.AllowUserToAddRows = False
        Me.departuresGrid.AllowUserToDeleteRows = False
        Me.departuresGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.departuresGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.departuresGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.timeUntilDeparture, Me.destinationName, Me.lineTravelledOn, Me.platformName})
        Me.departuresGrid.Location = New System.Drawing.Point(32, 21)
        Me.departuresGrid.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.departuresGrid.Name = "departuresGrid"
        Me.departuresGrid.ReadOnly = True
        Me.departuresGrid.Size = New System.Drawing.Size(1137, 549)
        Me.departuresGrid.TabIndex = 2
        '
        'timeUntilDeparture
        '
        Me.timeUntilDeparture.HeaderText = "Departing in..."
        Me.timeUntilDeparture.Name = "timeUntilDeparture"
        Me.timeUntilDeparture.ReadOnly = True
        Me.timeUntilDeparture.Width = 60
        '
        'destinationName
        '
        Me.destinationName.HeaderText = "Travelling To..."
        Me.destinationName.Name = "destinationName"
        Me.destinationName.ReadOnly = True
        Me.destinationName.Width = 300
        '
        'lineTravelledOn
        '
        Me.lineTravelledOn.HeaderText = "Line"
        Me.lineTravelledOn.Name = "lineTravelledOn"
        Me.lineTravelledOn.ReadOnly = True
        '
        'platformName
        '
        Me.platformName.HeaderText = "Platform"
        Me.platformName.Name = "platformName"
        Me.platformName.ReadOnly = True
        Me.platformName.Width = 200
        '
        'stationNameDisplay
        '
        Me.stationNameDisplay.AutoSize = True
        Me.stationNameDisplay.Location = New System.Drawing.Point(32, 21)
        Me.stationNameDisplay.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.stationNameDisplay.Name = "stationNameDisplay"
        Me.stationNameDisplay.Size = New System.Drawing.Size(0, 32)
        Me.stationNameDisplay.TabIndex = 3
        '
        'refreshButton
        '
        Me.refreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshButton.Location = New System.Drawing.Point(1016, 671)
        Me.refreshButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(200, 55)
        Me.refreshButton.TabIndex = 4
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'loadingLabel
        '
        Me.loadingLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.loadingLabel.AutoSize = True
        Me.loadingLabel.Location = New System.Drawing.Point(32, 604)
        Me.loadingLabel.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.loadingLabel.Name = "loadingLabel"
        Me.loadingLabel.Size = New System.Drawing.Size(0, 32)
        Me.loadingLabel.TabIndex = 5
        '
        'DepartureBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 755)
        Me.Controls.Add(Me.loadingLabel)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.stationNameDisplay)
        Me.Controls.Add(Me.departuresGrid)
        Me.Controls.Add(Me.BackButton)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.Name = "DepartureBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Departure Board"
        CType(Me.departuresGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents departuresGrid As DataGridView
    Friend WithEvents stationNameDisplay As Label
    Friend WithEvents refreshButton As Button
    Friend WithEvents loadingLabel As Label
    Friend WithEvents timeUntilDeparture As DataGridViewTextBoxColumn
    Friend WithEvents destinationName As DataGridViewTextBoxColumn
    Friend WithEvents lineTravelledOn As DataGridViewTextBoxColumn
    Friend WithEvents platformName As DataGridViewTextBoxColumn
End Class
