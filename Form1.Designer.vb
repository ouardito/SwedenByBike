<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CBtourdestination = New System.Windows.Forms.ComboBox()
        Me.CBtourmonth = New System.Windows.Forms.ComboBox()
        Me.CBtourlength = New System.Windows.Forms.ComboBox()
        Me.btnQuote = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBbikehire = New System.Windows.Forms.CheckBox()
        Me.CBmealplan = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblquotedprice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CBtourdestination
        '
        Me.CBtourdestination.FormattingEnabled = True
        Me.CBtourdestination.Items.AddRange(New Object() {""})
        Me.CBtourdestination.Location = New System.Drawing.Point(12, 79)
        Me.CBtourdestination.Name = "CBtourdestination"
        Me.CBtourdestination.Size = New System.Drawing.Size(121, 21)
        Me.CBtourdestination.TabIndex = 0
        '
        'CBtourmonth
        '
        Me.CBtourmonth.FormattingEnabled = True
        Me.CBtourmonth.Location = New System.Drawing.Point(177, 79)
        Me.CBtourmonth.Name = "CBtourmonth"
        Me.CBtourmonth.Size = New System.Drawing.Size(121, 21)
        Me.CBtourmonth.TabIndex = 1
        '
        'CBtourlength
        '
        Me.CBtourlength.FormattingEnabled = True
        Me.CBtourlength.Location = New System.Drawing.Point(341, 79)
        Me.CBtourlength.Name = "CBtourlength"
        Me.CBtourlength.Size = New System.Drawing.Size(121, 21)
        Me.CBtourlength.TabIndex = 2
        '
        'btnQuote
        '
        Me.btnQuote.Location = New System.Drawing.Point(120, 388)
        Me.btnQuote.Name = "btnQuote"
        Me.btnQuote.Size = New System.Drawing.Size(75, 23)
        Me.btnQuote.TabIndex = 3
        Me.btnQuote.Text = "Quote"
        Me.btnQuote.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Enabled = False
        Me.btnOrder.Location = New System.Drawing.Point(288, 388)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(99, 23)
        Me.btnOrder.TabIndex = 4
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tour Destination"
        '
        'CBbikehire
        '
        Me.CBbikehire.AutoSize = True
        Me.CBbikehire.Location = New System.Drawing.Point(12, 289)
        Me.CBbikehire.Name = "CBbikehire"
        Me.CBbikehire.Size = New System.Drawing.Size(107, 17)
        Me.CBbikehire.TabIndex = 6
        Me.CBbikehire.Text = "Electric Bike Hire"
        Me.CBbikehire.UseVisualStyleBackColor = True
        '
        'CBmealplan
        '
        Me.CBmealplan.AutoSize = True
        Me.CBmealplan.Location = New System.Drawing.Point(12, 266)
        Me.CBmealplan.Name = "CBmealplan"
        Me.CBmealplan.Size = New System.Drawing.Size(119, 17)
        Me.CBmealplan.TabIndex = 7
        Me.CBmealplan.Text = "Meal Package Plan"
        Me.CBmealplan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tour Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(338, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tour Length"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Optional Upgrades"
        '
        'lblquotedprice
        '
        Me.lblquotedprice.Location = New System.Drawing.Point(174, 185)
        Me.lblquotedprice.Name = "lblquotedprice"
        Me.lblquotedprice.Size = New System.Drawing.Size(288, 156)
        Me.lblquotedprice.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 450)
        Me.Controls.Add(Me.lblquotedprice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBmealplan)
        Me.Controls.Add(Me.CBbikehire)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnQuote)
        Me.Controls.Add(Me.CBtourlength)
        Me.Controls.Add(Me.CBtourmonth)
        Me.Controls.Add(Me.CBtourdestination)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBtourdestination As ComboBox
    Friend WithEvents CBtourmonth As ComboBox
    Friend WithEvents CBtourlength As ComboBox
    Friend WithEvents btnQuote As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CBbikehire As CheckBox
    Friend WithEvents CBmealplan As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblquotedprice As Label
End Class
