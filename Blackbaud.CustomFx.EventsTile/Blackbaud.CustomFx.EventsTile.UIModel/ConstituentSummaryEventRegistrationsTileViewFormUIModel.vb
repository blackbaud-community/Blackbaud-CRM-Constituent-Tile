Public Class ConstituentSummaryEventRegistrationsTileViewFormUIModel

    Private Sub ConstituentSummaryEventRegistrationsTileViewFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        If Me.REGISTRATIONS.Value.Count <= 1 Then
            Me.REGISTRATIONCOUNTTEXT.Visible = False
            Me.PREVIOUSREGISTRATION.Visible = False
            Me.NEXTREGISTRATION.Visible = False
        End If

        If Me.REGISTRATIONS.Value.Any Then
            Me.CURRENTREGISTRANTINDEX.Value = 0
            Draw()
        Else
            Me.EVENTNAME.Visible = False
            Me.STARTDATE.Visible = False
            Me.REGISTRATION.Visible = False
            Me.STATUS.Visible = False
            Me.TYPE.Visible = False
            Me.NOREGISTRATIONS.Visible = True
        End If


    End Sub

    Private Sub Draw()
        Dim currentRegistrant As ConstituentSummaryEventRegistrationsTileViewFormREGISTRATIONSUIModel = Nothing
        currentRegistrant = GetCurrentRegistrant()

        If currentRegistrant IsNot Nothing Then
            Me.CURRENTREGISTRANTID.Value = currentRegistrant.REGISTRANTID.Value
            Me.REGISTRATIONCOUNTTEXT.Value = String.Concat("(", (Me.CURRENTREGISTRANTINDEX.Value + 1).ToString(Globalization.CultureInfo.InvariantCulture), " of ", Me.REGISTRATIONS.Value.Count.ToString(Globalization.CultureInfo.InvariantCulture), ")")

            Me.REGISTRATION.Value = currentRegistrant.REGISTRATIONOPTIONNAME.Value
            Me.TYPE.Value = If(currentRegistrant.ISWALKIN.Value, "Walk-in", "Preregistration")
            Me.STATUS.Value = currentRegistrant.STATUSCODE.Translation

            Me.EVENTNAME.Caption = currentRegistrant.EVENTNAME.Value
            Me.STARTDATE.Value = currentRegistrant.STARTDATE.Value

        End If

    End Sub

    Private Function GetCurrentRegistrant() As ConstituentSummaryEventRegistrationsTileViewFormREGISTRATIONSUIModel
        Return Me.REGISTRATIONS.Value(Me.CURRENTREGISTRANTINDEX.Value)
    End Function

    Private Sub _previousregistration_InvokeAction() Handles _previousregistration.InvokeAction
        If Me.CURRENTREGISTRANTINDEX.Value = 0 Then
            Me.CURRENTREGISTRANTINDEX.Value = Me.REGISTRATIONS.Value.Count - 1
        Else
            Me.CURRENTREGISTRANTINDEX.Value -= 1
        End If

        Draw()
    End Sub
    Private Sub _nextregistration_InvokeAction() Handles _nextregistration.InvokeAction
        If Me.CURRENTREGISTRANTINDEX.Value = Me.REGISTRATIONS.Value.Count - 1 Then
            CURRENTREGISTRANTINDEX.Value = 0
        Else
            Me.CURRENTREGISTRANTINDEX.Value += 1
        End If

        Draw()
    End Sub
End Class