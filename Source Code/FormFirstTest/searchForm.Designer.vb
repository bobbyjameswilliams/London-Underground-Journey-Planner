<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class searchForm
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
        Me.mMenuButton = New System.Windows.Forms.Button()
        Me.linesorStations = New System.Windows.Forms.GroupBox()
        Me.stationsRad = New System.Windows.Forms.RadioButton()
        Me.linesRad = New System.Windows.Forms.RadioButton()
        Me.journeySelection = New System.Windows.Forms.GroupBox()
        Me.swapButton = New System.Windows.Forms.Button()
        Me.stationErrorLabel = New System.Windows.Forms.Label()
        Me.setDestinationButton = New System.Windows.Forms.Button()
        Me.setStartButton = New System.Windows.Forms.Button()
        Me.startBox = New System.Windows.Forms.TextBox()
        Me.destinationBox = New System.Windows.Forms.TextBox()
        Me.journeyBut = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.stationsGrid = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stationName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Latitude = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Longitude = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.linesGrid = New System.Windows.Forms.DataGridView()
        Me.lineId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lineName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colourOnMap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.mapButton = New System.Windows.Forms.Button()
        Me.departuresButton = New System.Windows.Forms.Button()
        Me.additionalControls = New System.Windows.Forms.GroupBox()
        Me.startAndDestinationRad = New System.Windows.Forms.RadioButton()
        Me.SrchAddInfRad = New System.Windows.Forms.RadioButton()
        Me.destAddInfRad = New System.Windows.Forms.RadioButton()
        Me.startAddInfRad = New System.Windows.Forms.RadioButton()
        Me.itineryLabel = New System.Windows.Forms.Label()
        Me.itineryTextBox = New System.Windows.Forms.RichTextBox()
        Me.stationsQueryEntry = New System.Windows.Forms.ComboBox()
        Me.linesQueryEntry = New System.Windows.Forms.ComboBox()
        Me.lineOrderGrid = New System.Windows.Forms.DataGridView()
        Me.nameOfLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orderoflines = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.linesorStations.SuspendLayout()
        Me.journeySelection.SuspendLayout()
        CType(Me.stationsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.additionalControls.SuspendLayout()
        CType(Me.lineOrderGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mMenuButton
        '
        Me.mMenuButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mMenuButton.Location = New System.Drawing.Point(0, 100)
        Me.mMenuButton.Margin = New System.Windows.Forms.Padding(1)
        Me.mMenuButton.Name = "mMenuButton"
        Me.mMenuButton.Size = New System.Drawing.Size(75, 33)
        Me.mMenuButton.TabIndex = 15
        Me.mMenuButton.Text = "Main Menu"
        Me.mMenuButton.UseVisualStyleBackColor = True
        '
        'linesorStations
        '
        Me.linesorStations.Controls.Add(Me.stationsRad)
        Me.linesorStations.Controls.Add(Me.linesRad)
        Me.linesorStations.Location = New System.Drawing.Point(4, 21)
        Me.linesorStations.Margin = New System.Windows.Forms.Padding(1)
        Me.linesorStations.Name = "linesorStations"
        Me.linesorStations.Padding = New System.Windows.Forms.Padding(1)
        Me.linesorStations.Size = New System.Drawing.Size(63, 47)
        Me.linesorStations.TabIndex = 1
        Me.linesorStations.TabStop = False
        '
        'stationsRad
        '
        Me.stationsRad.AutoSize = True
        Me.stationsRad.Checked = True
        Me.stationsRad.Location = New System.Drawing.Point(6, 9)
        Me.stationsRad.Margin = New System.Windows.Forms.Padding(1)
        Me.stationsRad.Name = "stationsRad"
        Me.stationsRad.Size = New System.Drawing.Size(63, 17)
        Me.stationsRad.TabIndex = 3
        Me.stationsRad.TabStop = True
        Me.stationsRad.Text = "Stations"
        Me.stationsRad.UseVisualStyleBackColor = True
        '
        'linesRad
        '
        Me.linesRad.AutoSize = True
        Me.linesRad.Location = New System.Drawing.Point(6, 28)
        Me.linesRad.Margin = New System.Windows.Forms.Padding(1)
        Me.linesRad.Name = "linesRad"
        Me.linesRad.Size = New System.Drawing.Size(50, 17)
        Me.linesRad.TabIndex = 4
        Me.linesRad.Text = "Lines"
        Me.linesRad.UseVisualStyleBackColor = True
        '
        'journeySelection
        '
        Me.journeySelection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.journeySelection.Controls.Add(Me.swapButton)
        Me.journeySelection.Controls.Add(Me.stationErrorLabel)
        Me.journeySelection.Controls.Add(Me.setDestinationButton)
        Me.journeySelection.Controls.Add(Me.setStartButton)
        Me.journeySelection.Controls.Add(Me.startBox)
        Me.journeySelection.Controls.Add(Me.destinationBox)
        Me.journeySelection.Controls.Add(Me.journeyBut)
        Me.journeySelection.Controls.Add(Me.mMenuButton)
        Me.journeySelection.Location = New System.Drawing.Point(10, 214)
        Me.journeySelection.Margin = New System.Windows.Forms.Padding(1)
        Me.journeySelection.Name = "journeySelection"
        Me.journeySelection.Padding = New System.Windows.Forms.Padding(1)
        Me.journeySelection.Size = New System.Drawing.Size(270, 135)
        Me.journeySelection.TabIndex = 2
        Me.journeySelection.TabStop = False
        Me.journeySelection.Text = "Select if search result is to be the start or destination"
        '
        'swapButton
        '
        Me.swapButton.Enabled = False
        Me.swapButton.Location = New System.Drawing.Point(209, 38)
        Me.swapButton.Name = "swapButton"
        Me.swapButton.Size = New System.Drawing.Size(47, 30)
        Me.swapButton.TabIndex = 15
        Me.swapButton.Text = "Swap"
        Me.swapButton.UseVisualStyleBackColor = True
        '
        'stationErrorLabel
        '
        Me.stationErrorLabel.AutoSize = True
        Me.stationErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.stationErrorLabel.Location = New System.Drawing.Point(4, 84)
        Me.stationErrorLabel.Name = "stationErrorLabel"
        Me.stationErrorLabel.Size = New System.Drawing.Size(0, 13)
        Me.stationErrorLabel.TabIndex = 14
        '
        'setDestinationButton
        '
        Me.setDestinationButton.Enabled = False
        Me.setDestinationButton.Location = New System.Drawing.Point(0, 52)
        Me.setDestinationButton.Name = "setDestinationButton"
        Me.setDestinationButton.Size = New System.Drawing.Size(75, 26)
        Me.setDestinationButton.TabIndex = 6
        Me.setDestinationButton.Text = "Destination"
        Me.setDestinationButton.UseVisualStyleBackColor = True
        '
        'setStartButton
        '
        Me.setStartButton.Enabled = False
        Me.setStartButton.Location = New System.Drawing.Point(0, 27)
        Me.setStartButton.Name = "setStartButton"
        Me.setStartButton.Size = New System.Drawing.Size(75, 23)
        Me.setStartButton.TabIndex = 5
        Me.setStartButton.Text = "Start"
        Me.setStartButton.UseVisualStyleBackColor = True
        '
        'startBox
        '
        Me.startBox.Location = New System.Drawing.Point(75, 29)
        Me.startBox.Name = "startBox"
        Me.startBox.ReadOnly = True
        Me.startBox.Size = New System.Drawing.Size(133, 20)
        Me.startBox.TabIndex = 12
        '
        'destinationBox
        '
        Me.destinationBox.Location = New System.Drawing.Point(75, 55)
        Me.destinationBox.Name = "destinationBox"
        Me.destinationBox.ReadOnly = True
        Me.destinationBox.Size = New System.Drawing.Size(133, 20)
        Me.destinationBox.TabIndex = 11
        '
        'journeyBut
        '
        Me.journeyBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.journeyBut.Enabled = False
        Me.journeyBut.Location = New System.Drawing.Point(182, 100)
        Me.journeyBut.Margin = New System.Windows.Forms.Padding(1)
        Me.journeyBut.Name = "journeyBut"
        Me.journeyBut.Size = New System.Drawing.Size(88, 33)
        Me.journeyBut.TabIndex = 7
        Me.journeyBut.Text = "Plan Journey"
        Me.journeyBut.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(178, 5)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(1)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(69, 20)
        Me.searchButton.TabIndex = 1
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'stationsGrid
        '
        Me.stationsGrid.AllowUserToAddRows = False
        Me.stationsGrid.AllowUserToDeleteRows = False
        Me.stationsGrid.AllowUserToResizeColumns = False
        Me.stationsGrid.AllowUserToResizeRows = False
        Me.stationsGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stationsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.stationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stationsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.stationName, Me.Latitude, Me.Longitude, Me.Zone})
        Me.stationsGrid.Location = New System.Drawing.Point(80, 29)
        Me.stationsGrid.Name = "stationsGrid"
        Me.stationsGrid.ReadOnly = True
        Me.stationsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.stationsGrid.Size = New System.Drawing.Size(443, 48)
        Me.stationsGrid.TabIndex = 1
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 50
        '
        'stationName
        '
        Me.stationName.HeaderText = "Name"
        Me.stationName.Name = "stationName"
        Me.stationName.ReadOnly = True
        '
        'Latitude
        '
        Me.Latitude.HeaderText = "Latitude"
        Me.Latitude.Name = "Latitude"
        Me.Latitude.ReadOnly = True
        Me.Latitude.Width = 60
        '
        'Longitude
        '
        Me.Longitude.HeaderText = "Longitude"
        Me.Longitude.Name = "Longitude"
        Me.Longitude.ReadOnly = True
        Me.Longitude.Width = 60
        '
        'Zone
        '
        Me.Zone.HeaderText = "Zone"
        Me.Zone.Name = "Zone"
        Me.Zone.ReadOnly = True
        Me.Zone.Width = 50
        '
        'linesGrid
        '
        Me.linesGrid.AllowUserToAddRows = False
        Me.linesGrid.AllowUserToDeleteRows = False
        Me.linesGrid.AllowUserToResizeColumns = False
        Me.linesGrid.AllowUserToResizeRows = False
        Me.linesGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linesGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.linesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.linesGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lineId, Me.lineName, Me.colourOnMap})
        Me.linesGrid.Location = New System.Drawing.Point(80, 29)
        Me.linesGrid.Name = "linesGrid"
        Me.linesGrid.ReadOnly = True
        Me.linesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.linesGrid.Size = New System.Drawing.Size(303, 48)
        Me.linesGrid.TabIndex = 5
        Me.linesGrid.Visible = False
        '
        'lineId
        '
        Me.lineId.HeaderText = "Id"
        Me.lineId.Name = "lineId"
        Me.lineId.ReadOnly = True
        Me.lineId.Width = 50
        '
        'lineName
        '
        Me.lineName.HeaderText = "Name"
        Me.lineName.Name = "lineName"
        Me.lineName.ReadOnly = True
        '
        'colourOnMap
        '
        Me.colourOnMap.HeaderText = "Line Colour"
        Me.colourOnMap.Name = "colourOnMap"
        Me.colourOnMap.ReadOnly = True
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.Location = New System.Drawing.Point(251, 8)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(0, 13)
        Me.errorLabel.TabIndex = 6
        '
        'mapButton
        '
        Me.mapButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mapButton.Enabled = False
        Me.mapButton.Location = New System.Drawing.Point(395, 314)
        Me.mapButton.Name = "mapButton"
        Me.mapButton.Size = New System.Drawing.Size(91, 32)
        Me.mapButton.TabIndex = 12
        Me.mapButton.Text = "Show On Map"
        Me.mapButton.UseVisualStyleBackColor = True
        '
        'departuresButton
        '
        Me.departuresButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.departuresButton.Enabled = False
        Me.departuresButton.Location = New System.Drawing.Point(492, 314)
        Me.departuresButton.Name = "departuresButton"
        Me.departuresButton.Size = New System.Drawing.Size(80, 32)
        Me.departuresButton.TabIndex = 13
        Me.departuresButton.Text = "Departures"
        Me.departuresButton.UseVisualStyleBackColor = True
        '
        'additionalControls
        '
        Me.additionalControls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.additionalControls.Controls.Add(Me.startAndDestinationRad)
        Me.additionalControls.Controls.Add(Me.SrchAddInfRad)
        Me.additionalControls.Controls.Add(Me.destAddInfRad)
        Me.additionalControls.Controls.Add(Me.startAddInfRad)
        Me.additionalControls.Location = New System.Drawing.Point(371, 223)
        Me.additionalControls.Name = "additionalControls"
        Me.additionalControls.Size = New System.Drawing.Size(210, 131)
        Me.additionalControls.TabIndex = 13
        Me.additionalControls.TabStop = False
        Me.additionalControls.Text = "Additional Information"
        '
        'startAndDestinationRad
        '
        Me.startAndDestinationRad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startAndDestinationRad.AutoSize = True
        Me.startAndDestinationRad.Enabled = False
        Me.startAndDestinationRad.Location = New System.Drawing.Point(25, 72)
        Me.startAndDestinationRad.Name = "startAndDestinationRad"
        Me.startAndDestinationRad.Size = New System.Drawing.Size(124, 17)
        Me.startAndDestinationRad.TabIndex = 11
        Me.startAndDestinationRad.TabStop = True
        Me.startAndDestinationRad.Text = "Start and Destination"
        Me.startAndDestinationRad.UseVisualStyleBackColor = True
        '
        'SrchAddInfRad
        '
        Me.SrchAddInfRad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SrchAddInfRad.AutoSize = True
        Me.SrchAddInfRad.Checked = True
        Me.SrchAddInfRad.Enabled = False
        Me.SrchAddInfRad.Location = New System.Drawing.Point(25, 14)
        Me.SrchAddInfRad.Name = "SrchAddInfRad"
        Me.SrchAddInfRad.Size = New System.Drawing.Size(92, 17)
        Me.SrchAddInfRad.TabIndex = 8
        Me.SrchAddInfRad.TabStop = True
        Me.SrchAddInfRad.Text = "Search Result"
        Me.SrchAddInfRad.UseVisualStyleBackColor = True
        '
        'destAddInfRad
        '
        Me.destAddInfRad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.destAddInfRad.AutoSize = True
        Me.destAddInfRad.Enabled = False
        Me.destAddInfRad.Location = New System.Drawing.Point(25, 52)
        Me.destAddInfRad.Name = "destAddInfRad"
        Me.destAddInfRad.Size = New System.Drawing.Size(114, 17)
        Me.destAddInfRad.TabIndex = 10
        Me.destAddInfRad.Text = "Destination Station"
        Me.destAddInfRad.UseVisualStyleBackColor = True
        '
        'startAddInfRad
        '
        Me.startAddInfRad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startAddInfRad.AutoSize = True
        Me.startAddInfRad.Enabled = False
        Me.startAddInfRad.Location = New System.Drawing.Point(25, 33)
        Me.startAddInfRad.Name = "startAddInfRad"
        Me.startAddInfRad.Size = New System.Drawing.Size(83, 17)
        Me.startAddInfRad.TabIndex = 9
        Me.startAddInfRad.TabStop = True
        Me.startAddInfRad.Text = "Start Station"
        Me.startAddInfRad.UseVisualStyleBackColor = True
        '
        'itineryLabel
        '
        Me.itineryLabel.AutoSize = True
        Me.itineryLabel.Location = New System.Drawing.Point(1, 80)
        Me.itineryLabel.Name = "itineryLabel"
        Me.itineryLabel.Size = New System.Drawing.Size(35, 13)
        Me.itineryLabel.TabIndex = 14
        Me.itineryLabel.Text = "Itinery"
        '
        'itineryTextBox
        '
        Me.itineryTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.itineryTextBox.Location = New System.Drawing.Point(4, 96)
        Me.itineryTextBox.Name = "itineryTextBox"
        Me.itineryTextBox.ReadOnly = True
        Me.itineryTextBox.Size = New System.Drawing.Size(379, 112)
        Me.itineryTextBox.TabIndex = 17
        Me.itineryTextBox.Text = "To start planning a journey, search for a station."
        '
        'stationsQueryEntry
        '
        Me.stationsQueryEntry.FormattingEnabled = True
        Me.stationsQueryEntry.Location = New System.Drawing.Point(4, 4)
        Me.stationsQueryEntry.Name = "stationsQueryEntry"
        Me.stationsQueryEntry.Size = New System.Drawing.Size(173, 21)
        Me.stationsQueryEntry.TabIndex = 18
        '
        'linesQueryEntry
        '
        Me.linesQueryEntry.FormattingEnabled = True
        Me.linesQueryEntry.Location = New System.Drawing.Point(4, 4)
        Me.linesQueryEntry.Name = "linesQueryEntry"
        Me.linesQueryEntry.Size = New System.Drawing.Size(173, 21)
        Me.linesQueryEntry.TabIndex = 19
        Me.linesQueryEntry.Visible = False
        '
        'lineOrderGrid
        '
        Me.lineOrderGrid.AllowUserToAddRows = False
        Me.lineOrderGrid.AllowUserToDeleteRows = False
        Me.lineOrderGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lineOrderGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lineOrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lineOrderGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nameOfLine, Me.orderoflines})
        Me.lineOrderGrid.Location = New System.Drawing.Point(395, 83)
        Me.lineOrderGrid.Name = "lineOrderGrid"
        Me.lineOrderGrid.ReadOnly = True
        Me.lineOrderGrid.RowHeadersVisible = False
        Me.lineOrderGrid.Size = New System.Drawing.Size(171, 125)
        Me.lineOrderGrid.TabIndex = 20
        '
        'nameOfLine
        '
        Me.nameOfLine.HeaderText = "Line Order"
        Me.nameOfLine.Name = "nameOfLine"
        Me.nameOfLine.ReadOnly = True
        '
        'orderoflines
        '
        Me.orderoflines.HeaderText = "Line Colour"
        Me.orderoflines.Name = "orderoflines"
        Me.orderoflines.ReadOnly = True
        Me.orderoflines.Width = 50
        '
        'searchForm
        '
        Me.AcceptButton = Me.searchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(583, 358)
        Me.Controls.Add(Me.lineOrderGrid)
        Me.Controls.Add(Me.linesQueryEntry)
        Me.Controls.Add(Me.stationsQueryEntry)
        Me.Controls.Add(Me.itineryTextBox)
        Me.Controls.Add(Me.itineryLabel)
        Me.Controls.Add(Me.departuresButton)
        Me.Controls.Add(Me.mapButton)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.linesGrid)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.stationsGrid)
        Me.Controls.Add(Me.linesorStations)
        Me.Controls.Add(Me.journeySelection)
        Me.Controls.Add(Me.additionalControls)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximizeBox = False
        Me.Name = "searchForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journey Planner"
        Me.linesorStations.ResumeLayout(False)
        Me.linesorStations.PerformLayout()
        Me.journeySelection.ResumeLayout(False)
        Me.journeySelection.PerformLayout()
        CType(Me.stationsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.additionalControls.ResumeLayout(False)
        Me.additionalControls.PerformLayout()
        CType(Me.lineOrderGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mMenuButton As Button
    Friend WithEvents linesorStations As GroupBox
    Friend WithEvents stationsRad As RadioButton
    Friend WithEvents linesRad As RadioButton
    Friend WithEvents journeySelection As GroupBox
    Friend WithEvents journeyBut As Button
    Friend WithEvents searchButton As Button
    Friend WithEvents stationsGrid As DataGridView
    Friend WithEvents linesGrid As DataGridView
    Friend WithEvents errorLabel As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents stationName As DataGridViewTextBoxColumn
    Friend WithEvents Latitude As DataGridViewTextBoxColumn
    Friend WithEvents Longitude As DataGridViewTextBoxColumn
    Friend WithEvents Zone As DataGridViewTextBoxColumn
    Friend WithEvents mapButton As Button
    Friend WithEvents departuresButton As Button
    Friend WithEvents destinationBox As TextBox
    Friend WithEvents startBox As TextBox
    Friend WithEvents additionalControls As GroupBox
    Friend WithEvents startAddInfRad As RadioButton
    Friend WithEvents SrchAddInfRad As RadioButton
    Friend WithEvents destAddInfRad As RadioButton
    Friend WithEvents stationErrorLabel As Label
    Friend WithEvents setDestinationButton As Button
    Friend WithEvents setStartButton As Button
    Friend WithEvents itineryLabel As Label
    Friend WithEvents startAndDestinationRad As RadioButton
    Friend WithEvents itineryTextBox As RichTextBox
    Friend WithEvents swapButton As Button
    Friend WithEvents stationsQueryEntry As ComboBox
    Friend WithEvents linesQueryEntry As ComboBox
    Friend WithEvents lineId As DataGridViewTextBoxColumn
    Friend WithEvents lineName As DataGridViewTextBoxColumn
    Friend WithEvents colourOnMap As DataGridViewTextBoxColumn
    Friend WithEvents lineOrderGrid As DataGridView
    Friend WithEvents nameOfLine As DataGridViewTextBoxColumn
    Friend WithEvents orderoflines As DataGridViewTextBoxColumn
End Class
