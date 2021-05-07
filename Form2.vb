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
    Dim towncity As String
    Dim zipcode As String


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltotal.Text += "total Cost : " & total & "SEK"
    End Sub


End Class