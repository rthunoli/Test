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
        Me.txtcon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblbin = New System.Windows.Forms.Label()
        Me.lblhex = New System.Windows.Forms.Label()
        Me.lbloct = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcon
        '
        Me.txtcon.Location = New System.Drawing.Point(149, 57)
        Me.txtcon.Name = "txtcon"
        Me.txtcon.Size = New System.Drawing.Size(100, 20)
        Me.txtcon.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "HEX"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "OCT"
        '
        'lblbin
        '
        Me.lblbin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblbin.Location = New System.Drawing.Point(149, 99)
        Me.lblbin.Name = "lblbin"
        Me.lblbin.Size = New System.Drawing.Size(243, 21)
        Me.lblbin.TabIndex = 1
        '
        'lblhex
        '
        Me.lblhex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblhex.Location = New System.Drawing.Point(149, 130)
        Me.lblhex.Name = "lblhex"
        Me.lblhex.Size = New System.Drawing.Size(243, 21)
        Me.lblhex.TabIndex = 1
        '
        'lbloct
        '
        Me.lbloct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbloct.Location = New System.Drawing.Point(149, 161)
        Me.lbloct.Name = "lbloct"
        Me.lbloct.Size = New System.Drawing.Size(243, 21)
        Me.lbloct.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(278, 230)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 280)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbloct)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblhex)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblbin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblbin As Label
    Friend WithEvents lblhex As Label
    Friend WithEvents lbloct As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
