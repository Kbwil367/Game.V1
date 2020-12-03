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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Stinker = New System.Windows.Forms.PictureBox()
        Me.Stinky = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.Stinker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stinky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Stinker
        '
        Me.Stinker.Image = Global.GameV1.My.Resources.Resources._3x
        Me.Stinker.Location = New System.Drawing.Point(1052, 12)
        Me.Stinker.Name = "Stinker"
        Me.Stinker.Size = New System.Drawing.Size(107, 85)
        Me.Stinker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Stinker.TabIndex = 2
        Me.Stinker.TabStop = False
        '
        'Stinky
        '
        Me.Stinky.Image = Global.GameV1.My.Resources.Resources.images
        Me.Stinky.Location = New System.Drawing.Point(148, 371)
        Me.Stinky.Name = "Stinky"
        Me.Stinky.Size = New System.Drawing.Size(126, 91)
        Me.Stinky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stinky.TabIndex = 1
        Me.Stinky.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Bullet
        '
        Me.Bullet.Image = Global.GameV1.My.Resources.Resources.peepo
        Me.Bullet.Location = New System.Drawing.Point(148, 371)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(41, 29)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Bullet.TabIndex = 3
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'Timer2
        '
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(357, 295)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(497, 436)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(357, 295)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(497, 436)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BackgroundImage = Global.GameV1.My.Resources.Resources.images__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1216, 906)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Stinker)
        Me.Controls.Add(Me.Stinky)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "  "
        CType(Me.Stinker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stinky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Stinky As PictureBox
    Friend WithEvents Stinker As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
