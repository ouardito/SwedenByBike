﻿'Import system io for writing the final receipt
Imports System.IO

Public Class Form2

    'Declaring local varibales and assign their values from the Form1
    ReadOnly total As Integer = Form1.total
    ReadOnly destination As String = Form1.destination
    ReadOnly length As String = Form1.length
    ReadOnly Month As String = Form1.Month
    ReadOnly options As String = Form1.options
    ReadOnly basicpackage As String = Form1.basicpackage

    'Declaring order's values
    Dim ccnum As String
    Dim fullname As String
    Dim housenum As String
    Dim streetname As String
    Dim town As String
    Dim postcode As String

    'Showing the price to the user
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltotal.Text += "Total Cost : " & total & "SEK"
    End Sub

    'Functions for different errors
    Private Function CheckIfNull() As Boolean
        If TBccnum.Text = "" Or TBfullname.Text = "" Or TBhousenum.Text = "" Or TBstreetname.Text = "" Or TBtown.Text = "" And TBpostcode.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function CheckTownName() As Boolean
        If TBtown.TextLength < 2 Then
            Return False
        ElseIf TBtown.TextLength > 25 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function CheckPostCode() As Boolean
        If Not IsNumeric(TBpostcode.Text) Then
            Return False
        ElseIf IsNumeric(TBpostcode.Text) And TBpostcode.TextLength <> 5 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function CheckCreditCard() As Boolean
        If Not IsNumeric(TBccnum.Text) Then
            Return False
        ElseIf IsNumeric(TBccnum.Text) And TBccnum.TextLength <> 16 Then
            Return False
        Else
            Return True
        End If
    End Function
    'Handling errors
    Private Sub ErrorHandle()
        If CheckCreditCard() = False Or CheckPostCode() = False Or CheckIfNull() = True Or CheckTownName() = False Then
            TBccnum.Text = ""
            TBfullname.Text = ""
            TBhousenum.Text = ""
            TBstreetname.Text = ""
            TBtown.Text = ""
            TBpostcode.Text = ""

            MessageBox.Show("Please Check your details again !", "Error !")
        Else
            Storedetails()
        End If

    End Sub

    'Function to store order details
    Private Function Storedetails() As String
        ccnum = TBccnum.Text
        fullname = TBfullname.Text
        housenum = TBhousenum.Text
        streetname = TBstreetname.Text
        town = TBtown.Text
        postcode = TBpostcode.Text

        Return ccnum & fullname & housenum & streetname & town & postcode
    End Function
    'Function to write the final receipt
    Private Sub Writedetails(text As String)
        Dim MyWriter As StreamWriter
        Dim dialog As SaveFileDialog
        Dim selected As Boolean
        Dim filename As String

        dialog = New SaveFileDialog With {
            .FileName = "BikeReceipt.txt", 'Force the Dialog to choose the provided filename
            .Filter = "txt files (*.txt)|*.txt", 'Force the system to choose only .txt as the type of file
            .FilterIndex = 1,
            .RestoreDirectory = True
        }

        selected = dialog.ShowDialog

        If selected = True Then
            filename = dialog.FileName

            MyWriter = File.CreateText(filename)
            MyWriter.WriteLine(text)
            MyWriter.Close()

        End If

    End Sub

    Private Sub BtnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click
        ErrorHandle()
    End Sub
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Declaring the receipt text 
        Dim receipt As String
        receipt = "Your order details : " & vbCrLf & "Full Name : " & fullname & vbCrLf & "Destination : " & destination & vbCrLf & "Tour month : " & Month & vbCrLf & "Tour length : " & length & vbCrLf & "Options : " & options & vbCrLf & "Basic package : " & basicpackage & vbCrLf & vbCrLf & "Total Cost : " & total & vbCrLf & vbCrLf & "Thank you for choosing our services. See you soon!"

        Writedetails(receipt)
    End Sub

End Class