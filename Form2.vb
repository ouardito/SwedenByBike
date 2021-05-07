Public Class Form2

    ReadOnly total As Integer = Form1.total
    ReadOnly destination As String = Form1.destination
    ReadOnly length As String = Form1.length
    ReadOnly Month As String = Form1.Month
    ReadOnly options As String = Form1.options

    Dim ccnum As Integer
    Dim fullname As String
    Dim housenum As String
    Dim streetname As String
    Dim town As String
    Dim postcode As String

    Private Sub CheckIfNull()
        If TBccnum.Text Is Nothing Or TBfullname.Text Is Nothing Or TBhousenum.Text Is Nothing Or TBstreetname.Text Is Nothing Or TBtown.Text Is Nothing And TBpostcode.Text Is Nothing Then
            MsgBox("Please complete all fields")
            TBccnum.Text = ""
            TBfullname.Text = ""
            TBhousenum.Text = ""
            TBpostcode.Text = ""
            TBstreetname.Text = ""
            TBtown.Text = ""
        End If
    End Sub

    Private Sub CheckTownName()
        If TBtown.Text < 2 Or TBtown.Text > 25 Then
            MsgBox("Please enter a valid town name !")
            TBtown.Text = ""
            town = ""
        End If
    End Sub

    Private Sub CheckPostCode()
        If TBpostcode.Text <> 5 Then
            MsgBox("Please enter a valid Post Code number !")
            TBpostcode.Text = ""
            postcode = ""
        End If
    End Sub

    Private Sub CheckCreditCard()
        If Not IsNumeric(TBccnum.Text) Or TBccnum.Text <> 16 Then
            MsgBox("Please enter a valid Credit Card number !")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltotal.Text += "Total Cost : " & total & "SEK"
    End Sub


End Class