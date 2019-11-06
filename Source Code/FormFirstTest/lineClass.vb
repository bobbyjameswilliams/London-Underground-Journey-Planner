Public Class lineClass
    Private id As Byte 'id corresponding to the lines csv file
    Private name As String 'station name
    Private colour As String 'Colour in which station appears on the map
    Private stripe As Boolean 'Whether it has a stripe or not
    Private StationsOnLine As New Dictionary(Of stationClass, List(Of tubeLink))
    '^^composes a list of stations on the line
    Sub New(i As Byte, n As String, c As String, s As Boolean) 'instantiates line
        id = i
        name = n
        colour = c
        stripe = s
    End Sub

    ''getters
    Function getId()
        Return id
    End Function
    Function getName()
        Return name
    End Function
    Function getColour()
        Return colour
    End Function
    Function getStripe()
        Return stripe
    End Function
    Function getStationsOnLine() As Dictionary(Of stationClass, List(Of tubeLink))
        '^^returns list of stations on the line
        Return StationsOnLine
    End Function

    Sub AddLink(station1 As stationClass, station2 As stationClass, weight As Integer) 'Creates an adjacency 
        If StationsOnLine.ContainsKey(station1) = False Then
            StationsOnLine.Add(station1, New List(Of tubeLink))
        End If
        StationsOnLine.Item(station1).Add(New tubeLink(station1, station2, weight))
    End Sub
End Class