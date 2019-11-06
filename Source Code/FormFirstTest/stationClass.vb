Public Class stationClass
    Private name As String
    Private longitude As Double
    Private latitude As Double
    Private zone As Int16
    Private linesServed As New List(Of lineClass)
    Private id As Int16
    Private naptan As New List(Of String)

    Sub New(i As Int16, lat As Double, lon As Double, n As String, z As Int16, lu As String, dl As String)
        ' Instantiates class.
        id = i
        longitude = lon
        latitude = lat
        name = n
        zone = z
        'Populates naptan list from parameters.
        If String.IsNullOrEmpty(lu) = False Then
            naptan.Add(lu)
        End If
        If String.IsNullOrEmpty(dl) = False Then
            naptan.Add(dl)
        End If
    End Sub
    '' getters
    Function getName()
        Return name
    End Function
    Function getLon()
        Return longitude
    End Function
    Function getlat()
        Return latitude
    End Function
    Function getZone()
        Return zone
    End Function
    Function getId()
        Return id
    End Function
    Function getLines()
        Return linesServed
    End Function
    Function getNaptan()
        Return naptan
    End Function
    'Setter
    Sub addLine(l As lineClass) 'Adds to the list of lines that serve the station
        If linesServed.Contains(l) = False Then
            linesServed.Add(l)
        End If
    End Sub
End Class