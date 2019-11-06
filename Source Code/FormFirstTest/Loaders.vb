Imports System.Net
Imports System.Web.Script.Serialization
Module procedures
    '###  Constants for the size of the data.
    Public Const stationMax As Int16 = 301
    Public Const lineMax As Byte = 12

    '#### Creates arrays which will store the stations and lines
    Public stations(stationMax) As stationClass 'creates the class array to store stations. referenced by their ID 
    Public lines(lineMax) As lineClass
    '#### API keys
    Const TFLappId As String = "4f034c04"
    Const TFLappKey As String = "ae19ca5123d75d4830912cc0b711c2d5"
    Public Const GoogleAPIKey As String = "AIzaSyCnuMUPNoySzAkXVetPMA0QycVNw90T1ZM"
    Dim vertexArr(stationMax)

    '#######LOADERS
    Sub loadStations(ByRef stations) 'loads stations in
        Dim readline As String 'buffer for lines read
        Dim explodedline(5) As String 'array for each variable separated by comma
        FileOpen(1, "Stations.csv", OpenMode.Input)
        Do Until EOF(1)
            readline = LineInput(1) 'buffer assigned
            explodedline = readline.Split(",") '
            stations(explodedline(0)) = New stationClass(CInt(explodedline(0)), CDbl(explodedline(1)), CDbl(explodedline(2)), explodedline(3), CInt(explodedline(4)), explodedline(6), explodedline(7))
        Loop 'instantiation^^
        FileClose(1)
    End Sub 'Loads the stations in from the .csv and instantiates an item of stationClass for each
    Sub loadLines(ByRef lines)
        Dim readline As String
        Dim explodedline(3) As String
        FileOpen(2, "Lines.csv", OpenMode.Input)
        Do Until EOF(2)
            readline = LineInput(2)
            explodedline = readline.Split(",")
            lines(explodedline(0)) = New lineClass(CInt(explodedline(0)), explodedline(1), explodedline(2), explodedline(3))
        Loop '^^^ instantiation
        FileClose(2)
    End Sub 'Loads the lines in from the .csv and instantiates an item of lines for each
    Sub loadAjacency(ByRef lines, ByRef stations)
        Dim readline As String
        Dim explodedline(3) As String
        'Dim prevID As Int16
        FileOpen(3, "Ajacency List.csv", OpenMode.Input)
        Do Until EOF(3)
            readline = LineInput(3)
            explodedline = readline.Split(",")
            stations(explodedline(0)).addLine(lines(explodedline(2)))    'Adds line to the station currently being processed (for each station to have data on which lines serve it)
            lines(explodedline(2)).AddLink(stations(explodedline(0)), stations(explodedline(1)), explodedline(3)) 'Adds ajacency from within lines. 
        Loop
        FileClose(3)
    End Sub 'Loads ajacencies from csv and adds the ajacencies to a property of lines. Also in here, deals with adding lines served to stations.

    '/////// SEARCH INITIALISERS
    Function stationSearchInit(ByVal stations, ByVal stationMax, ByVal target) 'initialises the stations array to be searched
        'Dim data As stationClass = stations
        Dim first As Int16 = 0
        Dim last As Int16 = stations.Length - 1  'Sets upper bound of the data to the length of stations array
        Dim midpoint As Int16
        Return binarySearch(stations, target.ToString.ToUpper, first, last, midpoint)  'Target set to upper to eliminate errors due to casing
    End Function
    Function lineSearchInit(ByVal lines, ByVal lineMax, ByVal target) 'initialised the lines array to be searched
        Dim first As Int16 = 0
        Dim last As Byte = lines.length - 1 'Sets upper bound of the data to the length of lines array
        Dim midpoint As Int16
        Return binarySearch(lines, target.ToString.ToUpper, first, last, midpoint) 'Target set to upper to eliminate errors due to casing
    End Function
    '///// BINARY SEARCH
    Function binarySearch(ByVal data, ByVal target, ByVal first, ByVal last, ByVal midpoint) ''wont return past acton town
        If last < first Then 'This should not happen, so the search has failed.
            Return -1
        Else
            midpoint = (first + last) \ 2

            If String.Compare(data(midpoint).getName.ToString.ToUpper, target) = 1 Then 'If search is less than the current mid point, eliminate the upper half
                Return binarySearch(data, target, first, midpoint - 1, midpoint)
            Else
                If String.Compare(data(midpoint).getName.ToString.ToUpper, target) = -1 Then 'If search is greater than current mid point, eliminate lower half.
                    Return binarySearch(data, target, midpoint + 1, last, midpoint)
                Else
                    Return midpoint 'Returns when midpoint is equal to the targets ID.
                End If
            End If
        End If
    End Function


    '///// DIJKSTRA

    Function findPath(ByVal stationMax, ByVal stations, ByVal lines, ByVal dest)
        Dim pQueue As New List(Of Dijkstra)
        Dim vertexArr(stationMax) As Dijkstra
        Dim u As Dijkstra
        Dim alt As Byte
        Dim change As Boolean = False
        For i = 0 To stationMax 'Populates the priority queue
            Try
                vertexArr(i).reinitialise()             'Avoids creating multiple irrelevant objects every time its run
                pQueue.Add(vertexArr(i))
            Catch ex As System.NullReferenceException
                vertexArr(i) = New Dijkstra(stations(i))
                pQueue.Add(vertexArr(i))
            End Try
        Next
        ''Start Vertex
        vertexArr(dest).setAccDist(0)
        Dim t As Int16 = 1
        While pQueue.Count <> 0 'Checks queue is not empty
            pQueue = pQueue.OrderBy(Function(z) z.getAccDist).ToList()
            u = pQueue(0)             'Current shortest path to destination from unvisited node
            pQueue.RemoveAt(0)
            For Each lserved In stations(u.getVertex.getId()).getLines()                        'as ajacencies are dependant on lines, checks all ajacencies ajacencies for station considered
                For Each ajacency In lines(lserved.getId()).getStationsOnLine.item(u.getVertex)   'every ajacency of the current vertex

                    If pQueue.Contains(vertexArr(ajacency.getStation2.getID)) Then  'that is in the pQueue(IE not already considered)
                        'Console.WriteLine(t)
                        t += 1
                        change = False
                        Try    'Try is needed because error is thrown if is the node
                            If lserved.getId() <> vertexArr(u.getPrevNode.getId()).getLine.getId() Then  'if line change add weight of 5 to alt (average interchange time)
                                change = True
                            End If
                        Catch ex As System.NullReferenceException
                        End Try
                        If change = True Then
                            alt = u.getAccDist + ajacency.getWeight() + 5
                        Else
                            alt = u.getAccDist + ajacency.getWeight()
                        End If

                        If alt < vertexArr(ajacency.getStation2Id).getAccDist Then  'if this product is smaller than the ajacent stations distance from A already then...

                            vertexArr(ajacency.getStation2Id).setAccDist(alt)           'Replace alt with its current distance from a and 
                            vertexArr(ajacency.getStation2Id).setPrevNode(u.getVertex)   'note the current vertex as the previous node.
                            vertexArr(ajacency.getStation2Id).setLine(lserved)
                        End If
                    End If
                Next
            Next

        End While

        Return vertexArr 'Contains all the items of dijkstra which now contain the previous station, current line and distance from the start node.    

    End Function

    '////// DEPARTURE BOARD 

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
                Dim result As String = client.DownloadString("https://api.tfl.gov.uk/StopPoint/" & code & "/Arrivals?app_id=" & TFLappId & "&app_key=" & TFLappKey)
                Dim deserializedResult = serializer.Deserialize(Of List(Of arrivalsData))(result)
                For Each arrival In deserializedResult
                    totalDepartures.Add(arrival) 'adds to totaldepartuers
                Next

            End If
        Next
        totalDepartures = totalDepartures.OrderBy(Function(z) z.expectedArrival).ToList() 'Sorts all the results in order of departure time.
        Return totalDepartures 'Returns departures from both codes.
    End Function

    Public Function ConvertToRbg(ByVal HexColor As String) As Color 'Converts HEX to RGB numbers.
        Dim Red As String
        Dim Green As String
        Dim Blue As String
        HexColor = Replace(HexColor, "#", "")
        Red = Val("&H" & Mid(HexColor, 1, 2))
        Green = Val("&H" & Mid(HexColor, 3, 2))
        Blue = Val("&H" & Mid(HexColor, 5, 2))
        Return Color.FromArgb(Red, Green, Blue)
    End Function
End Module
