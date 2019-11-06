Public Class tubeLink
    Private station1 As stationClass
    Private station2 As stationClass
    Private line As Byte
    Private weight As Int16

    Sub New()
    End Sub

    Sub New(s1 As stationClass, s2 As stationClass, w As Byte)
        station1 = s1
        station2 = s2
        weight = w
    End Sub

    'getters
    Function getStation1()
        Return station1
    End Function
    Function getStation2()
        Return station2
    End Function
    Function getStation2Id()
        Return station2.getId()
    End Function
    Function getLine()
        Return line
    End Function
    Function getWeight()
        Return weight
    End Function
End Class