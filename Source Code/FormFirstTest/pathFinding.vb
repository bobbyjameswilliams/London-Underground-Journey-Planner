Module pathFinding
    '///// DIJKSTRA
    Function findPath(ByVal stationMax, ByVal stations, ByVal lines, ByVal dest) 'Dijkstas pathFinding algorithm
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
            For Each lserved In stations(u.getVertex.getId()).getLines()
                '^^^as ajacencies are dependant on lines, checks all ajacencies ajacencies for station considered
                For Each ajacency In lines(lserved.getId()).getStationsOnLine.item(u.getVertex)   'every ajacency of the current vertex

                    If pQueue.Contains(vertexArr(ajacency.getStation2.getID)) Then  'that is in the pQueue(IE not already considered)
                        'Console.WriteLine(t)
                        t += 1
                        change = False
                        Try    'Try is needed because error is thrown if is the node
                            If lserved.getId() <> vertexArr(u.getPrevNode.getId()).getLine.getId() Then
                                '^^^if line change add weight of 5 to alt (average interchange time)
                                change = True
                            End If
                        Catch ex As System.NullReferenceException
                        End Try
                        If change = True Then
                            alt = u.getAccDist + ajacency.getWeight() + 5
                        Else
                            alt = u.getAccDist + ajacency.getWeight()
                        End If

                        If alt < vertexArr(ajacency.getStation2Id).getAccDist Then
                            '^^^if this product is smaller than the ajacent stations distance from A already then...

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
End Module
