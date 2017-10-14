' Program:      Smart Car Rental
' Author:       Tu Tong
' Date:         October 13, 2017
' Purpose:      This application calculate and displays
'               the total cost of renting a car for a
'               period of time and distance.

' Prevent automatic conversion of values
Option Strict On

Public Class frmSmartCarRental

    ' Declare price per day rental class variable
    Const _cdecPricePerDay = 29.99D

    ' Declare price per mile rental class variable
    Const _cdecPricePerMile = 0.39D

    Private Sub frmSmartCarRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.

        ' display the cost heading
        lblRentalCost.Text = "Only " & _cdecPricePerDay.ToString("C") & " per day plus " & _cdecPricePerMile.ToString("C") & " per mile."

        ' clear the Text property of Number of Days TextBox
        ' Number of Miles TextBox, and Total Cost Label
        txtNumberOfDays.Clear()
        txtNumberOfMiles.Clear()
        lblTotalCost.Text = ""

        ' set the focus on the Number of Days TextBox
        txtNumberOfDays.Focus()

    End Sub

    Private Sub btnDisplayFare_Click(sender As Object, e As EventArgs) Handles btnDisplayFare.Click
        ' This event handler is executed when the user taps or clicks
        ' the Display Fare button. It calculates and display the cost
        ' of the car rental (number of days times the cost per day,
        ' plus number of miles times the cost per mile)

        ' Declare and initialize the variables
        Dim strNumberOfDays As String
        Dim strNumberOfMiles As String
        Dim intNumberOfDays As Integer
        Dim intNumberOfMiles As Integer
        Dim decTotalCost As Decimal

        ' Placing the number of days rented in a variable
        ' and convert the value to an integer
        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)

        ' Placing the number of miles rented in a variable
        ' and convert the value to an integer
        strNumberOfMiles = txtNumberOfMiles.Text
        intNumberOfMiles = Convert.ToInt32(strNumberOfMiles)

        ' Calculating the total cost of car rental
        decTotalCost = intNumberOfDays * _cdecPricePerDay + intNumberOfMiles * _cdecPricePerMile

        ' Convert the decimal total cost of rental to
        ' a string currency value and place it in the
        ' Text property of the Total Cost label
        lblTotalCost.Text = decTotalCost.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user taps or clicks
        ' the Clear button.

        ' clear the Text property of Number of Days TextBox
        ' Number of Miles TextBox, and Total Cost Label
        txtNumberOfDays.Clear()
        txtNumberOfMiles.Clear()
        lblTotalCost.Text = ""

        ' set the focus on the Number of Days TextBox
        txtNumberOfDays.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application

        Close()

    End Sub
End Class
