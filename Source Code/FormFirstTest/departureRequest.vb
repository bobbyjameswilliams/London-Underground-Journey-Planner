Imports System.Net
Imports System.Web.Script.Serialization

Module departureRequest
    '################# API KEYS ######################
    Const TFLappId As String = "" 'Add API details here
    Const TFLappKey As String = "" 'Add API details here
    Public Const GoogleAPIKey As String = "" 'add API details here
    '#################################################
    Function getDepartureBoard(ByVal searchResult)
        Dim client As New WebClient() 'Creates a client
        Dim serializer As New JavaScriptSerializer() 'Creates a serializer
        Dim totalDepartures As New List(Of arrivalsData)
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 'Sets the TLS protocol to 1.2, otherwise a connection cannot be made.
        For Each code In stations(searchResult).getNaptan 'Cycles through each code in the stations property "naptan" which contains connection codes.
            If code = "NULL" Then
                Return Nothing
            Else
                '##Makes request, concatenating info of the code, appid and appkey 
                Dim result As String =
                    client.DownloadString("https://api.tfl.gov.uk/StopPoint/" & code & "/Arrivals?app_id=" & TFLappId & "&app_key=" & TFLappKey)
                Dim deserializedResult = serializer.Deserialize(Of List(Of arrivalsData))(result)
                For Each arrival In deserializedResult
                    totalDepartures.Add(arrival) 'adds to totaldepartuers
                Next

            End If
        Next
        totalDepartures = totalDepartures.OrderBy(Function(z) z.expectedArrival).ToList() 'Sorts all the results in order of departure time.
        Return totalDepartures
    End Function
End Module
