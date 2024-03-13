Public Class CSWETestComponent
    Implements ISWETestComponenet

    Private answer As String

    Private Sub Sub1(str1)
        answer = str1.LCase()
    End Sub

    Private Sub Sub2(str1, str2)


    End Sub
    Public Function PubFunc(str1 As String, str2 As String, bFlag As Boolean) As String Implements ISWETestComponenet.PubFunc
        If (bFlag = True) Then
            Sub1(str1)
        Else
            Sub2(str1, str2)
        End If
    End Function
End Class
