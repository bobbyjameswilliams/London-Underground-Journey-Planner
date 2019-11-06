Imports System.Threading
Public Class searchForm
    Private Property searchMode As String 'Stores if searchmode is lines or strations
    Private Property searchResult As Int16 'Stores search results index key
    Private Property startStation As Int16 'Stores start stations index key
    Private Property destinationStation As Int16 'Stires destination stations index key
    Private searchPop As Boolean = False 'If successful search made, set to true
    Private startPop As Boolean = False 'If start set, set to true
    Private destPop As Boolean = False 'If start set, set to true
    Private butDisabled As Boolean = False 'if all radio buttons are disabled, this is set to true
    Private mmenubool As Boolean = False 'True if main menu button clicked.


    Private Sub searchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populates the comboBoxes with information from the stations and lines arrays.
        For i = 0 To stationMax - 1
            stationsQueryEntry.Items.Add(stations(i).getName)
        Next
        For i = 0 To lineMax - 1
            linesQueryEntry.Items.Add(lines(i).getName)
        Next
    End Sub
    '## Buttons
    Private Sub mMenuBut_Click(sender As Object, e As EventArgs) Handles mMenuButton.Click 'Returns to main menu
        mmenubool = True
        mainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        '## Clears the data grid
        stationsGrid.Rows.Clear()
        linesGrid.Rows.Clear()
        stationsGrid.DataSource = Nothing
        errorLabel.Text = ""    'sets error label to empty
        Select Case searchMode
            '## If stations
            Case "stations"
                searchResult = procedures.stationSearchInit(stations, stationMax, stationsQueryEntry.Text)
                If searchResult = -1 Then
                    'Displays no result and doesnt allow user to make a journey
                    errorLabel.Text = "No Result"
                    searchPop = False

                Else
                    'Clears error message and displays result, enables further controls
                    journeySelection.Enabled = True
                    mapButton.Enabled = True
                    departuresButton.Enabled = True
                    errorLabel.Text = ""
                    Dim n = stationsGrid.Rows.Add
                    stationsGrid.Rows(n).Cells(0).Value = stations(searchResult).getId
                    stationsGrid.Rows(n).Cells(1).Value = stations(searchResult).getName
                    stationsGrid.Rows(n).Cells(2).Value = stations(searchResult).getlat
                    stationsGrid.Rows(n).Cells(3).Value = stations(searchResult).getLon
                    stationsGrid.Rows(n).Cells(4).Value = stations(searchResult).getZone
                    searchPop = True

                End If

            Case "lines"
                searchPop = False
                'disables controls as not valid with lines. makes search.
                SrchAddInfRad.Enabled = False
                SrchAddInfRad.Checked = False
                searchResult = Searching.lineSearchInit(lines, lineMax, linesQueryEntry.Text)
                If searchResult = -1 Then
                    'no result if no result
                    errorLabel.Text = "No Result"

                Else
                    'clears errors 
                    errorLabel.Text = ""
                    Dim n = linesGrid.Rows.Add

                    linesGrid.Rows(n).Cells(0).Value = lines(searchResult).getId
                    linesGrid.Rows(n).Cells(1).Value = lines(searchResult).getName
                    linesGrid.Rows(n).Cells(2).Style.BackColor = ConvertToRbg(lines(searchResult).getColour)



                End If
        End Select
        checkButtons()
    End Sub

    ' ###### Lines or stations radio buttons (for search)
    Private Sub linesRad_CheckedChanged(sender As Object, e As EventArgs) Handles linesRad.CheckedChanged
        '## Hides all stations 
        stationsGrid.Hide() '## hides stations grid
        stationsQueryEntry.Hide() '## hides input for stations
        linesGrid.Show() '# shows the lines grid
        linesQueryEntry.Show() '# shows input for lines search
        stationsGrid.Rows.Clear() '# Clears stations search result
        linesGrid.Rows.Clear() 'Clears lines search result
        searchMode = "lines" 'Changes searchmode
    End Sub

    Private Sub stationsRad_CheckedChanged(sender As Object, e As EventArgs) Handles stationsRad.CheckedChanged
        'Shows and hides elements corresponding to lines and stations search
        linesGrid.Hide()
        linesQueryEntry.Hide()
        stationsGrid.Show()
        stationsQueryEntry.Show()
        stationsGrid.Rows.Clear()
        linesGrid.Rows.Clear()
        searchMode = "stations"
    End Sub

    '##### Additional information buttons
    Private Sub mapButton_Click(sender As Object, e As EventArgs) Handles mapButton.Click
        searchMapShow.Show()
        If SrchAddInfRad.Checked = True Then
            searchMapShow.showMap(stations(searchResult).getLon, stations(searchResult).getlat) 'Shows result in search
        ElseIf startAddInfRad.Checked = True Then
            searchMapShow.showMap(stations(startStation).getLon, stations(startStation).getlat) 'Shows result in start
        ElseIf destAddInfRad.Checked = True Then
            searchMapShow.showMap(stations(destinationStation).getLon, stations(destinationStation).getlat) 'Shows result in destination
        ElseIf startAndDestinationRad.Checked Then
            searchMapShow.showMap(stations(startStation).getLon, stations(startStation).getlat,
                                  stations(destinationStation).getLon, stations(destinationStation).getlat)
        End If '^Shows both start and end on map

    End Sub
    Private Sub departuresButton_Click(sender As Object, e As EventArgs) Handles departuresButton.Click

        'Depending on what radio button is checked depends on what index is sent to request for departures.

        If SrchAddInfRad.Checked = True Then
            DepartureBoard.showDepartureBoard(searchResult)
        ElseIf startAddInfRad.Checked = True Then
            DepartureBoard.showDepartureBoard(startStation)
        ElseIf destAddInfRad.Checked = True Then
            DepartureBoard.showDepartureBoard(destinationStation)
        End If
    End Sub

    '######## Additional information radio buttons
    Private Sub startAndDestinationRad_CheckedChanged(sender As Object, e As EventArgs) Handles startAndDestinationRad.CheckedChanged
        If butDisabled = True Then 'Disables the option for departures if the start and destination is checkd
            mapButton.Enabled = True
        End If
        If startAndDestinationRad.Checked = True Then
            departuresButton.Enabled = False
        Else
            departuresButton.Enabled = True
        End If
    End Sub
    Private Sub destAddInfRad_CheckedChanged(sender As Object, e As EventArgs) Handles destAddInfRad.CheckedChanged
        If butDisabled = True Then 'Re enables when another is checked
            mapButton.Enabled = True
            departuresButton.Enabled = True
        End If
    End Sub

    Private Sub startAddInfRad_CheckedChanged(sender As Object, e As EventArgs) Handles startAddInfRad.CheckedChanged
        If butDisabled = True Then
            mapButton.Enabled = True
            departuresButton.Enabled = True
        End If
    End Sub


    Private Sub SrchAddInfRad_CheckedChanged(sender As Object, e As EventArgs) Handles SrchAddInfRad.CheckedChanged
        If butDisabled = True Then
            mapButton.Enabled = True
            departuresButton.Enabled = True
        End If
    End Sub

    '##### Journey Buttons (start end set, plan journey)
    Private Sub setStart_Click(sender As Object, e As EventArgs) Handles setStartButton.Click
        If searchResult = destinationStation Then
            stationErrorLabel.Text = "The Start and End Station Cannot Be The Same" 'Doesnt allow for duplicate start and destination
        Else
            stationErrorLabel.Text = ""
            startStation = searchResult 'Sets the start
            startBox.Text = stations(searchResult).getName
            startPop = True
        End If
        checkButtons()
    End Sub

    Private Sub setDestinationButton_Click(sender As Object, e As EventArgs) Handles setDestinationButton.Click
        If searchResult = startStation Then
            stationErrorLabel.Text = "Start and End Station Cannot Be The Same" 'Doesnt allow for duplicate start and destination
        Else
            stationErrorLabel.Text = ""
            destinationStation = searchResult 'sets the destination
            destinationBox.Text = stations(searchResult).getName
            destPop = True
        End If
        checkButtons()
    End Sub
    Private Sub swapButton_Click(sender As Object, e As EventArgs) Handles swapButton.Click 'Swaps the start and destination
        Dim buffer As Int16 'Holds the start station whilst the start is set to destination.
        startBox.Text = stations(destinationStation).getName
        destinationBox.Text = stations(startStation).getName
        buffer = startStation
        startStation = destinationStation
        destinationStation = buffer
    End Sub
    Private Sub journeyBut_Click(sender As Object, e As EventArgs) Handles journeyBut.Click
        itineryTextBox.Clear()

        Dim itinery = pathFinding.findPath(stationMax, stations, lines, destinationStation) 'Queries for a path to be returned
        Dim lineOrderList As New List(Of lineClass) 'Line order stored as a list to output to table/
        Dim x As Int16 = startStation
        Dim currentLine As String = itinery(x).getLine().getName()
        itineryTextBox.Text += "Board the " & itinery(x).getLine().getName() & " at " & stations(startStation).getName & ", "
        lineOrderList.Add(itinery(x).getLine())
        itineryTextBox.Text += "
