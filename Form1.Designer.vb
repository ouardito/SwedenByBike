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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBtourdestination = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBbasicpackage = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CBtourmonth
        '
        Me.CBtourmonth.FormattingEnabled = True
        Me.CBtourmonth.Location = New System.Drawing.Point(181, 143)
        Me.CBtourmonth.Name = "CBtourmonth"
        Me.CBtourmonth.Size = New System.Drawing.Size(121, 21)
        Me.CBtourmonth.TabIndex = 1
        '
        'CBtourlength
        '
        Me.CBtourlength.FormattingEnabled = True
        Me.CBtourlength.Location = New System.Drawing.Point(345, 143)
        Me.CBtourlength.Name = "CBtourlength"
        Me.CBtourlength.Size = New System.Drawing.Size(121, 21)
        Me.CBtourlength.TabIndex = 2
        '
        'btnQuote
        '
        Me.btnQuote.Location = New System.Drawing.Point(140, 402)
        Me.btnQuote.Name = "btnQuote"
        Me.btnQuote.Size = New System.Drawing.Size(75, 36)
        Me.btnQuote.TabIndex = 3
        Me.btnQuote.Text = "Quote"
        Me.btnQuote.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Enabled = False
        Me.btnOrder.Location = New System.Drawing.Point(254, 402)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 36)
        Me.btnOrder.TabIndex = 4
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tour Destination"
        '
        'CBbikehire
        '
        Me.CBbikehire.AutoSize = True
        Me.CBbikehire.Location = New System.Drawing.Point(16, 256)
        Me.CBbikehire.Name = "CBbikehire"
        Me.CBbikehire.Size = New System.Drawing.Size(107, 17)
        Me.CBbikehire.TabIndex = 6
        Me.CBbikehire.Text = "Electric Bike Hire"
        Me.CBbikehire.UseVisualStyleBackColor = True
        '
        'CBmealplan
        '
        Me.CBmealplan.AutoSize = True
        Me.CBmealplan.Location = New System.Drawing.Point(16, 233)
        Me.CBmealplan.Name = "CBmealplan"
        Me.CBmealplan.Size = New System.Drawing.Size(119, 17)
        Me.CBmealplan.TabIndex = 7
        Me.CBmealplan.Text = "Meal Package Plan"
        Me.CBmealplan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tour Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(342, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tour Length"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Optional Upgrades"
        '
        'lblquotedprice
        '
        Me.lblquotedprice.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquotedprice.Location = New System.Drawing.Point(156, 340)
        Me.lblquotedprice.Name = "lblquotedprice"
        Me.lblquotedprice.Size = New System.Drawing.Size(163, 41)
        Me.lblquotedprice.TabIndex = 11
        Me.lblquotedprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Jokerman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(95, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(285, 43)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "SWEDEN BY BIKE"
        '
        'CBtourdestination
        '
        Me.CBtourdestination.FormattingEnabled = True
        Me.CBtourdestination.Location = New System.Drawing.Point(16, 143)
        Me.CBtourdestination.Name = "CBtourdestination"
        Me.CBtourdestination.Size = New System.Drawing.Size(121, 21)
        Me.CBtourdestination.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(178, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Basic Package"
        '
        'CBbasicpackage
        '
        Me.CBbasicpackage.AutoSize = True
        Me.CBbasicpackage.Location = New System.Drawing.Point(181, 256)
        Me.CBbasicpackage.Name = "CBbasicpackage"
        Me.CBbasicpackage.Size = New System.Drawing.Size(79, 17)
        Me.CBbasicpackage.TabIndex = 15
        Me.CBbasicpackage.Text = "Yes Please"
        Me.CBbasicpackage.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(181, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = " - Includes hotel room and hire of a basic bike." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBbasicpackage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBtourdestination)
        Me.Controls.Add(Me.Label5)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Sweden by bike"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Label5 As Label
    Friend WithEvents CBtourdestination As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CBbasicpackage As CheckBox
    Friend WithEvents Label7 As Label
End Class
