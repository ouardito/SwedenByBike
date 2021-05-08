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
    Private Sub ErrorHandle()
        If CheckCreditCard() = False Or CheckPostCode() = False Or CheckIfNull() = True Or CheckTownName() = False Then
            TBccnum.Text = ""
            TBfullname.Text = ""
            TBhousenum.Text = ""
            TBstreetname.Text = ""
            TBtown.Text = ""
            TBpostcode.Text = ""

            MsgBox("Please Check your details again !")
        Else
            Storedetails()
        End If

    End Sub

    Private Function Storedetails() As String
        ccnum = TBccnum.Text
        fullname = TBfullname.Text
        housenum = TBhousenum.Text
        streetname = TBstreetname.Text
        town = TBtown.Text
        postcode = TBpostcode.Text

        Return ccnum & fullname & housenum & streetname & town & postcode
    End Function

    Private Function WriteToFile(filename As String, text As String)
        Dim Mywriter As StreamWriter

        Mywriter = File.CreateText(filename)
        Mywriter.WriteLine(text)
        Mywriter.Close()

    End Function

    Private Sub BtnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click
        ErrorHandle()
    End Sub
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim dialog As SaveFileDialog
        Dim selected As Boolean
        Dim filename As String
        Dim receipt As String

        dialog = New SaveFileDialog()
        selected = dialog.ShowDialog

        If selected = True Then
            filename = dialog.FileName

            receipt = "Your order details : " & vbCrLf & "Full Name : " & fullname & vbCrLf & "Destination : " & destination & vbCrLf & "Tour month : " & Month & vbCrLf & "Tour length : " & length & vbCrLf & "Options : " & options & vbCrLf & "Total Cost : " & total

            WriteToFile("Bikereceipt.txt", "BikeReceipt.txt")
            WriteToFile(filename, receipt)
        End If
    End Sub
End Class