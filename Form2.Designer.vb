<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TBccnum = New System.Windows.Forms.TextBox()
        Me.TBfullname = New System.Windows.Forms.TextBox()
        Me.TBhousenum = New System.Windows.Forms.TextBox()
        Me.TBstreetname = New System.Windows.Forms.TextBox()
        Me.TBtown = New System.Windows.Forms.TextBox()
        Me.TBpostcode = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnStore = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBccnum
        '
        Me.TBccnum.Location = New System.Drawing.Point(12, 70)
        Me.TBccnum.Name = "TBccnum"
        Me.TBccnum.Size = New System.Drawing.Size(221, 20)
        Me.TBccnum.TabIndex = 0
        '
        'TBfullname
        '
        Me.TBfullname.Location = New System.Drawing.Point(12, 96)
        Me.TBfullname.Name = "TBfullname"
        Me.TBfullname.Size = New System.Drawing.Size(221, 20)
        Me.TBfullname.TabIndex = 1
        '
        'TBhousenum
        '
        Me.TBhousenum.Location = New System.Drawing.Point(12, 122)
        Me.TBhousenum.Name = "TBhousenum"
        Me.TBhousenum.Size = New System.Drawing.Size(221, 20)
        Me.TBhousenum.TabIndex = 2
        '
        'TBstreetname
        '
        Me.TBstreetname.Location = New System.Drawing.Point(12, 148)
        Me.TBstreetname.Name = "TBstreetname"
        Me.TBstreetname.Size = New System.Drawing.Size(221, 20)
        Me.TBstreetname.TabIndex = 3
        '
        'TBtown
        '
        Me.TBtown.Location = New System.Drawing.Point(12, 174)
        Me.TBtown.Name = "TBtown"
        Me.TBtown.Size = New System.Drawing.Size(221, 20)
        Me.TBtown.TabIndex = 4
        '
        'TBpostcode
        '
        Me.TBpostcode.Location = New System.Drawing.Point(12, 200)
        Me.TBpostcode.Name = "TBpostcode"
        Me.TBpostcode.Size = New System.Drawing.Size(221, 20)
        Me.TBpostcode.TabIndex = 5
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(529, 34)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(50, 13)
        Me.lbltotal.TabIndex = 6
        Me.lbltotal.Text = "Total is : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Credit card number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Full name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Hosue Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Street Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Town / City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(255, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Zip Code"
        '
        'btnStore
        '
        Me.btnStore.Location = New System.Drawing.Point(288, 382)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(101, 23)
        Me.btnStore.TabIndex = 13
        Me.btnStore.Text = "Store Details"
        Me.btnStore.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(409, 382)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(101, 23)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "Print Receipt"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnStore)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.TBpostcode)
        Me.Controls.Add(Me.TBtown)
        Me.Controls.Add(Me.TBstreetname)
        Me.Controls.Add(Me.TBhousenum)
        Me.Controls.Add(Me.TBfullname)
        Me.Controls.Add(Me.TBccnum)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBccnum As TextBox
    Friend WithEvents TBfullname As TextBox
    Friend WithEvents TBhousenum As TextBox
    Friend WithEvents TBstreetname As TextBox
    Friend WithEvents TBtown As TextBox
    Friend WithEvents TBpostcode As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnStore As Button
    Friend WithEvents btnPrint As Button
End Class
