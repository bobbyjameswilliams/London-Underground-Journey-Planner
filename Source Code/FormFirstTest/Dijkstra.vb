Public Class Dijkstra
    Dim vertex As stationClass 'Stores the vertex (itself) as an aggregation of stationClass
    Dim accDist As Double = Double.PositiveInfinity
    'Stores the accumulated distance as (by default) positive infinity as no path to start has been found
    Dim prevNode As stationClass 'stores the previous node as an aggregate of stationClass
    Dim line As lineClass 'stores the line where link is made as aggregate of lineclass.

    Sub New(s)
        vertex = s
    End Sub
    Sub reinitialise() 'Re sets the members 
        accDist = Double.PositiveInfinity
        prevNode = Nothing
        line = Nothing
    End Sub
    Sub setAccDist(ad) 'sets the accumulated distance
        accDist = ad
    End Sub
    Sub setPrevNode(pn) 'Updates the previous node
        prevNode = pn
    End Sub
    Sub setLine(l) 'sets the line which the link (between vertex and prevNode is made)
        line = l
    End Sub
    ''get
    Function getAccDist() 'Sets the accumulated distance from start 
        Return accDist
    End Function
    Function getVertex() 'Returns an aggregate of stationclass for which this vertex is.
        Return vertex
    End Function
    Function getPrevNode() 'Returns previous node for which the shortest path to the start is.
        Return prevNode
    End Function
    Function getLine() 'returns an aggregate for which the line where this path is taken.
        Return line
    End Function
End Class
