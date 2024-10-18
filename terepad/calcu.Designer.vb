<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calcu
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calcu))
        Me.txtSayi1 = New System.Windows.Forms.TextBox()
        Me.txtSayi2 = New System.Windows.Forms.TextBox()
        Me.btnCikar = New System.Windows.Forms.Button()
        Me.btnTopla = New System.Windows.Forms.Button()
        Me.btnCarp = New System.Windows.Forms.Button()
        Me.btnBol = New System.Windows.Forms.Button()
        Me.lblSonuc = New System.Windows.Forms.Label()
        Me.lstIslemGeçmişi = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()

        ' Form özellikleri
        Me.ClientSize = New System.Drawing.Size(400, 500)
        Me.BackColor = System.Drawing.Color.LightGreen ' Açık yeşil arka plan
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Text = "Calcu"

        ' txtSayi1
        Me.txtSayi1.Location = New System.Drawing.Point(120, 50)
        Me.txtSayi1.Name = "txtSayi1"
        Me.txtSayi1.Size = New System.Drawing.Size(150, 30)
        Me.txtSayi1.TabIndex = 0
        Me.txtSayi1.Font = New Font("Segoe UI", 12)
        Me.txtSayi1.MaxLength = 10
        AddHandler txtSayi1.KeyPress, AddressOf txtSayi_KeyPress

        ' txtSayi2
        Me.txtSayi2.Location = New System.Drawing.Point(120, 100)
        Me.txtSayi2.Name = "txtSayi2"
        Me.txtSayi2.Size = New System.Drawing.Size(150, 30)
        Me.txtSayi2.TabIndex = 1
        Me.txtSayi2.Font = New Font("Segoe UI", 12)
        Me.txtSayi2.MaxLength = 10
        AddHandler txtSayi2.KeyPress, AddressOf txtSayi_KeyPress

        ' btnCikar
        Me.btnCikar.Location = New System.Drawing.Point(220, 150)
        Me.btnCikar.Name = "btnCikar"
        Me.btnCikar.Size = New System.Drawing.Size(75, 40)
        Me.btnCikar.Text = "-"
        Me.btnCikar.UseVisualStyleBackColor = True
        Me.btnCikar.Font = New Font("Segoe UI", 14)
        Me.btnCikar.BackColor = System.Drawing.Color.LightCoral ' Buton rengi
        Me.btnCikar.FlatStyle = FlatStyle.Flat
        Me.btnCikar.FlatAppearance.BorderSize = 0
        AddHandler btnCikar.MouseEnter, AddressOf Button_MouseEnter
        AddHandler btnCikar.MouseLeave, AddressOf Button_MouseLeave

        ' btnTopla
        Me.btnTopla.Location = New System.Drawing.Point(50, 150)
        Me.btnTopla.Name = "btnTopla"
        Me.btnTopla.Size = New System.Drawing.Size(75, 40)
        Me.btnTopla.Text = "+"
        Me.btnTopla.UseVisualStyleBackColor = True
        Me.btnTopla.Font = New Font("Segoe UI", 14)
        Me.btnTopla.BackColor = System.Drawing.Color.MediumSeaGreen ' Daha uyumlu yeşil
        Me.btnTopla.FlatStyle = FlatStyle.Flat
        Me.btnTopla.FlatAppearance.BorderSize = 0
        AddHandler btnTopla.MouseEnter, AddressOf Button_MouseEnter
        AddHandler btnTopla.MouseLeave, AddressOf Button_MouseLeave

        ' btnCarp
        Me.btnCarp.Location = New System.Drawing.Point(50, 200)
        Me.btnCarp.Name = "btnCarp"
        Me.btnCarp.Size = New System.Drawing.Size(75, 40)
        Me.btnCarp.Text = "x"
        Me.btnCarp.UseVisualStyleBackColor = True
        Me.btnCarp.Font = New Font("Segoe UI", 14)
        Me.btnCarp.BackColor = System.Drawing.Color.LightGreen ' Yeşil
        Me.btnCarp.FlatStyle = FlatStyle.Flat
        Me.btnCarp.FlatAppearance.BorderSize = 0
        AddHandler btnCarp.MouseEnter, AddressOf Button_MouseEnter
        AddHandler btnCarp.MouseLeave, AddressOf Button_MouseLeave

        ' btnBol
        Me.btnBol.Location = New System.Drawing.Point(220, 200)
        Me.btnBol.Name = "btnBol"
        Me.btnBol.Size = New System.Drawing.Size(75, 40)
        Me.btnBol.Text = "/"
        Me.btnBol.UseVisualStyleBackColor = True
        Me.btnBol.Font = New Font("Segoe UI", 14)
        Me.btnBol.BackColor = System.Drawing.Color.PaleTurquoise ' Açık mavi
        Me.btnBol.FlatStyle = FlatStyle.Flat
        Me.btnBol.FlatAppearance.BorderSize = 0
        AddHandler btnBol.MouseEnter, AddressOf Button_MouseEnter
        AddHandler btnBol.MouseLeave, AddressOf Button_MouseLeave

        ' lblSonuc
        Me.lblSonuc.AutoSize = True
        Me.lblSonuc.Location = New System.Drawing.Point(120, 300)
        Me.lblSonuc.Name = "lblSonuc"
        Me.lblSonuc.Size = New System.Drawing.Size(50, 25)
        Me.lblSonuc.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        Me.lblSonuc.TabIndex = 6
        Me.lblSonuc.Text = "Sonuç"

        ' lstIslemGeçmişi
        Me.lstIslemGeçmişi.Location = New System.Drawing.Point(50, 350)
        Me.lstIslemGeçmişi.Size = New System.Drawing.Size(250, 100)
        Me.lstIslemGeçmişi.Font = New Font("Segoe UI", 10)
        Me.lstIslemGeçmişi.BorderStyle = BorderStyle.FixedSingle

        ' Form düzenini tamamla
        Me.Controls.Add(Me.lstIslemGeçmişi)
        Me.Controls.Add(Me.lblSonuc)
        Me.Controls.Add(Me.btnBol)
        Me.Controls.Add(Me.btnCarp)
        Me.Controls.Add(Me.btnTopla)
        Me.Controls.Add(Me.btnCikar)
        Me.Controls.Add(Me.txtSayi2)
        Me.Controls.Add(Me.txtSayi1)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    ' Butonların hover efektleri
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = Color.FromArgb(255, 228, 196) ' Daha açık renk
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        ' Orijinal rengine geri döner
        Select Case btn.Name
            Case "btnTopla"
                btn.BackColor = Color.MediumSeaGreen
            Case "btnCikar"
                btn.BackColor = Color.LightCoral
            Case "btnCarp"
                btn.BackColor = Color.LightGreen
            Case "btnBol"
                btn.BackColor = Color.PaleTurquoise
        End Select
    End Sub

    ' Sayı girişi kontrolü
    Private Sub txtSayi_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Sayı olmayan bir karakter girilmesini engeller
        End If
    End Sub

    Friend WithEvents txtSayi1 As TextBox
    Friend WithEvents txtSayi2 As TextBox
    Friend WithEvents btnCikar As Button
    Friend WithEvents btnTopla As Button
    Friend WithEvents btnCarp As Button
    Friend WithEvents btnBol As Button
    Friend WithEvents lblSonuc As Label
    Friend WithEvents lstIslemGeçmişi As ListBox
End Class
