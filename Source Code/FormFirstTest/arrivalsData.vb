
Public Class arrivalsData
    'Data recieved from TFL request, Members correspond to variabled returned in JSON response

    Public Property stationName As String
    Public Property expectedArrival As New DateTime
    Public Property lineName As String
    Public Property platformName As String
    Public Property modeName As String
    Public Property timeStamp As New DateTime
    Public Property direction As String
    Public Property destinationName As String

    Function arrivalCountdown()
        'Finds difference in expected arrival and current time in seconds, integer divides by 60, then compares for output
        'Returns departureboard-esque time information.
        If (expectedArrival - timeStamp).TotalSeconds \ 60 > 1 Then
            Return (expectedArrival - timeStamp).TotalSeconds \ 60 & " Minutes"
        ElseIf (expectedArrival - timeStamp).TotalSeconds \ 60 = 1 Then 'if below 1 min, dont produce minutes
            Return (expectedArrival - timeStamp).TotalSeconds \ 60 & " Minute"
        ElseIf (expectedArrival - timeStamp).TotalSeconds \ 60 = 0 Then
            'When the integer division is below 1 (returns 0, eg seconds/60 = 0.9 is rounded to 0), is due.
            Return "Due"
        ElseIf (expectedArrival - timeStamp).TotalSeconds \ 60 < 0 Then
            Return (timeStamp - expectedArrival).TotalSeconds \ 60 & " Minute(s) Late"
        End If

    End Function
    End Class




