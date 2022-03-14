'Miranda Breves
'RCET0265
'Spring 2022
'Address Label Program
'github url

Option Strict On
Option Explicit On

Public Class AddressLabelForm

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click

        'When the display button is clicked, the select case code checks to see if all text boxes have been filled
        'and makes a message box pop up if they're empty. If all are filled, the display label will be filled with
        'the properly formatted address.

        Select Case ""
            Case FirstNameTextBox.Text
                MsgBox("The first name textbox was left blank.")
                FirstNameTextBox.Focus()
            Case LastNameTextBox.Text
                MsgBox("The last name textbox was left blank.")
                LastNameTextBox.Focus()
            Case StreetAddressTextBox.Text
                MsgBox("The street address textbox was left blank.")
                StreetAddressTextBox.Focus()
            Case CityTextBox.Text
                MsgBox("The city textbox was left blank.")
                CityTextBox.Focus()
            Case StateTextBox.Text
                MsgBox("The state textbox was left blank.")
                StateTextBox.Focus()
            Case ZipTextBox.Text
                MsgBox("The zip code textbox was left blank.")
                ZipTextBox.Focus()

            Case Else
                DisplayLabel.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text &
                                    vbNewLine & StreetAddressTextBox.Text &
                                    vbNewLine & CityTextBox.Text & ", " & StateTextBox.Text &
                                    " " & ZipTextBox.Text
        End Select
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        'Emptying all textboxes and the display label
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        DisplayLabel.Text = ""

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class