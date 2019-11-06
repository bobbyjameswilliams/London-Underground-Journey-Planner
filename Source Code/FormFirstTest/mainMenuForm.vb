Public Class mainMenuForm
    Private Sub searchBut_Click(sender As Object, e As EventArgs) Handles startBut.Click
        searchForm.Show()
        Me.Hide()
    End Sub



    Private Sub mainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '^^Runs loading functions which loads data from csv files into their objects
        loadLines(lines)
        loadStations(stations)
        loadAjacency(lines, stations)


    End Sub

    Private Sub closeBut_Click(sender As Object, e As EventArgs) Handles closeBut.Click
        '^^Closes form and program.
        Me.Close()
    End Sub

End Class
