Module Validation
    Public IsNameInvalid = False
    Public ErrMessage As String

    Public Sub IsValidName(Name As String)
        IsNameInvalid = False
        If Len(Name) = 0 Then
            IsNameInvalid = True
            ErrMessage = "Please enter a name"

            Exit Sub
        End If

        If Text.RegularExpressions.Regex.Match(Name, "\d").Success Then
            IsNameInvalid = True
            ErrMessage = "Name can only contain alpahabets"

            Exit Sub
        End If
    End Sub
End Module
