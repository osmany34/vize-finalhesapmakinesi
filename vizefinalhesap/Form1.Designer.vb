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
        Me.txtVize = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.btnHesapla = New System.Windows.Forms.Button()
        Me.lblSonuc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtVize
        '
        Me.txtVize.Location = New System.Drawing.Point(164, 25)
        Me.txtVize.Name = "txtVize"
        Me.txtVize.Size = New System.Drawing.Size(174, 22)
        Me.txtVize.TabIndex = 0
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(164, 64)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(174, 22)
        Me.txtFinal.TabIndex = 1
        '
        'btnHesapla
        '
        Me.btnHesapla.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnHesapla.Location = New System.Drawing.Point(164, 145)
        Me.btnHesapla.Name = "btnHesapla"
        Me.btnHesapla.Size = New System.Drawing.Size(98, 37)
        Me.btnHesapla.TabIndex = 2
        Me.btnHesapla.Text = "Hesapla"
        Me.btnHesapla.UseVisualStyleBackColor = True
        '
        'lblSonuc
        '
        Me.lblSonuc.AutoSize = True
        Me.lblSonuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSonuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSonuc.Location = New System.Drawing.Point(102, 209)
        Me.lblSonuc.Name = "lblSonuc"
        Me.lblSonuc.Size = New System.Drawing.Size(218, 16)
        Me.lblSonuc.TabIndex = 3
        Me.lblSonuc.Text = "Sonucunuz Burada Görünecek."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(9, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Vize Notu Giriniz:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(9, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Final Notu Giriniz:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(397, 289)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSonuc)
        Me.Controls.Add(Me.btnHesapla)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtVize)
        Me.Name = "Form1"
        Me.Text = "Vize Final Hesaplama"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVize As TextBox
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents btnHesapla As Button
    Friend WithEvents lblSonuc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
