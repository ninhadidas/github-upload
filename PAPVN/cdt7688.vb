Public Class cdt7688
    Public Shared Function ConvertToDateSQL(ddate As Date) As String
        Dim Y As String
        Dim M As String
        Dim D As String
        Y = Year(ddate)
        If Month(ddate) < 10 Then
            M = "0" & Month(ddate)
        Else
            M = Month(ddate)
        End If
        If DateAndTime.Day(ddate) < 10 Then
            D = "0" & DateAndTime.Day(ddate)
        Else
            D = DateAndTime.Day(ddate)
        End If
        Return Y & M & D
    End Function

End Class
