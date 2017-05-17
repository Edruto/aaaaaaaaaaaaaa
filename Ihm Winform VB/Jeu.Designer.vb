<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jeu))
        Me.plato = New System.Windows.Forms.PictureBox()
        Me.XY30 = New System.Windows.Forms.Panel()
        Me.XY31 = New System.Windows.Forms.Panel()
        Me.XY32 = New System.Windows.Forms.Panel()
        Me.XY00 = New System.Windows.Forms.Panel()
        Me.XY01 = New System.Windows.Forms.Panel()
        Me.XY02 = New System.Windows.Forms.Panel()
        Me.XY11 = New System.Windows.Forms.Panel()
        Me.XY10 = New System.Windows.Forms.Panel()
        Me.XY20 = New System.Windows.Forms.Panel()
        Me.XY12 = New System.Windows.Forms.Panel()
        Me.XY22 = New System.Windows.Forms.Panel()
        Me.XY21 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.plato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'plato
        '
        Me.plato.Image = CType(resources.GetObject("plato.Image"), System.Drawing.Image)
        Me.plato.Location = New System.Drawing.Point(471, 46)
        Me.plato.Name = "plato"
        Me.plato.Size = New System.Drawing.Size(514, 766)
        Me.plato.TabIndex = 0
        Me.plato.TabStop = False
        '
        'XY30
        '
        Me.XY30.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY30.Location = New System.Drawing.Point(526, 158)
        Me.XY30.Name = "XY30"
        Me.XY30.Size = New System.Drawing.Size(128, 128)
        Me.XY30.TabIndex = 1
        '
        'XY31
        '
        Me.XY31.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY31.Location = New System.Drawing.Point(661, 158)
        Me.XY31.Name = "XY31"
        Me.XY31.Size = New System.Drawing.Size(128, 128)
        Me.XY31.TabIndex = 2
        '
        'XY32
        '
        Me.XY32.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY32.Location = New System.Drawing.Point(796, 158)
        Me.XY32.Name = "XY32"
        Me.XY32.Size = New System.Drawing.Size(128, 128)
        Me.XY32.TabIndex = 2
        '
        'XY00
        '
        Me.XY00.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY00.Location = New System.Drawing.Point(526, 567)
        Me.XY00.Name = "XY00"
        Me.XY00.Size = New System.Drawing.Size(128, 128)
        Me.XY00.TabIndex = 2
        '
        'XY01
        '
        Me.XY01.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY01.Location = New System.Drawing.Point(661, 567)
        Me.XY01.Name = "XY01"
        Me.XY01.Size = New System.Drawing.Size(128, 128)
        Me.XY01.TabIndex = 2
        '
        'XY02
        '
        Me.XY02.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY02.Location = New System.Drawing.Point(796, 567)
        Me.XY02.Name = "XY02"
        Me.XY02.Size = New System.Drawing.Size(128, 128)
        Me.XY02.TabIndex = 2
        '
        'XY11
        '
        Me.XY11.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY11.Location = New System.Drawing.Point(661, 434)
        Me.XY11.Name = "XY11"
        Me.XY11.Size = New System.Drawing.Size(128, 128)
        Me.XY11.TabIndex = 3
        '
        'XY10
        '
        Me.XY10.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY10.Location = New System.Drawing.Point(526, 434)
        Me.XY10.Name = "XY10"
        Me.XY10.Size = New System.Drawing.Size(128, 128)
        Me.XY10.TabIndex = 4
        '
        'XY20
        '
        Me.XY20.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY20.Location = New System.Drawing.Point(526, 296)
        Me.XY20.Name = "XY20"
        Me.XY20.Size = New System.Drawing.Size(128, 128)
        Me.XY20.TabIndex = 4
        '
        'XY12
        '
        Me.XY12.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY12.Location = New System.Drawing.Point(796, 434)
        Me.XY12.Name = "XY12"
        Me.XY12.Size = New System.Drawing.Size(128, 128)
        Me.XY12.TabIndex = 4
        '
        'XY22
        '
        Me.XY22.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY22.Location = New System.Drawing.Point(796, 296)
        Me.XY22.Name = "XY22"
        Me.XY22.Size = New System.Drawing.Size(128, 128)
        Me.XY22.TabIndex = 4
        '
        'XY21
        '
        Me.XY21.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.XY21.Location = New System.Drawing.Point(661, 296)
        Me.XY21.Name = "XY21"
        Me.XY21.Size = New System.Drawing.Size(128, 128)
        Me.XY21.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(259, 422)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(128, 128)
        Me.Panel1.TabIndex = 3
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 841)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.XY21)
        Me.Controls.Add(Me.XY22)
        Me.Controls.Add(Me.XY12)
        Me.Controls.Add(Me.XY20)
        Me.Controls.Add(Me.XY10)
        Me.Controls.Add(Me.XY11)
        Me.Controls.Add(Me.XY02)
        Me.Controls.Add(Me.XY01)
        Me.Controls.Add(Me.XY00)
        Me.Controls.Add(Me.XY32)
        Me.Controls.Add(Me.XY31)
        Me.Controls.Add(Me.XY30)
        Me.Controls.Add(Me.plato)
        Me.Name = "Jeu"
        Me.Text = "Jeu"
        CType(Me.plato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents plato As PictureBox
    Friend WithEvents XY30 As Panel
    Friend WithEvents XY31 As Panel
    Friend WithEvents XY32 As Panel
    Friend WithEvents XY00 As Panel
    Friend WithEvents XY01 As Panel
    Friend WithEvents XY02 As Panel
    Friend WithEvents XY11 As Panel
    Friend WithEvents XY10 As Panel
    Friend WithEvents XY20 As Panel
    Friend WithEvents XY12 As Panel
    Friend WithEvents XY22 As Panel
    Friend WithEvents XY21 As Panel
    Friend WithEvents Panel1 As Panel
End Class
