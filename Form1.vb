Public Class Form1

    'Declaring arrays
    ReadOnly tourdestinations() As String = {"Gothenburg", "Malmö", "Stockholm"}
    ReadOnly tourmonths() As String = {"June", "July", "August"}
    ReadOnly tourlengths() As String = {"3 Days", "6 Days", "10 Days"}

    'Declaring variables (Used Public declaring to use it in the next form)
    Public destination As String
    Public length As String
    Public Month As String
    Public options As String
    Public basicpackage As String
    Public total As Integer
    Dim optionsprice As Integer
    Dim i, j As Integer

    'Send arrays values to Comboboxes
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CBtourdestination.MaxDropDownItems = tourdestinations.Length
        For Each destination As String In tourdestinations
            CBtourdestination.Items.Add(destination)
        Next
        CBtourlength.MaxDropDownItems = tourlengths.Length
        For Each length As String In tourlengths
            CBtourlength.Items.Add(length)
        Next
        CBtourmonth.MaxDropDownItems = tourmonths.Length
        For Each month As String In tourmonths
            CBtourmonth.Items.Add(month)
        Next
    End Sub

    'Calculating the total price
    Private Sub BtnQuote_Click(sender As Object, e As EventArgs) Handles btnQuote.Click

        'Assigning value to the varibales via comboboxes' selected items
        destination = CBtourdestination.SelectedItem
        length = CBtourlength.SelectedItem
        Month = CBtourmonth.SelectedItem

        total = 0
        optionsprice = 0
        i = 0
        j = 0

        'Implementation for total price based on options choosed
        If destination = "Gothenburg" Then
            If Month = "June" Then
                If length = "3 Days" Then
                    total += 2900
                ElseIf length = "6 Days" Then
                    total += 5500
                ElseIf length = "10 Days" Then
                    total += 9000
                End If
            ElseIf Month = "July" Then
                If length = "3 Days" Then
                    total += 3900
                ElseIf length = "6 Days" Then
                    total += 6500
                ElseIf length = "10 Days" Then
                    total += 10000
                End If
            ElseIf Month = "August" Then
                If length = "3 Days" Then
                    total += 3400
                ElseIf length = "6 Days" Then
                    total += 5900
                ElseIf length = "10 Days" Then
                    total += 9400
                End If
            End If

        ElseIf destination = "Malmö" Then
            If Month = "June" Then
                If length = "3 Days" Then
                    total += 2400
                ElseIf length = "6 Days" Then
                    total += 500
                ElseIf length = "10 Days" Then
                    total += 8500
                End If
            ElseIf Month = "July" Then
                If length = "3 Days" Then
                    total += 3400
                ElseIf length = "6 Days" Then
                    total += 6000
                ElseIf length = "10 Days" Then
                    total += 95000
                End If
            ElseIf Month = "August" Then
                If length = "3 Days" Then
                    total += 2900
                ElseIf length = "6 Days" Then
                    total += 5500
                ElseIf length = "10 Days" Then
                    total += 9000
                End If
            End If
        ElseIf destination = "Stockholm" Then
            If Month = "June" Then
                If length = "3 Days" Then
                    total += 3400
                ElseIf length = "6 Days" Then
                    total += 6000
                ElseIf length = "10 Days" Then
                    total += 10000
                End If
            ElseIf Month = "July" Then
                If length = "3 Days" Then
                    total += 4500
                ElseIf length = "6 Days" Then
                    total += 7000
                ElseIf length = "10 Days" Then
                    total += 11000
                End If
            ElseIf Month = "August" Then
                If length = "3 Days" Then
                    total += 3900
                ElseIf length = "6 Days" Then
                    total += 6400
                ElseIf length = "10 Days" Then
                    total += 10500
                End If
            End If
        End If

        'Adding optionals price to total
        If CBbikehire.Checked = True Then
            i = DoCalculations(length, 650)
            optionsprice += i
            options = "Electric Bike Hire"
        End If
        If CBmealplan.Checked = True Then
            j = DoCalculations(length, 490)
            optionsprice += j
            options = "Meal Plan Package"
        End If
        If CBbikehire.Checked = True And CBmealplan.Checked = True Then
            options = "Electric Bike Hire and Meal plan package"
        Else
            options = "None"
        End If

        'Adding basic package to its variable
        If CBbasicpackage.Checked = True Then
            basicpackage = "Yes"
        Else
            basicpackage = "No"
        End If

        'Final total cost
        total += optionsprice

        'Check errors and Enabling the Order button
        HandleBlankError()
    End Sub

    'Check if any of the tour/length/month is blank
    Private Sub HandleBlankError()
        If CBtourdestination.SelectedItem Is Nothing Or CBtourmonth.SelectedItem Is Nothing Or CBtourlength.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill all your options.", "Error !")
        Else
            btnOrder.Enabled = True
            lblquotedprice.Text = total & " SEK"
        End If
    End Sub

    'Function to calculate options per days that had been choosen
    Private Function DoCalculations(days As String, price As Integer)
        Dim x As Integer

        If days = "3 Days" Then
            x = price * 3
        ElseIf days = "6 Days" Then
            x = price * 3
        ElseIf days = "10 Days" Then
            x = price * 10
        End If
        Return x
    End Function

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        'Show the order window and Hide the current window
        Form2.Show()
        Me.Hide()
    End Sub
End Class