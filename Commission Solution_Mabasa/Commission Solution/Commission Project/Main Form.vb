' Name:         Commission Project
' Purpose:      Display the number of salespeople earning a specific commission
' Programmer:   Jochelle Mae T. Mabasa on September 15, 2020

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the number of salespeople earning a specific commission

        Dim intAmount As Integer
        Dim intCount As Integer

        'declaring 1 dimensional array 
        Dim intCommission() As Integer = {300, 500, 200, 150, 600,
                                          750, 900, 150, 100, 200,
                                          250, 650, 300, 750, 800,
                                          350, 250, 150, 100, 300}

        'inputBox 1-1000
        Integer.TryParse(InputBox("Enter a commission amount (1-1000): ", "Commission"), intAmount)

        'checker if valid ang gi input
        If intAmount < 0 OrElse intAmount > 1000 Then
            MessageBox.Show("Invalid commission amount." & ControlChars.NewLine & "Only 1-1000.", "Input Error!")
        Else
            For Each intElement As Integer In intCommission
                If intAmount = intElement Then
                    intCount += 1
                End If
            Next intElement

            'display
            MessageBox.Show(intCount & " salespeople earned a commission of " & intAmount & ".", "Result")
        End If
    End Sub
End Class
