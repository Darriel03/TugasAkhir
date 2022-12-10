<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FTambahKategori
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNewKat = New System.Windows.Forms.TextBox()
        Me.btnSimpanBrg = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 19)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Tambah Kategori Baru"
        '
        'tbNewKat
        '
        Me.tbNewKat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewKat.Location = New System.Drawing.Point(25, 55)
        Me.tbNewKat.Name = "tbNewKat"
        Me.tbNewKat.Size = New System.Drawing.Size(328, 26)
        Me.tbNewKat.TabIndex = 27
        '
        'btnSimpanBrg
        '
        Me.btnSimpanBrg.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanBrg.Location = New System.Drawing.Point(25, 127)
        Me.btnSimpanBrg.Name = "btnSimpanBrg"
        Me.btnSimpanBrg.Size = New System.Drawing.Size(78, 32)
        Me.btnSimpanBrg.TabIndex = 28
        Me.btnSimpanBrg.Text = "SIMPAN"
        Me.btnSimpanBrg.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(111, 127)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(78, 32)
        Me.btnBatal.TabIndex = 29
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'tambahKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 172)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpanBrg)
        Me.Controls.Add(Me.tbNewKat)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FTambahKategori"
        Me.Text = "Tambah Kategori"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents tbNewKat As TextBox
    Friend WithEvents btnSimpanBrg As Button
    Friend WithEvents btnBatal As Button
End Class