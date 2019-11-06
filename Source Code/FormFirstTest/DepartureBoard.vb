Imports System.Threading

Public Class DepartureBoard
    Private Property stationCode As Int16


    Public Sub showDepartureBoard(ByVal searchResult) 'is called by searchForm, passes the index of the station for whos departures are to be displayed.
        searchForm.Enabled = False 'disables the search form.

        Try
            Me.Show()
            departuresGrid.Rows.Clear()
            loadingLabel.Text = "Loading..."
            stationCode = searchResult 'Sets stationCode member to result for re-use when refreshing. 
            Dim result = departureRequest.getDepartureBoard(stationCode) 'Calls departures function which returns the result as a list of arrivals objects.
            loadingLabel.Text = ""
            For Each arrival In result 'Outputs each row
                Dim row As String() = New String() {arrival.arrivalCountdown(), arrival.destinationName, arrival.lineName, arrival.platformName} '
                departuresGrid.Rows.Add(row)  'Updates the data table
                Me.Text = arrival.stationName & " Departure Board" 'displays on caption the name of the stations departures.
            Next

        Catch
            loadingLabel.Text = "###### NETWORK ERROR ######" 'If there is an error, program catches it and displayes error message
        End Try

    End Sub
    Private Sub refreshDepartureBoard() 'same as showDepartureBoard.
        Try
            loadingLabel.Text = "Loading..."
            Dim result = departureRequest.getDepartureBoard(stationCode)
            departuresGrid.Rows.Clear()
            loadingLabel.Text = ""
            If result.count = 0 Then
                loadingLabel.Text = "No Arrivals Available."
            Else
                For Each arrival In result
                    Dim row As String() = New String() {arrival.arrivalCountdown(), arrival.destinationName, arrival.lineName, arrival.platformName}
                    departuresGrid.Rows.Add(row)
                Next
            End If

        Catch
            loadingLabel.Text = "###### NETWORK ERROR ######"
        End Try
    End Sub


    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        refreshDepartureBoard() 'requests for data and updates the table.
    End Sub



    Private Sub closing_down(sender As Object, e As EventArgs) Handles Me.Closing
        searchForm.Enabled = True
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub DepartureBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
