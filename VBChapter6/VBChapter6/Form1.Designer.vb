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
        Me.btnGetRetail = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWholesale = New System.Windows.Forms.TextBox()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGetRetail
        '
        Me.btnGetRetail.Location = New System.Drawing.Point(114, 334)
        Me.btnGetRetail.Name = "btnGetRetail"
        Me.btnGetRetail.Size = New System.Drawing.Size(117, 49)
        Me.btnGetRetail.TabIndex = 0
        Me.btnGetRetail.Text = "Get Retail"
        Me.btnGetRetail.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(488, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 49)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Wholesale Cost of Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Markup %"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Retail Price"
        '
        'txtWholesale
        '
        Me.txtWholesale.Location = New System.Drawing.Point(337, 60)
        Me.txtWholesale.Name = "txtWholesale"
        Me.txtWholesale.Size = New System.Drawing.Size(100, 22)
        Me.txtWholesale.TabIndex = 5
        '
        'txtMarkup
        '
        Me.txtMarkup.Location = New System.Drawing.Point(337, 137)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(100, 22)
        Me.txtMarkup.TabIndex = 6
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Location = New System.Drawing.Point(337, 212)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtRetailPrice.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Retail Price Calculator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRetailPrice)
        Me.Controls.Add(Me.txtMarkup)
        Me.Controls.Add(Me.txtWholesale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnGetRetail)
        Me.Name = "Form1"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGetRetail As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtWholesale As TextBox
    Friend WithEvents txtMarkup As TextBox
    Friend WithEvents txtRetailPrice As TextBox
    Friend WithEvents Label4 As Label
End Class
