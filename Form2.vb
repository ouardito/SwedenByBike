Imports System.IO

Public Class Form2

    ReadOnly total As Integer = Form1.total
    ReadOnly destination As String = Form1.destination
    ReadOnly length As String = Form1.length
    ReadOnly Month As String = Form1.Month
    ReadOnly options As String = Form1.options

    Dim ccnum As String
    Dim fullname As String
    Dim housenum As String
    Dim streetname As String
    Dim town As String
    Dim postcode As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltotal.Text += "Total Cost : " & total & "SEK"
    End Sub

    Private Function CheckIfNull() As Boolean
        If TBccnum.Text Is Nothing Or TBfullname.Text Is Nothing Or TBhousenum.Text Is Nothing Or TBstreetname.Text Is Nothing Or TBtown.Text Is Nothing And TBpostcode.Text Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CheckTownName() As Boolean
        If TBtown.TextLength < 2 Or TBtown.TextLength > 25 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function CheckPostCode() As Boolean
        If Not IsNumeric(TBpostcode.Text) Then
            Return False
        ElseIf IsNumeric(TBpostcode.Text) Then
            If TBpostcode.Text <> 5 Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Private Function CheckCreditCard() As Boolean
        If Not IsNumeric(TBccnum.Text) Then
            Return False
        ElseIf IsNumeric(TBccnum.Text) Then
            If TBccnum.Text <> 16 Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Private Function Storedetails() As String
        ccnum = TBccnum.Text
        fullname = TBfullname.Text
        housenum = TBhousenum.Text
        streetname = TBstreetname.Text
        town = TBtown.Text
        postcode = TBpostcode.Text

        Return ccnum & fullname & housenum & streetname & town & postcode
    End Function


    Private Sub ErrorHandle()
        If CheckIfNull() = True Or CheckTownName() = False Or CheckPostCode() = False Or CheckCreditCard() = False Then
            TBccnum.Text = ""
            TBfullname.Text = ""
            TBhousenum.Text = ""
            TBstreetname.Text = ""
            TBtown.Text = ""
            TBpostcode.Text = ""

            MsgBox("Please Check your details again !")
        ElseIf CheckIfNull() = False And CheckTownName() = True And CheckPostCode() = True And CheckCreditCard() = True Then
            Storedetails()
        End If

        Storedetails()


    End Sub


    Private Sub WriteDetails()
        Dim Mywriter As StreamWriter
        Dim dialog As SaveFileDialog
        Dim selected As Boolean
        Dim receipt As String
        Dim filename As String

        receipt = "Your order details : " & vbCrLf & "Full Name : " & fullname & vbCrLf & "Destination : " & destination & vbCrLf & "Tour month : " & Month & vbCrLf & "Tour length : " & length & vbCrLf & "Total Cost : " & total

        dialog = New SaveFileDialog()
        selected = dialog.ShowDialog

        If selected = True Then
            filename = "BikeReceipt.txt"

            Mywriter = File.CreateText(filename)
            Mywriter.WriteLine(receipt)
            Mywriter.Close()
        End If

    End Sub

    Private Sub btnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click
        ErrorHandle()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        WriteDetails()
    End Sub
End Class