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
        Me.LabelPoolAddress = New System.Windows.Forms.Label()
        Me.LabelMyrAddress = New System.Windows.Forms.Label()
        Me.LabelThreads = New System.Windows.Forms.Label()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.TextBoxPoolAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxMyrAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxThreads = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LabelOutput = New System.Windows.Forms.Label()
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelPoolAddress
        '
        Me.LabelPoolAddress.AutoSize = True
        Me.LabelPoolAddress.Location = New System.Drawing.Point(156, 176)
        Me.LabelPoolAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPoolAddress.Name = "LabelPoolAddress"
        Me.LabelPoolAddress.Size = New System.Drawing.Size(99, 17)
        Me.LabelPoolAddress.TabIndex = 0
        Me.LabelPoolAddress.Text = "Pool address: "
        '
        'LabelMyrAddress
        '
        Me.LabelMyrAddress.AutoSize = True
        Me.LabelMyrAddress.Location = New System.Drawing.Point(116, 212)
        Me.LabelMyrAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMyrAddress.Name = "LabelMyrAddress"
        Me.LabelMyrAddress.Size = New System.Drawing.Size(142, 17)
        Me.LabelMyrAddress.TabIndex = 1
        Me.LabelMyrAddress.Text = "LNC Wallet Address :"
        '
        'LabelThreads
        '
        Me.LabelThreads.AutoSize = True
        Me.LabelThreads.Location = New System.Drawing.Point(161, 246)
        Me.LabelThreads.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelThreads.Name = "LabelThreads"
        Me.LabelThreads.Size = New System.Drawing.Size(92, 17)
        Me.LabelThreads.TabIndex = 2
        Me.LabelThreads.Text = "# of threads: "
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(125, 391)
        Me.ButtonStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(219, 28)
        Me.ButtonStart.TabIndex = 3
        Me.ButtonStart.Text = "Start Mining"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonStop
        '
        Me.ButtonStop.Location = New System.Drawing.Point(431, 391)
        Me.ButtonStop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(219, 28)
        Me.ButtonStop.TabIndex = 4
        Me.ButtonStop.Text = "Stop Mining"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'TextBoxPoolAddress
        '
        Me.TextBoxPoolAddress.Location = New System.Drawing.Point(268, 172)
        Me.TextBoxPoolAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxPoolAddress.Name = "TextBoxPoolAddress"
        Me.TextBoxPoolAddress.Size = New System.Drawing.Size(387, 22)
        Me.TextBoxPoolAddress.TabIndex = 5
        Me.TextBoxPoolAddress.Text = "stratum+tcp://pool.lightning-cash.com:6666"
        '
        'TextBoxMyrAddress
        '
        Me.TextBoxMyrAddress.Location = New System.Drawing.Point(268, 208)
        Me.TextBoxMyrAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxMyrAddress.Name = "TextBoxMyrAddress"
        Me.TextBoxMyrAddress.Size = New System.Drawing.Size(387, 22)
        Me.TextBoxMyrAddress.TabIndex = 6
        Me.TextBoxMyrAddress.Text = "MUfy6yWoaXPqpFJRUgpF2QfSxskxUZaSqe"
        '
        'TextBoxThreads
        '
        Me.TextBoxThreads.Location = New System.Drawing.Point(268, 242)
        Me.TextBoxThreads.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxThreads.Name = "TextBoxThreads"
        Me.TextBoxThreads.Size = New System.Drawing.Size(81, 22)
        Me.TextBoxThreads.TabIndex = 7
        Me.TextBoxThreads.Text = "2"
        '
        'BackgroundWorker1
        '
        '
        'LabelOutput
        '
        Me.LabelOutput.AutoSize = True
        Me.LabelOutput.Location = New System.Drawing.Point(13, 266)
        Me.LabelOutput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelOutput.Name = "LabelOutput"
        Me.LabelOutput.Size = New System.Drawing.Size(95, 17)
        Me.LabelOutput.TabIndex = 8
        Me.LabelOutput.Text = "Miner output: "
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOutput.Location = New System.Drawing.Point(16, 287)
        Me.TextBoxOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxOutput.Multiline = True
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.Size = New System.Drawing.Size(745, 96)
        Me.TextBoxOutput.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(125, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(524, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(779, 434)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBoxOutput)
        Me.Controls.Add(Me.LabelOutput)
        Me.Controls.Add(Me.TextBoxThreads)
        Me.Controls.Add(Me.TextBoxMyrAddress)
        Me.Controls.Add(Me.TextBoxPoolAddress)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.LabelThreads)
        Me.Controls.Add(Me.LabelMyrAddress)
        Me.Controls.Add(Me.LabelPoolAddress)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "LightningCash GUI Miner"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPoolAddress As Label
    Friend WithEvents LabelMyrAddress As Label
    Friend WithEvents LabelThreads As Label
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonStop As Button
    Friend WithEvents TextBoxPoolAddress As TextBox
    Friend WithEvents TextBoxMyrAddress As TextBox
    Friend WithEvents TextBoxThreads As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelOutput As Label
    Friend WithEvents TextBoxOutput As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
