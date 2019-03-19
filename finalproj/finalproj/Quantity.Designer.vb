<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quantity
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxqty = New System.Windows.Forms.TextBox()
        Me.Buttonqty = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'TextBoxqty
        '
        Me.TextBoxqty.Location = New System.Drawing.Point(80, 35)
        Me.TextBoxqty.Name = "TextBoxqty"
        Me.TextBoxqty.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxqty.TabIndex = 1
        '
        'Buttonqty
        '
        Me.Buttonqty.Location = New System.Drawing.Point(80, 75)
        Me.Buttonqty.Name = "Buttonqty"
        Me.Buttonqty.Size = New System.Drawing.Size(75, 23)
        Me.Buttonqty.TabIndex = 2
        Me.Buttonqty.Text = "Button"
        Me.Buttonqty.UseVisualStyleBackColor = True
        '
        'Quantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 110)
        Me.Controls.Add(Me.Buttonqty)
        Me.Controls.Add(Me.TextBoxqty)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Quantity"
        Me.Text = "Quantity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxqty As TextBox
    Friend WithEvents Buttonqty As Button
End Class
