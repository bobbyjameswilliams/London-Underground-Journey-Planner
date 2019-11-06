Module Searching
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

    Function binarySearch(ByVal data, ByVal target, ByVal first, ByVal last, ByVal midpoint) 'Recursive Binary Search Algorithm
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
End Module
