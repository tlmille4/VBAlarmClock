'-----------------------------------------------------------------------------------------------------
'-                                          File Name : frmMain                                      - 
'-                                          Part of Project: Assign10                                -
'-----------------------------------------------------------------------------------------------------
'-                                          Written By: Tyler Miller                                 -
'-                                          Written On: 04/17/2016                                   -
'-----------------------------------------------------------------------------------------------------
'- File Purpose:                                                                                     -
'- This file is the main form that runs when the application is launched. It will show a clock and   -
'- allow the user to set an alarm                                                                    - 
'-----------------------------------------------------------------------------------------------------
'- Program Purpose:                                                                                  -
'-                                                                                                   -
'- This program is designed to utilize the ClockControl control on the form to show a clock with an  -
'- alarm. If the user turns on the alarm and sets a specific time, the program will sound a tone at  -
'- the specified time.                                                                               -
'-----------------------------------------------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):                                                      -
'- (None)                                                                                            –
'-----------------------------------------------------------------------------------------------------
Public Class frmMain
    Private Sub cmdNightColors_Click(sender As Object, e As EventArgs) Handles cmdNightColors.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmdNightColors                                    -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 01/25/2015                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the user clicks the Use Night Colors button. It will make the -
        '- background darker, which is more comfortable to read at nighttime hours                          -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        ClockControl1.ForeColor = Color.DarkSlateBlue
        Me.BackColor = Color.Black
    End Sub

    Private Sub cmdDayColors_Click(sender As Object, e As EventArgs) Handles cmdDayColors.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmdDayColors                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 01/25/2015                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the user clicks the Use Day Colors button. It will make the   -
        '- background lighter, which is more comfortable to read at daytime hours                           -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        Me.BackColor = SystemColors.Control
        ClockControl1.ForeColor = Color.Black
    End Sub
End Class
