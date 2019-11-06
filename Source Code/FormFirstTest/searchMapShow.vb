Imports System.Net
Public Class searchMapShow
    Dim wc As New WebClient()
    Public Sub showMap(ByVal lon As String, ByVal lat As String)
        Try
            statusLabel.Text = "Loading..."
            zl5.Hide() 'Hides picturebox for both stations
            ''Requests for the maps sent to google,  response created as new bitmap and displayed on the form
            zl1.Image =
                New Bitmap(wc.OpenRead("https://maps.googleapis.com/maps/api/staticmap?zoom=17&center=" & lat & "," & lon & "&markers=|" & lat & "," & lon & "&size=401x264&key=" & departureRequest.GoogleAPIKey))
            zl2.Image =
                New Bitmap(wc.OpenRead("https://maps.googleapis.com/maps/api/staticmap?zoom=15&center=" & lat & "," & lon & "&markers=|" & lat & "," & lon & "&size=401x264&key=" & departureRequest.GoogleAPIKey))
            zl3.Image =
                New Bitmap(wc.OpenRead("https://maps.googleapis.com/maps/api/staticmap?zoom=11&center=" & lat & "," & lon & "&markers=|" & lat & "," & lon & "&size=401x264&key=" & departureRequest.GoogleAPIKey))
            zl4.Image =
                New Bitmap(wc.OpenRead("https://maps.googleapis.com/maps/api/staticmap?zoom=9&center=51.5074,-0.1278&markers=|" & lat & "," & lon & "&size=401x264&key=" & departureRequest.GoogleAPIKey))

            statusLabel.Text = ""
        Catch
            statusLabel.Text = "###### NETWORK ERROR ######" 'If an error occurs, then an error message is displayed.
        End Try
    End Sub
    Public Sub showMap(ByVal lon1 As String, ByVal lat1 As String, ByVal lon2 As String, ByVal lat2 As String) 'Shows map with both stations.
        Try
            statusLabel.Text = "Loading..."
            zl5.Show()
            'Request sent with markers for both stations as parameters.
            zl5.Image =
                New Bitmap(wc.OpenRead("https://maps.googleapis.com/maps/api/staticmap?zoom=10&center=51.5074,-0.1278&markers=|" & lat1 & "," & lon1 & "|" & lat2 & "," & lon2 & "&size=811x555&key=" & departureRequest.GoogleAPIKey))

            statusLabel.Text = ""
        Catch
            statusLabel.Text = "###### NETWORK ERROR ######" 'If an error occurs, then an error message is displayed.
        End Try
    End Sub

    Private Sub searchMapShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchForm.Enabled() = False 'Disables other form upon opening.
    End Sub
    Private Sub closeMap(sender As Object, e As EventArgs) Handles MyBase.Closing
        searchForm.Enabled() = True 'Re-enables when closing.
    End Sub

    Private Sub backBut_Click(sender As Object, e As EventArgs) Handles backBut.Click
        Me.Close() 'Back button closes form.
    End Sub

End Class