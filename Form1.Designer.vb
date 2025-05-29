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
        Me.pnlIn = New System.Windows.Forms.Panel()
        Me.btnZOut = New System.Windows.Forms.Button()
        Me.btnZIn = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPlot = New System.Windows.Forms.Button()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.lblAmp = New System.Windows.Forms.Label()
        Me.txtAmp = New System.Windows.Forms.TextBox()
        Me.pnlOut = New System.Windows.Forms.Panel()
        Me.picOut = New System.Windows.Forms.PictureBox()
        Me.pnlIn.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.pnlOut.SuspendLayout()
        CType(Me.picOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlIn
        '
        Me.pnlIn.Controls.Add(Me.btnZOut)
        Me.pnlIn.Controls.Add(Me.btnZIn)
        Me.pnlIn.Controls.Add(Me.btnReset)
        Me.pnlIn.Controls.Add(Me.btnPlot)
        Me.pnlIn.Controls.Add(Me.grpInput)
        Me.pnlIn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlIn.Location = New System.Drawing.Point(0, 253)
        Me.pnlIn.Name = "pnlIn"
        Me.pnlIn.Size = New System.Drawing.Size(532, 100)
        Me.pnlIn.TabIndex = 0
        '
        'btnZOut
        '
        Me.btnZOut.Location = New System.Drawing.Point(414, 48)
        Me.btnZOut.Name = "btnZOut"
        Me.btnZOut.Size = New System.Drawing.Size(75, 32)
        Me.btnZOut.TabIndex = 4
        Me.btnZOut.Text = "Z&oom -"
        Me.btnZOut.UseVisualStyleBackColor = True
        '
        'btnZIn
        '
        Me.btnZIn.Location = New System.Drawing.Point(414, 10)
        Me.btnZIn.Name = "btnZIn"
        Me.btnZIn.Size = New System.Drawing.Size(75, 32)
        Me.btnZIn.TabIndex = 3
        Me.btnZIn.Text = "&Zoom +"
        Me.btnZIn.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(305, 48)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 32)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPlot
        '
        Me.btnPlot.Location = New System.Drawing.Point(305, 10)
        Me.btnPlot.Name = "btnPlot"
        Me.btnPlot.Size = New System.Drawing.Size(75, 32)
        Me.btnPlot.TabIndex = 1
        Me.btnPlot.Text = "&Plot"
        Me.btnPlot.UseVisualStyleBackColor = True
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.lblAmp)
        Me.grpInput.Controls.Add(Me.txtAmp)
        Me.grpInput.Location = New System.Drawing.Point(34, 10)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(232, 74)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input:"
        '
        'lblAmp
        '
        Me.lblAmp.AutoSize = True
        Me.lblAmp.Location = New System.Drawing.Point(6, 37)
        Me.lblAmp.Name = "lblAmp"
        Me.lblAmp.Size = New System.Drawing.Size(85, 16)
        Me.lblAmp.TabIndex = 1
        Me.lblAmp.Text = "Amplitude, A:"
        '
        'txtAmp
        '
        Me.txtAmp.Location = New System.Drawing.Point(97, 34)
        Me.txtAmp.Name = "txtAmp"
        Me.txtAmp.Size = New System.Drawing.Size(129, 22)
        Me.txtAmp.TabIndex = 0
        '
        'pnlOut
        '
        Me.pnlOut.Controls.Add(Me.picOut)
        Me.pnlOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOut.Location = New System.Drawing.Point(0, 0)
        Me.pnlOut.Name = "pnlOut"
        Me.pnlOut.Size = New System.Drawing.Size(532, 253)
        Me.pnlOut.TabIndex = 1
        '
        'picOut
        '
        Me.picOut.BackColor = System.Drawing.SystemColors.Desktop
        Me.picOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picOut.Location = New System.Drawing.Point(0, 0)
        Me.picOut.Name = "picOut"
        Me.picOut.Size = New System.Drawing.Size(532, 253)
        Me.picOut.TabIndex = 0
        Me.picOut.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnPlot
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(532, 353)
        Me.Controls.Add(Me.pnlOut)
        Me.Controls.Add(Me.pnlIn)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sine and Cosine Plotter"
        Me.pnlIn.ResumeLayout(False)
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.pnlOut.ResumeLayout(False)
        CType(Me.picOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlIn As Panel
    Friend WithEvents btnZOut As Button
    Friend WithEvents btnZIn As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPlot As Button
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents lblAmp As Label
    Friend WithEvents txtAmp As TextBox
    Friend WithEvents pnlOut As Panel
    Friend WithEvents picOut As PictureBox
End Class
