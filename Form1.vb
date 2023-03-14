Public Class Form1
    Private Sub btnInternetSpeed_Click(sender As Object, e As EventArgs) Handles btnInternetSpeed.Click
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumofSpeeds As Decimal
        Dim decAverage As Decimal = 60

        Dim strIBoxMessage As String = " Enter the number of Mbps of home internet speed user # "
        Dim strIBoxTitle As String = " Internet Speed "
        Dim strNotNumericErrMsg As String = " Error - Enter the speed of your home internet connection "
        Dim strNegErrMsg As String = " Error - Enter a valid speed"

        Dim intMaxEntries As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strIBoxMessage & intEntries, strIBoxMessage)

        'Do Until intEntries > intMaxEntries
        'or until strSpeed is empty
        Do Until intEntries > intMaxEntries Or strSpeed = ""
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                If decSpeed > 0 Then
                    lstInternetSpeed.Items.Add(decSpeed)
                    decSumofSpeeds += decSpeed
                    intEntries += 1
                    strIBoxMessage = strIBoxMessage


                Else
                    strIBoxMessage = strNegErrMsg

                End If
            Else
                strIBoxMessage = strNotNumericErrMsg

            End If

            If intEntries <= intMaxEntries Then
                strSpeed = InputBox(strIBoxMessage & intEntries, strIBoxTitle)
            End If
        Loop

        lblAverageInt.Visible = True

        If intEntries > 1 Then
            decAverage = decSumofSpeeds / (intEntries - 1)
            lblAverageInt.Text = " Average Internet Speed: " & decAverage.ToString("F2") & " Mbps "
        Else
            lblAverageInt.Text = " No Speed Values Entered "
        End If
        btnInternetSpeed.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAverageInt.Text = ""
        lstInternetSpeed.Items.Clear()
        btnInternetSpeed.Enabled = True
    End Sub
End Class