Travel on " & itinery(x).getLine().getName() & " until "
        While x <> destinationStation                               'Writes out the journey to the itinerary text Box
            If itinery(x).getLine().getName() <> currentLine Then
                itineryTextBox.Text += itinery(x).getVertex.getName & " Then change for " & itinery(x).getLine().getName() & ", "
                lineOrderList.Add(itinery(x).getLine())
                itineryTextBox.Text += "
Travel on " & itinery(x).getLine().getName() & " until "
            End If
            currentLine = itinery(x).getLine().getName()
            x = itinery(x).getPrevNode.getId()
        End While
        itineryTextBox.Text += "
Alight at " & stations(destinationStation).getName()
        itineryTextBox.Text += "
Journey time, approx. " & itinery(startStation).getAccDist.ToString & " Minutes"

        lineOrderGrid.Rows.Clear()
        For i = 0 To lineOrderList.Count - 1 'Displays the line order which was accumulated above to the table.
            Dim n = lineOrderGrid.Rows.Add
            lineOrderGrid.Rows(n).Cells(0).Value = lineOrderList(i).getName()
            lineOrderGrid.Rows(n).Cells(1).Style.BackColor = ConvertToRbg(lineOrderList(i).getColour.ToString())

        Next
    End Sub




    '#### Button and radio button validation
    Sub checkRadButState() ' Checks the radio buttons to see if any are checked.
        If destAddInfRad.Checked = True Or startAddInfRad.Checked =
            True Or startAndDestinationRad.Checked = True Or SrchAddInfRad.Checked = True Then
        Else
            departuresButton.Enabled = False
            mapButton.Enabled = False
            butDisabled = True
        End If
    End Sub

    Private Sub checkButtons() 'Validation for buttons

        If searchPop = True Then 'enables radio buttons if valid search is made
            SrchAddInfRad.Enabled = True
            setStartButton.Enabled = True
            setDestinationButton.Enabled = True
        Else
            SrchAddInfRad.Enabled = False 'else disable
            SrchAddInfRad.Checked = False
            setStartButton.Enabled = False
            setDestinationButton.Enabled = False
        End If
        If startPop = True Then        'Enable start radio button if start is set
            startAddInfRad.Enabled = True

        Else
            startAddInfRad.Enabled = False
            startAddInfRad.Checked = False


        End If
        If destPop = True Then 'Enable destination radio button if destination is set
            destAddInfRad.Enabled = True
        Else
            destAddInfRad.Enabled = False
            destAddInfRad.Checked = False
        End If
        If destPop = True And startPop = True Then 'If both are set enable the both map option/
            startAndDestinationRad.Enabled = True
            journeyBut.Enabled = True
            swapButton.Enabled = True
        Else
            startAndDestinationRad.Enabled = False
            startAndDestinationRad.Checked = False
            journeyBut.Enabled = False
            swapButton.Enabled = False

        End If
        checkRadButState() 'Check to see if radio buttons are disabled.
    End Sub

    '### Miscellaneous
    Private Sub queryEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then 'make search if the user hits the return key

            searchButton.PerformClick()

        End If

    End Sub

    Private Sub searchform_Close(sender As Object, e As EventArgs) Handles Me.Closed
        searchResult = Nothing 'Sets the search to nothing
    End Sub
    Private Sub closing_down(sender As Object, e As EventArgs) Handles Me.Closing
        If mmenubool = False Then 'If main menu button wasnt clicked, shut the whole program down.
            mainMenuForm.Close()
        End If

    End Sub
End Class