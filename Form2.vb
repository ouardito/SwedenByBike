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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltotal.Text += "Total Cost : " & total & "SEK"
    End Sub


End Class